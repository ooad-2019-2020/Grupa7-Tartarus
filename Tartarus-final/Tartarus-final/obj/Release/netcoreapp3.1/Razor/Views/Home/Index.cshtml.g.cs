#pragma checksum "C:\Users\Ajdin.Ajdin-PC\Source\Repos\ooad-2019-2020\Grupa7-Tartarus\Tartarus-final\Tartarus-final\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "983b14d25ad3ffe6df8dab017ba2d806b8681187"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Ajdin.Ajdin-PC\Source\Repos\ooad-2019-2020\Grupa7-Tartarus\Tartarus-final\Tartarus-final\Views\_ViewImports.cshtml"
using Tartarus_final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ajdin.Ajdin-PC\Source\Repos\ooad-2019-2020\Grupa7-Tartarus\Tartarus-final\Tartarus-final\Views\_ViewImports.cshtml"
using Tartarus_final.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"983b14d25ad3ffe6df8dab017ba2d806b8681187", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23d9cf4ac3981ab3ba209a4346d506fe02af54f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/Picture2.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Ajdin.Ajdin-PC\Source\Repos\ooad-2019-2020\Grupa7-Tartarus\Tartarus-final\Tartarus-final\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center mb-lg-5"">
    <h1 class=""display-5"">Welcome</h1>
</div>


<div class=""bg"">
    <div class=""d-flex justify-content-center"">

        <div class=""card ml-5"" style=""width: 18rem; background-color: #a3a2a2; align-items: center;"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "983b14d25ad3ffe6df8dab017ba2d806b86811874802", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <div class=\"card-body\">\r\n                <p class=\"card-text\"><button style=\"background-color: #000000; text-align: center;\" type=\"submit\" class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 555, "\"", 613, 3);
            WriteAttributeValue("", 565, "location.href=\'", 565, 15, true);
#nullable restore
#line 16 "C:\Users\Ajdin.Ajdin-PC\Source\Repos\ooad-2019-2020\Grupa7-Tartarus\Tartarus-final\Tartarus-final\Views\Home\Index.cshtml"
WriteAttributeValue("", 580, Url.Action("Index", "Upravnik"), 580, 32, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 612, "\'", 612, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">Access as warden</button></p>
            </div>
        </div>

        <div class=""card ml-5"" style=""width: 18rem; background-color: #a3a2a2; align-items: center;"">
            <img src=""img/Picture1.svg"" class=""card-img-top"" alt=""..."">
            <div class=""card-body"">
                <p class=""card-text""><button style=""background-color: #000000; text-align: center;"" type=""submit"" class=""btn btn-primary""");
            BeginWriteAttribute("onclick", " onclick=\"", 1034, "\"", 1089, 3);
            WriteAttributeValue("", 1044, "location.href=\'", 1044, 15, true);
#nullable restore
#line 23 "C:\Users\Ajdin.Ajdin-PC\Source\Repos\ooad-2019-2020\Grupa7-Tartarus\Tartarus-final\Tartarus-final\Views\Home\Index.cshtml"
WriteAttributeValue("", 1059, Url.Action("Index", "Cuvar"), 1059, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1088, "\'", 1088, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">Access as guard</button></p>
            </div>
        </div>

        <div class=""card ml-5"" style=""width: 18rem; background-color: #a3a2a2; align-items: center;"">
            <img src=""img/Picture3.svg"" class=""card-img-top"" alt=""..."">
            <div class=""card-body"">
                <p class=""card-text""><button style=""background-color: #000000; text-align: center;"" type=""submit"" class=""btn btn-primary""");
            BeginWriteAttribute("onclick", " onclick=\"", 1509, "\"", 1566, 3);
            WriteAttributeValue("", 1519, "location.href=\'", 1519, 15, true);
#nullable restore
#line 30 "C:\Users\Ajdin.Ajdin-PC\Source\Repos\ooad-2019-2020\Grupa7-Tartarus\Tartarus-final\Tartarus-final\Views\Home\Index.cshtml"
WriteAttributeValue("", 1534, Url.Action("Index", "Pravnik"), 1534, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1565, "\'", 1565, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Access as jugde</button></p>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
