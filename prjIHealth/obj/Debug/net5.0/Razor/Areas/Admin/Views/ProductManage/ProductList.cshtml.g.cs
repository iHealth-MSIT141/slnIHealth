#pragma checksum "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\ProductManage\ProductList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8b69c845a523b9cbb80db54de7c0935df122ce1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ProductManage_ProductList), @"mvc.1.0.view", @"/Areas/Admin/Views/ProductManage/ProductList.cshtml")]
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
#line 3 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\ProductManage\ProductList.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\ProductManage\ProductList.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8b69c845a523b9cbb80db54de7c0935df122ce1", @"/Areas/Admin/Views/ProductManage/ProductList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a16e691bc2a8572590ef329eb9d410d52ff20929", @"/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ProductManage_ProductList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<prjIHealth.ViewModels.CProductViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "5", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:30%;height:30%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("primary-btn cart-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\ProductManage\ProductList.cshtml"
  
    ViewData["Title"] = "ProductList";
    Layout = "~/Areas/Admin/Admin_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <link href=""/css//PagedList.css"" rel=""stylesheet"" />
    <style>
        .btn-light {
            background-color: #DFEACE !important;
            color: black;
        }
        .btn-success {
            background-color: #7FAD39;
            color: white;
            border: none;
        }
        table.table td{
            vertical-align:middle;
            text-align:center;
        }
        .selectbox{
            margin-bottom:5%;
            margin-left:-10%;
        }
        #title {
            font-weight: 800;
            color: #599e32;
            margin-left: 20vw;
            margin-right: 20vw;
        }
    </style>
");
            }
            );
            WriteLiteral(@"
<h2 id=""title"">產品管理</h2>


<hr />
<div class=""container"">

    <div class=""col-lg-12"">
        <div class=""shoping__cart__table"">
            <div class=""col-lg-4"">
                <select id=""catrgorysearch"" name=""catrgorysearch"" class=""custom-select selectbox"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8b69c845a523b9cbb80db54de7c0935df122ce17720", async() => {
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
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8b69c845a523b9cbb80db54de7c0935df122ce19628", async() => {
                WriteLiteral("乳清蛋白");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8b69c845a523b9cbb80db54de7c0935df122ce110805", async() => {
                WriteLiteral("健康食品");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8b69c845a523b9cbb80db54de7c0935df122ce111983", async() => {
                WriteLiteral("運動用品");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8b69c845a523b9cbb80db54de7c0935df122ce113161", async() => {
                WriteLiteral("男裝");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8b69c845a523b9cbb80db54de7c0935df122ce114337", async() => {
                WriteLiteral("女裝");
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
            WriteLiteral(@"
                </select>
            </div>
            <table class=""table"" style=""table-layout: fixed"">
                <thead class=""thead-dark"">
                    <tr>
                        <th class=""shoping__product col-lg-3"" style=""text-align: left; margin-left: auto"">
                            ");
#nullable restore
#line 61 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\ProductManage\ProductList.cshtml"
                       Write(Html.DisplayNameFor(model => model.FProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th class=\"col-lg-1\" style=\"margin-left:auto\">\r\n                            ");
#nullable restore
#line 64 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\ProductManage\ProductList.cshtml"
                       Write(Html.DisplayNameFor(model => model.FCategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th class=\"col-lg-1\" style=\"margin-left:auto\">\r\n                            ");
#nullable restore
#line 67 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\ProductManage\ProductList.cshtml"
                       Write(Html.DisplayNameFor(model => model.FUnitprice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th class=\"col-lg-3\" style=\"margin-left:auto\">\r\n                            ");
#nullable restore
#line 70 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\ProductManage\ProductList.cshtml"
                       Write(Html.DisplayNameFor(model => model.FDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th style=\"margin-left:auto\">\r\n                            ");
#nullable restore
#line 73 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\ProductManage\ProductList.cshtml"
                       Write(Html.DisplayNameFor(model => model.FVisible));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th></th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody id=\"ListPro\">\r\n");
#nullable restore
#line 80 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\ProductManage\ProductList.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <tr>
                            <td class=""shoping__cart__item "" style=""margin-left: auto;vertical-align:middle; text-align: left; overflow: hidden; white-space: nowrap; text-overflow: ellipsis;"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a8b69c845a523b9cbb80db54de7c0935df122ce118495", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3168, "~/img/product/", 3168, 14, true);
#nullable restore
#line 84 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\ProductManage\ProductList.cshtml"
AddHtmlAttributeValue("", 3182, item.FCoverImage, 3182, 17, false);

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
            WriteLiteral(" <span>");
#nullable restore
#line 84 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\ProductManage\ProductList.cshtml"
                                                                                                             Write(Html.DisplayFor(modelItem => item.FProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </td>\r\n                            <td style=\"margin-left: auto; text-align: center; vertical-align: middle; \">\r\n                                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 3490, "\"", 3546, 1);
#nullable restore
#line 87 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\ProductManage\ProductList.cshtml"
WriteAttributeValue(" ", 3498, Html.DisplayFor(modelItem => item.FCategoryId), 3499, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"FCategoryId\" name=\"FCategoryId\" />\r\n                                ");
#nullable restore
#line 88 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\ProductManage\ProductList.cshtml"
                           Write(Html.DisplayFor(modelItem => item.FCategoryName.FCategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td style=\"margin-left: auto;vertical-align:middle; \">\r\n                                ");
#nullable restore
#line 91 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\ProductManage\ProductList.cshtml"
                           Write(Html.DisplayFor(modelItem => item.FUnitprice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td style=\"margin-left: auto; vertical-align: middle; \"");
            BeginWriteAttribute("title", "title=\"", 4002, "\"", 4058, 1);
#nullable restore
#line 93 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\ProductManage\ProductList.cshtml"
WriteAttributeValue(" ", 4009, Html.DisplayFor(modelItem => item.FDescription), 4010, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">             \r\n                                ");
#nullable restore
#line 94 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\ProductManage\ProductList.cshtml"
                           Write(item.FDescription.Substring(0, Math.Min(item.FDescription.Length, 20)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td style=\"margin-left: auto; vertical-align: middle; \">\r\n                                ");
#nullable restore
#line 97 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\ProductManage\ProductList.cshtml"
                           Write(Html.DisplayFor(modelItem => item.FVisible));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td style=\"margin-left:auto\">\r\n                                ");
#nullable restore
#line 100 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\ProductManage\ProductList.cshtml"
                           Write(Html.ActionLink("修改產品", "ProductEdit", new { id = item.FProductId },
                                 new { @class = "btn btn-light" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                              \r\n                            </td>\r\n                            <td style=\"margin-left:auto\">\r\n                                ");
#nullable restore
#line 104 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\ProductManage\ProductList.cshtml"
                           Write(Html.ActionLink("檢視圖片", "ProductImgList", new { id = item.FProductId },
                                new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 108 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\ProductManage\ProductList.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-11\">\r\n                    <div class=\"col-lg-2\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8b69c845a523b9cbb80db54de7c0935df122ce124751", async() => {
                WriteLiteral("新增產品");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div ");
            WriteLiteral(" style=\"text-align:center\" >\r\n                        ");
#nullable restore
#line 118 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\ProductManage\ProductList.cshtml"
                   Write(Html.PagedListPager((IPagedList)ViewBag.OnePageOfPro, page => Url.Action("ProductList", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $('#catrgorysearch').on('change', Catrgorychange);

        async function Catrgorychange() {
            $('#ListPro>tr').remove();
            const changecat = catrgorysearch.options[catrgorysearch.selectedIndex].value;
            const response = await fetch(""");
#nullable restore
#line 132 "C:\ispan\GitHub\0801n6\prjIHealth\Areas\Admin\Views\ProductManage\ProductList.cshtml"
                                     Write(Url.Content("~/Admin/ProductManage/Categoryselect"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""" + `?id=${changecat}`);
            const datas = await response.json();
           /* console.log(datas);*/
            let tr = '';           
            for (i = 0; i < datas.length; i++) {
                let fixdesr = '';
                if (datas[i].fDescription != null) {
                    fixdesr = datas[i].fDescription.substr(0,10);
                }

                tr = `<tr>
                        <td class=""shoping__cart__item"" style=""margin-left: auto; text-align: left; overflow: hidden; white-space: nowrap; text-overflow: ellipsis;vertical-align: middle;"">
                                <img src=""/img/product/${datas[i].fCoverImage}"" style=""width:30%;height:30%;"" /> <span>${datas[i].fProductName}</span>
                            </td>
                            <td style=""margin-left:auto; text-align:center;vertical-align: middle;"">
                                <input type=""hidden"" value="" ${datas[i].fCategoryID})"" id=""fCategoryID"" name=""fCategoryID"" />
             ");
                WriteLiteral(@"                   <input type=""hidden"" value="" ${datas[i].fProductID})"" id=""fProductID"" name=""fProductID"" />
                                ${datas[i].fCategoryName.fCategoryName}
                            </td>
                            <td style=""margin-left:auto;vertical-align: middle;"">
                               ${datas[i].fUnitprice}
                            </td>
                            <td style=""margin-left: auto; overflow: hidden; white-space: nowrap; text-overflow: ellipsis; vertical-align: middle; "">
                              ${fixdesr}
                            </td>
                            <td style=""margin-left:auto; vertical-align: middle;"">
                               ${datas[i].fVisible}
                            </td>
                            <td style=""margin-left:auto;vertical-align: middle;"">
                               <a class=""primary-btn cart-btn"" href=""/Admin/ProductManage/ProductEdit/${datas[i].fProductId}"">修改產品</a>
              ");
                WriteLiteral(@"                 <a class=""primary-btn cart-btn"" href=""/Admin/ProductManage/ProductImgList/${datas[i].fProductId}"">檢視圖片</a>
                            </td>
                        </tr> `               
                $('#ListPro').append(tr);             
            }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<prjIHealth.ViewModels.CProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
