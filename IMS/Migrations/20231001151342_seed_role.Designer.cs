﻿// <auto-generated />
using System;
using Data.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace IMS.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231001151342_seed_role")]
    partial class seed_role
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Data.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(350)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("isDeactive")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"),
                            Description = "Customer",
                            Name = "Customer",
                            isDeactive = false
                        },
                        new
                        {
                            Id = new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                            Description = "IT Staff",
                            Name = "IT",
                            isDeactive = false
                        },
                        new
                        {
                            Id = new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                            Description = "Staff",
                            Name = "Staff",
                            isDeactive = false
                        },
                        new
                        {
                            Id = new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                            Description = "Manager",
                            Name = "Manager",
                            isDeactive = false
                        },
                        new
                        {
                            Id = new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                            Description = "Admin",
                            Name = "Admin",
                            isDeactive = false
                        });
                });

            modelBuilder.Entity("Data.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<int>("CurrenNoticeCount")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FcmToken")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(1000)");

                    b.Property<bool>("Gender")
                        .HasColumnType("boolean");

                    b.Property<bool>("IdenficationConfirm")
                        .HasColumnType("boolean");

                    b.Property<string>("IdenficationNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsGoogle")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnType("varchar(1000)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserAva")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("isBlock")
                        .HasColumnType("boolean");

                    b.Property<bool>("isDelete")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"),
                            AccessFailedCount = 0,
                            Address = "Address1",
                            Age = "21",
                            ConcurrencyStamp = "5fd4bd5e-a2eb-4d67-a651-8007e8d7ff12",
                            CurrenNoticeCount = 0,
                            Email = "member1@gmail.com",
                            EmailConfirmed = true,
                            FcmToken = "token1",
                            FirstName = "FirstName1",
                            Gender = false,
                            IdenficationConfirm = true,
                            IdenficationNumber = "001183000001",
                            IsGoogle = true,
                            LastName = "LastName1",
                            LockoutEnabled = false,
                            NormalizedEmail = "member1@gmail.com",
                            NormalizedUserName = "member1@gmail.com",
                            PasswordHash = "AQAAAAIAAYagAAAAEOgvmD9SMN1iSWn0hq3HppVUxZu0KVqvtQzjthfFTbgpR75Q6qyuvdCn9pxtVIWSOQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserAva = "Avatar1",
                            UserName = "user1",
                            isBlock = true,
                            isDelete = false
                        },
                        new
                        {
                            Id = new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                            AccessFailedCount = 0,
                            Address = "Address2",
                            Age = "22",
                            ConcurrencyStamp = "78fab7eb-987a-45b1-8514-43d0a5366421",
                            CurrenNoticeCount = 0,
                            Email = "member2@gmail.com",
                            EmailConfirmed = true,
                            FcmToken = "token2",
                            FirstName = "FirstName2",
                            Gender = true,
                            IdenficationConfirm = true,
                            IdenficationNumber = "001183000001",
                            IsGoogle = true,
                            LastName = "LastName2",
                            LockoutEnabled = false,
                            NormalizedEmail = "member2@gmail.com",
                            NormalizedUserName = "member2@gmail.com",
                            PasswordHash = "AQAAAAIAAYagAAAAEILXRvlHgT1k+kH7RQf2m9msyb4JamN6UJ0CqFq/pSoRcJven7qtmdzlDpdZoOIWRQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserAva = "Avatar2",
                            UserName = "user2",
                            isBlock = true,
                            isDelete = false
                        },
                        new
                        {
                            Id = new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                            AccessFailedCount = 0,
                            Address = "Address3",
                            Age = "23",
                            ConcurrencyStamp = "9ac8c526-d3e0-4bff-8205-830860994d50",
                            CurrenNoticeCount = 0,
                            Email = "member3@gmail.com",
                            EmailConfirmed = true,
                            FcmToken = "token3",
                            FirstName = "FirstName3",
                            Gender = false,
                            IdenficationConfirm = true,
                            IdenficationNumber = "001183000001",
                            IsGoogle = true,
                            LastName = "LastName3",
                            LockoutEnabled = false,
                            NormalizedEmail = "member3@gmail.com",
                            NormalizedUserName = "member3@gmail.com",
                            PasswordHash = "AQAAAAIAAYagAAAAEFC7OmboX8roYX/mwnT3rL3VggyTUR+E/dwH/KEvRpSWGu672O95rBW74+nofQgS9A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserAva = "Avatar3",
                            UserName = "user3",
                            isBlock = true,
                            isDelete = false
                        },
                        new
                        {
                            Id = new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                            AccessFailedCount = 0,
                            Address = "Address4",
                            Age = "24",
                            ConcurrencyStamp = "3dc335a2-7988-4c99-92a6-ee50e6423f7d",
                            CurrenNoticeCount = 0,
                            Email = "member4@gmail.com",
                            EmailConfirmed = true,
                            FcmToken = "token4",
                            FirstName = "FirstName4",
                            Gender = true,
                            IdenficationConfirm = true,
                            IdenficationNumber = "001183000001",
                            IsGoogle = true,
                            LastName = "LastName4",
                            LockoutEnabled = false,
                            NormalizedEmail = "member4@gmail.com",
                            NormalizedUserName = "member4@gmail.com",
                            PasswordHash = "AQAAAAIAAYagAAAAEI9yQL7+69r0x12jUtYmFynGfwowEBOQF135UeNpigJPoWuCgsLDV11h7F/RVPyLIA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserAva = "Avatar4",
                            UserName = "user4",
                            isBlock = true,
                            isDelete = false
                        },
                        new
                        {
                            Id = new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                            AccessFailedCount = 0,
                            Address = "Address5",
                            Age = "25",
                            ConcurrencyStamp = "8c3e34c4-7b8e-4dbf-b85f-118afb242587",
                            CurrenNoticeCount = 0,
                            Email = "member5@gmail.com",
                            EmailConfirmed = true,
                            FcmToken = "token5",
                            FirstName = "FirstName5",
                            Gender = false,
                            IdenficationConfirm = true,
                            IdenficationNumber = "001183000001",
                            IsGoogle = true,
                            LastName = "LastName5",
                            LockoutEnabled = false,
                            NormalizedEmail = "member5@gmail.com",
                            NormalizedUserName = "member5@gmail.com",
                            PasswordHash = "AQAAAAIAAYagAAAAEJzun7bk+ei4RcVltKdIfTH3uiqM4TdO8JSyte+Y693u2BkItzO5a90wp+Z9FmL0nQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserAva = "Avatar5",
                            UserName = "user5",
                            isBlock = true,
                            isDelete = false
                        });
                });

            modelBuilder.Entity("Data.Entities.UserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"),
                            RoleId = new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4")
                        },
                        new
                        {
                            UserId = new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                            RoleId = new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1")
                        },
                        new
                        {
                            UserId = new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                            RoleId = new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd")
                        },
                        new
                        {
                            UserId = new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                            RoleId = new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba")
                        },
                        new
                        {
                            UserId = new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                            RoleId = new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Data.Entities.UserRole", b =>
                {
                    b.HasOne("Data.Entities.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Data.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Entities.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Data.Entities.User", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
