#pragma checksum "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e89bbd177968043e0f6d0f626c83ba83309dfd99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_Index), @"mvc.1.0.view", @"/Views/Clientes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clientes/Index.cshtml", typeof(AspNetCore.Views_Clientes_Index))]
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
#line 1 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\_ViewImports.cshtml"
using sistemaAllqo;

#line default
#line hidden
#line 2 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\_ViewImports.cshtml"
using sistemaAllqo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e89bbd177968043e0f6d0f626c83ba83309dfd99", @"/Views/Clientes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f68deafed217cd279787deb9ae9337a82d72b6b", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<sistemaAllqo.Models.Cliente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn p-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(139, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(168, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f62bc4f409c4460998c13ab81b639b6", async() => {
                BeginContext(191, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(205, 115, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table text-center\" id=\"tabla\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(321, 39, false);
#line 17 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.dni));

#line default
#line hidden
            EndContext();
            BeginContext(360, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(416, 45, false);
#line 20 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.apellidos));

#line default
#line hidden
            EndContext();
            BeginContext(461, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(517, 43, false);
#line 23 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.nombres));

#line default
#line hidden
            EndContext();
            BeginContext(560, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(616, 42, false);
#line 26 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.correo));

#line default
#line hidden
            EndContext();
            BeginContext(658, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(714, 46, false);
#line 29 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.numCelular));

#line default
#line hidden
            EndContext();
            BeginContext(760, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(816, 42, false);
#line 32 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.estado));

#line default
#line hidden
            EndContext();
            BeginContext(858, 94, true);
            WriteLiteral("\r\n            </th>\r\n            <th>Opciones</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 38 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(984, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1033, 38, false);
#line 41 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.dni));

#line default
#line hidden
            EndContext();
            BeginContext(1071, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1127, 44, false);
#line 44 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.apellidos));

#line default
#line hidden
            EndContext();
            BeginContext(1171, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1227, 42, false);
#line 47 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.nombres));

#line default
#line hidden
            EndContext();
            BeginContext(1269, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1325, 41, false);
#line 50 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.correo));

#line default
#line hidden
            EndContext();
            BeginContext(1366, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1422, 45, false);
#line 53 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.numCelular));

#line default
#line hidden
            EndContext();
            BeginContext(1467, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1523, 41, false);
#line 56 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.estado));

#line default
#line hidden
            EndContext();
            BeginContext(1564, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1619, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "570faafda29948d89079d7e4b0a0c81b", async() => {
                BeginContext(1687, 27, true);
                WriteLiteral("<i class=\"fas fa-edit\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
                                                       WriteLiteral(item.idCliente);

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
            BeginContext(1718, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1738, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4325d8ea2fd40369edfc91759504d71", async() => {
                BeginContext(1809, 26, true);
                WriteLiteral("<i class=\"fas fa-eye\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
                                                          WriteLiteral(item.idCliente);

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
            BeginContext(1839, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1859, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dc49de635a84b34bf1ff98bd0ed3357", async() => {
                BeginContext(1929, 32, true);
                WriteLiteral("<i class=\"fas fa-trash-alt\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
                                                         WriteLiteral(item.idCliente);

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
            BeginContext(1965, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 64 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2004, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<sistemaAllqo.Models.Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
