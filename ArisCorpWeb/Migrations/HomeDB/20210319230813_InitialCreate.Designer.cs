﻿// <auto-generated />
using ArisCorpWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ArisCorpWeb.Migrations.HomeDB
{
    [DbContext(typeof(HomeDBContext))]
    [Migration("20210319230813_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArisCorpWeb.Models.HomeDB", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Charter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fleet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("History")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manifest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Member")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Partner")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Home");
                });
#pragma warning restore 612, 618
        }
    }
}
