#pragma checksum "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Company\_editComponyAdress.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a12f63b8965d263cfa1fac8e56e4413e28d65546"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company__editComponyAdress), @"mvc.1.0.view", @"/Views/Company/_editComponyAdress.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a12f63b8965d263cfa1fac8e56e4413e28d65546", @"/Views/Company/_editComponyAdress.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5190a7fa70597cf0160e9fb4f31b4a4a8d5480ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Company__editComponyAdress : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<(CompanyAddressDTO adres, List<CommonDTO> common)>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"row\" style=\"margin-top:10px\">\r\n    <input type=\"hidden\" name=\"CompanyId\"");
            BeginWriteAttribute("value", " value=\"", 142, "\"", 172, 1);
#nullable restore
#line 3 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Company\_editComponyAdress.cshtml"
WriteAttributeValue("", 150, Model.adres.CompanyId, 150, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"Id\"");
            BeginWriteAttribute("value", " value=\"", 212, "\"", 235, 1);
#nullable restore
#line 4 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Company\_editComponyAdress.cshtml"
WriteAttributeValue("", 220, Model.adres.Id, 220, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <div class=\"form-group cf\">\r\n        <label class=\"col-xs-4 control-label\">Adres Başlığı </label>\r\n        <div class=\"col-xs-8\">\r\n            <input type=\"text\" required=\"required\" name=\"AddressTitle\" class=\"inpt-charter\"");
            BeginWriteAttribute("value", " value=\"", 467, "\"", 500, 1);
#nullable restore
#line 8 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Company\_editComponyAdress.cshtml"
WriteAttributeValue("", 475, Model.adres.AddressTitle, 475, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
        </div>
    </div>
    <div class=""form-group cf"">
        <label class=""col-xs-4 control-label"">Ülke</label>
        <div class=""col-xs-8"">
            <select data-placeholder=""Seçiniz"" required=""required"" name=""CountryId"" class=""chosen-select"" tabindex=""2"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a12f63b8965d263cfa1fac8e56e4413e28d655465375", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Company\_editComponyAdress.cshtml"
                 foreach (var item in Model.common.Take(1))
                {
                    foreach (var country in item.countries)
                    {
                        if (Model.adres.CountryId == country.Id)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a12f63b8965d263cfa1fac8e56e4413e28d655466993", async() => {
#nullable restore
#line 22 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Company\_editComponyAdress.cshtml"
                                                            Write(country.CountryLanguage.FirstOrDefault().Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Company\_editComponyAdress.cshtml"
                               WriteLiteral(country.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Company\_editComponyAdress.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a12f63b8965d263cfa1fac8e56e4413e28d655469531", async() => {
#nullable restore
#line 26 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Company\_editComponyAdress.cshtml"
                                                   Write(country.CountryLanguage.FirstOrDefault().Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Company\_editComponyAdress.cshtml"
                               WriteLiteral(country.Id);

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
#line 27 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Company\_editComponyAdress.cshtml"
                        }
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </select>

        </div>
    </div>
    <div class=""form-group cf"">
        <label class=""col-xs-4 control-label"">İl</label>
        <div class=""col-xs-8"">
            <select data-placeholder=""Seçiniz"" required=""required"" name=""CityId"" class=""chosen-select"" tabindex=""2"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a12f63b8965d263cfa1fac8e56e4413e28d6554612033", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 39 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Company\_editComponyAdress.cshtml"
                 foreach (var item in Model.common.Take(1))
                {
                    foreach (var country in item.countries)
                    {
                        foreach (var city in country.Cities)
                        {
                            if (Model.adres.CityId == city.Id)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a12f63b8965d263cfa1fac8e56e4413e28d6554613749", async() => {
#nullable restore
#line 48 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Company\_editComponyAdress.cshtml"
                                                             Write(city.CityLanguage.FirstOrDefault().Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Company\_editComponyAdress.cshtml"
                                   WriteLiteral(city.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 49 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Company\_editComponyAdress.cshtml"
                            }
                            else
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a12f63b8965d263cfa1fac8e56e4413e28d6554616302", async() => {
#nullable restore
#line 53 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Company\_editComponyAdress.cshtml"
                                                    Write(city.CityLanguage.FirstOrDefault().Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Company\_editComponyAdress.cshtml"
                                   WriteLiteral(city.Id);

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
#line 54 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Company\_editComponyAdress.cshtml"
                            }
                        }
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </select>\r\n\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group cf\">\r\n        <label class=\"col-xs-4 control-label\">Posta Kodu</label>\r\n        <div class=\"col-xs-8\">\r\n            <input type=\"text\" required=\"required\" name=\"PostCode\"");
            BeginWriteAttribute("value", " value=\"", 2828, "\"", 2857, 1);
#nullable restore
#line 65 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Company\_editComponyAdress.cshtml"
WriteAttributeValue("", 2836, Model.adres.PostCode, 2836, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""inpt-charter"">
        </div>
    </div>
    <div class=""form-group cf"">
        <label class=""col-xs-4 control-label"">Adres</label>
        <div class=""col-xs-8"">
            <textarea name=""Address"" required=""required"" rows=""8"" cols=""40"" class=""inpt-charter"">");
#nullable restore
#line 71 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Company\_editComponyAdress.cshtml"
                                                                                            Write(Model.adres.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>
        </div>
    </div>
</div>
<script>

    $('.chosen-select').chosen();
    function LoadEditPage() {
        setTimeout(function () { window.location.reload() }, 2000);
    }
    var onEditSuccess = function () {
        $('#edtModal').modal('hide');
        Swal.fire({
            icon: 'success',
            title: 'Güncelleme İşlemi Başarılı',
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<(CompanyAddressDTO adres, List<CommonDTO> common)> Html { get; private set; }
    }
}
#pragma warning restore 1591