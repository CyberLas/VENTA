#pragma checksum "C:\Users\CyberCup\Downloads\Parking_Lot\Parking_Lot\Views\Estacionamiento\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d00e9dff3153584f4fa5b88f02a3ec3cb94f8e0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Estacionamiento_Index), @"mvc.1.0.view", @"/Views/Estacionamiento/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Estacionamiento/Index.cshtml", typeof(AspNetCore.Views_Estacionamiento_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d00e9dff3153584f4fa5b88f02a3ec3cb94f8e0f", @"/Views/Estacionamiento/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba31bce4d6792040e1e3028d4de7935a6682c098", @"/Views/_ViewImports.cshtml")]
    public class Views_Estacionamiento_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Estacionamiento/Pagar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Estacionamiento/reserva"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\CyberCup\Downloads\Parking_Lot\Parking_Lot\Views\Estacionamiento\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 536, true);
            WriteLiteral(@"
    <div>

        <!-- Nav tabs -->
        <ul class=""nav nav-tabs"" role=""tablist"">
            <li role=""presentation"" class=""active""><a href=""#estatab"" aria-controls=""home"" role=""tab"" data-toggle=""tab"">Estacionamientos</a></li>
            <li role=""presentation""><a href=""#nresertab"" aria-controls=""profile"" role=""tab"" data-toggle=""tab"">Reservar</a></li>
        </ul>

        <!-- Tab panes -->
        <div class=""tab-content"">
            <div role=""tabpanel"" class=""tab-pane active"" id=""estatab"">
                ");
            EndContext();
            BeginContext(565, 3198, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22661fa2d7b0469b9744b37fec8f423f", async() => {
                BeginContext(617, 464, true);
                WriteLiteral(@"
                    <table border=""1"">
                        <thead>
                            <tr>
                                <th>Tipo de Vehiculo</th>
                                <th>Ubicacion</th>
                                <th>Tarjeta</th>
                                <th>Horas</th>
                                <th> </th>
                            </tr>
                        </thead>
                        <tbody>
");
                EndContext();
#line 29 "C:\Users\CyberCup\Downloads\Parking_Lot\Parking_Lot\Views\Estacionamiento\Index.cshtml"
                             foreach (var estacionamiento in Model)
                            {

#line default
#line hidden
                BeginContext(1181, 140, true);
                WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1321, "\"", 1348, 1);
#line 33 "C:\Users\CyberCup\Downloads\Parking_Lot\Parking_Lot\Views\Estacionamiento\Index.cshtml"
WriteAttributeValue("", 1329, estacionamiento.Id, 1329, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1349, 97, true);
                WriteLiteral(" name=\"IdEstacionamiento\" readonly />\r\n                                        <input type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1446, "\"", 1483, 1);
#line 34 "C:\Users\CyberCup\Downloads\Parking_Lot\Parking_Lot\Views\Estacionamiento\Index.cshtml"
WriteAttributeValue("", 1454, estacionamiento.TipoVehiculo, 1454, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1484, 157, true);
                WriteLiteral(" readonly />\r\n                                    </td>\r\n                                    <td>\r\n                                        <input type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1641, "\"", 1701, 3);
#line 37 "C:\Users\CyberCup\Downloads\Parking_Lot\Parking_Lot\Views\Estacionamiento\Index.cshtml"
WriteAttributeValue("", 1649, estacionamiento.Latitud, 1649, 24, false);

#line default
#line hidden
                WriteAttributeValue(" ", 1673, ",", 1674, 2, true);
#line 37 "C:\Users\CyberCup\Downloads\Parking_Lot\Parking_Lot\Views\Estacionamiento\Index.cshtml"
WriteAttributeValue(" ", 1675, estacionamiento.Longitud, 1676, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1702, 268, true);
                WriteLiteral(@" readonly />
                                    </td>
                                    <td>
                                        <select name=""IdTarjeta"" class=""design"" id=""sel"" onclick=""PromptDemo2(this,event)"">
                                            ");
                EndContext();
                BeginContext(1970, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd5ff861fd1f44dc8e2bde46acad1362", async() => {
                    BeginContext(1988, 12, true);
                    WriteLiteral("-- Elegir --");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2009, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 42 "C:\Users\CyberCup\Downloads\Parking_Lot\Parking_Lot\Views\Estacionamiento\Index.cshtml"
                                             foreach (var tarjeta in ViewBag.Tarjeta)
                                            {

#line default
#line hidden
                BeginContext(2145, 48, true);
                WriteLiteral("                                                ");
                EndContext();
                BeginContext(2193, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "642b1a188ead4d8582cf4b8c37722c4a", async() => {
                    BeginContext(2222, 14, false);
#line 44 "C:\Users\CyberCup\Downloads\Parking_Lot\Parking_Lot\Views\Estacionamiento\Index.cshtml"
                                                                       Write(tarjeta.Nombre);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 44 "C:\Users\CyberCup\Downloads\Parking_Lot\Parking_Lot\Views\Estacionamiento\Index.cshtml"
                                                   WriteLiteral(tarjeta.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2245, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 45 "C:\Users\CyberCup\Downloads\Parking_Lot\Parking_Lot\Views\Estacionamiento\Index.cshtml"
                                            }

#line default
#line hidden
                BeginContext(2294, 287, true);
                WriteLiteral(@"                                        </select>
                                    </td>
                                    <td>
                                        <select name=""NHoras"" id=""car"" onclick=""PromptDemo1(this,event)"">
                                            ");
                EndContext();
                BeginContext(2581, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a56216677f84c02bf7004de4b196f3f", async() => {
                    BeginContext(2599, 12, true);
                    WriteLiteral("-- Elegir --");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2620, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 51 "C:\Users\CyberCup\Downloads\Parking_Lot\Parking_Lot\Views\Estacionamiento\Index.cshtml"
                                             for (var i = 1; i < 11; i++)
                                            {
                                                if (i == 1)
                                                {

#line default
#line hidden
                BeginContext(2856, 52, true);
                WriteLiteral("                                                    ");
                EndContext();
                BeginContext(2908, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3b8a68c92374654be64b0331f4aed91", async() => {
                    BeginContext(2928, 1, false);
#line 55 "C:\Users\CyberCup\Downloads\Parking_Lot\Parking_Lot\Views\Estacionamiento\Index.cshtml"
                                                                  Write(i);

#line default
#line hidden
                    EndContext();
                    BeginContext(2929, 5, true);
                    WriteLiteral(" hora");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 55 "C:\Users\CyberCup\Downloads\Parking_Lot\Parking_Lot\Views\Estacionamiento\Index.cshtml"
                                                       WriteLiteral(i);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2943, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 56 "C:\Users\CyberCup\Downloads\Parking_Lot\Parking_Lot\Views\Estacionamiento\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
                BeginContext(3101, 52, true);
                WriteLiteral("                                                    ");
                EndContext();
                BeginContext(3153, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4749a93af6364c51bea94325b3915ab3", async() => {
                    BeginContext(3173, 1, false);
#line 59 "C:\Users\CyberCup\Downloads\Parking_Lot\Parking_Lot\Views\Estacionamiento\Index.cshtml"
                                                                  Write(i);

#line default
#line hidden
                    EndContext();
                    BeginContext(3174, 6, true);
                    WriteLiteral(" horas");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 59 "C:\Users\CyberCup\Downloads\Parking_Lot\Parking_Lot\Views\Estacionamiento\Index.cshtml"
                                                       WriteLiteral(i);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3189, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 60 "C:\Users\CyberCup\Downloads\Parking_Lot\Parking_Lot\Views\Estacionamiento\Index.cshtml"
                                                }
                                            }

#line default
#line hidden
                BeginContext(3289, 356, true);
                WriteLiteral(@"                                        </select>
                                    </td>
                                    <td>
                                        <button id=""bt1"" class=""btn btn-bot"" disabled  onclick=""PromptDemo(this,event)"">Comprar</button>
                                    </td>
                                </tr>
");
                EndContext();
#line 68 "C:\Users\CyberCup\Downloads\Parking_Lot\Parking_Lot\Views\Estacionamiento\Index.cshtml"
                            }

#line default
#line hidden
                BeginContext(3676, 80, true);
                WriteLiteral("                        </tbody>\r\n                    </table>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3763, 105, true);
            WriteLiteral("\r\n            </div>\r\n            <div role=\"tabpanel\" class=\"tab-pane\" id=\"nresertab\">\r\n                ");
            EndContext();
            BeginContext(3868, 1105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "799cee324c6d49f9a595342d60de2816", async() => {
                BeginContext(3922, 181, true);
                WriteLiteral("\r\n                    <div>\r\n                        <label>Estacionamiento</label>\r\n                        <select name=\"IdEstacionamiento\" required>\r\n                            ");
                EndContext();
                BeginContext(4103, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "431ad3a838694e56861f06d5ac0d19e7", async() => {
                    BeginContext(4111, 29, true);
                    WriteLiteral("--Escoja un estacionemiento--");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4149, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 79 "C:\Users\CyberCup\Downloads\Parking_Lot\Parking_Lot\Views\Estacionamiento\Index.cshtml"
                             foreach (var est in Model)
                            {

#line default
#line hidden
                BeginContext(4239, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(4271, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a07540c1eac4aafb133dd0a9e5a2544", async() => {
                    BeginContext(4296, 6, false);
#line 81 "C:\Users\CyberCup\Downloads\Parking_Lot\Parking_Lot\Views\Estacionamiento\Index.cshtml"
                                                   Write(est.Id);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 81 "C:\Users\CyberCup\Downloads\Parking_Lot\Parking_Lot\Views\Estacionamiento\Index.cshtml"
                                   WriteLiteral(est.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4311, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 82 "C:\Users\CyberCup\Downloads\Parking_Lot\Parking_Lot\Views\Estacionamiento\Index.cshtml"
                            }

#line default
#line hidden
                BeginContext(4344, 622, true);
                WriteLiteral(@"                        </select>
                    </div>
                    <div>
                        <label>Horas a reservar</label>
                        <input type=""number"" name=""NHora"" value=""1"" min=""1"" required/>
                    </div>
                    <div>
                        <label>Fecha de reserva</label>
                        <input type=""date"" name=""Fecha""  min=""2020-07-09"" max=""2020-12-31""  required/>
                    </div>

                    <div>
                        <button class=""btn btn-bot"">Reserva</button>
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4973, 54, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    ");
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