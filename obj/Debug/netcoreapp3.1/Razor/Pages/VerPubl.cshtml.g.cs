#pragma checksum "C:\Users\PIPEX\source\repos\RobertoVerdugo\Sirac\Pages\VerPubl.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2522910e3f67af3c828d94ebf0a74392e6eae312"
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
#line 1 "C:\Users\PIPEX\source\repos\RobertoVerdugo\Sirac\Pages\_ViewImports.cshtml"
using Test_Razor;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2522910e3f67af3c828d94ebf0a74392e6eae312", @"/Pages/VerPubl.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dc9fa8977314e88b30768fc80a353b372227e35", @"/Pages/_ViewImports.cshtml")]
    public class Pages_VerPubl : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\PIPEX\source\repos\RobertoVerdugo\Sirac\Pages\VerPubl.cshtml"
  
    ViewData["Title"] = Model.Publicacion.nombre;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
    <div class=""row"">
        <div class=""col-md-6 col-md-offset-3"">
            <hr />
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
#line 18 "C:\Users\PIPEX\source\repos\RobertoVerdugo\Sirac\Pages\VerPubl.cshtml"
                   Write(Model.Publicacion.fecha.ToString("dd MMMM, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 531, "\"", 567, 2);
            WriteAttributeValue("", 537, "img/", 537, 4, true);
#nullable restore
#line 19 "C:\Users\PIPEX\source\repos\RobertoVerdugo\Sirac\Pages\VerPubl.cshtml"
WriteAttributeValue("", 541, Model.Publicacion.rutaimg, 541, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-responsive\" />\r\n                    <h2 class=\"text-center\">");
#nullable restore
#line 20 "C:\Users\PIPEX\source\repos\RobertoVerdugo\Sirac\Pages\VerPubl.cshtml"
                                       Write(Model.Publicacion.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n                    <hr />\r\n                    <p>\r\n                        ");
#nullable restore
#line 24 "C:\Users\PIPEX\source\repos\RobertoVerdugo\Sirac\Pages\VerPubl.cshtml"
                   Write(Model.Publicacion.descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>

                    <h3>Detalles físicos</h3>
                    <div class=""row"">
                        <div class=""col-md-3"">
                            <p><b>Especie: </b></p>
                        </div>
                        <div class=""col-md-3"">
                            <p>");
#nullable restore
#line 33 "C:\Users\PIPEX\source\repos\RobertoVerdugo\Sirac\Pages\VerPubl.cshtml"
                          Write(Model.Publicacion.especie);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"col-md-3\">\r\n                            <p><b>Raza: </b></p>\r\n                        </div>\r\n                        <div class=\"col-md-3\">\r\n                            <p>");
#nullable restore
#line 39 "C:\Users\PIPEX\source\repos\RobertoVerdugo\Sirac\Pages\VerPubl.cshtml"
                          Write(Model.Publicacion.raza);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-3"">
                            <p><b>Género: </b></p>
                        </div>
                        <div class=""col-md-3"">
                            <p>");
#nullable restore
#line 47 "C:\Users\PIPEX\source\repos\RobertoVerdugo\Sirac\Pages\VerPubl.cshtml"
                          Write(Model.Publicacion.genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"col-md-3\">\r\n                            <p><b>Edad: </b></p>\r\n                        </div>\r\n                        <div class=\"col-md-3\">\r\n                            <p>");
#nullable restore
#line 53 "C:\Users\PIPEX\source\repos\RobertoVerdugo\Sirac\Pages\VerPubl.cshtml"
                          Write(Model.Publicacion.edad);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>

                    </div>
                    <div class=""row"">
                        <div class=""col-md-3"">
                            <p><b>Tipo de pelaje: </b></p>
                        </div>
                        <div class=""col-md-3"">
                            <p>");
#nullable restore
#line 62 "C:\Users\PIPEX\source\repos\RobertoVerdugo\Sirac\Pages\VerPubl.cshtml"
                          Write(Model.Publicacion.pelaje);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                        <div class=""col-md-3"">
                            <p><b>Color de pelaje: </b></p>
                        </div>
                        <div class=""col-md-3"">
                            <p>");
#nullable restore
#line 68 "C:\Users\PIPEX\source\repos\RobertoVerdugo\Sirac\Pages\VerPubl.cshtml"
                          Write(Model.Publicacion.color);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                    </div>
                    <div class=""row"">

                        <div class=""col-md-3"">
                            <p><b>Tamaño: </b></p>
                        </div>
                        <div class=""col-md-3"">
                            <p>");
#nullable restore
#line 77 "C:\Users\PIPEX\source\repos\RobertoVerdugo\Sirac\Pages\VerPubl.cshtml"
                          Write(Model.Publicacion.tamano);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                    </div>

                    <h3>Detalles de situación</h3>
                    <div class=""row"">
                        <div class=""col-md-2"">
                            <p><b>Ubicación: </b></p>
                        </div>
                        <div class=""col-md-10"">
                            <p>");
#nullable restore
#line 87 "C:\Users\PIPEX\source\repos\RobertoVerdugo\Sirac\Pages\VerPubl.cshtml"
                          Write(Model.Publicacion.ubicacion);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-2"">
                            <p><b>Estado: </b></p>
                        </div>
                        <div class=""col-md-10"">
                            <p>");
#nullable restore
#line 95 "C:\Users\PIPEX\source\repos\RobertoVerdugo\Sirac\Pages\VerPubl.cshtml"
                          Write(Model.Publicacion.estado);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                    </div>


                    <div class=""row"" style=""padding-top:20px; margin: 0px; border: 0px;"">
                        <div class=""col-md-6"">
                            <p><small>Por:<br /> ");
#nullable restore
#line 102 "C:\Users\PIPEX\source\repos\RobertoVerdugo\Sirac\Pages\VerPubl.cshtml"
                                            Write(Model.Usuario.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 102 "C:\Users\PIPEX\source\repos\RobertoVerdugo\Sirac\Pages\VerPubl.cshtml"
                                                                  Write(Model.Usuario.apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /> ");
#nullable restore
#line 102 "C:\Users\PIPEX\source\repos\RobertoVerdugo\Sirac\Pages\VerPubl.cshtml"
                                                                                                 Write(Model.Usuario.email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 102 "C:\Users\PIPEX\source\repos\RobertoVerdugo\Sirac\Pages\VerPubl.cshtml"
                                                                                                                            if (Model.Usuario.telefono != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /> ");
#nullable restore
#line 102 "C:\Users\PIPEX\source\repos\RobertoVerdugo\Sirac\Pages\VerPubl.cshtml"
                                                                                                                                                                   Write(Model.Usuario.telefono);

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Users\PIPEX\source\repos\RobertoVerdugo\Sirac\Pages\VerPubl.cshtml"
                                                                                                                                                                                               }

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n");
#nullable restore
#line 105 "C:\Users\PIPEX\source\repos\RobertoVerdugo\Sirac\Pages\VerPubl.cshtml"
                             if(@Model.Publicacion.actualizacion!=null){

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"text-right\"><small>Actualizado el ");
#nullable restore
#line 105 "C:\Users\PIPEX\source\repos\RobertoVerdugo\Sirac\Pages\VerPubl.cshtml"
                                                                                                               Write(Model.Publicacion.actualizacion.ToString("dd MMMM, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>");
#nullable restore
#line 105 "C:\Users\PIPEX\source\repos\RobertoVerdugo\Sirac\Pages\VerPubl.cshtml"
                                                                                                                                                                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n            <p class=\"text-right\"><a href=\"#\">Reportar</a></p>\r\n        </div>\r\n    </div>\r\n</div>");
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
