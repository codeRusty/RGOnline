﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using RGonline.DataAccess;
using System;

namespace RGOnline.WebAPI.Migrations
{
    [DbContext(typeof(RGOnlineContext))]
    partial class RGOnlineContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RGOnline.DataModels.M_CurrencyDominance", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Currency");

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedOn");

                    b.Property<double>("Value");

                    b.HasKey("Id");

                    b.ToTable("M_CurrencyDominance");
                });

            modelBuilder.Entity("RGOnline.DataModels.M_PriceDecisonFactor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("DecisionFactor");

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("M_PriceDecisonFactor");
                });

            modelBuilder.Entity("RGOnline.DataModels.M_ProductCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive");

                    b.Property<string>("ProductCategory");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("M_ProductCategory");
                });

            modelBuilder.Entity("RGOnline.DataModels.M_ProductSubCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive");

                    b.Property<long?>("M_ProductCategoryId");

                    b.Property<string>("ProductSubCategory");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("M_ProductCategoryId");

                    b.ToTable("M_ProductSubCategory");
                });

            modelBuilder.Entity("RGOnline.DataModels.M_SupplierCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive");

                    b.Property<string>("SupplierCategory");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("M_SupplierCategory");
                });

            modelBuilder.Entity("RGOnline.DataModels.Products", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("RGOnline.DataModels.M_ProductSubCategory", b =>
                {
                    b.HasOne("RGOnline.DataModels.M_ProductCategory", "M_ProductCategory")
                        .WithMany("M_ProductSubCategory")
                        .HasForeignKey("M_ProductCategoryId");
                });
#pragma warning restore 612, 618
        }
    }
}
