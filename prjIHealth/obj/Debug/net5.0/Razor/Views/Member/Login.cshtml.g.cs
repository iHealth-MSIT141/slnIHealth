#pragma checksum "C:\ispan\0808\prjIHealth\Views\Member\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88d408f81f5e5fe2b74213612aa91436647be5ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_Login), @"mvc.1.0.view", @"/Views/Member/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88d408f81f5e5fe2b74213612aa91436647be5ed", @"/Views/Member/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a16e691bc2a8572590ef329eb9d410d52ff20929", @"/_ViewImports.cshtml")]
    public class Views_Member_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-gradient-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "C:\ispan\0808\prjIHealth\Views\Member\Login.cshtml"
   ViewData["Title"] = "Login"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/css/all.min.css\" />\r\n\r\n\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral(@"<section class=""breadcrumb-section set-bg"" data-setbg=""/img/breadcrumb.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 text-center"">
                <div class=""breadcrumb__text"">
                    <div class=""container"">
                        <!-- Outer Row -->
                        <div class=""row justify-content-center"">

                            <div class=""col-xl-10 col-lg-12 col-md-9"">

                                <div class=""card o-hidden border-0 shadow-lg my-5"">
                                    <div class=""card-body p-0"">
                                        <!-- Nested Row within Card Body -->
                                        <div class=""row"">
");
            WriteLiteral(@"                                            <div class=""col-xl-6 d-none d-xl-block"">
                                                <img src=""https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-registration/img4.webp""
                                                     alt=""Sample photo"" class=""img-fluid""
                                                     style=""border-top-left-radius: .25rem; border-bottom-left-radius: .25rem;"" />
                                            </div>
                                            <div class=""col-lg-6"">
                                                <div class=""p-5"">
                                                    <div class=""text-center"">
                                                        <h1 class=""h4 text-gray-900 mb-4"">歡迎登入IHealth會員!</h1>
                                                    </div>
");
#nullable restore
#line 40 "C:\ispan\0808\prjIHealth\Views\Member\Login.cshtml"
                                                     using (Html.BeginForm("Login", "member", FormMethod.Post))
                                                    {
                                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\ispan\0808\prjIHealth\Views\Member\Login.cshtml"
                                                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <div class=\"form-horizontal\">\r\n                                                            <hr />\r\n                                                            ");
#nullable restore
#line 46 "C:\ispan\0808\prjIHealth\Views\Member\Login.cshtml"
                                                       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                            <div class=""form-outline mb-4"">
                                                                <div class=""col-md-12 mb-3"">
                                                                    ");
#nullable restore
#line 49 "C:\ispan\0808\prjIHealth\Views\Member\Login.cshtml"
                                                               Write(Html.TextBox("fUserName", "", new { htmlAttributes = new { @class = "form-control form-control-user" }, placeholder = "請輸入帳號" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                                </div>\r\n                                                                <div class=\"col-md-12 mb-3\">\r\n                                                                    ");
#nullable restore
#line 52 "C:\ispan\0808\prjIHealth\Views\Member\Login.cshtml"
                                                               Write(Html.TextBox("fPassword", "", new { htmlAttributes = new { @class = "form-control form-control-user" }, placeholder = "請輸入密碼" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                </div>
                                                                <div class=""custom-control custom-checkbox small"">
                                                                    <input type=""checkbox"" class=""custom-control-input"" id=""customCheck"" name=""RememberMe"" >
                                                                    <label class=""custom-control-label"" for=""customCheck"">記住帳號  </label>
                                                                </div>
                                                                <div class="" col-md-12  "">
                                                                    <input id=""btnSubmit""type=""submit"" value=""會員登入"" class=""btn btn-primary "">
                                                                </div>
                                                            </div>
                                                            <div class=""form-group"">

   ");
            WriteLiteral("                                                         </div>\r\n                                                        </div>");
#nullable restore
#line 65 "C:\ispan\0808\prjIHealth\Views\Member\Login.cshtml"
                                                              }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <div class=\"form-group\">\r\n\r\n..\r\n                                                        <!--");
            WriteLiteral(@"
                                                                                                    <!--</form>-->
                                                        <hr>
                                                        <div class=""text-center  mb-4"">
                                                            ");
#nullable restore
#line 78 "C:\ispan\0808\prjIHealth\Views\Member\Login.cshtml"
                                                       Write(Html.ActionLink("忘記密碼?", "ForgotPassword", "Member", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </div>\r\n                                                        <div class=\"text-center\">\r\n                                                            ");
#nullable restore
#line 81 "C:\ispan\0808\prjIHealth\Views\Member\Login.cshtml"
                                                       Write(Html.ActionLink("註冊會員", "Register", "Member", null, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                </div>

                            </div>

                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</section>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88d408f81f5e5fe2b74213612aa91436647be5ed11287", async() => {
                WriteLiteral(@"



    <!-- Bootstrap core JavaScript-->
    <script src=""vendor/jquery/jquery.min.js""></script>
    <script src=""vendor/bootstrap/js/bootstrap.bundle.min.js""></script>

    <!-- Core plugin JavaScript-->
    <script src=""vendor/jquery-easing/jquery.easing.min.js""></script>

    <!-- Custom scripts for all pages-->
    <script src=""js/sb-admin-2.min.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<section class=\"product spad\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        document.querySelector(\"#btnSubmit\").addEventListener(\'click\', function ()\r\n        {\r\n           \r\n            console.log($(\'#customCheck\').val());\r\n\r\n        });\r\n\r\n    </script>\r\n");
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
