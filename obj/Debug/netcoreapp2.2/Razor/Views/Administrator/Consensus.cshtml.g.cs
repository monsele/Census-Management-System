#pragma checksum "C:\Users\rooai\source\repos\CensusManagement System\Views\Administrator\Consensus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b7acbb0f3fd73cc12c8546190a5060a453304e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrator_Consensus), @"mvc.1.0.view", @"/Views/Administrator/Consensus.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrator/Consensus.cshtml", typeof(AspNetCore.Views_Administrator_Consensus))]
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
#line 1 "C:\Users\rooai\source\repos\CensusManagement System\Views\_ViewImports.cshtml"
using CensusManagement_System;

#line default
#line hidden
#line 2 "C:\Users\rooai\source\repos\CensusManagement System\Views\_ViewImports.cshtml"
using CensusManagement_System.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b7acbb0f3fd73cc12c8546190a5060a453304e3", @"/Views/Administrator/Consensus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5965faa785ac22fef5ba98e68117ba656da70e80", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrator_Consensus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CensusManagement_System.ViewModels.AdminViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\rooai\source\repos\CensusManagement System\Views\Administrator\Consensus.cshtml"
  
    ViewData["Title"] = "Consensus";

#line default
#line hidden
            BeginContext(103, 216, true);
            WriteLiteral("\r\n<h1>Consensus</h1>\r\n<div class=\"container-fluid\">\r\n    <div class=\"card\">\r\n        <div class=\"card-header\">\r\n            <h3>Total Population</h3>\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <h5>");
            EndContext();
            BeginContext(320, 17, false);
#line 13 "C:\Users\rooai\source\repos\CensusManagement System\Views\Administrator\Consensus.cshtml"
           Write(Model.CensusCount);

#line default
#line hidden
            EndContext();
            BeginContext(337, 208, true);
            WriteLiteral("</h5>\r\n        </div>\r\n    </div>\r\n    <div class=\"card\">\r\n        <div class=\"card-header\">\r\n            <h3>Total Population InCountry</h3>\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <h5>");
            EndContext();
            BeginContext(546, 23, false);
#line 21 "C:\Users\rooai\source\repos\CensusManagement System\Views\Administrator\Consensus.cshtml"
           Write(Model.ThoseInTheCountry);

#line default
#line hidden
            EndContext();
            BeginContext(569, 217, true);
            WriteLiteral("</h5>\r\n        </div>\r\n    </div>\r\n    <div class=\"card\">\r\n        <div class=\"card-header\">\r\n            <h3>Total Population Not In the Country</h3>\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <h5>");
            EndContext();
            BeginContext(787, 23, false);
#line 29 "C:\Users\rooai\source\repos\CensusManagement System\Views\Administrator\Consensus.cshtml"
           Write(Model.ThoseNotInCountry);

#line default
#line hidden
            EndContext();
            BeginContext(810, 204, true);
            WriteLiteral("</h5>\r\n        </div>\r\n    </div>\r\n    <div class=\"card\">\r\n        <div class=\"card-header\">\r\n            <h3>Total Number Of States</h3>\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <h5>");
            EndContext();
            BeginContext(1015, 20, false);
#line 37 "C:\Users\rooai\source\repos\CensusManagement System\Views\Administrator\Consensus.cshtml"
           Write(Model.NumberOfStates);

#line default
#line hidden
            EndContext();
            BeginContext(1035, 43, true);
            WriteLiteral("</h5>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CensusManagement_System.ViewModels.AdminViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
