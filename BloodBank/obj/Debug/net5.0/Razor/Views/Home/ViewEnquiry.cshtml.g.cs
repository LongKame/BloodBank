#pragma checksum "C:\Users\Computer\Desktop\BloodBank\BloodBank\Views\Home\ViewEnquiry.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab8bebf625f2df361c54e3c4ff52dd8c582ed51d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewEnquiry), @"mvc.1.0.view", @"/Views/Home/ViewEnquiry.cshtml")]
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
#line 1 "C:\Users\Computer\Desktop\BloodBank\BloodBank\Views\_ViewImports.cshtml"
using BloodBank;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Computer\Desktop\BloodBank\BloodBank\Views\Home\ViewEnquiry.cshtml"
using BloodBank.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab8bebf625f2df361c54e3c4ff52dd8c582ed51d", @"/Views/Home/ViewEnquiry.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df15cc4366a66067ef89a117130e7d6f729118d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewEnquiry : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FullInfor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<style>
    table {
        font-family: arial, sans-serif;
        border-collapse: collapse;
        width: 100%;
    }

    td, th {
        border: 1px solid #dddddd;
        text-align: left;
        padding: 8px;
    }

    tr:nth-child(even) {
        background-color: #dddddd;
    }
</style>
<table>
    <tr>
        <th>Name</th>
        <th>Contact</th>
        <th>Bloodtype</th>
    </tr>
");
#nullable restore
#line 33 "C:\Users\Computer\Desktop\BloodBank\BloodBank\Views\Home\ViewEnquiry.cshtml"
     foreach (var i in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\Computer\Desktop\BloodBank\BloodBank\Views\Home\ViewEnquiry.cshtml"
           Write(i.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\Computer\Desktop\BloodBank\BloodBank\Views\Home\ViewEnquiry.cshtml"
           Write(i.ContactNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 38 "C:\Users\Computer\Desktop\BloodBank\BloodBank\Views\Home\ViewEnquiry.cshtml"
           Write(i.Bloodname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 40 "C:\Users\Computer\Desktop\BloodBank\BloodBank\Views\Home\ViewEnquiry.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FullInfor>> Html { get; private set; }
    }
}
#pragma warning restore 1591