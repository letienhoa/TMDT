#pragma checksum "C:\Users\Hoa Le\Desktop\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Views\Shared\_AppointmentProductDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e689c9ebdc4dc4556d4d10cc3cdd72320d2ef15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AppointmentProductDetails), @"mvc.1.0.view", @"/Views/Shared/_AppointmentProductDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_AppointmentProductDetails.cshtml", typeof(AspNetCore.Views_Shared__AppointmentProductDetails))]
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
#line 1 "C:\Users\Hoa Le\Desktop\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Views\_ViewImports.cshtml"
using Website_BanDienThoai_Version1;

#line default
#line hidden
#line 2 "C:\Users\Hoa Le\Desktop\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Views\_ViewImports.cshtml"
using Website_BanDienThoai_Version1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e689c9ebdc4dc4556d4d10cc3cdd72320d2ef15", @"/Views/Shared/_AppointmentProductDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9b50acd34197c6e7490297201e6085d60464264", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AppointmentProductDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Website_BanDienThoai_Version1.Models.Products>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(192, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 6 "C:\Users\Hoa Le\Desktop\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Views\Shared\_AppointmentProductDetails.cshtml"
     if (Model.Count > 0)
{

#line default
#line hidden
            BeginContext(226, 208, true);
            WriteLiteral("    <table class=\"table table-striped\" width=\"100%\">\r\n        <tr class=\"table-info\">\r\n            <th style=\"text-align:center; width:20%\"></th>\r\n            <th style=\"text-align:center;\">\r\n                ");
            EndContext();
            BeginContext(434, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e689c9ebdc4dc4556d4d10cc3cdd72320d2ef155181", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 12 "C:\Users\Hoa Le\Desktop\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Views\Shared\_AppointmentProductDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FirstOrDefault().Name);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(488, 82, true);
            WriteLiteral("\r\n            </th>\r\n            <th style=\"text-align:center;\">\r\n                ");
            EndContext();
            BeginContext(570, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e689c9ebdc4dc4556d4d10cc3cdd72320d2ef156869", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 15 "C:\Users\Hoa Le\Desktop\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Views\Shared\_AppointmentProductDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FirstOrDefault().Price);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(625, 82, true);
            WriteLiteral("\r\n            </th>\r\n            <th style=\"text-align:center;\">\r\n                ");
            EndContext();
            BeginContext(707, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e689c9ebdc4dc4556d4d10cc3cdd72320d2ef158558", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 18 "C:\Users\Hoa Le\Desktop\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Views\Shared\_AppointmentProductDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FirstOrDefault().Memory);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(763, 82, true);
            WriteLiteral("\r\n            </th>\r\n            <th style=\"text-align:center;\">\r\n                ");
            EndContext();
            BeginContext(845, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e689c9ebdc4dc4556d4d10cc3cdd72320d2ef1510248", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 21 "C:\Users\Hoa Le\Desktop\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Views\Shared\_AppointmentProductDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FirstOrDefault().Color);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(900, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th style=\"text-align:center;\"></th>\r\n        </tr>\r\n");
            EndContext();
#line 25 "C:\Users\Hoa Le\Desktop\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Views\Shared\_AppointmentProductDetails.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1035, 70, true);
            WriteLiteral("        <tr style=\"padding:50px;\">\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1105, 253, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e689c9ebdc4dc4556d4d10cc3cdd72320d2ef1512348", async() => {
                BeginContext(1195, 26, true);
                WriteLiteral("\r\n                    <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1221, "\"", 1238, 1);
#line 30 "C:\Users\Hoa Le\Desktop\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Views\Shared\_AppointmentProductDetails.cshtml"
WriteAttributeValue("", 1227, item.Image, 1227, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1239, 115, true);
                WriteLiteral(" width=\"100%\" style=\"margin:auto; display:block; border-radius:5px; border:1px solid #bbb9b9;\" />\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 29 "C:\Users\Hoa Le\Desktop\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Views\Shared\_AppointmentProductDetails.cshtml"
                                                                                    WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1358, 81, true);
            WriteLiteral("\r\n            </td>\r\n            <td style=\"text-align:center\">\r\n                ");
            EndContext();
            BeginContext(1440, 31, false);
#line 34 "C:\Users\Hoa Le\Desktop\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Views\Shared\_AppointmentProductDetails.cshtml"
           Write(Html.DisplayFor(c => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1471, 81, true);
            WriteLiteral("\r\n            </td>\r\n            <td style=\"text-align:center\">\r\n                ");
            EndContext();
            BeginContext(1553, 32, false);
#line 37 "C:\Users\Hoa Le\Desktop\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Views\Shared\_AppointmentProductDetails.cshtml"
           Write(Html.DisplayFor(c => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1585, 81, true);
            WriteLiteral("\r\n            </td>\r\n            <td style=\"text-align:center\">\r\n                ");
            EndContext();
            BeginContext(1667, 33, false);
#line 40 "C:\Users\Hoa Le\Desktop\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Views\Shared\_AppointmentProductDetails.cshtml"
           Write(Html.DisplayFor(c => item.Memory));

#line default
#line hidden
            EndContext();
            BeginContext(1700, 81, true);
            WriteLiteral("\r\n            </td>\r\n            <td style=\"text-align:center\">\r\n                ");
            EndContext();
            BeginContext(1782, 32, false);
#line 43 "C:\Users\Hoa Le\Desktop\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Views\Shared\_AppointmentProductDetails.cshtml"
           Write(Html.DisplayFor(c => item.Color));

#line default
#line hidden
            EndContext();
            BeginContext(1814, 99, true);
            WriteLiteral("\r\n            </td>\r\n            <td style=\"text-align:center\">\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 48 "C:\Users\Hoa Le\Desktop\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Views\Shared\_AppointmentProductDetails.cshtml"

        }

#line default
#line hidden
            BeginContext(1926, 14, true);
            WriteLiteral("    </table>\r\n");
            EndContext();
#line 51 "C:\Users\Hoa Le\Desktop\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Views\Shared\_AppointmentProductDetails.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1952, 55, true);
            WriteLiteral("    <div>No items added to the shopping cart...</div>\r\n");
            EndContext();
#line 55 "C:\Users\Hoa Le\Desktop\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Views\Shared\_AppointmentProductDetails.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Website_BanDienThoai_Version1.Models.Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591
