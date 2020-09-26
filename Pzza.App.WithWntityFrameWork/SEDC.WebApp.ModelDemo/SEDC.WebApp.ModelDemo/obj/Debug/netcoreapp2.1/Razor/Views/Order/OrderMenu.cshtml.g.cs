#pragma checksum "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Order\OrderMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0984c0a4228d454e005c68c4c52c6d63e66578cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_OrderMenu), @"mvc.1.0.view", @"/Views/Order/OrderMenu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/OrderMenu.cshtml", typeof(AspNetCore.Views_Order_OrderMenu))]
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
using SEDC.WebApp.ModelDemo.PresentationLayer.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0984c0a4228d454e005c68c4c52c6d63e66578cd", @"/Views/Order/OrderMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c8971b237631b2047537c8e418db30556ad23ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_OrderMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 30, true);
            WriteLiteral("\n\n\n<h2>OrderMenu</h2>\n \n<div>\n");
            EndContext();
#line 8 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Order\OrderMenu.cshtml"
     foreach (var item in Model)
    {
        string delivered = item.Delivered ? "DELIVERED" : "NOT DELEVERED YET";

#line default
#line hidden
            BeginContext(169, 59, true);
            WriteLiteral("        <div>\n            <div>\n                Delivered: ");
            EndContext();
            BeginContext(229, 9, false);
#line 13 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Order\OrderMenu.cshtml"
                      Write(delivered);

#line default
#line hidden
            EndContext();
            BeginContext(238, 65, true);
            WriteLiteral("\n            </div>\n            <div>\n                User Name: ");
            EndContext();
            BeginContext(305, 46, false);
#line 16 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Order\OrderMenu.cshtml"
                       Write(item.User.FirstName + " " + item.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(352, 31, true);
            WriteLiteral("\n                User Address: ");
            EndContext();
            BeginContext(384, 17, false);
#line 17 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Order\OrderMenu.cshtml"
                         Write(item.User.Address);

#line default
#line hidden
            EndContext();
            BeginContext(401, 31, true);
            WriteLiteral("\n                Phone Number: ");
            EndContext();
            BeginContext(433, 15, false);
#line 18 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Order\OrderMenu.cshtml"
                         Write(item.User.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(448, 61, true);
            WriteLiteral("\n            </div>\n            <div>\n                Pizza: ");
            EndContext();
            BeginContext(510, 15, false);
#line 21 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Order\OrderMenu.cshtml"
                  Write(item.Pizza.Name);

#line default
#line hidden
            EndContext();
            BeginContext(525, 23, true);
            WriteLiteral("\n                Size: ");
            EndContext();
            BeginContext(549, 15, false);
#line 22 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Order\OrderMenu.cshtml"
                 Write(item.Pizza.Size);

#line default
#line hidden
            EndContext();
            BeginContext(564, 24, true);
            WriteLiteral("\n                Price: ");
            EndContext();
            BeginContext(589, 16, false);
#line 23 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Order\OrderMenu.cshtml"
                  Write(item.Pizza.Price);

#line default
#line hidden
            EndContext();
            BeginContext(605, 35, true);
            WriteLiteral("\n            </div>\n        </div>\n");
            EndContext();
#line 26 "C:\Users\vikto\source\repos\MVC\CLASS\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Order\OrderMenu.cshtml"
    }

#line default
#line hidden
            BeginContext(646, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
