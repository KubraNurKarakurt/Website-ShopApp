#pragma checksum "D:\shopapp\shopapp.webui\Views\Cart\Orders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a06d8b0e97a5d5cd46083ecb23c86f2bc82bb00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Orders), @"mvc.1.0.view", @"/Views/Cart/Orders.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a06d8b0e97a5d5cd46083ecb23c86f2bc82bb00", @"/Views/Cart/Orders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24a7865ee6f0c02b641a9919dafce89d19e4cd25", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Orders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderListModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n<h1 class=\"mb-4\">Orders</h1>\r\n<hr>\r\n\r\n");
#nullable restore
#line 8 "D:\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
 foreach (var order in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card mb-4 shadow-sm\">\r\n        <div class=\"card-header bg-success text-white\">\r\n            <div class=\"d-flex justify-content-between align-items-center\">\r\n                <h5 class=\"mb-0\">Order Id: #");
#nullable restore
#line 13 "D:\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
                                       Write(order.OrderNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <span class=\"badge badge-light\">Total: ");
#nullable restore
#line 14 "D:\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
                                                  Write(order.TotalPrice().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <table class=\"table table-borderless\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>Product Name</th>\r\n");
            WriteLiteral("                        <th>Price</th>\r\n                        <th>Quantity</th>\r\n                        <th>Total</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 29 "D:\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
                     foreach (var orderItem in order.OrderItems)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 32 "D:\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
                           Write(orderItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("\r\n                            <td>");
#nullable restore
#line 35 "D:\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
                           Write(orderItem.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 36 "D:\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
                           Write(orderItem.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 37 "D:\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
                            Write((orderItem.Quantity * orderItem.Price).ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 39 "D:\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
            <div class=""mt-4"">
                <h5>Customer Details</h5>
                <ul class=""list-group list-group-flush"">
                    <li class=""list-group-item""><strong>Customer Name:</strong> ");
#nullable restore
#line 45 "D:\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
                                                                           Write(order.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 45 "D:\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
                                                                                            Write(order.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li class=\"list-group-item\"><strong>Address:</strong> ");
#nullable restore
#line 46 "D:\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
                                                                     Write(order.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li class=\"list-group-item\"><strong>Email:</strong> ");
#nullable restore
#line 47 "D:\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
                                                                   Write(order.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li class=\"list-group-item\"><strong>Phone:</strong> ");
#nullable restore
#line 48 "D:\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
                                                                   Write(order.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li class=\"list-group-item\"><strong>Order Status:</strong> ");
#nullable restore
#line 49 "D:\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
                                                                          Write(order.OrderState);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li class=\"list-group-item\"><strong>Payment Type:</strong> ");
#nullable restore
#line 50 "D:\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
                                                                          Write(order.PaymentType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 55 "D:\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <style>
        .card {
            border: none;
            border-radius: 10px;
            transition: transform 0.3s ease-in-out, box-shadow 0.3s ease-in-out;
        }

        .card-header {
            border-top-left-radius: 10px;
            border-top-right-radius: 10px;
        }

        .card:hover {
            transform: translateY(-10px);
            box-shadow: 0 10px 20px rgba(0, 0, 0, 0.15);
        }

        .list-group-item {
            border: none;
            padding-left: 0;
        }

        .list-group-item strong {
            width: 150px;
            display: inline-block;
        }
    </style>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderListModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
