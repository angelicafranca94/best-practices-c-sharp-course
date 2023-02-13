﻿// <auto-generated />
using System;
using Avanade.BestPractices.Infrestructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Avanade.BestPractices.Infrestructure.Data.Migrations
{
    [DbContext(typeof(EntityContext))]
    [Migration("20230203215110_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("domain")
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Avanade.BestPractices.Domain.Entities.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Avanade.BestPractices.Domain.Entities.Charge", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("RideId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RideId");

                    b.ToTable("Charges");
                });

            modelBuilder.Entity("Avanade.BestPractices.Domain.Entities.Document", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Number")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("Avanade.BestPractices.Domain.Entities.DocumentParameter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("DocumentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Key")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Value")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("DocumentId");

                    b.ToTable("DocumentParameters");
                });

            modelBuilder.Entity("Avanade.BestPractices.Domain.Entities.Manufacturer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("Avanade.BestPractices.Domain.Entities.Model", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("ManufacturerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("Avanade.BestPractices.Domain.Entities.ModelVersion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("ModelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("ModelId");

                    b.ToTable("ModelVersions");
                });

            modelBuilder.Entity("Avanade.BestPractices.Domain.Entities.Ride", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Distance")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("StartAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("VehicleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("VehicleId");

                    b.ToTable("Rides");
                });

            modelBuilder.Entity("Avanade.BestPractices.Domain.Entities.Vehicle", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Color")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("ModelVersionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Plate")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ModelVersionId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("Avanade.BestPractices.Domain.Entities.Charge", b =>
                {
                    b.HasOne("Avanade.BestPractices.Domain.Entities.Ride", "Ride")
                        .WithMany("Charges")
                        .HasForeignKey("RideId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Avanade.BestPractices.Domain.ValueObjects.Money", "DiscountValue", b1 =>
                        {
                            b1.Property<Guid>("ChargeId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<long>("Value")
                                .HasColumnType("bigint")
                                .HasColumnName("Discount");

                            b1.HasKey("ChargeId");

                            b1.ToTable("Charges");

                            b1.WithOwner()
                                .HasForeignKey("ChargeId");
                        });

                    b.OwnsOne("Avanade.BestPractices.Domain.ValueObjects.Money", "GrossValue", b1 =>
                        {
                            b1.Property<Guid>("ChargeId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Currency")
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)")
                                .HasColumnName("Currency");

                            b1.Property<long>("Value")
                                .HasColumnType("bigint")
                                .HasColumnName("GrossValue");

                            b1.HasKey("ChargeId");

                            b1.ToTable("Charges");

                            b1.WithOwner()
                                .HasForeignKey("ChargeId");
                        });

                    b.OwnsOne("Avanade.BestPractices.Domain.ValueObjects.Money", "NetValue", b1 =>
                        {
                            b1.Property<Guid>("ChargeId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<long>("Value")
                                .HasColumnType("bigint")
                                .HasColumnName("NetValue");

                            b1.HasKey("ChargeId");

                            b1.ToTable("Charges");

                            b1.WithOwner()
                                .HasForeignKey("ChargeId");
                        });

                    b.Navigation("DiscountValue");

                    b.Navigation("GrossValue");

                    b.Navigation("NetValue");

                    b.Navigation("Ride");
                });

            modelBuilder.Entity("Avanade.BestPractices.Domain.Entities.Document", b =>
                {
                    b.HasOne("Avanade.BestPractices.Domain.Entities.Account", "Account")
                        .WithMany("Documents")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Avanade.BestPractices.Domain.Entities.DocumentParameter", b =>
                {
                    b.HasOne("Avanade.BestPractices.Domain.Entities.Document", "Document")
                        .WithMany("DocumentParameters")
                        .HasForeignKey("DocumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Document");
                });

            modelBuilder.Entity("Avanade.BestPractices.Domain.Entities.Model", b =>
                {
                    b.HasOne("Avanade.BestPractices.Domain.Entities.Manufacturer", "Manufacturer")
                        .WithMany("Models")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("Avanade.BestPractices.Domain.Entities.ModelVersion", b =>
                {
                    b.HasOne("Avanade.BestPractices.Domain.Entities.Model", "Model")
                        .WithMany("ModelVersions")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Model");
                });

            modelBuilder.Entity("Avanade.BestPractices.Domain.Entities.Ride", b =>
                {
                    b.HasOne("Avanade.BestPractices.Domain.Entities.Account", "Account")
                        .WithMany("Rides")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Avanade.BestPractices.Domain.Entities.Vehicle", "Vehicle")
                        .WithMany("Rides")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("Avanade.BestPractices.Domain.Entities.Vehicle", b =>
                {
                    b.HasOne("Avanade.BestPractices.Domain.Entities.ModelVersion", "ModelVersion")
                        .WithMany("Vehicles")
                        .HasForeignKey("ModelVersionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ModelVersion");
                });

            modelBuilder.Entity("Avanade.BestPractices.Domain.Entities.Account", b =>
                {
                    b.Navigation("Documents");

                    b.Navigation("Rides");
                });

            modelBuilder.Entity("Avanade.BestPractices.Domain.Entities.Document", b =>
                {
                    b.Navigation("DocumentParameters");
                });

            modelBuilder.Entity("Avanade.BestPractices.Domain.Entities.Manufacturer", b =>
                {
                    b.Navigation("Models");
                });

            modelBuilder.Entity("Avanade.BestPractices.Domain.Entities.Model", b =>
                {
                    b.Navigation("ModelVersions");
                });

            modelBuilder.Entity("Avanade.BestPractices.Domain.Entities.ModelVersion", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Avanade.BestPractices.Domain.Entities.Ride", b =>
                {
                    b.Navigation("Charges");
                });

            modelBuilder.Entity("Avanade.BestPractices.Domain.Entities.Vehicle", b =>
                {
                    b.Navigation("Rides");
                });
#pragma warning restore 612, 618
        }
    }
}