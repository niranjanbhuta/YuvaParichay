#pragma checksum "/Users/admin/NSB/yuvap/Pages/YP/pProcess/ProcessGirl.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "166063ed94afa54dda58effce65d979fbc642209"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(yuvap.Pages.YP.pProcess.Pages_YP_pProcess_ProcessGirl), @"mvc.1.0.razor-page", @"/Pages/YP/pProcess/ProcessGirl.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/YP/pProcess/ProcessGirl.cshtml", typeof(yuvap.Pages.YP.pProcess.Pages_YP_pProcess_ProcessGirl), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"166063ed94afa54dda58effce65d979fbc642209", @"/Pages/YP/pProcess/ProcessGirl.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6995f1c8a2970a40cad8635013e8b548f6f04a53", @"/Pages/_ViewImports.cshtml")]
    public class Pages_YP_pProcess_ProcessGirl : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/ProcessGirl.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(100, 113, true);
            WriteLiteral("\r\n<h3>Female Report</h3>\r\n\r\n<<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(214, 50, false);
#line 14 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/ProcessGirl.cshtml"
           Write(Html.DisplayNameFor(model => model.Girl[0].GirlID));

#line default
#line hidden
            EndContext();
            BeginContext(264, 67, true);
            WriteLiteral("\r\n            </th>            \r\n            <th>\r\n                ");
            EndContext();
            BeginContext(332, 48, false);
#line 17 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/ProcessGirl.cshtml"
           Write(Html.DisplayNameFor(model => model.Girl[0].Name));

#line default
#line hidden
            EndContext();
            BeginContext(380, 155, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Girl Liked By:\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 26 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/ProcessGirl.cshtml"
 foreach (var item in Model.Girl) {

#line default
#line hidden
            BeginContext(572, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(621, 41, false);
#line 29 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/ProcessGirl.cshtml"
           Write(Html.DisplayFor(modelItem => item.GirlID));

#line default
#line hidden
            EndContext();
            BeginContext(662, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(718, 39, false);
#line 32 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/ProcessGirl.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(757, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(813, 52, false);
#line 35 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/ProcessGirl.cshtml"
           Write(Html.DisplayFor(modelItem => item.GirlLikedByConcat));

#line default
#line hidden
            EndContext();
            BeginContext(865, 48, true);
            WriteLiteral("\r\n            </td>            \r\n        </tr>\r\n");
            EndContext();
#line 38 "/Users/admin/NSB/yuvap/Pages/YP/pProcess/ProcessGirl.cshtml"
}

#line default
#line hidden
            BeginContext(916, 50, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<yuvap.Pages.YP.pProcess.ProcessGirlModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<yuvap.Pages.YP.pProcess.ProcessGirlModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<yuvap.Pages.YP.pProcess.ProcessGirlModel>)PageContext?.ViewData;
        public yuvap.Pages.YP.pProcess.ProcessGirlModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
