#pragma checksum "C:\Users\Hoa Le\Downloads\TMDT-Han\Website_BanDienThoai_Version1.3\Website_BanDienThoai_Version1\Areas\Customer\Views\Account\FogetPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb9f743958ff75b584dfc80a364ac4cb4ea1f53d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Account_FogetPassword), @"mvc.1.0.view", @"/Areas/Customer/Views/Account/FogetPassword.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/Account/FogetPassword.cshtml", typeof(AspNetCore.Areas_Customer_Views_Account_FogetPassword))]
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
#line 1 "C:\Users\Hoa Le\Downloads\TMDT-Han\Website_BanDienThoai_Version1.3\Website_BanDienThoai_Version1\Areas\Customer\Views\_ViewImports.cshtml"
using Website_BanDienThoai_Version1;

#line default
#line hidden
#line 2 "C:\Users\Hoa Le\Downloads\TMDT-Han\Website_BanDienThoai_Version1.3\Website_BanDienThoai_Version1\Areas\Customer\Views\_ViewImports.cshtml"
using Website_BanDienThoai_Version1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb9f743958ff75b584dfc80a364ac4cb4ea1f53d", @"/Areas/Customer/Views/Account/FogetPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcc4be05efaa50b2c45cbaad95c485471343cdaa", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Account_FogetPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("accept-charset", new global::Microsoft.AspNetCore.Html.HtmlString("UTF-8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("login-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Hoa Le\Downloads\TMDT-Han\Website_BanDienThoai_Version1.3\Website_BanDienThoai_Version1\Areas\Customer\Views\Account\FogetPassword.cshtml"
  
    Layout = "~/Areas/Customer/Views/Shared/_AccountView.cshtml";

#line default
#line hidden
            BeginContext(71, 347, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-6 col-md-offset-3"">
            <h4 style=""border-bottom: 1px solid #c5c5c5;"">
                <i class=""glyphicon glyphicon-user"">
                </i>
                Tài khoản
            </h4>
            <div style=""padding: 20px;"" id=""form-olvidado"">
                ");
            EndContext();
            BeginContext(418, 1727, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb9f743958ff75b584dfc80a364ac4cb4ea1f53d5670", async() => {
                BeginContext(489, 1649, true);
                WriteLiteral(@"
                    <fieldset>
                        <div class=""form-group input-group"">
                            <span class=""input-group-addon"">
                                Mail:
                            </span>
                            <input class=""form-control"" placeholder=""Email"" name=""email"" type=""email"" required=""""
                                   autofocus="""">
                        </div>
                        <div class=""form-group input-group"">
                            <span class=""input-group-addon"">
                                <i class=""glyphicon glyphicon-lock"">
                                </i>
                            </span>
                            <input class=""form-control"" placeholder=""New Password"" name=""password"" type=""password"" value=""""
                                   required="""">
                        </div>
                        <div class=""form-group input-group"">
                            <span class=""input-group-addon"">
             ");
                WriteLiteral(@"                   <i class=""glyphicon glyphicon-lock"">
                                </i>
                            </span>
                            <input class=""form-control"" placeholder=""Password Confirmed"" name=""password"" type=""password"" value=""""
                                   required="""">
                        </div>
                        <div class=""form-group"">
                            <button type=""submit"" class=""btn btn-primary btn-block"">
                                Gửi
                            </button>
                        </div>
                    </fieldset>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2145, 52, true);
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
