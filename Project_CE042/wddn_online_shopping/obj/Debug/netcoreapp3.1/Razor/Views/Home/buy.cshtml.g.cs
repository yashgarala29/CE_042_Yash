#pragma checksum "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\Home\buy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2194956c9eff1c948cf5b26cb7cb60858418a3e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_buy), @"mvc.1.0.view", @"/Views/Home/buy.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2194956c9eff1c948cf5b26cb7cb60858418a3e5", @"/Views/Home/buy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6be1f3e4dee4bb8b078df23db921893d4069a58", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_buy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<wddn_online_shopping.Models.model_class.item_detail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "place_order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "item_detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\Home\buy.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Place Order</h1>\r\n\r\n<div>\r\n    <h4>item_detail</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\Home\buy.cshtml"
       Write(Html.DisplayNameFor(model => model.product_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\Home\buy.cshtml"
       Write(Html.DisplayFor(model => model.product_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\Home\buy.cshtml"
       Write(Html.DisplayNameFor(model => model.product_price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\Home\buy.cshtml"
       Write(Html.DisplayFor(model => model.product_price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\Home\buy.cshtml"
       Write(Html.DisplayNameFor(model => model.product_description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\Home\buy.cshtml"
       Write(Html.DisplayFor(model => model.product_description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\Home\buy.cshtml"
       Write(Html.DisplayNameFor(model => model.product_image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 35 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\Home\buy.cshtml"
              var product_image_path = "/product_image/" +Model.product_image;
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <img class=\"card-img-top\" style=\"height:100px;width:100Px\"");
            BeginWriteAttribute("src", " src=\"", 1166, "\"", 1191, 1);
#nullable restore
#line 37 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\Home\buy.cshtml"
WriteAttributeValue("", 1172, product_image_path, 1172, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2194956c9eff1c948cf5b26cb7cb60858418a3e58193", async() => {
                WriteLiteral("Place Order");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\Home\buy.cshtml"
                                                                WriteLiteral(Model.product_id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n\r\n");
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<wddn_online_shopping.Models.model_class.item_detail> Html { get; private set; }
    }
}
#pragma warning restore 1591
