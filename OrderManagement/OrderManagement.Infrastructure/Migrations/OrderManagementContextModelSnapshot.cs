﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderManagement.Infrastructure.Data.Context;

namespace OrderManagement.Infrastructure.Migrations
{
    [DbContext(typeof(OrderManagementContext))]
    partial class OrderManagementContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OrderManagement.Domain.Aggregates.OrderAggregate.Orders", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalAmount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("OrderManagement.Domain.Aggregates.OrderAggregate.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("Mrp")
                        .HasColumnType("int");

                    b.Property<long?>("OrdersId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrdersId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("OrderManagement.Domain.Aggregates.OrderAggregate.Product", b =>
                {
                    b.HasOne("OrderManagement.Domain.Aggregates.OrderAggregate.Orders", null)
                        .WithMany("Products")
                        .HasForeignKey("OrdersId");
                });
#pragma warning restore 612, 618
        }
    }
}
