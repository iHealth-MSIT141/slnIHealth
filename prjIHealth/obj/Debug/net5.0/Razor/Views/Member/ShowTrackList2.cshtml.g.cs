#pragma checksum "C:\ispan\GitHub\0801n6\prjIHealth\Views\Member\ShowTrackList2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee288d8fa4a9fed2d9e4f545e6b72bff29fc5efb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_ShowTrackList2), @"mvc.1.0.view", @"/Views/Member/ShowTrackList2.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\ispan\GitHub\0801n6\prjIHealth\_ViewImports.cshtml"
using prjIHealth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ispan\GitHub\0801n6\prjIHealth\Views\Member\ShowTrackList2.cshtml"
using prjIHealth.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "C:\ispan\GitHub\0801n6\prjIHealth\Views\Member\ShowTrackList2.cshtml"
using prjIHealth.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 129 "C:\ispan\GitHub\0801n6\prjIHealth\Views\Member\ShowTrackList2.cshtml"
using prjiHealth.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 130 "C:\ispan\GitHub\0801n6\prjIHealth\Views\Member\ShowTrackList2.cshtml"
using prjIHealth.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 131 "C:\ispan\GitHub\0801n6\prjIHealth\Views\Member\ShowTrackList2.cshtml"
using prjiHealth.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 132 "C:\ispan\GitHub\0801n6\prjIHealth\Views\Member\ShowTrackList2.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 133 "C:\ispan\GitHub\0801n6\prjIHealth\Views\Member\ShowTrackList2.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 134 "C:\ispan\GitHub\0801n6\prjIHealth\Views\Member\ShowTrackList2.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 135 "C:\ispan\GitHub\0801n6\prjIHealth\Views\Member\ShowTrackList2.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee288d8fa4a9fed2d9e4f545e6b72bff29fc5efb", @"/Views/Member/ShowTrackList2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a16e691bc2a8572590ef329eb9d410d52ff20929", @"/_ViewImports.cshtml")]
    public class Views_Member_ShowTrackList2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<prjIHealth.Models.TProduct>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Shopping/ShowShoppingMall"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            DefineSection("Styles", async() => {
                WriteLiteral(@"

    <style>
        #body {
            font-family: ""Quicksand"", sans-serif;
            display: grid;
            place-items: center;
        }

        #container {
            display: flex;
            flex-wrap: wrap;
            justify-content: center;
            max-width: 1200px;
            margin-block: 2rem;
            gap: 2rem;
        }

        img {
            max-width: 100%;
            display: block;
            object-fit: cover;
        }

        .card {
            display: flex;
            flex-direction: column;
            width: clamp(20rem, calc(20rem + 2vw), 22rem);
            overflow: hidden;
            box-shadow: 0 .1rem 1rem rgba(0, 0, 0, 0.1);
            border-radius: 1em;
            background: #ECE9E6;
            background: linear-gradient(to right, #FFFFFF, #ECE9E6);
        }

        .card__body {
            padding: 1rem;
            display: flex;
            flex-direction: column;
            gap: .5rem;
   ");
                WriteLiteral(@"     }


        .tag {
            align-self: flex-start;
            padding: .25em .75em;
            border-radius: 1em;
            font-size: .75rem;
        }

            .tag + .tag {
                margin-left: .5em;
            }

        .tag-blue {
            background: #7fad39;
            /*background: linear-gradient(to bottom, #2F80ED, #56CCF2);*/
            color: #fafafa;
        }

        .card__body h4 {
            font-size: 1.5rem;
            text-transform: capitalize;
        }

        .card__footer {
            display: flex;
            padding: 1rem;
            margin-top: 10px;
        }

        .user {
            display: flex;
            gap: .5rem;
        }

        .user__image {
            border-radius: 50%;
        }

        .user__info > small {
            color: #666;
        }

        .btnRemove {
            float: right;
            background-color: #e33d3d;
            border: none
        }

      ");
                WriteLiteral("  .btnShow {\r\n            background-color: #3aea1a;\r\n            border: none\r\n        }\r\n    </style>\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
            WriteLiteral("<section class=\"breadcrumb-section set-bg\" data-setbg=\"/img/banner/banner_mem.png\" id=\"bannerTop\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-12 text-center\">\r\n                <div class=\"breadcrumb__text\">\r\n");
            WriteLiteral("                    <h2 class=\"reveal_t1\">追蹤商品清單</h2>\r\n                    <div class=\"breadcrumb__option reveal_t1\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee288d8fa4a9fed2d9e4f545e6b72bff29fc5efb7722", async() => {
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
            WriteLiteral("\r\n                        <span>Shopping</span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<section class=\"product spad\" id=\"body\">\r\n    <div id=\"container\" class=\"reveal_b2\">\r\n");
            WriteLiteral("    </div>\r\n</section>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n");
                WriteLiteral("\r\n");
#nullable restore
#line 137 "C:\ispan\GitHub\0801n6\prjIHealth\Views\Member\ShowTrackList2.cshtml"
      
        string LoginbuttonValue = "登入";
        int loginId = 0;
        TMember loginMember = null;

        if (Context.Session.Keys.Contains(CDictionary.SK_Logined_User))
        {
            string logJson = Context.Session.GetString(CDictionary.SK_Logined_User);
            loginMember = JsonSerializer.Deserialize<TMember>(logJson);
            LoginbuttonValue = loginMember.FMemberName;
            loginId = loginMember.FMemberId;
        };
    

#line default
#line hidden
#nullable disable
                WriteLiteral("        let MemberID = ");
#nullable restore
#line 150 "C:\ispan\GitHub\0801n6\prjIHealth\Views\Member\ShowTrackList2.cshtml"
                  Write(loginId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"; //member id
        function showTrackList(url) {
            $.get(url, function (data) {
                console.log(data);
                let htmlShowProduct = """";
                //顯示追蹤清單
                $.each(data, function (idx, list) {
                    list.fUnitprice = ""NT$""+toCurrency(list.fUnitprice);
                    htmlShowProduct += ` <div class=""card"">
                                            <div class=""card__header btnShow"" data-id=""${list.fProductId}"">
                                                <img src=""/img/product/${list.fCoverImage}"" alt=""card__image"" class=""card__image"" width=""600"" height=""339.64"">
                                            </div>
                                            <div class=""shoping__cart__item"">
                                                <button class=""col-lg-6 btnShow"" data-id=""${list.fProductId}""><span class=""fa fa-shopping-bag""></span></button>
                                                <button type=""button"" clas");
                WriteLiteral(@"s=""col-lg-6 btnRemove"" data-id=""${list.fProductId}""><span class=""fa icon_close""></span></button>
                                                
                                            </div>
                                            <div class=""card__body"">
                                                <span class=""tag tag-blue"">${list.fUnitprice}</span>
                                                <h4>${list.fProductName}</h4>
                                                <p>${list.fDescription}</p>
                                            </div>                                       
                                        </div>`
                })
                $(""#container"").html(htmlShowProduct);
             })
        }

        //js轉換數字為千分位型態方法
        function toCurrency(num) {
            var parts = num.toString().split('.');
            parts[0] = parts[0].replace(/\B(?=(\d{3})+(?!\d))/g, ',');
            return parts.join('.');
        }

        //以Mem");
                WriteLiteral("berID去找他所追蹤的商品\r\n        showTrackProduct();\r\n        function showTrackProduct() {\r\n            let url = \"");
#nullable restore
#line 188 "C:\ispan\GitHub\0801n6\prjIHealth\Views\Member\ShowTrackList2.cshtml"
                  Write(Url.Content("~/Member/ShowTrackProduct/"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\" + MemberID;\r\n            showTrackList(url);\r\n        }\r\n\r\n        //\r\n        async function showTrackCount() {\r\n            url = \"");
#nullable restore
#line 194 "C:\ispan\GitHub\0801n6\prjIHealth\Views\Member\ShowTrackList2.cshtml"
              Write(Url.Content("~/Member/ShowTrackCount/"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""" + MemberID;
            let response = await fetch(url);
            let datas = await response.json();
            console.log(datas);
            $(""#fa-heart"").children(""span"").text(datas);
        }

        //以ProductID刪除追蹤商品
        
        $(""#container"").delegate("".btnRemove"", ""click"", function (event) {
            event.preventDefault();
            let productID = $(this).attr(""data-id"");
            SwalGreen.fire({
                title: `確定取消追蹤嗎?`,
                showDenyButton: false,
                showCancelButton: true,
                confirmButtonText: '確定',
                cancelButtonText: '取消',
                icon: 'question'
            }).then((result) => {
                if (result.isConfirmed) {
                    $(event.currentTarget).parent().parent().remove();
                    DeleteTrack(productID);

                    let count = $(""#fa-heart"").children(""span"").text();
                    let newCount = count - 1;
                    if (n");
                WriteLiteral(@"ewCount == 0) {
                        $(""#fa-heart"").children(""span"").text("""");
                        $(""#fa-heart"").children(""span"").hide();
                    }
                    else {
                        $(""#fa-heart"").children(""span"").text(newCount);
                        $(""#fa-heart"").children(""span"").show();
                    }
                }
            })
        })      
         function DeleteTrack(id) {
             url = """);
#nullable restore
#line 232 "C:\ispan\GitHub\0801n6\prjIHealth\Views\Member\ShowTrackList2.cshtml"
               Write(Url.Content("~/Member/DeleteTrackList/"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""" + id;
             showTrackList(url);
         }

        //顯示商品詳情
        $(""#container"").delegate("".btnShow"", ""click"", function () {
            let productID = $(this).attr(""data-id"");
            location.href = `/Shopping/ShowProductDetail/${productID}`;
            console.log(productID);
            showProductDetail(productID);
        })
        $(""#container"").delegate("".btnShow"", ""click"", function () {
            let productID = $(this).attr(""data-id"");
            location.href = `/Shopping/ShowProductDetail/${productID}`;
            console.log(productID);
            showProductDetail(productID);
        })

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<prjIHealth.Models.TProduct> Html { get; private set; }
    }
}
#pragma warning restore 1591