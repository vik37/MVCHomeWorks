#pragma checksum "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.MVC_Exercise1\ASP.NET.MVC_Exercise1\Views\User\UserDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a612332b377d1fb73d4ccaa332338d01f7b264b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UserDetails), @"mvc.1.0.view", @"/Views/User/UserDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/UserDetails.cshtml", typeof(AspNetCore.Views_User_UserDetails))]
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
#line 1 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.MVC_Exercise1\ASP.NET.MVC_Exercise1\Views\_ViewImports.cshtml"
using ASP.NET.MVC_Exercise1;

#line default
#line hidden
#line 2 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.MVC_Exercise1\ASP.NET.MVC_Exercise1\Views\_ViewImports.cshtml"
using ASP.NET.MVC_Exercise1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a612332b377d1fb73d4ccaa332338d01f7b264b", @"/Views/User/UserDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83375c061c6967e55eb8562d007fea88f08ee589", @"/Views/_ViewImports.cshtml")]
    public class Views_User_UserDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASP.NET.MVC_Exercise1.Models.UserModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.MVC_Exercise1\ASP.NET.MVC_Exercise1\Views\User\UserDetails.cshtml"
  
    ViewData["Title"] = "UserDetails";

#line default
#line hidden
            BeginContext(96, 127, true);
            WriteLiteral("\r\n<h2>UserDetails</h2>\r\n\r\n<div>\r\n    <h4>UserModel</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(224, 38, false);
#line 14 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.MVC_Exercise1\ASP.NET.MVC_Exercise1\Views\User\UserDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(262, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(306, 34, false);
#line 17 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.MVC_Exercise1\ASP.NET.MVC_Exercise1\Views\User\UserDetails.cshtml"
       Write(Html.DisplayFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(340, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(384, 45, false);
#line 20 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.MVC_Exercise1\ASP.NET.MVC_Exercise1\Views\User\UserDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(429, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(473, 41, false);
#line 23 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.MVC_Exercise1\ASP.NET.MVC_Exercise1\Views\User\UserDetails.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(514, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(558, 44, false);
#line 26 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.MVC_Exercise1\ASP.NET.MVC_Exercise1\Views\User\UserDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(602, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(646, 40, false);
#line 29 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.MVC_Exercise1\ASP.NET.MVC_Exercise1\Views\User\UserDetails.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(686, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(730, 39, false);
#line 32 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.MVC_Exercise1\ASP.NET.MVC_Exercise1\Views\User\UserDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(769, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(813, 35, false);
#line 35 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.MVC_Exercise1\ASP.NET.MVC_Exercise1\Views\User\UserDetails.cshtml"
       Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(848, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(896, 68, false);
#line 40 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.MVC_Exercise1\ASP.NET.MVC_Exercise1\Views\User\UserDetails.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(964, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(972, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9941c0d92c644897ba3b2abc08e95815", async() => {
                BeginContext(994, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1010, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASP.NET.MVC_Exercise1.Models.UserModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
