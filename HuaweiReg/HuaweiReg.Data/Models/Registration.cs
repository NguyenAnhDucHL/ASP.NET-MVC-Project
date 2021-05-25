using System;
using System.ComponentModel.DataAnnotations;
using HuaweiReg.Data.IRepositories;

namespace HuaweiReg.Data.Models
{
    public class Registration : ITrackedEntity
    {
        [Key]
        public Guid Id { get; set; }

        //Basic info
        [Required, MaxLength(500)]
        public string CompanyName { get; set; }
        [MaxLength(255)]
        public string CompanyWebsite { get; set; }
        public int? CompanyEstablishedYear { get; set; }
        [MaxLength(255)]
        public string CompanyLegallyDomiciled { get; set; }
        [MaxLength(255)]
        public string HuaweiCloudAccountName { get; set; }
        [MaxLength(255)]
        public string HuaweiCloudAccountId { get; set; }

        //Founder 1
        [MaxLength(255)]
        public string Founder1Name { get; set; }
        [MaxLength(255)]
        public string Founder1Position { get; set; }
        [MaxLength(500)]
        public string Founder1LinkedInProfile { get; set; }
        [MaxLength(255)]
        public string Founder1Email { get; set; }
        [MaxLength(20)]
        public string Founder1Mobile { get; set; }

        //Founder 2
        [MaxLength(255)]
        public string Founder2Name { get; set; }
        [MaxLength(255)]
        public string Founder2Position { get; set; }
        [MaxLength(500)]
        public string Founder2LinkedInProfile { get; set; }
        [MaxLength(255)]
        public string Founder2Email { get; set; }
        [MaxLength(20)]
        public string Founder2Mobile { get; set; }

        //Company section
        [MaxLength(20)]
        public string CompanyBusiness  { get; set; }
        public int? CompanyBusinessPoint { get; set; }
        [MaxLength(255)]
        public string IndustryFocusOn { get; set; }
        public int? IndustryFocusOnPoint { get; set; }
        [MaxLength(50)]
        public string ActiveUserMonthly { get; set; }
        public int? ActiveUserMonthlyPoint { get; set; }
        [MaxLength(50)]
        public string FundingReceived { get; set; }
        public int? FundingReceivedPoint { get; set; }
        [MaxLength(500)]
        public string Company2BAverageContractValue { get; set; }
        public int? Company2BAverageContractValuePoint { get; set; }
        [MaxLength(50)]
        public string GrowthRateSaleRevenue { get; set; }
        public int? GrowthRateSaleRevenuePoint { get; set; }
        [MaxLength(50)]
        public string CloudSetupSaaSProdiver { get; set; }
        public int? CloudSetupSaaSProdiverPoint { get; set; }
        [MaxLength(50)]
        public string Company2BActiveClient { get; set; }
        public int? Company2BActiveClientPoint { get; set; }
        [MaxLength(255)]
        public string ServiceDeliveryModel { get; set; }
        public int? ServiceDeliveryModelPoint { get; set; }
        [MaxLength(50)]
        public string Company2BAverageSaleCycle { get; set; }
        public int? Company2BAverageSaleCyclePoint { get; set; }
        [MaxLength(50)]
        public string SaleRevenuePreviousYear { get; set; }
        public int? SaleRevenuePreviousYearPoint { get; set; }
        [MaxLength(50)]
        public string CompanyFullTimeEmployee { get; set; }
        public int? CompanyFullTimeEmployeePoint { get; set; }
        [MaxLength(500)]
        public string AverageMonthlySpendingOnCloud { get; set; }
        public int? AverageMonthlySpendingOnCloudPoint { get; set; }
        //Feedback
        [MaxLength(500)]
        public string CloudPlatformUsing { get; set; }
        public int? CloudPlatformUsingPoint { get; set; }
        public bool? HeardOfHuaweiCloudBefore { get; set; }
        public int? HeardOfHuaweiCloudBeforePoint { get; set; }
        [MaxLength(255)]
        public string OverallOpinionOnHuaweiCloud { get; set; }
        public int? OverallOpinionOnHuaweiCloudPoint { get; set; }
        public int? HuaweiCloudConsiderLevel { get; set; }
        public int? HuaweiCloudConsiderLevelPoint { get; set; }
        public int? TotalPoint { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }

        public string Abc { get; set; }
    }
}
