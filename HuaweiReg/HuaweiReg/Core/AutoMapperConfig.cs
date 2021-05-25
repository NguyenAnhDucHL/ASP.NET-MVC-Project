using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HuaweiReg.Common;
using HuaweiReg.Data.Models;
using HuaweiReg.Service.ServiceModels;
using HuaweiReg.Web.Models;

namespace HuaweiReg.Web.Core
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            //Create map
            CreateMap<RegistraionViewModel, RegistrationModel>()
                .ForMember(h => h.CompanyBusiness, k => k.MapFrom(x => StaticData.CompanyBusinessData.FirstOrDefault(y => y.Key == x.CompanyBusinessKey).Text))
                .ForMember(h => h.ActiveUserMonthly, k => k.MapFrom(x => StaticData.ActiveUserMonthlyData.FirstOrDefault(y => y.Key == x.ActiveUserMonthlyKey).Text))
                .ForMember(h => h.FundingReceived, k => k.MapFrom(x => StaticData.FundingReceivedData.FirstOrDefault(y => y.Key == x.FundingReceivedKey).Text))
                .ForMember(h => h.GrowthRateSaleRevenue, k => k.MapFrom(x => StaticData.GrowthRateSaleRevenueData.FirstOrDefault(y => y.Key == x.GrowthRateSaleRevenueKey).Text))
                .ForMember(h => h.CloudSetupSaaSProdiver, k => k.MapFrom(x => StaticData.CloudSetupSaaSProdiverData.FirstOrDefault(y => y.Key == x.CloudSetupSaaSProdiverKey).Text))
                .ForMember(h => h.Company2BActiveClient, k => k.MapFrom(x => StaticData.Company2BActiveClientData.FirstOrDefault(y => y.Key == x.Company2BActiveClientKey).Text))
                .ForMember(h => h.ServiceDeliveryModel, k => k.MapFrom(x => StaticData.ServiceDeliveryModelData.FirstOrDefault(y => y.Key == x.ServiceDeliveryModelKey).Text))
                .ForMember(h => h.Company2BAverageSaleCycle, k => k.MapFrom(x => StaticData.Company2BAverageSaleCycleData.FirstOrDefault(y => y.Key == x.Company2BAverageSaleCycleKey).Text))
                .ForMember(h => h.SaleRevenuePreviousYear, k => k.MapFrom(x => StaticData.SaleRevenuePreviousYearData.FirstOrDefault(y => y.Key == x.SaleRevenuePreviousYearKey).Text))
                .ForMember(h => h.CompanyFullTimeEmployee, k => k.MapFrom(x => StaticData.CompanyFullTimeEmployeeData.FirstOrDefault(y => y.Key == x.CompanyFullTimeEmployeeKey).Text))
                .ForMember(h => h.AverageMonthlySpendingOnCloud, k => k.MapFrom(x => StaticData.AverageMonthlySpendingOnCloudData.FirstOrDefault(y => y.Key == x.AverageMonthlySpendingOnCloudKey).Text))

                .ForMember(h => h.CompanyBusinessPoint, k => k.MapFrom(x => StaticData.CompanyBusinessData.FirstOrDefault(y => y.Key == x.CompanyBusinessKey).Point))
                .ForMember(h => h.ActiveUserMonthlyPoint, k => k.MapFrom(x => StaticData.ActiveUserMonthlyData.FirstOrDefault(y => y.Key == x.ActiveUserMonthlyKey).Point))
                .ForMember(h => h.FundingReceivedPoint, k => k.MapFrom(x => StaticData.FundingReceivedData.FirstOrDefault(y => y.Key == x.FundingReceivedKey).Point))
                .ForMember(h => h.GrowthRateSaleRevenuePoint, k => k.MapFrom(x => StaticData.GrowthRateSaleRevenueData.FirstOrDefault(y => y.Key == x.GrowthRateSaleRevenueKey).Point))
                .ForMember(h => h.CloudSetupSaaSProdiverPoint, k => k.MapFrom(x => StaticData.CloudSetupSaaSProdiverData.FirstOrDefault(y => y.Key == x.CloudSetupSaaSProdiverKey).Point))
                .ForMember(h => h.Company2BActiveClientPoint, k => k.MapFrom(x => StaticData.Company2BActiveClientData.FirstOrDefault(y => y.Key == x.Company2BActiveClientKey).Point))
                .ForMember(h => h.ServiceDeliveryModelPoint, k => k.MapFrom(x => StaticData.ServiceDeliveryModelData.FirstOrDefault(y => y.Key == x.ServiceDeliveryModelKey).Point))
                .ForMember(h => h.Company2BAverageSaleCyclePoint, k => k.MapFrom(x => StaticData.Company2BAverageSaleCycleData.FirstOrDefault(y => y.Key == x.Company2BAverageSaleCycleKey).Point))
                .ForMember(h => h.SaleRevenuePreviousYearPoint, k => k.MapFrom(x => StaticData.SaleRevenuePreviousYearData.FirstOrDefault(y => y.Key == x.SaleRevenuePreviousYearKey).Point))
                .ForMember(h => h.CompanyFullTimeEmployeePoint, k => k.MapFrom(x => StaticData.CompanyFullTimeEmployeeData.FirstOrDefault(y => y.Key == x.CompanyFullTimeEmployeeKey).Point))
                .ForMember(h => h.AverageMonthlySpendingOnCloudPoint, k => k.MapFrom(x => StaticData.AverageMonthlySpendingOnCloudData.FirstOrDefault(y => y.Key == x.AverageMonthlySpendingOnCloudKey).Point))
                
                .ForMember(h => h.HeardOfHuaweiCloudBefore, k => k.MapFrom(x => x.HeardOfHuaweiCloudBefore == "1"))
                .AfterMap((h, k) =>
                {
                    k.TotalPoint = k.CompanyBusinessPoint + k.ActiveUserMonthlyPoint + k.FundingReceivedPoint + k.GrowthRateSaleRevenuePoint + k.CloudSetupSaaSProdiverPoint +
                                   k.Company2BActiveClientPoint + k.ServiceDeliveryModelPoint + k.Company2BAverageSaleCyclePoint + k.SaleRevenuePreviousYearPoint + k.CompanyFullTimeEmployeePoint +
                                   k.AverageMonthlySpendingOnCloudPoint;
                });

            CreateMap<RegistrationModel, Registration>();
        }
    }
}
