﻿// <auto-generated />
using System;
using CocktailApp.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CocktailApp.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200901150832_NewEntities")]
    partial class NewEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CocktailApp.Repository.Entities.BittersEntity", b =>
                {
                    b.Property<int>("BittersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Abv")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BittersId");

                    b.ToTable("Bitters");
                });

            modelBuilder.Entity("CocktailApp.Repository.Entities.CocktailEntity", b =>
                {
                    b.Property<int>("CocktailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BittersId")
                        .HasColumnType("int");

                    b.Property<int>("FortifiedWineId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Origin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Recipe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpiritId")
                        .HasColumnType("int");

                    b.HasKey("CocktailId");

                    b.HasIndex("BittersId");

                    b.HasIndex("FortifiedWineId");

                    b.HasIndex("SpiritId");

                    b.ToTable("Cocktails");
                });

            modelBuilder.Entity("CocktailApp.Repository.Entities.FortifiedWineEntity", b =>
                {
                    b.Property<int>("FortifiedWineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Abv")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FortifiedWineId");

                    b.ToTable("FortifiedWines");
                });

            modelBuilder.Entity("CocktailApp.Repository.Entities.SpiritEntity", b =>
                {
                    b.Property<int>("SpiritId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Abv")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsOverproof")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SpiritId");

                    b.ToTable("Spirits");
                });

            modelBuilder.Entity("CocktailApp.Repository.Entities.CocktailEntity", b =>
                {
                    b.HasOne("CocktailApp.Repository.Entities.BittersEntity", "Bitters")
                        .WithMany()
                        .HasForeignKey("BittersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CocktailApp.Repository.Entities.FortifiedWineEntity", "FortifiedWine")
                        .WithMany()
                        .HasForeignKey("FortifiedWineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CocktailApp.Repository.Entities.SpiritEntity", "Spirit")
                        .WithMany()
                        .HasForeignKey("SpiritId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
