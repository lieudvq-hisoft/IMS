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
    [Migration("20231010143121_make_allocation_server_nullable")]
    partial class make_allocation_server_nullable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Data.Entities.AdditionalService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CollocationId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<int>("ServiceId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CollocationId");

                    b.HasIndex("ServiceId");

                    b.ToTable("AdditionalServices");
                });

            modelBuilder.Entity("Data.Entities.Collocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateAllocate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateStop")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("InspectorNote")
                        .HasColumnType("text");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Note")
                        .HasColumnType("text");

                    b.Property<int?>("ServerId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ServerId");

                    b.ToTable("Collocations");
                });

            modelBuilder.Entity("Data.Entities.CompanyType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CompanyTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2023, 10, 10, 21, 31, 20, 654, DateTimeKind.Local).AddTicks(8136),
                            DateUpdated = new DateTime(2023, 10, 10, 21, 31, 20, 654, DateTimeKind.Local).AddTicks(8150),
                            Description = "Doanh nghiệp tư nhân",
                            IsDeleted = false,
                            Name = "Doanh nghiệp tư nhân"
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2023, 10, 10, 21, 31, 20, 654, DateTimeKind.Local).AddTicks(8193),
                            DateUpdated = new DateTime(2023, 10, 10, 21, 31, 20, 654, DateTimeKind.Local).AddTicks(8194),
                            Description = "Công ty trách nhiệm hữu hạn một thành viên",
                            IsDeleted = false,
                            Name = "Công ty trách nhiệm hữu hạn một thành viên"
                        },
                        new
                        {
                            Id = 3,
                            DateCreated = new DateTime(2023, 10, 10, 21, 31, 20, 654, DateTimeKind.Local).AddTicks(8207),
                            DateUpdated = new DateTime(2023, 10, 10, 21, 31, 20, 654, DateTimeKind.Local).AddTicks(8208),
                            Description = "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên",
                            IsDeleted = false,
                            Name = "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên"
                        },
                        new
                        {
                            Id = 4,
                            DateCreated = new DateTime(2023, 10, 10, 21, 31, 20, 654, DateTimeKind.Local).AddTicks(8219),
                            DateUpdated = new DateTime(2023, 10, 10, 21, 31, 20, 654, DateTimeKind.Local).AddTicks(8220),
                            Description = "Công ty cổ phần",
                            IsDeleted = false,
                            Name = "Công ty cổ phần"
                        },
                        new
                        {
                            Id = 5,
                            DateCreated = new DateTime(2023, 10, 10, 21, 31, 20, 654, DateTimeKind.Local).AddTicks(8232),
                            DateUpdated = new DateTime(2023, 10, 10, 21, 31, 20, 654, DateTimeKind.Local).AddTicks(8232),
                            Description = "Công ty hợp danh",
                            IsDeleted = false,
                            Name = "Công ty hợp danh"
                        });
                });

            modelBuilder.Entity("Data.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CompanyTypeId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("TaxNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CompanyTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Data.Entities.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BasePower")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("NumberOfPort")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Size")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Devices");
                });

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
                            Description = "Sale",
                            Name = "Sale",
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

            modelBuilder.Entity("Data.Entities.Server", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("DNS")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("DeviceId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.ToTable("Servers");
                });

            modelBuilder.Entity("Data.Entities.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2023, 10, 10, 21, 31, 20, 654, DateTimeKind.Local).AddTicks(8253),
                            DateUpdated = new DateTime(2023, 10, 10, 21, 31, 20, 654, DateTimeKind.Local).AddTicks(8253),
                            Description = "Thuê Chỗ",
                            IsDeleted = false,
                            Name = "Thuê Chỗ"
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2023, 10, 10, 21, 31, 20, 654, DateTimeKind.Local).AddTicks(8272),
                            DateUpdated = new DateTime(2023, 10, 10, 21, 31, 20, 654, DateTimeKind.Local).AddTicks(8272),
                            Description = "Thêm 1U",
                            IsDeleted = false,
                            Name = "Thêm 1U"
                        },
                        new
                        {
                            Id = 3,
                            DateCreated = new DateTime(2023, 10, 10, 21, 31, 20, 654, DateTimeKind.Local).AddTicks(8291),
                            DateUpdated = new DateTime(2023, 10, 10, 21, 31, 20, 654, DateTimeKind.Local).AddTicks(8292),
                            Description = "Công suất 100",
                            IsDeleted = false,
                            Name = "Công suất 100"
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

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("varchar(1000)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

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

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

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
                            Id = new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                            AccessFailedCount = 0,
                            Address = "Address2",
                            ConcurrencyStamp = "91ea0a0e-d0bc-42aa-8aaa-c07160093fa7",
                            CurrenNoticeCount = 0,
                            Email = "it@gmail.com",
                            EmailConfirmed = true,
                            Fullname = "Fullname2",
                            IsDeleted = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "it@gmail.com",
                            NormalizedUserName = "it",
                            PasswordHash = "AQAAAAIAAYagAAAAEJCa7nlu0zSsj9ftVxBM1PYLvfqnDpixuXcA+GnsQPTlgVokODV9nPjA8rcbcyPBbA==",
                            PhoneNumber = "0000000002",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "it"
                        },
                        new
                        {
                            Id = new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                            AccessFailedCount = 0,
                            Address = "Address3",
                            ConcurrencyStamp = "706a293f-573d-4d7f-af74-b1470a2ddff1",
                            CurrenNoticeCount = 0,
                            Email = "sale@gmail.com",
                            EmailConfirmed = true,
                            Fullname = "Fullname3",
                            IsDeleted = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "sale@gmail.com",
                            NormalizedUserName = "sale",
                            PasswordHash = "AQAAAAIAAYagAAAAEOsuOPPD4IYMSXfp0Q+ANdaFWq/oFrVL0IMA+wy+RHwUWjST73vUZ1/3g6TUL2v9sQ==",
                            PhoneNumber = "0000000003",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "sale"
                        },
                        new
                        {
                            Id = new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                            AccessFailedCount = 0,
                            Address = "Address4",
                            ConcurrencyStamp = "2eb1daa5-b596-4741-b8e4-223d4ccfe05f",
                            CurrenNoticeCount = 0,
                            Email = "manager@gmail.com",
                            EmailConfirmed = true,
                            Fullname = "Fullname4",
                            IsDeleted = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "manager@gmail.com",
                            NormalizedUserName = "manager",
                            PasswordHash = "AQAAAAIAAYagAAAAEHvp/bMbLWBhUyC3GjbSsYZn1UIilKO8VBxgP754ybjQ0sDufit/hU/8Sl1rNeh6QA==",
                            PhoneNumber = "0000000004",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "manager"
                        },
                        new
                        {
                            Id = new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                            AccessFailedCount = 0,
                            Address = "Address5",
                            ConcurrencyStamp = "835f46c4-f5f8-457c-8a73-ef0f342b6515",
                            CurrenNoticeCount = 0,
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            Fullname = "Fullname5",
                            IsDeleted = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "admin@gmail.com",
                            NormalizedUserName = "admin",
                            PasswordHash = "AQAAAAIAAYagAAAAEHBzD4zKktPgzJrhIVyXwB6j8n7IZ9KsQuHbJ3xgQwpsuFLymLQ8JBLSzGHWhIjb1Q==",
                            PhoneNumber = "0000000005",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin"
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

            modelBuilder.Entity("Data.Entities.AdditionalService", b =>
                {
                    b.HasOne("Data.Entities.Collocation", "Collocation")
                        .WithMany("ServerService")
                        .HasForeignKey("CollocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.Service", "Service")
                        .WithMany("AdditionalServices")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Collocation");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("Data.Entities.Collocation", b =>
                {
                    b.HasOne("Data.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.Server", "Server")
                        .WithMany()
                        .HasForeignKey("ServerId");

                    b.Navigation("Customer");

                    b.Navigation("Server");
                });

            modelBuilder.Entity("Data.Entities.Customer", b =>
                {
                    b.HasOne("Data.Entities.CompanyType", "CompanyType")
                        .WithMany("Customer")
                        .HasForeignKey("CompanyTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompanyType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Data.Entities.Server", b =>
                {
                    b.HasOne("Data.Entities.Device", "Device")
                        .WithMany()
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Device");
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

            modelBuilder.Entity("Data.Entities.Collocation", b =>
                {
                    b.Navigation("ServerService");
                });

            modelBuilder.Entity("Data.Entities.CompanyType", b =>
                {
                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Data.Entities.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Data.Entities.Service", b =>
                {
                    b.Navigation("AdditionalServices");
                });

            modelBuilder.Entity("Data.Entities.User", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
