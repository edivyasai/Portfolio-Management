#pragma checksum "C:\PortfolioManagement\CustomerPortalMVC-main\CustomerPortalMVC-main\Views\Customer\LoginContact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70b996700c962772cea46aee7b918024b05f4055"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_LoginContact), @"mvc.1.0.view", @"/Views/Customer/LoginContact.cshtml")]
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
#line 1 "C:\PortfolioManagement\CustomerPortalMVC-main\CustomerPortalMVC-main\Views\_ViewImports.cshtml"
using CustomerPortalMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\PortfolioManagement\CustomerPortalMVC-main\CustomerPortalMVC-main\Views\_ViewImports.cshtml"
using CustomerPortalMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70b996700c962772cea46aee7b918024b05f4055", @"/Views/Customer/LoginContact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cfe1b1640c2fb67cb2b5291435479048511b9b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_LoginContact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("php-email-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("myFunction()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "C:\PortfolioManagement\CustomerPortalMVC-main\CustomerPortalMVC-main\Views\Customer\LoginContact.cshtml"
  
    Layout = "~/Views/Shared/LoginLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"" data-aos=""fade-up"">



    <div class=""section-title"">
        <h2 class=""text-white"">Contact</h2>
        <p class=""text-white"">Contact Us</p>
    </div>



    <div>
        <iframe style=""border:0; width: 100%; height: 270px;"" src=""https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d12097.433213460943!2d-74.0062269!3d40.7101282!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0xb89d1fe6bc499443!2sDowntown+Conference+Center!5e0!3m2!1smk!2sbg!4v1539943755621"" frameborder=""0"" allowfullscreen></iframe>
    </div>



    <div class=""row mt-5"">

        

        <div class=""col-lg-4"">
            <div class=""info"">
                <div class=""address"">
                    <i class=""bi bi-geo-alt""></i>
                    <h4 class=""text-white"">Location:</h4>
                    <p class=""text-white"">A108 Adam Street, New York, NY 535022</p>
                </div>



                <div class=""email"">
                    <i class=""bi bi-envelope""></i>
                    <h4 class=""text-white"">E");
            WriteLiteral(@"mail:</h4>
                    <p class=""text-white"">info@example.com</p>
                </div>



                <div class=""phone"">
                    <i class=""bi bi-phone""></i>
                    <h4 class=""text-white"">Call:</h4>
                    <p class=""text-white"">+1 5589 55488 55s</p>
                </div>



            </div>



        </div>



        <div class=""col-lg-8 mt-5 mt-lg-0"">



            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70b996700c962772cea46aee7b918024b05f40555799", async() => {
                WriteLiteral(@"

                <div class=""row"">
                    <div class=""col-md-6 form-group"">
                        <input type=""text"" name=""name"" class=""form-control"" id=""name"" placeholder=""Your Name"" required>
                    </div>
                    <div class=""col-md-6 form-group mt-3 mt-md-0"">
                        <input type=""email"" class=""form-control"" name=""email"" id=""email"" placeholder=""Your Email"" required>
                    </div>
                </div>
                <div class=""form-group mt-3"">
                    <input type=""text"" class=""form-control"" name=""subject"" id=""subject"" placeholder=""Subject"" required>
                </div>
                <div class=""form-group mt-3"">
                    <textarea class=""form-control"" name=""message"" rows=""5"" placeholder=""Message"" required></textarea>
                </div>
                <div class=""my-3"">
                    
                </div>
                <div class=""text-center""><input type=""submit"" name=""sendmessage"" value=""Sen");
                WriteLiteral("d Message\"></div>\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n            <script>\n                function myFunction() {\n                    alert(\"Thanks  for contacting us.We will get back to you shortly\");\n                }\n            </script>\n\n        </div>\n\n\n\n    </div>\n\n\n\n</div>\n\n\n</div>\n");
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