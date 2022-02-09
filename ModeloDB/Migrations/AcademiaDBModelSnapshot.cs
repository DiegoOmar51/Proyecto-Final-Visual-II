﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModeloDB;

namespace ModeloDB.Migrations
{
    [DbContext(typeof(AcademiaDB))]
    partial class AcademiaDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("Modelo.Entidades.Configuracion", b =>
                {
                    b.Property<string>("NombreEmpresa")
                        .HasColumnType("varchar(767)");

                    b.Property<float>("Horas_Extras_Maxima")
                        .HasColumnType("float");

                    b.Property<float>("Horas_Extras_Minima")
                        .HasColumnType("float");

                    b.Property<float>("Salario_Horas_Extras")
                        .HasColumnType("float");

                    b.Property<float>("sueldoMaximo")
                        .HasColumnType("float");

                    b.HasKey("NombreEmpresa");

                    b.ToTable("configuracion");
                });

            modelBuilder.Entity("Modelo.Entidades.Decimo_Tercero", b =>
                {
                    b.Property<int>("Decimo_TerceroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("PersonalId")
                        .HasColumnType("int");

                    b.Property<int?>("SalarioID")
                        .HasColumnType("int");

                    b.Property<DateTime>("fecha_final")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("fecha_inicio")
                        .HasColumnType("datetime");

                    b.Property<string>("meses")
                        .HasColumnType("text");

                    b.Property<float>("total")
                        .HasColumnType("float");

                    b.HasKey("Decimo_TerceroId");

                    b.HasIndex("PersonalId");

                    b.HasIndex("SalarioID")
                        .IsUnique();

                    b.ToTable("decimo_Terceros");
                });

            modelBuilder.Entity("Modelo.Entidades.Empresa", b =>
                {
                    b.Property<int>("EmpresaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("PersonalId")
                        .HasColumnType("int");

                    b.Property<string>("direccion")
                        .HasColumnType("text");

                    b.Property<string>("nombreEmpresa")
                        .HasColumnType("text");

                    b.Property<string>("provincia")
                        .HasColumnType("text");

                    b.Property<string>("ruc")
                        .HasColumnType("text");

                    b.Property<string>("telefono")
                        .HasColumnType("text");

                    b.HasKey("EmpresaId");

                    b.HasIndex("PersonalId")
                        .IsUnique();

                    b.ToTable("empresas");
                });

            modelBuilder.Entity("Modelo.Entidades.Liquidaciones", b =>
                {
                    b.Property<int>("LiquidacionesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Estadoliq")
                        .HasColumnType("int");

                    b.Property<int?>("PersonalId")
                        .HasColumnType("int");

                    b.Property<string>("cesantia")
                        .HasColumnType("text");

                    b.Property<string>("periodo_pri")
                        .HasColumnType("text");

                    b.Property<string>("salario_base")
                        .HasColumnType("text");

                    b.HasKey("LiquidacionesId");

                    b.HasIndex("PersonalId")
                        .IsUnique();

                    b.ToTable("liquidaciones");
                });

            modelBuilder.Entity("Modelo.Entidades.Personal", b =>
                {
                    b.Property<int>("PersonalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cedula")
                        .HasColumnType("text");

                    b.Property<string>("Direccion")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<int>("EstadoCV")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.Property<string>("Telefono")
                        .HasColumnType("text");

                    b.Property<DateTime>("fecha_incio")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("fecha_salida")
                        .HasColumnType("datetime");

                    b.Property<float>("salario")
                        .HasColumnType("float");

                    b.Property<int>("tipo")
                        .HasColumnType("int");

                    b.HasKey("PersonalId");

                    b.ToTable("personales");
                });

            modelBuilder.Entity("Modelo.Entidades.Roles", b =>
                {
                    b.Property<int>("RolesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("PersonalId")
                        .HasColumnType("int");

                    b.Property<int?>("SalarioID")
                        .HasColumnType("int");

                    b.Property<float>("anticipo")
                        .HasColumnType("float");

                    b.Property<float>("aporte_iess")
                        .HasColumnType("float");

                    b.Property<float>("comision")
                        .HasColumnType("float");

                    b.Property<float>("total")
                        .HasColumnType("float");

                    b.HasKey("RolesId");

                    b.HasIndex("PersonalId");

                    b.HasIndex("SalarioID")
                        .IsUnique();

                    b.ToTable("roles");
                });

            modelBuilder.Entity("Modelo.Entidades.Salario", b =>
                {
                    b.Property<int>("SalarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("DecimoCuartoSueldo")
                        .HasColumnType("float");

                    b.Property<float>("DecimoTercerSueldo")
                        .HasColumnType("float");

                    b.Property<int>("EstadoSal")
                        .HasColumnType("int");

                    b.Property<int?>("PersonalId")
                        .HasColumnType("int");

                    b.Property<float>("SueldoBasico")
                        .HasColumnType("float");

                    b.Property<float>("Utilidades")
                        .HasColumnType("float");

                    b.HasKey("SalarioId");

                    b.HasIndex("PersonalId");

                    b.ToTable("salarios");
                });

            modelBuilder.Entity("Modelo.Entidades.Decimo_Tercero", b =>
                {
                    b.HasOne("Modelo.Entidades.Personal", "Personal")
                        .WithMany("Decimos_Terceros")
                        .HasForeignKey("PersonalId");

                    b.HasOne("Modelo.Entidades.Salario", "Salario")
                        .WithOne("decterceros")
                        .HasForeignKey("Modelo.Entidades.Decimo_Tercero", "SalarioID");

                    b.Navigation("Personal");

                    b.Navigation("Salario");
                });

            modelBuilder.Entity("Modelo.Entidades.Empresa", b =>
                {
                    b.HasOne("Modelo.Entidades.Personal", "Personal")
                        .WithOne("empresa")
                        .HasForeignKey("Modelo.Entidades.Empresa", "PersonalId");

                    b.Navigation("Personal");
                });

            modelBuilder.Entity("Modelo.Entidades.Liquidaciones", b =>
                {
                    b.HasOne("Modelo.Entidades.Personal", "Personal")
                        .WithOne("liquidacion")
                        .HasForeignKey("Modelo.Entidades.Liquidaciones", "PersonalId");

                    b.Navigation("Personal");
                });

            modelBuilder.Entity("Modelo.Entidades.Roles", b =>
                {
                    b.HasOne("Modelo.Entidades.Personal", "Personal")
                        .WithMany("Roles")
                        .HasForeignKey("PersonalId");

                    b.HasOne("Modelo.Entidades.Salario", "Salario")
                        .WithOne("roles")
                        .HasForeignKey("Modelo.Entidades.Roles", "SalarioID");

                    b.Navigation("Personal");

                    b.Navigation("Salario");
                });

            modelBuilder.Entity("Modelo.Entidades.Salario", b =>
                {
                    b.HasOne("Modelo.Entidades.Personal", "Personal")
                        .WithMany("Salarios")
                        .HasForeignKey("PersonalId");

                    b.Navigation("Personal");
                });

            modelBuilder.Entity("Modelo.Entidades.Personal", b =>
                {
                    b.Navigation("Decimos_Terceros");

                    b.Navigation("empresa");

                    b.Navigation("liquidacion");

                    b.Navigation("Roles");

                    b.Navigation("Salarios");
                });

            modelBuilder.Entity("Modelo.Entidades.Salario", b =>
                {
                    b.Navigation("decterceros");

                    b.Navigation("roles");
                });
#pragma warning restore 612, 618
        }
    }
}
