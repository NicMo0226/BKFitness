#pragma checksum "/home/nic/Projects/BKFitness/BKFitness/Views/Session/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8211762f6d1e37df961c04e3625e14260425d1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Session_Index), @"mvc.1.0.view", @"/Views/Session/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Session/Index.cshtml", typeof(AspNetCore.Views_Session_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8211762f6d1e37df961c04e3625e14260425d1a", @"/Views/Session/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33632e80f1a0d26790b7f13708d7b708a3e474ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Session_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BKFitness.ViewModels.Session.SessionIndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Session", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(54, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/home/nic/Projects/BKFitness/BKFitness/Views/Session/Index.cshtml"
  
    ViewData["Title"] = "Class Listing";

#line default
#line hidden
            BeginContext(102, 381, true);
            WriteLiteral(@"
<h3>Classes</h3>
    <div id=""table"">
        <table class=""table table-condensed"" id=""Table"">
            <thead>
                <tr>
                  
                    <th>Image</th>
                    <th>Class</th>
                    <th>Price</th>
                    <th>Member Price</th>
		            
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 21 "/home/nic/Projects/BKFitness/BKFitness/Views/Session/Index.cshtml"
                 foreach (var session in Model.SessionListing)
                {

#line default
#line hidden
            BeginContext(564, 103, true);
            WriteLiteral("                    <tr class=\"Row\">\n                        <td class=\"\">\n                            ");
            EndContext();
            BeginContext(667, 199, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8211762f6d1e37df961c04e3625e14260425d1a4756", async() => {
                BeginContext(742, 37, true);
                WriteLiteral("\n                                <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 779, "\"", 799, 1);
#line 26 "/home/nic/Projects/BKFitness/BKFitness/Views/Session/Index.cshtml"
WriteAttributeValue("", 785, session.Image, 785, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(800, 62, true);
                WriteLiteral(" width=\"150\" class=\"imageCell\" />\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 25 "/home/nic/Projects/BKFitness/BKFitness/Views/Session/Index.cshtml"
                                                                              WriteLiteral(session.Id);

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
            BeginContext(866, 68, true);
            WriteLiteral("\n                        </td>\n                        <td class=\"\">");
            EndContext();
            BeginContext(935, 19, false);
#line 29 "/home/nic/Projects/BKFitness/BKFitness/Views/Session/Index.cshtml"
                                Write(session.SessionName);

#line default
#line hidden
            EndContext();
            BeginContext(954, 43, true);
            WriteLiteral("</td>\n                        <td class=\"\">");
            EndContext();
            BeginContext(998, 22, false);
#line 30 "/home/nic/Projects/BKFitness/BKFitness/Views/Session/Index.cshtml"
                                Write(session.NonMemberPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1020, 43, true);
            WriteLiteral("</td>\n                        <td class=\"\">");
            EndContext();
            BeginContext(1064, 19, false);
#line 31 "/home/nic/Projects/BKFitness/BKFitness/Views/Session/Index.cshtml"
                                Write(session.MemberPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1083, 57, true);
            WriteLiteral("</td>\n                        \n                    </tr>\n");
            EndContext();
#line 34 "/home/nic/Projects/BKFitness/BKFitness/Views/Session/Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1158, 55, true);
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BKFitness.ViewModels.Session.SessionIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
