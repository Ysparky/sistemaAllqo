using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using sistemaAllqo.Data;
using sistemaAllqo.Models;

namespace sistemaAllqo.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly ApplicationDbContext _context;
        private readonly IEmailSender _emailSender;
        private readonly RoleManager<IdentityRole> _roleManager;

        public RegisterModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, ILogger<RegisterModel> logger,
            IEmailSender emailSender, ApplicationDbContext context)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "Este campo es obligatorio")]
            [EmailAddress]
            [Display(Name = "Correo")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Este campo es obligatorio")]
            [StringLength(25, ErrorMessage = "La {0} debe tener al menos {2} y como maximo {1} caracteres de largo.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Contraseña")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirmar contraseña")]
            [Compare("Password", ErrorMessage = "Contaseña y confirmar contraseña no coinciden.")]
            public string ConfirmPassword { get; set; }
            /*****************************************************************************************/
            [Display(Name = "Nombre")]
            [Required(ErrorMessage = "Este Campo es Obligatorio")]
            [RegularExpression("^[a-zA-ZñÑáéíóúÁÉÍÓÚ]*$", ErrorMessage = "* Solo se permiten letras.")]
            public string nom { get; set; }
            [Display(Name = "Apellidos")]
            [Required(ErrorMessage = "Este Campo es Obligatorio")]
            [RegularExpression("^[a-zA-ZñÑáéíóúÁÉÍÓÚ]*$", ErrorMessage = "* Solo se permiten letras.")]
            public string ape { get; set; }
            [Display(Name = "DNI")]
            [Required(ErrorMessage = "Este Campo es Obligatorio")]
            [Range(10000000, 99999999, ErrorMessage = "Campo valido de 8 digitos")]
            [RegularExpression("^[0-9]*$", ErrorMessage = "* Solo se permiten números positivos.")]
            public int dni { get; set; }
            [Display(Name = "Celular")]
            [Required(ErrorMessage = "Este Campo es Obligatorio")]
            [Range(100000000, 999999999, ErrorMessage = "Campo valido de 9 digitos")]
            [RegularExpression("^[0-9]*$", ErrorMessage = "* Solo se permiten números positivos.")]
            public int cel { get; set; }
            [Display(Name = "Dirección")]
            [Required(ErrorMessage = "Este Campo es Obligatorio")]
            public string dir { get; set; }
        }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync([Bind("idTrabajador, nombres, apellidos,dni,numCel,direccion")] string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            if (ModelState.IsValid)
            {
                var worker = new Trabajador { dni = Input.dni, nombres = Input.nom, apellidos = Input.ape, numCel = Input.cel, direccion = Input.dir };
                _context.Add(worker);
                await _context.SaveChangesAsync();



                var user = new IdentityUser { UserName = Input.Email, Email = Input.Email, Id = Input.dni.ToString() };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { userId = user.Id, code = code },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    //await _signInManager.SignOutAsync();
                    return LocalRedirect(returnUrl);
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
