﻿// <auto-generated />
using System;
using FoodApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodApp.Migrations
{
    [DbContext(typeof(OrderDbContext))]
    [Migration("20240426092049_base data")]
    partial class basedata
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FoodApp.Models.OrderModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PizzaId")
                        .HasColumnType("int");

                    b.Property<string>("PizzaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PizzaId");

                    b.ToTable("order");
                });

            modelBuilder.Entity("FoodApp.Models.PizzaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("BasePrice")
                        .HasColumnType("real");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("pizza");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            BasePrice = 8f,
                            Description = "Pizza for the peppered swaggs",
                            Name = "Pepperoni",
                            Size = 2
                        },
                        new
                        {
                            Id = -2,
                            BasePrice = 8f,
                            Description = "This is from Hawaii",
                            Name = "Hawaiin",
                            Size = 2
                        },
                        new
                        {
                            Id = -3,
                            BasePrice = 8f,
                            Description = "This is made with dear love",
                            Name = "Deariazza",
                            Size = 2
                        },
                        new
                        {
                            Id = -4,
                            BasePrice = 6f,
                            Description = "This is a beeffed up Pizza made with love",
                            Name = "BeefedUp",
                            Size = 1
                        });
                });

            modelBuilder.Entity("FoodApp.Models.OrderModel", b =>
                {
                    b.HasOne("FoodApp.Models.PizzaModel", "Pizza")
                        .WithMany()
                        .HasForeignKey("PizzaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pizza");
                });
#pragma warning restore 612, 618
        }
    }
}
