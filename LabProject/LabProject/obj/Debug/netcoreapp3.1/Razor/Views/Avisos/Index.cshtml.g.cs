#pragma checksum "D:\Lab 3ºAno\Prato_do_Dia\LabProject\LabProject\Views\Avisos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bab1b17e50a336b640f6925f7fe56c1634e0932d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Avisos_Index), @"mvc.1.0.view", @"/Views/Avisos/Index.cshtml")]
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
#line 1 "D:\Lab 3ºAno\Prato_do_Dia\LabProject\LabProject\Views\_ViewImports.cshtml"
using LabProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Lab 3ºAno\Prato_do_Dia\LabProject\LabProject\Views\_ViewImports.cshtml"
using LabProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Lab 3ºAno\Prato_do_Dia\LabProject\LabProject\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bab1b17e50a336b640f6925f7fe56c1634e0932d", @"/Views/Avisos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da0c2a20cf237f40765043e4193852e67d1571cf", @"/Views/_ViewImports.cshtml")]
    public class Views_Avisos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LabProject.Models.Aviso>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table\">\r\n    \r\n    <tbody>\r\n");
#nullable restore
#line 6 "D:\Lab 3ºAno\Prato_do_Dia\LabProject\LabProject\Views\Avisos\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 9 "D:\Lab 3ºAno\Prato_do_Dia\LabProject\LabProject\Views\Avisos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Foto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 12 "D:\Lab 3ºAno\Prato_do_Dia\LabProject\LabProject\Views\Avisos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 15 "D:\Lab 3ºAno\Prato_do_Dia\LabProject\LabProject\Views\Avisos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 18 "D:\Lab 3ºAno\Prato_do_Dia\LabProject\LabProject\Views\Avisos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Data));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 21 "D:\Lab 3ºAno\Prato_do_Dia\LabProject\LabProject\Views\Avisos\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LabProject.Models.Aviso>> Html { get; private set; }
    }
}
#pragma warning restore 1591
