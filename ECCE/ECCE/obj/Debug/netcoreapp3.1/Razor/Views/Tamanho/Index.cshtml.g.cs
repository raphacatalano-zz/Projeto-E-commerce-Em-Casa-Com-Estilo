#pragma checksum "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Tamanho\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3342f16251bc99e2614280ed320a457f362ff3f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tamanho_Index), @"mvc.1.0.view", @"/Views/Tamanho/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3342f16251bc99e2614280ed320a457f362ff3f4", @"/Views/Tamanho/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8d523cb7d045fc283b7b459a0bcbbd2d4e32902", @"/Views/_ViewImports.cshtml")]
    public class Views_Tamanho_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<tb_tamanho>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Tamanho\Index.cshtml"
    ViewData["Title"] = "Tamanhos";

    Layout = "_Layout_dashboard";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div >
    <table class=""table"">
        <tr>
            <th><h4>Tamanhos</h4></th>
            <th></th>
            <th></th>
            <th class=""text-sm-right""><button class=""btn btn-primary"" type=""button"" onclick=""window.location.href ='/tamanho/cadastrotamanho'"">Novo Tamanho</button>
            <th>
        </tr>
    </table>
");
#nullable restore
#line 19 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Tamanho\Index.cshtml"
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
#line 32 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Tamanho\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 35 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Tamanho\Index.cshtml"
                       Write(item.CodigoTamanho);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 36 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Tamanho\Index.cshtml"
                       Write(item.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><button type=\"button\" class=\"btn btn-warning\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1041, "\"", 1145, 5);
            WriteAttributeValue("", 1051, "window.location.href=\'/tamanho/editar?CodigoCor=", 1051, 48, true);
#nullable restore
#line 37 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Tamanho\Index.cshtml"
WriteAttributeValue("", 1099, item.CodigoTamanho, 1099, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1118, "&Descricao=", 1118, 11, true);
#nullable restore
#line 37 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Tamanho\Index.cshtml"
WriteAttributeValue("", 1129, item.Descricao, 1129, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1144, "\'", 1144, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Editar</button></td>\r\n                        <td><button type=\"button\" class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1241, "\"", 1320, 3);
            WriteAttributeValue("", 1251, "window.location.href=\'/tamanho/excluir?CodigoCor=", 1251, 49, true);
#nullable restore
#line 38 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Tamanho\Index.cshtml"
WriteAttributeValue("", 1300, item.CodigoTamanho, 1300, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1319, "\'", 1319, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Excluir</button></td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 41 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Tamanho\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 44 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Tamanho\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-primary\" role=\"alert\">\r\n            Sem Registros!\r\n        </div>\r\n");
#nullable restore
#line 50 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Tamanho\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<tb_tamanho>> Html { get; private set; }
    }
}
#pragma warning restore 1591