#pragma checksum "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\RawMaterial\RawMaterial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3024ee98967704e88500f9bc97eef658d234530"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RawMaterial_RawMaterial), @"mvc.1.0.view", @"/Views/RawMaterial/RawMaterial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3024ee98967704e88500f9bc97eef658d234530", @"/Views/RawMaterial/RawMaterial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5190a7fa70597cf0160e9fb4f31b4a4a8d5480ac", @"/Views/_ViewImports.cshtml")]
    public class Views_RawMaterial_RawMaterial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RawMaterialDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "RawMaterial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RawMaterial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditRawMaterial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-success", new global::Microsoft.AspNetCore.Html.HtmlString("editOnSuccess"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("POST"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddRawMaterial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-success", new global::Microsoft.AspNetCore.Html.HtmlString("onSuccess"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\RawMaterial\RawMaterial.cshtml"
  
    ViewData["Title"] = "Hammadde İşlemleri";
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
                    <div class=""col-lg-11 col-md-11 col-sm-10 col-xs-10"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3024ee98967704e88500f9bc97eef658d2345307283", async() => {
                WriteLiteral(@"
                            <div class=""row"">
                                <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">  <input type=""text"" name=""filtre"" class=""inpt-charter"" placeholder=""Giriniz...""></div>
                                <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">  <button style="" float: right;margin-top:10px"" type=""submit"" class=""btn-charter-p m-b"">FİLTRELE</button></div>
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

                    </div>
                    <div class=""col-lg-1 col-md-1 col-sm-2 col-xs-2"">
                        <i data-toggle=""modal"" data-target=""#AddModal"" class=""fa fa-plus-square"" style=""font-size:35px; float:right""></i>
                    </div>
                </div>
            </fieldset>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-lg-12"">
            <fieldset class=""fieldset"">
                <legend class=""fieldsetb"">Ham Madde Listesi</legend>
                <div class=""row"">
                    <div class=""col-xs-12"">
                        <div class=""table-responsive mb10"">
                            <table class=""table table-striped table-bordered table-hover dataTables dataTable "">
                                <thead>
                                    <tr>
                                        <th>İşlemler</th>
                                        <th>Ham Madde No</th>
                                        <th>Ham ");
            WriteLiteral("Madde Adı</th>\r\n                                        <th>Özkütle</th>\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
#nullable restore
#line 47 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\RawMaterial\RawMaterial.cshtml"
                                     foreach (var item in Model.OrderByDescending(x=>x.Id))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td><a");
            BeginWriteAttribute("onclick", " onclick=\"", 2511, "\"", 2546, 3);
            WriteAttributeValue("", 2521, "editRawMaterial(", 2521, 16, true);
#nullable restore
#line 50 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\RawMaterial\RawMaterial.cshtml"
WriteAttributeValue("", 2537, item.Id, 2537, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2545, ")", 2545, 1, true);
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"modal\" data-target=\"#inputModal\" class=\"btn btn-info\">Düzenle</a></td>\r\n                                            <td>");
#nullable restore
#line 51 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\RawMaterial\RawMaterial.cshtml"
                                           Write(item.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 52 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\RawMaterial\RawMaterial.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 53 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\RawMaterial\RawMaterial.cshtml"
                                           Write(item.Density);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 55 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\RawMaterial\RawMaterial.cshtml"
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

    <div class=""modal fade"" id=""inputModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"" style=""width:100%"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3024ee98967704e88500f9bc97eef658d23453013761", async() => {
                WriteLiteral(@"
                    <div class=""modal-header"">
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                        <h4 class=""modal-title"" id=""myModalLabel"">Ham Madde Güncelle</h4>
                    </div>
                    <div class=""modal-body"">
                        <div class=""row"" style=""margin-top:10px"">
                            <input type=""hidden"" name=""Id"" id=""EditRawId""");
                BeginWriteAttribute("value", " value=\"", 4104, "\"", 4112, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                            <div class=""form-group cf"">
                                <label class=""col-xs-4 control-label"">Ham Madde Adı</label>
                                <div class=""col-xs-8"">
                                    <input type=""text"" required=""required"" name=""Name"" id=""editRawMaterialName""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 4435, "\"", 4449, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""inpt-charter"">
                                </div>
                            </div>

                            <div class=""form-group cf"">
                                <label class=""col-xs-4 control-label"">Ham Madde No</label>
                                <div class=""col-xs-8"">
                                    <input type=""text"" required=""required"" name=""Code""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 4843, "\"", 4857, 0);
                EndWriteAttribute();
                WriteLiteral(@" maxlength=""10"" id=""editRawMaterialCode"" class=""inpt-charter"">
                                </div>
                            </div>
                            <div class=""form-group cf"">
                                <label class=""col-xs-4 control-label"">Özkütle</label>
                                <div class=""col-xs-8"">
                                    <input type=""text"" required=""required"" name=""Density""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 5287, "\"", 5301, 0);
                EndWriteAttribute();
                WriteLiteral(@" maxlength=""50"" id=""editDensity"" class=""inpt-charter"">
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""submit"" style=""margin-right:15px"" class=""btn btn-info"">KAYDET</button>
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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

    <div class=""modal fade"" id=""AddModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"" style=""width:100%"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3024ee98967704e88500f9bc97eef658d23453018814", async() => {
                WriteLiteral(@"
                    <div class=""modal-header"">
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                        <h4 class=""modal-title"" id=""myModalLabel"">Ham Madde Ekle</h4>
                    </div>
                    <div class=""modal-body"">
                        <div class=""row"" style=""margin-top:10px"">
                            <div class=""form-group cf"">

                                <label class=""col-xs-4 control-label"">Ham Madde Adı</label>
                                <div class=""col-xs-8"">
                                    <input type=""text"" required=""required"" id=""RawMaterialName"" name=""Name"" placeholder=""Hammadde Adı"" class=""inpt-charter"">
                                </div>
                            </div>
                            <div class=""form-group cf"">
                                <label class=""col-xs-4 control-label"">Ham Madde No</label>
     ");
                WriteLiteral(@"                           <div class=""col-xs-8"">
                                    <input type=""text"" required=""required"" id=""RawMaterialCode"" name=""Code"" maxlength=""10"" placeholder=""Hammadde Kodu"" class=""inpt-charter"">
                                </div>
                            </div>
                            <div class=""form-group cf"">
                                <label class=""col-xs-4 control-label"">Özkütle</label>
                                <div class=""col-xs-8"">
                                    <input type=""text"" required=""required"" id=""RawMaterialDensity"" name=""Density"" maxlength=""50"" placeholder=""Özkütle"" class=""inpt-charter"">
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""submit"" style=""margin-right:15px"" class=""btn btn-info"">KAYDET</button>
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
</div>
<script>
    function LoadPage() {
        setTimeout(function () { window.location.reload() }, 2000);
    }
    var onSuccess = function () {
        $('#AddModal').modal('hide');
        Swal.fire({
            icon: 'success',
            title: 'Kayıt İşlemi Başarılı',
            showConfirmButton: false,
            timer: 1500
        })
        $('#RawMaterialName').val("""");
        $('#RawMaterialCode').val("""");
        $('#RawMaterialDensity').val("""");
        LoadPage()
    };
    var editOnSuccess = function () {
        $('#inputModal').modal('hide');
        Swal.fire({
            icon: 'success',
            title: 'Güncelleme İşlemi Başarılı',
            showConfirmButton: false,
            timer: 1500
        })
        $('#editRawMaterialName').val("""");
        $('#editRawMaterialCode').val("""");
        $('#editDensity').val("""");
        LoadPage()
    }
</script>
<script>
    function editRawMateria");
            WriteLiteral(@"l(id) {
        $.get(""/RawMaterial/GetRawMaterialDetail"", { id: id }).done(function (data) {
            $('#editRawMaterialName').val(data.name);
            $('#editRawMaterialCode').val(data.code);
            $('#editDensity').val(data.density);
            $('#EditRawId').val(data.id);
        })
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RawMaterialDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
