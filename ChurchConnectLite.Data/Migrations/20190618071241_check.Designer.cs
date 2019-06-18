﻿// <auto-generated />
using System;
using ChurchConnectLite.Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChurchConnectLite.Data.Migrations
{
    [DbContext(typeof(ChurchContext))]
    [Migration("20190618071241_check")]
    partial class check
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ChurchConnectLite.Core.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ChurchName");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ChurchConnectLite.Core.Entities.Church", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About");

                    b.Property<string>("AccountName");

                    b.Property<string>("AccountNumber");

                    b.Property<string>("Address");

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("BankName");

                    b.Property<int?>("CountryId");

                    b.Property<int?>("DenominationId");

                    b.Property<string>("Email");

                    b.Property<string>("Facebook");

                    b.Property<string>("Instagram");

                    b.Property<string>("LogoUrl");

                    b.Property<string>("Name");

                    b.Property<string>("OnlineServiceUrl");

                    b.Property<string>("Phone1");

                    b.Property<string>("Phone2");

                    b.Property<int?>("StateId");

                    b.Property<string>("Twitter");

                    b.Property<string>("Website");

                    b.Property<string>("WorshipDays");

                    b.Property<int?>("YearFounded");

                    b.HasKey("ID");

                    b.HasIndex("ApplicationUserId")
                        .IsUnique()
                        .HasFilter("[ApplicationUserId] IS NOT NULL");

                    b.HasIndex("CountryId");

                    b.HasIndex("DenominationId");

                    b.HasIndex("StateId");

                    b.ToTable("Churches");
                });

            modelBuilder.Entity("ChurchConnectLite.Core.Entities.Country", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("ChurchConnectLite.Core.Entities.Denomination", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId");

                    b.Property<DateTime?>("DateEntered");

                    b.Property<string>("Logo");

                    b.Property<string>("LogoBlobName");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Denominations");
                });

            modelBuilder.Entity("ChurchConnectLite.Core.Entities.Donation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ChurchId");

                    b.Property<string>("Email");

                    b.Property<string>("Message");

                    b.Property<decimal>("MyProperty");

                    b.Property<int?>("ReferenceId");

                    b.Property<string>("Status");

                    b.Property<int?>("TransactionID");

                    b.HasKey("ID");

                    b.HasIndex("ChurchId");

                    b.ToTable("Donations");
                });

            modelBuilder.Entity("ChurchConnectLite.Core.Entities.Image", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId");

                    b.Property<int?>("ChurchId");

                    b.Property<int?>("MinisterId");

                    b.Property<string>("PictureUrl");

                    b.HasKey("ID");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("ChurchId");

                    b.HasIndex("MinisterId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("ChurchConnectLite.Core.Entities.Minister", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About");

                    b.Property<string>("ApplicationUserId");

                    b.Property<int>("ChurchId");

                    b.Property<DateTime>("DateEntered");

                    b.Property<string>("Email");

                    b.Property<string>("FaceBook");

                    b.Property<string>("InstagramProfile");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<string>("PictureUrl");

                    b.Property<string>("Position");

                    b.Property<string>("Twitter");

                    b.HasKey("ID");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("ChurchId");

                    b.ToTable("Ministers");
                });

            modelBuilder.Entity("ChurchConnectLite.Core.Entities.State", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CountryId");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("CountryId");

                    b.ToTable("States");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ChurchConnectLite.Core.Entities.Church", b =>
                {
                    b.HasOne("ChurchConnectLite.Core.Entities.ApplicationUser", "ApplicationUser")
                        .WithOne("Churches")
                        .HasForeignKey("ChurchConnectLite.Core.Entities.Church", "ApplicationUserId");

                    b.HasOne("ChurchConnectLite.Core.Entities.Country", "Country")
                        .WithMany("Churches")
                        .HasForeignKey("CountryId");

                    b.HasOne("ChurchConnectLite.Core.Entities.Denomination", "Denominations")
                        .WithMany("Churches")
                        .HasForeignKey("DenominationId");

                    b.HasOne("ChurchConnectLite.Core.Entities.State", "State")
                        .WithMany("Churches")
                        .HasForeignKey("StateId");
                });

            modelBuilder.Entity("ChurchConnectLite.Core.Entities.Denomination", b =>
                {
                    b.HasOne("ChurchConnectLite.Core.Entities.ApplicationUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("ChurchConnectLite.Core.Entities.Donation", b =>
                {
                    b.HasOne("ChurchConnectLite.Core.Entities.Church", "Church")
                        .WithMany("Donations")
                        .HasForeignKey("ChurchId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ChurchConnectLite.Core.Entities.Image", b =>
                {
                    b.HasOne("ChurchConnectLite.Core.Entities.ApplicationUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("ChurchConnectLite.Core.Entities.Church", "Church")
                        .WithMany("Gallery")
                        .HasForeignKey("ChurchId");

                    b.HasOne("ChurchConnectLite.Core.Entities.Minister", "Minister")
                        .WithMany("Pictures")
                        .HasForeignKey("MinisterId");
                });

            modelBuilder.Entity("ChurchConnectLite.Core.Entities.Minister", b =>
                {
                    b.HasOne("ChurchConnectLite.Core.Entities.ApplicationUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("ChurchConnectLite.Core.Entities.Church", "Church")
                        .WithMany("Ministers")
                        .HasForeignKey("ChurchId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ChurchConnectLite.Core.Entities.State", b =>
                {
                    b.HasOne("ChurchConnectLite.Core.Entities.Country", "Country")
                        .WithMany("States")
                        .HasForeignKey("CountryId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ChurchConnectLite.Core.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ChurchConnectLite.Core.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ChurchConnectLite.Core.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ChurchConnectLite.Core.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
