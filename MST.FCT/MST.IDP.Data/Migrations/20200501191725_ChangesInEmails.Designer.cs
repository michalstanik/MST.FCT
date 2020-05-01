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
    [Migration("20200501191725_ChangesInEmails")]
    partial class ChangesInEmails
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
                            Id = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Active = true,
                            ConcurrencyStamp = "e482d91d-7a39-4c47-8aa0-6107f0a3c2fb",
                            Email = "frank@gmail.com",
                            Password = "AQAAAAEAACcQAAAAEAAP1QAc8J6Ri88b4+01i2M+u9amqIhA8Jo1pvdIWTO0Le3NPqPAyQzrbWYQHSD0WA==",
                            SecurityCodeExpirationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Subject = "d860efca-22d9-47fd-8249-791ba61b07c7",
                            Username = "Frank"
                        },
                        new
                        {
                            Id = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Active = true,
                            ConcurrencyStamp = "ddd9d4ac-979d-4726-966f-a9e380615169",
                            Email = "claire@gmail.com",
                            Password = "AQAAAAEAACcQAAAAEAAP1QAc8J6Ri88b4+01i2M+u9amqIhA8Jo1pvdIWTO0Le3NPqPAyQzrbWYQHSD0WA==",
                            SecurityCodeExpirationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Subject = "b7539694-97e7-4dfe-84da-b4256e1ff5c7",
                            Username = "Claire"
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
                            Id = new Guid("e8578525-28f9-41a7-b63d-117527789eec"),
                            ConcurrencyStamp = "8ca441c7-408e-4852-8e13-19bafad37ed1",
                            Type = "given_name",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "Frank"
                        },
                        new
                        {
                            Id = new Guid("be285eea-b5c8-462b-84ff-e15be7c795ee"),
                            ConcurrencyStamp = "ffba5bd2-7f02-4d71-9357-2911b25709ce",
                            Type = "family_name",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "Underwood"
                        },
                        new
                        {
                            Id = new Guid("cb25b9b3-3502-4f7d-b760-3beda05fa874"),
                            ConcurrencyStamp = "97436ddd-b9b6-432a-aa85-aa5a235d6168",
                            Type = "address",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "Main Road 1"
                        },
                        new
                        {
                            Id = new Guid("49aa1e8f-51db-448a-a329-0e577c71acf6"),
                            ConcurrencyStamp = "b8b63c89-7ea8-480e-8804-0877d44b1f69",
                            Type = "subscriptionlevel",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "FreeUser"
                        },
                        new
                        {
                            Id = new Guid("1bca7927-a861-4bc2-a6fd-f9a5453ff887"),
                            ConcurrencyStamp = "1776efcb-1fd0-4caf-8ffd-2a588154cccf",
                            Type = "country",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "nl"
                        },
                        new
                        {
                            Id = new Guid("cc79ad27-8024-490d-8929-625d0e07e131"),
                            ConcurrencyStamp = "2f488b87-2408-4932-a2ee-dc9be20a5c69",
                            Type = "given_name",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "Claire"
                        },
                        new
                        {
                            Id = new Guid("5ee1d1c1-3335-4bda-ac2f-9d4e569f3cd3"),
                            ConcurrencyStamp = "e7e66072-42e8-4ae6-9c6b-25e2fa6ddbb4",
                            Type = "family_name",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "Underwood"
                        },
                        new
                        {
                            Id = new Guid("6a529168-fc9c-46a2-ac4c-aebc066f2100"),
                            ConcurrencyStamp = "3ec792e2-c698-4e5a-9a57-77a9bfafd5d1",
                            Type = "address",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "Big Street 2"
                        },
                        new
                        {
                            Id = new Guid("5bd73156-eb49-44a7-b843-fb7c4340d981"),
                            ConcurrencyStamp = "e6274c47-1918-4e68-bd8d-c407295c7d85",
                            Type = "subscriptionlevel",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "PayingUser"
                        },
                        new
                        {
                            Id = new Guid("c4ce9eee-e6d8-4af1-846b-7ba3115efd78"),
                            ConcurrencyStamp = "19cabb61-f5e1-4b7c-992e-28415937f126",
                            Type = "country",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "be"
                        });
                });

            modelBuilder.Entity("MST.IDP.Domain.UserClaim", b =>
                {
                    b.HasOne("MST.IDP.Domain.User", "User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
