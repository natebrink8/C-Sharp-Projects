#pragma checksum "C:\Users\ochob\OneDrive\Documents\GitHub\TTA_Basic_C-Sharp_Projects\Basic_C#_Programs\LMSStep548ASPNetCoreWebApp\LMSStep548ASPNetCoreWebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "118f44f68177a3089703c5c032f32e1b14e049bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ochob\OneDrive\Documents\GitHub\TTA_Basic_C-Sharp_Projects\Basic_C#_Programs\LMSStep548ASPNetCoreWebApp\LMSStep548ASPNetCoreWebApp\Views\_ViewImports.cshtml"
using LMSStep548ASPNetCoreWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ochob\OneDrive\Documents\GitHub\TTA_Basic_C-Sharp_Projects\Basic_C#_Programs\LMSStep548ASPNetCoreWebApp\LMSStep548ASPNetCoreWebApp\Views\_ViewImports.cshtml"
using LMSStep548ASPNetCoreWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ochob\OneDrive\Documents\GitHub\TTA_Basic_C-Sharp_Projects\Basic_C#_Programs\LMSStep548ASPNetCoreWebApp\LMSStep548ASPNetCoreWebApp\Views\Home\Index.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ochob\OneDrive\Documents\GitHub\TTA_Basic_C-Sharp_Projects\Basic_C#_Programs\LMSStep548ASPNetCoreWebApp\LMSStep548ASPNetCoreWebApp\Views\Home\Index.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"118f44f68177a3089703c5c032f32e1b14e049bb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2f670d51d2c3416b7ae34af8084e9baab00b536", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\ochob\OneDrive\Documents\GitHub\TTA_Basic_C-Sharp_Projects\Basic_C#_Programs\LMSStep548ASPNetCoreWebApp\LMSStep548ASPNetCoreWebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>The current time is:</p>\r\n    <p>");
#nullable restore
#line 11 "C:\Users\ochob\OneDrive\Documents\GitHub\TTA_Basic_C-Sharp_Projects\Basic_C#_Programs\LMSStep548ASPNetCoreWebApp\LMSStep548ASPNetCoreWebApp\Views\Home\Index.cshtml"
  Write(DateTime.Now.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <h2 class=\"text-xl-center\" style=\"font-family:\'Comic Sans MS\'; color:rebeccapurple\">SRS BIZNISS FONT!!</h2>\r\n</div>\r\n");
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