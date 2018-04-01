﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using RGOnline.DataAccess;
using System;

namespace RGOnline.WebAPI.Migrations
{
    [DbContext(typeof(RGOnlineContext))]
    [Migration("20180331185944_try")]
    partial class @try
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RGOnline.DataModels.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Area");

                    b.Property<string>("Building");

                    b.Property<string>("City");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Pincode");

                    b.Property<string>("Street");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("RGOnline.DataModels.Cart", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<long>("CustomerID");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("CustomerID");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("RGOnline.DataModels.CartItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CartID");

                    b.Property<string>("Name");

                    b.Property<long>("ProductID");

                    b.HasKey("Id");

                    b.HasIndex("CartID");

                    b.HasIndex("ProductID");

                    b.ToTable("CartItem");
                });

            modelBuilder.Entity("RGOnline.DataModels.Customer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("AddressID");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<string>("Email");

                    b.Property<string>("Gender");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("AddressID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("RGOnline.DataModels.GiftCoupon", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CouponCode");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<double>("Discount");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("GiftCoupon");
                });

            modelBuilder.Entity("RGOnline.DataModels.Grade", b =>
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

                    b.ToTable("Grade");
                });

            modelBuilder.Entity("RGOnline.DataModels.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("AddressID");

                    b.Property<double>("Amount");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<long>("CustomerID");

                    b.Property<string>("Description");

                    b.Property<Guid>("Reference");

                    b.Property<long>("ShippingAddressID");

                    b.Property<double>("Tax");

                    b.Property<double>("TotalAmount");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("AddressID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("RGOnline.DataModels.OrderItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<Guid>("OrderID");

                    b.Property<long>("ProductID");

                    b.Property<int>("Quantity");

                    b.Property<double>("SalesFee");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("OrderID");

                    b.HasIndex("ProductID");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("RGOnline.DataModels.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<int>("Quantity");

                    b.Property<string>("SKU");

                    b.Property<double>("SalesFee");

                    b.Property<long>("SchoolID");

                    b.Property<long>("SeasonID");

                    b.Property<long>("SizeID");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("SchoolID");

                    b.HasIndex("SeasonID");

                    b.HasIndex("SizeID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("RGOnline.DataModels.School", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("AddressID");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive");

                    b.Property<string>("SchoolName");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("AddressID");

                    b.ToTable("School");
                });

            modelBuilder.Entity("RGOnline.DataModels.Season", b =>
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

                    b.ToTable("Season");
                });

            modelBuilder.Entity("RGOnline.DataModels.Size", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Breath");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<double>("Length");

                    b.Property<string>("Name");

                    b.Property<double>("Number");

                    b.Property<string>("Type");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedOn");

                    b.Property<double>("Weight");

                    b.HasKey("Id");

                    b.ToTable("Size");
                });

            modelBuilder.Entity("RGOnline.DataModels.Cart", b =>
                {
                    b.HasOne("RGOnline.DataModels.Customer", "Customer")
                        .WithMany("Cart")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RGOnline.DataModels.CartItem", b =>
                {
                    b.HasOne("RGOnline.DataModels.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RGOnline.DataModels.Product", "Product")
                        .WithMany("CartItems")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RGOnline.DataModels.Customer", b =>
                {
                    b.HasOne("RGOnline.DataModels.Address", "Address")
                        .WithMany("Customer")
                        .HasForeignKey("AddressID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RGOnline.DataModels.Order", b =>
                {
                    b.HasOne("RGOnline.DataModels.Address", "ShippingAddress")
                        .WithMany("Orders")
                        .HasForeignKey("AddressID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RGOnline.DataModels.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RGOnline.DataModels.OrderItem", b =>
                {
                    b.HasOne("RGOnline.DataModels.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RGOnline.DataModels.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RGOnline.DataModels.Product", b =>
                {
                    b.HasOne("RGOnline.DataModels.School", "School")
                        .WithMany("Products")
                        .HasForeignKey("SchoolID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RGOnline.DataModels.Season", "Season")
                        .WithMany("Products")
                        .HasForeignKey("SeasonID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RGOnline.DataModels.Size", "Size")
                        .WithMany("Products")
                        .HasForeignKey("SizeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RGOnline.DataModels.School", b =>
                {
                    b.HasOne("RGOnline.DataModels.Address", "Address")
                        .WithMany("Schools")
                        .HasForeignKey("AddressID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}