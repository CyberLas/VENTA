#pragma checksum "C:\Users\CyberCup\source\repos\Parking_Lot\Parking_Lot\Views\Servicios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca598f40fd15664fde8d2cc7a738704fc427eed7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Servicios_Index), @"mvc.1.0.view", @"/Views/Servicios/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Servicios/Index.cshtml", typeof(AspNetCore.Views_Servicios_Index))]
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
#line 1 "C:\Users\CyberCup\source\repos\Parking_Lot\Parking_Lot\Views\_ViewImports.cshtml"
using Parking_Lot;

#line default
#line hidden
#line 2 "C:\Users\CyberCup\source\repos\Parking_Lot\Parking_Lot\Views\_ViewImports.cshtml"
using Parking_Lot.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca598f40fd15664fde8d2cc7a738704fc427eed7", @"/Views/Servicios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba31bce4d6792040e1e3028d4de7935a6682c098", @"/Views/_ViewImports.cshtml")]
    public class Views_Servicios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Clase5.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 1 "C:\Users\CyberCup\source\repos\Parking_Lot\Parking_Lot\Views\Servicios\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(24, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(28, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cd46be4e7b6447f680eaceac81478b30", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(89, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(94, 2102, true);
            WriteLiteral(@"

<link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">


<section class=""services pt-60 pb-60"" id=""services"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xl-12"">
                <div class=""section-title text-center mb-60"">
                    <p>Estacionamientos en cada Departamento del Perú</p>
                    <h4>Parking Lot</h4>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-4 col-sm-12"">
                <div class=""single_service service_right"">
                    <h4>Rapido y Seguro</h4>
                    <p>Debido a que ofrece mayor estabilidad</p>
                </div>
                <div class=""single_service service_right"">
                    <h4>Rapido y Seguro</h4>
                    <p>Debido a que ofrece mayor estabilidad</p>
                </div>
                <div class=""single_service servic");
            WriteLiteral(@"e_right"">
                    <h4>Rapido y Seguro</h4>
                    <p>Debido a que ofrece mayor estabilidad</p>
                </div>
            </div>
            <div class=""col-md-4 col-sm-12 text-center"">
                <div class=""single_mid"">
                    <img src=""https://i.pinimg.com/originals/7f/6c/dc/7f6cdce4c15b2d1548b618ce5573bfd3.png"" alt="""">
                </div>
            </div>
            <div class=""col-md-4 col-sm-12"">
                <div class=""single_service"">
                    <h4>Rapido y Seguro</h4>
                    <p>Debido a que ofrece mayor estabilidad</p>
                </div>
                <div class=""single_service"">
                    <h4>Rapido y Seguro</h4>
                    <p>Debido a que ofrece mayor estabilidad</p>
                </div>
                <div class=""single_service"">
                    <h4>Rapido y Seguro</h4>
                    <p>Debido a que ofrece mayor estabilidad</p>
                </div>
    ");
            WriteLiteral("        </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
