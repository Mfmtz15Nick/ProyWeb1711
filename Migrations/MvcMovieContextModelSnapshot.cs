﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mudanza1711.Data;

namespace Mudanza1711.Migrations
{
    [DbContext(typeof(MvcMovieContext))]
    partial class MvcMovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Mudanza1711.Models.AltaCamiones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CantidadCamion")
                        .HasColumnType("int");

                    b.Property<string>("TipoCamion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AltaCamiones");
                });

            modelBuilder.Entity("Mudanza1711.Models.Bus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Matricula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Bus");
                });

            modelBuilder.Entity("Mudanza1711.Models.Camion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CapacidadPeso")
                        .HasColumnType("int");

                    b.Property<int>("Kilometraje")
                        .HasColumnType("int");

                    b.Property<int>("KilometrajeUltimoServicio")
                        .HasColumnType("int");

                    b.Property<int>("Placas")
                        .HasColumnType("int");

                    b.Property<string>("TipoCamion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoCombustible")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Volumen")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Camion");
                });

            modelBuilder.Entity("Mudanza1711.Models.Camiones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CapacidadPeso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kilomentraje")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KilomentrajeUltimoServicio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoCamion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoCombustible")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Volumen")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Camiones");
                });
#pragma warning restore 612, 618
        }
    }
}
