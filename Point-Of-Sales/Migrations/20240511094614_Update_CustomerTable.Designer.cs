﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Point_Of_Sales.Config;

#nullable disable

namespace Point_Of_Sales.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240511094614_Update_CustomerTable")]
    partial class Update_CustomerTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Point_Of_Sales.Entities.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsFirstLogin")
                        .HasColumnType("bit");

                    b.Property<string>("Pwd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Point_Of_Sales.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Point_Of_Sales.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RetailStoreId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("RetailStoreId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Point_Of_Sales.Entities.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("InventoryID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("RetailStoreId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("RetailStoreId")
                        .IsUnique();

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("Point_Of_Sales.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Barcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Creation_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Import_Price")
                        .HasColumnType("float");

                    b.Property<bool>("Is_Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Product_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("Retail_Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("Product_Name", "Barcode")
                        .IsUnique();

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Point_Of_Sales.Entities.Purchase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date_Of_Purchase")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<double>("Paid_Back")
                        .HasColumnType("float");

                    b.Property<double>("Received_Money")
                        .HasColumnType("float");

                    b.Property<double>("Total_Amount")
                        .HasColumnType("float");

                    b.Property<string>("purchaseId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("PurchaseHistories");
                });

            modelBuilder.Entity("Point_Of_Sales.Entities.PurchaseDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("PurchaseId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("PurchaseId");

                    b.ToTable("PurchaseDetails");
                });

            modelBuilder.Entity("Point_Of_Sales.Entities.RetailStore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InventoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RetailStoreID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RetailStores");
                });

            modelBuilder.Entity("Point_Of_Sales.Entities.Account", b =>
                {
                    b.HasOne("Point_Of_Sales.Entities.Employee", "Employee")
                        .WithOne("Account")
                        .HasForeignKey("Point_Of_Sales.Entities.Account", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Point_Of_Sales.Entities.Employee", b =>
                {
                    b.HasOne("Point_Of_Sales.Entities.RetailStore", "RetailStore")
                        .WithMany("Employees")
                        .HasForeignKey("RetailStoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RetailStore");
                });

            modelBuilder.Entity("Point_Of_Sales.Entities.Inventory", b =>
                {
                    b.HasOne("Point_Of_Sales.Entities.Product", "Product")
                        .WithMany("Inventories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Point_Of_Sales.Entities.RetailStore", "RetailStore")
                        .WithOne("Inventory")
                        .HasForeignKey("Point_Of_Sales.Entities.Inventory", "RetailStoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("RetailStore");
                });

            modelBuilder.Entity("Point_Of_Sales.Entities.Purchase", b =>
                {
                    b.HasOne("Point_Of_Sales.Entities.Customer", "Customer")
                        .WithMany("Purchases")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Point_Of_Sales.Entities.Employee", "Employee")
                        .WithMany("PurchaseHistories")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Point_Of_Sales.Entities.PurchaseDetail", b =>
                {
                    b.HasOne("Point_Of_Sales.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Point_Of_Sales.Entities.Purchase", "Purchase")
                        .WithMany("PurchaseDetails")
                        .HasForeignKey("PurchaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Purchase");
                });

            modelBuilder.Entity("Point_Of_Sales.Entities.Customer", b =>
                {
                    b.Navigation("Purchases");
                });

            modelBuilder.Entity("Point_Of_Sales.Entities.Employee", b =>
                {
                    b.Navigation("Account")
                        .IsRequired();

                    b.Navigation("PurchaseHistories");
                });

            modelBuilder.Entity("Point_Of_Sales.Entities.Product", b =>
                {
                    b.Navigation("Inventories");
                });

            modelBuilder.Entity("Point_Of_Sales.Entities.Purchase", b =>
                {
                    b.Navigation("PurchaseDetails");
                });

            modelBuilder.Entity("Point_Of_Sales.Entities.RetailStore", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Inventory");
                });
#pragma warning restore 612, 618
        }
    }
}
