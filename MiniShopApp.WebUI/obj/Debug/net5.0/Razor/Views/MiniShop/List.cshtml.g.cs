#pragma checksum "C:\Users\PATRON\Desktop\Project\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdea219547eb780a842ef5290380d716b789b43d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MiniShop_List), @"mvc.1.0.view", @"/Views/MiniShop/List.cshtml")]
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
#line 2 "C:\Users\PATRON\Desktop\Project\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PATRON\Desktop\Project\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PATRON\Desktop\Project\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PATRON\Desktop\Project\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PATRON\Desktop\Project\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\PATRON\Desktop\Project\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.WebUI.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\PATRON\Desktop\Project\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdea219547eb780a842ef5290380d716b789b43d", @"/Views/MiniShop/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35c9e85769d47bd0cf7187da04d9af312a57049f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_MiniShop_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_NoProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-3\">\n        ");
#nullable restore
#line 5 "C:\Users\PATRON\Desktop\Project\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
   Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <div class=\"col-md-9\">\n        <div class=\"row\">\n");
#nullable restore
#line 9 "C:\Users\PATRON\Desktop\Project\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
             if (Model.Products.Count == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cdea219547eb780a842ef5290380d716b789b43d5418", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 12 "C:\Users\PATRON\Desktop\Project\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\PATRON\Desktop\Project\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
                 foreach (var product in Model.Products)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-4\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cdea219547eb780a842ef5290380d716b789b43d7111", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 18 "C:\Users\PATRON\Desktop\Project\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = product;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            WriteLiteral("                    </div>\n");
#nullable restore
#line 21 "C:\Users\PATRON\Desktop\Project\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\PATRON\Desktop\Project\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n        <div class=\"row\">\n            <div class=\"col\">\n                <nav>\n                    <ul class=\"pagination\">\n");
#nullable restore
#line 28 "C:\Users\PATRON\Desktop\Project\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
                         for (int i = 0; i < Model.PageInfo.TotalPages(); i++)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\PATRON\Desktop\Project\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
                             if (string.IsNullOrEmpty(Model.PageInfo.CurrentCategory))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li");
            BeginWriteAttribute("class", " class=\"", 1051, "\"", 1119, 2);
            WriteAttributeValue("", 1059, "page-item", 1059, 9, true);
#nullable restore
#line 32 "C:\Users\PATRON\Desktop\Project\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
WriteAttributeValue(" ", 1068, Model.PageInfo.CurrentPage==i+1 ? "active" : "", 1069, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1160, "\"", 1188, 2);
            WriteAttributeValue("", 1167, "/products?page=", 1167, 15, true);
#nullable restore
#line 33 "C:\Users\PATRON\Desktop\Project\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
WriteAttributeValue("", 1182, i+1, 1182, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\">");
#nullable restore
#line 33 "C:\Users\PATRON\Desktop\Project\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
                                                                                  Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                </li>\n");
#nullable restore
#line 35 "C:\Users\PATRON\Desktop\Project\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li");
            BeginWriteAttribute("class", " class=\"", 1385, "\"", 1453, 2);
            WriteAttributeValue("", 1393, "page-item", 1393, 9, true);
#nullable restore
#line 38 "C:\Users\PATRON\Desktop\Project\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
WriteAttributeValue(" ", 1402, Model.PageInfo.CurrentPage==i+1 ? "active" : "", 1403, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1494, "\"", 1554, 4);
            WriteAttributeValue("", 1501, "/products/", 1501, 10, true);
#nullable restore
#line 39 "C:\Users\PATRON\Desktop\Project\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
WriteAttributeValue("", 1511, Model.PageInfo.CurrentCategory, 1511, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1542, "?page=", 1542, 6, true);
#nullable restore
#line 39 "C:\Users\PATRON\Desktop\Project\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
WriteAttributeValue("", 1548, i+1, 1548, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\">");
#nullable restore
#line 39 "C:\Users\PATRON\Desktop\Project\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
                                                                                                                  Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                </li>\n");
#nullable restore
#line 41 "C:\Users\PATRON\Desktop\Project\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\PATRON\Desktop\Project\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n                    </ul>\n                </nav>\n            </div>\n        </div>\n    </div>\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
