#pragma checksum "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pBoy/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3049ac6f628da00db46d9399d5fefdd7a4968a09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(yuvap.Pages.YP.pBoy.Pages_YP_pBoy_Index), @"mvc.1.0.razor-page", @"/Pages/YP/pBoy/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/YP/pBoy/Index.cshtml", typeof(yuvap.Pages.YP.pBoy.Pages_YP_pBoy_Index), null)]
namespace yuvap.Pages.YP.pBoy
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3049ac6f628da00db46d9399d5fefdd7a4968a09", @"/Pages/YP/pBoy/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6995f1c8a2970a40cad8635013e8b548f6f04a53", @"/Pages/_ViewImports.cshtml")]
    public class Pages_YP_pBoy_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pBoy/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(89, 34, true);
            WriteLiteral("\r\n<h3>Male Index</h3>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(123, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3049ac6f628da00db46d9399d5fefdd7a4968a094701", async() => {
                BeginContext(144, 10, true);
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
            BeginContext(158, 153, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Reg-No\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(312, 47, false);
#line 20 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pBoy/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Boy[0].Name));

#line default
#line hidden
            EndContext();
            BeginContext(359, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(415, 52, false);
#line 23 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pBoy/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Boy[0].MobileNum));

#line default
#line hidden
            EndContext();
            BeginContext(467, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(523, 48, false);
#line 26 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pBoy/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Boy[0].Pref1));

#line default
#line hidden
            EndContext();
            BeginContext(571, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(627, 48, false);
#line 29 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pBoy/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Boy[0].Pref2));

#line default
#line hidden
            EndContext();
            BeginContext(675, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(731, 48, false);
#line 32 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pBoy/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Boy[0].Pref3));

#line default
#line hidden
            EndContext();
            BeginContext(779, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(835, 48, false);
#line 35 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pBoy/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Boy[0].Pref4));

#line default
#line hidden
            EndContext();
            BeginContext(883, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(939, 48, false);
#line 38 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pBoy/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Boy[0].Pref5));

#line default
#line hidden
            EndContext();
            BeginContext(987, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1043, 48, false);
#line 41 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pBoy/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Boy[0].Pref6));

#line default
#line hidden
            EndContext();
            BeginContext(1091, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1147, 48, false);
#line 44 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pBoy/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Boy[0].Pref7));

#line default
#line hidden
            EndContext();
            BeginContext(1195, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1251, 48, false);
#line 47 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pBoy/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Boy[0].Pref8));

#line default
#line hidden
            EndContext();
            BeginContext(1299, 154, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Boy Liked By:\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 56 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pBoy/Index.cshtml"
 foreach (var item in Model.Boy) {

#line default
#line hidden
            BeginContext(1489, 47, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n               ");
            EndContext();
            BeginContext(1537, 40, false);
#line 59 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pBoy/Index.cshtml"
          Write(Html.DisplayFor(modelItem => item.BoyID));

#line default
#line hidden
            EndContext();
            BeginContext(1577, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1633, 39, false);
#line 62 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pBoy/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1672, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1728, 44, false);
#line 65 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pBoy/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MobileNum));

#line default
#line hidden
            EndContext();
            BeginContext(1772, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1828, 40, false);
#line 68 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pBoy/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pref1));

#line default
#line hidden
            EndContext();
            BeginContext(1868, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1924, 40, false);
#line 71 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pBoy/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pref2));

#line default
#line hidden
            EndContext();
            BeginContext(1964, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2020, 40, false);
#line 74 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pBoy/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pref3));

#line default
#line hidden
            EndContext();
            BeginContext(2060, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2116, 40, false);
#line 77 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pBoy/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pref4));

#line default
#line hidden
            EndContext();
            BeginContext(2156, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2212, 40, false);
#line 80 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pBoy/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pref5));

#line default
#line hidden
            EndContext();
            BeginContext(2252, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2308, 40, false);
#line 83 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pBoy/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pref6));

#line default
#line hidden
            EndContext();
            BeginContext(2348, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2404, 40, false);
#line 86 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pBoy/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pref7));

#line default
#line hidden
            EndContext();
            BeginContext(2444, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2500, 40, false);
#line 89 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pBoy/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pref8));

#line default
#line hidden
            EndContext();
            BeginContext(2540, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2596, 51, false);
#line 92 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pBoy/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BoyLikedByConcat));

#line default
#line hidden
            EndContext();
            BeginContext(2647, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2702, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3049ac6f628da00db46d9399d5fefdd7a4968a0915215", async() => {
                BeginContext(2750, 4, true);
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
#line 95 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pBoy/Index.cshtml"
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
            BeginContext(2778, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3049ac6f628da00db46d9399d5fefdd7a4968a0917507", async() => {
                BeginContext(2829, 7, true);
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
#line 96 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pBoy/Index.cshtml"
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
            BeginContext(2840, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2860, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3049ac6f628da00db46d9399d5fefdd7a4968a0919805", async() => {
                BeginContext(2910, 6, true);
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
#line 97 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pBoy/Index.cshtml"
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
            BeginContext(2920, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 100 "/Users/admin/Yuvap4 Core22/yuvap/Pages/YP/pBoy/Index.cshtml"
}

#line default
#line hidden
            BeginContext(2959, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<yuvap.Pages.YP.pBoy.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<yuvap.Pages.YP.pBoy.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<yuvap.Pages.YP.pBoy.IndexModel>)PageContext?.ViewData;
        public yuvap.Pages.YP.pBoy.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
