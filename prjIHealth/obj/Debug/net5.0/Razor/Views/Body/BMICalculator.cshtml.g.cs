#pragma checksum "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Body\BMICalculator.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e7452981be4f3e8f2c499a29674b71950af1009"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Body_BMICalculator), @"mvc.1.0.view", @"/Views/Body/BMICalculator.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e7452981be4f3e8f2c499a29674b71950af1009", @"/Views/Body/BMICalculator.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a16e691bc2a8572590ef329eb9d410d52ff20929", @"/_ViewImports.cshtml")]
    public class Views_Body_BMICalculator : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Body/BodyCalculatorMain"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Body\BMICalculator.cshtml"
  
    ViewData["Title"] = "BMICalculator";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <style>
        
        .leftdiv,.rightdiv {
            padding: 1vw;
        }
        
        .rightdiv {
            border: 2px dotted green;
            border-radius: 5%;
        }
        
        .form-group > label {
            margin-left: 1vw;
        }
        
        .text-danger {
            float: right;
        }
        
        .divResult {
            border: 2px dotted green;
            border-radius: 10px;
            padding: 5px 20px 5px 20px;
            margin-top: 1vw;
            margin-bottom: 1vw;
        }
        
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

            .blog__btn:ho");
                WriteLiteral("ver {\r\n                color: black;\r\n                font-weight:800;\r\n            }\r\n\r\n            .blog__btn:active {\r\n                color: black;\r\n                font-weight: 800;\r\n            }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("\r\n");
            WriteLiteral(@"<section class=""breadcrumb-section set-bg"" data-setbg=""/img/body/banner_cal.png"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 text-center"">
                <div class=""breadcrumb__text"">
                    <h2 class=""reveal_t1"">BMI計算器</h2>
                    <div class=""breadcrumb__option reveal_t1"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e7452981be4f3e8f2c499a29674b71950af10095563", async() => {
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
                        <span>Body Calculator</span>
                    </div>
                </div>
            </div>

        </div>
    </div>
</section>

<div class=""contact-form spad"">
    <div class=""container"">
        <div class=""row"">

");
            WriteLiteral(@"            <div class=""col-lg-12 reveal_b1"">
                <div class=""contact__form__title"">
                    <div class=""col-lg-8 centered"" style=""text-align:start"">
                        BMI的中文名稱為【身體質量指數】（Body Mass Index, BMI），世界衛生組織建議衡量肥胖程度的指標。
                        根據國民健康署的建議，台灣成人BMI標準的正常理想範圍落在18.5~24之間。
                    </div>
                    <br />
                    <div class=""col-lg-8 centered"">
                        來算算看自己的 BMI 是否標準吧！
                    </div>
                </div>
            </div>

");
            WriteLiteral(@"            <div class=""col-lg-6 leftdiv reveal_b2"">
                <div class=""section-title product__discount__title"" style=""margin-bottom:2vw"">
                    <h2 style=""font-size:30px;"" id=""hResult"">您的BMI值為：</h2>
                </div>
                <div class=""divResult"">
                    BMI < 18.5<br />
                    「體重過輕」，需要多運動，均衡飲食，以增加體能，維持健康！
                </div>
                <div class=""divResult"">
                    18.5 ≤ BMI < 24<br />
                    恭喜！「健康體重」，要繼續保持！
                </div>
                <div class=""divResult"">
                    24 ≤ BMI < 27<br />
                    「體重過重」了，要小心囉，趕快力行健康體重管理！
                </div>
                <div class=""divResult"" style=""margin-bottom:0"">
                    BMI ≥ 27<br />
                    啊～「肥胖」，需要立刻力行健康體重管理囉！
                </div>
            </div>

");
            WriteLiteral("            <div class=\"col-lg-6 rightdiv reveal_b3\">\r\n");
            WriteLiteral(@"                <br />
                <div class=""form-group"">
                    <label class=""control-label"">身高(cm)</label><span class=""text-danger""></span>
                    <input class=""form-control inpBmi"" id=""FHeight"" type=""number"" pattern=""^[0-9]+(.[0-9])?$$"" placeholder=""請輸入身高(cm)"" required />
                </div>
                <div class=""form-group"">
                    <label class=""control-label"">體重(kg)</label><span class=""text-danger""></span>
                    <input class=""form-control inpBmi"" id=""FWeight"" type=""number"" pattern=""^[0-9]+(.[0-9])?$"" placeholder=""請輸入體重(kg)"" required />
                </div>
                <br />
                <div class=""text-center"">
                    <button class=""site-btn"" id=""btnGetBMI"">開始計算!</button>
                    <button type=""button"" class=""btn btn-info"" id=""btnDemo"">Demo</button>
                </div>
                <div class=""text-center"">想知道自己的每日總消耗熱量嗎？<a href=""../Body/TDEECalculator"" class=""blog__btn"" style=""margi");
            WriteLiteral("n-left:1vw;margin-top:1vh\"><span class=\"arrow_right\"></span>TDEE計算器</a></div>\r\n");
            WriteLiteral("            </div>\r\n        \r\n        </div>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"    <script>

        //驗證空值+數字
        $("".inpBmi"").blur(function () {
            let isNum = /^[0-9]+(.[0-9])?$/;
            if ($(this).val() == """") {
                $(this).prev().text(""此為必填欄位"");
                $(""#hResult"").text(""您的BMI值為："");
            }
            else if (!isNum.test($(this).val())) {
                $(this).prev().text(""請輸入數字"");
                $(""#hResult"").text(""您的BMI值為："");
            }
            else {
                $(this).prev().text("""");
            }
        })

        //show計算結果
        $(""#btnGetBMI"").click(function () {
            $("".inpBmi"").blur();
            $("".divResult"").css(""background-color"", ""transparent"");
            if ($("".text-danger"").text() == """") {
                $.get(""");
#nullable restore
#line 172 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Body\BMICalculator.cshtml"
                  Write(Url.Content("~/Body/getBMI"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""", { ""FHeight"": $(""#FHeight"").val(), ""FWeight"": $(""#FWeight"").val() }, function (numBMI) {
                    if (numBMI < 18.5) {
                        $("".divResult"").first().css(""transition"", ""1s"").css(""background-color"", ""#b5daa7"");
                    }
                    else if (numBMI >= 18.5 && numBMI < 24) {
                        $("".divResult"").eq(1).css(""transition"", ""1s"").css(""background-color"", ""#b5daa7"");
                    }
                    else if (numBMI >= 24 && numBMI < 27) {
                        $("".divResult"").eq(2).css(""transition"", ""1s"").css(""background-color"", ""#b5daa7"");
                    }
                    else if (numBMI >= 27) {
                        $("".divResult"").eq(3).css(""transition"", ""1s"").css(""background-color"", ""#b5daa7"");
                    }
                    $(""#hResult"").text(""您的BMI值為："" + numBMI);
                })
            }
        })

        //Demo鍵
        $(""#btnDemo"").click(function () {
            $(""#FHeight"").v");
                WriteLiteral("al(\"171\");\r\n            $(\"#FWeight\").val(\"85\");\r\n            $(\".inpBmi\").blur();\r\n        })\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
