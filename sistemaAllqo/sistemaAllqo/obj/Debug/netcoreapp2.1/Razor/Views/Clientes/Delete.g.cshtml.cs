#pragma checksum "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77379e8c6e88686157d87cb691bfdce96b701aba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_Delete), @"mvc.1.0.view", @"/Views/Clientes/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clientes/Delete.cshtml", typeof(AspNetCore.Views_Clientes_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77379e8c6e88686157d87cb691bfdce96b701aba", @"/Views/Clientes/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f68deafed217cd279787deb9ae9337a82d72b6b", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistemaAllqo.Models.Cliente>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(127, 168, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Cliente</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(296, 43, false);
#line 16 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.nombres));

#line default
#line hidden
            EndContext();
            BeginContext(339, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(383, 39, false);
#line 19 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.nombres));

#line default
#line hidden
            EndContext();
            BeginContext(422, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(466, 45, false);
#line 22 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.apellidos));

#line default
#line hidden
            EndContext();
            BeginContext(511, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(555, 41, false);
#line 25 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.apellidos));

#line default
#line hidden
            EndContext();
            BeginContext(596, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(640, 45, false);
#line 28 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.direccion));

#line default
#line hidden
            EndContext();
            BeginContext(685, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(729, 41, false);
#line 31 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.direccion));

#line default
#line hidden
            EndContext();
            BeginContext(770, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(814, 39, false);
#line 34 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.dni));

#line default
#line hidden
            EndContext();
            BeginContext(853, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(897, 35, false);
#line 37 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.dni));

#line default
#line hidden
            EndContext();
            BeginContext(932, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(976, 42, false);
#line 40 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.correo));

#line default
#line hidden
            EndContext();
            BeginContext(1018, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1062, 38, false);
#line 43 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.correo));

#line default
#line hidden
            EndContext();
            BeginContext(1100, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1144, 46, false);
#line 46 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.numCelular));

#line default
#line hidden
            EndContext();
            BeginContext(1190, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1234, 42, false);
#line 49 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.numCelular));

#line default
#line hidden
            EndContext();
            BeginContext(1276, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1320, 42, false);
#line 52 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.estado));

#line default
#line hidden
            EndContext();
            BeginContext(1362, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1406, 38, false);
#line 55 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.estado));

#line default
#line hidden
            EndContext();
            BeginContext(1444, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1488, 41, false);
#line 58 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.lugar));

#line default
#line hidden
            EndContext();
            BeginContext(1529, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1573, 45, false);
#line 61 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.lugar.idLugar));

#line default
#line hidden
            EndContext();
            BeginContext(1618, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1656, 214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "524edeab14dd40b187f0145b37fc4a7b", async() => {
                BeginContext(1682, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1692, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5015faa13aa6450f9fcc1ec9335bfd03", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 66 "C:\Users\Emperatriz\Desktop\ALLQO PROGRA\sistemaAllqo\sistemaAllqo\Views\Clientes\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.idCliente);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1735, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1819, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d34a5460db1404da2d2f2136fa14787", async() => {
                    BeginContext(1841, 12, true);
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
                BeginContext(1857, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1870, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistemaAllqo.Models.Cliente> Html { get; private set; }
    }
}
#pragma warning restore 1591