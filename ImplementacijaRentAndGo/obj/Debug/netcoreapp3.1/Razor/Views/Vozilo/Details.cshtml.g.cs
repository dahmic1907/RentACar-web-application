#pragma checksum "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39f9cc06c547dca7f0d2a8950877291f7795e437"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vozilo_Details), @"mvc.1.0.view", @"/Views/Vozilo/Details.cshtml")]
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
#line 1 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\_ViewImports.cshtml"
using ImplementacijaRentAndGo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\_ViewImports.cshtml"
using ImplementacijaRentAndGo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39f9cc06c547dca7f0d2a8950877291f7795e437", @"/Views/Vozilo/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebfe1076445bd4b0d73e2f789a73c23a4324251c", @"/Views/_ViewImports.cshtml")]
    public class Views_Vozilo_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ImplementacijaRentAndGo.Models.Vozilo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
  
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
            BeginWriteAttribute("src", " src=\"", 412, "\"", 462, 1);
#nullable restore
#line 21 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
WriteAttributeValue("", 418, Html.DisplayFor(model => model.SlikaVozila), 418, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded\" alt=\"slika vozila\">\r\n            </div>\r\n            <div class=\"col-6 col-sm-3\">\r\n                <h5 class=\"text-secondary\" style=\"align-content:center\">");
#nullable restore
#line 24 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
                                                                   Write(Html.DisplayFor(model => model.Naziv));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n                <i class=\"bi bi-droplet-half\">");
#nullable restore
#line 26 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
                                         Write(Html.DisplayFor(model => model.Gorivo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                <br />\r\n                <i class=\"bi bi-gear\">");
#nullable restore
#line 28 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
                                 Write(Html.DisplayFor(model => model.Mjenjac));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                <br />\r\n                <br />\r\n                <h6>Dodatno:</h6>\r\n                ");
#nullable restore
#line 32 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
           Write(Html.DisplayFor(model => model.Klima));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 33 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Klima));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n                ");
#nullable restore
#line 35 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
           Write(Html.DisplayFor(model => model.SistemBezKljuca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 36 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.SistemBezKljuca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n                ");
#nullable restore
#line 38 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
           Write(Html.DisplayFor(model => model.AluminijskeFelge));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 39 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.AluminijskeFelge));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n                ");
#nullable restore
#line 41 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
           Write(Html.DisplayFor(model => model.SklopiviRetrovizori));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 42 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.SklopiviRetrovizori));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n                ");
#nullable restore
#line 44 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
           Write(Html.DisplayFor(model => model.BoardComputer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 45 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.BoardComputer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n                ");
#nullable restore
#line 47 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
           Write(Html.DisplayFor(model => model.MP3Interfejs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 48 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.MP3Interfejs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n            </div>\r\n            <div class=\"col-6 col-sm-3\">\r\n                <hr />\r\n                <i class=\"bi bi-box\">");
#nullable restore
#line 53 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
                                Write(Html.DisplayFor(model => model.MaksimalanBrojPutnika));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Sjedišta</i>\r\n                <br />\r\n                <i class=\"bi bi-emoji-sunglasses\">");
#nullable restore
#line 55 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
                                             Write(Html.DisplayFor(model => model.Klasa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n\r\n            </div>\r\n\r\n            <!-- Force next columns to break to new line at md breakpoint and up -->\r\n\r\n\r\n            <div class=\"col-6 col-sm-6\" style=\"text-align:center\">\r\n                <h5 class=\"text-secondary\">Cijena po danu: ");
#nullable restore
#line 63 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
                                                      Write(Html.DisplayFor(model => model.CijenaPoDanu));

#line default
#line hidden
#nullable disable
            WriteLiteral(" KM</h5>\r\n                <br />\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n\r\n        <!--<div class=\"row\">\r\n            <div class=\"col-6\" align=\"center\">\r\n                <img id=\"prikaz-slika-vozila\" src=\"");
#nullable restore
#line 73 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
                                              Write(Html.DisplayFor(model => model.SlikaVozila));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"rounded\" alt=\"slika vozila\">\r\n                <label>Cijena po danu:</label>\r\n                <label> ");
#nullable restore
#line 75 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
                   Write(Html.DisplayFor(model => model.CijenaPoDanu));

#line default
#line hidden
#nullable disable
            WriteLiteral(" KM</label>\r\n                <br />\r\n\r\n                <a asp-action=\"Uredi\" asp-route-id=\"");
#nullable restore
#line 78 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
                                               Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">Edit</a>
                <i class=""bi bi-pencil-square""></i>
                <br />

                <a asp-action=""Index"">Nazad na listu</a>
                <i class=""bi bi-backspace""></i>

            </div>

            <div class=""col-3"">
                ");
#nullable restore
#line 88 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Klima));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 89 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.SistemBezKljuca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                ");
#nullable restore
#line 92 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.AluminijskeFelge));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                ");
#nullable restore
#line 95 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.SklopiviRetrovizori));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n                ");
#nullable restore
#line 99 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.BoardComputer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n                ");
#nullable restore
#line 103 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.MP3Interfejs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n            </div>\r\n            <div class=\"col-3\">\r\n                ");
#nullable restore
#line 108 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
           Write(Html.DisplayFor(model => model.Klima));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 109 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
           Write(Html.DisplayFor(model => model.SistemBezKljuca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                ");
#nullable restore
#line 111 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
           Write(Html.DisplayFor(model => model.AluminijskeFelge));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 112 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
           Write(Html.DisplayFor(model => model.SklopiviRetrovizori));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 113 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
           Write(Html.DisplayFor(model => model.BoardComputer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 114 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
           Write(Html.DisplayFor(model => model.MP3Interfejs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>-->\r\n        <!-- Force next columns to break to new line at md breakpoint and up -->\r\n        <!--<div class=\"w-100 d-none d-md-block\"></div>-->\r\n");
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n");
            WriteLiteral("<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39f9cc06c547dca7f0d2a8950877291f7795e43717402", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 205 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Vozilo\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39f9cc06c547dca7f0d2a8950877291f7795e43719579", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
