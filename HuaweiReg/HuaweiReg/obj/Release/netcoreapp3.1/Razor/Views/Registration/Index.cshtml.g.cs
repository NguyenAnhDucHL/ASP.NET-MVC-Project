#pragma checksum "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3a0c4e47b52479dfa86473f6ee51072e630c804"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Registration_Index), @"mvc.1.0.view", @"/Views/Registration/Index.cshtml")]
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
#line 1 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\_ViewImports.cshtml"
using HuaweiReg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\_ViewImports.cshtml"
using HuaweiReg.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
using HuaweiReg.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3a0c4e47b52479dfa86473f6ee51072e630c804", @"/Views/Registration/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6dea5b7b7ba9a6a292890333d3f0ae7acb579b7", @"/Views/_ViewImports.cshtml")]
    public class Views_Registration_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HuaweiReg.Web.Models.RegistraionViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
  
    ViewData["Title"] = "Registration";
    Layout = "~/Views/Shared/_ClientLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div data-mod-name-pc=\"");
            WriteLiteral("@cloud/pep-home-page/pc/index\" data-mod-name-m=\"");
            WriteLiteral(@"@cloud/pep-home-page/pc/index"">
<div class=""home-banner-zh"">
        <div class=""banner"" data-mod-name=""banner"" id=""banner"" bi_parent_name=""home-banner"" data-report=""home"">
            <div class=""carousel-container banner-container"" id=""banner-container"" style=""background-image: url()"">
                <div class=""carousel-wrapper"">


                    <div class=""carousel-slide carousel-slide-0 set-first-banner"" data-swiper-autoplay=""99999999999999999"" bi_param_rec_position=""1"" bi_param_rec_channel=""006"" bi_param_rec_source=""default"" bi_param_rec_material=""&#39;Niu&#39; Year Cloud Festival is On"" carousel-autoplay=""99999999999999999"" data-img=""https://i.ibb.co/R4dL8fV/About-09.png"" bi_parent_name=""1_https://activity.huaweicloud.com/intl/en-us/Niu_Year_Cloud_Festival/index.html"">
                        <div class=""banner-content"" data-exit-animation=""banner-fadeOut"">
                            <div class=""banner-content-bg"" data-src=""https://i.ibb.co/P9wy58w/bg10.png"" style=""filter: brightness(.");
            WriteLiteral(@"5);""></div>
                            <a class=""banner-content-inner"" bi_name=""&#39;Niu&#39; Year Cloud Festival is On"" target=""_blank"">
                                <div class=""banner-content-main"" bi_name=""&#39;Niu&#39; Year Cloud Festival is On"">
                                    <div class=""banner-content-main-inner"" bi_name=""&#39;Niu&#39; Year Cloud Festival is On"">
                                        <div class=""banner-text banner-text-pc banner-text-enter m-0"" data-enter-transition=""banner-text-enter"" data-exit-transition=""banner-exit-none"" mbtitle=""&#39;Niu&#39; Year Cloud Festival is On"" mbdesc=""$1 New User Offers，SME Support Program with $3000 coupons"" style=""margin-top: 110px !important;"">
                                            <h5 class=""text-white"">Registration</h5>
                                            <p class=""text-white d-none"" style=""white-space: normal;"">
                                                We would love to hear from you, drop us a note about what yo");
            WriteLiteral(@"u would like to discuss with us.
                                            </p>
                                            <div class=""banner-text-btn-wrapper d-none"">
                                                <div class=""banner-learn-more text-white""><span>Let us be part of your village.</span><i></i></div>
                                            </div>
                                        </div>
                                        <div class=""banner-text banner-text-mb"">
                                            <h5 class=""text-white"">Registration</h5>
                                            <p class=""text-white d-none"" style=""white-space: normal;"">We would love to hear from you, drop us a note about what you would like to discuss with us.</p>
                                        </div>
                                    </div>
                                </div>
                            </a>
                        </div>
                    </div>
       ");
            WriteLiteral("         </div>\r\n                <!--  <div class=\"carousel-indicator-wrapper\"></div> -->\r\n            </div>\r\n        </div>\r\n        <style>\r\n            ");
            WriteLiteral("@media(min-width: 1024px) {\r\n                .carousel-container {\r\n                    background: #E6F0FC;\r\n                }\r\n            }\r\n\r\n            ");
            WriteLiteral("@media (min-width: 768px) {\r\n                .banner .banner-text {\r\n                    width: 50%;\r\n                }\r\n            }\r\n        </style>\r\n    </div>\r\n");
#nullable restore
#line 58 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""home-solution"">
        <div class=""section section-solutions"">
        <div class=""por-container"">

        <table class=""bg-light"">
        <tbody>
        <tr>
        <td class=""p-5 d-block w-75 m-auto"">
        <h2 class=""mb-4 h2"">Basic Info</h2>

        <div class=""row g-3"">
        <div class=""col-sm-6"">
            <label for=""CompanyName"" class=""form-label"">Company name</label>(<span class=""text-danger"">*</span>)
            ");
#nullable restore
#line 74 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.TextBoxFor(x => x.CompanyName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 75 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.CompanyName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-6\">\r\n            <label for=\"CompanyWebsite\" class=\"form-label\">Company website</label>(<span class=\"text-danger\">*</span>)\r\n            ");
#nullable restore
#line 80 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.TextBoxFor(x => x.CompanyWebsite, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 81 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.CompanyWebsite, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-6\">\r\n            <label for=\"CompanyEstablishedYear\" class=\"form-label\">Which year was your company established</label>(<span class=\"text-danger\">*</span>)\r\n            ");
#nullable restore
#line 86 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.TextBoxFor(x => x.CompanyEstablishedYear, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 87 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.CompanyEstablishedYear, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-6\">\r\n            <label for=\"CompanyLegallyDomiciled\" class=\"form-label\">Which country was your company legally domiciled in</label>(<span class=\"text-danger\">*</span>)\r\n            ");
#nullable restore
#line 92 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.TextBoxFor(x => x.CompanyLegallyDomiciled, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 93 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.CompanyLegallyDomiciled, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-6\">\r\n            <label for=\"HuaweiCloudAccountName\" class=\"form-label\">Huawei cloud account name <sup>(if applicable)</sup></label>\r\n            ");
#nullable restore
#line 98 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.TextBoxFor(x => x.HuaweiCloudAccountName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 99 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.HuaweiCloudAccountName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-6\">\r\n            <label for=\"HuaweiCloudAccountId\" class=\"form-label\">Huawei cloud account ID <sup>(if applicable)</sup></label>\r\n            ");
#nullable restore
#line 104 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.TextBoxFor(x => x.HuaweiCloudAccountId, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 105 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.HuaweiCloudAccountId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>

        <div class=""col-sm-12""><br><hr></div>
        <div class=""col-sm-12""><h3 class=""mt-3 text-dark h3"">Founder 1</h3></div>

        <div class=""col-sm-12"">
            <label for=""Founder1Name"" class=""form-label"">Founder Name</label>(<span class=""text-danger"">*</span>)
            ");
#nullable restore
#line 113 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.TextBoxFor(x => x.Founder1Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 114 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.Founder1Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-6\">\r\n            <label for=\"Founder1Position\" class=\"form-label\">Founder Position</label>(<span class=\"text-danger\">*</span>)\r\n            ");
#nullable restore
#line 119 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.TextBoxFor(x => x.Founder1Position, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 120 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.Founder1Position, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-6\">\r\n            <label for=\"Founder1Email\" class=\"form-label\">Founder Email</label>(<span class=\"text-danger\">*</span>)\r\n            ");
#nullable restore
#line 125 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.TextBoxFor(x => x.Founder1Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 126 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.Founder1Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-6\">\r\n            <label for=\"Founder1LinkedInProfile\" class=\"form-label\">Founder LinkedIn Profile</label>(<span class=\"text-danger\">*</span>)\r\n            ");
#nullable restore
#line 131 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.TextBoxFor(x => x.Founder1LinkedInProfile, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 132 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.Founder1LinkedInProfile, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-6\">\r\n            <label for=\"Founder1Mobile\" class=\"form-label\">Founder Mobile</label>(<span class=\"text-danger\">*</span>)\r\n            ");
#nullable restore
#line 137 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.TextBoxFor(x => x.Founder1Mobile, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 138 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.Founder1Mobile, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>

        <div class=""col-sm-12""><br><hr></div>
        <div class=""col-sm-12""><h3 class=""mt-3 text-dark h3"">Founder 2</h3></div>

        <div class=""col-sm-12"">
            <label for=""Founder2Name"" class=""form-label"">Founder Name</label>
            ");
#nullable restore
#line 146 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.TextBoxFor(x => x.Founder2Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-6\">\r\n            <label for=\"Founder2Position\" class=\"form-label\">Founder Position</label>\r\n            ");
#nullable restore
#line 151 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.TextBoxFor(x => x.Founder2Position, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-6\">\r\n            <label for=\"address2\" class=\"form-label\">Founder Email</label>\r\n            ");
#nullable restore
#line 156 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.TextBoxFor(x => x.Founder2Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-6\">\r\n            <label for=\"Founder2LinkedInProfile\" class=\"form-label\">Founder LinkedIn Profile</label>\r\n            ");
#nullable restore
#line 161 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.TextBoxFor(x => x.Founder2LinkedInProfile, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-6\">\r\n            <label for=\"address2\" class=\"form-label\">Founder Mobile</label>\r\n            ");
#nullable restore
#line 166 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.TextBoxFor(x => x.Founder2Mobile, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>

        <div class=""col-sm-12""><br><hr></div>
        <div class=""col-sm-12""><h3 class=""mt-3 text-dark h3"">Company Section</h3></div>

        <div class=""col-12"">
            <label for=""CompanyBusinessKey"" class=""form-label"">Will you describe your business are a B2B or B2C or others</label>(<span class=""text-danger"">*</span>)
            ");
#nullable restore
#line 174 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.DropDownListFor(x => x.CompanyBusinessKey, new SelectList(StaticData.CompanyBusinessData, "Key", "Text"), "-- Select --", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 175 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.CompanyBusinessKey, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-6\">\r\n            <label for=\"IndustryFocusOn\" class=\"form-label\">Which industry are you focus on?</label>(<span class=\"text-danger\">*</span>)\r\n            ");
#nullable restore
#line 180 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.TextBoxFor(x => x.IndustryFocusOn, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 181 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.IndustryFocusOn, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-6\">\r\n            <label for=\"Company2BActiveClientKey\" class=\"form-label\">If you are a 2B company , how many active clients do you have?</label>(<span class=\"text-danger\">*</span>)\r\n            ");
#nullable restore
#line 186 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.DropDownListFor(x => x.Company2BActiveClientKey, new SelectList(StaticData.Company2BActiveClientData, "Key", "Text"), "-- Select --", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 187 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.Company2BActiveClientKey, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-6\">\r\n            <label for=\"ActiveUserMonthlyKey\" class=\"form-label\">How many monthly active users (MAU) do you have?</label>(<span class=\"text-danger\">*</span>)\r\n            ");
#nullable restore
#line 192 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.DropDownListFor(x => x.ActiveUserMonthlyKey, new SelectList(StaticData.ActiveUserMonthlyData, "Key", "Text"), "-- Select --", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 193 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.ActiveUserMonthlyKey, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-6\">\r\n            <label for=\"ServiceDeliveryModelKey\" class=\"form-label\">What\'s your service delivery model</label>(<span class=\"text-danger\">*</span>)\r\n            ");
#nullable restore
#line 198 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.DropDownListFor(x => x.ServiceDeliveryModelKey, new SelectList(StaticData.ServiceDeliveryModelData, "Key", "Text"), "-- Select --", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 199 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.ServiceDeliveryModelKey, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-6\">\r\n            <label for=\"FundingReceivedKey\" class=\"form-label\">How much funding (in USD) have you received so far?</label>(<span class=\"text-danger\">*</span>)\r\n            ");
#nullable restore
#line 204 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.DropDownListFor(x => x.FundingReceivedKey, new SelectList(StaticData.FundingReceivedData, "Key", "Text"), "-- Select --", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 205 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.FundingReceivedKey, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-6\">\r\n            <label for=\"Company2BAverageSaleCycleKey\" class=\"form-label\">If you are a 2B company, how long is your average sales cycle</label>(<span class=\"text-danger\">*</span>)\r\n            ");
#nullable restore
#line 210 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.DropDownListFor(x => x.Company2BAverageSaleCycleKey, new SelectList(StaticData.Company2BAverageSaleCycleData, "Key", "Text"), "-- Select --", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 211 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.Company2BAverageSaleCycleKey, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-6\">\r\n            <label for=\"Company2BAverageContractValue\" class=\"form-label\">If you are a 2B company, what\'s your average contract value</label>(<span class=\"text-danger\">*</span>)\r\n            ");
#nullable restore
#line 216 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.TextBoxFor(x => x.Company2BAverageContractValue, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 217 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.Company2BAverageContractValue, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-6\">\r\n            <label for=\"SaleRevenuePreviousYearKey\" class=\"form-label\">How much was your previous year annual sales revenue?</label>(<span class=\"text-danger\">*</span>)\r\n            ");
#nullable restore
#line 222 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.DropDownListFor(x => x.SaleRevenuePreviousYearKey, new SelectList(StaticData.SaleRevenuePreviousYearData, "Key", "Text"), "-- Select --", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 223 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.SaleRevenuePreviousYearKey, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-6\">\r\n            <label for=\"GrowthRateSaleRevenueKey\" class=\"form-label\">What\'s your yr-on-yr growth rate in terms of sales revenue?</label>(<span class=\"text-danger\">*</span>)\r\n            ");
#nullable restore
#line 228 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.DropDownListFor(x => x.GrowthRateSaleRevenueKey, new SelectList(StaticData.GrowthRateSaleRevenueData, "Key", "Text"), "-- Select --", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 229 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.GrowthRateSaleRevenueKey, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-6\">\r\n            <label for=\"CompanyFullTimeEmployeeKey\" class=\"form-label\">What\'s your company size by number of full time employees?</label>(<span class=\"text-danger\">*</span>)\r\n            ");
#nullable restore
#line 234 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.DropDownListFor(x => x.CompanyFullTimeEmployeeKey, new SelectList(StaticData.CompanyFullTimeEmployeeData, "Key", "Text"), "-- Select --", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 235 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.CompanyFullTimeEmployeeKey, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-6\">\r\n            <label for=\"CloudSetupSaaSProdiverKey\" class=\"form-label\">If you are a SaaS provider, what\'s your cloud setup (tenant model)?(<span class=\"text-danger\">*</span>)</label>\r\n            ");
#nullable restore
#line 240 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.DropDownListFor(x => x.CloudSetupSaaSProdiverKey, new SelectList(StaticData.CloudSetupSaaSProdiverData, "Key", "Text"), "-- Select --", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 241 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.CloudSetupSaaSProdiverKey, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>

        <div class=""col-sm-6"">
            <label for=""AverageMonthlySpendingOnCloudKey"" class=""form-label"">What is your average monthly spending (in USD) on cloud services e.g. IaaS, PaaS(<span class=""text-danger"">*</span>)</label>
            ");
#nullable restore
#line 246 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.DropDownListFor(x => x.AverageMonthlySpendingOnCloudKey, new SelectList(StaticData.AverageMonthlySpendingOnCloudData, "Key", "Text"), "-- Select --", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 247 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.AverageMonthlySpendingOnCloudKey, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>

        <div class=""col-sm-12""><br><hr></div>
        <div class=""col-sm-12""><h3 class=""mt-3 text-dark h3"">Feedback</h3></div>

        <div class=""col-sm-12"">
            <label for=""CloudPlatformUsing"" class=""form-label"">What cloud platforms are you currently using?</label>(<span class=""text-danger"">*</span>)
            ");
#nullable restore
#line 255 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.TextBoxFor(x => x.CloudPlatformUsing, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 256 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.CloudPlatformUsing, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-12\">\r\n            <label for=\"HeardOfHuaweiCloudBefore\" class=\"form-label\">Have you heard of Huawei Cloud before?</label>(<span class=\"text-danger\">*</span>)\r\n            ");
#nullable restore
#line 261 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.DropDownListFor(x => x.HeardOfHuaweiCloudBefore, new SelectList(StaticData.HeardOfHuaweiCloudBeforeData, "Key", "Text"), "-- Select --", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 262 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.HeardOfHuaweiCloudBefore, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-12\">\r\n            <label for=\"OverallOpinionOnHuaweiCloud\" class=\"form-label\">If you answered \"Yes\" in the previous question, how would you describe your overall opinion on Huawei Cloud?</label>\r\n            ");
#nullable restore
#line 267 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.DropDownListFor(x => x.OverallOpinionOnHuaweiCloud, new SelectList(StaticData.OverallOpinionOnHuaweiCloudData, "Key", "Text"), "-- Select --", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 268 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.OverallOpinionOnHuaweiCloud, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>

        <div class=""col-sm-12"">
            <label for=""HuaweiCloudConsiderLevel"" class=""form-label"">In a scale from 1 to 10, how likely are you to consider adopting Huawei Cloud?</label>(<span class=""text-danger"">*</span>)
            ");
#nullable restore
#line 273 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.DropDownListFor(x => x.HuaweiCloudConsiderLevel, new SelectList(StaticData.HuaweiCloudConsiderLevelData, "Key", "Text"), "-- Select --", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 274 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.HuaweiCloudConsiderLevel, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
                                        
        </div>

        <button class=""por-btn por-btn-primary mt-5 w-100"" type=""submit"" style=""line-height: normal;"">SEND</button>
        </td>
        </tr>
        <tr>
            <td class=""bg-light p-5 border d-none"" style=""vertical-align: top;"" colspan=""2"">
                <h2>Singapore</h2>
                <p>If you require any level of support, please get in touch with us via the method below:</p>
                <p><i class=""bi bi-envelope-fill position-absolute"" style=""margin-top: -.45rem;""></i><span class=""ms-4 px-2"">Support@email.com</span></p>
                <p>1234 Street Name<br>City Name, Country Name<br>Postal Code 123546</p>
            </td>
        </tr>
        </tbody>
        </table>
        </div>
        </div>
        </div>
");
#nullable restore
#line 296 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
         if (!string.IsNullOrEmpty(ViewBag.Message))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <script>\r\n                alert(\'");
#nullable restore
#line 299 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
                  Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n            </script>\r\n");
#nullable restore
#line 301 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 301 "E:\Work\Projects\HuaweiReg\HuaweiReg\Views\Registration\Index.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <script>\r\n    window.gConfig = window.gConfig || {}; window.gConfig.seed = window.gConfig.seed || [];\r\n    window.gConfig.seed.push({\r\n        name: \'");
            WriteLiteral("@cloud/pep-home-page\', data:\r\n            { \"packages\": { \"");
            WriteLiteral("@cloud/pep-home-page\": { \"path\": \"https://res.hc-cdn.com/cpage-pep-home-page-hk/1.1.7/\", \"version\": \"1.1.7\" }, \"");
            WriteLiteral("@cloud/element-entrance\": { \"path\": \"https://res.hc-cdn.com/cnpm-element-entrance/1.2.0/\", \"version\": \"1.2.0\" }, \"");
            WriteLiteral("@cloud/lazyload\": { \"path\": \"https://res.hc-cdn.com/cnpm-lazyload/2.0.6/\", \"version\": \"2.0.6\" }, \"");
            WriteLiteral("@cloud/link-to\": { \"path\": \"https://res.hc-cdn.com/cnpm-link-to/1.0.11/\", \"version\": \"1.0.11\" }, \"");
            WriteLiteral("@cloud/parallax-scroll\": { \"path\": \"https://res.hc-cdn.com/cnpm-parallax-scroll/1.0.2/\", \"version\": \"1.0.2\" }, \"");
            WriteLiteral("@cloud/xtemplate-runtime\": { \"path\": \"https://res.hc-cdn.com/cnpm-xtemplate-runtime/1.0.1/\", \"version\": \"1.0.1\" } }, \"modules\": { \"");
            WriteLiteral("@cloud/pep-home-page/m/index\": { \"requires\": [\"");
            WriteLiteral("@cloud/parallax-scroll\", \"");
            WriteLiteral("@cloud/lazyload\", \"");
            WriteLiteral("@cloud/link-to\"] }, \"");
            WriteLiteral("@cloud/pep-home-page/pc/index\": { \"requires\": [\"");
            WriteLiteral("@cloud/parallax-scroll\", \"");
            WriteLiteral("@cloud/lazyload\", \"");
            WriteLiteral("@cloud/link-to\", \"");
            WriteLiteral("@cloud/element-entrance\"] } } }\r\n    })</script>\r\n\r\n        <script src=\"js/polyfill.min.js\"></script>\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HuaweiReg.Web.Models.RegistraionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
