#pragma checksum "C:\Users\Caro\Desktop\EQUIPO 6 GRUPO 28\proyecto\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Admin\AdminVeterinario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "027bd1fadb4acbeb707c163c6c9271f33ec3dd67"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"027bd1fadb4acbeb707c163c6c9271f33ec3dd67", @"/Pages/Admin/AdminVeterinario.cshtml")]
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
            WriteLiteral(@"
<link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js""></script>
<script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>


<div class=""wrapper fadeInDown"">
  <div id=""formContent"">
    <!-- Tabs Titles -->

    <!-- Login Form -->
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "027bd1fadb4acbeb707c163c6c9271f33ec3dd673661", async() => {
                WriteLiteral(@"
      <input type=""text"" id=""login"" class=""fadeIn second"" name=""login"" placeholder=""login"">
      <input type=""text"" id=""password"" class=""fadeIn third"" name=""login"" placeholder=""password"">
      <input type=""submit"" class=""fadeIn fourth"" value=""Log In"">
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
            WriteLiteral("\r\n\r\n    <!-- Remind Passowrd -->\r\n    <div id=\"formFooter\">\r\n      <a class=\"underlineHover\" href=\"#\">Forgot Password?</a>\r\n    </div>\r\n\r\n  </div>\r\n</div>");
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
