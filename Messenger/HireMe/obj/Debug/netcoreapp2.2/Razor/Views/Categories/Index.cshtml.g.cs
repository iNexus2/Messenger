#pragma checksum "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Categories\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5725df5e0abd06afcf8018a78f04c9d6c1679b3d"
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
#line 1 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\_ViewImports.cshtml"
using HireMe;

#line default
#line hidden
#line 2 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\_ViewImports.cshtml"
using HireMe.Models;

#line default
#line hidden
#line 3 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\_ViewImports.cshtml"
using HireMe.Services;

#line default
#line hidden
#line 4 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\_ViewImports.cshtml"
using HireMe.Data;

#line default
#line hidden
#line 5 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\_ViewImports.cshtml"
using HireMe.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5725df5e0abd06afcf8018a78f04c9d6c1679b3d", @"/Views/Categories/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"682bcd9d83d74065f4b1dc0ce11e260e29aaaf2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Categories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HireMe.ViewModels.Categories.CategoriesViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Categories\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_LayoutPanel.cshtml";

#line default
#line hidden
            BeginContext(154, 34, true);
            WriteLiteral("\r\n<h2>Categories</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(189, 39, false);
#line 11 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Categories\Index.cshtml"
Write(Html.ActionLink("Create New", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(228, 52, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\" id=\"categoriesTable\">\r\n");
            EndContext();
#line 14 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Categories\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(321, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(370, 40, false);
#line 18 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Categories\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(410, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(466, 46, false);
#line 21 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Categories\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(512, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(567, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5725df5e0abd06afcf8018a78f04c9d6c1679b3d5963", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 577, "~/", 577, 2, true);
#line 24 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Categories\Index.cshtml"
AddHtmlAttributeValue("", 579, item.Icon, 579, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(598, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(654, 53, false);
#line 27 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Categories\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(707, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(728, 57, false);
#line 28 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Categories\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(785, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 31 "C:\Users\iNexus\Documents\source\repos\HireMe\HireMe\Views\Categories\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(828, 65, true);
            WriteLiteral("\r\n</table>\r\n<button onclick=\"changeTextColor()\">Change</button>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(911, 224, true);
                WriteLiteral("\r\n\r\n    <script>\r\n\r\n        function changeTextColor() {\r\n            $(\'#categoriesTable tr:even\').css(\'background\', \'green\');\r\n            $(\'#categoriesTable tr:odd\').css(\'background\', \'blue\');\r\n        }\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HireMe.ViewModels.Categories.CategoriesViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
