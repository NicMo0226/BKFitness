#pragma checksum "/home/nic/Projects/BKFitness/BKFitness/Views/Booking/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e56a0af89db1bb0ecf7a8b631e4267e3a26369c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_Index), @"mvc.1.0.view", @"/Views/Booking/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Booking/Index.cshtml", typeof(AspNetCore.Views_Booking_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e56a0af89db1bb0ecf7a8b631e4267e3a26369c7", @"/Views/Booking/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33632e80f1a0d26790b7f13708d7b708a3e474ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BKFitness.ViewModels.Booking.BookingIndexModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/nic/Projects/BKFitness/BKFitness/Views/Booking/Index.cshtml"
  
    ViewBag.Title = "Listing";

#line default
#line hidden
            BeginContext(90, 5, true);
            WriteLiteral("\n<h3>");
            EndContext();
            BeginContext(96, 13, false);
#line 6 "/home/nic/Projects/BKFitness/BKFitness/Views/Booking/Index.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(109, 392, true);
            WriteLiteral(@"</h3>
<div id=""listingIndex"">
   <div id=""table"">
        <table class=""table table-condensed"" id=""Table"">
          <thead>
            <tr>
                <th>Class</th>
                <th>Location </th>
                <th>Day </th>
                <th>Date</th>
                <th>Start </th>
                <th>End </th>
          
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 22 "/home/nic/Projects/BKFitness/BKFitness/Views/Booking/Index.cshtml"
             foreach (var booking in Model.BookingList)
            {

#line default
#line hidden
            BeginContext(571, 44, true);
            WriteLiteral("                <tr>\n                   <td>");
            EndContext();
            BeginContext(616, 19, false);
#line 25 "/home/nic/Projects/BKFitness/BKFitness/Views/Booking/Index.cshtml"
                  Write(booking.SessionName);

#line default
#line hidden
            EndContext();
            BeginContext(635, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(666, 20, false);
#line 26 "/home/nic/Projects/BKFitness/BKFitness/Views/Booking/Index.cshtml"
                   Write(booking.LocationName);

#line default
#line hidden
            EndContext();
            BeginContext(686, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(717, 11, false);
#line 27 "/home/nic/Projects/BKFitness/BKFitness/Views/Booking/Index.cshtml"
                   Write(booking.Day);

#line default
#line hidden
            EndContext();
            BeginContext(728, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(759, 17, false);
#line 28 "/home/nic/Projects/BKFitness/BKFitness/Views/Booking/Index.cshtml"
                   Write(booking.ClassDate);

#line default
#line hidden
            EndContext();
            BeginContext(776, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(807, 13, false);
#line 29 "/home/nic/Projects/BKFitness/BKFitness/Views/Booking/Index.cshtml"
                   Write(booking.Start);

#line default
#line hidden
            EndContext();
            BeginContext(820, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(851, 11, false);
#line 30 "/home/nic/Projects/BKFitness/BKFitness/Views/Booking/Index.cshtml"
                   Write(booking.End);

#line default
#line hidden
            EndContext();
            BeginContext(862, 50, true);
            WriteLiteral("</td>\n                    <\n                </tr>\n");
            EndContext();
#line 33 "/home/nic/Projects/BKFitness/BKFitness/Views/Booking/Index.cshtml"
            }

#line default
#line hidden
            BeginContext(926, 36, true);
            WriteLiteral("        </tbody>\n    </table>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BKFitness.ViewModels.Booking.BookingIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
