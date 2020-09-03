using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShoppingCart.TagHelpers
{
    //Inherit from the base class - Tag Helper class
    public class EmailTagHelper: TagHelper
    {
        //This tag helper is used to show a link to the user in order to send an email through the contact us page
        public string Address { get; set; }

        public string Content { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailto:" + Address);
            output.Content.SetContent(Content);
        }
    }
}
