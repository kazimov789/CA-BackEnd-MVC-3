#pragma checksum "C:\Users\99470\Desktop\Code\BackEnd\ThirdTask For BackEnd - 20.04.2023\ThirdTask For BackEnd - 20.04.2023\Views\Service\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66e975bee0f36ef676a0636c0c904bb6394426bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Detail), @"mvc.1.0.view", @"/Views/Service/Detail.cshtml")]
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
#line 1 "C:\Users\99470\Desktop\Code\BackEnd\ThirdTask For BackEnd - 20.04.2023\ThirdTask For BackEnd - 20.04.2023\Views\_ViewImports.cshtml"
using ThirdTask_For_BackEnd___20._04._2023.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\99470\Desktop\Code\BackEnd\ThirdTask For BackEnd - 20.04.2023\ThirdTask For BackEnd - 20.04.2023\Views\_ViewImports.cshtml"
using ThirdTask_For_BackEnd___20._04._2023.ModelView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\99470\Desktop\Code\BackEnd\ThirdTask For BackEnd - 20.04.2023\ThirdTask For BackEnd - 20.04.2023\Views\_ViewImports.cshtml"
using ThirdTask_For_BackEnd___20._04._2023.DataAccess;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66e975bee0f36ef676a0636c0c904bb6394426bc", @"/Views/Service/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10bc0ce00c57974d6c8626a4cdaa253544ae1025", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Service_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FeatureForService>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<section id=\"services\" class=\"services\">\r\n    <div class=\"container\">\r\n        <div class=\"col-lg-12 col-md-12 d-flex align-items-stretch\">\r\n            <div class=\"icon-box\">\r\n                <div class=\"icon\"><i");
            BeginWriteAttribute("class", " class=\"", 241, "\"", 260, 1);
#nullable restore
#line 7 "C:\Users\99470\Desktop\Code\BackEnd\ThirdTask For BackEnd - 20.04.2023\ThirdTask For BackEnd - 20.04.2023\Views\Service\Detail.cshtml"
WriteAttributeValue("", 249, Model.Icon, 249, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></div>\r\n                <h4><a");
            BeginWriteAttribute("href", " href=\"", 296, "\"", 328, 2);
            WriteAttributeValue("", 303, "/service/detail/", 303, 16, true);
#nullable restore
#line 8 "C:\Users\99470\Desktop\Code\BackEnd\ThirdTask For BackEnd - 20.04.2023\ThirdTask For BackEnd - 20.04.2023\Views\Service\Detail.cshtml"
WriteAttributeValue("", 319, Model.Id, 319, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 8 "C:\Users\99470\Desktop\Code\BackEnd\ThirdTask For BackEnd - 20.04.2023\ThirdTask For BackEnd - 20.04.2023\Views\Service\Detail.cshtml"
                                                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                <p>");
#nullable restore
#line 9 "C:\Users\99470\Desktop\Code\BackEnd\ThirdTask For BackEnd - 20.04.2023\ThirdTask For BackEnd - 20.04.2023\Views\Service\Detail.cshtml"
              Write(Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FeatureForService> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
