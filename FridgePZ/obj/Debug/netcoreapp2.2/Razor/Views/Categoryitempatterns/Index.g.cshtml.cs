#pragma checksum "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "236284213c005cb7f4e62d9ac868c59f9e73991d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categoryitempatterns_Index), @"mvc.1.0.view", @"/Views/Categoryitempatterns/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Categoryitempatterns/Index.cshtml", typeof(AspNetCore.Views_Categoryitempatterns_Index))]
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
#line 1 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\_ViewImports.cshtml"
using FridgePZ;

#line default
#line hidden
#line 2 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\_ViewImports.cshtml"
using FridgePZ.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"236284213c005cb7f4e62d9ac868c59f9e73991d", @"/Views/Categoryitempatterns/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35637e76b85c4316bc78e95a1bdf0b6192c624e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Categoryitempatterns_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FridgePZ.Models.Categoryitempattern>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(100, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(129, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "236284213c005cb7f4e62d9ac868c59f9e73991d4906", async() => {
                BeginContext(152, 10, true);
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
            BeginContext(166, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(259, 40, false);
#line 16 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(299, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(355, 40, false);
#line 19 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(395, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(451, 51, false);
#line 22 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CurrentQuantity));

#line default
#line hidden
            EndContext();
            BeginContext(502, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(558, 52, false);
#line 25 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ExpectedQuantity));

#line default
#line hidden
            EndContext();
            BeginContext(610, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(666, 52, false);
#line 28 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ShopingFrequency));

#line default
#line hidden
            EndContext();
            BeginContext(718, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(774, 48, false);
#line 31 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Notification));

#line default
#line hidden
            EndContext();
            BeginContext(822, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(878, 43, false);
#line 34 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Storage));

#line default
#line hidden
            EndContext();
            BeginContext(921, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 40 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1039, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1088, 39, false);
#line 43 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1127, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1183, 39, false);
#line 46 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
            EndContext();
            BeginContext(1222, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1278, 50, false);
#line 49 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CurrentQuantity));

#line default
#line hidden
            EndContext();
            BeginContext(1328, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1384, 51, false);
#line 52 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ExpectedQuantity));

#line default
#line hidden
            EndContext();
            BeginContext(1435, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1491, 51, false);
#line 55 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ShopingFrequency));

#line default
#line hidden
            EndContext();
            BeginContext(1542, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1598, 52, false);
#line 58 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Notification.Type));

#line default
#line hidden
            EndContext();
            BeginContext(1650, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1706, 47, false);
#line 61 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Storage.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1753, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1808, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "236284213c005cb7f4e62d9ac868c59f9e73991d13143", async() => {
                BeginContext(1872, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Index.cshtml"
                                       WriteLiteral(item.CategoryItemPatternId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1880, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1900, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "236284213c005cb7f4e62d9ac868c59f9e73991d15541", async() => {
                BeginContext(1967, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Index.cshtml"
                                          WriteLiteral(item.CategoryItemPatternId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1978, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1998, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "236284213c005cb7f4e62d9ac868c59f9e73991d17945", async() => {
                BeginContext(2064, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 66 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Index.cshtml"
                                         WriteLiteral(item.CategoryItemPatternId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2074, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 69 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2113, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FridgePZ.Models.Categoryitempattern>> Html { get; private set; }
    }
}
#pragma warning restore 1591
