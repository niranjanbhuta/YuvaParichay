#pragma checksum "C:\nsb\Dropbox\web\Yuvap5 Core22-ModelRelational SqlServer\yuvap\Pages\YP\pGirl\GetRegNumForEditGirl.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba7dfe8d2e5474c2476ca9c7a9a22b8d3f149b51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(yuvap.Pages.YP.pGirl.Pages_YP_pGirl_GetRegNumForEditGirl), @"mvc.1.0.razor-page", @"/Pages/YP/pGirl/GetRegNumForEditGirl.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/YP/pGirl/GetRegNumForEditGirl.cshtml", typeof(yuvap.Pages.YP.pGirl.Pages_YP_pGirl_GetRegNumForEditGirl), null)]
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
#line 1 "C:\nsb\Dropbox\web\Yuvap5 Core22-ModelRelational SqlServer\yuvap\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\nsb\Dropbox\web\Yuvap5 Core22-ModelRelational SqlServer\yuvap\Pages\_ViewImports.cshtml"
using yuvap;

#line default
#line hidden
#line 3 "C:\nsb\Dropbox\web\Yuvap5 Core22-ModelRelational SqlServer\yuvap\Pages\_ViewImports.cshtml"
using yuvap.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba7dfe8d2e5474c2476ca9c7a9a22b8d3f149b51", @"/Pages/YP/pGirl/GetRegNumForEditGirl.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6995f1c8a2970a40cad8635013e8b548f6f04a53", @"/Pages/_ViewImports.cshtml")]
    public class Pages_YP_pGirl_GetRegNumForEditGirl : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("./EditWithLikes"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "C:\nsb\Dropbox\web\Yuvap5 Core22-ModelRelational SqlServer\yuvap\Pages\YP\pGirl\GetRegNumForEditGirl.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(98, 222, true);
            WriteLiteral("\n<h4>Female:<h4>\n<h4> After submitting Your Reg. Number, You can Enter Your Data. </h4>\n<h4>Please note that you are not allowed to modify your data after once done.</h4>\n<h5>Consult your Admin to solve any problem.</h5>\n\n");
            EndContext();
            BeginContext(320, 174, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba7dfe8d2e5474c2476ca9c7a9a22b8d3f149b514551", async() => {
                BeginContext(351, 136, true);
                WriteLiteral("\n  Type Your Reg. Number Without Prefix Like M/F etc:<br>\n  <input type=\"text\" name=\"id\" ><br>  \n  <input type=\"submit\" value=\"Submit\">\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<yuvap.Pages.YP.pGirl.GetRegNumForEditGirlModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<yuvap.Pages.YP.pGirl.GetRegNumForEditGirlModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<yuvap.Pages.YP.pGirl.GetRegNumForEditGirlModel>)PageContext?.ViewData;
        public yuvap.Pages.YP.pGirl.GetRegNumForEditGirlModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
