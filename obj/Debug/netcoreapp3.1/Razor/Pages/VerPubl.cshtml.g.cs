#pragma checksum "D:\R_B_G\Documents\Web dev\C#\Sirac\Pages\VerPubl.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "403b524b25ec37227b105650bf7367efedc1fdff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Test_Razor.Pages.Pages_VerPubl), @"mvc.1.0.razor-page", @"/Pages/VerPubl.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"403b524b25ec37227b105650bf7367efedc1fdff", @"/Pages/VerPubl.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dc9fa8977314e88b30768fc80a353b372227e35", @"/Pages/_ViewImports.cshtml")]
    public class Pages_VerPubl : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\R_B_G\Documents\Web dev\C#\Sirac\Pages\VerPubl.cshtml"
  
    ViewData["Title"] = Model.Publicacion.titulo;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6 col-md-offset-3\">\r\n            <div class=\"blogs\">\r\n                <div class=\"text-center\">\r\n                    <h2>");
#nullable restore
#line 11 "D:\R_B_G\Documents\Web dev\C#\Sirac\Pages\VerPubl.cshtml"
                   Write(Model.Publicacion.titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                </div>
                <hr>
            </div>
        </div>
    </div>
</div>
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-8 col-md-offset-2"">
            <div class=""page-header"">
                <div class=""blog"">
                    <h5>");
#nullable restore
#line 23 "D:\R_B_G\Documents\Web dev\C#\Sirac\Pages\VerPubl.cshtml"
                   Write(Model.Publicacion.fecha.ToString("dd MMMM, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 709, "\"", 745, 2);
            WriteAttributeValue("", 715, "img/", 715, 4, true);
#nullable restore
#line 24 "D:\R_B_G\Documents\Web dev\C#\Sirac\Pages\VerPubl.cshtml"
WriteAttributeValue("", 719, Model.Publicacion.rutaimg, 719, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-responsive\" />\r\n                    <h3>");
#nullable restore
#line 25 "D:\R_B_G\Documents\Web dev\C#\Sirac\Pages\VerPubl.cshtml"
                   Write(Model.Publicacion.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <h4>&ensp; ");
#nullable restore
#line 26 "D:\R_B_G\Documents\Web dev\C#\Sirac\Pages\VerPubl.cshtml"
                          Write(Model.Publicacion.especie);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                    <p>
                        Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam,quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut
                        aliquip ex ea commodo consequat.
                    </p>



                    <p>
                        Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore
                        te feugait nulla facilisi. Nam liber tempor cum soluta nobis eleifend option congue nihil imperdiet doming id quod mazim placerat facer possim assum. Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem.
                    </p>

                    <p>Nam liber tempor cum soluta n");
            WriteLiteral(@"obis eleifend option congue nihil imperdiet doming id quod mazim placerat facer possim assum. Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum.</p>

                    <p>
                        Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut
                        aliquip ex ea commodo consequat.
                    </p>
                    <p><a href=""#"">Reportar</a></p>

                </div>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Test_Razor.Pages.VerPublModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Test_Razor.Pages.VerPublModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Test_Razor.Pages.VerPublModel>)PageContext?.ViewData;
        public Test_Razor.Pages.VerPublModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591