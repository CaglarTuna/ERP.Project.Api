#pragma checksum "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a99416ac17216a4429c1076d380bd38ea68c0307"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Product), @"mvc.1.0.view", @"/Views/Product/Product.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a99416ac17216a4429c1076d380bd38ea68c0307", @"/Views/Product/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5190a7fa70597cf0160e9fb4f31b4a4a8d5480ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CategoryDTO>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\Product.cshtml"
  
    ViewData["Title"] = "Product";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""wrapper wrapper-content animated fadeInRight mt60"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <fieldset class=""fieldset"">
                <legend class=""fieldsetb"">Filtreleme Alanı</legend>
                <div class=""row"">
                    <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-4"">
                        <select data-placeholder=""Ürün Kategorisini Seçiniz...""");
            BeginWriteAttribute("name", " name=\"", 532, "\"", 539, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"FilterCategory\" class=\"chosen-select\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a99416ac17216a4429c1076d380bd38ea68c03074030", async() => {
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
#line 15 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\Product.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a99416ac17216a4429c1076d380bd38ea68c03075272", async() => {
#nullable restore
#line 17 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\Product.cshtml"
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
#line 17 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\Product.cshtml"
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
#line 18 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\Product.cshtml"
                                foreach (var Sub in item.SubCategoryDto)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a99416ac17216a4429c1076d380bd38ea68c03077494", async() => {
                WriteLiteral("=> ");
#nullable restore
#line 20 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\Product.cshtml"
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
#line 20 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\Product.cshtml"
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
#line 21 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\Product.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                    </div>
                    <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-8"">
                        <input type=""text"" name=""filtre"" class=""inpt-charter"" id=""text"" placeholder=""Giriniz..."">
                    </div>
                </div>
                <div class=""row"" style=""margin-top:20px"">
                    <div class=""col-lg-12 col-md-12 col-md-12 col-xs-12"">
                        <button style="" float: right"" type=""button"" id=""filterButton"" class=""btn-charter-p m-b"">FİLTRELE</button>
                    </div>
                </div>
            </fieldset>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-lg-12"">
            <fieldset class=""fieldset"">
                <legend class=""fieldsetb"">Ürünler Listesi</legend>
                <div class=""row"">
                    <div class=""col-xs-12"">
                        <div class=""table-responsive mb10"">
                            <table class=""table");
            WriteLiteral(@" table-striped table-bordered table-hover dataTables dataTable "">
                                <thead>
                                    <tr>
                                        <th>Detay Gör</th>
                                        <th>Ürün Tipi</th>
                                        <th>Üretim Seri No</th>
                                        <th>Barkod</th>
                                        <th>Ürün Kategorisi</th>
                                        <th>Ürün Adı</th>
                                        <th>Ürün Stoğu</th>
                                        <th>Birim Yaklaşık Maliyeti</th>
                                    </tr>
                                </thead>
                                <tbody id=""ProductList"">
                                </tbody>
                            </table>
                        </div>

                    </div>
                </div>
            </fieldset>
        </div>
    </div>
</div>
<s");
            WriteLiteral(@"cript>
    $('#filterButton').click(function () {
        var text = $('#text').val();
        var category = $('#FilterCategory').val();
        $.ajax({
            url: '/Product/ProductMainList',
            data: { text: text, category: category },
            success: function (data) {
                $('#ProductList').empty();
                $('#ProductList').html(data);
            },
            error: function () {
                Swal.fire({
                    icon: 'error',
                    title: 'Aradığınız Ürün Bulunamadı',
                    showConfirmButton: false,
                    timer: 1500
                });
            }
        })
    });
    $('#FilterCategory').change(function () {
        var category = $('#FilterCategory').val();
        var text = $('#text').val();
        $.ajax({
            url: '/Product/ProductMainList',
            data: { text: text, category: category },
            success: function (data) {
                $('#Produc");
            WriteLiteral(@"tList').empty();
                $('#ProductList').html(data);
            },
            error: function () {
                Swal.fire({
                    icon: 'error',
                    title: 'Aradığınız Ürün Bulunamadı',
                    showConfirmButton: false,
                    timer: 1500
                });
            }
        })
    });
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