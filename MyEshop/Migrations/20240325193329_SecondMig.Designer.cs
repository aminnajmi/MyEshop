﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyEshop.Data;

namespace MyEshop.Migrations
{
    [DbContext(typeof(MyEshopContext))]
    [Migration("20240325193329_SecondMig")]
    partial class SecondMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyEshop.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Asp.net Core",
                            Name = "Asp.net Core"
                        },
                        new
                        {
                            Id = 2,
                            Description = "کتاب ها",
                            Name = "کتاب"
                        },
                        new
                        {
                            Id = 3,
                            Description = "پادکست ها",
                            Name = "پادکست"
                        },
                        new
                        {
                            Id = 4,
                            Description = "موسیقی ها",
                            Name = "موسیقی"
                        },
                        new
                        {
                            Id = 5,
                            Description = "مجله ها",
                            Name = "مجله"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
