#pragma checksum "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\Shared\_partial_view.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be51b21a0463ad9b466c3ff15e08396e0d5989f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__partial_view), @"mvc.1.0.view", @"/Views/Shared/_partial_view.cshtml")]
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
#line 1 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\_ViewImports.cshtml"
using wddn_online_shopping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\_ViewImports.cshtml"
using wddn_online_shopping.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\_ViewImports.cshtml"
using wddn_online_shopping.view_model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\_ViewImports.cshtml"
using wddn_online_shopping.Models.additional_field;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be51b21a0463ad9b466c3ff15e08396e0d5989f0", @"/Views/Shared/_partial_view.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6be1f3e4dee4bb8b078df23db921893d4069a58", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__partial_view : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\Shared\_partial_view.cshtml"
  
    string roll = "";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\Shared\_partial_view.cshtml"
  
    if (signinmanager.IsSignedIn(User))
    {

        roll = usemanager.Users.Where(x => x.UserName == User.Identity.Name).FirstOrDefault().account_type.ToString();
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 14 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\Shared\_partial_view.cshtml"
 if (signinmanager.IsSignedIn(User) && Model == roll)
{

}
else
{
    if (Model == "customer")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script type=\"text/javascript\">\r\n            window.location.href = \"");
#nullable restore
#line 23 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\Shared\_partial_view.cshtml"
                               Write(Url.Action("login_customer", "customers"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n        </script>\r\n");
#nullable restore
#line 25 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\Shared\_partial_view.cshtml"
    }
    else if (Model == "seller")
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <script type=\"text/javascript\">\r\n            window.location.href = \"");
#nullable restore
#line 30 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\Shared\_partial_view.cshtml"
                               Write(Url.Action("login_seller", "sellers"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n        </script>\r\n");
#nullable restore
#line 32 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\Shared\_partial_view.cshtml"
    }

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<customer_identity> usemanager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<customer_identity> signinmanager { get; private set; }
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
