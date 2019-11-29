using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using sistemaAllqo.Models;

namespace sistemaAllqo.Controllers
{
    public class RolesController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;

        public RolesController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        //GET: Roles/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Roles/Create
        [HttpPost]
        public async Task<IActionResult> Create(Rol model)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.NrNombre
                };
                IdentityResult result = await _roleManager.CreateAsync(identityRole);
                if (result.Succeeded)
                {
                    return RedirectToAction("List", "Roles");
                }
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult List()
        {
            var roles = _roleManager.Roles;
            return View(roles);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Rol con Id = {id} no pudo ser encontrado";
                return View("NotFound");
            }
            var model = new Rol
            {
                Id = role.Id,
                NrNombre = role.Name
            };
            foreach (var user in _userManager.Users)
            {
                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    model.Usuarios.Add(user.UserName);
                }
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Rol model)
        {
            var role = await _roleManager.FindByIdAsync(model.Id);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Rol con Id = {model.Id} no pudo ser encontrado";
                return View("NotFound");
            }
            else
            {
                role.Name = model.NrNombre;
                var result = await _roleManager.UpdateAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("List");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> EditUsersInRole(string rolId)
        {
            ViewBag.roleId = rolId;
            var role = await _roleManager.FindByIdAsync(rolId);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Rol con Id = {rolId} no pudo ser encontrado";
                return View("NotFound");
            }
            var model = new List<Rol>();
            foreach (var user in _userManager.Users)
            {
                var usuarioRolViewModel = new Rol
                {
                    UsuarioId = user.Id,
                    NombreUsuario = user.UserName
                };
                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    usuarioRolViewModel.EsSelec = true;
                }
                else
                {
                    usuarioRolViewModel.EsSelec = false;
                }
                model.Add(usuarioRolViewModel);
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditUsersInRole(List<Rol> model, string rolId)
        {
            var role = await _roleManager.FindByIdAsync(rolId);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role con Id = {rolId} no puedo ser encontrado";
                return View("NotFound");
            }
            for (int i = 0; i < model.Count; i++)
            {
                var user = await _userManager.FindByIdAsync(model[i].UsuarioId);
                IdentityResult result = null;
                if (model[i].EsSelec && !(await _userManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await _userManager.AddToRoleAsync(user, role.Name);
                }
                else if (!model[i].EsSelec && await _userManager.IsInRoleAsync(user, role.Name))
                {
                    result = await _userManager.RemoveFromRoleAsync(user, role.Name);
                }
                else
                {
                    continue;
                }
                if (result.Succeeded)
                {
                    if (i < (model.Count - 1))
                        continue;
                    else
                        return RedirectToAction("Edit", new { Id = rolId });
                }
            }
            return RedirectToAction("Edit", new { Id = rolId });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Rol con Id = {id} no pudo ser encontrado";
                return View("NotFound");
            }
            else
            {
                var result = await _roleManager.DeleteAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("List");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View("List");
            }
        }
    }
}