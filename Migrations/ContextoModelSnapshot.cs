﻿// <auto-generated />
using AlainaGarcia_Ap1_P1.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AlainaGarcia_Ap1_P1.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("AlainaGarcia_Ap1_P1.Models.Deudores", b =>
                {
                    b.Property<int>("DeudorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("DeudorId");

                    b.ToTable("Deudores");

                    b.HasData(
                        new
                        {
                            DeudorId = 1,
                            Nombres = "Juan Perez"
                        },
                        new
                        {
                            DeudorId = 2,
                            Nombres = "Alina Garcia"
                        },
                        new
                        {
                            DeudorId = 3,
                            Nombres = "Erian Brito"
                        });
                });

            modelBuilder.Entity("AlainaGarcia_Ap1_P1.Models.Prestamos", b =>
                {
                    b.Property<int>("PrestamosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Concepto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("DeudorId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Monto")
                        .HasColumnType("REAL");

                    b.HasKey("PrestamosId");

                    b.HasIndex("DeudorId");

                    b.ToTable("Prestamos");
                });

            modelBuilder.Entity("AlainaGarcia_Ap1_P1.Models.Prestamos", b =>
                {
                    b.HasOne("AlainaGarcia_Ap1_P1.Models.Deudores", "Deudor")
                        .WithMany()
                        .HasForeignKey("DeudorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Deudor");
                });
#pragma warning restore 612, 618
        }
    }
}
