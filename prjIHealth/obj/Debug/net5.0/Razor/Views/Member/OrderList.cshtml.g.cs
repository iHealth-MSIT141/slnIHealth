#pragma checksum "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Views\Member\OrderList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c3fadba2b3400eda66dce16a022b362b2e90fc6"
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
#line 2 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Views\Member\OrderList.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Views\Member\OrderList.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c3fadba2b3400eda66dce16a022b362b2e90fc6", @"/Views/Member/OrderList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a16e691bc2a8572590ef329eb9d410d52ff20929", @"/_ViewImports.cshtml")]
    public class Views_Member_OrderList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<prjIHealth.ViewModels.COrderViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Shopping/ShowShoppingMall"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/member/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Diary/DiaryMain"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Member/OrderList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Student/CandidateList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Student/CourseList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Student/ViewCourseCalendar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Problem/CheckReply"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Coach/CreateResume"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("blog__btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Views\Member\OrderList.cshtml"
  
    ViewData["Title"] = "OrderList";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <link href=""/css//PagedList.css"" rel=""stylesheet"" />
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css"" integrity=""sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
    <style>
        /*會員專區導覽列*/
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
                border: 1px solid #4F6C24;
                color: #4F6C24;
            }

            .blog__btn:active {
                color: black;
                font-weight: 800;
            }

        .sideba");
                WriteLiteral(@"r__item ul li a {
            margin-bottom: 1vh;
        }

        .sidebar__item {
            border: 1px solid lightgray;
            box-shadow: 2px 2px 5px lightgray;
            padding: 20px;
            margin-right: 30px;
            margin-bottom: 20px;
        }

            .sidebar__item h5 {
                text-align: center;
                margin-bottom: 20px;
                padding: 10px;
                background-color: #4F6C24;
                color: white;
            }

            .sidebar__item li:hover {
                transition: .2s;
                background-color: #EFF5E6;
            }

            .sidebar__item i {
                margin-right: 5px;
            }

        .liThis {
            background-color: #EFEDED;
        }

        .btn-success {
            background-color: #7FAD39;
            width:100px;
            color: white;
            border: none;
          
        }
    </style>
");
            }
            );
            WriteLiteral("\r\n");
            WriteLiteral("<section class=\"breadcrumb-section set-bg\" data-setbg=\"/img/banner/banner_mem.png\" id=\"bannerTop\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-12 text-center\">\r\n                <div class=\"breadcrumb__text\">\r\n");
            WriteLiteral("                    <h2 class=\"reveal_t1\">訂單查詢</h2>\r\n                    <div class=\"breadcrumb__option reveal_t1\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c3fadba2b3400eda66dce16a022b362b2e90fc610297", async() => {
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
                        <h5>會員專區</h5>
                        <ul>
                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c3fadba2b3400eda66dce16a022b362b2e90fc611971", async() => {
                WriteLiteral("<i class=\"fa-solid fa-user-pen col-2\"></i>個人資料");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c3fadba2b3400eda66dce16a022b362b2e90fc613209", async() => {
                WriteLiteral("<i class=\"fa-solid fa-utensils col-2\"></i>飲食日誌");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                            <li class=\"liThis\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c3fadba2b3400eda66dce16a022b362b2e90fc614464", async() => {
                WriteLiteral("<i class=\"fa-solid fa-cart-shopping col-2\"></i>訂單查詢");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c3fadba2b3400eda66dce16a022b362b2e90fc615707", async() => {
                WriteLiteral("<i class=\"fa-solid fa-heart col-2\"></i>候選教練");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c3fadba2b3400eda66dce16a022b362b2e90fc616942", async() => {
                WriteLiteral("<i class=\"fa-solid fa-dumbbell col-2\"></i>課程列表");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c3fadba2b3400eda66dce16a022b362b2e90fc618180", async() => {
                WriteLiteral("<i class=\"fa-solid fa-calendar-day col-2\"></i>課程行事曆");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c3fadba2b3400eda66dce16a022b362b2e90fc619423", async() => {
                WriteLiteral("<i class=\"fa-solid fa-comments col-2\"></i>客服記錄");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                        </ul>\r\n                    </div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c3fadba2b3400eda66dce16a022b362b2e90fc620712", async() => {
                WriteLiteral("<span class=\"arrow_right\"></span>教練專區");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-9 col-md-7\">\r\n");
            WriteLiteral(@"                <div class=""col-lg-12"">
                    <div class=""shoping__cart__table"">
                        <table class=""table"" style=""table-layout:fixed"">
                            <thead class=""thead-dark"">
                                <tr>
                                    <th style=""margin-left:auto"">
                                        ");
#nullable restore
#line 129 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Views\Member\OrderList.cshtml"
                                   Write(Html.DisplayNameFor(model => model.FOrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th style=\"margin-left:auto\">\r\n                                        ");
#nullable restore
#line 132 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Views\Member\OrderList.cshtml"
                                   Write(Html.DisplayNameFor(model => model.FDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th style=\"margin-left:auto\">\r\n                                        ");
#nullable restore
#line 135 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Views\Member\OrderList.cshtml"
                                   Write(Html.DisplayNameFor(model => model.FContact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th class=\"col-lg-2\" style=\"margin-left:auto\">\r\n                                        ");
#nullable restore
#line 138 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Views\Member\OrderList.cshtml"
                                   Write(Html.DisplayNameFor(model => model.FPaymentCategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th style=\"margin-left:auto;width:20%\">\r\n                                        ");
#nullable restore
#line 141 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Views\Member\OrderList.cshtml"
                                   Write(Html.DisplayNameFor(model => model.FStatusNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th class=\"col-lg-2\"></th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody id=\"ListPro\">\r\n");
#nullable restore
#line 147 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Views\Member\OrderList.cshtml"
                                  

                                    foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td style=\"margin-left: auto;text-align:center;\">\r\n                                                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 6289, "\"", 6342, 1);
#nullable restore
#line 153 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Views\Member\OrderList.cshtml"
WriteAttributeValue(" ", 6297, Html.DisplayFor(modelItem => item.FOrderId), 6298, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"FOrderId\" name=\"FOrderId\" />\r\n                                                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 6446, "\"", 6500, 1);
#nullable restore
#line 154 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Views\Member\OrderList.cshtml"
WriteAttributeValue(" ", 6454, Html.DisplayFor(modelItem => item.FMemberId), 6455, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"FMemberId\" name=\"FMemberId\" />\r\n                                                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 6606, "\"", 6664, 1);
#nullable restore
#line 155 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Views\Member\OrderList.cshtml"
WriteAttributeValue(" ", 6614, Html.DisplayFor(modelItem => item.FStatusNumber), 6615, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"FStatusNumber\" name=\"FStatusNumber\" />\r\n                                                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 6778, "\"", 6844, 1);
#nullable restore
#line 156 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Views\Member\OrderList.cshtml"
WriteAttributeValue(" ", 6786, Html.DisplayFor(modelItem => item.fstatus.FStatusNumber), 6787, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"fstatus.FStatusNumber\" name=\"fstatus.FStatusNumber\" />\r\n                                                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 6974, "\"", 7046, 1);
#nullable restore
#line 157 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Views\Member\OrderList.cshtml"
WriteAttributeValue(" ", 6982, Html.DisplayFor(modelItem => item.fPayment.FPaymentCategoryId), 6983, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"fPayment.FPaymentCategoryId\" name=\"fPayment.FPaymentCategoryId\" />\r\n                                                ");
#nullable restore
#line 158 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Views\Member\OrderList.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.FOrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td style=\"margin-left: auto; text-align: center;\">\r\n                                                ");
#nullable restore
#line 161 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Views\Member\OrderList.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.FDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td style=\"margin-left: auto; text-align: center;\"");
            BeginWriteAttribute("title", " title=\"", 7598, "\"", 7651, 1);
#nullable restore
#line 163 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Views\Member\OrderList.cshtml"
WriteAttributeValue(" ", 7606, Html.DisplayFor(modelItem => item.FContact), 7607, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                ");
#nullable restore
#line 164 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Views\Member\OrderList.cshtml"
                                           Write(item.FContact);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td style=\"margin-left: auto; text-align: center;\">\r\n                                                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 7935, "\"", 7997, 1);
#nullable restore
#line 167 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Views\Member\OrderList.cshtml"
WriteAttributeValue("", 7943, Html.DisplayFor(modelItem => item.FPaymentCategoryId), 7943, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"FPaymentCategoryId\" name=\"FPaymentCategoryId\" />\r\n                                                ");
#nullable restore
#line 168 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Views\Member\OrderList.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.fPayment.FPaymentCategory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td style=\"margin-left: auto; text-align: center;\">\r\n                                                ");
#nullable restore
#line 171 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Views\Member\OrderList.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.fstatus.FStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td style=\"margin-left: auto; text-align: center;\">\r\n                                                ");
#nullable restore
#line 174 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Views\Member\OrderList.cshtml"
                                           Write(Html.ActionLink("訂單明細", "OrderdetailList", new { id = item.FOrderId },
                                                  new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 178 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Views\Member\OrderList.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                        <div style=\"text-align:center\">\r\n                            ");
#nullable restore
#line 183 "C:\ispan\GitHub\slnIHealth\0808\prjIHealth\Views\Member\OrderList.cshtml"
                       Write(Html.PagedListPager((IPagedList)ViewBag.OnePageOfPro, page => Url.Action("OrderList", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
