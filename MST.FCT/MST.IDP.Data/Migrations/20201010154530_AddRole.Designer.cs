﻿// <auto-generated />
using System;
using MST.IDP.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MST.IDP.Data.Migrations
{
    [DbContext(typeof(IdentityDbContext))]
    [Migration("20201010154530_AddRole")]
    partial class AddRole
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MST.IDP.Domain.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("LastLoginDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("SecurityCode")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("SecurityCodeExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("Subject")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique()
                        .HasFilter("[Username] IS NOT NULL");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a98aab29-5807-4487-94f8-08d857fdd95f"),
                            Active = true,
                            ConcurrencyStamp = "66466c6e-c1df-4ae5-96fd-0cf2e5334c56",
                            Email = "michal@gmail.com",
                            LastLoginDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Password = "AQAAAAEAACcQAAAAELh/TFL1qtIL9+07j1JbNPk7VMrJQ07QMCQD6OdJxvl0l+lXaljbphhlZcfrlNM44w==",
                            SecurityCodeExpirationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Subject = "2b6803d7-3983-4aae-a0c3-0feb52f699b6",
                            Username = "Michal"
                        });
                });

            modelBuilder.Entity("MST.IDP.Domain.UserClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaim");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f581489d-7efb-4abe-8629-c3738f4d0d1f"),
                            ConcurrencyStamp = "3357f381-5819-414b-a3d8-0b8e8d935c2f",
                            Type = "given_name",
                            UserId = new Guid("a98aab29-5807-4487-94f8-08d857fdd95f"),
                            Value = "Michal"
                        },
                        new
                        {
                            Id = new Guid("31c26452-a94d-47c6-9880-83b2afa614c6"),
                            ConcurrencyStamp = "b1e0b2b2-5091-4088-93ba-5d1eca174dc5",
                            Type = "family_name",
                            UserId = new Guid("a98aab29-5807-4487-94f8-08d857fdd95f"),
                            Value = "Stanik"
                        },
                        new
                        {
                            Id = new Guid("cdd1521a-833b-4fea-a84c-d926b2d801e2"),
                            ConcurrencyStamp = "528f2124-429c-4e4b-92ee-2bec9b4a2926",
                            Type = "country",
                            UserId = new Guid("a98aab29-5807-4487-94f8-08d857fdd95f"),
                            Value = "pl"
                        },
                        new
                        {
                            Id = new Guid("849d8138-763f-45c1-9d3e-2c42e0529f3d"),
                            ConcurrencyStamp = "dab93d6c-4d5c-425d-99b0-4ba10323a5c7",
                            Type = "role",
                            UserId = new Guid("a98aab29-5807-4487-94f8-08d857fdd95f"),
                            Value = "admin_aviation"
                        });
                });

            modelBuilder.Entity("MST.IDP.Domain.UserLogin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Provider")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ProviderIdentityKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogin");
                });

            modelBuilder.Entity("MST.IDP.Domain.UserClaim", b =>
                {
                    b.HasOne("MST.IDP.Domain.User", "User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MST.IDP.Domain.UserLogin", b =>
                {
                    b.HasOne("MST.IDP.Domain.User", "User")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}