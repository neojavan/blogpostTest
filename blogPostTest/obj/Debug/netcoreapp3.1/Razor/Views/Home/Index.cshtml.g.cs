#pragma checksum "C:\Users\neojavan\source\repos\blogpostTest\blogPostTest\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20deb27f6130e8587b424b2199c08a06c2c13d36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\neojavan\source\repos\blogpostTest\blogPostTest\Views\_ViewImports.cshtml"
using blogPostTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\neojavan\source\repos\blogpostTest\blogPostTest\Views\_ViewImports.cshtml"
using blogPostTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20deb27f6130e8587b424b2199c08a06c2c13d36", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"865d0b1b59c13618f9e548cc070b9baff36106a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<blogPostTest.Models.Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\neojavan\source\repos\blogpostTest\blogPostTest\Views\Home\Index.cshtml"
      
        ViewData["Title"] = "Home Page";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n    <div class=\"row\">\r\n");
#nullable restore
#line 7 "C:\Users\neojavan\source\repos\blogpostTest\blogPostTest\Views\Home\Index.cshtml"
         if (Model.Count() > 0)
        {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\neojavan\source\repos\blogpostTest\blogPostTest\Views\Home\Index.cshtml"
                     foreach (var item in Model)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\neojavan\source\repos\blogpostTest\blogPostTest\Views\Home\Index.cshtml"
                         if (item.PostPublished.HasValue) 
                        { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"container\">\r\n                                <div class=\"card-title\"><h2>");
#nullable restore
#line 14 "C:\Users\neojavan\source\repos\blogpostTest\blogPostTest\Views\Home\Index.cshtml"
                                                       Write(item.PostTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2></div>\r\n                                <div class=\"tab-content\">\r\n                                    ");
#nullable restore
#line 16 "C:\Users\neojavan\source\repos\blogpostTest\blogPostTest\Views\Home\Index.cshtml"
                               Write(item.PostContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div>\r\n                                        <p>");
#nullable restore
#line 18 "C:\Users\neojavan\source\repos\blogpostTest\blogPostTest\Views\Home\Index.cshtml"
                                      Write(Html.DisplayNameFor(m => m.PostPublished));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 18 "C:\Users\neojavan\source\repos\blogpostTest\blogPostTest\Views\Home\Index.cshtml"
                                                                                   Write(item.PostPublished);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p>");
#nullable restore
#line 19 "C:\Users\neojavan\source\repos\blogpostTest\blogPostTest\Views\Home\Index.cshtml"
                                      Write(Html.DisplayNameFor(m => m.PostUsrId));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 19 "C:\Users\neojavan\source\repos\blogpostTest\blogPostTest\Views\Home\Index.cshtml"
                                                                               Write(item.PostUsrId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n\r\n                            </div>\r\n");
#nullable restore
#line 24 "C:\Users\neojavan\source\repos\blogpostTest\blogPostTest\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\neojavan\source\repos\blogpostTest\blogPostTest\Views\Home\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\neojavan\source\repos\blogpostTest\blogPostTest\Views\Home\Index.cshtml"
                     
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>No existen registros</p>\r\n");
#nullable restore
#line 30 "C:\Users\neojavan\source\repos\blogpostTest\blogPostTest\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<blogPostTest.Models.Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
