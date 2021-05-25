using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiReg.Service.ServiceModels
{
    public class RegistrationModel
    {
        public Guid Id { get; set; }

        //Basic info
        public string CompanyName { get; set; }
        public string CompanyWebsite { get; set; }
        public int? CompanyEstablishedYear { get; set; }
        public string CompanyLegallyDomiciled { get; set; }
        public string HuaweiCloudAccountName { get; set; }
        public string HuaweiCloudAccountId { get; set; }

        //Founder 1
        public string Founder1Name { get; set; }
        public string Founder1Position { get; set; }
        public string Founder1LinkedInProfile { get; set; }
        public string Founder1Email { get; set; }
        public string Founder1Mobile { get; set; }

        //Founder 2
        public string Founder2Name { get; set; }
        public string Founder2Position { get; set; }
        public string Founder2LinkedInProfile { get; set; }
        public string Founder2Email { get; set; }
        public string Founder2Mobile { get; set; }

        //Company section
        public string CompanyBusiness  { get; set; }
        public int? CompanyBusinessPoint { get; set; }
        public string IndustryFocusOn { get; set; }
        public int? IndustryFocusOnPoint { get; set; }
        public string ActiveUserMonthly { get; set; }
        public int? ActiveUserMonthlyPoint { get; set; }
        public string FundingReceived { get; set; }
        public int? FundingReceivedPoint { get; set; }
        public string Company2BAverageContractValue { get; set; }
        public int? Company2BAverageContractValuePoint { get; set; }
        public string GrowthRateSaleRevenue { get; set; }
        public int? GrowthRateSaleRevenuePoint { get; set; }
        public string CloudSetupSaaSProdiver { get; set; }
        public int? CloudSetupSaaSProdiverPoint { get; set; }
        public string Company2BActiveClient { get; set; }
        public int? Company2BActiveClientPoint { get; set; }
        public string ServiceDeliveryModel { get; set; }
        public int? ServiceDeliveryModelPoint { get; set; }
        public string Company2BAverageSaleCycle { get; set; }
        public int? Company2BAverageSaleCyclePoint { get; set; }
        public string SaleRevenuePreviousYear { get; set; }
        public int? SaleRevenuePreviousYearPoint { get; set; }
        public string CompanyFullTimeEmployee { get; set; }
        public int? CompanyFullTimeEmployeePoint { get; set; }
        public string AverageMonthlySpendingOnCloud { get; set; }
        public int? AverageMonthlySpendingOnCloudPoint { get; set; }
        //Feedback
        public string CloudPlatformUsing { get; set; }
        public int? CloudPlatformUsingPoint { get; set; }
        public bool? HeardOfHuaweiCloudBefore { get; set; }
        public int? HeardOfHuaweiCloudBeforePoint { get; set; }
        public string OverallOpinionOnHuaweiCloud { get; set; }
        public int? OverallOpinionOnHuaweiCloudPoint { get; set; }
        public int? HuaweiCloudConsiderLevel { get; set; }
        public int? HuaweiCloudConsiderLevelPoint { get; set; }
        public int? TotalPoint { get; set; }
    }
}
