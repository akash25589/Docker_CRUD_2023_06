﻿// <auto-generated />
using CRUD_2023_06.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRUD_2023_06.Migrations
{
    [DbContext(typeof(DB))]
    [Migration("20230608113337_my_initial_fruits05")]
    partial class my_initial_fruits05
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CRUD_2023_06.Models.Fruits_Data", b =>
                {
                    b.Property<int>("FruitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FruitId"), 1L, 1);

                    b.Property<string>("FruitName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FruitId");

                    b.ToTable("Fruits_details");
                });

            modelBuilder.Entity("CRUD_2023_06.Models.MyFruits", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("fruitname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("fruitquantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("myCRUD");
                });
#pragma warning restore 612, 618
        }
    }
}
