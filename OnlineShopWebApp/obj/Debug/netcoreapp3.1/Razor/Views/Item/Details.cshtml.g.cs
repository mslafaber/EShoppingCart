#pragma checksum "C:\Users\Melisha Lafaber\Documents\EShoppingCart\OnlineShopWebApp\Views\Item\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d96f89fb295d22a4e46e734a1e1d47a21f29479f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_Details), @"mvc.1.0.view", @"/Views/Item/Details.cshtml")]
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
#line 1 "C:\Users\Melisha Lafaber\Documents\EShoppingCart\OnlineShopWebApp\Views\_ViewImports.cshtml"
using OnlineShopWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Melisha Lafaber\Documents\EShoppingCart\OnlineShopWebApp\Views\_ViewImports.cshtml"
using OnlineShopWebApp.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d96f89fb295d22a4e46e734a1e1d47a21f29479f", @"/Views/Item/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9236962b3ddaf37d5d27f29825ed0780c342639e", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Item>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 3 "C:\Users\Melisha Lafaber\Documents\EShoppingCart\OnlineShopWebApp\Views\Item\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div class=\"img-thumbnail\">\r\n    <img");
            BeginWriteAttribute("alt", " alt=\"", 76, "\"", 82, 0);
            EndWriteAttribute();
#nullable restore
#line 6 "C:\Users\Melisha Lafaber\Documents\EShoppingCart\OnlineShopWebApp\Views\Item\Details.cshtml"
          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" src=\"");
#nullable restore
#line 6 "C:\Users\Melisha Lafaber\Documents\EShoppingCart\OnlineShopWebApp\Views\Item\Details.cshtml"
                            Write(Model.ItemImageUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"/>\r\n    <div class=\"caption-full\">\r\n        <h3 class=\"float-right\">");
#nullable restore
#line 8 "C:\Users\Melisha Lafaber\Documents\EShoppingCart\OnlineShopWebApp\Views\Item\Details.cshtml"
                           Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <h3><a href=\"#\">");
#nullable restore
#line 9 "C:\Users\Melisha Lafaber\Documents\EShoppingCart\OnlineShopWebApp\Views\Item\Details.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n        <p>");
#nullable restore
#line 10 "C:\Users\Melisha Lafaber\Documents\EShoppingCart\OnlineShopWebApp\Views\Item\Details.cshtml"
      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Item> Html { get; private set; }
    }
}
#pragma warning restore 1591