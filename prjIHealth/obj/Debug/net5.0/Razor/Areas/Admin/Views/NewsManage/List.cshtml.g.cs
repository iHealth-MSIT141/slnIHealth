#pragma checksum "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\NewsManage\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "888846e0e0844da2c6ced7e9801a754e05c7b8dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_NewsManage_List), @"mvc.1.0.view", @"/Areas/Admin/Views/NewsManage/List.cshtml")]
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
#line 1 "C:\ispan\GitHub\0801n6\prjIHealth\_ViewImports.cshtml"
using prjIHealth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ispan\GitHub\0801n6\prjIHealth\_ViewImports.cshtml"
using prjIHealth.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\NewsManage\List.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\NewsManage\List.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"888846e0e0844da2c6ced7e9801a754e05c7b8dd", @"/Areas/Admin/Views/NewsManage/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a16e691bc2a8572590ef329eb9d410d52ff20929", @"/_ViewImports.cshtml")]
    public class Areas_Admin_Views_NewsManage_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<prjIHealth.Models.TNews>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("primary-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/News/Blog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link href=\"/css/PagedList.css\" rel=\"stylesheet\" />\r\n    <style>\r\n        #title {\r\n            font-weight: 800;\r\n            color: #599e32;\r\n            margin-left: 20vw;\r\n            margin-right: 20vw;\r\n        }\r\n    </style>\r\n");
            }
            );
#nullable restore
#line 16 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\NewsManage\List.cshtml"
   ViewData["Title"] = "iHeath後臺";
    Layout = "~/Areas/Admin/Admin_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2 id=""title"">專欄管理</h2>
<section class=""product spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-3 col-md-3"" style=""margin-left:0%"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "888846e0e0844da2c6ced7e9801a754e05c7b8dd7908", async() => {
                WriteLiteral("新增專欄");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-lg-3 col-md-3 \">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "888846e0e0844da2c6ced7e9801a754e05c7b8dd9339", async() => {
                WriteLiteral("專欄顯示");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-lg-3 col-md-3 \">\r\n                        <select name=\"selectCate\" id=\"selectCate\" class=\"custom-select\" style=\"width:150px\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "888846e0e0844da2c6ced7e9801a754e05c7b8dd10814", async() => {
                WriteLiteral("依類別篩選");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "888846e0e0844da2c6ced7e9801a754e05c7b8dd12731", async() => {
                WriteLiteral("運動健身");
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
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "888846e0e0844da2c6ced7e9801a754e05c7b8dd13917", async() => {
                WriteLiteral("食物營養");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "888846e0e0844da2c6ced7e9801a754e05c7b8dd15103", async() => {
                WriteLiteral("新冠疫情");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "888846e0e0844da2c6ced7e9801a754e05c7b8dd16289", async() => {
                WriteLiteral("教練專欄");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </select>
                    </div>
                    <div class=""col-lg-3 col-md-3"" style=""margin-right:0%"">
                        <button name=""btnReset"" id=""btnReset"" class=""site-btn"" style=""width:150px"">清空篩選</button>
                    </div>
                </div>
            </div>
        </div>
");
            WriteLiteral(@"        <div class=""row"">
            <div>
                <table class=""table"" style=""table-layout: fixed"">
                    <thead>
                        <tr style=""margin-left:auto"">
                            <th style=""margin-left:auto"">
                                標題
                            </th>
                            <th style=""margin-left:auto"">
                                時間
                            </th>
                            <th style=""margin-left:auto"">
                                內容
                            </th>
                            <th style=""margin-left:auto"">
                                縮圖
                            </th>
                            <th style=""margin-left:auto"">
                                類別
                            </th>
                            <th style=""margin-left:auto"">
                                
                            </th>
                            <th style=""margin-lef");
            WriteLiteral(@"t:auto"">
                                影片連結
                            </th>
                            <th style=""margin-left:auto"">
                                作者名稱
                            </th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody id=""ListZone"">
");
#nullable restore
#line 80 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\NewsManage\List.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 84 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\NewsManage\List.cshtml"
                               Write(item.FTitle.Substring(0, Math.Min(item.FTitle.Length, 10)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 87 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\NewsManage\List.cshtml"
                               Write(item.FNewsDate.Substring(0, Math.Min(item.FNewsDate.Length, 10)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n");
            WriteLiteral("                                    ");
#nullable restore
#line 91 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\NewsManage\List.cshtml"
                               Write(Html.Raw(@item.FContent.Substring(0, Math.Min(item.FContent.Length, 10))));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "888846e0e0844da2c6ced7e9801a754e05c7b8dd20925", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4107, "~/img/blog/", 4107, 11, true);
#nullable restore
#line 94 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\NewsManage\List.cshtml"
AddHtmlAttributeValue("", 4118, item.FThumbnailPath, 4118, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 97 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\NewsManage\List.cshtml"
                               Write(Html.DisplayFor(modelItem => item.FNewsCategory.FCategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 100 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\NewsManage\List.cshtml"
                               Write(Html.DisplayFor(modelItem => item.FViews));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 103 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\NewsManage\List.cshtml"
                               Write(Html.DisplayFor(modelItem => item.FVideoUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 106 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\NewsManage\List.cshtml"
                               Write(Html.DisplayFor(modelItem => item.FMemberId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 109 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\NewsManage\List.cshtml"
                               Write(Html.ActionLink("編輯", "Edit", new { id = item.FNewsId }, new { @class = "primary-btn" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <br />\r\n                                    ");
#nullable restore
#line 111 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\NewsManage\List.cshtml"
                               Write(Html.ActionLink("詳細", "Details", new { id = item.FNewsId }, new { @class = "primary-btn" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <br />\r\n                                    ");
#nullable restore
#line 113 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\NewsManage\List.cshtml"
                               Write(Html.ActionLink("刪除", "Delete", new { id = item.FNewsId },
                                                   new { onclick = "return confirm('確定要刪除嗎?')", @class = "primary-btn" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 117 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\NewsManage\List.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n                <div class=\"container\">\r\n                    <div style=\"margin-right:85%\">\r\n                        <div class=\"row\">\r\n\r\n");
#nullable restore
#line 124 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\NewsManage\List.cshtml"
                             using (Html.BeginForm())
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 126 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\NewsManage\List.cshtml"
                           Write(Html.TextBox("txtKeyword", null, null, new { @style = "width:150px" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <input type=\"submit\" value=\"輸入查詢\" class=\"site-btn\" style=\"width:150px\" />");
#nullable restore
#line 127 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\NewsManage\List.cshtml"
                                                                                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n                ");
#nullable restore
#line 131 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\NewsManage\List.cshtml"
           Write(Html.PagedListPager((IPagedList)ViewBag.OnePageOfNews, page => Url.Action("List", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $('#selectCate').on('change', CategoriesChange);
        $('#btnReset').on('click', ResetClick);
        //專欄類別篩選ajax
    async function CategoriesChange() {    
        $('#ListZone>tr').remove();
        const changeCate = selectCate.options[selectCate.selectedIndex].value;
        const response = await fetch(""");
#nullable restore
#line 145 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\NewsManage\List.cshtml"
                                 Write(Url.Content("~/Admin/NewsManage/SelectCategoryIDAPI"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""" + `?id=${changeCate}`);
        const datas = await response.json();
        console.log(datas);
        let tr = '';
        for (i = 0; i < datas.length; i++) {
            let fixViews = '';                 /*處理篩選資料後，空值會顯示null字樣問題*/
            let fixVideo = '';
            let fixTitle = '';
            let fixDate = '';
            let fixContent = '';
            if (datas[i].fViews == null) {
                fixViews = ''
            }
            else {
                fixViews = datas[i].fViews
            }
            if (datas[i].fVideoUrl == null) {
                fixVideo = ''
            }
            else {
                fixVideo = datas[i].fVideoUrl
            }
            if (datas[i].fTitle != null) {
                fixTitle = datas[i].fTitle.substr(0, 10);
            }
            if (datas[i].fNewsDate != null) {
                fixDate = datas[i].fNewsDate.substr(0, 10);
            }
            if (datas[i].fContent != null) {
                fixC");
                WriteLiteral(@"ontent = datas[i].fContent.substr(0, 10);
            }
             tr =`<tr>
             <td>${fixTitle}</td>
             <td style=""overflow: hidden; white-space: nowrap; text-overflow: ellipsis"">${fixDate}</td>
             <td style=""overflow: hidden; white-space: nowrap; text-overflow: ellipsis"">${fixContent}</td>
             <td>
             <img src=""/img/blog/${datas[i].fThumbnailPath}"" width=""100"" height=""80""/></td>
             <td>${datas[i].newsCategory.fCategoryName}</td>
             <td>${fixViews}</td>
             <td>${fixVideo}</td>
             <td>${datas[i].fMemberId}</td>
             <td>
             <a class=""primary-btn"" href=""/Admin/NewsManage/Edit/${datas[i].fNewsId}"">編輯</a>
             <a class=""primary-btn"" href=""/Admin/NewsManage/Details/${datas[i].fNewsId}"">詳細</a>
             <a class=""primary-btn"" href=""/Admin/NewsManage/Delete/${datas[i].fNewsId}"" onclick=""return confirm('確定要刪除嗎?')"">刪除</a>
             </td></tr>`
            $(`#ListZone`).append(tr)");
                WriteLiteral(";\r\n        }\r\n        };\r\n        //專欄類別篩選復歸ajax\r\n        async function ResetClick() {\r\n              $(\'#ListZone>tr\').remove();\r\n        const response = await fetch(\'");
#nullable restore
#line 197 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\NewsManage\List.cshtml"
                                 Write(Url.Content("~/Admin/NewsManage/ResetList"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"');
        const datas = await response.json();
        let tr = '';
            for (i = 0; i < datas.length; i++) {
                let fixViews = '';
                let fixVideo = '';
                let fixTitle = '';
                let fixDate = '';
                let fixContent = '';
                if (datas[i].fViews == null) {
                    fixViews = ''
                }
                else {
                    fixViews = datas[i].fViews
                }
                if (datas[i].fVideoUrl == null) {
                    fixVideo = ''
                }
                else {
                    fixVideo = datas[i].fVideoUrl
                }
                if (datas[i].fTitle != null) {
                    fixTitle = datas[i].fTitle.substr(0, 10);
                }
                if (datas[i].fNewsDate != null) {
                    fixDate = datas[i].fNewsDate.substr(0, 10);
                }
                if (datas[i].fContent != null) {
             ");
                WriteLiteral(@"       fixContent = datas[i].fContent.substr(0, 10);
                }
                tr = `<tr>
             <td>${fixTitle}</td>
             <td style=""overflow: hidden; white-space: nowrap; text-overflow: ellipsis"">${fixDate}</td>
             <td style=""overflow: hidden; white-space: nowrap; text-overflow: ellipsis"">${fixContent}</td>
             <td>
             <img src=""/img/blog/${datas[i].fThumbnailPath}"" width=""100"" height=""80""/></td>
             <td>${datas[i].newsCategory.fCategoryName}</td>
             <td>${fixViews}</td>
             <td>${fixVideo}</td>
             <td>${datas[i].fMemberId}</td>
             <td>
             <a class=""primary-btn"" href=""/Admin/NewsManage/Edit/${datas[i].fNewsId}"">編輯</a>
             <a class=""primary-btn"" href=""/Admin/NewsManage/Details/${datas[i].fNewsId}"">詳細</a>
             <a class=""primary-btn"" href=""/Admin/NewsManage/Delete/${datas[i].fNewsId}"" onclick=""return confirm('確定要刪除嗎?')"">刪除</a>
             </td></tr>`
                $(");
                WriteLiteral("`#ListZone`).append(tr);\r\n            }\r\n        };\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<prjIHealth.Models.TNews>> Html { get; private set; }
    }
}
#pragma warning restore 1591
