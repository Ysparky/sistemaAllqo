#pragma checksum "E:\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Clientes\_Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84325aa7af1fbe0db72a04593e9781e75d53dadb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes__Index), @"mvc.1.0.view", @"/Views/Clientes/_Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clientes/_Index.cshtml", typeof(AspNetCore.Views_Clientes__Index))]
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
#line 1 "E:\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\_ViewImports.cshtml"
using sistemaAllqo;

#line default
#line hidden
#line 2 "E:\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\_ViewImports.cshtml"
using sistemaAllqo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84325aa7af1fbe0db72a04593e9781e75d53dadb", @"/Views/Clientes/_Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f68deafed217cd279787deb9ae9337a82d72b6b", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes__Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<sistemaAllqo.Models.Cliente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info text-wrap float-right mx-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn p-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(169, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "E:\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Clientes\_Index.cshtml"
   
    ViewData["Title"] = "Index";
    string color;

#line default
#line hidden
            BeginContext(232, 149, true);
            WriteLiteral("\r\n<div class=\"card shadow\">\r\n    <div class=\"card-header \">\r\n        <h3 class=\"m-0 font-weight-bold text-primary float-left\">CLIENTES</h3>\r\n        ");
            EndContext();
            BeginContext(381, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50e56de0a79a4d86808e462d31bd3daa", async() => {
                BeginContext(452, 15, true);
                WriteLiteral("Agregar Cliente");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            BeginContext(471, 277, true);
            WriteLiteral(@"
    </div>
    <div class=""card-body"">
        <div class=""container"">
            <table class="" table table-bordered text-center table-hover table-responsive"">
                <thead>
                    <tr>
                        <th>
                            ");
            EndContext();
            BeginContext(749, 39, false);
#line 21 "E:\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Clientes\_Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.dni));

#line default
#line hidden
            EndContext();
            BeginContext(788, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(880, 45, false);
#line 24 "E:\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Clientes\_Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.apellidos));

#line default
#line hidden
            EndContext();
            BeginContext(925, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1017, 43, false);
#line 27 "E:\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Clientes\_Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.nombres));

#line default
#line hidden
            EndContext();
            BeginContext(1060, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1152, 42, false);
#line 30 "E:\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Clientes\_Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.correo));

#line default
#line hidden
            EndContext();
            BeginContext(1194, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1286, 46, false);
#line 33 "E:\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Clientes\_Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.numCelular));

#line default
#line hidden
            EndContext();
            BeginContext(1332, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1424, 42, false);
#line 36 "E:\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Clientes\_Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.estado));

#line default
#line hidden
            EndContext();
            BeginContext(1466, 154, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>Opciones</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 42 "E:\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Clientes\_Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1693, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1790, 38, false);
#line 46 "E:\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Clientes\_Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.dni));

#line default
#line hidden
            EndContext();
            BeginContext(1828, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1932, 44, false);
#line 49 "E:\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Clientes\_Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.apellidos));

#line default
#line hidden
            EndContext();
            BeginContext(1976, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2080, 42, false);
#line 52 "E:\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Clientes\_Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.nombres));

#line default
#line hidden
            EndContext();
            BeginContext(2122, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2226, 41, false);
#line 55 "E:\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Clientes\_Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.correo));

#line default
#line hidden
            EndContext();
            BeginContext(2267, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2371, 45, false);
#line 58 "E:\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Clientes\_Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.numCelular));

#line default
#line hidden
            EndContext();
            BeginContext(2416, 71, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
            EndContext();
#line 61 "E:\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Clientes\_Index.cshtml"
                                 if (item.estado == "Registrado") { color = "bg-green"; } else { color = "bg-red"; }

#line default
#line hidden
            BeginContext(2605, 36, true);
            WriteLiteral("                                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2641, "\"", 2668, 2);
#line 62 "E:\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Clientes\_Index.cshtml"
WriteAttributeValue("", 2649, color, 2649, 6, false);

#line default
#line hidden
            WriteAttributeValue(" ", 2655, "rounded-pill", 2656, 13, true);
            EndWriteAttribute();
            BeginContext(2669, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2671, 41, false);
#line 62 "E:\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Clientes\_Index.cshtml"
                                                            Write(Html.DisplayFor(modelItem => item.estado));

#line default
#line hidden
            EndContext();
            BeginContext(2712, 109, true);
            WriteLiteral("</div>\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2821, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1393d49edf6b44ab8c8f0534700526d9", async() => {
                BeginContext(2889, 27, true);
                WriteLiteral("<i class=\"fas fa-edit\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "E:\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Clientes\_Index.cshtml"
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
            BeginContext(2920, 36, true);
            WriteLiteral(" |\r\n                                ");
            EndContext();
            BeginContext(2956, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8f64861b7934949952ac784c593b4a4", async() => {
                BeginContext(3027, 26, true);
                WriteLiteral("<i class=\"fas fa-eye\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 66 "E:\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Clientes\_Index.cshtml"
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
            BeginContext(3057, 36, true);
            WriteLiteral(" |\r\n                                ");
            EndContext();
            BeginContext(3093, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3315281254934058890d3e9b622065b7", async() => {
                BeginContext(3163, 32, true);
                WriteLiteral("<i class=\"fas fa-trash-alt\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 67 "E:\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Clientes\_Index.cshtml"
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
            BeginContext(3199, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 70 "E:\sistemaAllqo\sistemaAllqo\sistemaAllqo\Views\Clientes\_Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(3290, 84, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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