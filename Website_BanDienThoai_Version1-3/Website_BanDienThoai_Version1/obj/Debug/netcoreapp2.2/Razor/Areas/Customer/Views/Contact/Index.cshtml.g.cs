#pragma checksum "C:\Users\Hoa Le\Downloads\TMDT-Han\Website_BanDienThoai_Version1.3\Website_BanDienThoai_Version1\Areas\Customer\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47f53a5a10d8de36ff7e41c4fefab4e9ed09124a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Contact_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Contact/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/Contact/Index.cshtml", typeof(AspNetCore.Areas_Customer_Views_Contact_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47f53a5a10d8de36ff7e41c4fefab4e9ed09124a", @"/Areas/Customer/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcc4be05efaa50b2c45cbaad95c485471343cdaa", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "C:\Users\Hoa Le\Downloads\TMDT-Han\Website_BanDienThoai_Version1.3\Website_BanDienThoai_Version1\Areas\Customer\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(39, 238, true);
            WriteLiteral("\n<div class=\"main\">\n    <div class=\"content\">\n        <div class=\"section group\">\n            <div class=\"col span_2_of_3\">\n                <div class=\"contact-form\">\n                    <h2>Liên hệ với chúng tôi</h2>\n                    ");
            EndContext();
            BeginContext(277, 779, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47f53a5a10d8de36ff7e41c4fefab4e9ed09124a4225", async() => {
                BeginContext(283, 766, true);
                WriteLiteral(@"
                        <div>
                            <span><label>Tên</label></span>
                            <span><input type=""text"" class=""textbox""></span>
                        </div>
                        <div>
                            <span><label>E-mail</label></span>
                            <span><input type=""text"" class=""textbox""></span>
                        </div>

                        <div>
                            <span><label>Ý kiến </label></span>
                            <span><textarea> </textarea></span>
                        </div>
                        <div>
                            <span><input type=""submit"" value=""Submit"" class=""myButton""></span>
                        </div>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1056, 1937, true);
            WriteLiteral(@"
                </div>
            </div>
            <div class=""col span_1_of_3"">
                <div class=""contact_info"">
                    <h3>Tìm kiếm chúng tôi ở đây</h3>
                    <div class=""mapouter"">
                        <div class=""gmap_canvas"">
                            <iframe width=""600"" height=""500"" id=""gmap_canvas""
                                    src=""https://maps.google.com/maps?q=%C4%90%E1%BA%A1i%20h%E1%BB%8Dc%20s%C6%B0%20ph%E1%BA%A1m%20k%E1%BB%B9%20thu%E1%BA%ADt%20HCM&t=&z=13&ie=UTF8&iwloc=&output=embed""
                                    frameborder=""0"" scrolling=""no"" marginheight=""0"" marginwidth=""0""></iframe><a href=""https://www.embedgooglemap.net/blog/nordvpn-coupon-code/""></a>
                        </div>
                        <style>
                            .mapouter {
                                position: relative;
                                text-align: right;
                                height: 400px;
                                width");
            WriteLiteral(@": 400px;
                            }

                            .gmap_canvas {
                                overflow: hidden;
                                background: none !important;
                                height: 400px;
                                width: 400px;
                            }
                        </style>
                    </div>
                </div>
                <br>
                <div class=""company_address"">
                    <h3>Thông tin cửa hàng :</h3>
                    <p>Hoàng Diệu 2,Linh Chiểu,Thủ Đức,HCM, Việt Nam </p>
                    <p>Điện thoại:(00) 222 666 444</p>
                    <p>Email: <span><a href=""https://www.facebook.com/nhoxlexit"">TMDT.HCMUTE</a></span></p>
                    <p>Liên hệ qua: <span>https://www.facebook.com/nhoxlexit</span>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
