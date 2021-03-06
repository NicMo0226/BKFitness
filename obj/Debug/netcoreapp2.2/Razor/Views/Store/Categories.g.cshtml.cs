#pragma checksum "/home/nic/Documents/WebApps/BKFitness/BKFitness/Views/Store/Categories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fca4c2fd8f734092f3e3038c8a1c4f6c120fdae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_Categories), @"mvc.1.0.view", @"/Views/Store/Categories.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Store/Categories.cshtml", typeof(AspNetCore.Views_Store_Categories))]
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
#line 1 "/home/nic/Documents/WebApps/BKFitness/BKFitness/Views/_ViewImports.cshtml"
using BKFitness;

#line default
#line hidden
#line 2 "/home/nic/Documents/WebApps/BKFitness/BKFitness/Views/_ViewImports.cshtml"
using BKFitness.Infastructure;

#line default
#line hidden
#line 3 "/home/nic/Documents/WebApps/BKFitness/BKFitness/Views/_ViewImports.cshtml"
using BKFitness.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fca4c2fd8f734092f3e3038c8a1c4f6c120fdae", @"/Views/Store/Categories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9e38f95abdef5d741a13fd2bdc1dac49b78c9c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_Categories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BKFitness.Models.Pages.PagedList<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 177, true);
            WriteLiteral("\n\n<div class=\"container-fluid mt-4\">\n\n    <div class=\"row no-gutters\">\n        <div class=\"col mt-1\">\n            <button form=\"pageform\" name=\"category\" value=\"0\" type=\"submit\"");
            EndContext();
            BeginWriteAttribute("class", "\n                    class=\"", 227, "\"", 361, 3);
            WriteAttributeValue("", 255, "btn", 255, 3, true);
            WriteAttributeValue(" ", 258, "btn-block", 259, 10, true);
#line 9 "/home/nic/Documents/WebApps/BKFitness/BKFitness/Views/Store/Categories.cshtml"
WriteAttributeValue(" ", 268, ViewBag.SelectedCategory == 0
                    ? "btn-primary" : "btn-outline-primary", 269, 92, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(362, 265, true);
            WriteLiteral(@">
                All
            </button>
        </div>
    </div>

    <div class=""row no-gutters mt-4""></div>

    <div class=""row no-gutters"">
        <div class=""col mt-1"">
            <button form=""pageform""
                    name=""catoptions.currentPage""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 627, "\"", 658, 1);
#line 21 "/home/nic/Documents/WebApps/BKFitness/BKFitness/Views/Store/Categories.cshtml"
WriteAttributeValue("", 635, Model.CurrentPage -1, 635, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("class", "\n                    class=\"", 659, "\"", 790, 4);
            WriteAttributeValue("", 687, "btn", 687, 3, true);
            WriteAttributeValue(" ", 690, "btn-block", 691, 10, true);
            WriteAttributeValue(" ", 700, "btn-outline-secondary", 701, 22, true);
#line 22 "/home/nic/Documents/WebApps/BKFitness/BKFitness/Views/Store/Categories.cshtml"
WriteAttributeValue("\n                        ", 722, !Model.HasPreviousPage ? "disabled" : "", 747, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(791, 110, true);
            WriteLiteral("\n                    type=\"submit\">\n                Previous\n            </button>\n        </div>\n    </div>\n\n");
            EndContext();
#line 30 "/home/nic/Documents/WebApps/BKFitness/BKFitness/Views/Store/Categories.cshtml"
     foreach (Category c in Model) {

#line default
#line hidden
            BeginContext(938, 127, true);
            WriteLiteral("        <div class=\"row no-gutters\">\n            <div class=\"col mt-1\">\n                <button form=\"pageform\" name=\"category\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1065, "\"", 1078, 1);
#line 33 "/home/nic/Documents/WebApps/BKFitness/BKFitness/Views/Store/Categories.cshtml"
WriteAttributeValue("", 1073, c.Id, 1073, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1079, 38, true);
            WriteLiteral("\n                        type=\"submit\"");
            EndContext();
            BeginWriteAttribute("class", "\n                        class=\"", 1117, "\"", 1262, 3);
            WriteAttributeValue("", 1149, "btn", 1149, 3, true);
            WriteAttributeValue(" ", 1152, "btn-block", 1153, 10, true);
#line 35 "/home/nic/Documents/WebApps/BKFitness/BKFitness/Views/Store/Categories.cshtml"
WriteAttributeValue(" ", 1162, ViewBag.SelectedCategory == c.Id
                        ? "btn-primary" : "btn-outline-primary", 1163, 99, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1263, 22, true);
            WriteLiteral(">\n                    ");
            EndContext();
            BeginContext(1286, 6, false);
#line 37 "/home/nic/Documents/WebApps/BKFitness/BKFitness/Views/Store/Categories.cshtml"
               Write(c.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1292, 61, true);
            WriteLiteral("\n                </button>\n            </div>\n        </div>\n");
            EndContext();
#line 41 "/home/nic/Documents/WebApps/BKFitness/BKFitness/Views/Store/Categories.cshtml"
    }

#line default
#line hidden
            BeginContext(1359, 150, true);
            WriteLiteral("\n    <div class=\"row no-gutters\">\n        <div class=\"col mt-1\">\n            <button form=\"pageform\"\n                    name=\"catoptions.currentPage\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1509, "\"", 1540, 1);
#line 46 "/home/nic/Documents/WebApps/BKFitness/BKFitness/Views/Store/Categories.cshtml"
WriteAttributeValue("", 1517, Model.CurrentPage +1, 1517, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("class", "\n                    class=\"", 1541, "\"", 1667, 4);
            WriteAttributeValue("", 1569, "btn", 1569, 3, true);
            WriteAttributeValue(" ", 1572, "btn-block", 1573, 10, true);
            WriteAttributeValue(" ", 1582, "btn-outline-secondary", 1583, 22, true);
#line 47 "/home/nic/Documents/WebApps/BKFitness/BKFitness/Views/Store/Categories.cshtml"
WriteAttributeValue("\n                        ", 1604, !Model.HasNextPage? "disabled" : "", 1629, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1668, 111, true);
            WriteLiteral("\n                    type=\"submit\">\n                Next\n            </button>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BKFitness.Models.Pages.PagedList<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
