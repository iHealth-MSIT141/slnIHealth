#pragma checksum "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Shopping\ShoppingCartList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36ae5f8812d38cbc6d89b056b594cf06de3cc757"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shopping_ShoppingCartList), @"mvc.1.0.view", @"/Views/Shopping/ShoppingCartList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36ae5f8812d38cbc6d89b056b594cf06de3cc757", @"/Views/Shopping/ShoppingCartList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a16e691bc2a8572590ef329eb9d410d52ff20929", @"/_ViewImports.cshtml")]
    public class Views_Shopping_ShoppingCartList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<prjIHealth.ViewModels.CShoppingCartItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Shopping/ShowShoppingMall"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("primary-btn cart-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Shopping\ShoppingCartList.cshtml"
  
    ViewData["Title"] = "ShoppingCartList";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n<style>\r\n   \r\n</style>\r\n");
            }
            );
            WriteLiteral("<section class=\"breadcrumb-section set-bg\" data-setbg=\"/img/product/banner_shop.png\" id=\"bannerTop\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-12 text-center\">\r\n                <div class=\"breadcrumb__text\">\r\n");
            WriteLiteral("                    <h2 class=\"reveal_t1\">購物車</h2>\r\n                    <div class=\"breadcrumb__option reveal_t1\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36ae5f8812d38cbc6d89b056b594cf06de3cc7575329", async() => {
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
            WriteLiteral("\r\n                        <span>Shopping</span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            WriteLiteral(@"
<section class=""shoping-cart spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""shoping__cart__table"">
                    <table id=""table"">
                        <thead>
                            <tr>
                                <th style=""display:none"">編號</th>
                                <th class=""shoping__product"">產品名稱</th>
                                <th>價格</th>
                                <th>數量</th>
                                <th>總價</th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 48 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Shopping\ShoppingCartList.cshtml"
                              
                                decimal pay = 0;
                                decimal discount = 0;

                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Shopping\ShoppingCartList.cshtml"
                                 foreach (var item in Model)
                                {
                                    discount = item.discount;
                                    pay += item.小計;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td style=\"display:none\" id=\"productid\">");
#nullable restore
#line 57 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Shopping\ShoppingCartList.cshtml"
                                                                   Write(item.productId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"shoping__cart__item\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 2139, "\"", 2183, 2);
            WriteAttributeValue("", 2145, "/img/product/", 2145, 13, true);
#nullable restore
#line 59 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Shopping\ShoppingCartList.cshtml"
WriteAttributeValue("", 2158, item.product.FCoverImage, 2158, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2184, "\"", 2190, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width:10%;height:10%\">\r\n                                    <h5>");
#nullable restore
#line 60 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Shopping\ShoppingCartList.cshtml"
                                   Write(item.product.FProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                </td>\r\n                                <td class=\"shoping__cart__price\">\r\n                                    ");
#nullable restore
#line 63 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Shopping\ShoppingCartList.cshtml"
                               Write(item.price.ToString("C0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </td>
                                <td class=""shoping__cart__quantity"">
                                    <div class=""quantity"">
                                        <div class=""pro-qty"">
                                            <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 2760, "\"", 2809, 1);
#nullable restore
#line 68 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Shopping\ShoppingCartList.cshtml"
WriteAttributeValue("", 2768, Html.DisplayFor(modelItem => item.count), 2768, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""productqty"">
                                        </div>
                                    </div>
                                </td>
                                <td class=""shoping__cart__total"" id=""tempprice"" name=""shoping__cart__total"">
                                    ");
#nullable restore
#line 73 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Shopping\ShoppingCartList.cshtml"
                               Write(item.小計.ToString("C0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </td>
                                <td class=""shoping__cart__item__close"">
                                    <span class=""icon_close""></span>
                                </td>
                                <td style=""display:none"" id=""productdiscount"">");
#nullable restore
#line 78 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Shopping\ShoppingCartList.cshtml"
                                                                         Write(item.discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 80 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Shopping\ShoppingCartList.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Shopping\ShoppingCartList.cshtml"
                                 
                                decimal total = pay - discount;
                            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""shoping__cart__btns"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36ae5f8812d38cbc6d89b056b594cf06de3cc75712635", async() => {
                WriteLiteral("繼續購物");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-6\">\r\n                <div class=\"shoping__continue\">\r\n                    <div class=\"shoping__discount\">\r\n                        <h5>折扣代碼</h5>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36ae5f8812d38cbc6d89b056b594cf06de3cc75714055", async() => {
                WriteLiteral("\r\n                            <input type=\"text\" autocomplete=\"off\" placeholder=\"請輸入折扣代碼\" id=\"codestring\">\r\n                            <button type=\"button\" class=\"site-btn\" id=\"checkdiscount\">使用折扣代碼</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""shoping__checkout"">
                    <h5>結帳明細</h5>
                    <ul>
                        <li>小計<span id=""originprice"">");
#nullable restore
#line 109 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Shopping\ShoppingCartList.cshtml"
                                                Write(pay.ToString("C0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                        <li  id=\"discounthint\">折扣金額<span id=\"pricehint\">");
#nullable restore
#line 110 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Shopping\ShoppingCartList.cshtml"
                                                                   Write(discount.ToString("C0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                        <li>總金額<span id=\"total\">");
#nullable restore
#line 111 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Shopping\ShoppingCartList.cshtml"
                                           Write(total.ToString("C0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                    </ul>\r\n                    ");
#nullable restore
#line 113 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Shopping\ShoppingCartList.cshtml"
               Write(Html.ActionLink("開始結帳", "CheckOut", new { }, new { @class = "primary-btn", @id = "checkout" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        //結帳時檢查是否有數量為0的商品，若有則從session中移除
        $('#checkout').on('click', checkzero)
        function checkzero() {
            var data = {};
            data.txtFid = $('#productid').text()
            data.txtCount = 0;
            $.ajax({
             type: ""POST"",
             url: """);
#nullable restore
#line 130 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Shopping\ShoppingCartList.cshtml"
              Write(Url.Action("ShoppingCartCheckZero"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
             data: data
            })
        }
        //刪除購物車商品並重新計算小計與總金額
        $(""span[class='icon_close']"").on('click', removeproduct)
        function removeproduct(){
            $(this).closest('tr').remove();
            //將所有加總的值取出後放入list，再計算list之和sum，之後由sum計算並替換小計與總金額
            var list = new Array();
            $(""td[class='shoping__cart__total']"").each(function () {
                list.push(parseInt($(this).text().trim().replace("","", """").replace(""\n"", """").substring(3)));
            });
            var sum = 0;
            list.forEach(function (element) {
                sum += element;
            });
            //sum處理為NT$與千分位型態&計算折扣金額
            let strsum = ""NT$"" + toCurrency(sum)
            let discountprice = 0;
            if (hasdiscount) {
                discountprice = parseInt($('#discounthint').text().replace(',', '').substring(7))
            }
            let finaltotal = sum - discountprice
            $('#originprice').html(strsum)
         ");
                WriteLiteral(@"   //finaltotal處理為NT$與千分位型態
            let strfinaltotal = ""NT$"" + toCurrency(finaltotal)
            $('#total').html(strfinaltotal)
            //從session中移除選中商品
            var data = {};
            data.txtFid = parseInt($(this).parent().prev().prev().prev().prev().prev().text());
            $.ajax({
             type: ""POST"",
             url: """);
#nullable restore
#line 163 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Shopping\ShoppingCartList.cshtml"
              Write(Url.Action("ShoppingCartDelete"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
             data: data
            })
            //變更右上購物車顯示數量            
            let oricartcount = $(""#fa-cart"").children(""span"").text();
            let newcartcount = oricartcount - 1;
            if (newcartcount == 0) {
                $(""#fa-cart"").children(""span"").text("""");
                $(""#fa-cart"").children(""span"").hide();
            }
            else {
                $(""#fa-cart"").children(""span"").text(newcartcount);
                $(""#fa-cart"").children(""span"").show();
            }           
        }
        //判斷是否有折價卷旗標
        let hasdiscount = false;
        //js轉換數字為千分位型態方法
        function toCurrency(num) {
            var parts = num.toString().split('.');
            parts[0] = parts[0].replace(/\B(?=(\d{3})+(?!\d))/g, ',');
            return parts.join('.');
        }
        //js處理C#帶入的貨幣文字格式，將NT$與,消除後變數字運用
        async function CheckDiscount() {
            const originprice = parseInt((document.getElementById(""originprice"").innerHTML).repla");
                WriteLiteral("ce(\",\", \"\").substring(3))\r\n            const codestring = ($(\'#codestring\').val()).toString();\r\n            const response = await fetch(\'");
#nullable restore
#line 190 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Shopping\ShoppingCartList.cshtml"
                                     Write(Url.Content("~/Shopping/CheckDiscount"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' + `?code=${codestring}`);
            const datas = await response.json();
            if (datas.length == 0) {
                SwalGreen.fire({
                    title: '請輸入正確折扣碼',
                    text: false,
                    icon: 'warning',
                    confirmButtonText: '確認',
                    showCloseButton: true
                })
            }
            else {
        //讀取折扣額並計算總金額後，再將數字用方法轉回千分位型態字串且加上NT$
                $('#discounthint').css('display', 'block')
                let discountvalue = ""NT$"" + toCurrency(parseInt(datas[0].fDiscountValue, 10))
                $('#pricehint').html(discountvalue)
                let total = originprice - parseInt(datas[0].fDiscountValue, 10)
                let stringtotal = ""NT$"" + toCurrency(total)
                $('#total').html(stringtotal)
                hasdiscount = true;
                SwalGreen.fire({
                    title: '已成功使用折扣碼',
                    text: false,
                    icon: 's");
                WriteLiteral(@"uccess',
                    confirmButtonText: '確認',
                    showCloseButton: true
                })
            }
        //為現有商品加上折扣金額的值供結帳頁面使用
            var data = {};
            data.txtFid = $('#productid').text()
            data.discountValue = parseInt($('#discounthint').text().replace(',', '').substring(7))
            data.discountID = datas[0].fDiscountId
            $.ajax({
             type: ""POST"",
             url: """);
#nullable restore
#line 225 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Shopping\ShoppingCartList.cshtml"
              Write(Url.Action("AttachDiscount"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
             data: data
            })
            console.log(data.discountID)
        }
        $('#checkdiscount').on('click', CheckDiscount);

        //按+時變更總價,小計,總金額,並對模板預設input值與顯示值差1進行處理
        $(""span[class='inc qtybtn']"").on('click', changepriceplus)
        function changepriceplus() {
            let count = parseInt($(this).prev().val())
            let newprice = 0
            let oldprice = parseInt(($(this).parent().parent().parent().prev().text()).replace("","", """").trim().substring(3))
            if (count == 1) {
                newprice = ""NT$"" + toCurrency(2 * oldprice)
            } else {
                newprice = ""NT$"" + toCurrency((count+1) * oldprice)
            }
            $(this).parent().parent().parent().next().html(newprice)
          //將所有加總的值取出後放入list，再計算list之和sum，之後由sum計算並替換小計與總金額
            var list = new Array();
            $(""td[class='shoping__cart__total']"").each(function () {
                list.push(parseInt($(this).text().trim().replace");
                WriteLiteral(@"("","", """").replace(""\n"", """").substring(3)));
            });
            var sum = 0;
            list.forEach(function (element) {
                sum += element;
            });


           //sum處理為NT$與千分位型態&計算折扣金額
            let strsum = ""NT$"" + toCurrency(sum)
            let discountprice = 0;
            if (hasdiscount) {
                discountprice = parseInt($('#discounthint').text().replace(',', '').substring(7))
            }
            let finaltotal = sum - discountprice
            $('#originprice').html(strsum)
            //finaltotal處理為NT$與千分位型態
            let strfinaltotal = ""NT$"" + toCurrency(finaltotal)
            $('#total').html(strfinaltotal)
            //變更seesion內產品數量
             var data = {};
            data.txtFid = parseInt($(this).parent().parent().parent().prev().prev().prev().text());
            data.txtCount = parseInt($(this).prev().val()) + 1;
            if (hasdiscount) {
                data.discountValue = discountprice = parseInt($('#di");
                WriteLiteral("scounthint\').text().replace(\',\', \'\').substring(7))\r\n            }\r\n            else {\r\n                data.discountValue = 0;\r\n            }\r\n            $.ajax({\r\n             type: \"POST\",\r\n             url: \"");
#nullable restore
#line 278 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Shopping\ShoppingCartList.cshtml"
              Write(Url.Action("ShoppingCartSession"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
             data: data
            })
            console.log(data.discountValue)
        }
        //按-時變更總價,小計,總金額,並對模板預設input值與顯示值差1進行處理
        $(""span[class='dec qtybtn']"").on('click', changepriceminus)
        function changepriceminus() {
            //處理商品數量歸0時，總價小計與總金額顯示
            if ($(this).next().val() == 1 || $(this).next().val() == 0) {
                let newprice = ""NT$0""
                $(this).parent().parent().parent().next().html(newprice)
                //將所有加總的值取出後放入list，再計算list之和sum，之後由sum計算並替換小計與總金額
                var list = new Array();
                $(""td[class='shoping__cart__total']"").each(function () {
                    list.push(parseInt($(this).text().trim().replace("","", """").replace(""\n"", """").substring(3)));
                });
                var sum = 0;
                list.forEach(function (element) {
                    sum += element;
                });
                //sum處理為NT$與千分位型態&計算折扣金額
                let strsum = ""NT$"" + toCurren");
                WriteLiteral(@"cy(sum)
                let discountprice = 0;
                if (hasdiscount) {
                    discountprice = parseInt($('#discounthint').text().replace(',', '').substring(7))
                }
                let finaltotal = sum - discountprice
                $('#originprice').html(strsum)
                //finaltotal處理為NT$與千分位型態
                let strfinaltotal = ""NT$"" + toCurrency(finaltotal)
                $('#total').html(strfinaltotal)
            }
            else {
            let count = parseInt($(this).next().val())
            let newprice = 0
            let oldprice = parseInt(($(this).parent().parent().parent().prev().text()).replace("","", """").trim().substring(3))
            if (count == 3) {
                newprice = ""NT$"" + toCurrency(2 * oldprice)
            } else {
                newprice = ""NT$"" + toCurrency((count - 1) * oldprice)
            }
            $(this).parent().parent().parent().next().html(newprice)
            //將所有加總的值取出後放入list，再計算list之");
                WriteLiteral(@"和sum，之後由sum計算並替換小計與總金額
            var list = new Array();
            $(""td[class='shoping__cart__total']"").each(function () {
                list.push(parseInt($(this).text().trim().replace("","", """").replace(""\n"", """").substring(3)));
            });
            var sum = 0;
            list.forEach(function (element) {
                sum += element;
            });
            //sum處理為NT$與千分位型態&計算折扣金額
            let strsum = ""NT$"" + toCurrency(sum)
            let discountprice = 0;
            if (hasdiscount) {
                discountprice = parseInt($('#discounthint').text().replace(',', '').substring(7))
            }
            let finaltotal = sum - discountprice
            $('#originprice').html(strsum)
            //finaltotal處理為NT$與千分位型態
            let strfinaltotal = ""NT$"" + toCurrency(finaltotal)
            $('#total').html(strfinaltotal)
            }
            //變更seesion內產品數量
             var data = {};
            data.txtFid = parseInt($(this).parent().parent(");
                WriteLiteral(@").parent().prev().prev().prev().text());
            data.txtCount = parseInt($(this).next().val())-1;
            if (hasdiscount) {
                data.discountValue = discountprice = parseInt($('#discounthint').text().replace(',', '').substring(7))
            }
            else {
                data.discountValue = 0;
            }
            $.ajax({
             type: ""POST"",
             url: """);
#nullable restore
#line 354 "C:\ispan\GitHub\slnIHealth\0802n7\prjIHealth\Views\Shopping\ShoppingCartList.cshtml"
              Write(Url.Action("ShoppingCartSession"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n             data: data\r\n            })\r\n        }\r\n    </script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<prjIHealth.ViewModels.CShoppingCartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
