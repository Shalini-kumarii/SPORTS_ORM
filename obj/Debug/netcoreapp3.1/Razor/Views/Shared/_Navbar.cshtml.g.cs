#pragma checksum "C:\DOJO\Csharp\Sports_ORM\Views\Shared\_Navbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4beadf954f620ba9a3233bb9838e54c822f1a223"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Navbar), @"mvc.1.0.view", @"/Views/Shared/_Navbar.cshtml")]
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
#line 1 "C:\DOJO\Csharp\Sports_ORM\Views\_ViewImports.cshtml"
using SportsORM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DOJO\Csharp\Sports_ORM\Views\_ViewImports.cshtml"
using SportsORM.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4beadf954f620ba9a3233bb9838e54c822f1a223", @"/Views/Shared/_Navbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a84e242283cdb641f30a7b0c0ba0e5ada8d6e8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Navbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav class=""navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-dark mb-4"">
    <div class=""container"">
        <a class=""navbar-brand"" href=""/"">SportsORM</a>
        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target="".navbar-collapse"" aria-controls=""navbarSupportedContent""
                aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>
        <div class=""navbar-collapse collapse d-sm-inline-flex flex-sm-row-reverse"">
            <ul class=""navbar-nav flex-grow-1"">
                <!-- place your navigation links here -->
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""/"">Instructions</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""/level_1"">Level 1</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""/level_2"">Level 2</a>
                </l");
            WriteLiteral(@"i>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""/level_3"">Level 3</a>
                </li>
            </ul>
        </div>
    </div>
</nav>

<script>
    document.querySelectorAll("".nav-link"").forEach(link => {
        if(link.getAttribute(""href"") === window.location.pathname) {
            link.classList.add(""active"");
        }
    });
</script>");
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