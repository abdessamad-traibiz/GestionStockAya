#pragma checksum "C:\Users\Abdes\source\repos\GestionStock\GestionStock\Pages\Clients.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "369e8b056861b4b75aa754cbed0420d0f7ba2a03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GestionStock.Pages.Pages_Clients), @"mvc.1.0.razor-page", @"/Pages/Clients.cshtml")]
namespace GestionStock.Pages
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
#line 1 "C:\Users\Abdes\source\repos\GestionStock\GestionStock\Pages\_ViewImports.cshtml"
using GestionStock;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"369e8b056861b4b75aa754cbed0420d0f7ba2a03", @"/Pages/Clients.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c3e572da7f727224732672eace0d0bd5aaa3eed", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Clients : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1> liste des clients : </h1>
<br>
<h2> liste des clients</h2>
<a class='btn btn-primary btn-sm' href='/Clients/Create'> Nouveau client</a>
<table class=""table"">
    <thead>
        <tr>
            <th>ID </th>
            <th>Name </th>
            <th>Email </th>
            <th>Télephone </th>
            <th>Adresse </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "C:\Users\Abdes\source\repos\GestionStock\GestionStock\Pages\Clients.cshtml"
         foreach (var item in Model.listClients)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\Abdes\source\repos\GestionStock\GestionStock\Pages\Clients.cshtml"
               Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\Abdes\source\repos\GestionStock\GestionStock\Pages\Clients.cshtml"
               Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\Abdes\source\repos\GestionStock\GestionStock\Pages\Clients.cshtml"
               Write(item.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\Abdes\source\repos\GestionStock\GestionStock\Pages\Clients.cshtml"
               Write(item.telephone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\Abdes\source\repos\GestionStock\GestionStock\Pages\Clients.cshtml"
               Write(item.adresse);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a class=\'btn btn-primary btn-sm\'");
            BeginWriteAttribute("href", "\r\n                       href=\'", 792, "\'", 848, 2);
            WriteAttributeValue("", 823, "/Clients/Edit?id=", 823, 17, true);
#nullable restore
#line 30 "C:\Users\Abdes\source\repos\GestionStock\GestionStock\Pages\Clients.cshtml"
WriteAttributeValue("", 840, item.id, 840, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Editer </a>\r\n                    <a class=\'btn btn-danger btn-sm\'");
            BeginWriteAttribute("href", "\r\n                       href=\'", 916, "\'", 974, 2);
            WriteAttributeValue("", 947, "/Clients/Delete?id=", 947, 19, true);
#nullable restore
#line 32 "C:\Users\Abdes\source\repos\GestionStock\GestionStock\Pages\Clients.cshtml"
WriteAttributeValue("", 966, item.id, 966, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> supprimer</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 35 "C:\Users\Abdes\source\repos\GestionStock\GestionStock\Pages\Clients.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GestionStock.Pages.Clients.ClientsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GestionStock.Pages.Clients.ClientsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GestionStock.Pages.Clients.ClientsModel>)PageContext?.ViewData;
        public GestionStock.Pages.Clients.ClientsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
