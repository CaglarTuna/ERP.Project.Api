#pragma checksum "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Stand\_editStand.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebddf1df94b8d4d1e14bd40005db236922859b7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stand__editStand), @"mvc.1.0.view", @"/Views/Stand/_editStand.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebddf1df94b8d4d1e14bd40005db236922859b7e", @"/Views/Stand/_editStand.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5190a7fa70597cf0160e9fb4f31b4a4a8d5480ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Stand__editStand : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<(StandDTO stand, List<ProcessDTO> processes)>
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
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-4"">
        <label class=""control-label"">Tezgah Adı :</label>
    </div>

    <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-8"">
        <input type=""text"" required=""required"" name=""Name"" class=""inpt-charter"" id=""StandDesk""");
            BeginWriteAttribute("value", " value=\"", 351, "\"", 376, 1);
#nullable restore
#line 9 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Stand\_editStand.cshtml"
WriteAttributeValue("", 359, Model.stand.Name, 359, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n</div>\r\n<div class=\"row\" style=\"margin-top: 3%;\">\r\n    <div class=\"col-lg-4 col-md-4 col-sm-4 col-xs-4\">\r\n        <label class=\"control-label\">İşlem :</label>\r\n    </div>\r\n    <input type=\"hidden\" name=\"Id\" id=\"Id\"");
            BeginWriteAttribute("value", " value=\"", 606, "\"", 629, 1);
#nullable restore
#line 16 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Stand\_editStand.cshtml"
WriteAttributeValue("", 614, Model.stand.Id, 614, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"StandNo\" id=\"standNo\"");
            BeginWriteAttribute("value", " value=\"", 687, "\"", 715, 1);
#nullable restore
#line 17 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Stand\_editStand.cshtml"
WriteAttributeValue("", 695, Model.stand.StandNo, 695, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <div class=\"col-lg-8 col-md-8 col-sm-8 col-xs-8\">\r\n        <select data-placeholder=\"Seçiniz ...\" required=\"required\" class=\"chosen-select\"");
            BeginWriteAttribute("id", " id=\"", 864, "\"", 869, 0);
            EndWriteAttribute();
            WriteLiteral(" name=\"ProccessId\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebddf1df94b8d4d1e14bd40005db236922859b7e5260", async() => {
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
#line 21 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Stand\_editStand.cshtml"
             foreach (var item in Model.processes)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Stand\_editStand.cshtml"
                 if (Model.stand.StandProcess.FirstOrDefault().ProcessId == item.ProcessLanguage.FirstOrDefault().ProcessId)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebddf1df94b8d4d1e14bd40005db236922859b7e6806", async() => {
                WriteLiteral("\r\n                        ");
#nullable restore
#line 26 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Stand\_editStand.cshtml"
                   Write(item.ProcessLanguage.FirstOrDefault().Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Stand\_editStand.cshtml"
                       WriteLiteral(item.Id);

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
#line 28 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Stand\_editStand.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebddf1df94b8d4d1e14bd40005db236922859b7e9349", async() => {
                WriteLiteral("\r\n                        ");
#nullable restore
#line 32 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Stand\_editStand.cshtml"
                   Write(item.ProcessLanguage.FirstOrDefault().Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Stand\_editStand.cshtml"
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
#line 34 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Stand\_editStand.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Stand\_editStand.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </select>
    </div>
</div>
<script>
    $('.chosen-select').chosen();
    function LoadEditPage() {
        setTimeout(function () { window.location.reload() }, 2000);
    }
    var onEditSuccess = function () {
        $('#MdlEditTable').modal('hide');
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<(StandDTO stand, List<ProcessDTO> processes)> Html { get; private set; }
    }
}
#pragma warning restore 1591