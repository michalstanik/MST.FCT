﻿// <auto-generated />
using System;
using FCT.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FCT.Data.Migrations
{
    [DbContext(typeof(FCTContext))]
    [Migration("20201107170849_AddTimeZone")]
    partial class AddTimeZone
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FCT.Data.Domain.Admin.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Exception")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Level")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogEvent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageTemplate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Properties")
                        .HasColumnType("xml");

                    b.Property<DateTimeOffset>("TimeStamp")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("Log");
                });

            modelBuilder.Entity("FCT.Data.Domain.Aviation.Aircraft", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AircraftModelId")
                        .HasColumnType("int");

                    b.Property<string>("TailNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AircraftModelId");

                    b.ToTable("Aircraft");
                });

            modelBuilder.Entity("FCT.Data.Domain.Aviation.AircraftFactory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AircraftFactoryCountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AircraftFactoryCountryId");

                    b.ToTable("AircraftFactory");
                });

            modelBuilder.Entity("FCT.Data.Domain.Aviation.AircraftModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AircraftFactoryId")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AircraftFactoryId");

                    b.ToTable("AircraftModel");
                });

            modelBuilder.Entity("FCT.Data.Domain.Aviation.Airline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AirLineAllianceId")
                        .HasColumnType("int");

                    b.Property<int?>("AirlineCountryId")
                        .HasColumnType("int");

                    b.Property<string>("IATA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ICAO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AirLineAllianceId");

                    b.HasIndex("AirlineCountryId");

                    b.ToTable("Airline");
                });

            modelBuilder.Entity("FCT.Data.Domain.Aviation.AirlineAlliance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AirLineAlliance");
                });

            modelBuilder.Entity("FCT.Data.Domain.Aviation.Airport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<int>("Elevation")
                        .HasColumnType("int");

                    b.Property<string>("IATA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ICAO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeZone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Airport");
                });

            modelBuilder.Entity("FCT.Data.Domain.Flights.Flight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AircraftId")
                        .HasColumnType("int");

                    b.Property<int?>("AirlineId")
                        .HasColumnType("int");

                    b.Property<int?>("ArrivalAirportId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ArrivialDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DepartureAirportId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DepartureDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("Distance")
                        .HasColumnType("bigint");

                    b.Property<string>("FlightNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlightTypeAssessment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ScheduleArrivialDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ScheduleDepartureDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AircraftId");

                    b.HasIndex("AirlineId");

                    b.HasIndex("ArrivalAirportId");

                    b.HasIndex("DepartureAirportId");

                    b.ToTable("Flight");
                });

            modelBuilder.Entity("FCT.Data.Domain.Geo.Continent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CountryCount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Continent");
                });

            modelBuilder.Entity("FCT.Data.Domain.Geo.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alpha2Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Alpha3Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Area")
                        .HasColumnType("bigint");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfficialName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RegionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("FCT.Data.Domain.Geo.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ContinentId")
                        .HasColumnType("int");

                    b.Property<int?>("CountriesCount")
                        .HasColumnType("int");

                    b.Property<double>("MaxLatitude")
                        .HasColumnType("float");

                    b.Property<double>("MaxLongitude")
                        .HasColumnType("float");

                    b.Property<double>("MinLatitude")
                        .HasColumnType("float");

                    b.Property<double>("MinLongitude")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContinentId");

                    b.ToTable("Region");
                });

            modelBuilder.Entity("FCT.Data.Domain.User.TUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastLoginTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TUser");
                });

            modelBuilder.Entity("FCT.Data.Domain.User.UserFlight", b =>
                {
                    b.Property<int>("FlightId")
                        .HasColumnType("int");

                    b.Property<string>("TUserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("FlightId", "TUserId");

                    b.HasIndex("TUserId");

                    b.ToTable("UserFlight");
                });

            modelBuilder.Entity("FCT.Data.Domain.Aviation.Aircraft", b =>
                {
                    b.HasOne("FCT.Data.Domain.Aviation.AircraftModel", "AircraftModel")
                        .WithMany("Aircrafts")
                        .HasForeignKey("AircraftModelId");
                });

            modelBuilder.Entity("FCT.Data.Domain.Aviation.AircraftFactory", b =>
                {
                    b.HasOne("FCT.Data.Domain.Geo.Country", "AircraftFactoryCountry")
                        .WithMany()
                        .HasForeignKey("AircraftFactoryCountryId");
                });

            modelBuilder.Entity("FCT.Data.Domain.Aviation.AircraftModel", b =>
                {
                    b.HasOne("FCT.Data.Domain.Aviation.AircraftFactory", "AircraftFactory")
                        .WithMany("AircraftModels")
                        .HasForeignKey("AircraftFactoryId");
                });

            modelBuilder.Entity("FCT.Data.Domain.Aviation.Airline", b =>
                {
                    b.HasOne("FCT.Data.Domain.Aviation.AirlineAlliance", "AirLineAlliance")
                        .WithMany("Airlines")
                        .HasForeignKey("AirLineAllianceId");

                    b.HasOne("FCT.Data.Domain.Geo.Country", "AirlineCountry")
                        .WithMany()
                        .HasForeignKey("AirlineCountryId");
                });

            modelBuilder.Entity("FCT.Data.Domain.Aviation.Airport", b =>
                {
                    b.HasOne("FCT.Data.Domain.Geo.Country", "Country")
                        .WithMany("Airports")
                        .HasForeignKey("CountryId");
                });

            modelBuilder.Entity("FCT.Data.Domain.Flights.Flight", b =>
                {
                    b.HasOne("FCT.Data.Domain.Aviation.Aircraft", "Aircraft")
                        .WithMany()
                        .HasForeignKey("AircraftId");

                    b.HasOne("FCT.Data.Domain.Aviation.Airline", "Airline")
                        .WithMany("Flights")
                        .HasForeignKey("AirlineId");

                    b.HasOne("FCT.Data.Domain.Aviation.Airport", "ArrivalAirport")
                        .WithMany("ArrivalFlights")
                        .HasForeignKey("ArrivalAirportId");

                    b.HasOne("FCT.Data.Domain.Aviation.Airport", "DepartureAirport")
                        .WithMany("DepartureFlights")
                        .HasForeignKey("DepartureAirportId");
                });

            modelBuilder.Entity("FCT.Data.Domain.Geo.Country", b =>
                {
                    b.HasOne("FCT.Data.Domain.Geo.Region", "Region")
                        .WithMany("Countries")
                        .HasForeignKey("RegionId");
                });

            modelBuilder.Entity("FCT.Data.Domain.Geo.Region", b =>
                {
                    b.HasOne("FCT.Data.Domain.Geo.Continent", "Continent")
                        .WithMany("Regions")
                        .HasForeignKey("ContinentId");
                });

            modelBuilder.Entity("FCT.Data.Domain.User.UserFlight", b =>
                {
                    b.HasOne("FCT.Data.Domain.Flights.Flight", "Flight")
                        .WithMany("UserFlights")
                        .HasForeignKey("FlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FCT.Data.Domain.User.TUser", "TUser")
                        .WithMany("UserFlights")
                        .HasForeignKey("TUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
