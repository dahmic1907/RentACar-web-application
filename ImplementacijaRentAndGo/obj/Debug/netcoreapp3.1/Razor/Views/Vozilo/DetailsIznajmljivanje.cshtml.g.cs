#pragma checksum "C:\Users\Emina Basic\source\repos\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\DetailsIznajmljivanje.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31442764868a0d31debc0c85d68a718e04b0e438"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vozilo_DetailsIznajmljivanje), @"mvc.1.0.view", @"/Views/Vozilo/DetailsIznajmljivanje.cshtml")]
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
#line 1 "C:\Users\Emina Basic\source\repos\Grupa6-RentACar\ImplementacijaRentAndGo\Views\_ViewImports.cshtml"
using ImplementacijaRentAndGo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Emina Basic\source\repos\Grupa6-RentACar\ImplementacijaRentAndGo\Views\_ViewImports.cshtml"
using ImplementacijaRentAndGo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31442764868a0d31debc0c85d68a718e04b0e438", @"/Views/Vozilo/DetailsIznajmljivanje.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebfe1076445bd4b0d73e2f789a73c23a4324251c", @"/Views/_ViewImports.cshtml")]
    public class Views_Vozilo_DetailsIznajmljivanje : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ImplementacijaRentAndGo.Models.Vozilo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "VozilaZaRentanje", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Emina Basic\source\repos\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\DetailsIznajmljivanje.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    #prikaz-slika-vozila {
        width: 100%;
        height: auto;
    }
</style>

<div>
    <h5 class=""text-secondary"">Detalji o vozilu</h5>
    <hr />

    <div class=""container"">



        <div class=""row"">
            <div class=""col-6 col-sm-6"">
                <img id=""prikaz-slika-vozila""");
            BeginWriteAttribute("src", " src=\"", 418, "\"", 468, 1);
#nullable restore
#line 24 "C:\Users\Emina Basic\source\repos\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\DetailsIznajmljivanje.cshtml"
WriteAttributeValue("", 424, Html.DisplayFor(model => model.SlikaVozila), 424, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded\" alt=\"slika vozila\">\r\n            </div>\r\n            <div class=\"col-6 col-sm-3\">\r\n                <h5 class=\"text-secondary\" style=\"align-content:center\">");
#nullable restore
#line 27 "C:\Users\Emina Basic\source\repos\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\DetailsIznajmljivanje.cshtml"
                                                                   Write(Html.DisplayFor(model => model.Naziv));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n                <i class=\"bi bi-droplet-half\">");
#nullable restore
#line 29 "C:\Users\Emina Basic\source\repos\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\DetailsIznajmljivanje.cshtml"
                                         Write(Html.DisplayFor(model => model.Gorivo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                <br />\r\n                <i class=\"bi bi-gear\">");
#nullable restore
#line 31 "C:\Users\Emina Basic\source\repos\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\DetailsIznajmljivanje.cshtml"
                                 Write(Html.DisplayFor(model => model.Mjenjac));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                <br />\r\n                <br />\r\n                <h6>Dodatno:</h6>\r\n                ");
#nullable restore
#line 35 "C:\Users\Emina Basic\source\repos\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\DetailsIznajmljivanje.cshtml"
           Write(Html.DisplayFor(model => model.Klima));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 36 "C:\Users\Emina Basic\source\repos\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\DetailsIznajmljivanje.cshtml"
           Write(Html.DisplayNameFor(model => model.Klima));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n                ");
#nullable restore
#line 38 "C:\Users\Emina Basic\source\repos\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\DetailsIznajmljivanje.cshtml"
           Write(Html.DisplayFor(model => model.SistemBezKljuca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 39 "C:\Users\Emina Basic\source\repos\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\DetailsIznajmljivanje.cshtml"
           Write(Html.DisplayNameFor(model => model.SistemBezKljuca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n                ");
#nullable restore
#line 41 "C:\Users\Emina Basic\source\repos\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\DetailsIznajmljivanje.cshtml"
           Write(Html.DisplayFor(model => model.AluminijskeFelge));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 42 "C:\Users\Emina Basic\source\repos\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\DetailsIznajmljivanje.cshtml"
           Write(Html.DisplayNameFor(model => model.AluminijskeFelge));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n                ");
#nullable restore
#line 44 "C:\Users\Emina Basic\source\repos\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\DetailsIznajmljivanje.cshtml"
           Write(Html.DisplayFor(model => model.SklopiviRetrovizori));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 45 "C:\Users\Emina Basic\source\repos\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\DetailsIznajmljivanje.cshtml"
           Write(Html.DisplayNameFor(model => model.SklopiviRetrovizori));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n                ");
#nullable restore
#line 47 "C:\Users\Emina Basic\source\repos\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\DetailsIznajmljivanje.cshtml"
           Write(Html.DisplayFor(model => model.BoardComputer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 48 "C:\Users\Emina Basic\source\repos\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\DetailsIznajmljivanje.cshtml"
           Write(Html.DisplayNameFor(model => model.BoardComputer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n                ");
#nullable restore
#line 50 "C:\Users\Emina Basic\source\repos\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\DetailsIznajmljivanje.cshtml"
           Write(Html.DisplayFor(model => model.MP3Interfejs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 51 "C:\Users\Emina Basic\source\repos\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\DetailsIznajmljivanje.cshtml"
           Write(Html.DisplayNameFor(model => model.MP3Interfejs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n            </div>\r\n            <div class=\"col-6 col-sm-3\">\r\n                <hr />\r\n                <i class=\"bi bi-box\">");
#nullable restore
#line 56 "C:\Users\Emina Basic\source\repos\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\DetailsIznajmljivanje.cshtml"
                                Write(Html.DisplayFor(model => model.MaksimalanBrojPutnika));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Sjedišta</i>\r\n                <br />\r\n                <i class=\"bi bi-emoji-sunglasses\">");
#nullable restore
#line 58 "C:\Users\Emina Basic\source\repos\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\DetailsIznajmljivanje.cshtml"
                                             Write(Html.DisplayFor(model => model.Klasa));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</i>
                <br />
                <br />
                <br />
                <br />
                
            </div>

            <!-- Force next columns to break to new line at md breakpoint and up -->


            <div class=""col-6 col-sm-6"" style=""text-align:center"">
                <h5 class=""text-secondary"">Cijena po danu: ");
#nullable restore
#line 70 "C:\Users\Emina Basic\source\repos\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\DetailsIznajmljivanje.cshtml"
                                                      Write(Html.DisplayFor(model => model.CijenaPoDanu));

#line default
#line hidden
#nullable disable
            WriteLiteral(" KM</h5>\r\n                \r\n                <br />\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31442764868a0d31debc0c85d68a718e04b0e43811669", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ImplementacijaRentAndGo.Models.Vozilo> Html { get; private set; }
    }
}
#pragma warning restore 1591