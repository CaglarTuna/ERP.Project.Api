#pragma checksum "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\MeetingRecordList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcb76c4495d7bc5821dfab913390fb4b2518a9fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_MeetingRecordList), @"mvc.1.0.view", @"/Views/Order/MeetingRecordList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcb76c4495d7bc5821dfab913390fb4b2518a9fe", @"/Views/Order/MeetingRecordList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5190a7fa70597cf0160e9fb4f31b4a4a8d5480ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_MeetingRecordList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrderDetailInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MeetingRecordList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OfferList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MeetingRecordAdd", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-success", new global::Microsoft.AspNetCore.Html.HtmlString("onSuccess"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\MeetingRecordList.cshtml"
  
    ViewData["Title"] = "MeetingRecordList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"wrapper wrapper-content animated fadeInRight mt60\">\r\n\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <div class=\"tabs-container\">\r\n                <ul class=\"nav nav-tabs tab-border-top-danger\">\r\n                    <li");
            BeginWriteAttribute("class", " class=\"", 372, "\"", 380, 0);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcb76c4495d7bc5821dfab913390fb4b2518a9fe7381", async() => {
                WriteLiteral("Info&Ürünler");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\MeetingRecordList.cshtml"
                                                                                          WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                    <li class=\"active\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcb76c4495d7bc5821dfab913390fb4b2518a9fe9860", async() => {
                WriteLiteral("Görüşme Kaydı");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\MeetingRecordList.cshtml"
                                                                                                  WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                    <li");
            BeginWriteAttribute("class", " class=\"", 653, "\"", 661, 0);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcb76c4495d7bc5821dfab913390fb4b2518a9fe12471", async() => {
                WriteLiteral("Teklif Oluştur&Teklifler");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\MeetingRecordList.cshtml"
                                                                                    WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                </ul>
                <div class=""tab-content"">
                    <div id=""tab-1"" class=""tab-pane active"">
                        <div class=""panel-body"">
                            <!-- tab1 -->
                            <!--FİLTER AREA-->
                            <div class=""row"">
                                <div class=""col-lg-12"">
                                    <fieldset class=""fieldset"">
                                        <legend class=""fieldsetb"">Filtreleme Alanı</legend>

                                        <div class=""row"">
                                            <div class=""col-lg-11 col-md-11 col-sm-10 col-xs-10"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcb76c4495d7bc5821dfab913390fb4b2518a9fe15674", async() => {
                WriteLiteral(@"
                                                    <div class=""row"">
                                                        <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                                                            <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6"">
                                                                <div class=""input-group date"">
                                                                    <input type=""datetime"" class=""inpt-charter DatetimeChart"" name=""FirstDate""");
                BeginWriteAttribute("value", " value=\"", 2137, "\"", 2145, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                                    <span class=""input-group-addon""><i class=""fa fa-calendar""></i></span>
                                                                </div>
                                                            </div>
                                                            <input type=""hidden"" name=""id""");
                BeginWriteAttribute("value", " value=\"", 2518, "\"", 2535, 1);
#nullable restore
#line 38 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\MeetingRecordList.cshtml"
WriteAttributeValue("", 2526, Model.Id, 2526, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                                            <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6"">
                                                                <div class=""input-group date"">
                                                                    <input type=""datetime"" class=""inpt-charter DatetimeChart"" name=""LastDate""");
                BeginWriteAttribute("value", " value=\"", 2889, "\"", 2897, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                                    <span class=""input-group-addon""><i class=""fa fa-calendar""></i></span>
                                                                </div>
                                                            </div>
                                                            <input type=""text"" name=""Filter"" style=""margin-top:10px""
                                                                   class=""inpt-charter"" placeholder=""Giriniz..."">
                                                        </div>
                                                        <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                                                            <button style="" float: right;margin-top:10px""
                                                                    type=""submit"" class=""btn-charter-p m-b"">
                                                                FİLTRELE
                                           ");
                WriteLiteral("                 </button>\r\n                                                        </div>\r\n                                                    </div>\r\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
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
                                                <i data-toggle=""modal"" data-target=""#MdlAddProcess""
                                                   class=""fa fa-plus-square"" style=""font-size:35px; cursor: pointer; float:right""></i>
                                            </div>
                                        </div>
                                    </fieldset>
                                </div>
                            </div>


                            <div class=""row"" style=""margin-top:3%;"">
                                <div class=""col-lg-12"">
                                    <fieldset class=""fieldset"">
                                        <legend class=""fieldsetb"">Görüşme Listesi</legend>
                                        <!-- insert element row -->
                                        <div class=""ro");
            WriteLiteral(@"w"">
                                            <div class=""col-xs-12"">

                                                <!-- liste -->
                                                <div class=""form-group cf"">
                                                    <div class=""col-xs-12"">
                                                        <div class=""table-responsive mb10"">
                                                            <table class=""table table-striped table-bordered table-hover dataTables dataTable "">
                                                                <thead>
                                                                    <tr>
                                                                        <th>Görüşme Tarihi</th>
                                                                        <th>Görüşme Notu</th>
                                                                        <th>Hatırlatıcı Tarihi</th>
                                                   ");
            WriteLiteral(@"                     <th>Hatırlatıcı Notu</th>
                                                                    </tr>
                                                                </thead>
                                                                <tbody>
");
#nullable restore
#line 90 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\MeetingRecordList.cshtml"
                                                                     foreach (var item in Model.MeetingRecords)
                                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                        <tr>\r\n                                                                            <td>\r\n                                                                                ");
#nullable restore
#line 94 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\MeetingRecordList.cshtml"
                                                                           Write(item.MeetingDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                                            </td>\r\n                                                                            <td>\r\n                                                                                ");
#nullable restore
#line 97 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\MeetingRecordList.cshtml"
                                                                           Write(item.MeetingNote);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                                            </td>\r\n                                                                            <td>\r\n                                                                                ");
#nullable restore
#line 100 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\MeetingRecordList.cshtml"
                                                                           Write(item.ReminderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                                            </td>\r\n                                                                            <td>\r\n                                                                                ");
#nullable restore
#line 103 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\MeetingRecordList.cshtml"
                                                                           Write(item.ReminderNote);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                                            </td>\r\n                                                                        </tr>\r\n");
#nullable restore
#line 106 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\MeetingRecordList.cshtml"
                                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                                </tbody>
                                                            </table>
                                                        </div>

                                                    </div>
                                                </div>
                                                <!-- liste -->
                                            </div>
                                        </div>
                                    </fieldset>
                                </div>
                            </div>

                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>

    <div class=""modal fade"" id=""MdlAddProcess"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcb76c4495d7bc5821dfab913390fb4b2518a9fe27381", async() => {
                WriteLiteral(@"
                    <div class=""modal-header"">
                        <button type=""button"" class=""close"" data-dismiss=""modal""
                                aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                        <h4 class=""modal-title"" id=""myModalLabel"">Görüşme Kaydı Ekle</h4>
                    </div>
                    <div class=""modal-body"">
                        <input type=""hidden"" name=""OrderId""");
                BeginWriteAttribute("value", " value=\"", 9598, "\"", 9615, 1);
#nullable restore
#line 142 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\MeetingRecordList.cshtml"
WriteAttributeValue("", 9606, Model.Id, 9606, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                        <div class=""row"">
                            <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-4"">
                                <label class=""control-label"">Görüşme Tarihi :</label>
                            </div>

                            <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-8"">
                                <div class=""input-group date"">
                                    <input type=""text"" name=""MeetingDate"" class=""inpt-charter DatetimeChart""");
                BeginWriteAttribute("value", " value=\"", 10119, "\"", 10127, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                    <span class=""input-group-addon""><i class=""fa fa-calendar""></i></span>
                                </div>

                            </div>
                        </div>

                        <div class=""row"" style=""margin-top: 3%;"">
                            <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-4"">
                                <label class=""control-label"">Görüşme Notu :</label>
                            </div>

                            <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-8"">
                                <textarea name=""MeetingNote"" rows=""8"" cols=""40"" required=""required"" class=""inpt-charter""></textarea>

                            </div>
                        </div>

                        <div class=""row"" style=""margin-top: 3%;"">
                            <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-4"">
                                <label class=""control-label"">Hatırlatıcı Tarihi :</label>
           ");
                WriteLiteral(@"                 </div>

                            <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-8"">
                                <div class=""input-group date"">
                                    <input type=""text"" name=""ReminderDate"" class=""inpt-charter DatetimeChart""");
                BeginWriteAttribute("value", " value=\"", 11431, "\"", 11439, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                    <span class=""input-group-addon""><i class=""fa fa-calendar""></i></span>
                                </div>
                            </div>
                        </div>

                        <div class=""row"" style=""margin-top: 3%;"">
                            <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-4"">
                                <label class=""control-label"">Hatırlatıcı Notu :</label>
                            </div>

                            <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-8"">
                                <textarea name=""ReminderNote"" rows=""8"" cols=""40"" class=""inpt-charter""></textarea>

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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
        $('#MdlAddProcess').modal('hide');
        Swal.fire({
            icon: 'success',
            title: 'Kayıt İşlemi Başarılı',
            showConfirmButton: false,
            timer: 2000
        });
        LoadEditPage();
    };
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
