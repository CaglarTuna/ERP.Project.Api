#pragma checksum "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\GetSpecialProductDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0b9c4c5bd38d2eac8c50b7cef7eab8b8b7e5317"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_GetSpecialProductDetail), @"mvc.1.0.view", @"/Views/Product/GetSpecialProductDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0b9c4c5bd38d2eac8c50b7cef7eab8b8b7e5317", @"/Views/Product/GetSpecialProductDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5190a7fa70597cf0160e9fb4f31b4a4a8d5480ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_GetSpecialProductDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\GetSpecialProductDetail.cshtml"
  
    ViewData["Title"] = "GetSpecialProductDetail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""wrapper wrapper-content animated fadeInRight mt60"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""tabs-container"">
                <div class=""tab-content"">
                    <div id=""tab-1"" class=""tab-pane active"">
                        <div class=""panel-body"">
                            <fieldset class=""fieldset"">
                                <legend class=""fieldsetb"">Benzersiz Ürün Detayı</legend>
                                <div class=""row"">
                                    <div class=""col-xs-12"">
                                        <div class=""form-group cf"">
                                            <label class=""col-xs-3 control-label"" style=""color:black"">Ürün Kategorisi</label>
                                            <div class=""col-xs-9"">
                                                ");
#nullable restore
#line 20 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\GetSpecialProductDetail.cshtml"
                                           Write(Model.Categories.CategoryLanguageDTOs.FirstOrDefault().Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>

                                        <div class=""form-group cf"">
                                            <label class=""col-xs-3 control-label"" style=""color:black"">Ürün Adı</label>
                                            <div class=""col-xs-9"">
                                                ");
#nullable restore
#line 27 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\GetSpecialProductDetail.cshtml"
                                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>

                                        <div class=""form-group cf"">
                                            <label class=""col-xs-3 control-label"" style=""color:black"">Üretim Tarihi</label>
                                            <div class=""col-xs-9"">
                                                ");
#nullable restore
#line 34 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\GetSpecialProductDetail.cshtml"
                                           Write(Model.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>

                                        <div class=""col-md-12 col-sm-12 "" style=""margin-top: 3%"">
                                            <div class=""table table-bordered"" style=""overflow:scroll"">
                                                <table class=""table"">
                                                    <tr>
                                                        <th>Kulanılan Malzeme Adı</th>
                                                        <th>Tedarik Edildiği Firma</th>
                                                        <th>Tedarik Edildiği Tarih</th>
                                                        <th>Adet/Miktar</th>
                                                    </tr>
");
#nullable restore
#line 47 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\GetSpecialProductDetail.cshtml"
                                                     foreach (var item in Model.productMaterialDTOs)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <tr>\r\n                                                            <td>");
#nullable restore
#line 50 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\GetSpecialProductDetail.cshtml"
                                                           Write(item.Materials.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 52 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\GetSpecialProductDetail.cshtml"
                                                           Write(item.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 53 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\GetSpecialProductDetail.cshtml"
                                                           Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        </tr>\r\n");
#nullable restore
#line 55 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\GetSpecialProductDetail.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                </table>
                                            </div>
                                        </div>


                                        <div class=""col-md-12 col-sm-12 "" style=""margin-top: 3%"">
                                            <div class=""table table-bordered"" style=""overflow:scroll"">
                                                <table class=""table"">
                                                    <tr>
                                                        <th>Yapılan İşlem</th>
                                                        <th>İşlemi Yapan Usta</th>
                                                        <th>İşlemin Yapılma Tarihi</th>
                                                        <th>İşlemin Yapılma Süresi</th>
                                                    </tr>
");
#nullable restore
#line 70 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\GetSpecialProductDetail.cshtml"
                                                     foreach (var item in Model.productProcessDTOs)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <tr>\r\n                                                            <td>");
#nullable restore
#line 73 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\GetSpecialProductDetail.cshtml"
                                                           Write(item.Process.ProcessLanguage.FirstOrDefault().Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 75 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\GetSpecialProductDetail.cshtml"
                                                           Write(item.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 76 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\GetSpecialProductDetail.cshtml"
                                                           Write(item.ProcessDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        </tr>\r\n");
#nullable restore
#line 78 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\GetSpecialProductDetail.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </table>\r\n                                            </div>\r\n                                        </div>\r\n");
#nullable restore
#line 82 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\GetSpecialProductDetail.cshtml"
                                         if (Model.productDocumentDTOs.Count > 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <div class=""form-group cf"">
                                                <label class=""col-xs-3 control-label"" style=""color:black"">Teknik Resim</label>
                                                <div class=""col-xs-9"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f0b9c4c5bd38d2eac8c50b7cef7eab8b8b7e531713195", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5782, "~/Images/", 5782, 9, true);
#nullable restore
#line 87 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\GetSpecialProductDetail.cshtml"
AddHtmlAttributeValue("", 5791, Model.productDocumentDTOs.FirstOrDefault(x=>x.Document.Type==".jpg"||x.Document.Type==".png").Document.Name, 5791, 108, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                </div>\r\n                                            </div>\r\n");
#nullable restore
#line 90 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\GetSpecialProductDetail.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\GetSpecialProductDetail.cshtml"
                                         if (Model.productDocumentDTOs.Count > 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <div class=""form-group cf"">
                                                <label class=""col-xs-3 control-label"" style=""color:black"">Teknik Pdf</label>
                                                <div class=""col-xs-9"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0b9c4c5bd38d2eac8c50b7cef7eab8b8b7e531715823", async() => {
                WriteLiteral("Teknik Pdf için Tıklayınız...");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6514, "~/Documents/", 6514, 12, true);
#nullable restore
#line 96 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\GetSpecialProductDetail.cshtml"
AddHtmlAttributeValue("", 6526, Model.productDocumentDTOs.FirstOrDefault(x=>x.Document.Type==".pdf").Document.Name, 6526, 83, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                </div>\r\n                                            </div>\r\n");
#nullable restore
#line 99 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\GetSpecialProductDetail.cshtml"
                                        }
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </div>
                                </div>
                            </fieldset>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
