#pragma checksum "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Categoria\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "491ae89c913caac5d84dd1dc03fe3e18bf69baf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categoria_Index), @"mvc.1.0.view", @"/Views/Categoria/Index.cshtml")]
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
#line 1 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\_ViewImports.cshtml"
using ECCE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\_ViewImports.cshtml"
using ECCE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"491ae89c913caac5d84dd1dc03fe3e18bf69baf1", @"/Views/Categoria/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8d523cb7d045fc283b7b459a0bcbbd2d4e32902", @"/Views/_ViewImports.cshtml")]
    public class Views_Categoria_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<tb_categoria>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Categoria\Index.cshtml"
    ViewData["Title"] = "Home Page";

    Layout = "_Layout_dashboard";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div >
    <table class=""table"">
        <tr>
            <th><h4>Categorias</h4></th>
            <th></th>
            <th></th>
            <th class=""text-sm-right""><button class=""btn btn-primary"" type=""button"" onclick=""window.location.href ='/categoria/cadastrocategoria'"">Nova Categoria</button>
            <th>
        </tr>
    </table>
");
#nullable restore
#line 19 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Categoria\Index.cshtml"
     if (Model.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table"">

            <thead>
                <tr>
                    <th>Código</th>
                    <th>Nome</th>
                    <th></th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 32 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Categoria\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 35 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Categoria\Index.cshtml"
                       Write(item.CodigoCategoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 36 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Categoria\Index.cshtml"
                       Write(item.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><button type=\"button\" class=\"btn btn-warning\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1054, "\"", 1168, 5);
            WriteAttributeValue("", 1064, "window.location.href=\'/categoria/editar?CodigoCategoria=", 1064, 56, true);
#nullable restore
#line 37 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Categoria\Index.cshtml"
WriteAttributeValue("", 1120, item.CodigoCategoria, 1120, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1141, "&Descricao=", 1141, 11, true);
#nullable restore
#line 37 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Categoria\Index.cshtml"
WriteAttributeValue("", 1152, item.Descricao, 1152, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1167, "\'", 1167, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Editar</button></td>\r\n                        <td><button type=\"button\" class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1264, "\"", 1353, 3);
            WriteAttributeValue("", 1274, "window.location.href=\'/categoria/excluir?CodigoCategoria=", 1274, 57, true);
#nullable restore
#line 38 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Categoria\Index.cshtml"
WriteAttributeValue("", 1331, item.CodigoCategoria, 1331, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1352, "\'", 1352, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Excluir</button></td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 41 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Categoria\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 44 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Categoria\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-primary\" role=\"alert\">\r\n            Sem Registros!\r\n        </div>\r\n");
#nullable restore
#line 50 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Categoria\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<tb_categoria>> Html { get; private set; }
    }
}
#pragma warning restore 1591
