#pragma checksum "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Produto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df94524256f0d56be00458244632e037ceaac07f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Index), @"mvc.1.0.view", @"/Views/Produto/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df94524256f0d56be00458244632e037ceaac07f", @"/Views/Produto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8d523cb7d045fc283b7b459a0bcbbd2d4e32902", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProdutoModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Produto\Index.cshtml"
    ViewData["Title"] = "Home Page";

    Layout = "_Layout_dashboard";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th><h4>Produtos</h4></th>\r\n            <th></th>\r\n            <th></th>\r\n            <th class=\"text-sm-right\"><button class=\"btn btn-primary\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 335, "\"", 345, 0);
            EndWriteAttribute();
            WriteLiteral(@">Novo Produto</button></th>

        </tr>
    </table>
    <table class=""table"">
        <thead>
            <tr>
                <th>Código</th>
                <th>Nome</th>
                <th></th>
                <th></th>
            </tr>
            <tr>
                <th>2</th>
                <th>Elegante XX</th>
                <td><button class=""btn btn-primary"" type=""button""");
            BeginWriteAttribute("onclick", " onclick=\"", 754, "\"", 764, 0);
            EndWriteAttribute();
            WriteLiteral(">Visualizar</button></td>\r\n                <td><button class=\"btn btn-primary\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 857, "\"", 867, 0);
            EndWriteAttribute();
            WriteLiteral(">Excluir</button></td>\r\n            </tr>\r\n        </thead>\r\n    </table>\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProdutoModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
