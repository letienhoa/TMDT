#pragma checksum "E:\Data\Studying\Năm 3\Học kỳ 2\TMDT\Final project\TMDT - Copy\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0417fb94695c8603b0db8c1d601ac79bd9f44803"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Products_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Products/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Products/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Products_Index))]
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
#line 1 "E:\Data\Studying\Năm 3\Học kỳ 2\TMDT\Final project\TMDT - Copy\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Areas\Admin\Views\_ViewImports.cshtml"
using Website_BanDienThoai_Version1;

#line default
#line hidden
#line 2 "E:\Data\Studying\Năm 3\Học kỳ 2\TMDT\Final project\TMDT - Copy\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Areas\Admin\Views\_ViewImports.cshtml"
using Website_BanDienThoai_Version1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0417fb94695c8603b0db8c1d601ac79bd9f44803", @"/Areas/Admin/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9b50acd34197c6e7490297201e6085d60464264", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Website_BanDienThoai_Version1.Models.Products>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Data\Studying\Năm 3\Học kỳ 2\TMDT\Final project\TMDT - Copy\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";


#line default
#line hidden
            BeginContext(110, 266, true);
            WriteLiteral(@"<br />
<br />
<div class=""row"">
    <div class=""col-6 "" style=""padding-left:40px;font-size:30px; text-align:center;"">

        <p class=""text-info"">Danh sách sản phẩm</p>
    </div>

    <div class=""col-6 text-right"" style=""padding-right:20px;"">
        ");
            EndContext();
            BeginContext(376, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0417fb94695c8603b0db8c1d601ac79bd9f448036761", async() => {
                BeginContext(420, 11, true);
                WriteLiteral("New Product");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(435, 833, true);
            WriteLiteral(@"
    </div>
</div>
<br />
<div>
    <table class=""table table-striped boder"" style=""font-size:14px;"">
        <tr class=""table-info text-bold"">
            <th>
              Tên sản phẩm
            </th>
            <th>
                Link ảnh
            </th>

            <th>
                Ram
            </th>
            <td>
               Số lượng
            </td>
            <th>
                Bộ nhớ
            </th>
            <th>
                Nhà sản xuất
            </th>
            <th>
                Màu
            </th>
            <th>
                Giá
            </th>
            <th>
                Danh mục
            </th>
            <th>
                Loại
            </th>
            <th>
            </th>
        </tr>
");
            EndContext();
#line 56 "E:\Data\Studying\Năm 3\Học kỳ 2\TMDT\Final project\TMDT - Copy\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1317, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1378, 31, false);
#line 60 "E:\Data\Studying\Năm 3\Học kỳ 2\TMDT\Final project\TMDT - Copy\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1409, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1477, 32, false);
#line 63 "E:\Data\Studying\Năm 3\Học kỳ 2\TMDT\Final project\TMDT - Copy\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(m => item.Image));

#line default
#line hidden
            EndContext();
            BeginContext(1509, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1577, 33, false);
#line 66 "E:\Data\Studying\Năm 3\Học kỳ 2\TMDT\Final project\TMDT - Copy\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(m => item.Memory));

#line default
#line hidden
            EndContext();
            BeginContext(1610, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1678, 35, false);
#line 69 "E:\Data\Studying\Năm 3\Học kỳ 2\TMDT\Final project\TMDT - Copy\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(m => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(1713, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1781, 35, false);
#line 72 "E:\Data\Studying\Năm 3\Học kỳ 2\TMDT\Final project\TMDT - Copy\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(m => item.Capacity));

#line default
#line hidden
            EndContext();
            BeginContext(1816, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1884, 39, false);
#line 75 "E:\Data\Studying\Năm 3\Học kỳ 2\TMDT\Final project\TMDT - Copy\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(m => item.Manufacturer));

#line default
#line hidden
            EndContext();
            BeginContext(1923, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1991, 32, false);
#line 78 "E:\Data\Studying\Năm 3\Học kỳ 2\TMDT\Final project\TMDT - Copy\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(m => item.Color));

#line default
#line hidden
            EndContext();
            BeginContext(2023, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2091, 32, false);
#line 81 "E:\Data\Studying\Năm 3\Học kỳ 2\TMDT\Final project\TMDT - Copy\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(m => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2123, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2191, 40, false);
#line 84 "E:\Data\Studying\Năm 3\Học kỳ 2\TMDT\Final project\TMDT - Copy\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(m => item.Category.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2231, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 87 "E:\Data\Studying\Năm 3\Học kỳ 2\TMDT\Final project\TMDT - Copy\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
                     if (!item.SpecialTag.Name.Equals("--None--"))
                    {
                        

#line default
#line hidden
            BeginContext(2394, 42, false);
#line 89 "E:\Data\Studying\Năm 3\Học kỳ 2\TMDT\Final project\TMDT - Copy\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(m => item.SpecialTag.Name));

#line default
#line hidden
            EndContext();
#line 89 "E:\Data\Studying\Năm 3\Học kỳ 2\TMDT\Final project\TMDT - Copy\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
                                                                   
                    }

#line default
#line hidden
            BeginContext(2461, 147, true);
            WriteLiteral("                </td>\r\n                <td style=\"width:150px\">\r\n                    <div class=\"btn-group\" role=\"group\">\r\n                        ");
            EndContext();
            BeginContext(2608, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0417fb94695c8603b0db8c1d601ac79bd9f4480315308", async() => {
                BeginContext(2677, 27, true);
                WriteLiteral("<i class=\"fas fa-edit\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 94 "E:\Data\Studying\Năm 3\Học kỳ 2\TMDT\Final project\TMDT - Copy\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
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
            BeginContext(2708, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2734, 107, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0417fb94695c8603b0db8c1d601ac79bd9f4480317887", async() => {
                BeginContext(2806, 31, true);
                WriteLiteral("<i class=\"fas fa-list-alt\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 95 "E:\Data\Studying\Năm 3\Học kỳ 2\TMDT\Final project\TMDT - Copy\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
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
            BeginContext(2841, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2867, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0417fb94695c8603b0db8c1d601ac79bd9f4480320473", async() => {
                BeginContext(2937, 32, true);
                WriteLiteral("<i class=\"fas fa-trash-alt\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 96 "E:\Data\Studying\Năm 3\Học kỳ 2\TMDT\Final project\TMDT - Copy\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
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
            BeginContext(2973, 72, true);
            WriteLiteral("\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 100 "E:\Data\Studying\Năm 3\Học kỳ 2\TMDT\Final project\TMDT - Copy\Website_BanDienThoai_Version1.2\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"

        }

#line default
#line hidden
            BeginContext(3058, 20, true);
            WriteLiteral("    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Website_BanDienThoai_Version1.Models.Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591
