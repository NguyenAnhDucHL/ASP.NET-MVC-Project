using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiReg.Common
{
    public static class StaticData
    {
        //Company Section
        public static readonly List<AnswerModel> CompanyBusinessData = new List<AnswerModel>
        {
            new AnswerModel{Key = "1", Text = "B2B", Point = 1},
            new AnswerModel{Key = "2", Text = "B2C", Point = 1},
            new AnswerModel{Key = "3", Text = "B2B2C", Point = 2},
            new AnswerModel{Key = "4", Text = "C2C", Point = 1},
            new AnswerModel{Key = "5", Text = "Others", Point = 0}
        };
        
        public static readonly List<AnswerModel> ActiveUserMonthlyData = new List<AnswerModel>
        {
            new AnswerModel{Key = "1", Text = "0 - 5K DAU", Point = 0},
            new AnswerModel{Key = "2", Text = "5K - 25K DAU", Point = 1},
            new AnswerModel{Key = "3", Text = "25K - 100K DAU", Point = 1},
            new AnswerModel{Key = "4", Text = ">100K DAU", Point = 2}
        };

        public static readonly List<AnswerModel> FundingReceivedData = new List<AnswerModel>
        {
            new AnswerModel{Key = "1", Text = "None", Point = 0},
            new AnswerModel{Key = "2", Text = "$100K - $500K", Point = 1},
            new AnswerModel{Key = "3", Text = "$500K - $1M", Point = 1},
            new AnswerModel{Key = "4", Text = "$1M - $2M", Point = 2},
            new AnswerModel{Key = "5", Text = "$2M - $5M", Point = 2},
            new AnswerModel{Key = "6", Text = "$5M - $10M", Point = 2},
            new AnswerModel{Key = "7", Text = ">$10M", Point = 2}
        };

        public static readonly List<AnswerModel> GrowthRateSaleRevenueData = new List<AnswerModel>
        {
            new AnswerModel{Key = "1", Text = "<30%", Point = 0},
            new AnswerModel{Key = "2", Text = "30% - 100%", Point = 1},
            new AnswerModel{Key = "3", Text = ">100%", Point = 2}
        };

        public static readonly List<AnswerModel> CloudSetupSaaSProdiverData = new List<AnswerModel>
        {
            new AnswerModel{Key = "1", Text = "On premise", Point = 0},
            new AnswerModel{Key = "2", Text = "Single tenant", Point = 1},
            new AnswerModel{Key = "3", Text = "Multi-tenant", Point = 2},
        };
        
        public static readonly List<AnswerModel> Company2BActiveClientData = new List<AnswerModel>
        {
            new AnswerModel{Key = "1", Text = "0 - 3 customers", Point = 0},
            new AnswerModel{Key = "2", Text = "4 - 10 customers", Point = 1},
            new AnswerModel{Key = "3", Text = ">10 customers", Point = 2}
        };
        
        // need to confirm
        public static readonly List<AnswerModel> ServiceDeliveryModelData = new List<AnswerModel>
        {
            new AnswerModel{Key = "1", Text = "Not cloud centric", Point = 0},
            new AnswerModel{Key = "2", Text = "SaaS", Point = 1},
            new AnswerModel{Key = "3", Text = "Pure SaaS", Point = 2},
            new AnswerModel{Key = "4", Text = "Others", Point = 1}
        };
        
        public static readonly List<AnswerModel> Company2BAverageSaleCycleData = new List<AnswerModel>
        {
            new AnswerModel{Key = "1", Text = "Quick sales cycle (<6m)", Point = 2},
            new AnswerModel{Key = "2", Text = "Medium sales cycle (6-12m)", Point = 1},
            new AnswerModel{Key = "3", Text = "Long sales cycle (>1yr)", Point = 0}
        };
        
        public static readonly List<AnswerModel> SaleRevenuePreviousYearData = new List<AnswerModel>
        {
            new AnswerModel{Key = "1", Text = "<$100K p.a.", Point = 0},
            new AnswerModel{Key = "2", Text = "$100K - $500K p.a.", Point = 1},
            new AnswerModel{Key = "3", Text = "$501K - $1M p.a.", Point = 1},
            new AnswerModel{Key = "4", Text = "$1M - $3M p.a.", Point = 2},
            new AnswerModel{Key = "5", Text = ">$3M p.a.", Point = 2}
        };
        
        public static readonly List<AnswerModel> CompanyFullTimeEmployeeData = new List<AnswerModel>
        {
            new AnswerModel{Key = "1", Text = "<20 FTE", Point = 0},
            new AnswerModel{Key = "2", Text = "21-70 FTE", Point = 1},
            new AnswerModel{Key = "3", Text = ">70 FTE", Point = 2}
        };
        
        public static readonly List<AnswerModel> AverageMonthlySpendingOnCloudData = new List<AnswerModel>
        {
            new AnswerModel{Key = "1", Text = "<$2K", Point = 0},
            new AnswerModel{Key = "2", Text = "$2K - $10K", Point = 1},
            new AnswerModel{Key = "3", Text = ">$10K", Point = 2}
        };

        //Feedback
        public static readonly List<AnswerModel> HeardOfHuaweiCloudBeforeData = new List<AnswerModel>
        {
            new AnswerModel{Key = "1", Text = "Yes"},
            new AnswerModel{Key = "0", Text = "No"}
        };

        public static readonly List<AnswerModel> OverallOpinionOnHuaweiCloudData = new List<AnswerModel>
        {
            new AnswerModel{Key = "1", Text = "Very favorable"},
            new AnswerModel{Key = "2", Text = "Somewhat favorable"},
            new AnswerModel{Key = "3", Text = "Neutral"},
            new AnswerModel{Key = "4", Text = "Somewhat unfavorable"},
            new AnswerModel{Key = "5", Text = "Very unfavorable"}
        };

        public static readonly List<AnswerModel> HuaweiCloudConsiderLevelData = new List<AnswerModel>
        {
            new AnswerModel{Key = "1", Text = "1"},
            new AnswerModel{Key = "2", Text = "2"},
            new AnswerModel{Key = "3", Text = "3"},
            new AnswerModel{Key = "4", Text = "4"},
            new AnswerModel{Key = "5", Text = "5"},
            new AnswerModel{Key = "6", Text = "6"},
            new AnswerModel{Key = "7", Text = "7"},
            new AnswerModel{Key = "8", Text = "8"},
            new AnswerModel{Key = "9", Text = "9"},
            new AnswerModel{Key = "10", Text = "10"}
        };
    }
}
