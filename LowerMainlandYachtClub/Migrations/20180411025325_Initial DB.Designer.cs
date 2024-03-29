﻿// <auto-generated />
using LowerMainlandYachtClub.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace LowerMainlandYachtClub.Migrations
{
    [DbContext(typeof(YachtClubDbContext))]
    [Migration("20180411025325_Initial DB")]
    partial class InitialDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LowerMainlandYachtClub.Models.Boat", b =>
                {
                    b.Property<string>("BoatId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreditsPerHour");

                    b.Property<string>("Description");

                    b.Property<int>("Length");

                    b.Property<string>("Make");

                    b.Property<string>("Name");

                    b.Property<byte[]>("Photo");

                    b.Property<string>("Status");

                    b.Property<int>("Year");

                    b.HasKey("BoatId");

                    b.ToTable("Boat");
                });

            modelBuilder.Entity("LowerMainlandYachtClub.Models.Booking", b =>
                {
                    b.Property<string>("BookingId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BoatId");

                    b.Property<int>("CreditsUsed");

                    b.Property<DateTime>("EndDateTime");

                    b.Property<string>("Id");

                    b.Property<string>("Itinerary");

                    b.Property<DateTime>("StartDateTime");

                    b.HasKey("BookingId");

                    b.HasIndex("BoatId");

                    b.HasIndex("Id");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("LowerMainlandYachtClub.Models.ClassificationCode", b =>
                {
                    b.Property<string>("CodeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Classification");

                    b.HasKey("CodeId");

                    b.ToTable("ClassificationCodes");
                });

            modelBuilder.Entity("LowerMainlandYachtClub.Models.Document", b =>
                {
                    b.Property<string>("DocumentId")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("Content");

                    b.Property<string>("ContentType");

                    b.Property<string>("DocumentName");

                    b.Property<string>("Id");

                    b.HasKey("DocumentId");

                    b.HasIndex("Id");

                    b.ToTable("Document");
                });

            modelBuilder.Entity("LowerMainlandYachtClub.Models.EmergencyContact", b =>
                {
                    b.Property<string>("EmergencyContactId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name1");

                    b.Property<string>("Name2");

                    b.Property<string>("Phone1");

                    b.Property<string>("Phone2");

                    b.HasKey("EmergencyContactId");

                    b.ToTable("EmergencyContact");
                });

            modelBuilder.Entity("LowerMainlandYachtClub.Models.Member", b =>
                {
                    b.Property<string>("BookingId");

                    b.Property<string>("UserId");

                    b.HasKey("BookingId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Member");
                });

            modelBuilder.Entity("LowerMainlandYachtClub.Models.NonMember", b =>
                {
                    b.Property<string>("NonMemberId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BookingId");

                    b.Property<string>("Name");

                    b.HasKey("NonMemberId");

                    b.HasIndex("BookingId");

                    b.ToTable("NonMember");
                });

            modelBuilder.Entity("LowerMainlandYachtClub.Models.Report", b =>
                {
                    b.Property<string>("ReportID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Approved");

                    b.Property<string>("CodeId");

                    b.Property<string>("Content");

                    b.Property<DateTime>("DateCreated");

                    b.Property<int>("Hours");

                    b.Property<string>("Id");

                    b.Property<string>("UserId");

                    b.HasKey("ReportID");

                    b.HasIndex("CodeId");

                    b.HasIndex("UserId");

                    b.ToTable("Report");
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
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

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

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

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

            modelBuilder.Entity("OpenIddict.Models.OpenIddictApplication", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClientId")
                        .IsRequired();

                    b.Property<string>("ClientSecret");

                    b.Property<string>("ConcurrencyToken")
                        .IsConcurrencyToken();

                    b.Property<string>("ConsentType");

                    b.Property<string>("DisplayName");

                    b.Property<string>("Permissions");

                    b.Property<string>("PostLogoutRedirectUris");

                    b.Property<string>("Properties");

                    b.Property<string>("RedirectUris");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ClientId")
                        .IsUnique();

                    b.ToTable("OpenIddictApplications");
                });

            modelBuilder.Entity("OpenIddict.Models.OpenIddictAuthorization", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationId");

                    b.Property<string>("ConcurrencyToken")
                        .IsConcurrencyToken();

                    b.Property<string>("Properties");

                    b.Property<string>("Scopes");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<string>("Subject")
                        .IsRequired();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.ToTable("OpenIddictAuthorizations");
                });

            modelBuilder.Entity("OpenIddict.Models.OpenIddictScope", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyToken")
                        .IsConcurrencyToken();

                    b.Property<string>("Description");

                    b.Property<string>("DisplayName");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Properties");

                    b.Property<string>("Resources");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("OpenIddictScopes");
                });

            modelBuilder.Entity("OpenIddict.Models.OpenIddictToken", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationId");

                    b.Property<string>("AuthorizationId");

                    b.Property<string>("ConcurrencyToken")
                        .IsConcurrencyToken();

                    b.Property<DateTimeOffset?>("CreationDate");

                    b.Property<DateTimeOffset?>("ExpirationDate");

                    b.Property<string>("Payload");

                    b.Property<string>("Properties");

                    b.Property<string>("ReferenceId");

                    b.Property<string>("Status");

                    b.Property<string>("Subject")
                        .IsRequired();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.HasIndex("AuthorizationId");

                    b.HasIndex("ReferenceId")
                        .IsUnique()
                        .HasFilter("[ReferenceId] IS NOT NULL");

                    b.ToTable("OpenIddictTokens");
                });

            modelBuilder.Entity("LowerMainlandYachtClub.Models.User", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<int>("Credits");

                    b.Property<string>("EmergencyContactId");

                    b.Property<string>("FirstName");

                    b.Property<string>("HomePhone");

                    b.Property<string>("LastName");

                    b.Property<string>("MemberStatus");

                    b.Property<string>("MobilePhone");

                    b.Property<string>("PostalCode");

                    b.Property<string>("Province");

                    b.Property<string>("SailingExperience");

                    b.Property<string>("SailingQualifications");

                    b.Property<string>("Skills");

                    b.Property<string>("SkipperStatus");

                    b.Property<string>("Street");

                    b.Property<string>("WorkPhone");

                    b.HasIndex("EmergencyContactId");

                    b.ToTable("User");

                    b.HasDiscriminator().HasValue("User");
                });

            modelBuilder.Entity("LowerMainlandYachtClub.Models.Booking", b =>
                {
                    b.HasOne("LowerMainlandYachtClub.Models.Boat", "Boat")
                        .WithMany("Bookings")
                        .HasForeignKey("BoatId");

                    b.HasOne("LowerMainlandYachtClub.Models.User", "User")
                        .WithMany("Bookings")
                        .HasForeignKey("Id");
                });

            modelBuilder.Entity("LowerMainlandYachtClub.Models.Document", b =>
                {
                    b.HasOne("LowerMainlandYachtClub.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("Id");
                });

            modelBuilder.Entity("LowerMainlandYachtClub.Models.Member", b =>
                {
                    b.HasOne("LowerMainlandYachtClub.Models.Booking", "Booking")
                        .WithMany("Members")
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LowerMainlandYachtClub.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LowerMainlandYachtClub.Models.NonMember", b =>
                {
                    b.HasOne("LowerMainlandYachtClub.Models.Booking", "Booking")
                        .WithMany("NonMembers")
                        .HasForeignKey("BookingId");
                });

            modelBuilder.Entity("LowerMainlandYachtClub.Models.Report", b =>
                {
                    b.HasOne("LowerMainlandYachtClub.Models.ClassificationCode", "Code")
                        .WithMany()
                        .HasForeignKey("CodeId");

                    b.HasOne("LowerMainlandYachtClub.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OpenIddict.Models.OpenIddictAuthorization", b =>
                {
                    b.HasOne("OpenIddict.Models.OpenIddictApplication", "Application")
                        .WithMany("Authorizations")
                        .HasForeignKey("ApplicationId");
                });

            modelBuilder.Entity("OpenIddict.Models.OpenIddictToken", b =>
                {
                    b.HasOne("OpenIddict.Models.OpenIddictApplication", "Application")
                        .WithMany("Tokens")
                        .HasForeignKey("ApplicationId");

                    b.HasOne("OpenIddict.Models.OpenIddictAuthorization", "Authorization")
                        .WithMany("Tokens")
                        .HasForeignKey("AuthorizationId");
                });

            modelBuilder.Entity("LowerMainlandYachtClub.Models.User", b =>
                {
                    b.HasOne("LowerMainlandYachtClub.Models.EmergencyContact", "EmergencyContacts")
                        .WithMany()
                        .HasForeignKey("EmergencyContactId");
                });
#pragma warning restore 612, 618
        }
    }
}
