﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Wooja_Inventory_Manager.Models.Context;

namespace Wooja_Inventory_Manager.Migrations
{
    [DbContext(typeof(WIMContext))]
    [Migration("20210331145216_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.AddOn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Bool1")
                        .HasColumnType("bit");

                    b.Property<int>("Counter")
                        .HasColumnType("int");

                    b.Property<DateTime>("DT1")
                        .HasColumnType("datetime2");

                    b.Property<string>("Info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Int1")
                        .HasColumnType("int");

                    b.Property<string>("Interface")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAbo")
                        .HasColumnType("bit");

                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("License")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Port")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SettingsId")
                        .HasColumnType("int");

                    b.Property<string>("Str1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ValidyTo")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SettingsId");

                    b.ToTable("AddOns");
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.Assets", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FolderName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Assets");
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HexCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.Condition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Conditions");
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.ContractData", b =>
                {
                    b.Property<int>("CDId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Customer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerAdres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerLand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InvoiceNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PInvoiceNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PayDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Payed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("PurchasingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PurchasingValue")
                        .HasColumnType("int");

                    b.Property<string>("Seller")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SellingPrice")
                        .HasColumnType("int");

                    b.Property<int>("ValueOfGood")
                        .HasColumnType("int");

                    b.HasKey("CDId");

                    b.ToTable("ContractDatas");
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Asset")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ExtFieldsId")
                        .HasColumnType("int");

                    b.Property<bool>("GDPR")
                        .HasColumnType("bit");

                    b.Property<DateTime>("GDPRDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Land")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonFN1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonFN2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonSN1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonSN2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNo1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNo2")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ExtFieldsId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.ExtFields", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ItemId")
                        .HasColumnType("int");

                    b.Property<int?>("SettingsId")
                        .HasColumnType("int");

                    b.Property<bool>("XBoolField")
                        .HasColumnType("bit");

                    b.Property<DateTime>("XDateTimeField")
                        .HasColumnType("datetime2");

                    b.Property<int>("XIntField")
                        .HasColumnType("int");

                    b.Property<string>("XStringField")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("SettingsId");

                    b.ToTable("ExtFields");
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.Extra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ExtraDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExtraField")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExtraName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Extras");
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ChangesId")
                        .HasColumnType("int");

                    b.Property<string>("ExtraField")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InvDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("InvSession")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ItemId")
                        .HasColumnType("int");

                    b.Property<int?>("MandatoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ResponsiveId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ChangesId");

                    b.HasIndex("ItemId");

                    b.HasIndex("MandatoryId");

                    b.HasIndex("ResponsiveId");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AssetsId")
                        .HasColumnType("int");

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<int?>("CInfoCDId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("ClassId")
                        .HasColumnType("int");

                    b.Property<int?>("ColorId")
                        .HasColumnType("int");

                    b.Property<int?>("ConditionId")
                        .HasColumnType("int");

                    b.Property<int>("ConstructionYear")
                        .HasColumnType("int");

                    b.Property<bool>("CurrentInv")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FolderNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastSeenOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("Latitude")
                        .HasColumnType("int");

                    b.Property<bool>("LendOut")
                        .HasColumnType("bit");

                    b.Property<int>("LendOutAmount")
                        .HasColumnType("int");

                    b.Property<DateTime>("LendOutDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LendOutToId")
                        .HasColumnType("int");

                    b.Property<int?>("LocalId")
                        .HasColumnType("int");

                    b.Property<bool>("LocalSale")
                        .HasColumnType("bit");

                    b.Property<int?>("LogInfosId")
                        .HasColumnType("int");

                    b.Property<int>("Longitude")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NetAmount")
                        .HasColumnType("int");

                    b.Property<bool>("Reserved")
                        .HasColumnType("bit");

                    b.Property<string>("SN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Sold")
                        .HasColumnType("bit");

                    b.Property<int?>("SoldById")
                        .HasColumnType("int");

                    b.Property<DateTime>("SoldDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SoldToId")
                        .HasColumnType("int");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.Property<int?>("SubCategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssetsId");

                    b.HasIndex("BrandId");

                    b.HasIndex("CInfoCDId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ClassId");

                    b.HasIndex("ColorId");

                    b.HasIndex("ConditionId");

                    b.HasIndex("LendOutToId");

                    b.HasIndex("LocalId");

                    b.HasIndex("LogInfosId");

                    b.HasIndex("SoldById");

                    b.HasIndex("SoldToId");

                    b.HasIndex("StatusId");

                    b.HasIndex("SubCategoryId");

                    b.HasIndex("TypeId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.Localization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ANNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shelf")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastActivity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastChanges")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LastUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LastUserId");

                    b.ToTable("Log");
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.Mandatory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExtraField")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MandatoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Mandatories");
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.Rights", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RightsName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rights");
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.Settings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmongLabels")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConString")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConString2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DateYear")
                        .HasColumnType("int");

                    b.Property<bool>("LabelOn")
                        .HasColumnType("bit");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicenceChecked")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicenceType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MwSt")
                        .HasColumnType("int");

                    b.Property<string>("PW")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PW2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Port")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Port2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductKey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Server")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Server2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Theme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Version")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Settings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AmongLabels = 0,
                            CompanyName = "",
                            DB = "Sqlite",
                            DateYear = 0,
                            LabelOn = false,
                            MwSt = 0,
                            Theme = "Wooja"
                        });
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stati");
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.SubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SubCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.SystemLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SystemLog");
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("TagName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ExtraBoolField")
                        .HasColumnType("bit");

                    b.Property<string>("ExtraField")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GDPR")
                        .HasColumnType("bit");

                    b.Property<DateTime>("GDPRDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MandatoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProfileId")
                        .HasColumnType("int");

                    b.Property<int?>("RightsId")
                        .HasColumnType("int");

                    b.Property<bool>("TermsOfUse")
                        .HasColumnType("bit");

                    b.Property<DateTime>("TermsOfUseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MandatoryId");

                    b.HasIndex("ProfileId");

                    b.HasIndex("RightsId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.AddOn", b =>
                {
                    b.HasOne("Wooja_Inventory_Manager.Models.Settings", null)
                        .WithMany("AddOns")
                        .HasForeignKey("SettingsId");
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.Customer", b =>
                {
                    b.HasOne("Wooja_Inventory_Manager.Models.ExtFields", "ExtFields")
                        .WithMany()
                        .HasForeignKey("ExtFieldsId");

                    b.Navigation("ExtFields");
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.ExtFields", b =>
                {
                    b.HasOne("Wooja_Inventory_Manager.Models.Item", null)
                        .WithMany("ExtFields")
                        .HasForeignKey("ItemId");

                    b.HasOne("Wooja_Inventory_Manager.Models.Settings", null)
                        .WithMany("ExtFields")
                        .HasForeignKey("SettingsId");
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.Inventory", b =>
                {
                    b.HasOne("Wooja_Inventory_Manager.Models.Log", "Changes")
                        .WithMany()
                        .HasForeignKey("ChangesId");

                    b.HasOne("Wooja_Inventory_Manager.Models.Item", null)
                        .WithMany("Inventory")
                        .HasForeignKey("ItemId");

                    b.HasOne("Wooja_Inventory_Manager.Models.Mandatory", "Mandatory")
                        .WithMany()
                        .HasForeignKey("MandatoryId");

                    b.HasOne("Wooja_Inventory_Manager.Models.User", "Responsive")
                        .WithMany()
                        .HasForeignKey("ResponsiveId");

                    b.Navigation("Changes");

                    b.Navigation("Mandatory");

                    b.Navigation("Responsive");
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.Item", b =>
                {
                    b.HasOne("Wooja_Inventory_Manager.Models.Assets", "Assets")
                        .WithMany()
                        .HasForeignKey("AssetsId");

                    b.HasOne("Wooja_Inventory_Manager.Models.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId");

                    b.HasOne("Wooja_Inventory_Manager.Models.ContractData", "CInfo")
                        .WithMany()
                        .HasForeignKey("CInfoCDId");

                    b.HasOne("Wooja_Inventory_Manager.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("Wooja_Inventory_Manager.Models.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId");

                    b.HasOne("Wooja_Inventory_Manager.Models.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId");

                    b.HasOne("Wooja_Inventory_Manager.Models.Condition", "Condition")
                        .WithMany()
                        .HasForeignKey("ConditionId");

                    b.HasOne("Wooja_Inventory_Manager.Models.Customer", "LendOutTo")
                        .WithMany()
                        .HasForeignKey("LendOutToId");

                    b.HasOne("Wooja_Inventory_Manager.Models.Localization", "Local")
                        .WithMany()
                        .HasForeignKey("LocalId");

                    b.HasOne("Wooja_Inventory_Manager.Models.Log", "LogInfos")
                        .WithMany()
                        .HasForeignKey("LogInfosId");

                    b.HasOne("Wooja_Inventory_Manager.Models.User", "SoldBy")
                        .WithMany()
                        .HasForeignKey("SoldById");

                    b.HasOne("Wooja_Inventory_Manager.Models.Customer", "SoldTo")
                        .WithMany()
                        .HasForeignKey("SoldToId");

                    b.HasOne("Wooja_Inventory_Manager.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");

                    b.HasOne("Wooja_Inventory_Manager.Models.SubCategory", "SubCategory")
                        .WithMany()
                        .HasForeignKey("SubCategoryId");

                    b.HasOne("Wooja_Inventory_Manager.Models.Type", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");

                    b.Navigation("Assets");

                    b.Navigation("Brand");

                    b.Navigation("Category");

                    b.Navigation("CInfo");

                    b.Navigation("Class");

                    b.Navigation("Color");

                    b.Navigation("Condition");

                    b.Navigation("LendOutTo");

                    b.Navigation("Local");

                    b.Navigation("LogInfos");

                    b.Navigation("SoldBy");

                    b.Navigation("SoldTo");

                    b.Navigation("Status");

                    b.Navigation("SubCategory");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.Log", b =>
                {
                    b.HasOne("Wooja_Inventory_Manager.Models.User", "LastUser")
                        .WithMany()
                        .HasForeignKey("LastUserId");

                    b.Navigation("LastUser");
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.Tag", b =>
                {
                    b.HasOne("Wooja_Inventory_Manager.Models.Item", null)
                        .WithMany("Tags")
                        .HasForeignKey("ItemId");
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.User", b =>
                {
                    b.HasOne("Wooja_Inventory_Manager.Models.Mandatory", "Mandatory")
                        .WithMany()
                        .HasForeignKey("MandatoryId");

                    b.HasOne("Wooja_Inventory_Manager.Models.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileId");

                    b.HasOne("Wooja_Inventory_Manager.Models.Rights", "Rights")
                        .WithMany()
                        .HasForeignKey("RightsId");

                    b.Navigation("Mandatory");

                    b.Navigation("Profile");

                    b.Navigation("Rights");
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.Item", b =>
                {
                    b.Navigation("ExtFields");

                    b.Navigation("Inventory");

                    b.Navigation("Tags");
                });

            modelBuilder.Entity("Wooja_Inventory_Manager.Models.Settings", b =>
                {
                    b.Navigation("AddOns");

                    b.Navigation("ExtFields");
                });
#pragma warning restore 612, 618
        }
    }
}