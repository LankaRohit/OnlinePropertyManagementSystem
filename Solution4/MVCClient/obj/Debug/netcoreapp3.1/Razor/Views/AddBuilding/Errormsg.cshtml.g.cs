#pragma checksum "C:\Users\sairo\source\repos\Solution4\MVCClient\Views\AddBuilding\Errormsg.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "321eae1d855b3abd1bf065988ad00a513a56cdf5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AddBuilding_Errormsg), @"mvc.1.0.view", @"/Views/AddBuilding/Errormsg.cshtml")]
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
#line 1 "C:\Users\sairo\source\repos\Solution4\MVCClient\Views\_ViewImports.cshtml"
using MVCClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sairo\source\repos\Solution4\MVCClient\Views\_ViewImports.cshtml"
using MVCClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"321eae1d855b3abd1bf065988ad00a513a56cdf5", @"/Views/AddBuilding/Errormsg.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e6d0ae0c9d7e6e45ee166fce82a68c9aa028843", @"/Views/_ViewImports.cshtml")]
    public class Views_AddBuilding_Errormsg : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h4>building has  not been added</h4>\r\n<h5>fill all the details</h5>\r\n<p>\r\n    <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 235, "\"", 281, 1);
#nullable restore
#line 9 "C:\Users\sairo\source\repos\Solution4\MVCClient\Views\AddBuilding\Errormsg.cshtml"
WriteAttributeValue("", 242, Url.Action("GetDetails","AddBuilding"), 242, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Add Building</a>\r\n    <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 331, "\"", 371, 1);
#nullable restore
#line 10 "C:\Users\sairo\source\repos\Solution4\MVCClient\Views\AddBuilding\Errormsg.cshtml"
WriteAttributeValue("", 338, Url.Action("Details","Building"), 338, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">List of available buildings</a>\r\n\r\n    <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 438, "\"", 474, 1);
#nullable restore
#line 12 "C:\Users\sairo\source\repos\Solution4\MVCClient\Views\AddBuilding\Errormsg.cshtml"
WriteAttributeValue("", 445, Url.Action("Logout","Login"), 445, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">signout</a>\r\n</p>\r\n");
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
