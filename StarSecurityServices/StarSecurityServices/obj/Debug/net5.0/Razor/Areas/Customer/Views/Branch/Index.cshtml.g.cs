#pragma checksum "D:\Aptech\Project 3\Star_Security_Service\StarSecurityServices\StarSecurityServices\Areas\Customer\Views\Branch\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49d0d0c481ccd3beb56b9c1d3f8f25d74204964d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Branch_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Branch/Index.cshtml")]
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
#line 1 "D:\Aptech\Project 3\Star_Security_Service\StarSecurityServices\StarSecurityServices\Areas\Customer\Views\_ViewImports.cshtml"
using StarSecurityServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Aptech\Project 3\Star_Security_Service\StarSecurityServices\StarSecurityServices\Areas\Customer\Views\_ViewImports.cshtml"
using StarSecurityServices.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49d0d0c481ccd3beb56b9c1d3f8f25d74204964d", @"/Areas/Customer/Views/Branch/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c185ddd2af846ca9cdb3dba8d944c1eb2d61335", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Branch_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StarSecurityServices.Areas.Customer.ViewModels.BranchRegionViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/leafletjs/leaflet-utils.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\Aptech\Project 3\Star_Security_Service\StarSecurityServices\StarSecurityServices\Areas\Customer\Views\Branch\Index.cshtml"
   ViewData["Title"] = "Index";
    Layout = "~/Areas/Customer/Views/Shared/_LayoutBranch.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<link rel=\"stylesheet\" href=\"https://unpkg.com/leaflet@1.7.1/dist/leaflet.css\"\n      integrity=\"sha512-xodZBNTC5n17Xt2atTPuE1HxjVMSvLVW9ocqUKLsCC5CXdbqCmblAshOMAS6/keqq/sMZMZ19scR4PsZChSR7A==\"");
            BeginWriteAttribute("crossorigin", "\n      crossorigin=\"", 371, "\"", 391, 0);
            EndWriteAttribute();
            WriteLiteral(" />\n<script src=\"https://unpkg.com/leaflet@1.7.1/dist/leaflet.js\"\n        integrity=\"sha512-XQoYMqMTK8LvdxXYG3nZ448hOEQiglfqkJs1NOQV44cWnUrBc8PkAOcXy20w0vlaXaVUearIOBhiXZ5V3ynxwA==\"");
            BeginWriteAttribute("crossorigin", "\n        crossorigin=\"", 573, "\"", 595, 0);
            EndWriteAttribute();
            WriteLiteral(@"></script>

<div class=""breadcrumb-area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""breadcrumb-text"">
                    <h1>OUR NETWORK</h1>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""container"">
    <div>
");
#nullable restore
#line 27 "D:\Aptech\Project 3\Star_Security_Service\StarSecurityServices\StarSecurityServices\Areas\Customer\Views\Branch\Index.cshtml"
         foreach (var region in Model.Regions)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"region-title\">");
#nullable restore
#line 29 "D:\Aptech\Project 3\Star_Security_Service\StarSecurityServices\StarSecurityServices\Areas\Customer\Views\Branch\Index.cshtml"
                                 Write(region.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n            <div class=\"branch-list row\">\n");
#nullable restore
#line 31 "D:\Aptech\Project 3\Star_Security_Service\StarSecurityServices\StarSecurityServices\Areas\Customer\Views\Branch\Index.cshtml"
                 foreach (var item in Model.Branches)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\Aptech\Project 3\Star_Security_Service\StarSecurityServices\StarSecurityServices\Areas\Customer\Views\Branch\Index.cshtml"
                     if (item.RegionId == region.Id)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-4\">\n                            <div style=\"display: none;\" class=\"branch-position\">");
#nullable restore
#line 36 "D:\Aptech\Project 3\Star_Security_Service\StarSecurityServices\StarSecurityServices\Areas\Customer\Views\Branch\Index.cshtml"
                                                                           Write(item.GetDetailLatLong());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n                            <div class=\"branch-name\">\n                                <b>");
#nullable restore
#line 39 "D:\Aptech\Project 3\Star_Security_Service\StarSecurityServices\StarSecurityServices\Areas\Customer\Views\Branch\Index.cshtml"
                              Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\n                            </div>\n                            <div class=\"address\">\n                                <i class=\"mdi mdi-map-marker\"></i>\n                                ");
#nullable restore
#line 43 "D:\Aptech\Project 3\Star_Security_Service\StarSecurityServices\StarSecurityServices\Areas\Customer\Views\Branch\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </div>\n                            <div class=\"contact\">\n                                <i class=\"mdi mdi-phone\"></i>\n                                ");
#nullable restore
#line 47 "D:\Aptech\Project 3\Star_Security_Service\StarSecurityServices\StarSecurityServices\Areas\Customer\Views\Branch\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </div>\n                        </div>\n");
#nullable restore
#line 50 "D:\Aptech\Project 3\Star_Security_Service\StarSecurityServices\StarSecurityServices\Areas\Customer\Views\Branch\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "D:\Aptech\Project 3\Star_Security_Service\StarSecurityServices\StarSecurityServices\Areas\Customer\Views\Branch\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n");
#nullable restore
#line 53 "D:\Aptech\Project 3\Star_Security_Service\StarSecurityServices\StarSecurityServices\Areas\Customer\Views\Branch\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n\n    <h2 class=\"mt-5\">Find us on map</h2>\n    <div id=\"map\" style=\"height:500px;\"></div>\n</div>\n\n<!-- Leaflet JS -->\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49d0d0c481ccd3beb56b9c1d3f8f25d74204964d9333", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<script>\n    const map = new Leaflet(\"map\");\n    map.displayMarkers(map.getMakerData());\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StarSecurityServices.Areas.Customer.ViewModels.BranchRegionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
