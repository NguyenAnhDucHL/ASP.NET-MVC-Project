using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HuaweiReg.Data.Migrations
{
    public partial class UpdateRegistrationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HuaweiCloudPoint",
                table: "Registrations",
                newName: "TotalPoint");

            migrationBuilder.AddColumn<int>(
                name: "ActiveUserMonthlyPoint",
                table: "Registrations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AverageMonthlySpendingOnCloudPoint",
                table: "Registrations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CloudPlatformUsingPoint",
                table: "Registrations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CloudSetupSaaSProdiverPoint",
                table: "Registrations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Company2BActiveClientPoint",
                table: "Registrations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Company2BAverageContractValuePoint",
                table: "Registrations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Company2BAverageSaleCyclePoint",
                table: "Registrations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyBusinessPoint",
                table: "Registrations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyFullTimeEmployeePoint",
                table: "Registrations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FundingReceivedPoint",
                table: "Registrations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GrowthRateSaleRevenuePoint",
                table: "Registrations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HeardOfHuaweiCloudBeforePoint",
                table: "Registrations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HuaweiCloudConsiderLevel",
                table: "Registrations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HuaweiCloudConsiderLevelPoint",
                table: "Registrations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IndustryFocusOnPoint",
                table: "Registrations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OverallOpinionOnHuaweiCloudPoint",
                table: "Registrations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SaleRevenuePreviousYearPoint",
                table: "Registrations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServiceDeliveryModelPoint",
                table: "Registrations",
                type: "int",
                nullable: true);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActiveUserMonthlyPoint",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "AverageMonthlySpendingOnCloudPoint",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "CloudPlatformUsingPoint",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "CloudSetupSaaSProdiverPoint",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "Company2BActiveClientPoint",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "Company2BAverageContractValuePoint",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "Company2BAverageSaleCyclePoint",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "CompanyBusinessPoint",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "CompanyFullTimeEmployeePoint",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "FundingReceivedPoint",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "GrowthRateSaleRevenuePoint",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "HeardOfHuaweiCloudBeforePoint",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "HuaweiCloudConsiderLevel",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "HuaweiCloudConsiderLevelPoint",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "IndustryFocusOnPoint",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "OverallOpinionOnHuaweiCloudPoint",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "SaleRevenuePreviousYearPoint",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "ServiceDeliveryModelPoint",
                table: "Registrations");

            migrationBuilder.RenameColumn(
                name: "TotalPoint",
                table: "Registrations",
                newName: "HuaweiCloudPoint");

        }
    }
}
