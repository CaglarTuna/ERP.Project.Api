#pragma checksum "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\OrderControlProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2363fbb11d39db981b5726b2bd5d89f05e438b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_OrderControlProduct), @"mvc.1.0.view", @"/Views/Order/OrderControlProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2363fbb11d39db981b5726b2bd5d89f05e438b7", @"/Views/Order/OrderControlProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5190a7fa70597cf0160e9fb4f31b4a4a8d5480ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_OrderControlProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrderControlProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddRealizedProductionCount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-success", new global::Microsoft.AspNetCore.Html.HtmlString("onSuccess"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("POST"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\OrderControlProduct.cshtml"
  
    ViewData["Title"] = "OrderControlProduct";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"wrapper wrapper-content animated fadeInRight mt60\">\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-12\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2363fbb11d39db981b5726b2bd5d89f05e438b76484", async() => {
                WriteLiteral(@"
                        <fieldset class=""fieldset"">
                            <legend class=""fieldsetb"">Filtreleme Alanı</legend>
                            <div class=""row"">
                                <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                                    <div class=""row"">
                                        <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                                            <input type=""text"" name=""filtre""
                                                   class=""inpt-charter"" placeholder=""Giriniz..."">
                                            <input type=""hidden"" name=""id""");
                BeginWriteAttribute("value", " value=\"", 1106, "\"", 1140, 1);
#nullable restore
#line 21 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\OrderControlProduct.cshtml"
WriteAttributeValue("", 1114, Model.FirstOrDefault().Id, 1114, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                        </div>
                                        <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                                            <button style="" float: right;margin-top:10px""
                                                    type=""submit"" class=""btn-charter-p m-b"">
                                                FİLTRELE
                                            </button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </fieldset>
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
            <!--LİSTE ALANI-->
            <div class=""row"">
                <div class=""col-lg-12"">
                    <fieldset class=""fieldset"">
                        <legend class=""fieldsetb"">Siparişteki Ürünler</legend>
                        <div class=""row"">
                            <div class=""col-xs-12"">
                                <div class=""table-responsive mb10"">
                                    <table class=""table table-striped table-bordered table-hover dataTables dataTable "">
                                        <thead>
                                            <tr>
                                                <th>İmza Kontrolü</th>
                                                <th>Gerçekleşen Üretim Sayısı Girişi</th>
                                                <th>Gerkekleşen Üretim Sayısı</th>
                                                <th>Üretim Tarihi</th>
                                        ");
            WriteLiteral("        <th>Ürün Benzersiz No</th>\r\n                                                <th>Ürün Adı</th>\r\n                                            </tr>\r\n                                        </thead>\r\n                                        <tbody>\r\n");
#nullable restore
#line 56 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\OrderControlProduct.cshtml"
                                             foreach (var item in Model)
                                            {
                                                foreach (var op in item.OrderProducts)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td><a");
            BeginWriteAttribute("onclick", " onclick=\"", 3476, "\"", 3512, 5);
            WriteAttributeValue("", 3486, "Veri(", 3486, 5, true);
#nullable restore
#line 61 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\OrderControlProduct.cshtml"
WriteAttributeValue("", 3491, op.ProductId, 3491, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3504, ",", 3504, 1, true);
#nullable restore
#line 61 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\OrderControlProduct.cshtml"
WriteAttributeValue("", 3505, op.Id, 3505, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3511, ")", 3511, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Veri Gir</a> </td>\r\n                                                        <td>\r\n                                                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3679, "\"", 3726, 5);
            WriteAttributeValue("", 3689, "ProductionModal(", 3689, 16, true);
#nullable restore
#line 63 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\OrderControlProduct.cshtml"
WriteAttributeValue("", 3705, op.Quantitiy, 3705, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3718, ",", 3718, 1, true);
#nullable restore
#line 63 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\OrderControlProduct.cshtml"
WriteAttributeValue("", 3719, op.Id, 3719, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3725, ")", 3725, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Gerçekleşen Üretim Sayısı Gir</a>\r\n                                                        </td>\r\n                                                        <td>\r\n");
#nullable restore
#line 66 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\OrderControlProduct.cshtml"
                                                             if (op.RealizedProduction != null)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <span>");
#nullable restore
#line 68 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\OrderControlProduct.cshtml"
                                                                 Write(op.RealizedProduction);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 69 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\OrderControlProduct.cshtml"
                                                            }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <span>-</span>\r\n");
#nullable restore
#line 73 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\OrderControlProduct.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        </td>\r\n                                                        <td>");
#nullable restore
#line 75 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\OrderControlProduct.cshtml"
                                                       Write(item.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 76 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\OrderControlProduct.cshtml"
                                                       Write(item.OrderNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 77 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\OrderControlProduct.cshtml"
                                                       Write(op.Products.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 79 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\OrderControlProduct.cshtml"
                                                }
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </fieldset>
                </div>
            </div>
        </div>
    </div>

    <div class=""modal fade"" id=""Modal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">

    </div>
    <div class=""modal fade"" id=""ProductionModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog "">
            <div class=""modal-content"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2363fbb11d39db981b5726b2bd5d89f05e438b717890", async() => {
                WriteLiteral(@"
                    <div class=""modal-header"">
                        <button type=""button"" class=""close"" data-dismiss=""modal""
                                aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                        <h4 class=""modal-title"" id=""myModalLabel"">Üretim Sayısı</h4>
                    </div>
                    <div class=""modal-body"">

                        <div class=""row"">
                            <div class=""col-md-6 col-sm-6 "">

                                <label>
                                    Planlanan Üretim Sayısı
                                </label>
                            </div>
                            <div class=""col-md-6 col-sm-6 "">
                                <label id=""ProductionCount""> </label>
                                <input type=""hidden"" name=""Id"" id=""PcId""");
                BeginWriteAttribute("value", " value=\"", 6786, "\"", 6794, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                            </div>
                        </div>
                        <div class=""row"" style=""margin-top:3%"">
                            <div class=""col-md-6 col-sm-6 "">

                                <label>Gerçekleşen Üretim Sayısı</label>

                            </div>
                            <div class=""col-md-6 col-sm-6 "">
                                <input type=""text"" name=""RealizedProduction"" class=""inpt-charter"">

                            </div>
                        </div>
                    </div>
                    <div class=""modal-footer"" style=""margin-top:3%"">
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
    var mdl = $('#Modal');
    function Veri(productId, OrderProductId) {
        $.get('/Order/GetStaffProcces', { productId: productId, OrderProductId: OrderProductId }).done(function (data) {
            mdl.empty();
            mdl.append(data);
            $('#Modal').modal('show');
        })
    }
    function ProductionModal(count, ıd) {
        $('#ProductionCount').text(count);
        $('#PcId').val(ıd);
        $('#ProductionModal').modal('show');
    }
    function LoadEditPage() {
        setTimeout(function () { window.location.reload() }, 2000);
    }
    var onSuccess = function () {
        $('#ProductionModal').modal('hide');
        Swal.fire({
            icon: 'success',
            title: 'Kayıt İşlemi Başarılı',
            showConfirmButton: false,
            timer: 2000
        });
        LoadEditPage();
    };
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591