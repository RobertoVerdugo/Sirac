#pragma checksum "D:\R_B_G\Documents\Web dev\C#\Sirac\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f75191e27510c9dbf94bf95a86d0c8247d16aaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Test_Razor.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Test_Razor.Pages
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
#line 1 "D:\R_B_G\Documents\Web dev\C#\Sirac\Pages\_ViewImports.cshtml"
using Test_Razor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\R_B_G\Documents\Web dev\C#\Sirac\Pages\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f75191e27510c9dbf94bf95a86d0c8247d16aaf", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dc9fa8977314e88b30768fc80a353b372227e35", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/01.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "VerPubl", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\R_B_G\Documents\Web dev\C#\Sirac\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"slider\">\r\n                <div class=\"img-responsive\">\r\n");
#nullable restore
#line 13 "D:\R_B_G\Documents\Web dev\C#\Sirac\Pages\Index.cshtml"
                     if (signInManager.IsSignedIn(User))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <!-- Aqui puede ir un slider con las publicaciones recomendadas por el algoritmo-->\r\n                        <ul class=\"bxslider\">\r\n                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7f75191e27510c9dbf94bf95a86d0c8247d16aaf4908", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7f75191e27510c9dbf94bf95a86d0c8247d16aaf6058", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7f75191e27510c9dbf94bf95a86d0c8247d16aaf7208", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                        </ul>\r\n");
#nullable restore
#line 21 "D:\R_B_G\Documents\Web dev\C#\Sirac\Pages\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
            </div>
        </div>
    </div>



<div class=""container"">
    <div class=""row"">
        <div class=""col-md-6 col-md-offset-3"">
            <div class=""text-center"">
                <h2>Multi Purpose Theme</h2>
                <p>Lorem ipsum dolor sit amet consectetur adipiscing elit Cras suscipit arcu<br> vestibulum volutpat libero sollicitudin vitae Curabitur ac aliquam <br> lorem sit amet scelerisque justo</p>
            </div>
            <hr>
        </div>
    </div>
</div>

<div class=""container"">
    <div class=""row"">
        <div class=""box"">
            <div class=""col-md-4"">
                <div class=""wow bounceIn"" data-wow-offset=""0"" data-wow-delay=""0.4s"">
                    <h4>Responsive</h4>
                    <div class=""icon"">
                        <i class=""fa fa-heart-o fa-3x""></i>
                    </div>
                    <p>Lorem ipsum dolor sit amet consectetur adipiscing elit Cras suscipit arcu libero</p>
  ");
            WriteLiteral(@"                  <div class=""ficon"">
                        <a href=""#"" class=""btn btn-default"" role=""button"">Read more</a>
                    </div>
                </div>
            </div>

            <div class=""col-md-4"">
                <div class=""wow bounceIn"" data-wow-offset=""0"" data-wow-delay=""1.0s"">
                    <h4>Multi Purpose</h4>
                    <div class=""icon"">
                        <i class=""fa fa-desktop fa-3x""></i>
                    </div>
                    <p>Lorem ipsum dolor sit amet consectetur adipiscing elit Cras suscipit arcu libero</p>
                    <div class=""ficon"">
                        <a href=""#"" class=""btn btn-default"" role=""button"">Read more</a>
                    </div>
                </div>
            </div>

            <div class=""col-md-4"">
                <div class=""wow bounceIn"" data-wow-offset=""0"" data-wow-delay=""1.6s"">
                    <h4>Easy Customize</h4>
                    <div class=""icon"">
       ");
            WriteLiteral(@"                 <i class=""fa fa-location-arrow fa-3x""></i>
                    </div>
                    <p>Lorem ipsum dolor sit amet consectetur adipiscing elit Cras suscipit arcu libero</p>
                    <div class=""ficon"">
                        <a href=""#"" class=""btn btn-default"" role=""button"">Read more</a>
                    </div>
                </div>

            </div>

        </div>
    </div>
</div>

<div class=""container"">
    <div class=""row"">
        <div class=""col-md-6 col-md-offset-3"">
            <div class=""text-center"">
                <h2>Mascotas</h2>
                <p>
                    Lorem ipsum dolor sit amet consectetur adipiscing elit Cras suscipit arcu<br> vestibulum volutpat libero sollicitudin vitae Curabitur ac aliquam <br>
                </p>
            </div>
            <hr>
        </div>
    </div>
</div>

<div class=""content"">
    <div class=""grid"">
");
#nullable restore
#line 104 "D:\R_B_G\Documents\Web dev\C#\Sirac\Pages\Index.cshtml"
         if (Model.Publicaciones.Count() > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "D:\R_B_G\Documents\Web dev\C#\Sirac\Pages\Index.cshtml"
             foreach (var pub in Model.Publicaciones)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <figure class=\"effect-zoe\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f75191e27510c9dbf94bf95a86d0c8247d16aaf12213", async() => {
                WriteLiteral("<img");
                BeginWriteAttribute("src", " src=\"", 4037, "\"", 4059, 2);
                WriteAttributeValue("", 4043, "img/", 4043, 4, true);
#nullable restore
#line 109 "D:\R_B_G\Documents\Web dev\C#\Sirac\Pages\Index.cshtml"
WriteAttributeValue("", 4047, pub.rutaimg, 4047, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 109 "D:\R_B_G\Documents\Web dev\C#\Sirac\Pages\Index.cshtml"
                        WriteLiteral(pub.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <figcaption>\r\n                        <h3>");
#nullable restore
#line 111 "D:\R_B_G\Documents\Web dev\C#\Sirac\Pages\Index.cshtml"
                       Write(pub.titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3><span>");
#nullable restore
#line 111 "D:\R_B_G\Documents\Web dev\C#\Sirac\Pages\Index.cshtml"
                                              Write(pub.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <p class=\"icon-links\">\r\n                            <a href=\"#\"><span>Report</span></a>\r\n                        </p>\r\n                        <p class=\"description\">");
#nullable restore
#line 115 "D:\R_B_G\Documents\Web dev\C#\Sirac\Pages\Index.cshtml"
                                          Write(pub.ubicacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </figcaption>\r\n                </figure>\r\n");
#nullable restore
#line 118 "D:\R_B_G\Documents\Web dev\C#\Sirac\Pages\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "D:\R_B_G\Documents\Web dev\C#\Sirac\Pages\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
