#pragma checksum "/Users/admin/NSB/yuvap/Pages/YP/pProcess/IndexBoy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ae0879dc864ea913faffbf7904020d5e5347fb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(yuvap.Pages.YP.pProcess.Pages_YP_pProcess_IndexBoy), @"mvc.1.0.razor-page", @"/Pages/YP/pProcess/IndexBoy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/YP/pProcess/IndexBoy.cshtml", typeof(yuvap.Pages.YP.pProcess.Pages_YP_pProcess_IndexBoy), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ae0879dc864ea913faffbf7904020d5e5347fb3", @"/Pages/YP/pProcess/IndexBoy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6995f1c8a2970a40cad8635013e8b548f6f04a53", @"/Pages/_ViewImports.cshtml")]
    public class Pages_YP_pProcess_IndexBoy : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/IndexBoy.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(97, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(126, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ae0879dc864ea913faffbf7904020d5e5347fb34714", async() => {
                BeginContext(147, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(161, 135, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Reg-No</th>\r\n            \r\n            <th>\r\n                ");
            EndContext();
            BeginContext(297, 47, false);
#line 19 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/IndexBoy.cshtml"
           Write(Html.DisplayNameFor(model => model.Boy[0].Name));

#line default
#line hidden
            EndContext();
            BeginContext(344, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(400, 52, false);
#line 22 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/IndexBoy.cshtml"
           Write(Html.DisplayNameFor(model => model.Boy[0].MobileNum));

#line default
#line hidden
            EndContext();
            BeginContext(452, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(508, 48, false);
#line 25 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/IndexBoy.cshtml"
           Write(Html.DisplayNameFor(model => model.Boy[0].Pref1));

#line default
#line hidden
            EndContext();
            BeginContext(556, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(612, 48, false);
#line 28 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/IndexBoy.cshtml"
           Write(Html.DisplayNameFor(model => model.Boy[0].Pref2));

#line default
#line hidden
            EndContext();
            BeginContext(660, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(716, 48, false);
#line 31 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/IndexBoy.cshtml"
           Write(Html.DisplayNameFor(model => model.Boy[0].Pref3));

#line default
#line hidden
            EndContext();
            BeginContext(764, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(820, 48, false);
#line 34 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/IndexBoy.cshtml"
           Write(Html.DisplayNameFor(model => model.Boy[0].Pref4));

#line default
#line hidden
            EndContext();
            BeginContext(868, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(924, 48, false);
#line 37 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/IndexBoy.cshtml"
           Write(Html.DisplayNameFor(model => model.Boy[0].Pref5));

#line default
#line hidden
            EndContext();
            BeginContext(972, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1028, 48, false);
#line 40 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/IndexBoy.cshtml"
           Write(Html.DisplayNameFor(model => model.Boy[0].Pref6));

#line default
#line hidden
            EndContext();
            BeginContext(1076, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1132, 48, false);
#line 43 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/IndexBoy.cshtml"
           Write(Html.DisplayNameFor(model => model.Boy[0].Pref7));

#line default
#line hidden
            EndContext();
            BeginContext(1180, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1236, 48, false);
#line 46 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/IndexBoy.cshtml"
           Write(Html.DisplayNameFor(model => model.Boy[0].Pref8));

#line default
#line hidden
            EndContext();
            BeginContext(1284, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 52 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/IndexBoy.cshtml"
 foreach (var item in Model.Boy) {

#line default
#line hidden
            BeginContext(1406, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1455, 40, false);
#line 55 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/IndexBoy.cshtml"
           Write(Html.DisplayFor(modelItem => item.BoyID));

#line default
#line hidden
            EndContext();
            BeginContext(1495, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1551, 39, false);
#line 58 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/IndexBoy.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1590, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1646, 44, false);
#line 61 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/IndexBoy.cshtml"
           Write(Html.DisplayFor(modelItem => item.MobileNum));

#line default
#line hidden
            EndContext();
            BeginContext(1690, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1746, 40, false);
#line 64 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/IndexBoy.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pref1));

#line default
#line hidden
            EndContext();
            BeginContext(1786, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1842, 40, false);
#line 67 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/IndexBoy.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pref2));

#line default
#line hidden
            EndContext();
            BeginContext(1882, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1938, 40, false);
#line 70 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/IndexBoy.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pref3));

#line default
#line hidden
            EndContext();
            BeginContext(1978, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2034, 40, false);
#line 73 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/IndexBoy.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pref4));

#line default
#line hidden
            EndContext();
            BeginContext(2074, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2130, 40, false);
#line 76 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/IndexBoy.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pref5));

#line default
#line hidden
            EndContext();
            BeginContext(2170, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2226, 40, false);
#line 79 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/IndexBoy.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pref6));

#line default
#line hidden
            EndContext();
            BeginContext(2266, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2322, 40, false);
#line 82 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/IndexBoy.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pref7));

#line default
#line hidden
            EndContext();
            BeginContext(2362, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2418, 40, false);
#line 85 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/IndexBoy.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pref8));

#line default
#line hidden
            EndContext();
            BeginContext(2458, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2514, 51, false);
#line 88 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/IndexBoy.cshtml"
           Write(Html.DisplayFor(modelItem => item.BoyLikedByConcat));

#line default
#line hidden
            EndContext();
            BeginContext(2565, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2620, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ae0879dc864ea913faffbf7904020d5e5347fb315066", async() => {
                BeginContext(2668, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 91 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/IndexBoy.cshtml"
                                       WriteLiteral(item.BoyID);

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
            BeginContext(2676, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2696, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ae0879dc864ea913faffbf7904020d5e5347fb317355", async() => {
                BeginContext(2747, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 92 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/IndexBoy.cshtml"
                                          WriteLiteral(item.BoyID);

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
            BeginContext(2758, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2778, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ae0879dc864ea913faffbf7904020d5e5347fb319650", async() => {
                BeginContext(2828, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 93 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/IndexBoy.cshtml"
                                         WriteLiteral(item.BoyID);

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
            BeginContext(2838, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 96 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/IndexBoy.cshtml"
}

#line default
#line hidden
            BeginContext(2877, 50, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<br/>\r\n\r\n\r\n               ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<yuvap.Pages.YP.pProcess.IndexBoyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<yuvap.Pages.YP.pProcess.IndexBoyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<yuvap.Pages.YP.pProcess.IndexBoyModel>)PageContext?.ViewData;
        public yuvap.Pages.YP.pProcess.IndexBoyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
