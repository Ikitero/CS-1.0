#pragma checksum "C:\Users\ololo\Source\Repos\CS-1.0\CS 1.0\Views\Shared\_RightImg.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cd86bb3258fe194e05e30e3efb759ec5b4010b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__RightImg), @"mvc.1.0.view", @"/Views/Shared/_RightImg.cshtml")]
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
#line 1 "C:\Users\ololo\Source\Repos\CS-1.0\CS 1.0\Views\_ViewImports.cshtml"
using CS_1._0.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ololo\Source\Repos\CS-1.0\CS 1.0\Views\_ViewImports.cshtml"
using CS_1._0.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cd86bb3258fe194e05e30e3efb759ec5b4010b0", @"/Views/Shared/_RightImg.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed7cbcd7d6a68a062ac7721dd2766bb276af374b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__RightImg : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Record>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div style=\"background-color:black;color:white;padding:20px;\">\r\n\r\n        <h2>");
#nullable restore
#line 4 "C:\Users\ololo\Source\Repos\CS-1.0\CS 1.0\Views\Shared\_RightImg.cshtml"
       Write(Model.RecordHeader);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <p>\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 152, "\"", 176, 1);
#nullable restore
#line 6 "C:\Users\ololo\Source\Repos\CS-1.0\CS 1.0\Views\Shared\_RightImg.cshtml"
WriteAttributeValue("", 158, Model.RecordImage, 158, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"float:right;width:42px;height:42px;\">\r\n            ");
#nullable restore
#line 7 "C:\Users\ololo\Source\Repos\CS-1.0\CS 1.0\Views\Shared\_RightImg.cshtml"
       Write(Model.RecordDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Record> Html { get; private set; }
    }
}
#pragma warning restore 1591
