#pragma checksum "C:\Users\Lejla\Source\Repos\ooad-2019-2020\Grupa7-Tartarus\Tartarus-final\Tartarus-final\Views\Zatvorenici\HomeSearchPrisoner.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2e3e593155d76d406494e6af84406cc19f4babf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Zatvorenici_HomeSearchPrisoner), @"mvc.1.0.view", @"/Views/Zatvorenici/HomeSearchPrisoner.cshtml")]
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
#line 1 "C:\Users\Lejla\Source\Repos\ooad-2019-2020\Grupa7-Tartarus\Tartarus-final\Tartarus-final\Views\_ViewImports.cshtml"
using Tartarus_final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lejla\Source\Repos\ooad-2019-2020\Grupa7-Tartarus\Tartarus-final\Tartarus-final\Views\_ViewImports.cshtml"
using Tartarus_final.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2e3e593155d76d406494e6af84406cc19f4babf", @"/Views/Zatvorenici/HomeSearchPrisoner.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23d9cf4ac3981ab3ba209a4346d506fe02af54f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Zatvorenici_HomeSearchPrisoner : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Tartarus_final.Models.Zatvorenik>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Zatvorenici", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "HomeSearchPrisoner", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Lejla\Source\Repos\ooad-2019-2020\Grupa7-Tartarus\Tartarus-final\Tartarus-final\Views\Zatvorenici\HomeSearchPrisoner.cshtml"
  
    ViewData["Title"] = "HomeSearchPrisoner";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Search prisoners</h1>\r\n\r\n<div class=\" mb-lg-3\"></div>\r\n\r\n<div class=\"d-flex justify-content-center\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2e3e593155d76d406494e6af84406cc19f4babf4555", async() => {
                WriteLiteral(@"
        <p style=""font-size:large; align-items:center;"">
            Enter prisoner name: <input type=""text"" name=""SearchString"" style=""border-radius: 50px;  width: 80%; border: none;"" />
            <input type=""submit"" value=""Filter"" style=""border-radius: 50px; border: none;"" />
        </p>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

    <div class="" mb-lg-5""></div>

    <table class=""table  mb-lg-5"">
        <thead>
            <tr>
                <th style=""text-align: center; background-color: #ffffff;"">
                    First name
                </th>
                <th style=""text-align: center; background-color: #ffffff;"">
                    Last name
                </th>
                <th style=""text-align: center; background-color: #ffffff;"">
                    Prison sentence
                </th>
                <th style=""text-align: center; background-color: #ffffff;"">
                    Prisoner evaluation
                </th>
                <th style=""text-align: center; background-color: #ffffff;"">
                    Jmbg
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 45 "C:\Users\Lejla\Source\Repos\ooad-2019-2020\Grupa7-Tartarus\Tartarus-final\Tartarus-final\Views\Zatvorenici\HomeSearchPrisoner.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td style=\"text-align: center; background-color: #ffffff;\">\r\n                        ");
#nullable restore
#line 49 "C:\Users\Lejla\Source\Repos\ooad-2019-2020\Grupa7-Tartarus\Tartarus-final\Tartarus-final\Views\Zatvorenici\HomeSearchPrisoner.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Ime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td style=\"text-align: center; background-color: #ffffff;\">\r\n                        ");
#nullable restore
#line 52 "C:\Users\Lejla\Source\Repos\ooad-2019-2020\Grupa7-Tartarus\Tartarus-final\Tartarus-final\Views\Zatvorenici\HomeSearchPrisoner.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Prezime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td style=\"text-align: center; background-color: #ffffff;\">\r\n                        ");
#nullable restore
#line 55 "C:\Users\Lejla\Source\Repos\ooad-2019-2020\Grupa7-Tartarus\Tartarus-final\Tartarus-final\Views\Zatvorenici\HomeSearchPrisoner.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ZatvorskaKazna));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td style=\"text-align: center; background-color: #ffffff;\">\r\n                        ");
#nullable restore
#line 58 "C:\Users\Lejla\Source\Repos\ooad-2019-2020\Grupa7-Tartarus\Tartarus-final\Tartarus-final\Views\Zatvorenici\HomeSearchPrisoner.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Evaluacija));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td style=\"text-align: center; background-color: #ffffff;\">\r\n                        ");
#nullable restore
#line 61 "C:\Users\Lejla\Source\Repos\ooad-2019-2020\Grupa7-Tartarus\Tartarus-final\Tartarus-final\Views\Zatvorenici\HomeSearchPrisoner.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Jmbg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n\r\n                </tr>\r\n");
#nullable restore
#line 66 "C:\Users\Lejla\Source\Repos\ooad-2019-2020\Grupa7-Tartarus\Tartarus-final\Tartarus-final\Views\Zatvorenici\HomeSearchPrisoner.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Tartarus_final.Models.Zatvorenik>> Html { get; private set; }
    }
}
#pragma warning restore 1591
