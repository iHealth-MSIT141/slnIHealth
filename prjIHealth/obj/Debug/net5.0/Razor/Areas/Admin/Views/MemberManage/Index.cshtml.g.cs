#pragma checksum "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Areas\Admin\Views\MemberManage\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da493dc3ac61a0b7468ee7d50d2e9d1ec468125f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_MemberManage_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/MemberManage/Index.cshtml")]
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
#line 1 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\_ViewImports.cshtml"
using prjIHealth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\_ViewImports.cshtml"
using prjIHealth.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Areas\Admin\Views\MemberManage\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Areas\Admin\Views\MemberManage\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da493dc3ac61a0b7468ee7d50d2e9d1ec468125f", @"/Areas/Admin/Views/MemberManage/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a16e691bc2a8572590ef329eb9d410d52ff20929", @"/_ViewImports.cshtml")]
    public class Areas_Admin_Views_MemberManage_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<prjIHealth.Models.TMember>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Areas\Admin\Views\MemberManage\Index.cshtml"
   ViewData["Title"] = "iHeath後臺";
    Layout = "~/Areas/Admin/Admin_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Areas\Admin\Views\MemberManage\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Areas\Admin\Views\MemberManage\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Admin_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<link href=\"/css/PagedList.css\" rel=\"stylesheet\" type=\"text/css\" />\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <style>\r\n\r\n        #title {\r\n            font-weight: 800;\r\n            color: #599e32;\r\n            margin-left: 20vw;\r\n            margin-right: 20vw;\r\n        }\r\n        .col{\r\n            margin-bottom:10px;\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("<h2 id=\"title\">會員資料管理列表</h2>\r\n\r\n \r\n<hr />\r\n\r\n<div class=\"row \">\r\n    <div class=\"col\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da493dc3ac61a0b7468ee7d50d2e9d1ec468125f7331", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 36 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Areas\Admin\Views\MemberManage\Index.cshtml"
             using (@Html.BeginForm())
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                WriteLiteral("關鍵字 ");
#nullable restore
#line 38 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Areas\Admin\Views\MemberManage\Index.cshtml"
                 Write(Html.TextBox("txtKeyword"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <button class=\"btn \"><i class=\"fa fa-search\"></i></button>");
#nullable restore
#line 39 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Areas\Admin\Views\MemberManage\Index.cshtml"
                                                                      }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da493dc3ac61a0b7468ee7d50d2e9d1ec468125f9946", async() => {
                WriteLiteral("會員資料新增");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<table class=\"table\">\r\n    <thead class=\"thead-dark\">\r\n        <tr>\r\n               <th>\r\n                ");
#nullable restore
#line 52 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Areas\Admin\Views\MemberManage\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().FUserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 56 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Areas\Admin\Views\MemberManage\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().FBirthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 59 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Areas\Admin\Views\MemberManage\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().FGender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 62 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Areas\Admin\Views\MemberManage\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().FEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 65 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Areas\Admin\Views\MemberManage\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().FRegisterDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 68 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Areas\Admin\Views\MemberManage\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().FDisabled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                \r\n            </th>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 75 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Areas\Admin\Views\MemberManage\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().FAuthority.FAuthorityName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 81 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Areas\Admin\Views\MemberManage\Index.cshtml"
                
            foreach (var item in Model)
            {
               

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 87 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Areas\Admin\Views\MemberManage\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FUserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 90 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Areas\Admin\Views\MemberManage\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FBirthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td >\r\n                       ");
#nullable restore
#line 93 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Areas\Admin\Views\MemberManage\Index.cshtml"
                  Write(Html.DropDownListFor(m => @item.FGender, new SelectList(new[] {
                       new { Value = "", Text = "-- Choose YES or NO --" },
                       new { Value = "true", Text = "生理男性" },
                       new { Value = "false", Text = "生理女性" },  },
                           "Value",  "Text"  )));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                       \r\n                        ");
#nullable restore
#line 101 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Areas\Admin\Views\MemberManage\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 104 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Areas\Admin\Views\MemberManage\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FRegisterDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td  >\r\n                        ");
#nullable restore
#line 107 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Areas\Admin\Views\MemberManage\Index.cshtml"
                   Write(Html.DropDownListFor(m => @item.FDisabled, new SelectList(new[] {
                     new { Value = "", Text = "-- Choose YES or NO --" },
                     new { Value = "true", Text = "停權中" },
                     new { Value = "false", Text = "有效會員" },  },
                         "Value", "Text") ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 115 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Areas\Admin\Views\MemberManage\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FAuthority.FAuthorityName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da493dc3ac61a0b7468ee7d50d2e9d1ec468125f17299", async() => {
                WriteLiteral("<i class=\"fas fa-edit\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 118 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Areas\Admin\Views\MemberManage\Index.cshtml"
                                               WriteLiteral(item.FMemberId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da493dc3ac61a0b7468ee7d50d2e9d1ec468125f19604", async() => {
                WriteLiteral("<i class=\"fas fa-trash-alt\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 119 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Areas\Admin\Views\MemberManage\Index.cshtml"
                                                 WriteLiteral(item.FMemberId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 122 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Areas\Admin\Views\MemberManage\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
#nullable restore
#line 126 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Areas\Admin\Views\MemberManage\Index.cshtml"
Write(Html.PagedListPager(Model, page => Url.Action("Index", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(\'td select\').prop(\"disabled\", \"true\").css(\"width\", \"100px\").css(\"border\", \"none\").css(\"-webkit-appearance\", \"none\").css(\"background-color\",\"transparent\");\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<prjIHealth.Models.TMember>> Html { get; private set; }
    }
}
#pragma warning restore 1591
