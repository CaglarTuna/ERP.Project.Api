#pragma checksum "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\ProductManagement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f99fe143ee76ba1ab2ec61c84680fd190cd22e04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductManagement), @"mvc.1.0.view", @"/Views/Product/ProductManagement.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f99fe143ee76ba1ab2ec61c84680fd190cd22e04", @"/Views/Product/ProductManagement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5190a7fa70597cf0160e9fb4f31b4a4a8d5480ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductManagement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CategoryDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductManagement", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SpecialProductPrescriptionsList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProductRecipe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\ProductManagement.cshtml"
  
    ViewData["Title"] = "ProductManagement";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"wrapper wrapper-content animated fadeInRight mt60\">\r\n    <div class=\"tabs-container\">\r\n        <ul class=\"nav nav-tabs tab-border-top-danger\">\r\n            <li class=\"active\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f99fe143ee76ba1ab2ec61c84680fd190cd22e045038", async() => {
                WriteLiteral(" Ürün Reçeteleri&amp;Ürün Reçetesi Oluşturma");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n            <li");
            BeginWriteAttribute("class", " class=\"", 442, "\"", 450, 0);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f99fe143ee76ba1ab2ec61c84680fd190cd22e046598", async() => {
                WriteLiteral("Ürün Reçetesi Oluşturulacaklar Listesi");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
        </ul>
        <div class=""tab-content"" style=""margin-top:20px"">

            <div id=""tab-1"" class=""tab-pane active"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <fieldset class=""fieldset"">
                            <legend class=""fieldsetb"">Filtreleme Alanı</legend>
                            <div class=""row"">
                                <div class=""col-lg-3 col-md-3 col-sm-3 col-xs-3"">
                                    <select data-placeholder=""Ürün Kategorisini Seçiniz...""");
            BeginWriteAttribute("name", " name=\"", 1139, "\"", 1146, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"FilterCategory\" class=\"chosen-select\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f99fe143ee76ba1ab2ec61c84680fd190cd22e048813", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\ProductManagement.cshtml"
                                         foreach (var item in Model)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f99fe143ee76ba1ab2ec61c84680fd190cd22e0410101", async() => {
#nullable restore
#line 25 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\ProductManagement.cshtml"
                                                                Write(item.CategoryLanguageDTOs.FirstOrDefault().Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\ProductManagement.cshtml"
                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\ProductManagement.cshtml"
                                            foreach (var Sub in item.SubCategoryDto)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f99fe143ee76ba1ab2ec61c84680fd190cd22e0412414", async() => {
                WriteLiteral("=> ");
#nullable restore
#line 28 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\ProductManagement.cshtml"
                                                                      Write(Sub.CategoryLanguageDTOs.FirstOrDefault().Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\ProductManagement.cshtml"
                                                   WriteLiteral(Sub.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\ProductManagement.cshtml"
                                            }
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </select>
                                </div>
                                <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-8"">
                                    <input type=""text"" name=""filtre"" class=""inpt-charter"" id=""FilterText"" placeholder=""Giriniz..."">
                                </div>
                                <div class=""col-lg-1 col-md-1 col-sm-2 col-xs-2"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f99fe143ee76ba1ab2ec61c84680fd190cd22e0415159", async() => {
                WriteLiteral("\r\n                                        <i class=\"fa fa-plus-square\" style=\"font-size:35px; float:right\"></i>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
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
                            <div class=""row"" style=""margin-top:20px"">
                                <div class=""col-lg-3 col-md-3 col-sm-6 col-xs-6"">
                                    <label>Özel Ürün Tüm Ürünler Arasında Gösterilsin mi?</label>
                                </div>
                                <div class=""col-lg-1 col-md-1 col-sm-6 col-xs-6"">
                                    <input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 3033, "\"", 3041, 0);
            EndWriteAttribute();
            WriteLiteral(@"  name=""special"" id=""SpecialFilter"">
                                </div>
                                <div class=""col-lg-8 col-md-8 col-sm-0 col-xs-0"">
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-lg-11 col-md-11 col-sm-11 col-xs-11"">
                                    <button style=""float:right; margin-top:10px"" type=""button"" id=""FilterBtn"" class=""btn-charter-p m-b"">
                                        FİLTRELE
                                    </button>
                                </div>
                                <div class=""col-lg-1 col-md-1 col-sm-1 col-xs-1"">
                                </div>
                            </div>
                        </fieldset>
                    </div>
                </div>


                <!--LİSTE ALANI-->
                <div class=""row"">
                    <div class=""col-lg-12"">
          ");
            WriteLiteral(@"              <fieldset class=""fieldset"">
                            <legend class=""fieldsetb"">Ürün Reçetesi Listesi</legend>
                            <div class=""row"">
                                <div class=""col-xs-12"">
                                    <div class=""table-responsive mb10"">
                                        <table class=""table table-striped table-bordered table-hover dataTables dataTable "">
                                            <thead>
                                                <tr>
                                                    <th>Detay Gör</th>
                                                    <th>Düzenle</th>
                                                    <th>Ürün Tipi</th>
                                                    <th>Üretim Seri No</th>
                                                    <th>Ürün Kategorisi</th>
                                                    <th>Ürün Adı</th>
                                             ");
            WriteLiteral(@"       <th>Birim Yaklaşık Maliyeti</th>
                                                </tr>
                                            </thead>
                                            <tbody id=""ProductTable"">
                                               
                                            </tbody>
                                        </table>
                                    </div>

                                </div>
                            </div>
                        </fieldset>
                    </div>
                </div>
            </div>
        </div>
    </div>

</div>
<script>
    $('#FilterBtn').click(function () {
        if ($('#SpecialFilter').is(':checked')) {
            $('#SpecialFilter').attr('value', 'true');
        }
        else {
            $('#SpecialFilter').attr('value', 'false');
        }
        var special = $('#SpecialFilter').val();
        var text = $('#FilterText').val();
        var category = $('#FilterC");
            WriteLiteral(@"ategory').val();
        $.ajax({
            url: '/Product/ProductList',
            data: { special: special, text: text, category: category },
            success: function (data) {
                $('#ProductTable').empty();
                $('#ProductTable').html(data);
            },
            error: function () {
                Swal.fire({
                    icon: 'error',
                    title: 'Aradığınız Ürün Bulunamadı',
                    showConfirmButton: false,
                    timer: 1500
                })
            }
        })
    });
    $('#FilterCategory').change(function () {
        var category = $('#FilterCategory').val();
        if ($('#SpecialFilter').is(':checked')) {
            $('#SpecialFilter').attr('value', 'true');
        }
        else {
            $('#SpecialFilter').attr('value', 'false');
        }
        var special = $('#SpecialFilter').val();
        var text = $('#FilterText').val();
        $.ajax({
            url: '");
            WriteLiteral(@"/Product/ProductList',
            data: { special: special, category: category },
            success: function (data) {
                $('#ProductTable').empty();
                $('#ProductTable').html(data);
            },
            error: function () {
                Swal.fire({
                    icon: 'error',
                    title: 'Aradığınız Ürün Bulunamadı',
                    showConfirmButton: false,
                    timer: 1500
                })
            }
        })
    })
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CategoryDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591