#pragma checksum "C:\Users\crobe\Documents\GIT\ExampleMasterDetail\App\WebApp\WebApp.Frontend\Views\Lista\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8070f1fe60aebc4d737cc5ce723c6ccbf73cd08d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lista_Index), @"mvc.1.0.view", @"/Views/Lista/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8070f1fe60aebc4d737cc5ce723c6ccbf73cd08d", @"/Views/Lista/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18aed6b18315539ded8f7b717063c3026a3fd897", @"/Views/_ViewImports.cshtml")]
    public class Views_Lista_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\crobe\Documents\GIT\ExampleMasterDetail\App\WebApp\WebApp.Frontend\Views\Lista\Index.cshtml"
  
    ViewData["Title"] = "Lista [Maestro]";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Lista</h1>
    <button type=""button"" class=""btn btn-primary"">Consultar</button>
</div>
<div>
    <table class=""table table-striped table-hover"">
        <thead>
            <tr>
                <th scope=""col"">Creacion</th>
                <th scope=""col"">Actualizacion</th>
                <th scope=""col"">Detalle</th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody>
            <tr class=""table-active"">
                <td>Celda 1</td>
                <td>Celda 2</td>
                <td>Celda 3</td>
                <td>
                    <a href=""/Lista/Edit"" class=""btn btn-info"">Editar</a>
                    <a href=""/Lista/Detail"" class=""btn btn-light"">Detalles</a>
                </td>
            </tr>
        </tbody>
    </table>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
