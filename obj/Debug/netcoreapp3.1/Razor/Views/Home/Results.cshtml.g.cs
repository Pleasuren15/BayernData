#pragma checksum "C:\MY STUFF\My Work\2021\BayernData\Views\Home\Results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "854cf9af6f19865d2f888312cb435e975e1a9246"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Results), @"mvc.1.0.view", @"/Views/Home/Results.cshtml")]
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
#line 2 "C:\MY STUFF\My Work\2021\BayernData\Views\_ViewImports.cshtml"
using BayernData.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"854cf9af6f19865d2f888312cb435e975e1a9246", @"/Views/Home/Results.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53516634d93777aa101114ea6082dfc2ba476fdf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Match>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_NavBarPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_FooterPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\MY STUFF\My Work\2021\BayernData\Views\Home\Results.cshtml"
  
    ViewData["Title"] = "Results";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "854cf9af6f19865d2f888312cb435e975e1a92463685", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""to-top"">
    <a href=""#top"" class=""text-light text-decoration-none anton"">&uArr;</a>
</div>

<div class=""container"" id=""top"">
    <div class=""site-results"">
        <h3>MATCH RESULTS</h3>
        <hr />
        <p>
            View Bayern Munich's last 5 home matches from competitions they took part in
        </p>
    </div>

");
#nullable restore
#line 21 "C:\MY STUFF\My Work\2021\BayernData\Views\Home\Results.cshtml"
     foreach (Match item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"site-single-match\">\r\n            <p class=\"text-center small mb-0 hand-writing\">");
#nullable restore
#line 24 "C:\MY STUFF\My Work\2021\BayernData\Views\Home\Results.cshtml"
                                                      Write(item.Venue);

#line default
#line hidden
#nullable disable
            WriteLiteral(" • ");
#nullable restore
#line 24 "C:\MY STUFF\My Work\2021\BayernData\Views\Home\Results.cshtml"
                                                                    Write(item.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 24 "C:\MY STUFF\My Work\2021\BayernData\Views\Home\Results.cshtml"
                                                                                Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <div class=\"site-single-match-hr\"></div>\r\n            <h5 class=\"text-center hand-writing\">FULL-TIME</h5>\r\n            <div class=\"d-flex justify-content-center\">\r\n                <div class=\"d-flex  align-items-center\">\r\n");
            WriteLiteral("                    <img class=\"anton\"");
            BeginWriteAttribute("src", " src=\"", 985, "\"", 1017, 1);
#nullable restore
#line 30 "C:\MY STUFF\My Work\2021\BayernData\Views\Home\Results.cshtml"
WriteAttributeValue("", 991, item.HomeTeam.TeamLogoUrl, 991, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100\" height=\"100\" />\r\n                    <h1 class=\"text-center hand-writing m-4\">");
#nullable restore
#line 31 "C:\MY STUFF\My Work\2021\BayernData\Views\Home\Results.cshtml"
                                                        Write(item.HomeTeam.TeamScore);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                </div>
                <div class=""d-flex justify-content-center align-items-center m-4"">
                    <h1 class=""text-center hand-writing"">-</h1>
                </div>
                <div class=""d-flex  align-items-center"">
                    <h1 class=""text-center hand-writing m-4"">");
#nullable restore
#line 37 "C:\MY STUFF\My Work\2021\BayernData\Views\Home\Results.cshtml"
                                                        Write(item.AwayTeam.TeamScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <img class=\"anton\"");
            BeginWriteAttribute("src", " src=\"", 1525, "\"", 1557, 1);
#nullable restore
#line 38 "C:\MY STUFF\My Work\2021\BayernData\Views\Home\Results.cshtml"
WriteAttributeValue("", 1531, item.AwayTeam.TeamLogoUrl, 1531, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100\" height=\"100\" />\r\n");
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 43 "C:\MY STUFF\My Work\2021\BayernData\Views\Home\Results.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "854cf9af6f19865d2f888312cb435e975e1a92468646", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Match>> Html { get; private set; }
    }
}
#pragma warning restore 1591
