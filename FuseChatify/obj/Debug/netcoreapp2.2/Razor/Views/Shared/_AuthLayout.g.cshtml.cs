#pragma checksum "E:\.NET CORE\FuseChatify\FuseChatify\Views\Shared\_AuthLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fae3dc23c6b14e3898fe956f1c1bb696a5ba57b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AuthLayout), @"mvc.1.0.view", @"/Views/Shared/_AuthLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_AuthLayout.cshtml", typeof(AspNetCore.Views_Shared__AuthLayout))]
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
#line 1 "E:\.NET CORE\FuseChatify\FuseChatify\Views\_ViewImports.cshtml"
using FuseChatify;

#line default
#line hidden
#line 2 "E:\.NET CORE\FuseChatify\FuseChatify\Views\_ViewImports.cshtml"
using FuseChatify.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fae3dc23c6b14e3898fe956f1c1bb696a5ba57b", @"/Views/Shared/_AuthLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"605ed5774efb6474ffa37ac16d40d51f5df32973", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AuthLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layout layout-vertical layout-left-navigation layout-above-toolbar layout-above-footer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 3895, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fae3dc23c6b14e3898fe956f1c1bb696a5ba57b3774", async() => {
                BeginContext(31, 121, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
                EndContext();
                BeginContext(153, 17, false);
#line 6 "E:\.NET CORE\FuseChatify\FuseChatify\Views\Shared\_AuthLayout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(170, 3743, true);
                WriteLiteral(@" - FuseChatify</title>
    <link rel=""shortcut icon"" type=""image/x-icon"" href=""/assets/favicon.ico"" />

    <link href=""https://fonts.googleapis.com/css?family=Roboto:400,100,100italic,300,300italic,400italic,500,500italic,700italic,700,900,900italic"" rel=""stylesheet"">

    <!-- STYLESHEETS -->
    <style type=""text/css"">
        [fuse-cloak],
        .fuse-cloak {
            display: none !important;
        }
    </style>

    <!-- Icons.css -->
    <link type=""text/css"" rel=""stylesheet"" href=""/assets/icons/fuse-icon-font/style.css"">
    <!-- Animate.css -->
    <link type=""text/css"" rel=""stylesheet"" href=""/assets/node_modules/animate.css/animate.min.css"">
    <!-- PNotify -->
    <link type=""text/css"" rel=""stylesheet"" href=""/assets/node_modules/pnotify/dist/PNotifyBrightTheme.css"">
    <!-- Nvd3 - D3 Charts -->
    <link type=""text/css"" rel=""stylesheet"" href=""/assets/node_modules/nvd3/build/nv.d3.min.css"" />
    <!-- Perfect Scrollbar -->
    <link type=""text/css"" rel=""stylesheet"" hr");
                WriteLiteral(@"ef=""/assets/node_modules/perfect-scrollbar/css/perfect-scrollbar.css"" />
    <!-- Fuse Html -->
    <link type=""text/css"" rel=""stylesheet"" href=""/assets/fuse-html/fuse-html.min.css"" />
    <!-- Main CSS -->
    <link type=""text/css"" rel=""stylesheet"" href=""/assets/css/main.css"">
    <!-- / STYLESHEETS -->
    <!-- JAVASCRIPT -->
    <!-- jQuery -->
    <script type=""text/javascript"" src=""/assets/node_modules/jquery/dist/jquery.min.js""></script>
    <!-- Mobile Detect -->
    <script type=""text/javascript"" src=""/assets/node_modules/mobile-detect/mobile-detect.min.js""></script>
    <!-- Perfect Scrollbar -->
    <script type=""text/javascript"" src=""/assets/node_modules/perfect-scrollbar/dist/perfect-scrollbar.min.js""></script>
    <!-- Popper.js -->
    <script type=""text/javascript"" src=""/assets/node_modules/popper.js/dist/umd/popper.min.js""></script>
    <!-- Bootstrap -->
    <script type=""text/javascript"" src=""/assets/node_modules/bootstrap/dist/js/bootstrap.min.js""></script>
    <!-- Nvd3 - ");
                WriteLiteral(@"D3 Charts -->
    <script type=""text/javascript"" src=""/assets/node_modules/d3/d3.min.js""></script>
    <script type=""text/javascript"" src=""/assets/node_modules/nvd3/build/nv.d3.min.js""></script>
    <!-- Data tables -->
    <script type=""text/javascript"" src=""/assets/node_modules/datatables.net/js/jquery.dataTables.js""></script>
    <script type=""text/javascript"" src=""/assets/node_modules/datatables-responsive/js/dataTables.responsive.js""></script>
    <!-- PNotify -->
    <script type=""text/javascript"" src=""/assets/node_modules/pnotify/dist/iife/PNotify.js""></script>
    <script type=""text/javascript"" src=""/assets/node_modules/pnotify/dist/iife/PNotifyStyleMaterial.js""></script>
    <script type=""text/javascript"" src=""/assets/node_modules/pnotify/dist/iife/PNotifyButtons.js""></script>
    <script type=""text/javascript"" src=""/assets/node_modules/pnotify/dist/iife/PNotifyCallbacks.js""></script>
    <script type=""text/javascript"" src=""/assets/node_modules/pnotify/dist/iife/PNotifyMobile.js""></script>");
                WriteLiteral(@"
    <script type=""text/javascript"" src=""/assets/node_modules/pnotify/dist/iife/PNotifyHistory.js""></script>
    <script type=""text/javascript"" src=""/assets/node_modules/pnotify/dist/iife/PNotifyDesktop.js""></script>
    <script type=""text/javascript"" src=""/assets/node_modules/pnotify/dist/iife/PNotifyConfirm.js""></script>
    <script type=""text/javascript"" src=""/assets/node_modules/pnotify/dist/iife/PNotifyReference.js""></script>
    <!-- Fuse Html -->
    <script type=""text/javascript"" src=""/assets/fuse-html/fuse-html.min.js""></script>
    <!-- Main JS -->
    <script type=""text/javascript"" src=""/assets/js/main.js""></script>
    <!-- / JAVASCRIPT -->
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3920, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3922, 1073, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fae3dc23c6b14e3898fe956f1c1bb696a5ba57b9410", async() => {
                BeginContext(4023, 847, true);
                WriteLiteral(@"
    <main>
        <div id=""wrapper"">
            <div class=""content-wrapper"">
                <div class=""content custom-scrollbar"">

                    <div id=""login-v2"" class=""row no-gutters"">

                        <div class=""intro col-12 col-md light-fg"">

                            <div class=""d-flex flex-column align-items-center align-items-md-start text-center text-md-left py-16 py-md-32 px-12"">

                                <div class=""logo bg-secondary mb-8"">
                                    <span>FC</span>
                                </div>

                                <div class=""title"">
                                    Welcome to the Fuse Chatify!
                                </div>

                            </div>
                        </div>
                        ");
                EndContext();
                BeginContext(4871, 12, false);
#line 89 "E:\.NET CORE\FuseChatify\FuseChatify\Views\Shared\_AuthLayout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(4883, 105, true);
                WriteLiteral("\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </main>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(4995, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
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
