#pragma checksum "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\customer_cart_item\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3202eb7ca056f00a73b0022717a7ec51764794f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_customer_cart_item_Index), @"mvc.1.0.view", @"/Views/customer_cart_item/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3202eb7ca056f00a73b0022717a7ec51764794f", @"/Views/customer_cart_item/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6be1f3e4dee4bb8b078df23db921893d4069a58", @"/Views/_ViewImports.cshtml")]
    public class Views_customer_cart_item_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<wddn_online_shopping.Models.model_class.item_detail>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "remove_fro_cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "customer_cart_item", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "placer_order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\customer_cart_item\Index.cshtml"
Write(Html.Partial("_partial_view", "customer"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n");
#nullable restore
#line 5 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\customer_cart_item\Index.cshtml"
  
    ViewData["Title"] = "View";
    Layout = "~/Views/Shared/_Layout.cshtml";
    String product_image_path;
    List<wddn_online_shopping.Models.model_class.item_detail> list_cart = ViewBag.produc_in_cart;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Your cart</h1>\r\n\r\n<h1>Totle price ");
#nullable restore
#line 15 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\customer_cart_item\Index.cshtml"
           Write(ViewBag.total_price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\customer_cart_item\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.product_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\customer_cart_item\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.product_quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 28 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\customer_cart_item\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.product_description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\customer_cart_item\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.product_image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\customer_cart_item\Index.cshtml"
         foreach (var item in list_cart)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\customer_cart_item\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.product_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\customer_cart_item\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.product_price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\customer_cart_item\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.product_description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 51 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\customer_cart_item\Index.cshtml"
                      
                        product_image_path = "/product_image/" + item.product_image;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img style=\"height:100px;height:100px\"");
            BeginWriteAttribute("src", " src=\"", 1596, "\"", 1621, 1);
#nullable restore
#line 54 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\customer_cart_item\Index.cshtml"
WriteAttributeValue("", 1602, product_image_path, 1602, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3202eb7ca056f00a73b0022717a7ec51764794f9870", async() => {
                WriteLiteral("Remove frome cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\customer_cart_item\Index.cshtml"
                                                      WriteLiteral(item.product_id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 61 "E:\SEM 5\WDDN\A WDDN ONLINE SHOPPING\wddn_online_shopping\Views\customer_cart_item\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3202eb7ca056f00a73b0022717a7ec51764794f12364", async() => {
                WriteLiteral("Placer Order ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<wddn_online_shopping.Models.model_class.item_detail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
