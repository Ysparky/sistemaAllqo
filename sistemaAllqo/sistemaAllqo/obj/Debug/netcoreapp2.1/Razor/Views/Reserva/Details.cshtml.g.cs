#pragma checksum "C:\Users\Usuario\Downloads\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Reserva\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba4463c4bc92fea7bedd990b549ab9483ae8ca5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reserva_Details), @"mvc.1.0.view", @"/Views/Reserva/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reserva/Details.cshtml", typeof(AspNetCore.Views_Reserva_Details))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Usuario\Downloads\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\_ViewImports.cshtml"
using sistemaAllqo;

#line default
#line hidden
#line 2 "C:\Users\Usuario\Downloads\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\_ViewImports.cshtml"
using sistemaAllqo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba4463c4bc92fea7bedd990b549ab9483ae8ca5c", @"/Views/Reserva/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f68deafed217cd279787deb9ae9337a82d72b6b", @"/Views/_ViewImports.cshtml")]
    public class Views_Reserva_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistemaAllqo.Models.Reserva>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Usuario\Downloads\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Reserva\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(128, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Reserva</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(250, 50, false);
#line 15 "C:\Users\Usuario\Downloads\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Reserva\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.fechaReservada));

#line default
#line hidden
            EndContext();
            BeginContext(300, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(344, 46, false);
#line 18 "C:\Users\Usuario\Downloads\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Reserva\Details.cshtml"
       Write(Html.DisplayFor(model => model.fechaReservada));

#line default
#line hidden
            EndContext();
            BeginContext(390, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(434, 47, false);
#line 21 "C:\Users\Usuario\Downloads\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Reserva\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.fechaSesion));

#line default
#line hidden
            EndContext();
            BeginContext(481, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(525, 43, false);
#line 24 "C:\Users\Usuario\Downloads\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Reserva\Details.cshtml"
       Write(Html.DisplayFor(model => model.fechaSesion));

#line default
#line hidden
            EndContext();
            BeginContext(568, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(612, 42, false);
#line 27 "C:\Users\Usuario\Downloads\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Reserva\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.estado));

#line default
#line hidden
            EndContext();
            BeginContext(654, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(698, 38, false);
#line 30 "C:\Users\Usuario\Downloads\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Reserva\Details.cshtml"
       Write(Html.DisplayFor(model => model.estado));

#line default
#line hidden
            EndContext();
            BeginContext(736, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(780, 43, false);
#line 33 "C:\Users\Usuario\Downloads\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Reserva\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.cliente));

#line default
#line hidden
            EndContext();
            BeginContext(823, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(867, 49, false);
#line 36 "C:\Users\Usuario\Downloads\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Reserva\Details.cshtml"
       Write(Html.DisplayFor(model => model.cliente.idCliente));

#line default
#line hidden
            EndContext();
            BeginContext(916, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(960, 44, false);
#line 39 "C:\Users\Usuario\Downloads\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Reserva\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.servicio));

#line default
#line hidden
            EndContext();
            BeginContext(1004, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1048, 51, false);
#line 42 "C:\Users\Usuario\Downloads\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Reserva\Details.cshtml"
       Write(Html.DisplayFor(model => model.servicio.idServicio));

#line default
#line hidden
            EndContext();
            BeginContext(1099, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1143, 46, false);
#line 45 "C:\Users\Usuario\Downloads\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Reserva\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.trabajador));

#line default
#line hidden
            EndContext();
            BeginContext(1189, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1233, 55, false);
#line 48 "C:\Users\Usuario\Downloads\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Reserva\Details.cshtml"
       Write(Html.DisplayFor(model => model.trabajador.idTrabajador));

#line default
#line hidden
            EndContext();
            BeginContext(1288, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1335, 62, false);
<<<<<<< HEAD:sistemaAllqo/sistemaAllqo/obj/Debug/netcoreapp2.1/Razor/Views/Reserva/Details.cshtml.g.cs
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fec1b327fd9143d49f1e437be5a7897a", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77092e2ddf6346489c90b878778f4105", async() => {
>>>>>>> 2fb3174d6ff52f2b40c23d6f211f3371579e1951:sistemaAllqo/sistemaAllqo/obj/Debug/netcoreapp2.1/Razor/Views/Reserva/Details.g.cshtml.cs
                BeginContext(1389, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\Usuario\Downloads\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Reserva\Details.cshtml"
                           WriteLiteral(Model.Reserva_ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1397, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1405, 38, false);
<<<<<<< HEAD:sistemaAllqo/sistemaAllqo/obj/Debug/netcoreapp2.1/Razor/Views/Reserva/Details.cshtml.g.cs
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e45328f0780041189e91f954178d6632", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04158edcb80748d699c4443e12f898f0", async() => {
>>>>>>> 2fb3174d6ff52f2b40c23d6f211f3371579e1951:sistemaAllqo/sistemaAllqo/obj/Debug/netcoreapp2.1/Razor/Views/Reserva/Details.g.cshtml.cs
                BeginContext(1427, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1443, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistemaAllqo.Models.Reserva> Html { get; private set; }
    }
}
#pragma warning restore 1591
