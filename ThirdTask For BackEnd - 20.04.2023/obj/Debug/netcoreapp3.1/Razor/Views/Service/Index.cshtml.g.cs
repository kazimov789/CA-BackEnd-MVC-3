#pragma checksum "C:\Users\99470\Desktop\Code\BackEnd\ThirdTask For BackEnd - 20.04.2023\ThirdTask For BackEnd - 20.04.2023\Views\Service\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af2ca9361b773c70ae9f8f9d478547f5e76f3c1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Index), @"mvc.1.0.view", @"/Views/Service/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af2ca9361b773c70ae9f8f9d478547f5e76f3c1b", @"/Views/Service/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10bc0ce00c57974d6c8626a4cdaa253544ae1025", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Service_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FeatureForService>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"<main id=""main"">

    <!-- ======= Breadcrumbs ======= -->
    <section id=""breadcrumbs"" class=""breadcrumbs"">
        <div class=""container"">

            <ol>
                <li><a href=""index.html"">Home</a></li>
                <li>Services</li>
            </ol>
            <h2>Services</h2>

        </div>
    </section><!-- End Breadcrumbs -->
    <!-- ======= Services Section ======= -->
    <section id=""services"" class=""services"">
        <div class=""container"">

            <div class=""row"">
");
#nullable restore
#line 23 "C:\Users\99470\Desktop\Code\BackEnd\ThirdTask For BackEnd - 20.04.2023\ThirdTask For BackEnd - 20.04.2023\Views\Service\Index.cshtml"
                 foreach (FeatureForService item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-6 d-flex align-items-stretch mt-4\">\r\n                    <div class=\"icon-box\">\r\n                        <div class=\"icon\"><i");
            BeginWriteAttribute("class", " class=\"", 837, "\"", 855, 1);
#nullable restore
#line 27 "C:\Users\99470\Desktop\Code\BackEnd\ThirdTask For BackEnd - 20.04.2023\ThirdTask For BackEnd - 20.04.2023\Views\Service\Index.cshtml"
WriteAttributeValue("", 845, item.Icon, 845, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></div>\r\n                            <h4><a");
            BeginWriteAttribute("href", " href=\"", 903, "\"", 910, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "C:\Users\99470\Desktop\Code\BackEnd\ThirdTask For BackEnd - 20.04.2023\ThirdTask For BackEnd - 20.04.2023\Views\Service\Index.cshtml"
                                      Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                            <p>");
#nullable restore
#line 29 "C:\Users\99470\Desktop\Code\BackEnd\ThirdTask For BackEnd - 20.04.2023\ThirdTask For BackEnd - 20.04.2023\Views\Service\Index.cshtml"
                          Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>                    \n");
#nullable restore
#line 32 "C:\Users\99470\Desktop\Code\BackEnd\ThirdTask For BackEnd - 20.04.2023\ThirdTask For BackEnd - 20.04.2023\Views\Service\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>

        </div>
    </section><!-- End Services Section -->
    <!-- ======= Our Skills Section ======= -->
    <section id=""skills"" class=""skills"">
        <div class=""container"">

            <div class=""section-title"">
                <h2>Our Skills</h2>
                <p>Magnam dolores commodi suscipit. Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint consectetur velit. Quisquam quos quisquam cupiditate. Et nemo qui impedit suscipit alias ea. Quia fugiat sit in iste officiis commodi quidem hic quas.</p>
            </div>

            <div class=""row"">
                <div class=""col-lg-6"">
                    <img src=""assets/img/skills-img.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 1802, "\"", 1808, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
                <div class=""col-lg-6 pt-4 pt-lg-0 content"">
                    <h3>Voluptatem dignissimos provident quasi corporis voluptates</h3>
                    <p class=""fst-italic"">
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt direna past reda
                    </p>

                    <div class=""skills-content"">

                        <div class=""progress"">
                            <span class=""skill"">HTML <i class=""val"">100%</i></span>
                            <div class=""progress-bar-wrap"">
                                <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                            </div>
                        </div>

                        <div class=""progress"">
                            <span class=""skill"">CSS <i class=""val"">90%</i></span>
                            <div class=""progress-bar-");
            WriteLiteral(@"wrap"">
                                <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""90"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                            </div>
                        </div>

                        <div class=""progress"">
                            <span class=""skill"">JavaScript <i class=""val"">75%</i></span>
                            <div class=""progress-bar-wrap"">
                                <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                            </div>
                        </div>

                        <div class=""progress"">
                            <span class=""skill"">Photoshop <i class=""val"">55%</i></span>
                            <div class=""progress-bar-wrap"">
                                <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""55"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                            </div>
                 ");
            WriteLiteral("       </div>\r\n\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </section><!-- End Our Skills Section -->\r\n\r\n</main><!-- End #main -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FeatureForService>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
