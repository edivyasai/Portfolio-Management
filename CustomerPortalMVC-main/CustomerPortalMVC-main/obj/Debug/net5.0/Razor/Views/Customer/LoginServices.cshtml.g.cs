#pragma checksum "C:\PortfolioManagement\CustomerPortalMVC-main\CustomerPortalMVC-main\Views\Customer\LoginServices.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e37e62f7f421638c7b80f2dbff122387d90adc2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_LoginServices), @"mvc.1.0.view", @"/Views/Customer/LoginServices.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e37e62f7f421638c7b80f2dbff122387d90adc2a", @"/Views/Customer/LoginServices.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cfe1b1640c2fb67cb2b5291435479048511b9b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_LoginServices : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\PortfolioManagement\CustomerPortalMVC-main\CustomerPortalMVC-main\Views\Customer\LoginServices.cshtml"
  
    Layout = "~/Views/Shared/LoginLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section id=""services"" class=""services"">
    <div class=""container"" data-aos=""fade-up"">

        <div class=""section-title"">
            <h2 class=""text-white"">Services</h2>

        </div>

        <div class=""row"">
            <div class=""col-lg-4 col-md-6 d-flex align-items-stretch "" data-aos=""zoom-in"" data-aos-delay=""100"">
                <div class=""icon-box"" style=""background-color:azure"">
                    <div class=""icon""><i class=""bx bxl-dribbble""></i></div>
                    <h4><a href=""/customer/ViewAdminStockDetails"">Stocks</a></h4>
                    <p>There are 10000+ types of stocks including Equity and Commodity to Invest</p>
                </div>
            </div>


            <div class=""col-lg-4 col-md-6 d-flex align-items-stretch mt-4 mt-lg-0"" data-aos=""zoom-in"" data-aos-delay=""300"">
                <div class=""icon-box"" style=""background-color:azure"">
                    <div class=""icon""><i class=""bx bx-tachometer""></i></div>
                    <h4><a href=""/customer/ViewAdmi");
            WriteLiteral(@"nMutualFundDetails"">Mutual Funds</a></h4>
                    <p>There are more than 3000+ Mutual Funds to select and Invest</p>
                </div>
            </div>


            <div class=""col-lg-4 col-md-6 d-flex align-items-stretch mt-4 mt-lg-0"" data-aos=""zoom-in"" data-aos-delay=""300"">
                <div class=""icon-box"" style=""background-color:azure"">
                    <div class=""icon""><i class=""bx bx-tachometer""></i></div>
                    <h4><a onclick=""funIPO()"">IPO's</a></h4>
                    <p>Invest in companys even before they made public</p>
                </div>
            </div>

        </div>

    </div>
</section>
");
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
