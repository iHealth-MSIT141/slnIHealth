#pragma checksum "C:\ispan\GitHub\0801n6\prjIHealth\Views\News\Blog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1723ffe50e72f75cdbe772674afd540699f240d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Blog), @"mvc.1.0.view", @"/Views/News/Blog.cshtml")]
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
#line 2 "C:\ispan\GitHub\0801n6\prjIHealth\Views\News\Blog.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ispan\GitHub\0801n6\prjIHealth\Views\News\Blog.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1723ffe50e72f75cdbe772674afd540699f240d", @"/Views/News/Blog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a16e691bc2a8572590ef329eb9d410d52ff20929", @"/_ViewImports.cshtml")]
    public class Views_News_Blog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.IEnumerable<prjIHealth.Models.TNews>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/News/Blog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:40px;height:40px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("blog__sidebar__recent__item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("blog__btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link href=\"/css/PagedList.css\" rel=\"stylesheet\" />\r\n");
            }
            );
#nullable restore
#line 8 "C:\ispan\GitHub\0801n6\prjIHealth\Views\News\Blog.cshtml"
   ViewData["Title"] = "Blog"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Breadcrumb Section Begin -->
<section class=""breadcrumb-section set-bg"" data-setbg=""/img/blog/banner_news.png"" id=""bannerTop"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 text-center"">
                <div class=""breadcrumb__text"">
");
            WriteLiteral("                    <h2 class=\"reveal_t1\">健康資訊</h2>\r\n                    <div class=\"breadcrumb__option reveal_t1\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1723ffe50e72f75cdbe772674afd540699f240d6641", async() => {
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
            WriteLiteral(@"
                        <span>News</span>
                    </div>
                </div>
            </div>

        </div>
    </div>
</section>
<!-- Breadcrumb Section End -->

<section class=""blog spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 col-md-5"">
                <div class=""blog__sidebar"">
                    <div class=""blog__sidebar__search"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1723ffe50e72f75cdbe772674afd540699f240d8173", async() => {
                WriteLiteral("\r\n                            <input type=\"text\" placeholder=\"Search...\" ");
#nullable restore
#line 37 "C:\ispan\GitHub\0801n6\prjIHealth\Views\News\Blog.cshtml"
                                                                  Write(Html.TextBox("txtKeyword"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <button type=\"submit\"><span class=\"icon_search\"></span></button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"blog__sidebar__item\" id=\"cateSe\">\r\n                        <h4>專欄分類</h4>\r\n                        <ul id=\"cate\">\r\n                            <li><a data-id=\"0\">所有顯示 (");
#nullable restore
#line 44 "C:\ispan\GitHub\0801n6\prjIHealth\Views\News\Blog.cshtml"
                                                Write(ViewBag.Category0Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</a></li>\r\n                            <li><a data-id=\"1\">運動健身 (");
#nullable restore
#line 45 "C:\ispan\GitHub\0801n6\prjIHealth\Views\News\Blog.cshtml"
                                                Write(ViewBag.Category1Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</a></li>\r\n                            <li><a data-id=\"2\">食物營養 (");
#nullable restore
#line 46 "C:\ispan\GitHub\0801n6\prjIHealth\Views\News\Blog.cshtml"
                                                Write(ViewBag.Category2Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</a></li>\r\n                            <li><a data-id=\"3\">新冠疫情 (");
#nullable restore
#line 47 "C:\ispan\GitHub\0801n6\prjIHealth\Views\News\Blog.cshtml"
                                                Write(ViewBag.Category3Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</a></li>\r\n                            <li><a data-id=\"4\">教練專欄 (");
#nullable restore
#line 48 "C:\ispan\GitHub\0801n6\prjIHealth\Views\News\Blog.cshtml"
                                                Write(ViewBag.Category4Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@")</a></li>
                            <!--專欄分類使用處-->
                        </ul>
                    </div>
                    <div class=""blog__sidebar__item"" id=""recentBlog"">
                        <h4>近期專欄</h4>
                        <div class=""blog__sidebar__recent"">
");
#nullable restore
#line 55 "C:\ispan\GitHub\0801n6\prjIHealth\Views\News\Blog.cshtml"
                              
                                IHealthContext db = new IHealthContext();
                                foreach (var item in db.TNews.OrderByDescending(t => t.FNewsDate).Take(3))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1723ffe50e72f75cdbe772674afd540699f240d12477", async() => {
                WriteLiteral("\r\n                                        <div class=\"blog__sidebar__recent__item__pic\">\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e1723ffe50e72f75cdbe772674afd540699f240d12869", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2825, "~/img/blog/", 2825, 11, true);
#nullable restore
#line 61 "C:\ispan\GitHub\0801n6\prjIHealth\Views\News\Blog.cshtml"
AddHtmlAttributeValue("", 2836, item.FThumbnailPath, 2836, 20, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"blog__sidebar__recent__item__text\">\r\n                                            <h6>\r\n                                                ");
#nullable restore
#line 65 "C:\ispan\GitHub\0801n6\prjIHealth\Views\News\Blog.cshtml"
                                           Write(item.FTitle.Substring(0, Math.Min(item.FContent.Length, 18)).Replace("<p>", "").Replace("<strong>", "").Replace("<br />", "").Replace("</p>", ""));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                <br />\r\n");
                WriteLiteral("                                            </h6>\r\n                                            <span>");
#nullable restore
#line 69 "C:\ispan\GitHub\0801n6\prjIHealth\Views\News\Blog.cshtml"
                                             Write(item.FNewsDate.Substring(0, Math.Min(item.FNewsDate.Length, 10)));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                        </div>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2609, "~/News/BlogDetail?id=", 2609, 21, true);
#nullable restore
#line 59 "C:\ispan\GitHub\0801n6\prjIHealth\Views\News\Blog.cshtml"
AddHtmlAttributeValue("", 2630, item.FNewsId, 2630, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 72 "C:\ispan\GitHub\0801n6\prjIHealth\Views\News\Blog.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <!--近期專欄使用處-->
                        </div>
                    </div>
                    <div class=""blog__sidebar__item"">
                        <!--<h4>快速搜尋</h4> 快速功能待施工中，預計改成熱門作者
                        <div class=""blog__sidebar__item__tags"">
                            <a href=""#"">健身</a>
                            <a href=""#"">飲食</a>
                            <a href=""#"">新冠</a>
                            <a href=""#"">健康</a>
                            <a href=""#"">食譜</a>-->
                            <!--插入快速搜尋標籤-->
                        <!--</div>-->
                    </div>
                </div>
            </div>
            <div class=""col-lg-8 col-md-7"">
                <div class=""row"" id=""BlogShow"">
");
#nullable restore
#line 92 "C:\ispan\GitHub\0801n6\prjIHealth\Views\News\Blog.cshtml"
                       //測試迴圈顯示
                        foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1723ffe50e72f75cdbe772674afd540699f240d18466", async() => {
                WriteLiteral("\r\n                                <div class=\"col-lg-6 col-md-6 col-sm-6\">\r\n                                    <div class=\"blog__item\">\r\n                                        <div class=\"blog__item__pic\">\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e1723ffe50e72f75cdbe772674afd540699f240d18985", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 5096, "~/img/blog/", 5096, 11, true);
#nullable restore
#line 99 "C:\ispan\GitHub\0801n6\prjIHealth\Views\News\Blog.cshtml"
AddHtmlAttributeValue("", 5107, item.FThumbnailPath, 5107, 20, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </div>
                                        <div class=""blog__item__text"">
                                            <ul>
                                                <li><i class=""fa fa-calendar-o""></i>");
#nullable restore
#line 103 "C:\ispan\GitHub\0801n6\prjIHealth\Views\News\Blog.cshtml"
                                                                               Write(item.FNewsDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
                WriteLiteral("                                                <li><i class=\"fa fa-comment-o\"></i>");
#nullable restore
#line 105 "C:\ispan\GitHub\0801n6\prjIHealth\Views\News\Blog.cshtml"
                                                                              Write(item.TNewsComments.Count());

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                            </ul>\r\n                                            <h5>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1723ffe50e72f75cdbe772674afd540699f240d21579", async() => {
#nullable restore
#line 107 "C:\ispan\GitHub\0801n6\prjIHealth\Views\News\Blog.cshtml"
                                                                                        Write(Html.DisplayFor(modelItem => item.FTitle));

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 5698, "~/News/BlogDetail?id=", 5698, 21, true);
#nullable restore
#line 107 "C:\ispan\GitHub\0801n6\prjIHealth\Views\News\Blog.cshtml"
AddHtmlAttributeValue("", 5719, item.FNewsId, 5719, 13, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</h5>\r\n                                            <p>\r\n");
                WriteLiteral("                                                ");
#nullable restore
#line 111 "C:\ispan\GitHub\0801n6\prjIHealth\Views\News\Blog.cshtml"
                                           Write(item.FContent.Substring(0, Math.Min(item.FContent.Length, 30)).Replace("<p>", "").Replace("<strong>", "").Replace("<br/>", "").Replace("</p>", ""));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </p>\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1723ffe50e72f75cdbe772674afd540699f240d24011", async() => {
                    WriteLiteral("READ MORE <span class=\"arrow_right\"></span>");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 6402, "~/News/BlogDetail?id=", 6402, 21, true);
#nullable restore
#line 113 "C:\ispan\GitHub\0801n6\prjIHealth\Views\News\Blog.cshtml"
AddHtmlAttributeValue("", 6423, item.FNewsId, 6423, 13, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral("                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4797, "~/News/BlogDetail?id=", 4797, 21, true);
#nullable restore
#line 95 "C:\ispan\GitHub\0801n6\prjIHealth\Views\News\Blog.cshtml"
AddHtmlAttributeValue("", 4818, item.FNewsId, 4818, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 121 "C:\ispan\GitHub\0801n6\prjIHealth\Views\News\Blog.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-12\">\r\n                        <div class=\"product__pagination blog__pagination\">\r\n                            ");
#nullable restore
#line 126 "C:\ispan\GitHub\0801n6\prjIHealth\Views\News\Blog.cshtml"
                       Write(Html.PagedListPager((IPagedList)ViewBag.onePageOfBlogs, page => Url.Action("Blog", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- Blog Section End -->\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>

        $('#cate').on('click', CategorySelect)

        let cateID = 0;
        $(""#cate"").find(""a"").click(function (event) {
            event.preventDefault();
            cateID = $(this).attr(""data-id"");
            console.log(this);
        })
        //類別篩選api，尚無法恢復分頁套件顯示
        async function CategorySelect() {
            $('#BlogShow').empty();
            if (cateID == 0) {
                const response = await fetch('");
#nullable restore
#line 151 "C:\ispan\GitHub\0801n6\prjIHealth\Views\News\Blog.cshtml"
                                         Write(Url.Content("~/News/BlogSelectCategoryAPI"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"');
                const datas = await response.json();
                let tr = '';
                for (i = 0; i < datas.length; i++) {
                    if (datas[i].fContent != null) {
                        fixContent = datas[i].fContent.substr(0, 30);
                    }
                    tr = `<a href=""/News/BlogDetail?id=${datas[i].fNewsId}""><div class=""col-lg-6 col-md-6 col-sm-6"">
                  <div class=""blog__item""><div class=""blog__item__pic""><img src=""/img/blog/${datas[i].fThumbnailPath}"" />
                  </div><div class=""blog__item__text""><ul>
                  <li><i class=""fa fa-calendar-o""></i>${datas[i].fNewsDate}</li>
                  <li><i class=""fa fa-comment-o""></i> 5</li>
                  </ul>
                  </a>
                  <h5><a href=""/News/BlogDetail?id=${datas[i].fNewsId}""></a>
                  <a href=""/News/BlogDetail?id=${datas[i].fNewsId}"">${datas[i].fTitle}</a></h5>
                  <p>
                  ${fixContent}
        ");
                WriteLiteral(@"          </p>
                  <a href=""/News/BlogDetail?id=${datas[i].fNewsId}"" class=""blog__btn"">READ MORE <span class=""arrow_right""></span></a>
                  </div>
                  </div>
                  </div>
                  </a>`
                    $('#BlogShow').append(tr);
                }
            }
            if (cateID != 0) {
            const response = await fetch('");
#nullable restore
#line 179 "C:\ispan\GitHub\0801n6\prjIHealth\Views\News\Blog.cshtml"
                                     Write(Url.Content("~/News/BlogSelectCategoryAPI"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' + `?id=${cateID}`);
            //console.log(response);
            const datas = await response.json();
            //console.log(datas);
            let tr = '';
                    for (i = 0; i < datas.length; i++) {
                        if (datas[i].fContent != null) {
                            fixContent = datas[i].fContent.substr(0, 30);
                        }
                        tr = `<a href=""/News/BlogDetail?id=${datas[i].fNewsId}""><div class=""col-lg-6 col-md-6 col-sm-6"">
                  <div class=""blog__item""><div class=""blog__item__pic""><img src=""/img/blog/${datas[i].fThumbnailPath}"" />
                  </div><div class=""blog__item__text""><ul>
                  <li><i class=""fa fa-calendar-o""></i>${datas[i].fNewsDate}</li>
                  <li><i class=""fa fa-comment-o""></i> 5</li>
                  </ul>
                  </a>
                  <h5><a href=""/News/BlogDetail?id=${datas[i].fNewsId}""></a>
                  <a href=""/News/BlogDetail?id=${datas[i].");
                WriteLiteral(@"fNewsId}"">${datas[i].fTitle}</a></h5>
                  <p>
                  ${fixContent}
                  </p>
                  <a href=""/News/BlogDetail?id=${datas[i].fNewsId}"" class=""blog__btn"">READ MORE <span class=""arrow_right""></span></a>
                  </div>
                  </div>
                  </div>
                  </a>`
                        $('#BlogShow').append(tr);
                        console.log(""A"");
                    }
            }
        }
        async function CommentCountsN() {

        }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.IEnumerable<prjIHealth.Models.TNews>> Html { get; private set; }
    }
}
#pragma warning restore 1591