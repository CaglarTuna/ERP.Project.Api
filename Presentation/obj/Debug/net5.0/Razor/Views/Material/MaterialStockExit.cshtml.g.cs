#pragma checksum "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Material\MaterialStockExit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b7e982714ad364c061bb78ef35b5396203a7593"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Material_MaterialStockExit), @"mvc.1.0.view", @"/Views/Material/MaterialStockExit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b7e982714ad364c061bb78ef35b5396203a7593", @"/Views/Material/MaterialStockExit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5190a7fa70597cf0160e9fb4f31b4a4a8d5480ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Material_MaterialStockExit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MaterialExpertDeliverysDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Material", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MaterialStockExit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Material\MaterialStockExit.cshtml"
  
    ViewData["Title"] = "MaterialStockExit";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"wrapper wrapper-content animated fadeInRight mt60\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b7e982714ad364c061bb78ef35b5396203a75935030", async() => {
                WriteLiteral(@"
                <fieldset class=""fieldset"">
                    <legend class=""fieldsetb"">Filtreleme Alanı</legend>
                    <div class=""row"">
                        <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                            <input type=""text"" name=""filtre"" class=""inpt-charter"" placeholder=""Giriniz..."">
                        </div>
                    </div>
                    <div class=""row"" style=""margin-top:20px"">
                        <div class=""col-lg-12 col-md-12 col-md-12 col-xs-12"">
                            <button style="" float: right"" type=""submit"" class=""btn-charter-p m-b"">FİLTRELE</button>
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
    <div class=""row"">
        <div class=""col-lg-12"">
            <fieldset class=""fieldset"">
                <legend class=""fieldsetb"">Depodan Malzeme Çıkışları Listesi</legend>
                <div class=""row"">
                    <div class=""col-xs-12"">
                        <div class=""table-responsive mb10"">
                            <table class=""table table-striped table-bordered table-hover dataTables dataTable "">
                                <thead>
                                    <tr>
                                        <th>Teslim Edilen Usta</th>
                                        <th>Malzeme Adı</th>
                                        <th>Birim Ölçüsü</th>
                                        <th>Teslim Edilen Adet</th>
                                        <th>Teslim Tarihi</th>
                                        <th>Teslimat Notu</th>
                                    </tr>
                                </thead");
            WriteLiteral(">\r\n                                <tbody>\r\n");
#nullable restore
#line 45 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Material\MaterialStockExit.cshtml"
                                     foreach (var item in Model.OrderByDescending(x=>x.Id))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 48 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Material\MaterialStockExit.cshtml"
                                           Write(item.Staffs.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 49 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Material\MaterialStockExit.cshtml"
                                           Write(item.Materials.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 50 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Material\MaterialStockExit.cshtml"
                                             if (item.Materials.MaterialHeightMeasureDTOs.Count > 0)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td>");
#nullable restore
#line 52 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Material\MaterialStockExit.cshtml"
                                               Write(item.Materials.MaterialHeightMeasureDTOs.FirstOrDefault().HeightMeasures.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 53 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Material\MaterialStockExit.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td></td>\r\n");
#nullable restore
#line 57 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Material\MaterialStockExit.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td>");
#nullable restore
#line 59 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Material\MaterialStockExit.cshtml"
                                           Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" adet</td>\r\n                                            <td>");
#nullable restore
#line 60 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Material\MaterialStockExit.cshtml"
                                           Write(item.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 61 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Material\MaterialStockExit.cshtml"
                                           Write(item.DeliveryNote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 63 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Material\MaterialStockExit.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </fieldset>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MaterialExpertDeliverysDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
