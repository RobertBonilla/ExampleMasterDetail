#pragma checksum "C:\Users\crobe\Documents\GIT\ExampleMasterDetail\App\WebApp\WebApp.Frontend\Views\Lista\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "324a244b540847e23fa6268718c6fa07e7c28f8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lista_Detail), @"mvc.1.0.view", @"/Views/Lista/Detail.cshtml")]
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
#line 1 "C:\Users\crobe\Documents\GIT\ExampleMasterDetail\App\WebApp\WebApp.Frontend\Views\_ViewImports.cshtml"
using WebApp.Frontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\crobe\Documents\GIT\ExampleMasterDetail\App\WebApp\WebApp.Frontend\Views\_ViewImports.cshtml"
using WebApp.Frontend.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"324a244b540847e23fa6268718c6fa07e7c28f8b", @"/Views/Lista/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18aed6b18315539ded8f7b717063c3026a3fd897", @"/Views/_ViewImports.cshtml")]
    public class Views_Lista_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#nullable restore
#line 1 "C:\Users\crobe\Documents\GIT\ExampleMasterDetail\App\WebApp\WebApp.Frontend\Views\Lista\Detail.cshtml"
  
    ViewData["Title"] = "Lista [Detalle]";
    WebApp.Frontend.Models.Dto.ListaItems data = (WebApp.Frontend.Models.Dto.ListaItems)ViewData["ListaModel"];
    WebApp.Frontend.Models.Domain.Lista dataLista = data.Lista;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Detalle de Lista</h1>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "324a244b540847e23fa6268718c6fa07e7c28f8b3812", async() => {
                WriteLiteral("\r\n        <div class=\"mb-3\">\r\n            <label for=\"fechaCreacion\" class=\"form-label\">Creaccion</label>\r\n            <label id=\"fechaCreacion\">");
#nullable restore
#line 14 "C:\Users\crobe\Documents\GIT\ExampleMasterDetail\App\WebApp\WebApp.Frontend\Views\Lista\Detail.cshtml"
                                 Write(dataLista.FechaCreacion);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n        </div>\r\n        <div class=\"mb-3\">\r\n            <label for=\"fechaUpdate\" class=\"form-label\">Modificacion</label>\r\n            <label id=\"fechaUpdate\">");
#nullable restore
#line 18 "C:\Users\crobe\Documents\GIT\ExampleMasterDetail\App\WebApp\WebApp.Frontend\Views\Lista\Detail.cshtml"
                               Write(dataLista.FechaUpdate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n        </div>\r\n        <div class=\"mb-3\">\r\n            <label for=\"descripcion\" class=\"form-label\">Descripcion</label>\r\n            <input type=\"text\" class=\"form-control\" id=\"descripcion\" aria-describedby=\"Descripcion\" readonly");
                BeginWriteAttribute("value", " value=\"", 930, "\"", 960, 1);
#nullable restore
#line 22 "C:\Users\crobe\Documents\GIT\ExampleMasterDetail\App\WebApp\WebApp.Frontend\Views\Lista\Detail.cshtml"
WriteAttributeValue("", 938, dataLista.Descripcion, 938, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n        <a class=\"btn btn-secondary\" href=\"/\">Regresar</a>\r\n    ");
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
<div>
    <table class=""table table-striped table-hover"">
        <thead>
            <tr>
                <th scope=""col"">Producto</th>
                <th scope=""col"">Precio Unitario</th>
                <th scope=""col"">Cantidad</th>
                <th scope=""col"">SubTotal</th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 39 "C:\Users\crobe\Documents\GIT\ExampleMasterDetail\App\WebApp\WebApp.Frontend\Views\Lista\Detail.cshtml"
             foreach (var ListaModel in data.Items)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 42 "C:\Users\crobe\Documents\GIT\ExampleMasterDetail\App\WebApp\WebApp.Frontend\Views\Lista\Detail.cshtml"
           Write(ListaModel.Producto.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 43 "C:\Users\crobe\Documents\GIT\ExampleMasterDetail\App\WebApp\WebApp.Frontend\Views\Lista\Detail.cshtml"
           Write(ListaModel.detLista.ValorUnitario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 44 "C:\Users\crobe\Documents\GIT\ExampleMasterDetail\App\WebApp\WebApp.Frontend\Views\Lista\Detail.cshtml"
           Write(ListaModel.detLista.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 45 "C:\Users\crobe\Documents\GIT\ExampleMasterDetail\App\WebApp\WebApp.Frontend\Views\Lista\Detail.cshtml"
           Write(ListaModel.detLista.SubTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <button type=\"button\" class=\"btn btn-danger\" data-toggle=\"modal\" data-target=\"#exampleModal\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1863, "\"", 1915, 3);
            WriteAttributeValue("", 1873, "Eliminar(", 1873, 9, true);
#nullable restore
#line 47 "C:\Users\crobe\Documents\GIT\ExampleMasterDetail\App\WebApp\WebApp.Frontend\Views\Lista\Detail.cshtml"
WriteAttributeValue("", 1882, ListaModel.detLista.DetListaId, 1882, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1913, ");", 1913, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Eliminar</button>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 50 "C:\Users\crobe\Documents\GIT\ExampleMasterDetail\App\WebApp\WebApp.Frontend\Views\Lista\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">CONFIRMACION</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ESTA SEGURO QUE DESEA ELIMINAR EL REGISTRO?
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</button>
                <button type=""button"" class=""btn btn-primary"" onclick=""EliminarRegistro();"">Eliminar</button>
            </div>
        </div>
    </div>
</div>
<script>
    var ");
            WriteLiteral("idEliminar = 0;\r\n    function Eliminar(id) {\r\n        idEliminar = id;\r\n    }\r\n    function EliminarRegistro() {\r\n        var urlGetLista = \'");
#nullable restore
#line 79 "C:\Users\crobe\Documents\GIT\ExampleMasterDetail\App\WebApp\WebApp.Frontend\Views\Lista\Detail.cshtml"
                      Write(Url.Action("EliminarDetalle", "Lista"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        console.log(""Ejecutando"");
        $.ajax({
            url: urlGetLista,
            type: 'POST',
            data: { id: idEliminar},
            success: function (result) {
                console.log(result);
                alert(""Datos Eliminados con Exito"");
                location.reload();
            },
            error: function (httpResponse, e) {
                alert(""Error en el proceso"");
            },
            complete: function (result) {
            }
        });
    }
</script>");
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