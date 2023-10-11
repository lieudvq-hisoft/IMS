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
    [Migration("20231010132830_seed_service")]
    partial class seed_service
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

                    b.Property<DateTime>("AllocateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateCreated")
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

                    b.Property<int>("ServerId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StopDate")
                        .HasColumnType("timestamp without time zone");

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
                            DateCreated = new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9827),
                            DateUpdated = new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9840),
                            Description = "Doanh nghiệp tư nhân",
                            IsDeleted = false,
                            Name = "Doanh nghiệp tư nhân"
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9888),
                            DateUpdated = new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9889),
                            Description = "Công ty trách nhiệm hữu hạn một thành viên",
                            IsDeleted = false,
                            Name = "Công ty trách nhiệm hữu hạn một thành viên"
                        },
                        new
                        {
                            Id = 3,
                            DateCreated = new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9904),
                            DateUpdated = new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9904),
                            Description = "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên",
                            IsDeleted = false,
                            Name = "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên"
                        },
                        new
                        {
                            Id = 4,
                            DateCreated = new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9922),
                            DateUpdated = new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9922),
                            Description = "Công ty cổ phần",
                            IsDeleted = false,
                            Name = "Công ty cổ phần"
                        },
                        new
                        {
                            Id = 5,
                            DateCreated = new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9936),
                            DateUpdated = new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9937),
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
                            DateCreated = new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9962),
                            DateUpdated = new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9962),
                            Description = "Thuê Chỗ",
                            IsDeleted = false,
                            Name = "Thuê Chỗ"
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9979),
                            DateUpdated = new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9979),
                            Description = "Thêm 1U",
                            IsDeleted = false,
                            Name = "Thêm 1U"
                        },
                        new
                        {
                            Id = 3,
                            DateCreated = new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9993),
                            DateUpdated = new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9993),
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
                            ConcurrencyStamp = "c5f7bf26-d9c8-471e-8086-450f6762dd7b",
                            CurrenNoticeCount = 0,
                            Email = "it@gmail.com",
                            EmailConfirmed = true,
                            Fullname = "Fullname2",
                            IsDeleted = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "it@gmail.com",
                            NormalizedUserName = "it",
                            PasswordHash = "AQAAAAIAAYagAAAAECujji592Rz7zyI5gHXMHV2/1ZFEhUN4V64BCXPn7mFlZgKhBMKT8a8HhMpRXGfA/A==",
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
                            ConcurrencyStamp = "5bd9a406-f60b-46ce-9c2a-ccbdfe95aeea",
                            CurrenNoticeCount = 0,
                            Email = "sale@gmail.com",
                            EmailConfirmed = true,
                            Fullname = "Fullname3",
                            IsDeleted = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "sale@gmail.com",
                            NormalizedUserName = "sale",
                            PasswordHash = "AQAAAAIAAYagAAAAEJRcv1ZqXvayfIk9eL1AT//qGn172wC+v1iG8BBrsjd1GcqjOKXO2fl+fGHtjMt0MA==",
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
                            ConcurrencyStamp = "7972ee26-6aeb-4905-9498-15afc0ff4813",
                            CurrenNoticeCount = 0,
                            Email = "manager@gmail.com",
                            EmailConfirmed = true,
                            Fullname = "Fullname4",
                            IsDeleted = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "manager@gmail.com",
                            NormalizedUserName = "manager",
                            PasswordHash = "AQAAAAIAAYagAAAAEL+IA9SZ1YE48+Gc0dftNNTowyslWf2QRC2qhWk4DUveCU583JHkjvEeMDOeKJHvWw==",
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
                            ConcurrencyStamp = "ebe87c6d-880c-43ac-90e8-b48d280a6715",
                            CurrenNoticeCount = 0,
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            Fullname = "Fullname5",
                            IsDeleted = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "admin@gmail.com",
                            NormalizedUserName = "admin",
                            PasswordHash = "AQAAAAIAAYagAAAAEAARsSQt70oLXxYcMu6lIFb0lxI0e/cFWqmbshwXDflGySLnke48Gbl1XCBcazwWgw==",
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
                        .HasForeignKey("ServerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
