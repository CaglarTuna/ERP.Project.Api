#pragma checksum "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\ProductStockEntry.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58796b3fe36a345f50ae35d5ba9e29b1bb818e92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductStockEntry), @"mvc.1.0.view", @"/Views/Product/ProductStockEntry.cshtml")]
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
#line 1 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\_ViewImports.cshtml"
using DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\_ViewImports.cshtml"
using Presentation.ResponseModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58796b3fe36a345f50ae35d5ba9e29b1bb818e92", @"/Views/Product/ProductStockEntry.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5190a7fa70597cf0160e9fb4f31b4a4a8d5480ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductStockEntry : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateProductStock", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-success", new global::Microsoft.AspNetCore.Html.HtmlString("onSuccess"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("POST"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\ProductStockEntry.cshtml"
  
    ViewData["Title"] = "ProductStockEntry";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""wrapper wrapper-content animated fadeInRight mt60"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <fieldset class=""fieldset"">
                <legend class=""fieldsetb"">Siparişteki Ürünler Listesi</legend>

                <div class=""row"">
                    <div class=""col-xs-12"">
                        <div class=""table-responsive mb10"">
                            <table class=""table table-striped table-bordered table-hover dataTables dataTable "">
                                <thead>
                                    <tr>
                                        <th>Ürün Girişini Yap</th>
                                        <th>Planlanan Ürün Sayısı</th>
                                        <th>Üretim Seri No</th>
                                        <th>Ürün No</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 25 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\ProductStockEntry.cshtml"
                                     foreach (var item in Model.OrderProducts)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td><a");
            BeginWriteAttribute("onclick", " onclick=\"", 1303, "\"", 1333, 3);
            WriteAttributeValue("", 1313, "getProduct(", 1313, 11, true);
#nullable restore
#line 28 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\ProductStockEntry.cshtml"
WriteAttributeValue("", 1324, item.Id, 1324, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1332, ")", 1332, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Ürün Girişi Yap</a></td>\r\n                                            <td>");
#nullable restore
#line 29 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\ProductStockEntry.cshtml"
                                           Write(item.Quantitiy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 30 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\ProductStockEntry.cshtml"
                                           Write(item.Products.ProductionSerialNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 31 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\ProductStockEntry.cshtml"
                                           Write(item.Products.BarcodeNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 33 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\ProductStockEntry.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>

            </fieldset>
        </div>
    </div>

    <div class=""modal fade"" id=""saveModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58796b3fe36a345f50ae35d5ba9e29b1bb818e929423", async() => {
                WriteLiteral(@"
                    <div class=""modal-header"">
                        <button type=""button"" class=""close"" data-dismiss=""modal""
                                aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                        <h4 class=""modal-title"" id=""myModalLabel"">Depoya Ürün Ekle</h4>
                    </div>
                    <div class=""modal-body productModal"">

                    </div>
                    <div class=""modal-footer"">
                        <button type=""submit"" class=""btn btn-primary"" style=""margin-right:12px"">KAYDET</button>
                    </div>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>
<script>
    function LoadEditPage() {
        setTimeout(function () { window.location.reload() }, 2000);
    }
    var ProductModal = $('.productModal');
    function getProduct(id) {
        $.get('/Product/ProductEntryModal', { id: id }).done(function (data) {
            ProductModal.empty();
            ProductModal.html(data);
            $('#saveModal').modal('show');
        })
    }
    var onSuccess = function (data) {
        $('#saveModal').modal('hide');
        if (data == ""200"") {
            Swal.fire({
                icon: 'success',
                title: 'Kayıt İşlemi Başarılı',
                showConfirmButton: false,
                timer: 2000
            });
        }
        else {
            Swal.fire({
                icon: 'error',
                title: 'Kayıt İşlemi Sırasında hata gerçekleşti',
                showConfirmButton: false,
                timer: 2000
            });
        }
 ");
            WriteLiteral("       LoadEditPage();\r\n    };\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591