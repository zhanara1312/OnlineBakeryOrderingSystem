#pragma checksum "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "152bdac5a0bbc5232201d586e17eb1eeb8965e1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bakeries_Details), @"mvc.1.0.view", @"/Views/Bakeries/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bakeries/Details.cshtml", typeof(AspNetCore.Views_Bakeries_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"152bdac5a0bbc5232201d586e17eb1eeb8965e1a", @"/Views/Bakeries/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"893b6de201680f95aa27ed6f25e3ae7709b2f18e", @"/Views/_ViewImports.cshtml")]
    public class Views_Bakeries_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineBakeryOrderingSystem.Bakery>
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
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(87, 120, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Bakery</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(208, 49, false);
#line 14 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BakeryProduct));

#line default
#line hidden
            EndContext();
            BeginContext(257, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(301, 45, false);
#line 17 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Details.cshtml"
       Write(Html.DisplayFor(model => model.BakeryProduct));

#line default
#line hidden
            EndContext();
            BeginContext(346, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(390, 45, false);
#line 20 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemPrice));

#line default
#line hidden
            EndContext();
            BeginContext(435, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(479, 41, false);
#line 23 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Details.cshtml"
       Write(Html.DisplayFor(model => model.ItemPrice));

#line default
#line hidden
            EndContext();
            BeginContext(520, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(564, 48, false);
#line 26 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(612, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(656, 44, false);
#line 29 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(700, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(744, 51, false);
#line 32 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerAddress));

#line default
#line hidden
            EndContext();
            BeginContext(795, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(839, 47, false);
#line 35 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerAddress));

#line default
#line hidden
            EndContext();
            BeginContext(886, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(930, 56, false);
#line 38 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerEmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(986, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1030, 52, false);
#line 41 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerEmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1082, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1126, 61, false);
#line 44 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerBankAccountNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1187, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1231, 57, false);
#line 47 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerBankAccountNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1288, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1332, 49, false);
#line 50 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumberOfOrder));

#line default
#line hidden
            EndContext();
            BeginContext(1381, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1425, 45, false);
#line 53 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumberOfOrder));

#line default
#line hidden
            EndContext();
            BeginContext(1470, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1514, 40, false);
#line 56 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1554, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1598, 36, false);
#line 59 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Details.cshtml"
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1634, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1681, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6d222eb177648858aa058ccca2130c1", async() => {
                BeginContext(1739, 4, true);
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
#line 64 "C:\Zhanara\Kal academy\C#\Github\OnlBakeryOrdSystem\BakeryUI\Views\Bakeries\Details.cshtml"
                           WriteLiteral(Model.CustomerNumber);

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
            BeginContext(1747, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1755, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57102cd43bd946c586923ba0bc42498d", async() => {
                BeginContext(1777, 12, true);
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
            BeginContext(1793, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineBakeryOrderingSystem.Bakery> Html { get; private set; }
    }
}
#pragma warning restore 1591
