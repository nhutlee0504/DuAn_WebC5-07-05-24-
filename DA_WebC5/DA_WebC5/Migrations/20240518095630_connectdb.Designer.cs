﻿// <auto-generated />
using System;
using DA_WebC5.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DA_WebC5.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240518095630_connectdb")]
    partial class connectdb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DA_WebC5.Models.Account", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("varchar(12)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("UserName");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("DA_WebC5.Models.Bill", b =>
                {
                    b.Property<int>("IDBill")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(20)");

                    b.HasKey("IDBill");

                    b.HasIndex("UserName");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("DA_WebC5.Models.BillDetails", b =>
                {
                    b.Property<int>("IDBDetail")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IDBill")
                        .HasColumnType("int");

                    b.Property<int>("IDPDetail")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("IDBDetail");

                    b.HasIndex("IDBill");

                    b.HasIndex("IDPDetail");

                    b.ToTable("BillDetails");
                });

            modelBuilder.Entity("DA_WebC5.Models.Cart", b =>
                {
                    b.Property<int>("IDCart")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IDPDetail")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("IDCart");

                    b.HasIndex("IDPDetail");

                    b.HasIndex("UserName");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("DA_WebC5.Models.Category", b =>
                {
                    b.Property<int>("IDCategory")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDCategory");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("DA_WebC5.Models.Colors", b =>
                {
                    b.Property<int>("IDColor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDColor");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("DA_WebC5.Models.Evaluate", b =>
                {
                    b.Property<int>("IDEvaluate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Describe")
                        .HasColumnType("ntext");

                    b.Property<int>("IDProduct")
                        .HasColumnType("int");

                    b.Property<int?>("Point")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(20)");

                    b.HasKey("IDEvaluate");

                    b.HasIndex("IDProduct");

                    b.HasIndex("UserName");

                    b.ToTable("Evaluates");
                });

            modelBuilder.Entity("DA_WebC5.Models.History", b =>
                {
                    b.Property<int>("IDHistory")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Describe")
                        .HasColumnType("ntext");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(20)");

                    b.HasKey("IDHistory");

                    b.HasIndex("UserName");

                    b.ToTable("Histories");
                });

            modelBuilder.Entity("DA_WebC5.Models.ImageDetails", b =>
                {
                    b.Property<int>("IDImage")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IDProduct")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("varchar(150)");

                    b.HasKey("IDImage");

                    b.HasIndex("IDProduct");

                    b.ToTable("ImageDetails");
                });

            modelBuilder.Entity("DA_WebC5.Models.Product", b =>
                {
                    b.Property<int>("IDProduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Describe")
                        .HasColumnType("ntext");

                    b.Property<int>("IDCategory")
                        .HasColumnType("int");

                    b.Property<int>("IDSupplier")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("IDProduct");

                    b.HasIndex("IDCategory");

                    b.HasIndex("IDSupplier");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DA_WebC5.Models.ProductDetails", b =>
                {
                    b.Property<int>("IDPDetail")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IDColor")
                        .HasColumnType("int");

                    b.Property<int>("IDProduct")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.HasKey("IDPDetail");

                    b.HasIndex("IDColor");

                    b.HasIndex("IDProduct");

                    b.HasIndex("Size");

                    b.ToTable("ProductDetails");
                });

            modelBuilder.Entity("DA_WebC5.Models.Sale", b =>
                {
                    b.Property<int>("IDSale")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("ntext");

                    b.Property<int>("DiscountValue")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MaxAmount")
                        .HasColumnType("int");

                    b.Property<int?>("MinAmount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("IDSale");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("DA_WebC5.Models.SaleDetails", b =>
                {
                    b.Property<int>("IDSaleDetail")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IDSale")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(20)");

                    b.HasKey("IDSaleDetail");

                    b.HasIndex("IDSale");

                    b.HasIndex("UserName");

                    b.ToTable("SaleDetails");
                });

            modelBuilder.Entity("DA_WebC5.Models.Sizes", b =>
                {
                    b.Property<int>("IDSize")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SizeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDSize");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("DA_WebC5.Models.Supplier", b =>
                {
                    b.Property<int>("IDSupplier")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("varchar(12)");

                    b.HasKey("IDSupplier");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("DA_WebC5.Models.Bill", b =>
                {
                    b.HasOne("DA_WebC5.Models.Account", "Account")
                        .WithMany("bills")
                        .HasForeignKey("UserName");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("DA_WebC5.Models.BillDetails", b =>
                {
                    b.HasOne("DA_WebC5.Models.Bill", "Bill")
                        .WithMany("BillDetails")
                        .HasForeignKey("IDBill")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DA_WebC5.Models.ProductDetails", "ProductDetails")
                        .WithMany("BillDetails")
                        .HasForeignKey("IDPDetail")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bill");

                    b.Navigation("ProductDetails");
                });

            modelBuilder.Entity("DA_WebC5.Models.Cart", b =>
                {
                    b.HasOne("DA_WebC5.Models.ProductDetails", "ProductDetails")
                        .WithMany("Carts")
                        .HasForeignKey("IDPDetail")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DA_WebC5.Models.Account", "Account")
                        .WithMany("carts")
                        .HasForeignKey("UserName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("ProductDetails");
                });

            modelBuilder.Entity("DA_WebC5.Models.Evaluate", b =>
                {
                    b.HasOne("DA_WebC5.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("IDProduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DA_WebC5.Models.Account", "Account")
                        .WithMany("evaluates")
                        .HasForeignKey("UserName");

                    b.Navigation("Account");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DA_WebC5.Models.History", b =>
                {
                    b.HasOne("DA_WebC5.Models.Account", "Account")
                        .WithMany("histories")
                        .HasForeignKey("UserName");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("DA_WebC5.Models.ImageDetails", b =>
                {
                    b.HasOne("DA_WebC5.Models.Product", "Product")
                        .WithMany("ImageDetails")
                        .HasForeignKey("IDProduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DA_WebC5.Models.Product", b =>
                {
                    b.HasOne("DA_WebC5.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("IDCategory")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DA_WebC5.Models.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("IDSupplier")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("DA_WebC5.Models.ProductDetails", b =>
                {
                    b.HasOne("DA_WebC5.Models.Colors", "Colors")
                        .WithMany("ProductDetails")
                        .HasForeignKey("IDColor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DA_WebC5.Models.Product", "Product")
                        .WithMany("ProductDetails")
                        .HasForeignKey("IDProduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DA_WebC5.Models.Sizes", "Sizes")
                        .WithMany("ProductDetails")
                        .HasForeignKey("Size")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Colors");

                    b.Navigation("Product");

                    b.Navigation("Sizes");
                });

            modelBuilder.Entity("DA_WebC5.Models.SaleDetails", b =>
                {
                    b.HasOne("DA_WebC5.Models.Sale", "Sale")
                        .WithMany("Details")
                        .HasForeignKey("IDSale")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DA_WebC5.Models.Account", "Account")
                        .WithMany("SaleDetails")
                        .HasForeignKey("UserName");

                    b.Navigation("Account");

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("DA_WebC5.Models.Account", b =>
                {
                    b.Navigation("bills");

                    b.Navigation("carts");

                    b.Navigation("evaluates");

                    b.Navigation("histories");

                    b.Navigation("SaleDetails");
                });

            modelBuilder.Entity("DA_WebC5.Models.Bill", b =>
                {
                    b.Navigation("BillDetails");
                });

            modelBuilder.Entity("DA_WebC5.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DA_WebC5.Models.Colors", b =>
                {
                    b.Navigation("ProductDetails");
                });

            modelBuilder.Entity("DA_WebC5.Models.Product", b =>
                {
                    b.Navigation("ImageDetails");

                    b.Navigation("ProductDetails");
                });

            modelBuilder.Entity("DA_WebC5.Models.ProductDetails", b =>
                {
                    b.Navigation("BillDetails");

                    b.Navigation("Carts");
                });

            modelBuilder.Entity("DA_WebC5.Models.Sale", b =>
                {
                    b.Navigation("Details");
                });

            modelBuilder.Entity("DA_WebC5.Models.Sizes", b =>
                {
                    b.Navigation("ProductDetails");
                });

            modelBuilder.Entity("DA_WebC5.Models.Supplier", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
