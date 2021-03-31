using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Wooja_Inventory_Manager.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FolderName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HexCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Conditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContractDatas",
                columns: table => new
                {
                    CDId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Seller = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchasingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PurchasingValue = table.Column<int>(type: "int", nullable: false),
                    PInvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueOfGood = table.Column<int>(type: "int", nullable: false),
                    PayDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SellingPrice = table.Column<int>(type: "int", nullable: false),
                    InvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Customer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerLand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerAdres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Payed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractDatas", x => x.CDId);
                });

            migrationBuilder.CreateTable(
                name: "Extras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExtraName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraField = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Shelf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ANNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mandatories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MandatoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraField = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mandatories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RightsName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rights", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Theme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MwSt = table.Column<int>(type: "int", nullable: false),
                    DateYear = table.Column<int>(type: "int", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmongLabels = table.Column<int>(type: "int", nullable: false),
                    LabelOn = table.Column<bool>(type: "bit", nullable: false),
                    DB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Server = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Port = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PW = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Server2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConString2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Port2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PW2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicenceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicenceChecked = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stati",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stati", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfileId = table.Column<int>(type: "int", nullable: true),
                    RightsId = table.Column<int>(type: "int", nullable: true),
                    GDPR = table.Column<bool>(type: "bit", nullable: false),
                    GDPRDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TermsOfUse = table.Column<bool>(type: "bit", nullable: false),
                    TermsOfUseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExtraField = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraBoolField = table.Column<bool>(type: "bit", nullable: false),
                    MandatoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Mandatories_MandatoryId",
                        column: x => x.MandatoryId,
                        principalTable: "Mandatories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Rights_RightsId",
                        column: x => x.RightsId,
                        principalTable: "Rights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AddOns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    License = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValidyTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAbo = table.Column<bool>(type: "bit", nullable: false),
                    Interface = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Port = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Counter = table.Column<int>(type: "int", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Str1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Int1 = table.Column<int>(type: "int", nullable: false),
                    DT1 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Bool1 = table.Column<bool>(type: "bit", nullable: false),
                    SettingsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddOns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AddOns_Settings_SettingsId",
                        column: x => x.SettingsId,
                        principalTable: "Settings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Log",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastUserId = table.Column<int>(type: "int", nullable: true),
                    LastChanges = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastActivity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Log_Users_LastUserId",
                        column: x => x.LastUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FolderNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    ClassId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandId = table.Column<int>(type: "int", nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssetsId = table.Column<int>(type: "int", nullable: true),
                    CInfoCDId = table.Column<int>(type: "int", nullable: true),
                    ColorId = table.Column<int>(type: "int", nullable: true),
                    SubCategoryId = table.Column<int>(type: "int", nullable: true),
                    ConstructionYear = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: true),
                    ConditionId = table.Column<int>(type: "int", nullable: true),
                    NetAmount = table.Column<int>(type: "int", nullable: false),
                    LocalId = table.Column<int>(type: "int", nullable: true),
                    Sold = table.Column<bool>(type: "bit", nullable: false),
                    SoldToId = table.Column<int>(type: "int", nullable: true),
                    SoldById = table.Column<int>(type: "int", nullable: true),
                    SoldDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reserved = table.Column<bool>(type: "bit", nullable: false),
                    LendOutAmount = table.Column<int>(type: "int", nullable: false),
                    LendOut = table.Column<bool>(type: "bit", nullable: false),
                    LendOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LendOutToId = table.Column<int>(type: "int", nullable: true),
                    LocalSale = table.Column<bool>(type: "bit", nullable: false),
                    LastSeenOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrentInv = table.Column<bool>(type: "bit", nullable: false),
                    LogInfosId = table.Column<int>(type: "int", nullable: true),
                    Latitude = table.Column<int>(type: "int", nullable: false),
                    Longitude = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Assets_AssetsId",
                        column: x => x.AssetsId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Conditions_ConditionId",
                        column: x => x.ConditionId,
                        principalTable: "Conditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_ContractDatas_CInfoCDId",
                        column: x => x.CInfoCDId,
                        principalTable: "ContractDatas",
                        principalColumn: "CDId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Location_LocalId",
                        column: x => x.LocalId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Log_LogInfosId",
                        column: x => x.LogInfosId,
                        principalTable: "Log",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Stati_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Stati",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Users_SoldById",
                        column: x => x.SoldById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExtFields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    XStringField = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XBoolField = table.Column<bool>(type: "bit", nullable: false),
                    XIntField = table.Column<int>(type: "int", nullable: false),
                    XDateTimeField = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: true),
                    SettingsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExtFields_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExtFields_Settings_SettingsId",
                        column: x => x.SettingsId,
                        principalTable: "Settings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvSession = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MandatoryId = table.Column<int>(type: "int", nullable: true),
                    InvDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResponsiveId = table.Column<int>(type: "int", nullable: true),
                    ChangesId = table.Column<int>(type: "int", nullable: true),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraField = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inventories_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inventories_Log_ChangesId",
                        column: x => x.ChangesId,
                        principalTable: "Log",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inventories_Mandatories_MandatoryId",
                        column: x => x.MandatoryId,
                        principalTable: "Mandatories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inventories_Users_ResponsiveId",
                        column: x => x.ResponsiveId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tags_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Land = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonFN1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonSN1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNo1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonFN2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonSN2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNo2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GDPR = table.Column<bool>(type: "bit", nullable: false),
                    GDPRDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Asset = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtFieldsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_ExtFields_ExtFieldsId",
                        column: x => x.ExtFieldsId,
                        principalTable: "ExtFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AmongLabels", "CompanyName", "ConString", "ConString2", "DB", "DateYear", "LabelOn", "Language", "LicenceChecked", "LicenceType", "Logo", "MwSt", "PW", "PW2", "Port", "Port2", "ProductKey", "Server", "Server2", "Theme", "Version" },
                values: new object[] { 1, 0, "", null, null, "Sqlite", 0, false, null, null, null, null, 0, null, null, null, null, null, null, null, "Wooja", null });

            migrationBuilder.CreateIndex(
                name: "IX_AddOns_SettingsId",
                table: "AddOns",
                column: "SettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ExtFieldsId",
                table: "Customers",
                column: "ExtFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_ExtFields_ItemId",
                table: "ExtFields",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ExtFields_SettingsId",
                table: "ExtFields",
                column: "SettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_ChangesId",
                table: "Inventories",
                column: "ChangesId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_ItemId",
                table: "Inventories",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_MandatoryId",
                table: "Inventories",
                column: "MandatoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_ResponsiveId",
                table: "Inventories",
                column: "ResponsiveId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_AssetsId",
                table: "Items",
                column: "AssetsId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_BrandId",
                table: "Items",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CategoryId",
                table: "Items",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CInfoCDId",
                table: "Items",
                column: "CInfoCDId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ClassId",
                table: "Items",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ColorId",
                table: "Items",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ConditionId",
                table: "Items",
                column: "ConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_LendOutToId",
                table: "Items",
                column: "LendOutToId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_LocalId",
                table: "Items",
                column: "LocalId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_LogInfosId",
                table: "Items",
                column: "LogInfosId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_SoldById",
                table: "Items",
                column: "SoldById");

            migrationBuilder.CreateIndex(
                name: "IX_Items_SoldToId",
                table: "Items",
                column: "SoldToId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_StatusId",
                table: "Items",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_SubCategoryId",
                table: "Items",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_TypeId",
                table: "Items",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Log_LastUserId",
                table: "Log",
                column: "LastUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_ItemId",
                table: "Tags",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_MandatoryId",
                table: "Users",
                column: "MandatoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ProfileId",
                table: "Users",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RightsId",
                table: "Users",
                column: "RightsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Customers_LendOutToId",
                table: "Items",
                column: "LendOutToId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Customers_SoldToId",
                table: "Items",
                column: "SoldToId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExtFields_Settings_SettingsId",
                table: "ExtFields");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_ExtFields_ExtFieldsId",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "AddOns");

            migrationBuilder.DropTable(
                name: "Extras");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "SystemLog");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "ExtFields");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Assets");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Conditions");

            migrationBuilder.DropTable(
                name: "ContractDatas");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Log");

            migrationBuilder.DropTable(
                name: "Stati");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Mandatories");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "Rights");
        }
    }
}
