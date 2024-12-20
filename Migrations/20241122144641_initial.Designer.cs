﻿// <auto-generated />
using System;
using DotNET.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DotNET.Migrations
{
    [DbContext(typeof(ProductOrderDbContext))]
    [Migration("20241122144641_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DotNET.Models.TblOrders", b =>
                {
                    b.Property<int>("intOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("intOrderId"), 1L, 1);

                    b.Property<DateTime>("dtOrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("intProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("numQuantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("strCustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("intOrderId");

                    b.ToTable("tblOrders");
                });

            modelBuilder.Entity("DotNET.Models.TblProducts", b =>
                {
                    b.Property<int>("intProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("intProductId"), 1L, 1);

                    b.Property<decimal>("numStock")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("numUnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("strProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("intProductId");

                    b.ToTable("tblProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
