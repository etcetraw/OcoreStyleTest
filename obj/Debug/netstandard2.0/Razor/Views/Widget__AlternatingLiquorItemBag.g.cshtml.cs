#pragma checksum "C:\Users\rpc\OneDrive\Matebook X pro\OrchardNuget\AlternatingItems\Views\Widget__AlternatingLiquorItemBag.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e685e84a19e9205c330be92f4a63b253ce9aa8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Widget__AlternatingLiquorItemBag), @"mvc.1.0.view", @"/Views/Widget__AlternatingLiquorItemBag.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Widget__AlternatingLiquorItemBag.cshtml", typeof(AspNetCore.Views_Widget__AlternatingLiquorItemBag))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e685e84a19e9205c330be92f4a63b253ce9aa8d", @"/Views/Widget__AlternatingLiquorItemBag.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72c7104c706d2f8e8162ef473e14ea7835385a93", @"/_ViewImports.cshtml")]
    public class Views_Widget__AlternatingLiquorItemBag : OrchardCore.DisplayManagement.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-src", "/Alternating/css/alternatingitems.min.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-src", "/Alternating/alternating.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::OrchardCore.ResourceManagement.TagHelpers.StyleTagHelper __OrchardCore_ResourceManagement_TagHelpers_StyleTagHelper;
        private global::OrchardCore.ResourceManagement.TagHelpers.ScriptTagHelper __OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("style", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "001d2d80493e4a089c0ec94e39cbbc70", async() => {
            }
            );
            __OrchardCore_ResourceManagement_TagHelpers_StyleTagHelper = CreateTagHelper<global::OrchardCore.ResourceManagement.TagHelpers.StyleTagHelper>();
            __tagHelperExecutionContext.Add(__OrchardCore_ResourceManagement_TagHelpers_StyleTagHelper);
            __OrchardCore_ResourceManagement_TagHelpers_StyleTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 1 "C:\Users\rpc\OneDrive\Matebook X pro\OrchardNuget\AlternatingItems\Views\Widget__AlternatingLiquorItemBag.cshtml"
__OrchardCore_ResourceManagement_TagHelpers_StyleTagHelper.At = global::OrchardCore.ResourceManagement.ResourceLocation.Head;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("at", __OrchardCore_ResourceManagement_TagHelpers_StyleTagHelper.At, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(79, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(81, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ed03e11ba42416fb1e72c1ed56ab4aa", async() => {
            }
            );
            __OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper = CreateTagHelper<global::OrchardCore.ResourceManagement.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper);
            __OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper.Source = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 2 "C:\Users\rpc\OneDrive\Matebook X pro\OrchardNuget\AlternatingItems\Views\Widget__AlternatingLiquorItemBag.cshtml"
__OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper.At = global::OrchardCore.ResourceManagement.ResourceLocation.Foot;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("at", __OrchardCore_ResourceManagement_TagHelpers_ScriptTagHelper.At, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(146, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\rpc\OneDrive\Matebook X pro\OrchardNuget\AlternatingItems\Views\Widget__AlternatingLiquorItemBag.cshtml"
 if(Model.ContentItem.Content.BagPart.ContentItems.Count > 0)
{ 

#line default
#line hidden
            BeginContext(215, 186, true);
            WriteLiteral("<section id=\"about\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-12 text-center\">\r\n                <h2 class=\"section-heading text-uppercase\">");
            EndContext();
            BeginContext(402, 41, false);
#line 9 "C:\Users\rpc\OneDrive\Matebook X pro\OrchardNuget\AlternatingItems\Views\Widget__AlternatingLiquorItemBag.cshtml"
                                                      Write(Model.ContentItem.Content.TitlePart.Title);

#line default
#line hidden
            EndContext();
            BeginContext(443, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
            BeginContext(564, 140, true);
            WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-12\">\r\n                <div class=\"timeline\">\r\n");
            EndContext();
#line 16 "C:\Users\rpc\OneDrive\Matebook X pro\OrchardNuget\AlternatingItems\Views\Widget__AlternatingLiquorItemBag.cshtml"
                      
                        int i = 0;
                    

#line default
#line hidden
            BeginContext(787, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 19 "C:\Users\rpc\OneDrive\Matebook X pro\OrchardNuget\AlternatingItems\Views\Widget__AlternatingLiquorItemBag.cshtml"
                     foreach (var item in Model.ContentItem.Content.BagPart.ContentItems)
                    {

                        
                            var variable = "";
                            if (i % 2 == 0) { variable = "flex-row-reverse timeline-inverted"; }
                            i++;
                          

#line default
#line hidden
            BeginContext(1137, 28, true);
            WriteLiteral("                        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1165, "\"", 1191, 3);
            WriteAttributeValue("", 1173, "py-5", 1173, 4, true);
            WriteAttributeValue(" ", 1177, "row", 1178, 4, true);
#line 27 "C:\Users\rpc\OneDrive\Matebook X pro\OrchardNuget\AlternatingItems\Views\Widget__AlternatingLiquorItemBag.cshtml"
WriteAttributeValue(" ", 1181, variable, 1182, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1192, 179, true);
            WriteLiteral(">\r\n                            <div class=\"col-md-6 col-sm-12 d-flex justify-content-center timeline-image\">\r\n                                <img class=\"rounded-circle img-fluid\"");
            EndContext();
            BeginWriteAttribute("asset-src", " asset-src=\"", 1371, "\"", 1434, 1);
#line 29 "C:\Users\rpc\OneDrive\Matebook X pro\OrchardNuget\AlternatingItems\Views\Widget__AlternatingLiquorItemBag.cshtml"
WriteAttributeValue("", 1383, item.AlternatingItem.AlternatingItemImage.Paths[0], 1383, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1435, 59, true);
            WriteLiteral(" img-width=\"160\" img-height=\"160\" img-resize-mode=\"Stretch\"");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 1494, "\"", 1521, 1);
#line 29 "C:\Users\rpc\OneDrive\Matebook X pro\OrchardNuget\AlternatingItems\Views\Widget__AlternatingLiquorItemBag.cshtml"
WriteAttributeValue("", 1500, item.TitlePart.Title, 1500, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1522, 241, true);
            WriteLiteral(" />\r\n                            </div>\r\n                            <div class=\"col-md-6 col-sm-12 timeline-panel\">\r\n                                <div class=\"timeline-heading\">\r\n                                    <h4 class=\"subheading\">");
            EndContext();
            BeginContext(1764, 20, false);
#line 33 "C:\Users\rpc\OneDrive\Matebook X pro\OrchardNuget\AlternatingItems\Views\Widget__AlternatingLiquorItemBag.cshtml"
                                                      Write(item.TitlePart.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1784, 166, true);
            WriteLiteral("</h4>\r\n                                </div>\r\n                                <div class=\"timeline-body\">\r\n                                    <p class=\"text-muted\">");
            EndContext();
            BeginContext(1951, 22, false);
#line 36 "C:\Users\rpc\OneDrive\Matebook X pro\OrchardNuget\AlternatingItems\Views\Widget__AlternatingLiquorItemBag.cshtml"
                                                     Write(item.HtmlBodyPart.Html);

#line default
#line hidden
            EndContext();
            BeginContext(1973, 114, true);
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 40 "C:\Users\rpc\OneDrive\Matebook X pro\OrchardNuget\AlternatingItems\Views\Widget__AlternatingLiquorItemBag.cshtml"
                    }

#line default
#line hidden
            BeginContext(2110, 86, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            EndContext();
#line 47 "C:\Users\rpc\OneDrive\Matebook X pro\OrchardNuget\AlternatingItems\Views\Widget__AlternatingLiquorItemBag.cshtml"
}

#line default
#line hidden
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