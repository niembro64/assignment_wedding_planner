#pragma checksum "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\3.3\assignment_wedding_planner\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69ebccf977399b46966377152c32ae625dbe46e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
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
#nullable restore
#line 1 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\3.3\assignment_wedding_planner\Views\_ViewImports.cshtml"
using assignment_wedding_planner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\3.3\assignment_wedding_planner\Views\_ViewImports.cshtml"
using assignment_wedding_planner.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69ebccf977399b46966377152c32ae625dbe46e1", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e73d080286c18c469160d2ebdd05599090cea39", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Reservation>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/reservations/reserve"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\3.3\assignment_wedding_planner\Views\Home\Dashboard.cshtml"
  
  ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
  <h1>Dashboard</h1>
  <table class=""table table-hover"">
    <thead>
      <tr>
        <th scope=""col"">WeddingId</th>
        <th scope=""col"">Wedders</th>
        <th scope=""col"">Date</th>
        <th scope=""col"">Address</th>
        <th scope=""col"">Created By</th>
        <th scope=""col"">Functions</th>
      </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\3.3\assignment_wedding_planner\Views\Home\Dashboard.cshtml"
       foreach (Wedding x in @ViewBag.AllWeddings)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n          <td>\r\n            <p>");
#nullable restore
#line 24 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\3.3\assignment_wedding_planner\Views\Home\Dashboard.cshtml"
          Write(x.WeddingId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n          </td>\r\n          <td>\r\n            <p>");
#nullable restore
#line 27 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\3.3\assignment_wedding_planner\Views\Home\Dashboard.cshtml"
          Write(x.WedderOne);

#line default
#line hidden
#nullable disable
            WriteLiteral(" & ");
#nullable restore
#line 27 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\3.3\assignment_wedding_planner\Views\Home\Dashboard.cshtml"
                         Write(x.WedderTwo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n          </td>\r\n          <td>\r\n            <p>");
#nullable restore
#line 30 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\3.3\assignment_wedding_planner\Views\Home\Dashboard.cshtml"
          Write(x.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n          </td>\r\n          <td>\r\n            <p>");
#nullable restore
#line 33 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\3.3\assignment_wedding_planner\Views\Home\Dashboard.cshtml"
          Write(x.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n          </td>\r\n          <td>\r\n            <p>");
#nullable restore
#line 36 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\3.3\assignment_wedding_planner\Views\Home\Dashboard.cshtml"
          Write(x.CreatedById);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n          </td>\r\n");
#nullable restore
#line 38 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\3.3\assignment_wedding_planner\Views\Home\Dashboard.cshtml"
           if (@x.CreatedById == @ViewBag.Session_UserId)
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td><a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 976, "\"", 1012, 2);
            WriteAttributeValue("", 983, "/weddings/delete/", 983, 17, true);
#nullable restore
#line 40 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\3.3\assignment_wedding_planner\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1000, x.WeddingId, 1000, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a></td>\r\n");
#nullable restore
#line 41 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\3.3\assignment_wedding_planner\Views\Home\Dashboard.cshtml"
          }
          else
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69ebccf977399b46966377152c32ae625dbe46e18331", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "69ebccf977399b46966377152c32ae625dbe46e18605", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 46 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\3.3\assignment_wedding_planner\Views\Home\Dashboard.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\3.3\assignment_wedding_planner\Views\Home\Dashboard.cshtml"
                                                WriteLiteral(ViewBag.Session_UserId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "69ebccf977399b46966377152c32ae625dbe46e111089", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 47 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\3.3\assignment_wedding_planner\Views\Home\Dashboard.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.WeddingId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\3.3\assignment_wedding_planner\Views\Home\Dashboard.cshtml"
                                                   WriteLiteral(x.WeddingId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <input type=\"submit\" value=\"RSVP\" class=\"btn btn-primary my-3\">\r\n              ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n");
#nullable restore
#line 51 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\3.3\assignment_wedding_planner\Views\Home\Dashboard.cshtml"

          }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 54 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\3.3\assignment_wedding_planner\Views\Home\Dashboard.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n  </table>\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Reservation> Html { get; private set; }
    }
}
#pragma warning restore 1591
