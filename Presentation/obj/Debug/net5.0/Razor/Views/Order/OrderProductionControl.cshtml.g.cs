#pragma checksum "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\OrderProductionControl.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb6aad6e22f61d37169f48b6a0ee555fdea96318"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_OrderProductionControl), @"mvc.1.0.view", @"/Views/Order/OrderProductionControl.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb6aad6e22f61d37169f48b6a0ee555fdea96318", @"/Views/Order/OrderProductionControl.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5190a7fa70597cf0160e9fb4f31b4a4a8d5480ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_OrderProductionControl : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrderProductionControl", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrderControlProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\OrderProductionControl.cshtml"
  
    ViewData["Title"] = "OrderProductionControl";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"wrapper wrapper-content animated fadeInRight mt60\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n           \r\n            <div class=\"row\">\r\n                <div class=\"col-lg-12\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb6aad6e22f61d37169f48b6a0ee555fdea963185932", async() => {
                WriteLiteral(@"
                        <fieldset class=""fieldset"">
                            <legend class=""fieldsetb"">Filtreleme Alanı</legend>

                            <div class=""row"">
                                <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6"">
                                    <div class=""input-group date"">
                                        <input type=""datetime"" class=""inpt-charter DatetimeChart"" name=""FirstDate""");
                BeginWriteAttribute("value", " value=\"", 902, "\"", 910, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        <span class=""input-group-addon""><i class=""fa fa-calendar""></i></span>
                                    </div>
                                </div>

                                <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6"">
                                    <div class=""input-group date"">
                                        <input type=""datetime"" class=""inpt-charter DatetimeChart"" name=""LastDate""");
                BeginWriteAttribute("value", " value=\"", 1375, "\"", 1383, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        <span class=""input-group-addon""><i class=""fa fa-calendar""></i></span>
                                    </div>
                                </div>
                            </div>

                            <div class=""row"" style=""margin-top: 3%;"">
                                <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                                    <div class=""row"">
                                        <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                                            <input type=""text"" name=""Filter""
                                                   class=""inpt-charter"" placeholder=""Giriniz..."">
                                        </div>
                                        <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                                            <button style="" float: right;margin-top:10px""
                                                    type=""submit"" cla");
                WriteLiteral(@"ss=""btn-charter-p m-b"">
                                                FİLTRELE
                                            </button>
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
                        <legend class=""fieldsetb"">Siparişler</legend>
                        <div class=""row"">
                            <div class=""col-xs-12"">
                                <div class=""table-responsive mb10"">
                                    <table class=""table table-striped table-bordered table-hover dataTables dataTable "">
                                        <thead>
                                            <tr>
");
            WriteLiteral(@"                                                <th>Siparişteki Ürünlere Git</th>
                                                <th>Sipariş Giriş Tarihi</th>
                                                <th>Sipariş No</th>
                                                <th>Sipariş Müşteri No</th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 72 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\OrderProductionControl.cshtml"
                                             foreach (var item in Model.OrderByDescending(x => x.Id))
                                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>\r\n                                                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb6aad6e22f61d37169f48b6a0ee555fdea9631812160", async() => {
                WriteLiteral("Ürünlere Git");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\OrderProductionControl.cshtml"
                                                                                                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </td>\r\n                                                    <td>");
#nullable restore
#line 77 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\OrderProductionControl.cshtml"
                                                   Write(item.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 78 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\OrderProductionControl.cshtml"
                                                   Write(item.OrderNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 79 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\OrderProductionControl.cshtml"
                                                   Write(item.OrderCustomerNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                </tr>\r\n");
#nullable restore
#line 81 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\OrderProductionControl.cshtml"
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
</div>
<script>
    $(function () {
        $('.DatetimeChart').datepicker({
            changeMonth: true,
            changeYear: true,
            format: ""dd/mm/yyyy"",
            language: ""tr""
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591