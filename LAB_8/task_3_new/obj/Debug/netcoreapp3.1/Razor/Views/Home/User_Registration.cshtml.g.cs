#pragma checksum "E:\SEM 5\WDDN\LAB_8\task_3_new\Views\Home\User_Registration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f544fb27aea62fd9f78ae3eaf7bde6227f1fc412"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_User_Registration), @"mvc.1.0.view", @"/Views/Home/User_Registration.cshtml")]
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
#line 1 "E:\SEM 5\WDDN\LAB_8\task_3_new\Views\_ViewImports.cshtml"
using task_3_new;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\SEM 5\WDDN\LAB_8\task_3_new\Views\_ViewImports.cshtml"
using task_3_new.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f544fb27aea62fd9f78ae3eaf7bde6227f1fc412", @"/Views/Home/User_Registration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28e02ec3a560fb7bf37d0ae033984ce0db6acbe8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_User_Registration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\SEM 5\WDDN\LAB_8\task_3_new\Views\Home\User_Registration.cshtml"
  
    ViewData["Title"] = "User_Registration";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""float-left"">
    <table>
        <tbody>
            <tr colspan=""2"">
                <td colspan=""2"">
                    <div class=""text-center"">Registation</div>
                </td>
            </tr>
            <tr>
                <td>
                    Username
                </td>
                <td>
                    <input type=""text"" />
");
            WriteLiteral("                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    Password\r\n                </td>\r\n                <td>\r\n                    <input type=\"password\" />\r\n");
            WriteLiteral(@"                </td>
            </tr>
            <tr >
                <td colspan=""2""><input type=""submit"" /></td>
            </tr>
         </tbody>
    </table>
    
</div>

<div class=""float-right"">
    <table>
        <tbody>
            <tr colspan=""2"">
                <td colspan=""2"">
                    <div class=""text-center"">Login</div>
                </td>
            </tr>
            <tr>
                <td>
                    Username
                </td>
                <td>
                    <input type=""text"" />
");
            WriteLiteral("                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    Password\r\n                </td>\r\n                <td>\r\n                    <input type=\"password\" />\r\n");
            WriteLiteral("                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    re-Password\r\n                </td>\r\n                <td>\r\n                    <input type=\"password\" />\r\n");
            WriteLiteral("                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    Gender\r\n                </td>\r\n                <td>\r\n                    \r\n                    Male <input type=\"radio\" name=\"gender\"/> \r\n");
            WriteLiteral("                    Female <input type=\"radio\"  name=\"gender\"/>\r\n");
            WriteLiteral("                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    Email\r\n                </td>\r\n                <td>\r\n                    <input type=\"email\" />\r\n");
            WriteLiteral("                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    Mobil number\r\n                </td>\r\n                <td>\r\n                    <input type=\"number\" />\r\n");
            WriteLiteral("                </td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"2\"><input type=\"submit\" /></td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n\r\n</div>\r\n");
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
