#pragma checksum "C:\Users\wajeeh\OneDrive\Desktop\test\SözlükForum\Views\ForumSoru\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea9ab937bbfb3626ce8793c74b69339f2de86c36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ForumSoru_Detail), @"mvc.1.0.view", @"/Views/ForumSoru/Detail.cshtml")]
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
#line 1 "C:\Users\wajeeh\OneDrive\Desktop\test\SözlükForum\Views\_ViewImports.cshtml"
using SözlükForum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wajeeh\OneDrive\Desktop\test\SözlükForum\Views\_ViewImports.cshtml"
using SözlükForum.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\wajeeh\OneDrive\Desktop\test\SözlükForum\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea9ab937bbfb3626ce8793c74b69339f2de86c36", @"/Views/ForumSoru/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4bb6bc2e9ae94685adfdbeda196cefeb22039f3", @"/Views/_ViewImports.cshtml")]
    public class Views_ForumSoru_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SözlükForum.Models.ViewData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 5 "C:\Users\wajeeh\OneDrive\Desktop\test\SözlükForum\Views\ForumSoru\Detail.cshtml"
  
    var baslık = @Model.forumSoruss.First();
    var baslıkk = baslık.soru;
    ViewData["Title"] = baslıkk;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div style=\"background-color:#4ba2bd; border-radius: 5% \" class=\"container\">\r\n");
#nullable restore
#line 11 "C:\Users\wajeeh\OneDrive\Desktop\test\SözlükForum\Views\ForumSoru\Detail.cshtml"
     foreach (var item in Model.forumSoruss)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <h2 class=\"text-center\">");
#nullable restore
#line 14 "C:\Users\wajeeh\OneDrive\Desktop\test\SözlükForum\Views\ForumSoru\Detail.cshtml"
                               Write(Html.DisplayFor(modelItem => item.soru));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n            <p class=\"text-right\">");
#nullable restore
#line 16 "C:\Users\wajeeh\OneDrive\Desktop\test\SözlükForum\Views\ForumSoru\Detail.cshtml"
                             Write(Html.DisplayFor(modelItem => item.kullanici.kullanıcıAd));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        </div>\r\n        <hr />\r\n        <div>\r\n            <p>");
#nullable restore
#line 21 "C:\Users\wajeeh\OneDrive\Desktop\test\SözlükForum\Views\ForumSoru\Detail.cshtml"
          Write(Html.DisplayFor(modelItem => item.icerik));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"text-right\"><i>");
#nullable restore
#line 22 "C:\Users\wajeeh\OneDrive\Desktop\test\SözlükForum\Views\ForumSoru\Detail.cshtml"
                                Write(Html.DisplayFor(modelItem => item.eklemeTarih));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>\r\n        </div>\r\n");
#nullable restore
#line 24 "C:\Users\wajeeh\OneDrive\Desktop\test\SözlükForum\Views\ForumSoru\Detail.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<br />\r\n<div>\r\n\r\n    <h5>Yorumlar:</h5>\r\n");
#nullable restore
#line 30 "C:\Users\wajeeh\OneDrive\Desktop\test\SözlükForum\Views\ForumSoru\Detail.cshtml"
     if (User.Identity.IsAuthenticated)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea9ab937bbfb3626ce8793c74b69339f2de86c366204", async() => {
                WriteLiteral("\r\n            ");
#nullable restore
#line 33 "C:\Users\wajeeh\OneDrive\Desktop\test\SözlükForum\Views\ForumSoru\Detail.cshtml"
       Write(Html.TextBoxFor(x => x.yorumss.Icerik, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <button type=\"submit\" class=\"btn btn-block btn-primary\">Gönder</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 952, "/ForumSoru/Detail/", 952, 18, true);
#nullable restore
#line 32 "C:\Users\wajeeh\OneDrive\Desktop\test\SözlükForum\Views\ForumSoru\Detail.cshtml"
AddHtmlAttributeValue("", 970, Model.forumSoruss.First().Id, 970, 29, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 36 "C:\Users\wajeeh\OneDrive\Desktop\test\SözlükForum\Views\ForumSoru\Detail.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-info\">\r\n            <strong>Giriş!</strong> yapmanız gerekiyor...\r\n        </div>\r\n");
#nullable restore
#line 42 "C:\Users\wajeeh\OneDrive\Desktop\test\SözlükForum\Views\ForumSoru\Detail.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n    <div class=\"container\">\r\n");
#nullable restore
#line 46 "C:\Users\wajeeh\OneDrive\Desktop\test\SözlükForum\Views\ForumSoru\Detail.cshtml"
         foreach (var item in Model.yorums)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div style=\"background-color:#4ba2bd; border-radius: 5%; \">\r\n                <p style=\"padding:1%\">\r\n                    ");
#nullable restore
#line 50 "C:\Users\wajeeh\OneDrive\Desktop\test\SözlükForum\Views\ForumSoru\Detail.cshtml"
               Write(Html.DisplayFor(modelItem => item.Icerik));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <p style=\"font-size:11px;\" align=\"right\"><i>");
#nullable restore
#line 51 "C:\Users\wajeeh\OneDrive\Desktop\test\SözlükForum\Views\ForumSoru\Detail.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.kullanici.kullanıcıAd));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ~ ");
#nullable restore
#line 51 "C:\Users\wajeeh\OneDrive\Desktop\test\SözlükForum\Views\ForumSoru\Detail.cshtml"
                                                                                                                   Write(Html.DisplayFor(modelItem => item.Zaman));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>\r\n                </p>\r\n            </div>\r\n            <hr />\r\n");
#nullable restore
#line 55 "C:\Users\wajeeh\OneDrive\Desktop\test\SözlükForum\Views\ForumSoru\Detail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SözlükForum.Models.ViewData> Html { get; private set; }
    }
}
#pragma warning restore 1591
