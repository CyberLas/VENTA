#pragma checksum "C:\Users\CyberCup\Downloads\Parking_Lot\Parking_Lot\Views\Tarjeta\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2059b12f4d2cae68843a17d47115a4ea01e568fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tarjeta_Index), @"mvc.1.0.view", @"/Views/Tarjeta/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tarjeta/Index.cshtml", typeof(AspNetCore.Views_Tarjeta_Index))]
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
#line 1 "C:\Users\CyberCup\Downloads\Parking_Lot\Parking_Lot\Views\_ViewImports.cshtml"
using Parking_Lot;

#line default
#line hidden
#line 2 "C:\Users\CyberCup\Downloads\Parking_Lot\Parking_Lot\Views\_ViewImports.cshtml"
using Parking_Lot.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2059b12f4d2cae68843a17d47115a4ea01e568fc", @"/Views/Tarjeta/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba31bce4d6792040e1e3028d4de7935a6682c098", @"/Views/_ViewImports.cshtml")]
    public class Views_Tarjeta_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\CyberCup\Downloads\Parking_Lot\Parking_Lot\Views\Tarjeta\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 287, true);
            WriteLiteral(@"
<div style=""text-align: justify;"">
    <table>
        <thead>
            <tr>
                <th class=""col-md-4"">Nombre</th>
                <th class=""col-md-6"">Numero</th>
                <th class=""col-md-2"">CV2</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 16 "C:\Users\CyberCup\Downloads\Parking_Lot\Parking_Lot\Views\Tarjeta\Index.cshtml"
             foreach(var tarjeta in Model)
            {

#line default
#line hidden
            BeginContext(375, 63, true);
            WriteLiteral("                <tr>\r\n                    <td class=\"col-md-4\">");
            EndContext();
            BeginContext(439, 14, false);
#line 19 "C:\Users\CyberCup\Downloads\Parking_Lot\Parking_Lot\Views\Tarjeta\Index.cshtml"
                                    Write(tarjeta.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(453, 48, true);
            WriteLiteral("</td>\r\n                    <td class=\"col-md-6\">");
            EndContext();
            BeginContext(502, 14, false);
#line 20 "C:\Users\CyberCup\Downloads\Parking_Lot\Parking_Lot\Views\Tarjeta\Index.cshtml"
                                    Write(tarjeta.Numero);

#line default
#line hidden
            EndContext();
            BeginContext(516, 48, true);
            WriteLiteral("</td>\r\n                    <td class=\"col-md-2\">");
            EndContext();
            BeginContext(565, 11, false);
#line 21 "C:\Users\CyberCup\Downloads\Parking_Lot\Parking_Lot\Views\Tarjeta\Index.cshtml"
                                    Write(tarjeta.CV2);

#line default
#line hidden
            EndContext();
            BeginContext(576, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 23 "C:\Users\CyberCup\Downloads\Parking_Lot\Parking_Lot\Views\Tarjeta\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(621, 92, true);
            WriteLiteral("        </tbody>\r\n        <tr>\r\n            <td></td>\r\n        </tr>\r\n    </table>\r\n</div>\r\n");
            EndContext();
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