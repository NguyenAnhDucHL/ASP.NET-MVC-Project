using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HuaweiReg.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Registrations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CompanyWebsite = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CompanyEstablishedYear = table.Column<int>(type: "int", nullable: true),
                    CompanyLegallyDomiciled = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    HuaweiCloudAccountName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    HuaweiCloudAccountId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Founder1Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Founder1Position = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Founder1LinkedInProfile = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Founder1Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Founder1Mobile = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Founder2Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Founder2Position = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Founder2LinkedInProfile = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Founder2Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Founder2Mobile = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CompanyBusiness = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    IndustryFocusOn = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ActiveUserMonthly = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FundingReceived = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Company2BAverageContractValue = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    GrowthRateSaleRevenue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CloudSetupSaaSProdiver = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Company2BActiveClient = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ServiceDeliveryModel = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Company2BAverageSaleCycle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SaleRevenuePreviousYear = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CompanyFullTimeEmployee = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AverageMonthlySpendingOnCloud = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CloudPlatformUsing = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    HeardOfHuaweiCloudBefore = table.Column<bool>(type: "bit", nullable: true),
                    OverallOpinionOnHuaweiCloud = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    HuaweiCloudPoint = table.Column<int>(type: "int", nullable: true),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "F89F39DE-D9B1-4B2A-9857-AD2C7F4895E5", "f8d616ca-892b-4576-946f-fb35e4cf31b1", "ADMIN", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LastUpdatedBy", "LastUpdatedDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "40DB3A70-9EE6-4CF3-997A-C6262C622A47", 0, "2baa3ea1-5eb9-440f-99a9-952549221791", "admin@gmail.com", false, "SYSTEM", new DateTime(2021, 5, 4, 10, 24, 28, 899, DateTimeKind.Local).AddTicks(964), false, null, null, null, "AQAAAAEAACcQAAAAELuPdKD2QVKAo4wWNOE9eVLKmb9QMVWqCljWC2/rsSnuAZqivkujgtKJXbQ4hav7fg==", null, false, "b25ec0b6-8f90-4ffd-aa3f-d2c185cc4554", false, "Administrator" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "F89F39DE-D9B1-4B2A-9857-AD2C7F4895E5", "40DB3A70-9EE6-4CF3-997A-C6262C622A47" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Registrations");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
