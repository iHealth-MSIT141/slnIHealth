#pragma checksum "C:\ispan\0808\prjIHealth\Views\News\LoadComment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be695cf35065ab4944d02c66f0a47a7d7935ef11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_LoadComment), @"mvc.1.0.view", @"/Views/News/LoadComment.cshtml")]
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
#line 1 "C:\ispan\0808\prjIHealth\_ViewImports.cshtml"
using prjIHealth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ispan\0808\prjIHealth\_ViewImports.cshtml"
using prjIHealth.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be695cf35065ab4944d02c66f0a47a7d7935ef11", @"/Views/News/LoadComment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a16e691bc2a8572590ef329eb9d410d52ff20929", @"/_ViewImports.cshtml")]
    public class Views_News_LoadComment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<prjIHealth.ViewModels.CNewsCommentViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LoadComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border:dotted 3px green; margin-top:5px; padding:5px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    <!--<form asp-action=\"ReplyComment\" enctype=\"multipart/form-data\" id=\"blogForm\">-->\r\n");
            WriteLiteral(@"    <!--<input type=""hidden"" name=""FNewsId"" id=""testInput""/>
        <br />
        <label>留言回覆</label>
        <textarea id=""FNewsReply"" name=""FNewsReply""></textarea>
        <br />
        <input id=""btnSubmit"" type=""submit"" value=""發送回覆"" class=""site-btn"" />
    </form>-->
    <div>共有 ");
#nullable restore
#line 18 "C:\ispan\0808\prjIHealth\Views\News\LoadComment.cshtml"
       Write(ViewBag.CommentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 篇留言</div>\r\n");
#nullable restore
#line 19 "C:\ispan\0808\prjIHealth\Views\News\LoadComment.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be695cf35065ab4944d02c66f0a47a7d7935ef115121", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 967, "\"", 988, 1);
#nullable restore
#line 22 "C:\ispan\0808\prjIHealth\Views\News\LoadComment.cshtml"
WriteAttributeValue("", 975, item.FNewsId, 975, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"FNewsId\" />\r\n            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1041, "\"", 1064, 1);
#nullable restore
#line 23 "C:\ispan\0808\prjIHealth\Views\News\LoadComment.cshtml"
WriteAttributeValue("", 1049, item.FMemberId, 1049, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"FMemberId\" />\r\n            <label>會員名稱：</label>\r\n            <label");
                BeginWriteAttribute("value", " value=\"", 1139, "\"", 1147, 0);
                EndWriteAttribute();
                WriteLiteral(" readonly=\"readonly\">");
#nullable restore
#line 25 "C:\ispan\0808\prjIHealth\Views\News\LoadComment.cshtml"
                                           Write(item.MemberName.FMemberName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            <br />\r\n            <label>回覆內容：</label>\r\n            <label id=\"FNewsReply\" name=\"FNewsReply\" readonly=\"readonly\">");
#nullable restore
#line 28 "C:\ispan\0808\prjIHealth\Views\News\LoadComment.cshtml"
                                                                    Write(item.FNewsReply);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
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
            WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\ispan\0808\prjIHealth\Views\News\LoadComment.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
            WriteLiteral("\r\n<script>\r\n\r\n");
            WriteLiteral(@"

    //let testInput = $('#testInput');
    //var formData = new FormData(document.querySelector(""#blogForm""));
    //fetch(""/News/BlogDetail"", { body: formData, method: ""Post"" }).then(Response => Response.text()).(data => {
    //    alert(data);
    //    $('#testInput').val(data);

    //});


</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<prjIHealth.ViewModels.CNewsCommentViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
