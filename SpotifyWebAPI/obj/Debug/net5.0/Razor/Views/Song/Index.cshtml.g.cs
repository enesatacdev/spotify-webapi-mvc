#pragma checksum "C:\Users\User\Desktop\SpotifyWebAPI\SpotifyWebAPI\Views\Song\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b7e765d2f068d6bbb917d5b86d935823a6b6c61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Song_Index), @"mvc.1.0.view", @"/Views/Song/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\SpotifyWebAPI\SpotifyWebAPI\Views\_ViewImports.cshtml"
using SpotifyWebAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\SpotifyWebAPI\SpotifyWebAPI\Views\_ViewImports.cshtml"
using SpotifyWebAPI.Service.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b7e765d2f068d6bbb917d5b86d935823a6b6c61", @"/Views/Song/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5057c613f1428b2d56f141f19596c98491a5311", @"/Views/_ViewImports.cshtml")]
    public class Views_Song_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n\r\n    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 6 "C:\Users\User\Desktop\SpotifyWebAPI\SpotifyWebAPI\Views\Song\Index.cshtml"
         using (Html.BeginForm("Index", "Song"))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\SpotifyWebAPI\SpotifyWebAPI\Views\Song\Index.cshtml"
       Write(Html.TextBox("txtSong"));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input type=\"submit\" value=\"Ara\" />\r\n");
#nullable restore
#line 10 "C:\Users\User\Desktop\SpotifyWebAPI\SpotifyWebAPI\Views\Song\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 12 "C:\Users\User\Desktop\SpotifyWebAPI\SpotifyWebAPI\Views\Song\Index.cshtml"
     if (Model.Search != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\User\Desktop\SpotifyWebAPI\SpotifyWebAPI\Views\Song\Index.cshtml"
         if (Model.Search.Result.Count() > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\User\Desktop\SpotifyWebAPI\SpotifyWebAPI\Views\Song\Index.cshtml"
             foreach (var searchResult in Model.Search.Result)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-3\" style=\"height:600px\">\r\n                    <div class=\"card-body\">\r\n                        <h4 class=\"card-title\">Şarkı Adı : ");
#nullable restore
#line 20 "C:\Users\User\Desktop\SpotifyWebAPI\SpotifyWebAPI\Views\Song\Index.cshtml"
                                                      Write(Html.DisplayFor(x => searchResult.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <h5>Sanatçılar : ");
#nullable restore
#line 21 "C:\Users\User\Desktop\SpotifyWebAPI\SpotifyWebAPI\Views\Song\Index.cshtml"
                                    Write(Html.DisplayFor(x => searchResult.Artists));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <h6>Çıkış Tarihi : ");
#nullable restore
#line 22 "C:\Users\User\Desktop\SpotifyWebAPI\SpotifyWebAPI\Views\Song\Index.cshtml"
                                      Write(Html.DisplayFor(x => searchResult.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 843, "\"", 889, 1);
#nullable restore
#line 23 "C:\Users\User\Desktop\SpotifyWebAPI\SpotifyWebAPI\Views\Song\Index.cshtml"
WriteAttributeValue("", 850, Html.DisplayFor(x=> searchResult.Link), 850, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Hemen Dinle</a>\r\n                        <img style=\"width:100%;height:auto\"");
            BeginWriteAttribute("src", " src=\"", 967, "\"", 1014, 1);
#nullable restore
#line 24 "C:\Users\User\Desktop\SpotifyWebAPI\SpotifyWebAPI\Views\Song\Index.cshtml"
WriteAttributeValue("", 973, Html.DisplayFor(x => searchResult.Image), 973, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 27 "C:\Users\User\Desktop\SpotifyWebAPI\SpotifyWebAPI\Views\Song\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\User\Desktop\SpotifyWebAPI\SpotifyWebAPI\Views\Song\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\User\Desktop\SpotifyWebAPI\SpotifyWebAPI\Views\Song\Index.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
