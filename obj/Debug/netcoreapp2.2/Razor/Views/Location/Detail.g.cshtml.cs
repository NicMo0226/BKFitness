#pragma checksum "/home/nic/Projects/BKFitness/BKFitness/Views/Location/Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52ff48ba5559d313239dbf519abdee050817f093"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Location_Detail), @"mvc.1.0.view", @"/Views/Location/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Location/Detail.cshtml", typeof(AspNetCore.Views_Location_Detail))]
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
#line 1 "/home/nic/Projects/BKFitness/BKFitness/Views/_ViewImports.cshtml"
using BKFitness;

#line default
#line hidden
#line 2 "/home/nic/Projects/BKFitness/BKFitness/Views/_ViewImports.cshtml"
using BKFitness.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52ff48ba5559d313239dbf519abdee050817f093", @"/Views/Location/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33632e80f1a0d26790b7f13708d7b708a3e474ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Location_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BKFitness.ViewModels.Location.LocationDetailModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/home/nic/Projects/BKFitness/BKFitness/Views/Location/Detail.cshtml"
  

    ViewBag.Title = @Model.LocationName + " Location";

#line default
#line hidden
            BeginContext(119, 264, true);
            WriteLiteral(@"


<div class=""container"">
    <div class=""page-header clearfix detailHeading"">
        <h2 class=""text-muted"">Information</h2>
    </div>
</div>

<div class=""jumbotron"">
    <div class=""row"">

        <div class=""col-md-4 "">
            <div>
                <h2>");
            EndContext();
            BeginContext(384, 18, false);
#line 21 "/home/nic/Projects/BKFitness/BKFitness/Views/Location/Detail.cshtml"
               Write(Model.LocationName);

#line default
#line hidden
            EndContext();
            BeginContext(402, 97, true);
            WriteLiteral("</h2>\n                <div class=\"class day times\">\n                    <p id=\"MemberType\">Name: ");
            EndContext();
            BeginContext(500, 21, false);
#line 23 "/home/nic/Projects/BKFitness/BKFitness/Views/Location/Detail.cshtml"
                                        Write(Model.LocationAddress);

#line default
#line hidden
            EndContext();
            BeginContext(521, 44, true);
            WriteLiteral("</p>\n                    <p id=\"Since\">Map: ");
            EndContext();
            BeginContext(566, 17, false);
#line 24 "/home/nic/Projects/BKFitness/BKFitness/Views/Location/Detail.cshtml"
                                  Write(Model.LocationMap);

#line default
#line hidden
            EndContext();
            BeginContext(583, 95, true);
            WriteLiteral("</p>\n\n                </div>\n              \n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BKFitness.ViewModels.Location.LocationDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
