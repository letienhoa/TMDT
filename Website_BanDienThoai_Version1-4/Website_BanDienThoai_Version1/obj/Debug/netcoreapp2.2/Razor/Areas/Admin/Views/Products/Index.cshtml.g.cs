#pragma checksum "D:\Nam3\Thuong mai dien tu\TMDT\Website_BanDienThoai_Version1-4\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15a26a536218845369db9ba8c3b147757a1ef88f"
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
#line 1 "D:\Nam3\Thuong mai dien tu\TMDT\Website_BanDienThoai_Version1-4\Website_BanDienThoai_Version1\Areas\Admin\Views\_ViewImports.cshtml"
using Website_BanDienThoai_Version1;

#line default
#line hidden
#line 2 "D:\Nam3\Thuong mai dien tu\TMDT\Website_BanDienThoai_Version1-4\Website_BanDienThoai_Version1\Areas\Admin\Views\_ViewImports.cshtml"
using Website_BanDienThoai_Version1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15a26a536218845369db9ba8c3b147757a1ef88f", @"/Areas/Admin/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcc4be05efaa50b2c45cbaad95c485471343cdaa", @"/Areas/Admin/Views/_ViewImports.cshtml")]
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
#line 2 "D:\Nam3\Thuong mai dien tu\TMDT\Website_BanDienThoai_Version1-4\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";


#line default
#line hidden
            BeginContext(105, 257, true);
            WriteLiteral(@"<br />
<br />
<div class=""row"">
    <div class=""col-6 "" style=""padding-left:40px;font-size:30px; text-align:center;"">

        <p class=""text-info"">Danh sách sản phẩm</p>
    </div>

    <div class=""col-6 text-right"" style=""padding-right:20px;"">
        ");
            EndContext();
            BeginContext(362, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15a26a536218845369db9ba8c3b147757a1ef88f6625", async() => {
                BeginContext(406, 17, true);
                WriteLiteral("Thêm sản phẩm mới");
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
            BeginContext(427, 826, true);
            WriteLiteral(@"
    </div>
</div>
<br />
<div>
    <table class=""table table-striped boder"" style=""font-size:14px;"">
        <tr class=""table-info text-bold"">
            <th style=""width:150px"">
              Tên sản phẩm
            </th>
            <th>
                Ảnh
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
            <th style=""width:120px"">
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
#line 56 "D:\Nam3\Thuong mai dien tu\TMDT\Website_BanDienThoai_Version1-4\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1300, 58, true);
            WriteLiteral("            <tr>\n                <td>\n                    ");
            EndContext();
            BeginContext(1359, 31, false);
#line 60 "D:\Nam3\Thuong mai dien tu\TMDT\Website_BanDienThoai_Version1-4\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1390, 121, true);
            WriteLiteral("\n                </td>\n                <td style=\"width:80px;height:80px\">\n                    <img class=\" card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1511, "\"", 1528, 1);
#line 63 "D:\Nam3\Thuong mai dien tu\TMDT\Website_BanDienThoai_Version1-4\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
WriteAttributeValue("", 1517, item.Image, 1517, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1529, 81, true);
            WriteLiteral(" alt=\"card-img\"/>\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1611, 33, false);
#line 66 "D:\Nam3\Thuong mai dien tu\TMDT\Website_BanDienThoai_Version1-4\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(m => item.Memory));

#line default
#line hidden
            EndContext();
            BeginContext(1644, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1709, 35, false);
#line 69 "D:\Nam3\Thuong mai dien tu\TMDT\Website_BanDienThoai_Version1-4\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(m => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(1744, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1809, 35, false);
#line 72 "D:\Nam3\Thuong mai dien tu\TMDT\Website_BanDienThoai_Version1-4\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(m => item.Capacity));

#line default
#line hidden
            EndContext();
            BeginContext(1844, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1909, 39, false);
#line 75 "D:\Nam3\Thuong mai dien tu\TMDT\Website_BanDienThoai_Version1-4\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(m => item.Manufacturer));

#line default
#line hidden
            EndContext();
            BeginContext(1948, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(2013, 32, false);
#line 78 "D:\Nam3\Thuong mai dien tu\TMDT\Website_BanDienThoai_Version1-4\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(m => item.Color));

#line default
#line hidden
            EndContext();
            BeginContext(2045, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(2110, 32, false);
#line 81 "D:\Nam3\Thuong mai dien tu\TMDT\Website_BanDienThoai_Version1-4\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(m => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2142, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(2207, 40, false);
#line 84 "D:\Nam3\Thuong mai dien tu\TMDT\Website_BanDienThoai_Version1-4\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(m => item.Category.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2247, 44, true);
            WriteLiteral("\n                </td>\n                <td>\n");
            EndContext();
#line 87 "D:\Nam3\Thuong mai dien tu\TMDT\Website_BanDienThoai_Version1-4\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
                     if (!item.SpecialTag.Name.Equals("--None--"))
                    {
                        

#line default
#line hidden
            BeginContext(2405, 42, false);
#line 89 "D:\Nam3\Thuong mai dien tu\TMDT\Website_BanDienThoai_Version1-4\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(m => item.SpecialTag.Name));

#line default
#line hidden
            EndContext();
#line 89 "D:\Nam3\Thuong mai dien tu\TMDT\Website_BanDienThoai_Version1-4\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
                                                                   
                    }

#line default
#line hidden
            BeginContext(2470, 144, true);
            WriteLiteral("                </td>\n                <td style=\"width:150px\">\n                    <div class=\"btn-group\" role=\"group\">\n                        ");
            EndContext();
            BeginContext(2614, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15a26a536218845369db9ba8c3b147757a1ef88f14823", async() => {
                BeginContext(2683, 27, true);
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
#line 94 "D:\Nam3\Thuong mai dien tu\TMDT\Website_BanDienThoai_Version1-4\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
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
            BeginContext(2714, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(2739, 107, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15a26a536218845369db9ba8c3b147757a1ef88f17369", async() => {
                BeginContext(2811, 31, true);
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
#line 95 "D:\Nam3\Thuong mai dien tu\TMDT\Website_BanDienThoai_Version1-4\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
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
            BeginContext(2846, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(2871, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15a26a536218845369db9ba8c3b147757a1ef88f19922", async() => {
                BeginContext(2941, 32, true);
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
#line 96 "D:\Nam3\Thuong mai dien tu\TMDT\Website_BanDienThoai_Version1-4\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"
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
            BeginContext(2977, 68, true);
            WriteLiteral("\n                    </div>\n                </td>\n            </tr>\n");
            EndContext();
#line 100 "D:\Nam3\Thuong mai dien tu\TMDT\Website_BanDienThoai_Version1-4\Website_BanDienThoai_Version1\Areas\Admin\Views\Products\Index.cshtml"

        }

#line default
#line hidden
            BeginContext(3056, 19, true);
            WriteLiteral("    </table>\n</div>");
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
