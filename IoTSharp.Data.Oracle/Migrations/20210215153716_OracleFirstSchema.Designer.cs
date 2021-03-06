﻿// <auto-generated />
using System;
using IoTSharp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

namespace IoTSharp.Data.Oracle.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210215153716_OracleFirstSchema")]
    partial class OracleFirstSchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IoTSharp.Data.AuditLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("RAW(16)");

                    b.Property<string>("ActionData")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("ActionName")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("ActionResult")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("ActiveDateTime")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("RAW(16)");

                    b.Property<Guid>("ObjectID")
                        .HasColumnType("RAW(16)");

                    b.Property<string>("ObjectName")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("ObjectType")
                        .HasColumnType("NUMBER(10)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("RAW(16)");

                    b.Property<string>("UserId")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("UserName")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("TenantId");

                    b.ToTable("AuditLog");
                });

            modelBuilder.Entity("IoTSharp.Data.AuthorizedKey", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("RAW(16)");

                    b.Property<string>("AuthToken")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("RAW(16)");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("RAW(16)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("TenantId");

                    b.ToTable("AuthorizedKeys");
                });

            modelBuilder.Entity("IoTSharp.Data.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("RAW(16)");

                    b.Property<string>("Address")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("City")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Country")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Email")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Phone")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Province")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Street")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("RAW(16)");

                    b.Property<int>("ZipCode")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("TenantId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("IoTSharp.Data.DataStorage", b =>
                {
                    b.Property<int>("Catalog")
                        .HasColumnType("NUMBER(10)");

                    b.Property<Guid>("DeviceId")
                        .HasColumnType("RAW(16)");

                    b.Property<string>("KeyName")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<int>("DataSide")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("Type")
                        .HasColumnType("NUMBER(10)");

                    b.Property<byte[]>("Value_Binary")
                        .HasColumnType("RAW(2000)");

                    b.Property<bool>("Value_Boolean")
                        .HasColumnType("NUMBER(1)");

                    b.Property<DateTime>("Value_DateTime")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<double>("Value_Double")
                        .HasColumnType("BINARY_DOUBLE");

                    b.Property<string>("Value_Json")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<long>("Value_Long")
                        .HasColumnType("NUMBER(19)");

                    b.Property<string>("Value_String")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Value_XML")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Catalog", "DeviceId", "KeyName");

                    b.HasIndex("Catalog");

                    b.HasIndex("Catalog", "DeviceId");

                    b.ToTable("DataStorage");

                    b.HasDiscriminator<int>("Catalog").HasValue(0);
                });

            modelBuilder.Entity("IoTSharp.Data.Device", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("RAW(16)");

                    b.Property<Guid?>("AuthorizedKeyId")
                        .HasColumnType("RAW(16)");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("RAW(16)");

                    b.Property<int>("DeviceType")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime>("LastActive")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool>("Online")
                        .HasColumnType("NUMBER(1)");

                    b.Property<Guid?>("OwnerId")
                        .HasColumnType("RAW(16)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("RAW(16)");

                    b.Property<int>("Timeout")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorizedKeyId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("TenantId");

                    b.ToTable("Device");

                    b.HasDiscriminator<int>("DeviceType").HasValue(0);
                });

            modelBuilder.Entity("IoTSharp.Data.DeviceIdentity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("RAW(16)");

                    b.Property<Guid?>("DeviceId")
                        .HasColumnType("RAW(16)");

                    b.Property<string>("IdentityId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("IdentityType")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("IdentityValue")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.ToTable("DeviceIdentities");
                });

            modelBuilder.Entity("IoTSharp.Data.Relationship", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("RAW(16)");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("RAW(16)");

                    b.Property<string>("IdentityUserId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("RAW(16)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("IdentityUserId");

                    b.HasIndex("TenantId");

                    b.ToTable("Relationship");
                });

            modelBuilder.Entity("IoTSharp.Data.TelemetryData", b =>
                {
                    b.Property<Guid>("DeviceId")
                        .HasColumnType("RAW(16)");

                    b.Property<string>("KeyName")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("DataSide")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("Type")
                        .HasColumnType("NUMBER(10)");

                    b.Property<byte[]>("Value_Binary")
                        .HasColumnType("RAW(2000)");

                    b.Property<bool>("Value_Boolean")
                        .HasColumnType("NUMBER(1)");

                    b.Property<DateTime>("Value_DateTime")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<double>("Value_Double")
                        .HasColumnType("BINARY_DOUBLE");

                    b.Property<string>("Value_Json")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<long>("Value_Long")
                        .HasColumnType("NUMBER(19)");

                    b.Property<string>("Value_String")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Value_XML")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("DeviceId", "KeyName", "DateTime");

                    b.HasIndex("DeviceId");

                    b.HasIndex("KeyName");

                    b.HasIndex("DeviceId", "KeyName");

                    b.ToTable("TelemetryData");
                });

            modelBuilder.Entity("IoTSharp.Data.Tenant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("RAW(16)");

                    b.Property<string>("Address")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("City")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Country")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("EMail")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Phone")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Province")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Street")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("ZipCode")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.ToTable("Tenant");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("NVARCHAR2(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("NVARCHAR2(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("\"NormalizedName\" IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("NVARCHAR2(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("NUMBER(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("NUMBER(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TIMESTAMP(7) WITH TIME ZONE");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("NVARCHAR2(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("NVARCHAR2(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("NUMBER(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("NUMBER(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("NVARCHAR2(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("\"NormalizedUserName\" IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("Value")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("IoTSharp.Data.AttributeLatest", b =>
                {
                    b.HasBaseType("IoTSharp.Data.DataStorage");

                    b.HasDiscriminator().HasValue(2);
                });

            modelBuilder.Entity("IoTSharp.Data.TelemetryLatest", b =>
                {
                    b.HasBaseType("IoTSharp.Data.DataStorage");

                    b.HasDiscriminator().HasValue(4);
                });

            modelBuilder.Entity("IoTSharp.Data.Gateway", b =>
                {
                    b.HasBaseType("IoTSharp.Data.Device");

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("IoTSharp.Data.AuditLog", b =>
                {
                    b.HasOne("IoTSharp.Data.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("IoTSharp.Data.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId");

                    b.Navigation("Customer");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("IoTSharp.Data.AuthorizedKey", b =>
                {
                    b.HasOne("IoTSharp.Data.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("IoTSharp.Data.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId");

                    b.Navigation("Customer");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("IoTSharp.Data.Customer", b =>
                {
                    b.HasOne("IoTSharp.Data.Tenant", "Tenant")
                        .WithMany("Customers")
                        .HasForeignKey("TenantId");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("IoTSharp.Data.Device", b =>
                {
                    b.HasOne("IoTSharp.Data.AuthorizedKey", null)
                        .WithMany("Devices")
                        .HasForeignKey("AuthorizedKeyId");

                    b.HasOne("IoTSharp.Data.Customer", "Customer")
                        .WithMany("Devices")
                        .HasForeignKey("CustomerId");

                    b.HasOne("IoTSharp.Data.Gateway", "Owner")
                        .WithMany("Children")
                        .HasForeignKey("OwnerId");

                    b.HasOne("IoTSharp.Data.Tenant", "Tenant")
                        .WithMany("Devices")
                        .HasForeignKey("TenantId");

                    b.Navigation("Customer");

                    b.Navigation("Owner");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("IoTSharp.Data.DeviceIdentity", b =>
                {
                    b.HasOne("IoTSharp.Data.Device", "Device")
                        .WithMany()
                        .HasForeignKey("DeviceId");

                    b.Navigation("Device");
                });

            modelBuilder.Entity("IoTSharp.Data.Relationship", b =>
                {
                    b.HasOne("IoTSharp.Data.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId");

                    b.HasOne("IoTSharp.Data.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId");

                    b.Navigation("Customer");

                    b.Navigation("IdentityUser");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IoTSharp.Data.AuthorizedKey", b =>
                {
                    b.Navigation("Devices");
                });

            modelBuilder.Entity("IoTSharp.Data.Customer", b =>
                {
                    b.Navigation("Devices");
                });

            modelBuilder.Entity("IoTSharp.Data.Tenant", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("Devices");
                });

            modelBuilder.Entity("IoTSharp.Data.Gateway", b =>
                {
                    b.Navigation("Children");
                });
#pragma warning restore 612, 618
        }
    }
}
