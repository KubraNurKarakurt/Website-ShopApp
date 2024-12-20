#pragma checksum "D:\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bd28baac8726c7578d01af003c1c112fb0da056"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__navbar), @"mvc.1.0.view", @"/Views/Shared/_navbar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bd28baac8726c7578d01af003c1c112fb0da056", @"/Views/Shared/_navbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24a7865ee6f0c02b641a9919dafce89d19e4cd25", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__navbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bd28baac8726c7578d01af003c1c112fb0da0563659", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css\">\r\n    <!-- Diğer CSS dosyalarınız -->\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    <style>
    .navbar {
        background-color: #73777c; /* Daha sade ve modern bir renk */
    }

    .navbar-brand, .nav-link {
        color: #f8f9fa !important; /* Beyaz renk metin */
    }

    .nav-link {
        margin-left: 10px;
    }

    .nav-link:hover {
        color: #adb5bd !important; /* Hover efekti için daha açık bir gri */
    }

    .navbar-brand i, .nav-link i {
        margin-right: 5px; /* İkon ile metin arasında boşluk */
    }
</style>

<div class=""navbar bg-dark navbar-dark navbar-expand-sm"">
    <div class=""container"">
        <a href=""/"" class=""navbar-brand"">
            <i class=""fas fa-store""></i> ShopApp
        </a>
        <ul class=""navbar-nav mr-auto"">
            <li class=""nav-item"">
                <a href=""/products"" class=""nav-link"">
                    <i class=""fas fa-boxes""></i> Products
                </a>
            </li>

");
#nullable restore
#line 41 "D:\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml"
             if (User.Identity.IsAuthenticated && !User.IsInRole("admin"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <li class=""nav-item"">
                    <a href=""/cart"" class=""nav-link"">
                        <i class=""fas fa-shopping-cart""></i> Cart
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""/orders"" class=""nav-link"">
                        <i class=""fas fa-receipt""></i> Orders
                    </a>
                </li>
");
#nullable restore
#line 53 "D:\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 55 "D:\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml"
             if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <li class=""nav-item"">
                    <a href=""/admin/products"" class=""nav-link"">
                        <i class=""fas fa-cogs""></i> Admin Products
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""/admin/categories"" class=""nav-link"">
                        <i class=""fas fa-cogs""></i> Admin Categories
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""/admin/brands"" class=""nav-link"">
                        <i class=""fas fa-cogs""></i> Admin Brands
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""/admin/role/list"" class=""nav-link"">
                        <i class=""fas fa-cogs""></i> Roles
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""/admin/user/list"" class=""nav-link"">
                        <i class=""fas fa-us");
            WriteLiteral("ers-cog\"></i> Users\r\n                    </a>\r\n                </li>\r\n");
#nullable restore
#line 82 "D:\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n\r\n        <ul class=\"navbar-nav ml-auto\">\r\n");
#nullable restore
#line 86 "D:\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml"
             if (User.Identity.IsAuthenticated)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"nav-item\">\r\n                    <a href=\"/account/manage\" class=\"nav-link\">\r\n                        <i class=\"fas fa-user\"></i> ");
#nullable restore
#line 90 "D:\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml"
                                               Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""/account/logout"" class=""nav-link"">
                        <i class=""fas fa-sign-out-alt""></i> Logout
                    </a>
                </li>
");
#nullable restore
#line 98 "D:\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <li class=""nav-item"">
                    <a href=""/account/login"" class=""nav-link"">
                        <i class=""fas fa-sign-in-alt""></i> Login
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""/account/register"" class=""nav-link"">
                        <i class=""fas fa-user-plus""></i> Register
                    </a>
                </li>
");
#nullable restore
#line 111 "D:\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
