#pragma checksum "/Users/admin/Yuvap4 Core22/yuvap/Pages/ErrDuplcateRecord.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d6dfbcc088ba0a749f4d20150169a62d100e271"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(yuvap.Pages.Pages_ErrDuplcateRecord), @"mvc.1.0.razor-page", @"/Pages/ErrDuplcateRecord.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/ErrDuplcateRecord.cshtml", typeof(yuvap.Pages.Pages_ErrDuplcateRecord), null)]
namespace yuvap.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d6dfbcc088ba0a749f4d20150169a62d100e271", @"/Pages/ErrDuplcateRecord.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6995f1c8a2970a40cad8635013e8b548f6f04a53", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ErrDuplcateRecord : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/admin/Yuvap4 Core22/yuvap/Pages/ErrDuplcateRecord.cshtml"
  
    ViewData["Title"] = "Error Duplicate Record";

#line default
#line hidden
            BeginContext(97, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(102, 17, false);
#line 6 "/Users/admin/Yuvap4 Core22/yuvap/Pages/ErrDuplcateRecord.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(119, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(131, 13, false);
#line 7 "/Users/admin/Yuvap4 Core22/yuvap/Pages/ErrDuplcateRecord.cshtml"
Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(144, 105, true);
            WriteLiteral("</h3>\r\n\r\n<p>\"The data for this Code has already been entered. Contact admin to resolve the issue. \"</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrDuplicateRecordModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ErrDuplicateRecordModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ErrDuplicateRecordModel>)PageContext?.ViewData;
        public ErrDuplicateRecordModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591