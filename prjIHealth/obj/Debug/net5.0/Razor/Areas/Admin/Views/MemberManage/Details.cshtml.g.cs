#pragma checksum "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Areas\Admin\Views\MemberManage\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b92ca1cf6780fb7fbc8df8889aaa4ff9ac418d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_MemberManage_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/MemberManage/Details.cshtml")]
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
#line 1 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\_ViewImports.cshtml"
using prjIHealth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\_ViewImports.cshtml"
using prjIHealth.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b92ca1cf6780fb7fbc8df8889aaa4ff9ac418d0", @"/Areas/Admin/Views/MemberManage/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a16e691bc2a8572590ef329eb9d410d52ff20929", @"/_ViewImports.cshtml")]
    public class Areas_Admin_Views_MemberManage_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<prjIHealth.Models.TMember>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Areas\Admin\Views\MemberManage\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <style>\r\n        #title {\r\n            font-weight: 800;\r\n            color: #599e32;\r\n            margin-left: 20vw;\r\n            margin-right: 20vw;\r\n        }\r\n        /*        <h2 id=\"title\">管理頁Demo</h2>*/\r\n    </style>\r\n");
            }
            );
            WriteLiteral("<h2 id=\"title\">Details</h2>\r\n<hr />\r\n<div>\r\n    <h4>TMember</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Areas\Admin\Views\MemberManage\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FMemberName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Areas\Admin\Views\MemberManage\Details.cshtml"
       Write(Html.DisplayFor(model => model.FMemberName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Areas\Admin\Views\MemberManage\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Areas\Admin\Views\MemberManage\Details.cshtml"
       Write(Html.DisplayFor(model => model.FPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Areas\Admin\Views\MemberManage\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FBirthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Areas\Admin\Views\MemberManage\Details.cshtml"
       Write(Html.DisplayFor(model => model.FBirthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 43 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Areas\Admin\Views\MemberManage\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FGender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Areas\Admin\Views\MemberManage\Details.cshtml"
       Write(Html.DisplayFor(model => model.FGender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 49 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Areas\Admin\Views\MemberManage\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FPicturePath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 52 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Areas\Admin\Views\MemberManage\Details.cshtml"
       Write(Html.DisplayFor(model => model.FPicturePath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 55 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Areas\Admin\Views\MemberManage\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FUserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 58 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Areas\Admin\Views\MemberManage\Details.cshtml"
       Write(Html.DisplayFor(model => model.FUserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 61 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Areas\Admin\Views\MemberManage\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 64 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Areas\Admin\Views\MemberManage\Details.cshtml"
       Write(Html.DisplayFor(model => model.FAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 67 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Areas\Admin\Views\MemberManage\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 70 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Areas\Admin\Views\MemberManage\Details.cshtml"
       Write(Html.DisplayFor(model => model.FPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 73 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Areas\Admin\Views\MemberManage\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 76 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Areas\Admin\Views\MemberManage\Details.cshtml"
       Write(Html.DisplayFor(model => model.FEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 79 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Areas\Admin\Views\MemberManage\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FRegisterDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 82 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Areas\Admin\Views\MemberManage\Details.cshtml"
       Write(Html.DisplayFor(model => model.FRegisterDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 85 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Areas\Admin\Views\MemberManage\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FDisabled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 88 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Areas\Admin\Views\MemberManage\Details.cshtml"
       Write(Html.DisplayFor(model => model.FDisabled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 91 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Areas\Admin\Views\MemberManage\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FRemarks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 94 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Areas\Admin\Views\MemberManage\Details.cshtml"
       Write(Html.DisplayFor(model => model.FRemarks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 97 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Areas\Admin\Views\MemberManage\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FAuthority));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 100 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Areas\Admin\Views\MemberManage\Details.cshtml"
       Write(Html.DisplayFor(model => model.FAuthority.FAuthorityName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b92ca1cf6780fb7fbc8df8889aaa4ff9ac418d013177", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 105 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Areas\Admin\Views\MemberManage\Details.cshtml"
                           WriteLiteral(Model.FMemberId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b92ca1cf6780fb7fbc8df8889aaa4ff9ac418d015339", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<prjIHealth.Models.TMember> Html { get; private set; }
    }
}
#pragma warning restore 1591
