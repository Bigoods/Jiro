#pragma checksum "C:\Users\filip\Documents\UTAD\Lab\Prato_do_Dia\Prato_do_Dia\LabProject\LabProject\Views\Restaurantes\VerRestaurante.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ba09290f4b03fa484e02185330c0e13a4ebeacc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurantes_VerRestaurante), @"mvc.1.0.view", @"/Views/Restaurantes/VerRestaurante.cshtml")]
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
#line 1 "C:\Users\filip\Documents\UTAD\Lab\Prato_do_Dia\Prato_do_Dia\LabProject\LabProject\Views\_ViewImports.cshtml"
using LabProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\filip\Documents\UTAD\Lab\Prato_do_Dia\Prato_do_Dia\LabProject\LabProject\Views\_ViewImports.cshtml"
using LabProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ba09290f4b03fa484e02185330c0e13a4ebeacc", @"/Views/Restaurantes/VerRestaurante.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1bc2a40b8065edfd6c86eb75dcc7227492c3940", @"/Views/_ViewImports.cshtml")]
    public class Views_Restaurantes_VerRestaurante : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LabProject.Models.RestaurantePratosPertence>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Grid_style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2ba09290f4b03fa484e02185330c0e13a4ebeacc3999", async() => {
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
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n<div class=\"VerGridRectangle\">\r\n    <div class=\"VerRestauranteBanner\"");
            BeginWriteAttribute("style", " style=\'", 1899, "\'", 2019, 3);
            WriteAttributeValue("", 1907, "background-image:url(\"../../Images/Utilizadores/", 1907, 48, true);
#nullable restore
#line 51 "C:\Users\filip\Documents\UTAD\Lab\Prato_do_Dia\Prato_do_Dia\LabProject\LabProject\Views\Restaurantes\VerRestaurante.cshtml"
WriteAttributeValue("", 1955, Html.DisplayFor(model => model.Restaurante.Utilizador.Imagem), 1955, 62, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2017, "\")", 2017, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n    <div class=\"VerRestauranteNome\">");
#nullable restore
#line 52 "C:\Users\filip\Documents\UTAD\Lab\Prato_do_Dia\Prato_do_Dia\LabProject\LabProject\Views\Restaurantes\VerRestaurante.cshtml"
                               Write(Html.DisplayFor(model => model.Restaurante.Utilizador.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n</div>\r\n\r\n<div class=\"VerInformacoes\">\r\n    <div class=\"VerInformacoesDescricao\">\r\n        <p>\r\n            ");
#nullable restore
#line 59 "C:\Users\filip\Documents\UTAD\Lab\Prato_do_Dia\Prato_do_Dia\LabProject\LabProject\Views\Restaurantes\VerRestaurante.cshtml"
       Write(Html.DisplayFor(model => model.Restaurante.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        <p>\r\n            ");
#nullable restore
#line 62 "C:\Users\filip\Documents\UTAD\Lab\Prato_do_Dia\Prato_do_Dia\LabProject\LabProject\Views\Restaurantes\VerRestaurante.cshtml"
       Write(Html.DisplayFor(model => model.Restaurante.Utilizador.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        <p>\r\n            Exceto ");
#nullable restore
#line 65 "C:\Users\filip\Documents\UTAD\Lab\Prato_do_Dia\Prato_do_Dia\LabProject\LabProject\Views\Restaurantes\VerRestaurante.cshtml"
              Write(Html.DisplayFor(model => model.Restaurante.DiaDescanso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        <p style=\" margin-top: 2px; \">\r\n            ");
#nullable restore
#line 68 "C:\Users\filip\Documents\UTAD\Lab\Prato_do_Dia\Prato_do_Dia\LabProject\LabProject\Views\Restaurantes\VerRestaurante.cshtml"
       Write(Html.DisplayFor(model => model.Restaurante.HoraAbertura));

#line default
#line hidden
#nullable disable
            WriteLiteral("h - ");
#nullable restore
#line 68 "C:\Users\filip\Documents\UTAD\Lab\Prato_do_Dia\Prato_do_Dia\LabProject\LabProject\Views\Restaurantes\VerRestaurante.cshtml"
                                                                    Write(Html.DisplayFor(model => model.Restaurante.HoraFecho));

#line default
#line hidden
#nullable disable
            WriteLiteral("h\r\n        </p>\r\n        <p>\r\n            Exceto ");
#nullable restore
#line 71 "C:\Users\filip\Documents\UTAD\Lab\Prato_do_Dia\Prato_do_Dia\LabProject\LabProject\Views\Restaurantes\VerRestaurante.cshtml"
              Write(Html.DisplayFor(model => model.Restaurante.Morada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n\r\n    </div>\r\n    <div class=\"VerInformacoesMapa\" style=\"background-color:lightgreen\"></div>\r\n\r\n</div>\r\n\r\n\r\n\r\n<div class=\"verGridContainer\">\r\n");
#nullable restore
#line 82 "C:\Users\filip\Documents\UTAD\Lab\Prato_do_Dia\Prato_do_Dia\LabProject\LabProject\Views\Restaurantes\VerRestaurante.cshtml"
     foreach (var item in Model.Pratos)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"VerGridSquare\"");
            BeginWriteAttribute("onClick", " onClick=\"", 3021, "\"", 3082, 3);
            WriteAttributeValue("", 3031, "reply_click(", 3031, 12, true);
#nullable restore
#line 84 "C:\Users\filip\Documents\UTAD\Lab\Prato_do_Dia\Prato_do_Dia\LabProject\LabProject\Views\Restaurantes\VerRestaurante.cshtml"
WriteAttributeValue("", 3043, Html.DisplayFor(modelItem => item.Id), 3043, 38, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3081, ")", 3081, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"VerGridSquareNome\">");
#nullable restore
#line 85 "C:\Users\filip\Documents\UTAD\Lab\Prato_do_Dia\Prato_do_Dia\LabProject\LabProject\Views\Restaurantes\VerRestaurante.cshtml"
                                   Write((item.Nome.Length <= 13) ? item.Nome : item.Nome.Substring(0, 13) + "...");

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"VerGridSquareCentral\">\r\n            <div class=\"VerGridSquareCentralTexto\">\r\n                <p>Tipo: ");
#nullable restore
#line 88 "C:\Users\filip\Documents\UTAD\Lab\Prato_do_Dia\Prato_do_Dia\LabProject\LabProject\Views\Restaurantes\VerRestaurante.cshtml"
                     Write(item.TipoPrato.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Preço: ");
#nullable restore
#line 89 "C:\Users\filip\Documents\UTAD\Lab\Prato_do_Dia\Prato_do_Dia\LabProject\LabProject\Views\Restaurantes\VerRestaurante.cshtml"
                      Write((item.Preco).ToString("#.00") + " €");

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"VerGridSquareCentralFoto\"");
            BeginWriteAttribute("style", " style=\'", 3499, "\'", 3561, 3);
            WriteAttributeValue("", 3507, "background-image:url(../../Images/Pratos/", 3507, 41, true);
#nullable restore
#line 91 "C:\Users\filip\Documents\UTAD\Lab\Prato_do_Dia\Prato_do_Dia\LabProject\LabProject\Views\Restaurantes\VerRestaurante.cshtml"
WriteAttributeValue("", 3548, item.Foto, 3548, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3560, ")", 3560, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n        </div>\r\n        <p class=\"VerGridSquareDesc\" >Descrição: ");
#nullable restore
#line 93 "C:\Users\filip\Documents\UTAD\Lab\Prato_do_Dia\Prato_do_Dia\LabProject\LabProject\Views\Restaurantes\VerRestaurante.cshtml"
                                             Write(item.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral("\r\n\r\n    </div>\r\n");
#nullable restore
#line 99 "C:\Users\filip\Documents\UTAD\Lab\Prato_do_Dia\Prato_do_Dia\LabProject\LabProject\Views\Restaurantes\VerRestaurante.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LabProject.Models.RestaurantePratosPertence> Html { get; private set; }
    }
}
#pragma warning restore 1591