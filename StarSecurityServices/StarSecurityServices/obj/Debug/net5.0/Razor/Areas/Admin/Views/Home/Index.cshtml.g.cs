#pragma checksum "E:\C2002L\.NET\Star_Security_Service\StarSecurityServices\StarSecurityServices\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26b0ac6874b779b48299805f2befd3c1468baa86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
#line 1 "E:\C2002L\.NET\Star_Security_Service\StarSecurityServices\StarSecurityServices\Areas\Admin\Views\_ViewImports.cshtml"
using StarSecurityServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\C2002L\.NET\Star_Security_Service\StarSecurityServices\StarSecurityServices\Areas\Admin\Views\_ViewImports.cshtml"
using StarSecurityServices.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26b0ac6874b779b48299805f2befd3c1468baa86", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caeb43d0895f972916cc00d543e2e59ee1571a57", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StarSecurityServices.Areas.Admin.ViewModels.DashboardViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Admin/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\C2002L\.NET\Star_Security_Service\StarSecurityServices\StarSecurityServices\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <!-- include libraries(jQuery, bootstrap) -->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">

    <!-- custom css -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "26b0ac6874b779b48299805f2befd3c1468baa864767", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row mb-5"">
        <div class=""col-xl-3 col-md-6"">
            <div class=""card border-left-primary shadow"">
                <div class=""card-body"">
                    <div class=""text-xl-start text-card-title text-blue text-uppercase mb-1"">
                        Number of Employees
                    </div>
                    <div class=""h4 mb-0 font-weight-bold"">
                        ");
#nullable restore
#line 25 "E:\C2002L\.NET\Star_Security_Service\StarSecurityServices\StarSecurityServices\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.EmployeeCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-xl-3 col-md-6"">
            <div class=""card border-left-primary shadow"">
                <div class=""card-body"">
                    <div class=""text-xl-start text-card-title text-blue text-uppercase mb-1"">
                        Number of Roles
                    </div>
                    <div class=""h4 mb-0 font-weight-bold"">
                        ");
#nullable restore
#line 37 "E:\C2002L\.NET\Star_Security_Service\StarSecurityServices\StarSecurityServices\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.RoleCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-xl-3 col-md-6"">
            <div class=""card border-left-primary shadow"">
                <div class=""card-body"">
                    <div class=""text-xl-start text-card-title text-blue text-uppercase mb-1"">
                        Number of Role Assignments
                    </div>
                    <div class=""h4 mb-0 font-weight-bold"">
                        ");
#nullable restore
#line 49 "E:\C2002L\.NET\Star_Security_Service\StarSecurityServices\StarSecurityServices\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.EmployeeRoleCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""row mb-5"">
        <div class=""col-xl-3 col-md-6"">
            <div class=""card border-left-purple shadow"">
                <div class=""card-body"">
                    <div class=""text-xl-start text-card-title text-primary text-uppercase mb-1"">
                        Number of Departments
                    </div>
                    <div class=""h4 mb-0 font-weight-bold"">
                        ");
#nullable restore
#line 64 "E:\C2002L\.NET\Star_Security_Service\StarSecurityServices\StarSecurityServices\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.DepartmentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-xl-3 col-md-6"">
            <div class=""card border-left-purple shadow"">
                <div class=""card-body"">
                    <div class=""text-xl-start text-card-title text-primary text-uppercase mb-1"">
                        Number of Jobs
                    </div>
                    <div class=""h4 mb-0 font-weight-bold"">
                        ");
#nullable restore
#line 76 "E:\C2002L\.NET\Star_Security_Service\StarSecurityServices\StarSecurityServices\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.JobCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-xl-3 col-md-6"">
            <div class=""card border-left-purple shadow"">
                <div class=""card-body"">
                    <div class=""text-xl-start text-card-title text-primary text-uppercase mb-1"">
                        Number of Vacancies
                    </div>
                    <div class=""h4 mb-0 font-weight-bold"">
                        ");
#nullable restore
#line 88 "E:\C2002L\.NET\Star_Security_Service\StarSecurityServices\StarSecurityServices\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.VacancyCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""row mb-5"">
        <div class=""col-xl-3 col-md-6"">
            <div class=""card border-left-aqua shadow"">
                <div class=""card-body"">
                    <div class=""text-xl-start text-card-title text-aqua text-uppercase mb-1"">
                        Number of Branches
                    </div>
                    <div class=""h4 mb-0 font-weight-bold"">
                        ");
#nullable restore
#line 103 "E:\C2002L\.NET\Star_Security_Service\StarSecurityServices\StarSecurityServices\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.BranchCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-xl-3 col-md-6"">
            <div class=""card border-left-aqua shadow"">
                <div class=""card-body"">
                    <div class=""text-xl-start text-card-title text-aqua text-uppercase mb-1"">
                        Number of Regions
                    </div>
                    <div class=""h4 mb-0 font-weight-bold"">
                        ");
#nullable restore
#line 115 "E:\C2002L\.NET\Star_Security_Service\StarSecurityServices\StarSecurityServices\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.RegionCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""row mb-5"">
        <div class=""col-xl-3 col-md-6"">
            <div class=""card border-left-yellow shadow"">
                <div class=""card-body"">
                    <div class=""text-xl-start text-card-title text-yellow text-uppercase mb-1"">
                        Number of Services
                    </div>
                    <div class=""h4 mb-0 font-weight-bold"">
                        ");
#nullable restore
#line 130 "E:\C2002L\.NET\Star_Security_Service\StarSecurityServices\StarSecurityServices\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.ServiceCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-xl-3 col-md-6"">
            <div class=""card border-left-yellow shadow"">
                <div class=""card-body"">
                    <div class=""text-xl-start text-card-title text-yellow text-uppercase mb-1"">
                        Number of Business Divisions
                    </div>
                    <div class=""h4 mb-0 font-weight-bold"">
                        ");
#nullable restore
#line 142 "E:\C2002L\.NET\Star_Security_Service\StarSecurityServices\StarSecurityServices\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.DivisionCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""row mb-5"">
        <div class=""col-xl-3 col-md-6"">
            <div class=""card border-left-red shadow"">
                <div class=""card-body"">
                    <div class=""text-xl-start text-card-title text-danger text-uppercase mb-1"">
                        Number of Clients
                    </div>
                    <div class=""h4 mb-0 font-weight-bold"">
                        ");
#nullable restore
#line 157 "E:\C2002L\.NET\Star_Security_Service\StarSecurityServices\StarSecurityServices\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.ClientCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-xl-3 col-md-6"">
            <div class=""card border-left-red shadow"">
                <div class=""card-body"">
                    <div class=""text-xl-start text-card-title text-danger text-uppercase mb-1"">
                        Number of Clients' Services
                    </div>
                    <div class=""h4 mb-0 font-weight-bold"">
                        ");
#nullable restore
#line 169 "E:\C2002L\.NET\Star_Security_Service\StarSecurityServices\StarSecurityServices\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.ClientServiceCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"" integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"" integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous""></script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StarSecurityServices.Areas.Admin.ViewModels.DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
