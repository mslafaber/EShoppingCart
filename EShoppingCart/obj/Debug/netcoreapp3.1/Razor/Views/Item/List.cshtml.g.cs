#pragma checksum "C:\Users\Melisha Lafaber\Documents\EShoppingCart\EShoppingCart\Views\Item\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9087f072874af324a86c4766c4c70acf97f787e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_List), @"mvc.1.0.view", @"/Views/Item/List.cshtml")]
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
#line 1 "C:\Users\Melisha Lafaber\Documents\EShoppingCart\EShoppingCart\Views\_ViewImports.cshtml"
using EShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Melisha Lafaber\Documents\EShoppingCart\EShoppingCart\Views\_ViewImports.cshtml"
using EShoppingCart.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Melisha Lafaber\Documents\EShoppingCart\EShoppingCart\Views\_ViewImports.cshtml"
using EShoppingCart.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9087f072874af324a86c4766c4c70acf97f787e", @"/Views/Item/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d0cfb7cf46006e81b44b8c8631f20b37eb96835", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n    <h2>\r\n        All Items are shown here\r\n    </h2>\r\n</div>\r\n\r\n<h2>");
#nullable restore
#line 7 "C:\Users\Melisha Lafaber\Documents\EShoppingCart\EShoppingCart\Views\Item\List.cshtml"
Write(Model.CurrentCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 12 "C:\Users\Melisha Lafaber\Documents\EShoppingCart\EShoppingCart\Views\Item\List.cshtml"
          
            foreach (Item item in Model.Items)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Melisha Lafaber\Documents\EShoppingCart\EShoppingCart\Views\Item\List.cshtml"
           Write(Html.Partial("ItemsSummary", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Melisha Lafaber\Documents\EShoppingCart\EShoppingCart\Views\Item\List.cshtml"
                                                   
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
