#pragma checksum "C:\Workspace_Main\BackEnd2\AzTUChat\AzTUChat\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdc64c6f9ea20a15ad3acc3cb08cf539a45698f6"
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
#line 1 "C:\Workspace_Main\BackEnd2\AzTUChat\AzTUChat\Views\_ViewImports.cshtml"
using AzTUChat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Workspace_Main\BackEnd2\AzTUChat\AzTUChat\Views\_ViewImports.cshtml"
using AzTUChat.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Workspace_Main\BackEnd2\AzTUChat\AzTUChat\Views\_ViewImports.cshtml"
using AzTUChat.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdc64c6f9ea20a15ad3acc3cb08cf539a45698f6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39525a37d15f99a6a2f2cdeb56e0bd422b47b826", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/microsoft/signalr/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/chat.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Workspace_Main\BackEnd2\AzTUChat\AzTUChat\Views\Home\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdc64c6f9ea20a15ad3acc3cb08cf539a45698f65189", async() => {
                WriteLiteral(@"

    <meta charset=""UTF-8"">

    <link rel=""apple-touch-icon"" type=""image/png"" href=""https://cpwebassets.codepen.io/assets/favicon/apple-touch-icon-5ae1a0698dcc2402e9712f7d01ed509a57814f994c660df9f7a952f3060705ee.png"">
    <meta name=""apple-mobile-web-app-title"" content=""CodePen"">
    <link rel=""shortcut icon"" type=""image/x-icon"" href=""https://cpwebassets.codepen.io/assets/favicon/favicon-aec34940fbc1a6e787974dcd360f2c6b63348d4b1f4e06c77743096d55480f33.ico"">
    <link rel=""mask-icon"" type=""image/x-icon"" href=""https://cpwebassets.codepen.io/assets/favicon/logo-pin-8f3771b1072e3c38bd662872f6b673a722f4b3ca2421637d5596661b4e2132cc.svg"" color=""#111"">
    <title>CodePen - Material Messaging App Concept</title>
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Montserrat"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.0.");
                WriteLiteral("0-alpha.6/css/bootstrap.min.css\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fdc64c6f9ea20a15ad3acc3cb08cf539a45698f66582", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        window.console = window.console || function (t) { };
    </script>



    <script>
        if (document.location.search.match(/type=embed/gi)) {
            window.parent.postMessage(""resize"", ""*"");
        }
    </script>


");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdc64c6f9ea20a15ad3acc3cb08cf539a45698f68726", async() => {
                WriteLiteral(@"
    <div class=""container"">
        <div class=""row"">
            <section class=""discussions"">
                <div class=""discussion search"">
                    <div class=""searchbar"">
                        <i class=""fa fa-search"" aria-hidden=""true""></i>
                        <input type=""text"" placeholder=""Search..."">
                    </div>
                </div>
");
#nullable restore
#line 56 "C:\Workspace_Main\BackEnd2\AzTUChat\AzTUChat\Views\Home\Index.cshtml"
                 foreach (AppUser item in Model.Users)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"discussion\">\r\n                    <div class=\"photo\"");
                BeginWriteAttribute("style", " style=\"", 2667, "\"", 2742, 4);
                WriteAttributeValue("", 2675, "background-image:", 2675, 17, true);
                WriteAttributeValue(" ", 2692, "url(../image/profileimage/", 2693, 27, true);
#nullable restore
#line 59 "C:\Workspace_Main\BackEnd2\AzTUChat\AzTUChat\Views\Home\Index.cshtml"
WriteAttributeValue("", 2719, item.UserImage.Image, 2719, 21, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2740, ");", 2740, 2, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div");
                BeginWriteAttribute("id", " id=\"", 2774, "\"", 2793, 1);
#nullable restore
#line 60 "C:\Workspace_Main\BackEnd2\AzTUChat\AzTUChat\Views\Home\Index.cshtml"
WriteAttributeValue("", 2779, item.UserName, 2779, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("class", " class=\"", 2794, "\"", 2854, 2);
                WriteAttributeValue("", 2802, "status", 2802, 6, true);
#nullable restore
#line 60 "C:\Workspace_Main\BackEnd2\AzTUChat\AzTUChat\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 2808, item.ConnectionId!=null?"online":"offline", 2809, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></div>\r\n                    </div>\r\n                    <div class=\"desc-contact\">\r\n                        <p class=\"name\">");
#nullable restore
#line 63 "C:\Workspace_Main\BackEnd2\AzTUChat\AzTUChat\Views\Home\Index.cshtml"
                                   Write(item.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    </div>\r\n                </div>                    \n");
#nullable restore
#line 66 "C:\Workspace_Main\BackEnd2\AzTUChat\AzTUChat\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                \r\n            </section>\r\n            <section class=\"chat\">\r\n                <div class=\"header-chat\">\r\n                    <i class=\"icon fa fa-user-o\" aria-hidden=\"true\"></i>\r\n                    <p class=\"name\">");
#nullable restore
#line 73 "C:\Workspace_Main\BackEnd2\AzTUChat\AzTUChat\Views\Home\Index.cshtml"
                               Write(Model.CurrentUser.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                    <i class=""icon clickable fa fa-ellipsis-h right"" aria-hidden=""true""></i>
                </div>
                <div class=""messages-chat"">
                
                    
                </div>
                <div class=""footer-chat"">
                    <i class=""icon fa fa-smile-o clickable"" style=""font-size:25pt;"" aria-hidden=""true""></i>
                    <input id=""messageInput"" type=""text"" class=""write-message"" placeholder=""Type your message here"">
                    <i id=""sendButton""");
                BeginWriteAttribute("username", " username=\"", 3891, "\"", 3902, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"icon send fa fa-paper-plane-o clickable\" aria-hidden=\"true\"></i>\r\n                </div>\r\n            </section>\r\n        </div>\r\n    </div>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdc64c6f9ea20a15ad3acc3cb08cf539a45698f613252", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script src=\"https://code.jquery.com/jquery-3.6.0.min.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdc64c6f9ea20a15ad3acc3cb08cf539a45698f614429", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
