#pragma checksum "C:\Users\Dan\Desktop\html\HopSQL\ProjectHop\WebUI\Views\Store\Beer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5f94c8c3eb22946d108220b9f1778d1a15dd9d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_Beer), @"mvc.1.0.view", @"/Views/Store/Beer.cshtml")]
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
#line 1 "C:\Users\Dan\Desktop\html\HopSQL\ProjectHop\WebUI\Views\_ViewImports.cshtml"
using WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dan\Desktop\html\HopSQL\ProjectHop\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5f94c8c3eb22946d108220b9f1778d1a15dd9d4", @"/Views/Store/Beer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d8308283e147aceb640f85e77cb8c039e61219", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_Beer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Mods.Beer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Dan\Desktop\html\HopSQL\ProjectHop\WebUI\Views\Store\Beer.cshtml"
  
    ViewData["Title"] = "Beer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Beer</h1>\r\n\r\n<p>\r\n");
            WriteLiteral("</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Dan\Desktop\html\HopSQL\ProjectHop\WebUI\Views\Store\Beer.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Dan\Desktop\html\HopSQL\ProjectHop\WebUI\Views\Store\Beer.cshtml"
           Write(Html.DisplayNameFor(model => model.Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Dan\Desktop\html\HopSQL\ProjectHop\WebUI\Views\Store\Beer.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\Dan\Desktop\html\HopSQL\ProjectHop\WebUI\Views\Store\Beer.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n");
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\Dan\Desktop\html\HopSQL\ProjectHop\WebUI\Views\Store\Beer.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\Dan\Desktop\html\HopSQL\ProjectHop\WebUI\Views\Store\Beer.cshtml"
           Write(Html.DisplayFor(modelItem => item.Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <p>$ \r\n                ");
#nullable restore
#line 44 "C:\Users\Dan\Desktop\html\HopSQL\ProjectHop\WebUI\Views\Store\Beer.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\Dan\Desktop\html\HopSQL\ProjectHop\WebUI\Views\Store\Beer.cshtml"
           Write(Html.ActionLink("Edit Stock", "EditBeer", new { BeerId = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n");
            WriteLiteral("                ");
#nullable restore
#line 50 "C:\Users\Dan\Desktop\html\HopSQL\ProjectHop\WebUI\Views\Store\Beer.cshtml"
           Write(Html.ActionLink("Order", "Order", new { BeerId = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 54 "C:\Users\Dan\Desktop\html\HopSQL\ProjectHop\WebUI\Views\Store\Beer.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Mods.Beer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
