#pragma checksum "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bebde460034e5a488ceb01cf6117604ae1b84fc"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bebde460034e5a488ceb01cf6117604ae1b84fc", @"/Views/Clientes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f68deafed217cd279787deb9ae9337a82d72b6b", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<sistemaAllqo.Models.Cliente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5fcf05ed8184c5eb1a60c5770a067f3", async() => {
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
            BeginContext(205, 168, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table table-hover table-striped table-responsive text-center\">\r\n    <thead>\r\n        <tr >\r\n            <th class=\"text-center\">\r\n                ");
            EndContext();
            BeginContext(374, 43, false);
#line 17 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.nombres));

#line default
#line hidden
            EndContext();
            BeginContext(417, 75, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-center\">\r\n                ");
            EndContext();
            BeginContext(493, 45, false);
#line 20 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.apellidos));

#line default
#line hidden
            EndContext();
            BeginContext(538, 75, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-center\">\r\n                ");
            EndContext();
            BeginContext(614, 45, false);
#line 23 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.direccion));

#line default
#line hidden
            EndContext();
            BeginContext(659, 75, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-center\">\r\n                ");
            EndContext();
            BeginContext(735, 39, false);
#line 26 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.dni));

#line default
#line hidden
            EndContext();
            BeginContext(774, 75, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-center\">\r\n                ");
            EndContext();
            BeginContext(850, 42, false);
#line 29 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.correo));

#line default
#line hidden
            EndContext();
            BeginContext(892, 75, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-center\">\r\n                ");
            EndContext();
            BeginContext(968, 46, false);
#line 32 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.numCelular));

#line default
#line hidden
            EndContext();
            BeginContext(1014, 75, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-center\">\r\n                ");
            EndContext();
            BeginContext(1090, 42, false);
#line 35 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.estado));

#line default
#line hidden
            EndContext();
            BeginContext(1132, 75, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-center\">\r\n                ");
            EndContext();
            BeginContext(1208, 41, false);
#line 38 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.lugar));

#line default
#line hidden
            EndContext();
            BeginContext(1249, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 44 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1367, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1416, 42, false);
#line 47 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.nombres));

#line default
#line hidden
            EndContext();
            BeginContext(1458, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1514, 44, false);
#line 50 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.apellidos));

#line default
#line hidden
            EndContext();
            BeginContext(1558, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1614, 44, false);
#line 53 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.direccion));

#line default
#line hidden
            EndContext();
            BeginContext(1658, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1714, 38, false);
#line 56 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.dni));

#line default
#line hidden
            EndContext();
            BeginContext(1752, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1808, 41, false);
#line 59 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.correo));

#line default
#line hidden
            EndContext();
            BeginContext(1849, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1905, 45, false);
#line 62 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.numCelular));

#line default
#line hidden
            EndContext();
            BeginContext(1950, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2006, 41, false);
#line 65 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.estado));

#line default
#line hidden
            EndContext();
            BeginContext(2047, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2105, 47, false);
#line 69 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.lugar.nombre));

#line default
#line hidden
            EndContext();
            BeginContext(2152, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2207, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6beb395d0db945f9860f8aa3a8c866d7", async() => {
                BeginContext(2259, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
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
            BeginContext(2267, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2287, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cab25d7cab044d45b99a2a6670c986a5", async() => {
                BeginContext(2342, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 73 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
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
            BeginContext(2353, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2373, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9657f6f9a6e748c38141e0284a2332e7", async() => {
                BeginContext(2427, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 74 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
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
            BeginContext(2437, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 77 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2476, 24, true);
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
