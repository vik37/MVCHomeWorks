#pragma checksum "C:\Users\vikto\source\repos\MVC\HomeWORK\ASP.NET.MVCHomeWork_PizzaApp\ASP.NET.MVCHomeWork_PizzaApp\Views\Pizza\DeletePizza.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01db4214d04f6623c652ddc02bde3b7cf70288a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizza_DeletePizza), @"mvc.1.0.view", @"/Views/Pizza/DeletePizza.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pizza/DeletePizza.cshtml", typeof(AspNetCore.Views_Pizza_DeletePizza))]
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
#line 1 "C:\Users\vikto\source\repos\MVC\HomeWORK\ASP.NET.MVCHomeWork_PizzaApp\ASP.NET.MVCHomeWork_PizzaApp\Views\_ViewImports.cshtml"
using ASP.NET.MVCHomeWork_PizzaApp;

#line default
#line hidden
#line 2 "C:\Users\vikto\source\repos\MVC\HomeWORK\ASP.NET.MVCHomeWork_PizzaApp\ASP.NET.MVCHomeWork_PizzaApp\Views\_ViewImports.cshtml"
using ASP.NET.MVCHomeWork_PizzaApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01db4214d04f6623c652ddc02bde3b7cf70288a3", @"/Views/Pizza/DeletePizza.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5897f706518a63c6089ad564070a9e65ade1270", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizza_DeletePizza : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASP.NET.MVCHomeWork_PizzaApp.Models.PizzaModels>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeletePizza", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\vikto\source\repos\MVC\HomeWORK\ASP.NET.MVCHomeWork_PizzaApp\ASP.NET.MVCHomeWork_PizzaApp\Views\Pizza\DeletePizza.cshtml"
  
    ViewData["Title"] = "DeletePizza";

#line default
#line hidden
            BeginContext(105, 151, true);
            WriteLiteral("\r\n<h2>DeletePizza</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>PizzaModels</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n");
            EndContext();
            BeginContext(424, 26, true);
            WriteLiteral("        <dt>\r\n            ");
            EndContext();
            BeginContext(451, 40, false);
#line 21 "C:\Users\vikto\source\repos\MVC\HomeWORK\ASP.NET.MVCHomeWork_PizzaApp\ASP.NET.MVCHomeWork_PizzaApp\Views\Pizza\DeletePizza.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(491, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(535, 36, false);
#line 24 "C:\Users\vikto\source\repos\MVC\HomeWORK\ASP.NET.MVCHomeWork_PizzaApp\ASP.NET.MVCHomeWork_PizzaApp\Views\Pizza\DeletePizza.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(571, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(615, 47, false);
#line 27 "C:\Users\vikto\source\repos\MVC\HomeWORK\ASP.NET.MVCHomeWork_PizzaApp\ASP.NET.MVCHomeWork_PizzaApp\Views\Pizza\DeletePizza.cshtml"
       Write(Html.DisplayNameFor(model => model.Ingredients));

#line default
#line hidden
            EndContext();
            BeginContext(662, 17, true);
            WriteLiteral("\r\n        </dt>\r\n");
            EndContext();
            BeginContext(770, 32, true);
            WriteLiteral("        <dd>\r\n            <ul>\r\n");
            EndContext();
#line 34 "C:\Users\vikto\source\repos\MVC\HomeWORK\ASP.NET.MVCHomeWork_PizzaApp\ASP.NET.MVCHomeWork_PizzaApp\Views\Pizza\DeletePizza.cshtml"
                 foreach (var ingredient in Model.Ingredients)
                {

#line default
#line hidden
            BeginContext(885, 24, true);
            WriteLiteral("                    <li>");
            EndContext();
            BeginContext(910, 32, false);
#line 36 "C:\Users\vikto\source\repos\MVC\HomeWORK\ASP.NET.MVCHomeWork_PizzaApp\ASP.NET.MVCHomeWork_PizzaApp\Views\Pizza\DeletePizza.cshtml"
                   Write(Html.DisplayFor(i => ingredient));

#line default
#line hidden
            EndContext();
            BeginContext(942, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 37 "C:\Users\vikto\source\repos\MVC\HomeWORK\ASP.NET.MVCHomeWork_PizzaApp\ASP.NET.MVCHomeWork_PizzaApp\Views\Pizza\DeletePizza.cshtml"
                }

#line default
#line hidden
            BeginContext(968, 60, true);
            WriteLiteral("            </ul>\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1029, 40, false);
#line 41 "C:\Users\vikto\source\repos\MVC\HomeWORK\ASP.NET.MVCHomeWork_PizzaApp\ASP.NET.MVCHomeWork_PizzaApp\Views\Pizza\DeletePizza.cshtml"
       Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(1069, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1113, 36, false);
#line 44 "C:\Users\vikto\source\repos\MVC\HomeWORK\ASP.NET.MVCHomeWork_PizzaApp\ASP.NET.MVCHomeWork_PizzaApp\Views\Pizza\DeletePizza.cshtml"
       Write(Html.DisplayFor(model => model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(1149, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1193, 41, false);
#line 47 "C:\Users\vikto\source\repos\MVC\HomeWORK\ASP.NET.MVCHomeWork_PizzaApp\ASP.NET.MVCHomeWork_PizzaApp\Views\Pizza\DeletePizza.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1234, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1278, 37, false);
#line 50 "C:\Users\vikto\source\repos\MVC\HomeWORK\ASP.NET.MVCHomeWork_PizzaApp\ASP.NET.MVCHomeWork_PizzaApp\Views\Pizza\DeletePizza.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1315, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1359, 44, false);
#line 53 "C:\Users\vikto\source\repos\MVC\HomeWORK\ASP.NET.MVCHomeWork_PizzaApp\ASP.NET.MVCHomeWork_PizzaApp\Views\Pizza\DeletePizza.cshtml"
       Write(Html.DisplayNameFor(model => model.Currency));

#line default
#line hidden
            EndContext();
            BeginContext(1403, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1447, 40, false);
#line 56 "C:\Users\vikto\source\repos\MVC\HomeWORK\ASP.NET.MVCHomeWork_PizzaApp\ASP.NET.MVCHomeWork_PizzaApp\Views\Pizza\DeletePizza.cshtml"
       Write(Html.DisplayFor(model => model.Currency));

#line default
#line hidden
            EndContext();
            BeginContext(1487, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1525, 166, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6967c4927e34e629ced43374af9ddbc", async() => {
                BeginContext(1556, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1640, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f04f144ea54496888bce4bdaeb3703b", async() => {
                    BeginContext(1662, 12, true);
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
                BeginContext(1678, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1691, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASP.NET.MVCHomeWork_PizzaApp.Models.PizzaModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
