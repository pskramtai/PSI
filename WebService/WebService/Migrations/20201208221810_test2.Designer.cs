﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebService.Data;

namespace WebService.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20201208221810_test2")]
    partial class test2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("WebService.Base_Classes.Bar", b =>
                {
                    b.Property<int>("BarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BarLocation")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("BarName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("BarID");

                    b.ToTable("Bar");
                });

            modelBuilder.Entity("WebService.Base_Classes.Drink", b =>
                {
                    b.Property<int>("DrinkID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DrinkName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("DrinkID");

                    b.ToTable("Drink");
                });

            modelBuilder.Entity("WebService.Base_Classes.SpecificPrice", b =>
                {
                    b.Property<int>("SpecificPriceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BarID")
                        .HasColumnType("int");

                    b.Property<int>("DrinkID")
                        .HasColumnType("int");

                    b.Property<float>("DrinkPrice")
                        .HasColumnType("real");

                    b.HasKey("SpecificPriceID");

                    b.HasIndex("BarID");

                    b.HasIndex("DrinkID");

                    b.ToTable("SpecificPrice");
                });

            modelBuilder.Entity("WebService.Base_Classes.SpecificPrice", b =>
                {
                    b.HasOne("WebService.Base_Classes.Bar", "Bar")
                        .WithMany("AvailableDrinks")
                        .HasForeignKey("BarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebService.Base_Classes.Drink", "Drink")
                        .WithMany("DrinkLocations")
                        .HasForeignKey("DrinkID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bar");

                    b.Navigation("Drink");
                });

            modelBuilder.Entity("WebService.Base_Classes.Bar", b =>
                {
                    b.Navigation("AvailableDrinks");
                });

            modelBuilder.Entity("WebService.Base_Classes.Drink", b =>
                {
                    b.Navigation("DrinkLocations");
                });
#pragma warning restore 612, 618
        }
    }
}
