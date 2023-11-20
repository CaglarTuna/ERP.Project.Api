#pragma checksum "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\_OrderOutputDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff1fd3a991e206b513c0d24c8eddd48cd7cdf432"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order__OrderOutputDetail), @"mvc.1.0.view", @"/Views/Order/_OrderOutputDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff1fd3a991e206b513c0d24c8eddd48cd7cdf432", @"/Views/Order/_OrderOutputDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5190a7fa70597cf0160e9fb4f31b4a4a8d5480ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Order__OrderOutputDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-lg-4 col-md-4 col-sm-4 col-xs-4\">\r\n        <label class=\"control-label\">Sipariş No:</label>\r\n    </div>\r\n\r\n    <div class=\"col-lg-8 col-md-8 col-sm-8 col-xs-8\">\r\n        <label class=\"control-label\">");
#nullable restore
#line 8 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\_OrderOutputDetail.cshtml"
                                Write(Model.OrderNo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
    </div>
</div>

<div class=""row"" style=""margin-top:3%"">
    <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-4"">
        <label class=""control-label"">Firma :</label>
    </div>

    <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-8"">
        <label class=""control-label"">");
#nullable restore
#line 18 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\_OrderOutputDetail.cshtml"
                                      if (Model.Companies != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>");
#nullable restore
#line 19 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\_OrderOutputDetail.cshtml"
          Write(Model.Companies.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 19 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\_OrderOutputDetail.cshtml"
                                           }

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </label>
    </div>
</div>

<div class=""row"" style=""margin-top:3%"">
    <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-4"">
        <label class=""control-label"">Teslim Tarihi :</label>
    </div>

    <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-8"">
        <label class=""control-label"">");
#nullable restore
#line 29 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\_OrderOutputDetail.cshtml"
                                Write(Model.Deadline);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
    </div>
</div>

<div class=""row"" style=""margin-top:3%; margin-bottom:3%"">
    <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-4"">
        <label class=""control-label"">Teslim Adresi :</label>
    </div>

    <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-8"">
        <label class=""control-label"">
");
#nullable restore
#line 40 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\_OrderOutputDetail.cshtml"
             if (Model.Companies != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>");
#nullable restore
#line 41 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\_OrderOutputDetail.cshtml"
              Write(Model.Companies.CompanyAddressDTOs.Where(x => x.Id == Model.AddressId).Select(x => x.Address).FirstOrDefault());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 41 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\_OrderOutputDetail.cshtml"
                                                                                                                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </label>\r\n    </div>\r\n</div>");
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
