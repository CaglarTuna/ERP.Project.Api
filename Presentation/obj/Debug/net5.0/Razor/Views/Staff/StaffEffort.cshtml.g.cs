#pragma checksum "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Staff\StaffEffort.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0adedc593c485862f4df19b36cb007e954510218"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staff_StaffEffort), @"mvc.1.0.view", @"/Views/Staff/StaffEffort.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0adedc593c485862f4df19b36cb007e954510218", @"/Views/Staff/StaffEffort.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5190a7fa70597cf0160e9fb4f31b4a4a8d5480ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Staff_StaffEffort : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<StaffProcessDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Staff\StaffEffort.cshtml"
  
    ViewData["Title"] = "StaffEffort";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var lastMonth = DateTime.Now.AddMonths(-1);
    int? saat=0;
    int? dakika=0;
    int? saniye=0;
    foreach (var item in Model.Where(x=>x.CreateDate>=lastMonth&&x.SignatureStatu==true))
    {
        saat = saat + item.Hour;
        dakika = dakika + item.Minute;
        saniye = saniye + item.Second;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"wrapper wrapper-content animated fadeInRight mt60\">\r\n    <div class=\"tabs-container\">\r\n        <ul class=\"nav nav-tabs tab-border-top-danger\">\r\n            <li");
            BeginWriteAttribute("class", " class=\"", 621, "\"", 629, 0);
            EndWriteAttribute();
            WriteLiteral(@"><a href=""personel-bilgileri.html"">Personel Bilgileri</a></li>
            <li class=""active""><a href=""personel-usta-eforları.html"">Bitirdiği Siparişler&Eforları</a></li>
        </ul>
        <div class=""tab-content"">
            <div id=""tab-1"" class=""tab-pane active"">
                <div class=""panel-body"">

                    <fieldset class=""fieldset"">
                        <legend class=""fieldsetb"">Filtreleme Alanı</legend>

                        <div class=""row"">
                            <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6"">
                                <div class=""input-group date"">
                                    <input type=""text"" class=""inpt-charter""");
            BeginWriteAttribute("value", " value=\"", 1340, "\"", 1348, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <span class=""input-group-addon""><i class=""fa fa-calendar""></i></span>
                                </div>
                            </div>

                            <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6"">
                                <div class=""input-group date"">
                                    <input type=""text"" class=""inpt-charter""");
            BeginWriteAttribute("value", " value=\"", 1755, "\"", 1763, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <span class=""input-group-addon""><i class=""fa fa-calendar""></i></span>
                                </div>
                            </div>
                        </div>

                        <div class=""row"" style=""margin-top:3%"">
                            <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                                <input type=""text""");
            BeginWriteAttribute("name", " name=\"", 2182, "\"", 2189, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"inpt-charter\" placeholder=\"Giriniz...\">\r\n                            </div>\r\n                        </div>\r\n                        <label style=\"margin-top:3%\">\r\n                            <input type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 2412, "\"", 2420, 0);
            EndWriteAttribute();
            WriteLiteral(@" checked=""checked"" name=""ax"">
                            <i></i>
                            Tahmini Süreden Uzun Sürenler
                        </label>

                        <div class=""row"" style=""margin-top:3%"">
                            <div class=""col-lg-12 col-md-12 col-md-12 col-xs-12"">
                                <button style="" float: right""
                                        type=""submit""
                                        class=""btn-charter-p m-b"">
                                    FİLTRELE
                                </button>
                            </div>
                        </div>
                    </fieldset>

                    <div class=""row"">
                        <div class=""col-xs-12"">
                            <div class=""row"">
                                <div class=""col-lg-12"">
                                    <fieldset class=""fieldset"">
                                        <legend class=""fieldsetb"">Efor</legend");
            WriteLiteral(">\r\n");
            WriteLiteral(@"
                                        <div class=""row"">
                                            <div class=""col-xs-12"">
                                                <div class=""table-responsive mb10"">
                                                    <table class=""table table-striped table-bordered table-hover dataTables dataTable "">
                                                        <thead>
                                                            <tr>
                                                                <th>Tarih</th>
                                                                <th>adam/saat</th>
                                                            </tr>
                                                        </thead>
                                                        <tbody>
");
#nullable restore
#line 87 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Staff\StaffEffort.cshtml"
                                                             foreach (var item in Model.Where(x=>x.SignatureStatu==true))
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <tr>\r\n                                                                    <td>");
#nullable restore
#line 90 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Staff\StaffEffort.cshtml"
                                                                   Write(item.UpdateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                    <td>");
#nullable restore
#line 91 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Staff\StaffEffort.cshtml"
                                                                   Write(item.Hour);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Saat ");
#nullable restore
#line 91 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Staff\StaffEffort.cshtml"
                                                                                   Write(item.Minute);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Dakika ");
#nullable restore
#line 91 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Staff\StaffEffort.cshtml"
                                                                                                       Write(item.Second);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Saniye</td>\r\n                                                                </tr>\r\n");
#nullable restore
#line 93 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Staff\StaffEffort.cshtml"
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

                        </div>
                    </div>


                    <div class=""row"">
                        <div class=""col-xs-12"">
                            <div class=""row"">
                                <div class=""col-lg-12"">
                                    <fieldset class=""fieldset"">
                                        <legend class=""fieldsetb"">Bitirilen İşler Listesi</legend>
                                        <div class=""row"">
                                            <div class=""col-xs-12"">
                                                <div class=""");
            WriteLiteral(@"table-responsive mb10"">
                                                    <table class=""table table-striped table-bordered table-hover dataTables dataTable "">
                                                        <thead>
                                                            <tr>
                                                                <th>Çalışma Tarihi</th>
                                                                <th>Üretim Seri No</th>
                                                                <th>Ürün Adı</th>
                                                                <th>Ürün No</th>
                                                                <th>İşlem Adı</th>
                                                                <th>Harcanan Süre</th>
                                                            </tr>
                                                        </thead>
                                                        <tbody>
");
#nullable restore
#line 130 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Staff\StaffEffort.cshtml"
                                                             foreach (var item in Model.Where(x=>x.SignatureStatu==true))
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <tr>\r\n                                                                    <td>");
#nullable restore
#line 133 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Staff\StaffEffort.cshtml"
                                                                   Write(item.UpdateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                    <td>");
#nullable restore
#line 134 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Staff\StaffEffort.cshtml"
                                                                   Write(item.ProductDTO.ProductionSerialNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                    <td>");
#nullable restore
#line 135 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Staff\StaffEffort.cshtml"
                                                                   Write(item.ProductDTO.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                    <td>");
#nullable restore
#line 136 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Staff\StaffEffort.cshtml"
                                                                   Write(item.ProductDTO.BarcodeNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                    <td>");
#nullable restore
#line 137 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Staff\StaffEffort.cshtml"
                                                                   Write(item.ProcessDTO.ProcessLanguage.FirstOrDefault().Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                    <td>");
#nullable restore
#line 138 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Staff\StaffEffort.cshtml"
                                                                   Write(item.Hour);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Saat ");
#nullable restore
#line 138 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Staff\StaffEffort.cshtml"
                                                                                   Write(item.Minute);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Dakika ");
#nullable restore
#line 138 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Staff\StaffEffort.cshtml"
                                                                                                       Write(item.Second);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Saniye</td>\r\n                                                                </tr>\r\n");
#nullable restore
#line 140 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Staff\StaffEffort.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                        </tbody>
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
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<StaffProcessDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591