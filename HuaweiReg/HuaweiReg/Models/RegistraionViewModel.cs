using ExpressiveAnnotations.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HuaweiReg.Web.Models
{
    public class RegistraionViewModel
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Please enter your company name")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Please enter your company website")]
        [Url(ErrorMessage = "Please enter valid Url")]
        public string CompanyWebsite { get; set; }
        [Required(ErrorMessage = "Please enter your company established year")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid Number")]
        //[RegularExpression("([0-9]+)", ErrorMessage = "Please enter valid Number")]
        public string CompanyEstablishedYear { get; set; }
        [Required(ErrorMessage = "Please enter your company legally domiciled in")]
        public string CompanyLegallyDomiciled { get; set; }
        public string HuaweiCloudAccountName { get; set; }
        public string HuaweiCloudAccountId { get; set; }
        [Required(ErrorMessage = "Please enter your company founder name")]
        public string Founder1Name { get; set; }
        [Required(ErrorMessage = "Please enter your company founder position")]
        public string Founder1Position { get; set; }
        [Required(ErrorMessage = "Please enter your company founder email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Founder1Email { get; set; }
        [Required(ErrorMessage = "Please enter your company founder LinkedIn profile")]
        public string Founder1LinkedInProfile { get; set; }
        [Required(ErrorMessage = "Please enter your company founder mobile")]
        public string Founder1Mobile { get; set; }
        public string Founder2Name { get; set; }
        public string Founder2Position { get; set; }
        public string Founder2LinkedInProfile { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Founder2Email { get; set; }
        public string Founder2Mobile { get; set; }

        //Company Section
        [Required(ErrorMessage = "Please select a value")]
        public string CompanyBusinessKey { get; set; }
        [Required(ErrorMessage = "Please enter your answer")]
        public string IndustryFocusOn { get; set; }
        [Required(ErrorMessage = "Please select a value")]
        public string ActiveUserMonthlyKey { get; set; }
        [Required(ErrorMessage = "Please select a value")]
        public string FundingReceivedKey { get; set; }
        [Required(ErrorMessage = "Please enter your answer")]
        public string Company2BAverageContractValue { get; set; }
        [Required(ErrorMessage = "Please select a value")]
        public string GrowthRateSaleRevenueKey { get; set; }
        [Required(ErrorMessage = "Please select a value")]
        public string CloudSetupSaaSProdiverKey { get; set; }
        [Required(ErrorMessage = "Please select a value")]
        public string Company2BActiveClientKey { get; set; }
        [Required(ErrorMessage = "Please select a value")]
        public string ServiceDeliveryModelKey { get; set; }
        [Required(ErrorMessage = "Please select a value")]
        public string Company2BAverageSaleCycleKey { get; set; }
        [Required(ErrorMessage = "Please select a value")]
        public string SaleRevenuePreviousYearKey { get; set; }
        [Required(ErrorMessage = "Please select a value")]
        public string CompanyFullTimeEmployeeKey { get; set; }
        [Required(ErrorMessage = "Please select a value")]
        public string AverageMonthlySpendingOnCloudKey { get; set; }
        
        //Feedback
        [Required(ErrorMessage = "Please enter the cloud platforms are you currently using")]
        public string CloudPlatformUsing { get; set; }
        [Required(ErrorMessage = "Please select a value")]
        public string HeardOfHuaweiCloudBefore { get; set; }
        [RequiredIf("HeardOfHuaweiCloudBefore == '1'", ErrorMessage = "Please select a value")]
        public string OverallOpinionOnHuaweiCloud { get; set; }
        [Required(ErrorMessage = "Please select a value")]
        public string HuaweiCloudConsiderLevel { get; set; }

    }
}
