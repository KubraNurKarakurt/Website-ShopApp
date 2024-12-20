#pragma checksum "D:\shopapp\shopapp.webui\Views\Shop\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0de282b6d692b5309d85f66e8f4e71d3e18ae77a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_List), @"mvc.1.0.view", @"/Views/Shop/List.cshtml")]
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
#line 2 "D:\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0de282b6d692b5309d85f66e8f4e71d3e18ae77a", @"/Views/Shop/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24a7865ee6f0c02b641a9919dafce89d19e4cd25", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"<style>
    .product-list-container {
        background-color: #f8f9fa;
        padding: 20px;
        border-radius: 8px;
        box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
    }

    .pagination .page-link {
        color: #6c757d;
        background-color: #f8f9fa; 
        border-color: #6c757d; 
    }

  
    .pagination .page-item.active .page-link {
        color: #fff; 
        background-color: #6c757d; 
        border-color: #6c757d; 
    }
</style>
<div class=""row"">
    <div class=""col-md-3"">
        ");
#nullable restore
#line 26 "D:\shopapp\shopapp.webui\Views\Shop\List.cshtml"
   Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"col-md-9\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 31 "D:\shopapp\shopapp.webui\Views\Shop\List.cshtml"
             if (Model.Products.Count == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-12\">\r\n                    ");
#nullable restore
#line 34 "D:\shopapp\shopapp.webui\Views\Shop\List.cshtml"
               Write(await Html.PartialAsync("_noproduct"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 36 "D:\shopapp\shopapp.webui\Views\Shop\List.cshtml"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "D:\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                 foreach (var product in Model.Products)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-4\">\r\n                        ");
#nullable restore
#line 42 "D:\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                   Write(await Html.PartialAsync("_product", product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 44 "D:\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <nav aria-label=\"Page navigation example\">\r\n                    <ul class=\"pagination\">\r\n");
#nullable restore
#line 52 "D:\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                         for (int i = 0; i < Model.PageInfo.TotalPages(); i++)
                        {
                            var pageIndex = i + 1;
                            var isActive = Model.PageInfo.CurrentPage == pageIndex ? "active" : "";
                            var pageLink = String.IsNullOrEmpty(Model.PageInfo.CurrentCategory)
                                ? $"/products?page={pageIndex}"
                                : $"/products/{Model.PageInfo.CurrentCategory}?page={pageIndex}";


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li");
            BeginWriteAttribute("class", " class=\"", 1903, "\"", 1930, 2);
            WriteAttributeValue("", 1911, "page-item", 1911, 9, true);
#nullable restore
#line 60 "D:\shopapp\shopapp.webui\Views\Shop\List.cshtml"
WriteAttributeValue(" ", 1920, isActive, 1921, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1986, "\"", 2002, 1);
#nullable restore
#line 61 "D:\shopapp\shopapp.webui\Views\Shop\List.cshtml"
WriteAttributeValue("", 1993, pageLink, 1993, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 62 "D:\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                               Write(pageIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n                            </li>\r\n");
#nullable restore
#line 65 "D:\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </nav>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>
");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591