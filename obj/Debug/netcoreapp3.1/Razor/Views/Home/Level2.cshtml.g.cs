#pragma checksum "C:\DOJO\Csharp\Sports_ORM\Views\Home\Level2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb4fe820cdd7ae3eb5e57cbf068d132754109e0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Level2), @"mvc.1.0.view", @"/Views/Home/Level2.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb4fe820cdd7ae3eb5e57cbf068d132754109e0e", @"/Views/Home/Level2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a84e242283cdb641f30a7b0c0ba0e5ada8d6e8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Level2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""card"">
    <div class=""card-header bg-dark text-light"">Level 2</div>
    <div class=""card-body"">
        <p>Using the SportsORM, complete all the following queries and show their results on Level2.cshtml.</p>
        <ol>
            <li>...all teams in the Atlantic Soccer Conference</li>
            <li>...all (current) players on the Boston Penguins (Hint: Boston is the Location, Penguins is the TeamName)</li>
            <li>...all (current) players in the International Collegiate Baseball Conference</li>
            <li>...all (current) players in the American Conference of Amateur Football with last name ""Lopez""</li>
            <li>...all football players</li>
            <li>...all teams with a (current) player named ""Sophia""</li>
            <li>...all leagues with a (current) player named ""Sophia""</li>
            <li>...everyone with the last name ""Flores"" who DOESN'T (currently) play for the Washington Roughriders</li>
        </ol>
    </div>
</div>");
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
