#pragma checksum "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Member\OrderList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "497842feb75a8fdd0513b5f19f5a93e23f724814"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_OrderList), @"mvc.1.0.view", @"/Views/Member/OrderList.cshtml")]
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
#nullable restore
#line 2 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Member\OrderList.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Member\OrderList.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"497842feb75a8fdd0513b5f19f5a93e23f724814", @"/Views/Member/OrderList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a16e691bc2a8572590ef329eb9d410d52ff20929", @"/_ViewImports.cshtml")]
    public class Views_Member_OrderList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<prjIHealth.ViewModels.COrderViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Shopping/ShowShoppingMall"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/member/edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Diary/DiaryMain"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Member/OrderList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Student/CandidateList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Student/CourseList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Student/ViewCourseCalendar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Problem/CheckReply"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Coach/CreateResume"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("blog__btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Member\OrderList.cshtml"
  
    ViewData["Title"] = "OrderList";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <link href=""/css//PagedList.css"" rel=""stylesheet"" />
    <style>
        .blog__btn {
            display: inline-block;
            font-size: 14px;
            color: #1c1c1c;
            text-transform: uppercase;
            letter-spacing: 1px;
            border: 1px solid #b2b2b2;
            padding: 14px 20px 12px;
            border-radius: 25px;
        }

            .blog__btn:visited {
                color: #1c1c1c;
            }

            .blog__btn:hover {
                color: black;
                font-weight: 800;
            }

            .blog__btn:active {
                color: black;
                font-weight: 800;
            }

        .sidebar__item ul li a {
            border: dashed 2px #7fad39;
            border-top: none;
            border-left: none;
            border-right: none;
            padding-left: 1vw;
            margin-right: 8vw;
            margin-bottom: 1vh;
        }
    </style>
");
            }
            );
            WriteLiteral("\r\n");
            WriteLiteral("<section class=\"breadcrumb-section set-bg\" data-setbg=\"/img/banner/banner_mem.png\" id=\"bannerTop\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-12 text-center\">\r\n                <div class=\"breadcrumb__text\">\r\n");
            WriteLiteral("                    <h2 class=\"reveal_t1\">訂單檢視</h2>\r\n                    <div class=\"breadcrumb__option reveal_t1\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "497842feb75a8fdd0513b5f19f5a93e23f7248148898", async() => {
                WriteLiteral("Home");
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
            WriteLiteral("\r\n                        <span>Shopping</span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<section class=\"product spad\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
            WriteLiteral(@"            <div class=""col-lg-3 col-md-5 reveal_b1"">
                <div class=""sidebar"" style=""position:sticky;top:150px;"">
                    <div class=""sidebar__item"">
                        <h4>會員專區</h4>
                        <ul>

                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "497842feb75a8fdd0513b5f19f5a93e23f72481410573", async() => {
                WriteLiteral("個人資料");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "497842feb75a8fdd0513b5f19f5a93e23f72481411684", async() => {
                WriteLiteral("飲食日誌");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "497842feb75a8fdd0513b5f19f5a93e23f72481412795", async() => {
                WriteLiteral("訂單查詢");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "497842feb75a8fdd0513b5f19f5a93e23f72481413906", async() => {
                WriteLiteral("候選教練");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "497842feb75a8fdd0513b5f19f5a93e23f72481415017", async() => {
                WriteLiteral("課程列表");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "497842feb75a8fdd0513b5f19f5a93e23f72481416128", async() => {
                WriteLiteral("課程行事曆");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "497842feb75a8fdd0513b5f19f5a93e23f72481417240", async() => {
                WriteLiteral("客服記錄");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n\r\n                        </ul>\r\n                        <br />\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "497842feb75a8fdd0513b5f19f5a93e23f72481418414", async() => {
                WriteLiteral("<span class=\"arrow_right\"></span>教練專區");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-9 col-md-7\" style=\"height:400px\">\r\n");
            WriteLiteral(@"                <div class=""col-lg-12"">
                    <div class=""shoping__cart__table"">

                        <table style=""table-layout:fixed"">
                            <thead>
                                <tr>
                                    <th style=""margin-left:auto"">
                                        ");
#nullable restore
#line 100 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Member\OrderList.cshtml"
                                   Write(Html.DisplayNameFor(model => model.FContact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th style=\"margin-left:auto\">\r\n                                        ");
#nullable restore
#line 103 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Member\OrderList.cshtml"
                                   Write(Html.DisplayNameFor(model => model.FPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th style=\"margin-left:auto\">\r\n                                        ");
#nullable restore
#line 106 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Member\OrderList.cshtml"
                                   Write(Html.DisplayNameFor(model => model.FAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th style=\"margin-left:auto\">\r\n                                        ");
#nullable restore
#line 109 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Member\OrderList.cshtml"
                                   Write(Html.DisplayNameFor(model => model.FDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th style=\"margin-left:auto\">\r\n                                        ");
#nullable restore
#line 112 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Member\OrderList.cshtml"
                                   Write(Html.DisplayNameFor(model => model.FPaymentCategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th style=\"margin-left:auto\">\r\n                                        ");
#nullable restore
#line 115 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Member\OrderList.cshtml"
                                   Write(Html.DisplayNameFor(model => model.FStatusNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th style=\"margin-left:auto\">\r\n                                        ");
#nullable restore
#line 118 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Member\OrderList.cshtml"
                                   Write(Html.DisplayNameFor(model => model.FRemarks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th></th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody id=\"ListPro\">\r\n");
#nullable restore
#line 124 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Member\OrderList.cshtml"
                                  

                                    foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td style=\"margin-left: auto;text-align:center;\">\r\n                                                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 5247, "\"", 5300, 1);
#nullable restore
#line 130 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Member\OrderList.cshtml"
WriteAttributeValue(" ", 5255, Html.DisplayFor(modelItem => item.FOrderId), 5256, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"FOrderId\" name=\"FOrderId\" />\r\n                                                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 5404, "\"", 5458, 1);
#nullable restore
#line 131 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Member\OrderList.cshtml"
WriteAttributeValue(" ", 5412, Html.DisplayFor(modelItem => item.FMemberId), 5413, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"FMemberId\" name=\"FMemberId\" />\r\n                                                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 5564, "\"", 5622, 1);
#nullable restore
#line 132 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Member\OrderList.cshtml"
WriteAttributeValue(" ", 5572, Html.DisplayFor(modelItem => item.FStatusNumber), 5573, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"FStatusNumber\" name=\"FStatusNumber\" />\r\n                                                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 5736, "\"", 5802, 1);
#nullable restore
#line 133 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Member\OrderList.cshtml"
WriteAttributeValue(" ", 5744, Html.DisplayFor(modelItem => item.fstatus.FStatusNumber), 5745, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"fstatus.FStatusNumber\" name=\"fstatus.FStatusNumber\" />\r\n                                                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 5932, "\"", 6004, 1);
#nullable restore
#line 134 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Member\OrderList.cshtml"
WriteAttributeValue(" ", 5940, Html.DisplayFor(modelItem => item.fPayment.FPaymentCategoryId), 5941, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"fPayment.FPaymentCategoryId\" name=\"fPayment.FPaymentCategoryId\" />\r\n                                                ");
#nullable restore
#line 135 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Member\OrderList.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.FContact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td style=\"margin-left: auto; text-align: center; overflow: hidden; white-space: nowrap; text-overflow: ellipsis;\"");
            BeginWriteAttribute("title", " title=\"", 6381, "\"", 6432, 1);
#nullable restore
#line 137 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Member\OrderList.cshtml"
WriteAttributeValue(" ", 6389, Html.DisplayFor(modelItem => item.FPhone), 6390, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                ");
#nullable restore
#line 138 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Member\OrderList.cshtml"
                                           Write(item.FPhone.Substring(0, Math.Min(item.FPhone.Length, 6)));

#line default
#line hidden
#nullable disable
            WriteLiteral("...\r\n                                            </td>\r\n                                            <td style=\"margin-left: auto; text-align: center;\"");
            BeginWriteAttribute("title", " title=\"", 6692, "\"", 6745, 1);
#nullable restore
#line 140 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Member\OrderList.cshtml"
WriteAttributeValue(" ", 6700, Html.DisplayFor(modelItem => item.FAddress), 6701, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                ");
#nullable restore
#line 141 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Member\OrderList.cshtml"
                                           Write(item.FAddress.Substring(0, Math.Min(item.FAddress.Length, 5)));

#line default
#line hidden
#nullable disable
            WriteLiteral("...\r\n                                            </td>\r\n                                            <td style=\"margin-left: auto; text-align: center;\">\r\n                                                ");
#nullable restore
#line 144 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Member\OrderList.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.FDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td style=\"margin-left: auto; text-align: center;\">\r\n                                                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 7319, "\"", 7381, 1);
#nullable restore
#line 147 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Member\OrderList.cshtml"
WriteAttributeValue("", 7327, Html.DisplayFor(modelItem => item.FPaymentCategoryId), 7327, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"FPaymentCategoryId\" name=\"FPaymentCategoryId\" />\r\n                                                ");
#nullable restore
#line 148 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Member\OrderList.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.fPayment.FPaymentCategory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td style=\"margin-left: auto; text-align: center;\">\r\n                                                ");
#nullable restore
#line 151 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Member\OrderList.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.fstatus.FStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td style=\"margin-left: auto; text-align: center;\"");
            BeginWriteAttribute("title", " title=\"", 7942, "\"", 7995, 1);
#nullable restore
#line 153 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Member\OrderList.cshtml"
WriteAttributeValue(" ", 7950, Html.DisplayFor(modelItem => item.FRemarks), 7951, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                ");
#nullable restore
#line 154 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Member\OrderList.cshtml"
                                           Write(item.FRemarks.Substring(0, Math.Min(item.FRemarks.Length, 10)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td style=\"margin-left: auto; text-align: center;\">\r\n                                                ");
#nullable restore
#line 157 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Member\OrderList.cshtml"
                                           Write(Html.ActionLink("訂單明細", "OrderdetailList", new { id = item.FOrderId },
                                                  new { @class = "primary-btn cart-btn" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 161 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Member\OrderList.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                        <div style=\"text-align:center\">\r\n                            ");
#nullable restore
#line 166 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Member\OrderList.cshtml"
                       Write(Html.PagedListPager((IPagedList)ViewBag.OnePageOfPro, page => Url.Action("OrderList", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<prjIHealth.ViewModels.COrderViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
