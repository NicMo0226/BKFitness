#pragma checksum "/home/nic/Documents/WebApps/BKFitness/BKFitness/Views/Categories/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffbafe075e1e8976128a06473edf353cfe032d2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Index), @"mvc.1.0.view", @"/Views/Categories/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Categories/Index.cshtml", typeof(AspNetCore.Views_Categories_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffbafe075e1e8976128a06473edf353cfe032d2c", @"/Views/Categories/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9e38f95abdef5d741a13fd2bdc1dac49b78c9c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Categories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 101, true);
            WriteLiteral("    \n<h3 class=\"p-2 bg-primary text-white text-center\">Categories</h3>\n<div class=\"text-center\">\n    ");
            EndContext();
            BeginContext(131, 28, false);
#line 5 "/home/nic/Documents/WebApps/BKFitness/BKFitness/Views/Categories/Index.cshtml"
Write(Html.Partial("Pages", Model));

#line default
#line hidden
            EndContext();
            BeginContext(159, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 6 "/home/nic/Documents/WebApps/BKFitness/BKFitness/Views/Categories/Index.cshtml"
      
        ViewBag.searches = new string[] { "Name", "Description" };
        ViewBag.sorts = new string[] { "Name", "Description" };
    

#line default
#line hidden
            BeginContext(304, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(309, 34, false);
#line 10 "/home/nic/Documents/WebApps/BKFitness/BKFitness/Views/Categories/Index.cshtml"
Write(Html.Partial("PageOptions", Model));

#line default
#line hidden
            EndContext();
            BeginContext(343, 276, true);
            WriteLiteral(@"
</div>
<div class=""container-fluid mt-3"">
    <div class=""row"">
        <div class=""col-1 font-weight-bold"">Id</div>
        <div class=""col font-weight-bold"">Name</div>
        <div class=""col font-weight-bold"">Description</div>
        <div class=""col-3""></div>
    </div>
");
            EndContext();
#line 19 "/home/nic/Documents/WebApps/BKFitness/BKFitness/Views/Categories/Index.cshtml"
     if (ViewBag.EditId == null) {

#line default
#line hidden
            BeginContext(654, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(662, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffbafe075e1e8976128a06473edf353cfe032d2c7110", async() => {
                BeginContext(707, 13, true);
                WriteLiteral("\n            ");
                EndContext();
                BeginContext(721, 46, false);
#line 21 "/home/nic/Documents/WebApps/BKFitness/BKFitness/Views/Categories/Index.cshtml"
       Write(Html.Partial("CategoryEditor", new Category()));

#line default
#line hidden
                EndContext();
                BeginContext(767, 9, true);
                WriteLiteral("\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(783, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 23 "/home/nic/Documents/WebApps/BKFitness/BKFitness/Views/Categories/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(790, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 24 "/home/nic/Documents/WebApps/BKFitness/BKFitness/Views/Categories/Index.cshtml"
     foreach (Category c in Model) {
        

#line default
#line hidden
#line 25 "/home/nic/Documents/WebApps/BKFitness/BKFitness/Views/Categories/Index.cshtml"
         if (c.Id == ViewBag.EditId) {

#line default
#line hidden
            BeginContext(866, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(878, 183, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffbafe075e1e8976128a06473edf353cfe032d2c9963", async() => {
                BeginContext(926, 47, true);
                WriteLiteral("\n                <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 973, "\"", 986, 1);
#line 27 "/home/nic/Documents/WebApps/BKFitness/BKFitness/Views/Categories/Index.cshtml"
WriteAttributeValue("", 981, c.Id, 981, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(987, 20, true);
                WriteLiteral(" />\n                ");
                EndContext();
                BeginContext(1008, 33, false);
#line 28 "/home/nic/Documents/WebApps/BKFitness/BKFitness/Views/Categories/Index.cshtml"
           Write(Html.Partial("CategoryEditor", c));

#line default
#line hidden
                EndContext();
                BeginContext(1041, 13, true);
                WriteLiteral("\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1061, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 30 "/home/nic/Documents/WebApps/BKFitness/BKFitness/Views/Categories/Index.cshtml"
        } else {

#line default
#line hidden
            BeginContext(1079, 69, true);
            WriteLiteral("            <div class=\"row p-2\">\n                <div class=\"col-1\">");
            EndContext();
            BeginContext(1149, 4, false);
#line 32 "/home/nic/Documents/WebApps/BKFitness/BKFitness/Views/Categories/Index.cshtml"
                              Write(c.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1153, 40, true);
            WriteLiteral("</div>\n                <div class=\"col\">");
            EndContext();
            BeginContext(1194, 6, false);
#line 33 "/home/nic/Documents/WebApps/BKFitness/BKFitness/Views/Categories/Index.cshtml"
                            Write(c.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1200, 40, true);
            WriteLiteral("</div>\n                <div class=\"col\">");
            EndContext();
            BeginContext(1241, 13, false);
#line 34 "/home/nic/Documents/WebApps/BKFitness/BKFitness/Views/Categories/Index.cshtml"
                            Write(c.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1254, 63, true);
            WriteLiteral("</div>\n                <div class=\"col-3\">\n                    ");
            EndContext();
            BeginContext(1317, 437, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffbafe075e1e8976128a06473edf353cfe032d2c14061", async() => {
                BeginContext(1365, 55, true);
                WriteLiteral("\n                        <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1420, "\"", 1433, 1);
#line 37 "/home/nic/Documents/WebApps/BKFitness/BKFitness/Views/Categories/Index.cshtml"
WriteAttributeValue("", 1428, c.Id, 1428, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1434, 28, true);
                WriteLiteral(" />\n                        ");
                EndContext();
                BeginContext(1462, 117, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffbafe075e1e8976128a06473edf353cfe032d2c14924", async() => {
                    BeginContext(1571, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 38 "/home/nic/Documents/WebApps/BKFitness/BKFitness/Views/Categories/Index.cshtml"
                                                       WriteLiteral(c.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1579, 168, true);
                WriteLiteral("\n                        <button type=\"submit\" class=\"btn btn-outline-danger\">\n                            Delete\n                        </button>\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1754, 43, true);
            WriteLiteral("\n                </div>\n            </div>\n");
            EndContext();
#line 46 "/home/nic/Documents/WebApps/BKFitness/BKFitness/Views/Categories/Index.cshtml"
        }

#line default
#line hidden
#line 46 "/home/nic/Documents/WebApps/BKFitness/BKFitness/Views/Categories/Index.cshtml"
         
    }

#line default
#line hidden
            BeginContext(1813, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
