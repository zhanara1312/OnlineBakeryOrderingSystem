#pragma checksum "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "363c821017afc77d12fdf98c51ea371fcc5005d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bakeries_Index), @"mvc.1.0.view", @"/Views/Bakeries/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bakeries/Index.cshtml", typeof(AspNetCore.Views_Bakeries_Index))]
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
#line 1 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\_ViewImports.cshtml"
using BakeryUI;

#line default
#line hidden
#line 2 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\_ViewImports.cshtml"
using BakeryUI.Models;

#line default
#line hidden
#line 4 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\_ViewImports.cshtml"
using OnlineBakeryOrderingSystem;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"363c821017afc77d12fdf98c51ea371fcc5005d3", @"/Views/Bakeries/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"893b6de201680f95aa27ed6f25e3ae7709b2f18e", @"/Views/_ViewImports.cshtml")]
    public class Views_Bakeries_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineBakeryOrderingSystem.Bakery>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Transaction", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(98, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(127, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "418b699bb17846b281db71341707e4a3", async() => {
                BeginContext(150, 10, true);
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
            BeginContext(164, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(257, 49, false);
#line 16 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BakeryProduct));

#line default
#line hidden
            EndContext();
            BeginContext(306, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(362, 45, false);
#line 19 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ItemPrice));

#line default
#line hidden
            EndContext();
            BeginContext(407, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(463, 48, false);
#line 22 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(511, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(567, 51, false);
#line 25 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerAddress));

#line default
#line hidden
            EndContext();
            BeginContext(618, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(674, 56, false);
#line 28 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerEmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(730, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(786, 61, false);
#line 31 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerBankAccountNumber));

#line default
#line hidden
            EndContext();
            BeginContext(847, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(903, 49, false);
#line 34 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NumberOfOrder));

#line default
#line hidden
            EndContext();
            BeginContext(952, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1008, 40, false);
#line 37 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1048, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 43 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1166, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1215, 48, false);
#line 46 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BakeryProduct));

#line default
#line hidden
            EndContext();
            BeginContext(1263, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1319, 44, false);
#line 49 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ItemPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1363, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1419, 47, false);
#line 52 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(1466, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1522, 50, false);
#line 55 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1572, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1628, 55, false);
#line 58 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerEmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1683, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1739, 60, false);
#line 61 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerBankAccountNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1799, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1855, 48, false);
#line 64 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NumberOfOrder));

#line default
#line hidden
            EndContext();
            BeginContext(1903, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1959, 39, false);
#line 67 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1998, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2053, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05ffc6e49191473496374e51e33ecfbb", async() => {
                BeginContext(2110, 4, true);
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
#line 70 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Index.cshtml"
                                       WriteLiteral(item.CustomerNumber);

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
            BeginContext(2118, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2138, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fb739983a674afc9d0e05e8d196bfea", async() => {
                BeginContext(2198, 7, true);
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
#line 71 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Index.cshtml"
                                          WriteLiteral(item.CustomerNumber);

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
            BeginContext(2209, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2229, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "011b9a03306a443d8b9ad3650aef340e", async() => {
                BeginContext(2287, 5, true);
                WriteLiteral("Order");
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
#line 72 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Index.cshtml"
                                        WriteLiteral(item.CustomerNumber);

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
            BeginContext(2296, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2314, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a30a4d8310c482e8f8db8d5818bd209", async() => {
                BeginContext(2378, 11, true);
                WriteLiteral("Transaction");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 73 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Index.cshtml"
                                              WriteLiteral(item.CustomerNumber);

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
            BeginContext(2393, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 76 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2432, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineBakeryOrderingSystem.Bakery>> Html { get; private set; }
    }
}
#pragma warning restore 1591
