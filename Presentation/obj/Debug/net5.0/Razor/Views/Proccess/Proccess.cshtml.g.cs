#pragma checksum "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Proccess\Proccess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a5dfbb7eed778bfa04262a497ff32d0031044dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Proccess_Proccess), @"mvc.1.0.view", @"/Views/Proccess/Proccess.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a5dfbb7eed778bfa04262a497ff32d0031044dc", @"/Views/Proccess/Proccess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5190a7fa70597cf0160e9fb4f31b4a4a8d5480ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Proccess_Proccess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<(List<ProcessDTO> proccess, List<CommonDTO> common)>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Proccess", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Proccess", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProccess", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-success", new global::Microsoft.AspNetCore.Html.HtmlString("onSuccess"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("POST"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditProccess", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-success", new global::Microsoft.AspNetCore.Html.HtmlString("onEditSuccess"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Proccess\Proccess.cshtml"
  
    ViewData["Title"] = "İşlem Yönetimi";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""wrapper wrapper-content animated fadeInRight mt60"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <fieldset class=""fieldset"">
                        <legend class=""fieldsetb"">Filtreleme Alanı</legend>

                        <div class=""row"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a5dfbb7eed778bfa04262a497ff32d0031044dc7714", async() => {
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <div class=""col-lg-1 col-md-1 col-sm-2 col-xs-2"">
                                <i data-toggle=""modal"" data-target=""#MdlAddProcess""
                                   class=""fa fa-plus-square"" style=""font-size:35px; cursor: pointer; float:right""></i>
                            </div>
                        </div>
                    </fieldset>
                </div>
            </div>
            <!--LİSTE ALANI-->
            <div class=""row"">
                <div class=""col-lg-12"">
                    <fieldset class=""fieldset"">
                        <legend class=""fieldsetb"">İşlem Listesi</legend>
                        <div class=""row"">
                            <div class=""col-xs-12"">
                                <div class=""table-responsive mb10"">
                                    <table class=""table table-striped table-bordered table-hover dataTables dataTable "">
                                        <thead>
                              ");
            WriteLiteral(@"              <tr>
                                                <th>Düzenle</th>
                                                <th>İşlem No</th>
                                                <th>İşlem Adı</th>
                                                <th>Tahmini Maliyeti (/dk)</th>
                                            </tr>
                                        </thead>
                                        <tbody>

");
#nullable restore
#line 60 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Proccess\Proccess.cshtml"
                                             if (Model.proccess != null)
                                            {
                                                foreach (var item in Model.proccess.OrderByDescending(x => x.Id))
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td>\r\n                                                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3592, "\"", 3622, 3);
            WriteAttributeValue("", 3602, "getProcces(", 3602, 11, true);
#nullable restore
#line 66 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Proccess\Proccess.cshtml"
WriteAttributeValue("", 3613, item.Id, 3613, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3621, ")", 3621, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Düzenle</a>\r\n                                                        </td>\r\n                                                        <td>");
#nullable restore
#line 68 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Proccess\Proccess.cshtml"
                                                       Write(item.ProcessNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 69 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Proccess\Proccess.cshtml"
                                                       Write(item.ProcessLanguage.Where(x => x.ProcessId == item.Id).Select(x => x.Name).FirstOrDefault());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 70 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Proccess\Proccess.cshtml"
                                                       Write(item.Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 70 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Proccess\Proccess.cshtml"
                                                                  Write(item.Currencies.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                                    </tr>\r\n");
#nullable restore
#line 73 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Proccess\Proccess.cshtml"
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

    <div class=""modal fade"" id=""MdlAddProcess"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a5dfbb7eed778bfa04262a497ff32d0031044dc15775", async() => {
                WriteLiteral(@"
                    <div class=""modal-header"">
                        <button type=""button"" class=""close"" data-dismiss=""modal""
                                aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                        <h4 class=""modal-title"" id=""myModalLabel"">İşlem Ekle</h4>
                    </div>
                    <div class=""modal-body"" style=""margin-bottom:3%;"">

                        <div class=""row"">
                            <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-4"">
                                <label class=""control-label"">İşlem Adı :</label>
                            </div>

                            <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-8"">
                                <input type=""text"" required=""required"" name=""Name""
                                       class=""inpt-charter"" id=""NameValue""");
                BeginWriteAttribute("value", " value=\"", 5898, "\"", 5906, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            </div>
                        </div>

                        <div class=""row"" style=""margin-top: 3%;"">
                            <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-4"">
                                <label class=""control-label"">Tahmini Maliyet (/dk) :</label>
                            </div>

                            <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-8"">
                                <input type=""text"" required=""required"" name=""Cost""
                                       class=""inpt-charter"" id=""CostValue""");
                BeginWriteAttribute("value", " value=\"", 6495, "\"", 6503, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            </div>
                        </div>

                        <div class=""row"" style=""margin-top: 3%;"">
                            <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-4"">
                                <label class=""control-label"">Para Birimi :</label>
                            </div>

                            <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-8"">
                                <select data-placeholder=""Seçiniz ..."" required=""required"" name=""CurrencyId"" id=""CurrencySelect"" class=""chosen-select"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a5dfbb7eed778bfa04262a497ff32d0031044dc18569", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 131 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Proccess\Proccess.cshtml"
                                     foreach (var item in Model.common.Take(1))
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 133 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Proccess\Proccess.cshtml"
                                         foreach (var currency in item.currenciesDTOs)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a5dfbb7eed778bfa04262a497ff32d0031044dc20472", async() => {
#nullable restore
#line 135 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Proccess\Proccess.cshtml"
                                                                    Write(currency.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 135 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Proccess\Proccess.cshtml"
                                               WriteLiteral(currency.Id);

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
#line 136 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Proccess\Proccess.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 136 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Proccess\Proccess.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </select>
                            </div>
                        </div>

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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
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
<div class=""modal fade"" id=""MdlEditProcess"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a5dfbb7eed778bfa04262a497ff32d0031044dc25274", async() => {
                WriteLiteral(@"
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal""
                            aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                    <h4 class=""modal-title"" id=""myModalLabel"">İşlem Bilgileri Güncelle</h4>
                </div>
                <div class=""modal-body editModalBody"" style=""margin-bottom:3%;"">

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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
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
<script>
    function LoadEditPage() {
        setTimeout(function () { window.location.reload() }, 2000);
    }
    var onSuccess = function (data) {
        $('#MdlAddProcess').modal('hide');
        if (data == ""2"") {
            Swal.fire({

                icon: 'error',
                title: 'Kayıt İşlemi Başarılı',
                showConfirmButton: false,
                timer: 2000
            })
        }
        else {
            Swal.fire({

                icon: 'success',
                title: 'Kayıt İşlemi Başarılı',
                showConfirmButton: false,
                timer: 2000
            })
        }
        $('#NameValue').val("""");
        $('#CostValue').val("""");
        $(""#CurrencySelect option:selected"").prop(""selected"", false);
        LoadEditPage();
    };
</script>
<script>
    var pop = $('.editModalBody');
    function getProcces(id) {
        $.get('/Proccess/getProccess', { id: id }).done(function (");
            WriteLiteral("data) {\r\n            pop.empty();\r\n            pop.html(data);\r\n            $(\'#MdlEditProcess\').modal(\'show\');\r\n        })\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<(List<ProcessDTO> proccess, List<CommonDTO> common)> Html { get; private set; }
    }
}
#pragma warning restore 1591
