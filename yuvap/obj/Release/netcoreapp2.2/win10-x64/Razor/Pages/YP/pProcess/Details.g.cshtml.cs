#pragma checksum "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pProcess/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df4a7f205a3642a10b4c90893bf6f880144b5b40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(yuvap.Pages.YP.pProcess.Pages_YP_pProcess_Details), @"mvc.1.0.razor-page", @"/Pages/YP/pProcess/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/YP/pProcess/Details.cshtml", typeof(yuvap.Pages.YP.pProcess.Pages_YP_pProcess_Details), null)]
namespace yuvap.Pages.YP.pProcess
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/admin/Yuvap4 Core22/yuvap/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/Users/admin/Yuvap4 Core22/yuvap/Pages/_ViewImports.cshtml"
using yuvap;

#line default
#line hidden
#line 3 "/Users/admin/Yuvap4 Core22/yuvap/Pages/_ViewImports.cshtml"
using yuvap.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df4a7f205a3642a10b4c90893bf6f880144b5b40", @"/Pages/YP/pProcess/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6995f1c8a2970a40cad8635013e8b548f6f04a53", @"/Pages/_ViewImports.cshtml")]
    public class Pages_YP_pProcess_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pProcess/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(97, 124, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Boy</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(222, 44, false);
#line 15 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pProcess/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Boy.Name));

#line default
#line hidden
            EndContext();
            BeginContext(266, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(328, 40, false);
#line 18 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pProcess/Details.cshtml"
       Write(Html.DisplayFor(model => model.Boy.Name));

#line default
#line hidden
            EndContext();
            BeginContext(368, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(429, 49, false);
#line 21 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pProcess/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Boy.MobileNum));

#line default
#line hidden
            EndContext();
            BeginContext(478, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(540, 45, false);
#line 24 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pProcess/Details.cshtml"
       Write(Html.DisplayFor(model => model.Boy.MobileNum));

#line default
#line hidden
            EndContext();
            BeginContext(585, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(646, 45, false);
#line 27 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pProcess/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Boy.Pref1));

#line default
#line hidden
            EndContext();
            BeginContext(691, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(753, 41, false);
#line 30 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pProcess/Details.cshtml"
       Write(Html.DisplayFor(model => model.Boy.Pref1));

#line default
#line hidden
            EndContext();
            BeginContext(794, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(855, 45, false);
#line 33 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pProcess/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Boy.Pref2));

#line default
#line hidden
            EndContext();
            BeginContext(900, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(962, 41, false);
#line 36 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pProcess/Details.cshtml"
       Write(Html.DisplayFor(model => model.Boy.Pref2));

#line default
#line hidden
            EndContext();
            BeginContext(1003, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1064, 45, false);
#line 39 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pProcess/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Boy.Pref3));

#line default
#line hidden
            EndContext();
            BeginContext(1109, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1171, 41, false);
#line 42 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pProcess/Details.cshtml"
       Write(Html.DisplayFor(model => model.Boy.Pref3));

#line default
#line hidden
            EndContext();
            BeginContext(1212, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1273, 45, false);
#line 45 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pProcess/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Boy.Pref4));

#line default
#line hidden
            EndContext();
            BeginContext(1318, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1380, 41, false);
#line 48 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pProcess/Details.cshtml"
       Write(Html.DisplayFor(model => model.Boy.Pref4));

#line default
#line hidden
            EndContext();
            BeginContext(1421, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1482, 45, false);
#line 51 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pProcess/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Boy.Pref5));

#line default
#line hidden
            EndContext();
            BeginContext(1527, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1589, 41, false);
#line 54 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pProcess/Details.cshtml"
       Write(Html.DisplayFor(model => model.Boy.Pref5));

#line default
#line hidden
            EndContext();
            BeginContext(1630, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1691, 45, false);
#line 57 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pProcess/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Boy.Pref6));

#line default
#line hidden
            EndContext();
            BeginContext(1736, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1798, 41, false);
#line 60 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pProcess/Details.cshtml"
       Write(Html.DisplayFor(model => model.Boy.Pref6));

#line default
#line hidden
            EndContext();
            BeginContext(1839, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1900, 45, false);
#line 63 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pProcess/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Boy.Pref7));

#line default
#line hidden
            EndContext();
            BeginContext(1945, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2007, 41, false);
#line 66 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pProcess/Details.cshtml"
       Write(Html.DisplayFor(model => model.Boy.Pref7));

#line default
#line hidden
            EndContext();
            BeginContext(2048, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2109, 45, false);
#line 69 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pProcess/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Boy.Pref8));

#line default
#line hidden
            EndContext();
            BeginContext(2154, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2216, 41, false);
#line 72 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pProcess/Details.cshtml"
       Write(Html.DisplayFor(model => model.Boy.Pref8));

#line default
#line hidden
            EndContext();
            BeginContext(2257, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2318, 56, false);
#line 75 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pProcess/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Boy.BoyLikedByConcat));

#line default
#line hidden
            EndContext();
            BeginContext(2374, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2436, 52, false);
#line 78 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pProcess/Details.cshtml"
       Write(Html.DisplayFor(model => model.Boy.BoyLikedByConcat));

#line default
#line hidden
            EndContext();
            BeginContext(2488, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2535, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df4a7f205a3642a10b4c90893bf6f880144b5b4013058", async() => {
                BeginContext(2588, 4, true);
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
#line 83 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pProcess/Details.cshtml"
                           WriteLiteral(Model.Boy.BoyID);

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
            BeginContext(2596, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2604, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df4a7f205a3642a10b4c90893bf6f880144b5b4015336", async() => {
                BeginContext(2626, 12, true);
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
            BeginContext(2642, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<yuvap.Pages.YP.pProcess.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<yuvap.Pages.YP.pProcess.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<yuvap.Pages.YP.pProcess.DetailsModel>)PageContext?.ViewData;
        public yuvap.Pages.YP.pProcess.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
