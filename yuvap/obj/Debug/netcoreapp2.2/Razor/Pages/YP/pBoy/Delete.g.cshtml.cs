#pragma checksum "/Users/admin/NSB/yuvap/Pages/YP/pBoy/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c44b37da945b35ad6502323968c8a04e3e54cd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(yuvap.Pages.YP.pBoy.Pages_YP_pBoy_Delete), @"mvc.1.0.razor-page", @"/Pages/YP/pBoy/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/YP/pBoy/Delete.cshtml", typeof(yuvap.Pages.YP.pBoy.Pages_YP_pBoy_Delete), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c44b37da945b35ad6502323968c8a04e3e54cd8", @"/Pages/YP/pBoy/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6995f1c8a2970a40cad8635013e8b548f6f04a53", @"/Pages/_ViewImports.cshtml")]
    public class Pages_YP_pBoy_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "/Users/admin/NSB/yuvap/Pages/YP/pBoy/Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(91, 171, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Boy</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(263, 44, false);
#line 16 "/Users/admin/NSB/yuvap/Pages/YP/pBoy/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Boy.Name));

#line default
#line hidden
            EndContext();
            BeginContext(307, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(369, 40, false);
#line 19 "/Users/admin/NSB/yuvap/Pages/YP/pBoy/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Boy.Name));

#line default
#line hidden
            EndContext();
            BeginContext(409, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(470, 49, false);
#line 22 "/Users/admin/NSB/yuvap/Pages/YP/pBoy/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Boy.MobileNum));

#line default
#line hidden
            EndContext();
            BeginContext(519, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(581, 45, false);
#line 25 "/Users/admin/NSB/yuvap/Pages/YP/pBoy/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Boy.MobileNum));

#line default
#line hidden
            EndContext();
            BeginContext(626, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(687, 45, false);
#line 28 "/Users/admin/NSB/yuvap/Pages/YP/pBoy/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Boy.Pref1));

#line default
#line hidden
            EndContext();
            BeginContext(732, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(794, 41, false);
#line 31 "/Users/admin/NSB/yuvap/Pages/YP/pBoy/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Boy.Pref1));

#line default
#line hidden
            EndContext();
            BeginContext(835, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(896, 45, false);
#line 34 "/Users/admin/NSB/yuvap/Pages/YP/pBoy/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Boy.Pref2));

#line default
#line hidden
            EndContext();
            BeginContext(941, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1003, 41, false);
#line 37 "/Users/admin/NSB/yuvap/Pages/YP/pBoy/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Boy.Pref2));

#line default
#line hidden
            EndContext();
            BeginContext(1044, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1105, 45, false);
#line 40 "/Users/admin/NSB/yuvap/Pages/YP/pBoy/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Boy.Pref3));

#line default
#line hidden
            EndContext();
            BeginContext(1150, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1212, 41, false);
#line 43 "/Users/admin/NSB/yuvap/Pages/YP/pBoy/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Boy.Pref3));

#line default
#line hidden
            EndContext();
            BeginContext(1253, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1314, 45, false);
#line 46 "/Users/admin/NSB/yuvap/Pages/YP/pBoy/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Boy.Pref4));

#line default
#line hidden
            EndContext();
            BeginContext(1359, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1421, 41, false);
#line 49 "/Users/admin/NSB/yuvap/Pages/YP/pBoy/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Boy.Pref4));

#line default
#line hidden
            EndContext();
            BeginContext(1462, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1523, 45, false);
#line 52 "/Users/admin/NSB/yuvap/Pages/YP/pBoy/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Boy.Pref5));

#line default
#line hidden
            EndContext();
            BeginContext(1568, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1630, 41, false);
#line 55 "/Users/admin/NSB/yuvap/Pages/YP/pBoy/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Boy.Pref5));

#line default
#line hidden
            EndContext();
            BeginContext(1671, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1732, 45, false);
#line 58 "/Users/admin/NSB/yuvap/Pages/YP/pBoy/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Boy.Pref6));

#line default
#line hidden
            EndContext();
            BeginContext(1777, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1839, 41, false);
#line 61 "/Users/admin/NSB/yuvap/Pages/YP/pBoy/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Boy.Pref6));

#line default
#line hidden
            EndContext();
            BeginContext(1880, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1941, 45, false);
#line 64 "/Users/admin/NSB/yuvap/Pages/YP/pBoy/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Boy.Pref7));

#line default
#line hidden
            EndContext();
            BeginContext(1986, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2048, 41, false);
#line 67 "/Users/admin/NSB/yuvap/Pages/YP/pBoy/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Boy.Pref7));

#line default
#line hidden
            EndContext();
            BeginContext(2089, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2150, 45, false);
#line 70 "/Users/admin/NSB/yuvap/Pages/YP/pBoy/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Boy.Pref8));

#line default
#line hidden
            EndContext();
            BeginContext(2195, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2257, 41, false);
#line 73 "/Users/admin/NSB/yuvap/Pages/YP/pBoy/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Boy.Pref8));

#line default
#line hidden
            EndContext();
            BeginContext(2298, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2359, 56, false);
#line 76 "/Users/admin/NSB/yuvap/Pages/YP/pBoy/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Boy.BoyLikedByConcat));

#line default
#line hidden
            EndContext();
            BeginContext(2415, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2477, 52, false);
#line 79 "/Users/admin/NSB/yuvap/Pages/YP/pBoy/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Boy.BoyLikedByConcat));

#line default
#line hidden
            EndContext();
            BeginContext(2529, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2567, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c44b37da945b35ad6502323968c8a04e3e54cd813364", async() => {
                BeginContext(2587, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2597, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1c44b37da945b35ad6502323968c8a04e3e54cd813752", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 84 "/Users/admin/NSB/yuvap/Pages/YP/pBoy/Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Boy.BoyID);

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
                BeginContext(2640, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(2723, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c44b37da945b35ad6502323968c8a04e3e54cd815611", async() => {
                    BeginContext(2745, 12, true);
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
                BeginContext(2761, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2774, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<yuvap.Pages.YP.pBoy.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<yuvap.Pages.YP.pBoy.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<yuvap.Pages.YP.pBoy.DeleteModel>)PageContext?.ViewData;
        public yuvap.Pages.YP.pBoy.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
