#pragma checksum "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.MVC_Exercise1\ASP.NET.MVC_Exercise1\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a4b9fd0a88e760885d72a54c6f9cc8ac4a8f5c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Index.cshtml", typeof(AspNetCore.Views_User_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a4b9fd0a88e760885d72a54c6f9cc8ac4a8f5c4", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83375c061c6967e55eb8562d007fea88f08ee589", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ASP.NET.MVC_Exercise1.Models.UserModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.MVC_Exercise1\ASP.NET.MVC_Exercise1\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(103, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(132, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cbb846ac1744a49aa8801d71a134bad", async() => {
                BeginContext(159, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(173, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(266, 38, false);
#line 16 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.MVC_Exercise1\ASP.NET.MVC_Exercise1\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(304, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(360, 45, false);
#line 19 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.MVC_Exercise1\ASP.NET.MVC_Exercise1\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(405, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(461, 44, false);
#line 22 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.MVC_Exercise1\ASP.NET.MVC_Exercise1\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(505, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(561, 39, false);
#line 25 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.MVC_Exercise1\ASP.NET.MVC_Exercise1\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(600, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.MVC_Exercise1\ASP.NET.MVC_Exercise1\Views\User\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(718, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(767, 37, false);
#line 34 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.MVC_Exercise1\ASP.NET.MVC_Exercise1\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
            EndContext();
            BeginContext(804, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(860, 44, false);
#line 37 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.MVC_Exercise1\ASP.NET.MVC_Exercise1\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(904, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(960, 43, false);
#line 40 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.MVC_Exercise1\ASP.NET.MVC_Exercise1\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1003, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1059, 38, false);
#line 43 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.MVC_Exercise1\ASP.NET.MVC_Exercise1\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
            EndContext();
            BeginContext(1097, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1153, 65, false);
#line 46 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.MVC_Exercise1\ASP.NET.MVC_Exercise1\Views\User\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1218, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1239, 63, false);
#line 47 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.MVC_Exercise1\ASP.NET.MVC_Exercise1\Views\User\Index.cshtml"
           Write(Html.ActionLink("Details", "UserDetails", new {  id=item.id  }));

#line default
#line hidden
            EndContext();
            BeginContext(1302, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1323, 65, false);
#line 48 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.MVC_Exercise1\ASP.NET.MVC_Exercise1\Views\User\Index.cshtml"
           Write(Html.ActionLink("DeleteUser", "DeleteUser", new {  id=item.id  }));

#line default
#line hidden
            EndContext();
            BeginContext(1388, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 51 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.MVC_Exercise1\ASP.NET.MVC_Exercise1\Views\User\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1427, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ASP.NET.MVC_Exercise1.Models.UserModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591