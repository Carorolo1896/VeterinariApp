#pragma checksum "C:\Users\Caro\Desktop\EQUIPO 6 GRUPO 28\proyecto\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Admin\AdminVeterinario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc80576b11f1e624d32193d429de806acc1aee24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Veterinaria.App.Presentacion.Pages.Admin.Pages_Admin_AdminVeterinario), @"mvc.1.0.razor-page", @"/Pages/Admin/AdminVeterinario.cshtml")]
namespace Veterinaria.App.Presentacion.Pages.Admin
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
#line 1 "C:\Users\Caro\Desktop\EQUIPO 6 GRUPO 28\proyecto\Veterinaria.App\Veterinaria.App.Presentacion\Pages\_ViewImports.cshtml"
using Veterinaria.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc80576b11f1e624d32193d429de806acc1aee24", @"/Pages/Admin/AdminVeterinario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b4210c761a838aa2861a38133730205e80bc607", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_AdminVeterinario : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1 style= \"margin: 36px 10px;color: 51,0,102; font size: 0px;\" ");
#nullable restore
#line 6 "C:\Users\Caro\Desktop\EQUIPO 6 GRUPO 28\proyecto\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Admin\AdminVeterinario.cshtml"
                                                           Write(ViewData["TITLE PAGE"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>



<div class=""accordion"" id=""accordionExample"">
    <div class=""card"">
        <div class=""card-header"" id=""headingOne"">
            <h2 class=""mb-0"">
                <button class=""btn btn-link btn-block text-left"" type=""button"" data-toggle=""collapse""
                    data-target=""#collapseCrudVeterinario"" aria-expanded=""true"" aria-controls=""collapseCrudVeterinario"">
                    Crud Veterinario
                </button>
            </h2>
        </div>

        <div id=""collapseCrudVeterinario"" class=""collapse "" aria-labelledby=""headingOne""
            data-parent=""#accordionExample"">
            <div class=""card-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc80576b11f1e624d32193d429de806acc1aee244355", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""id-Nombre del Veterinario: "">Nombre del Veterinario: </label>
                        <input type=""email"" class=""form-control"" id=""id-Nombre del Veterinario""
                            aria-describedby=""emailHelp"">
                        <small id=""emailHelp"" class=""form-text text-muted"">Por favor ingrese su nombre en este
                            campo.</small>

                    </div>

                    <div class=""form-group"">
                        <label for=""id-Telefono del Veterinario: "">Teléfono: </label>
                        <input type=""tel"" class=""form-control"" id=""id-Telefono del Veterinario:""
                            aria-describedby=""emailHelp"">
                        <small id=""emailHelp"" class=""form-text text-muted"">Por favor ingrese nu numero de telefono en
                            este campo.</small>
                    </div>

                    <div class=""form-group"">");
                WriteLiteral(@"
                        <label for=""id-Edad del Veterinario: "">Edad: </label>
                        <input type=""number"" class=""form-control"" id=""id-La edad del Veterinario es :""
                            aria-describedby=""emailHelp"">
                        <small id=""emailHelp"" class=""form-text text-muted"">Por favor ingrese su edad en este
                            campo.</small>
                    </div>
                    <div class=""form-group"">
                        <label for=""id-Dirección del veterinario: "">Dirección: </label>
                        <input type=""email"" class=""form-control"" id=""id-Dirección del Vterinario""
                            aria-describedby=""emailHelp"">
                        <small id=""emailHelp"" class=""form-text text-muted"">Por favor ingrese su dirección en este
                            campo.</small>
                    </div>
                    <div class=""form-group"">
                        <label for=""id-Correo ElectonicoVeterinario: "">E-");
                WriteLiteral(@"mail : </label>
                        <input type=""email"" class=""form-control"" id=""id-Correo ElectonicoVeterinario""
                            aria-describedby=""emailHelp"">
                        <small id=""emailHelp"" class=""form-text text-muted"">Por favor ingrese su E-mail en este
                            campo.</small>
                    </div>
                    <div class=""form-group"">
                        <label for=""id-Contrasenia Veterinario: "">Contrasenia : </label>
                        <input type=""email"" class=""form-control"" id=""id-Contrasenia Veterinario""
                            aria-describedby=""emailHelp"">
                        <small id=""emailHelp"" class=""form-text text-muted"">Por favor ingrese su contrasenia en este
                            campo.</small>
                    </div>
                    <div class=""form-group"">
                        <label for=""id-Fecha Registro: "">FechaRegistro: </label>
                        <input type=""DateTime"" clas");
                WriteLiteral(@"s=""form-control"" id=""id-Fecha registro"" aria-describedby=""emailHelp"">
                        <small id=""emailHelp"" class=""form-text text-muted"">Por favor ingrese la fecha en este
                            campo.</small>
                    </div>
                    <div class=""form-group"">
                        <label for=""id-Especialización del veterinario: "">Especialización: </label>
                        <input type=""Email"" class=""form-control"" id=""id-Especializacion del veterinario""
                            aria-describedby=""emailHelp"">
                        <small id=""emailHelp"" class=""form-text text-muted"">Por favor ingrese la especialización en este
                            campo.</small>
                    </div>
                    <div class=""form-group"">
                        <label for=""id-Targeta Profesional: "">Tarjeta Profesional: </label>
                        <input type=""email"" class=""form-control"" id=""Trageta  Profesional"" aria-describedby=""emailHelp"">
    ");
                WriteLiteral(@"                    <small id=""emailHelp"" class=""form-text text-muted"">Por favor ingrese el codigo de la tergeta
                            profesional en este campo.</small>
                    </div>
                    <button   type=""submit"" class=""btn btn-primary"">Agragar</button>
                    <button  type=""submit"" class=""btn btn-primary"">Editar</button>
                    <button type=""submit"" class=""btn btn-primary"">Mostrar</button>
                    <button type=""submit"" class=""btn btn-primary"">Eliminar</button>
                    
                    




                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>
    <div class=""accordion"" id=""accordionExample"">
        <div class=""card"">
            <div class=""card-header"" id=""headingTwo"">
                <h2 class=""mb-0"">
                    <button class=""btn btn-link btn-block text-left"" type=""button"" data-toggle=""collapse""
                        data-target=""#collapseLista_Veterinario"" aria-expanded=""true""
                        aria-controls=""collapseLista_Veterinarios"">
                        Lista de Veterinario
                    </button>
                </h2>
            </div>

            <div id=""collapseLista_Veterinarios"" class=""collapse "" aria-labelledby=""headingTwo""
                data-parent=""#accordionExample"">
                <div class=""card-body"">
                    <ul class=""list-group"">
");
#nullable restore
#line 119 "C:\Users\Caro\Desktop\EQUIPO 6 GRUPO 28\proyecto\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Admin\AdminVeterinario.cshtml"
                         for (int i = 1; i < 10; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                          <li class=\"list-group-item\">Veterinario ");
#nullable restore
#line 121 "C:\Users\Caro\Desktop\EQUIPO 6 GRUPO 28\proyecto\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Admin\AdminVeterinario.cshtml"
                                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>   \r\n");
#nullable restore
#line 122 "C:\Users\Caro\Desktop\EQUIPO 6 GRUPO 28\proyecto\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Admin\AdminVeterinario.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                       \r\n                        \r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Veterinaria.App.Presentacion.AdminVeterinarioModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Presentacion.AdminVeterinarioModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Presentacion.AdminVeterinarioModel>)PageContext?.ViewData;
        public Veterinaria.App.Presentacion.AdminVeterinarioModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
