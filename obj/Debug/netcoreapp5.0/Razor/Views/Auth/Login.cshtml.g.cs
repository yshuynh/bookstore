#pragma checksum "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Auth\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d95b1d590b64a1a1de225b5e0dd6d957e2cf744"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_Login), @"mvc.1.0.view", @"/Views/Auth/Login.cshtml")]
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
#line 1 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\_ViewImports.cshtml"
using book;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\_ViewImports.cshtml"
using book.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d95b1d590b64a1a1de225b5e0dd6d957e2cf744", @"/Views/Auth/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24dd35a86a2649ee4fe97baa6f28501d756792cf", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<bool>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn--normal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("auth__form auth__form-signin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("auth__form auth__form-login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/auth/login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Auth\Login.cshtml"
                                   
    ViewData["Title"] = "Home Page";
    bool isRegister = Model;
    string formRegister;
    string formLogin;
    if (isRegister) {
        formRegister = "display: flex;";
        formLogin = "display: none;";
    } else {
        formLogin = "display: flex;";
        formRegister = "display: none;";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Modal -->\r\n<div class=\"modal \" id=\"modal\"");
            BeginWriteAttribute("style", " style=\"", 428, "\"", 449, 1);
#nullable restore
#line 18 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Auth\Login.cshtml"
WriteAttributeValue("", 436, formRegister, 436, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"modal__body border-light border rounded\">\r\n        <!-- Register form -->\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d95b1d590b64a1a1de225b5e0dd6d957e2cf7446596", async() => {
                WriteLiteral(@"
            <div class=""auth__form-container"">
                <div class=""auth__form-header"">
                    <h3 class=""auth__form-heading"">Đăng ký</h3>
                    <a id=""btn-login"" class=""auth__form-switch-btn"">Đăng nhập</a>
                </div>
                <div class=""auth__form-form"">
                    <div class=""auth__form-group"">
                        <input type=""text"" class=""auth__form-input"" placeholder=""Nhập email của bạn"">
                    </div>
                    <div class=""auth__form-group"">
                        <input type=""text"" class=""auth__form-input"" placeholder=""Nhập mật khẩu"">
                    </div>
                    <div class=""auth__form-group"">
                        <input type=""text"" class=""auth__form-input"" placeholder=""Nhập lại mật khẩu"">
                    </div>

                </div>
                <div class=""auth__form-info"">
                    <p>Bằng việc đăng ký,bạn đã đồng ý với chúng tôi về
                 ");
                WriteLiteral("       <a");
                BeginWriteAttribute("href", " href=\"", 1628, "\"", 1635, 0);
                EndWriteAttribute();
                WriteLiteral(">Điều khoản dịch vụ</a> & <a");
                BeginWriteAttribute("href", " href=\"", 1664, "\"", 1671, 0);
                EndWriteAttribute();
                WriteLiteral(">Chính sách bảo mật</a>\r\n                    </p>\r\n                </div>\r\n                <div class=\"auth__form-btn\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d95b1d590b64a1a1de225b5e0dd6d957e2cf7448440", async() => {
                    WriteLiteral("QUAY LẠI");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <button class=\"btn btn--primary\">ĐĂNG KÝ</button>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"auth__form-social\">\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 2085, "\"", 2092, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"auth__form-social-facebook btn btn--sizes btn--withicon \">\r\n                    <i class=\"fab fa-facebook\"></i>\r\n                    <span class=\"auth__form-social-label\">Kết nối với Facebook</span>\r\n                </a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 2341, "\"", 2348, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"auth__form-social-google btn btn--sizes btn--withicon \">\r\n                    <i class=\"fab fa-google\"></i>\r\n                    <span class=\"auth__form-social-label\">Kết nối với Google</span>\r\n                </a>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n        <!--Login form  -->\r\n\r\n    </div>\r\n</div>\r\n<div class=\"modal1\"");
            BeginWriteAttribute("style", " style=\"", 2684, "\"", 2702, 1);
#nullable restore
#line 67 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Auth\Login.cshtml"
WriteAttributeValue("", 2692, formLogin, 2692, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"modal__body border-light border rounded\">\r\n        <!-- Register form -->\r\n        <!--Login form  -->\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d95b1d590b64a1a1de225b5e0dd6d957e2cf74412637", async() => {
                WriteLiteral(@"
            <div class=""auth__form-container"">
                <div class=""auth__form-header"">
                    <h3 class=""auth__form-heading"">Đăng nhập</h3>
                    <a id=""btn-sign"" class=""auth__form-switch-btn"">Đăng ký</a>
                </div>
                <div class=""auth__form-form"">
                    <div class=""auth__form-group"">
                        <input name=""email"" type=""text"" class=""auth__form-input"" placeholder=""Nhập email của bạn"">
                    </div>
                    <div class=""auth__form-group"">
                        <input name=""password"" type=""text"" class=""auth__form-input"" placeholder=""Nhập mật khẩu"">
                    </div>

                </div>
                <div class=""auth__form-aside"">
                    <div class=""auth__form-help"">
                        <a");
                BeginWriteAttribute("href", " href=\"", 3769, "\"", 3776, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"auth__form-link auth__form-fogot\">Quên mật khẩu</a>\r\n                        <span class=\"auth__form-help-sperate\"></span>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 3935, "\"", 3942, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"auth__form-link auth__form-help-link\">Cần trợ giúp ?</a>\r\n                    </div>\r\n                </div>\r\n                <div class=\"auth__form-btn\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d95b1d590b64a1a1de225b5e0dd6d957e2cf74414453", async() => {
                    WriteLiteral("QUAY LẠI");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <button type=\"submit\" class=\"btn btn--primary\">ĐĂNG NHẬP</button>\r\n                </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        <div class=\"auth__form-social\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 4404, "\"", 4411, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"auth__form-social-facebook btn btn--sizes btn--withicon \">\r\n                <i class=\"fab fa-facebook\"></i>\r\n                <span class=\"auth__form-social-label\">Kết nối với Facebook</span>\r\n            </a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 4644, "\"", 4651, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"auth__form-social-google btn btn--sizes btn--withicon \">\r\n                <i class=\"fab fa-google\"></i>\r\n                <span class=\"auth__form-social-label\">Kết nối với Google</span>\r\n            </a>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<bool> Html { get; private set; }
    }
}
#pragma warning restore 1591
