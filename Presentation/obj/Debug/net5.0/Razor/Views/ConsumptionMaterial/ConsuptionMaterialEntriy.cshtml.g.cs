#pragma checksum "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\ConsumptionMaterial\ConsuptionMaterialEntriy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d627f60da56295bf3d4cdc78df4175bc5761b0b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ConsumptionMaterial_ConsuptionMaterialEntriy), @"mvc.1.0.view", @"/Views/ConsumptionMaterial/ConsuptionMaterialEntriy.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d627f60da56295bf3d4cdc78df4175bc5761b0b9", @"/Views/ConsumptionMaterial/ConsuptionMaterialEntriy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5190a7fa70597cf0160e9fb4f31b4a4a8d5480ac", @"/Views/_ViewImports.cshtml")]
    public class Views_ConsumptionMaterial_ConsuptionMaterialEntriy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConsuptionMaterialResponseModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ConsumptionMaterial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConsuptionMaterialEntriy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddMaterialStock", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-success", new global::Microsoft.AspNetCore.Html.HtmlString("onSuccess"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-begin", new global::Microsoft.AspNetCore.Html.HtmlString("OnBegin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("POST"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\ConsumptionMaterial\ConsuptionMaterialEntriy.cshtml"
  
    ViewData["Title"] = "ConsuptionMaterialEntriy";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""wrapper wrapper-content animated fadeInRight mt60"">

    <div class=""row"">
        <div class=""col-lg-12"">
            <fieldset class=""fieldset"">
                <legend class=""fieldsetb"">Filtreleme Alanı</legend>

                <!--SEARCH AREA-->
                <div class=""row"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d627f60da56295bf3d4cdc78df4175bc5761b0b97510", async() => {
                WriteLiteral(@"
                        <div class=""col-lg-11 col-md-11 col-sm-10 col-xs-10"">
                            <div class=""row"">
                                <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                                    <input type=""text"" name=""filtre""
                                           class=""inpt-charter"" placeholder=""Giriniz..."">
                                </div>
                                <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                                    <button style="" float: right;margin-top:10px""
                                            type=""submit"" class=""btn-charter-p m-b"">
                                        FİLTRELE
                                    </button>
                                </div>
                            </div>

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
                    <div class=""col-lg-1 col-md-1 col-sm-2 col-xs-2"">
                        <i data-toggle=""modal"" data-target=""#savePopUp"" class=""fa fa-plus-square"" style=""font-size:35px; cursor: pointer; float:right""></i>
                    </div>
                </div>

            </fieldset>
        </div>
    </div>


    <!--LİSTE ALANI-->
    <div class=""row"">
        <div class=""col-lg-12"">
            <fieldset class=""fieldset"">
                <legend class=""fieldsetb"">Sarf Malzeme Girişleri Listesi</legend>
                <div class=""row"">
                    <div class=""col-xs-12"">
                        <div class=""table-responsive mb10"">
                            <table class=""table table-striped table-bordered table-hover dataTables dataTable "">
                                <thead>
                                    <tr>
                                        <th>Tedarik Edilen Firma</th>
                                        <th>Depoya Giriş Tarihi</th>
");
            WriteLiteral(@"                                        <th>Toplam Adet/Miktar</th>
                                        <th>Maliyet(birim maliyeti)</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 60 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\ConsumptionMaterial\ConsuptionMaterialEntriy.cshtml"
                                     foreach (var item in Model.consumptionMaterialStocks.Where(x=>x.ExitDate==null).OrderByDescending(x=>x.Id))
                                    {
                                        var price = Convert.ToDouble(item.ConsumptionMaterials.CostPrice);
                                        var quamtity = item.Quantity;
                                        var totalPrice = price * quamtity;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 66 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\ConsumptionMaterial\ConsuptionMaterialEntriy.cshtml"
                                           Write(item.Companies.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 67 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\ConsumptionMaterial\ConsuptionMaterialEntriy.cshtml"
                                           Write(item.EntryDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 68 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\ConsumptionMaterial\ConsuptionMaterialEntriy.cshtml"
                                           Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" adet</td>\r\n                                            <td>");
#nullable restore
#line 69 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\ConsumptionMaterial\ConsuptionMaterialEntriy.cshtml"
                                           Write(totalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 69 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\ConsumptionMaterial\ConsuptionMaterialEntriy.cshtml"
                                                       Write(item.ConsumptionMaterials.Currencies.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 71 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\ConsumptionMaterial\ConsuptionMaterialEntriy.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </fieldset>
        </div>
    </div>

    <div class=""modal fade"" id=""savePopUp"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"" style=""width:100%"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d627f60da56295bf3d4cdc78df4175bc5761b0b914984", async() => {
                WriteLiteral(@"
                    <div class=""modal-header"">
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                        <h4 class=""modal-title"" id=""myModalLabel"">Sarf Malzeme Depoya Giriş</h4>
                    </div>

                    <div class=""modal-body"">

                        <div class=""row"">
                            <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-4"">
                                <label class=""control-label"">Depo :</label>
                            </div>
                            <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-8"">

                                <select data-placeholder=""Seçiniz"" name=""StoreId"" class=""chosen-select"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d627f60da56295bf3d4cdc78df4175bc5761b0b916106", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 103 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\ConsumptionMaterial\ConsuptionMaterialEntriy.cshtml"
                                     foreach (var item in Model.store)
                                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d627f60da56295bf3d4cdc78df4175bc5761b0b917676", async() => {
#nullable restore
#line 106 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\ConsumptionMaterial\ConsuptionMaterialEntriy.cshtml"
                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 106 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\ConsumptionMaterial\ConsuptionMaterialEntriy.cshtml"
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
#line 107 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\ConsumptionMaterial\ConsuptionMaterialEntriy.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </select>
                            </div>
                        </div>

                        <div class=""row"" style=""margin-top: 3%;"">
                            <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-4"">
                                <label class=""control-label"">Sarf Malzeme :</label>
                            </div>

                            <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-8"">

                                <select data-placeholder=""Seçiniz"" name=""ConsumptionMaterialId"" class=""chosen-select"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d627f60da56295bf3d4cdc78df4175bc5761b0b920569", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 121 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\ConsumptionMaterial\ConsuptionMaterialEntriy.cshtml"
                                     foreach (var item in Model.consumptionMaterialDTOs)
                                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d627f60da56295bf3d4cdc78df4175bc5761b0b922157", async() => {
#nullable restore
#line 124 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\ConsumptionMaterial\ConsuptionMaterialEntriy.cshtml"
                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 124 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\ConsumptionMaterial\ConsuptionMaterialEntriy.cshtml"
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
#line 125 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\ConsumptionMaterial\ConsuptionMaterialEntriy.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </select>
                            </div>
                        </div>
                        <div class=""row"" style=""margin-top: 3%;"">
                            <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-4"">
                                <label class=""control-label"">Tedarikçi Firma :</label>
                            </div>
                            <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-8"">
                                <select data-placeholder=""Seçiniz"" name=""CompanyId"" class=""chosen-select"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d627f60da56295bf3d4cdc78df4175bc5761b0b925035", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 136 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\ConsumptionMaterial\ConsuptionMaterialEntriy.cshtml"
                                     foreach (var item in Model.companies)
                                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d627f60da56295bf3d4cdc78df4175bc5761b0b926609", async() => {
#nullable restore
#line 139 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\ConsumptionMaterial\ConsuptionMaterialEntriy.cshtml"
                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 139 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\ConsumptionMaterial\ConsuptionMaterialEntriy.cshtml"
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
#line 140 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\ConsumptionMaterial\ConsuptionMaterialEntriy.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </select>
                            </div>
                        </div>
                        <div class=""row"" style=""margin-top: 3%;"">
                            <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-4"">
                                <label class=""control-label"">Adet / Toplam Miktar :</label>
                            </div>
                            <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-8"">
                                <input type=""text"" name=""Quantity""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 7785, "\"", 7799, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""inpt-charter"">
                            </div>
                        </div>

                        <div class=""row"" style=""margin-top: 3%;"">
                            <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-4"">
                                <label class=""control-label"">Sarf Malzemenin Adresi :</label>
                            </div>

                            <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-8"">
                                <textarea name=""ConsumptionMaterialAddress"" rows=""8"" cols=""40"" class=""inpt-charter""></textarea>
                            </div>
                        </div>

                    </div>
                    <div class=""modal-footer"" style=""margin-top: 3%"">
                        <button type=""submit"" style=""margin-right:15px"" class=""btn btn-info btnClick"">KAYDET</button>
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
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
    function LoadEditPage() {
        setTimeout(function () { window.location.reload() }, 2000);
    }
    var onSuccess = function () {
        $('#savePopUp').modal('hide');
        Swal.fire({
            icon: 'success',
            title: 'Kayıt İşlemi Başarılı',
            showConfirmButton: false,
            timer: 2000
        });
        LoadEditPage();
    };
    function OnBegin() {
        $('#savePopUp').modal('hide');
        $('.btnClick').prop(""disabled"", true);
        let timerInterval
        Swal.fire({
            title: 'İçerik Güncelleniyor',
            timer: 1000,
            timerProgressBar: true,
            didOpen: () => {
                Swal.showLoading()
            },
            willClose: () => {
                clearInterval(timerInterval)
            }
        }).then((result) => {
            if (result.dismiss === Swal.DismissReason.timer) {
                console.log('");
            WriteLiteral("I was closed by the timer\')\r\n            }\r\n        })\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConsuptionMaterialResponseModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
