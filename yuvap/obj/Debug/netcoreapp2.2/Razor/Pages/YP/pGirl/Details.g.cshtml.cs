#pragma checksum "/Users/admin/NSB/yuvap/Pages/YP/pGirl/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3559521ae6535da47d872434f288513f50f4a68a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(yuvap.Pages.YP.pGirl.Pages_YP_pGirl_Details), @"mvc.1.0.razor-page", @"/Pages/YP/pGirl/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/YP/pGirl/Details.cshtml", typeof(yuvap.Pages.YP.pGirl.Pages_YP_pGirl_Details), null)]
namespace yuvap.Pages.YP.pGirl
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/admin/NSB/yuvap/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/Users/admin/NSB/yuvap/Pages/_ViewImports.cshtml"
using yuvap;

#line default
#line hidden
#line 3 "/Users/admin/NSB/yuvap/Pages/_ViewImports.cshtml"
using yuvap.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3559521ae6535da47d872434f288513f50f4a68a", @"/Pages/YP/pGirl/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6995f1c8a2970a40cad8635013e8b548f6f04a53", @"/Pages/_ViewImports.cshtml")]
    public class Pages_YP_pGirl_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "/Users/admin/NSB/yuvap/Pages/YP/pGirl/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(94, 125, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Girl</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(220, 45, false);
#line 15 "/Users/admin/NSB/yuvap/Pages/YP/pGirl/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Girl.Name));

#line default
#line hidden
            EndContext();
            BeginContext(265, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(327, 41, false);
#line 18 "/Users/admin/NSB/yuvap/Pages/YP/pGirl/Details.cshtml"
       Write(Html.DisplayFor(model => model.Girl.Name));

#line default
#line hidden
            EndContext();
            BeginContext(368, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(429, 50, false);
#line 21 "/Users/admin/NSB/yuvap/Pages/YP/pGirl/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Girl.MobileNum));

#line default
#line hidden
            EndContext();
            BeginContext(479, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(541, 46, false);
#line 24 "/Users/admin/NSB/yuvap/Pages/YP/pGirl/Details.cshtml"
       Write(Html.DisplayFor(model => model.Girl.MobileNum));

#line default
#line hidden
            EndContext();
            BeginContext(587, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(648, 46, false);
#line 27 "/Users/admin/NSB/yuvap/Pages/YP/pGirl/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Girl.Pref1));

#line default
#line hidden
            EndContext();
            BeginContext(694, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(756, 42, false);
#line 30 "/Users/admin/NSB/yuvap/Pages/YP/pGirl/Details.cshtml"
       Write(Html.DisplayFor(model => model.Girl.Pref1));

#line default
#line hidden
            EndContext();
            BeginContext(798, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(859, 46, false);
#line 33 "/Users/admin/NSB/yuvap/Pages/YP/pGirl/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Girl.Pref2));

#line default
#line hidden
            EndContext();
            BeginContext(905, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(967, 42, false);
#line 36 "/Users/admin/NSB/yuvap/Pages/YP/pGirl/Details.cshtml"
       Write(Html.DisplayFor(model => model.Girl.Pref2));

#line default
#line hidden
            EndContext();
            BeginContext(1009, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1070, 46, false);
#line 39 "/Users/admin/NSB/yuvap/Pages/YP/pGirl/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Girl.Pref3));

#line default
#line hidden
            EndContext();
            BeginContext(1116, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1178, 42, false);
#line 42 "/Users/admin/NSB/yuvap/Pages/YP/pGirl/Details.cshtml"
       Write(Html.DisplayFor(model => model.Girl.Pref3));

#line default
#line hidden
            EndContext();
            BeginContext(1220, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1281, 46, false);
#line 45 "/Users/admin/NSB/yuvap/Pages/YP/pGirl/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Girl.Pref4));

#line default
#line hidden
            EndContext();
            BeginContext(1327, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1389, 42, false);
#line 48 "/Users/admin/NSB/yuvap/Pages/YP/pGirl/Details.cshtml"
       Write(Html.DisplayFor(model => model.Girl.Pref4));

#line default
#line hidden
            EndContext();
            BeginContext(1431, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1492, 46, false);
#line 51 "/Users/admin/NSB/yuvap/Pages/YP/pGirl/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Girl.Pref5));

#line default
#line hidden
            EndContext();
            BeginContext(1538, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1600, 42, false);
#line 54 "/Users/admin/NSB/yuvap/Pages/YP/pGirl/Details.cshtml"
       Write(Html.DisplayFor(model => model.Girl.Pref5));

#line default
#line hidden
            EndContext();
            BeginContext(1642, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1703, 46, false);
#line 57 "/Users/admin/NSB/yuvap/Pages/YP/pGirl/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Girl.Pref6));

#line default
#line hidden
            EndContext();
            BeginContext(1749, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1811, 42, false);
#line 60 "/Users/admin/NSB/yuvap/Pages/YP/pGirl/Details.cshtml"
       Write(Html.DisplayFor(model => model.Girl.Pref6));

#line default
#line hidden
            EndContext();
            BeginContext(1853, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1914, 46, false);
#line 63 "/Users/admin/NSB/yuvap/Pages/YP/pGirl/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Girl.Pref7));

#line default
#line hidden
            EndContext();
            BeginContext(1960, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2022, 42, false);
#line 66 "/Users/admin/NSB/yuvap/Pages/YP/pGirl/Details.cshtml"
       Write(Html.DisplayFor(model => model.Girl.Pref7));

#line default
#line hidden
            EndContext();
            BeginContext(2064, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2125, 46, false);
#line 69 "/Users/admin/NSB/yuvap/Pages/YP/pGirl/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Girl.Pref8));

#line default
#line hidden
            EndContext();
            BeginContext(2171, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2233, 42, false);
#line 72 "/Users/admin/NSB/yuvap/Pages/YP/pGirl/Details.cshtml"
       Write(Html.DisplayFor(model => model.Girl.Pref8));

#line default
#line hidden
            EndContext();
            BeginContext(2275, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2336, 58, false);
#line 75 "/Users/admin/NSB/yuvap/Pages/YP/pGirl/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Girl.GirlLikedByConcat));

#line default
#line hidden
            EndContext();
            BeginContext(2394, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2456, 54, false);
#line 78 "/Users/admin/NSB/yuvap/Pages/YP/pGirl/Details.cshtml"
       Write(Html.DisplayFor(model => model.Girl.GirlLikedByConcat));

#line default
#line hidden
            EndContext();
            BeginContext(2510, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2557, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3559521ae6535da47d872434f288513f50f4a68a12714", async() => {
                BeginContext(2612, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 83 "/Users/admin/NSB/yuvap/Pages/YP/pGirl/Details.cshtml"
                           WriteLiteral(Model.Girl.GirlID);

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
            BeginContext(2620, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2628, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3559521ae6535da47d872434f288513f50f4a68a14981", async() => {
                BeginContext(2650, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2666, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<yuvap.Pages.YP.pGirl.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<yuvap.Pages.YP.pGirl.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<yuvap.Pages.YP.pGirl.DetailsModel>)PageContext?.ViewData;
        public yuvap.Pages.YP.pGirl.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
