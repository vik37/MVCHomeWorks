#pragma checksum "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Test\Testing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a5afe544af7c7bf4620a9facc7b095db418d1c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_Testing), @"mvc.1.0.view", @"/Views/Test/Testing.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Test/Testing.cshtml", typeof(AspNetCore.Views_Test_Testing))]
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
#line 1 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\_ViewImports.cshtml"
using SEDC.WebApp.ModelDemo;

#line default
#line hidden
#line 2 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\_ViewImports.cshtml"
using SEDC.WebApp.ModelDemo.Models;

#line default
#line hidden
#line 3 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\_ViewImports.cshtml"
using SEDC.WebApp.ModelDemo.Models.Domain;

#line default
#line hidden
#line 4 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\_ViewImports.cshtml"
using SEDC.WebApp.ModelDemo.Models.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\_ViewImports.cshtml"
using SEDC.WebApp.ModelDemo.Models.Enums;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a5afe544af7c7bf4620a9facc7b095db418d1c0", @"/Views/Test/Testing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"737eb90a286c0fac18b4fa594ff516e6785b088d", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_Testing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Test", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Testing", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 58, true);
            WriteLiteral("\r\n<div>\r\n    HTML HELPERS\r\n\r\n    => ACTION LINK <=\r\n\r\n    ");
            EndContext();
            BeginContext(75, 46, false);
#line 8 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Test\Testing.cshtml"
Write(Html.ActionLink("Back to Test Index", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(121, 8, true);
            WriteLiteral("\r\n\r\n    ");
            EndContext();
            BeginContext(130, 48, false);
#line 10 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Test\Testing.cshtml"
Write(Html.ActionLink("Back to Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(178, 8, true);
            WriteLiteral("\r\n\r\n    ");
            EndContext();
            BeginContext(187, 72, false);
#line 12 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Test\Testing.cshtml"
Write(Html.ActionLink("Go to item with id 0", "Index", "Home", new { id = 0 }));

#line default
#line hidden
            EndContext();
            BeginContext(259, 25, true);
            WriteLiteral("\r\n\r\n    <= LABEL =>\r\n    ");
            EndContext();
            BeginContext(285, 20, false);
#line 15 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Test\Testing.cshtml"
Write(Html.Display("Name"));

#line default
#line hidden
            EndContext();
            BeginContext(305, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(312, 28, false);
#line 16 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Test\Testing.cshtml"
Write(Html.DisplayFor(p => p.Name));

#line default
#line hidden
            EndContext();
            BeginContext(340, 25, true);
            WriteLiteral("\r\n\r\n    <= LABEL =>\r\n    ");
            EndContext();
            BeginContext(366, 18, false);
#line 19 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Test\Testing.cshtml"
Write(Html.Label("Name"));

#line default
#line hidden
            EndContext();
            BeginContext(384, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(391, 26, false);
#line 20 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Test\Testing.cshtml"
Write(Html.LabelFor(x => x.Name));

#line default
#line hidden
            EndContext();
            BeginContext(417, 28, true);
            WriteLiteral("\r\n\r\n    <= TEXT BOX <=\r\n    ");
            EndContext();
            BeginContext(446, 21, false);
#line 23 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Test\Testing.cshtml"
Write(Html.TextBox("Price"));

#line default
#line hidden
            EndContext();
            BeginContext(467, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(474, 37, false);
#line 24 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Test\Testing.cshtml"
Write(Html.TextBoxFor(pizza => pizza.Price));

#line default
#line hidden
            EndContext();
            BeginContext(511, 34, true);
            WriteLiteral("\r\n\r\n    <= DROP DOWN LIST =>\r\n    ");
            EndContext();
            BeginContext(546, 87, false);
#line 27 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Test\Testing.cshtml"
Write(Html.DropDownListFor(pizza => pizza.Size, Html.GetEnumSelectList(Model.Size.GetType())));

#line default
#line hidden
            EndContext();
            BeginContext(633, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(640, 105, false);
#line 28 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Test\Testing.cshtml"
Write(Html.DropDownListFor(pizza => pizza.Size, Html.GetEnumSelectList(Model.Size.GetType()), "Select a pizza"));

#line default
#line hidden
            EndContext();
            BeginContext(745, 21, true);
            WriteLiteral("\r\n\r\n    => FORMS <=\r\n");
            EndContext();
#line 31 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Test\Testing.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
            BeginContext(813, 26, false);
#line 33 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Test\Testing.cshtml"
   Write(Html.LabelFor(x => x.Name));

#line default
#line hidden
            EndContext();
            BeginContext(850, 28, false);
#line 34 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Test\Testing.cshtml"
   Write(Html.TextBoxFor(x => x.Name));

#line default
#line hidden
            EndContext();
            BeginContext(880, 16, true);
            WriteLiteral("        <br />\r\n");
            EndContext();
            BeginContext(905, 105, false);
#line 36 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Test\Testing.cshtml"
   Write(Html.DropDownListFor(pizza => pizza.Size, Html.GetEnumSelectList(Model.Size.GetType()), "Select a pizza"));

#line default
#line hidden
            EndContext();
            BeginContext(1012, 66, true);
            WriteLiteral("        <br />\r\n        <button type=\"submit\">Add pizza</button>\r\n");
            EndContext();
#line 39 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Test\Testing.cshtml"
    }

#line default
#line hidden
            BeginContext(1085, 66, true);
            WriteLiteral("</div>\r\n\r\n    TAG HELPERS\r\n\r\n<div>\r\n    =>  ACTION LINK <=\r\n\r\n    ");
            EndContext();
            BeginContext(1151, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abec4ffa11004346805f0cb2b4c9bfcb", async() => {
                BeginContext(1195, 18, true);
                WriteLiteral("Back to test index");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1217, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1223, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9512c236da36470d9ca77733b1b059c3", async() => {
                BeginContext(1267, 12, true);
                WriteLiteral("Back to home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1283, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1289, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6d3eb9573e742eaba273ce1d8fe0254", async() => {
                BeginContext(1350, 18, true);
                WriteLiteral("Go to item with id");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1372, 25, true);
            WriteLiteral("\r\n\r\n    => Label <=\r\n    ");
            EndContext();
            BeginContext(1397, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76c0da5a70a744799f1cbe7eea6ca6ad", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 52 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Test\Testing.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1427, 34, true);
            WriteLiteral("\r\n\r\n    => Drop down list <=\r\n    ");
            EndContext();
            BeginContext(1461, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1482cd208bc4a029eb01ad551328d46", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 55 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Test\Testing.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Size);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 55 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Test\Testing.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Html.GetEnumSelectList<PizzaSize>();

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1541, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1547, 141, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "480ddc37a1184650a576c32a1dad4375", async() => {
                BeginContext(1618, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1628, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebaa08a099ea4661863d9c7eb737371f", async() => {
                    BeginContext(1645, 19, true);
                    WriteLiteral("Select a pizza size");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1673, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 56 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Test\Testing.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Size);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 56 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Test\Testing.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Html.GetEnumSelectList<PizzaSize>();

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1688, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1694, 483, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e0a549b49e54085a1570de08f3e0a20", async() => {
                BeginContext(1757, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1767, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91e0eb841ff94a1db44e6887ec9df80d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 60 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Test\Testing.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1797, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1807, 24, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9dfe37e3a5fb4d61b6b9103b7fc4733e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 61 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Test\Testing.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1831, 26, true);
                WriteLiteral("\r\n        <br />\r\n        ");
                EndContext();
                BeginContext(1857, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "591db570e76c4cec814b0cd5670555b8", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 63 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Test\Testing.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Price);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1888, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1898, 25, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6251244da09140ebb2be4c71a312f14c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 64 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Test\Testing.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Price);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1923, 26, true);
                WriteLiteral("\r\n        <br />\r\n        ");
                EndContext();
                BeginContext(1949, 149, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8201dd67ac394a35a4baad008182ac00", async() => {
                    BeginContext(2020, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(2034, 45, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8baa68e8a78643c79a0f03892d6b83a0", async() => {
                        BeginContext(2051, 19, true);
                        WriteLiteral("Select a pizza size");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2079, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 66 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Test\Testing.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Size);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 66 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Test\Testing.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Html.GetEnumSelectList<PizzaSize>();

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2098, 72, true);
                WriteLiteral("\r\n        <br />\r\n        <button type=\"submit\">Add pizza</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2177, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaVM> Html { get; private set; }
    }
}
#pragma warning restore 1591