#pragma checksum "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\_OrderProductDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c047b13c05d396fe856e1a287bc3dde6f02a7ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order__OrderProductDetail), @"mvc.1.0.view", @"/Views/Order/_OrderProductDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c047b13c05d396fe856e1a287bc3dde6f02a7ca", @"/Views/Order/_OrderProductDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5190a7fa70597cf0160e9fb4f31b4a4a8d5480ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Order__OrderProductDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\" style=\"margin-top:10px\">\r\n    <div class=\"col-lg-3 col-md-3 col-sm-12 col-xs-12\">\r\n        <span><strong>Depo :</strong></span>\r\n    </div>\r\n    <div class=\"col-lg-9 col-md-9 col-sm-12 col-xs-12\">\r\n        <p>");
#nullable restore
#line 7 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\_OrderProductDetail.cshtml"
      Write(Model.Stores.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n\r\n");
            WriteLiteral(@"
    <div class=""col-lg-3 col-md-3 col-sm-12 col-xs-12"">
        <span><strong>Ürünler :</strong></span>
    </div>
    <div class=""col-lg-9 col-md-9 col-sm-12 col-xs-12"">
        <table class=""table table-striped table-bordered table-hover dataTables dataTable "">
            <thead>
                <tr>
                    <th>Ürün Adı</th>
                    <th>Adedi</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 29 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\_OrderProductDetail.cshtml"
                 foreach (var item in Model.OrderProducts)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 32 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\_OrderProductDetail.cshtml"
                       Write(item.Products.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 33 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\_OrderProductDetail.cshtml"
                       Write(item.Quantitiy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 35 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Order\_OrderProductDetail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
