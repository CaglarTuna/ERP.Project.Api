#pragma checksum "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\_ProductMainList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab2b562f500f0625d51bda76b705e4414ca0c003"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product__ProductMainList), @"mvc.1.0.view", @"/Views/Product/_ProductMainList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab2b562f500f0625d51bda76b705e4414ca0c003", @"/Views/Product/_ProductMainList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5190a7fa70597cf0160e9fb4f31b4a4a8d5480ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Product__ProductMainList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\_ProductMainList.cshtml"
 foreach (var item in Model.OrderByDescending(x => x.Id))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab2b562f500f0625d51bda76b705e4414ca0c0034396", async() => {
                WriteLiteral("Detay Gör");
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
#line 5 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\_ProductMainList.cshtml"
                                                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 6 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\_ProductMainList.cshtml"
         if (item.ProductType != 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>Özel Ürün</td>\r\n");
#nullable restore
#line 9 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\_ProductMainList.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>Standart Ürün</td>\r\n");
#nullable restore
#line 13 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\_ProductMainList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td>");
#nullable restore
#line 14 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\_ProductMainList.cshtml"
       Write(item.ProductionSerialNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 15 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\_ProductMainList.cshtml"
       Write(item.BarcodeNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>\r\n");
#nullable restore
#line 17 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\_ProductMainList.cshtml"
             foreach (var item2 in item.Categories.CategoryLanguageDTOs.Take(1))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>");
#nullable restore
#line 19 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\_ProductMainList.cshtml"
                 Write(item2.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 20 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\_ProductMainList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </td>\r\n        <td>");
#nullable restore
#line 22 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\_ProductMainList.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>\r\n");
#nullable restore
#line 24 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\_ProductMainList.cshtml"
             if (item.productMaterialDTOs.Count > 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\_ProductMainList.cshtml"
           Write(item.productMaterialDTOs.FirstOrDefault().Count);

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\_ProductMainList.cshtml"
                                                                
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </td>\r\n        <td>");
#nullable restore
#line 29 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\_ProductMainList.cshtml"
       Write(item.ProductCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 32 "C:\Users\Çağlar\OneDrive\Masaüstü\ERP Project Api\Presentation\Views\Product\_ProductMainList.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
