﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModeloDB;

namespace ModeloDB.Migrations
{
    [DbContext(typeof(AcademiaDB))]
    [Migration("20220209051148_db1")]
    partial class db1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Modelo.Entidades.Configuracion", b =>
                {
                    b.Property<string>("NombreEmpresa")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("Horas_Extras_Maxima")
                        .HasColumnType("real");

                    b.Property<float>("Horas_Extras_Minima")
                        .HasColumnType("real");

                    b.Property<float>("Salario_Horas_Extras")
                        .HasColumnType("real");

                    b.Property<float>("sueldoMaximo")
                        .HasColumnType("real");

                    b.HasKey("NombreEmpresa");

                    b.ToTable("configuracion");
                });

            modelBuilder.Entity("Modelo.Entidades.Decimo_Tercero", b =>
                {
                    b.Property<int>("Decimo_TerceroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PersonalId")
                        .HasColumnType("int");

                    b.Property<int?>("SalarioID")
                        .HasColumnType("int");

                    b.Property<DateTime>("fecha_final")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fecha_inicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("meses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("total")
                        .HasColumnType("real");

                    b.HasKey("Decimo_TerceroId");

                    b.HasIndex("PersonalId");

                    b.HasIndex("SalarioID")
                        .IsUnique()
                        .HasFilter("[SalarioID] IS NOT NULL");

                    b.ToTable("decimo_Terceros");
                });

            modelBuilder.Entity("Modelo.Entidades.Empresa", b =>
                {
                    b.Property<int>("EmpresaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PersonalId")
                        .HasColumnType("int");

                    b.Property<int?>("RolesId")
                        .HasColumnType("int");

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombreEmpresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("provincia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ruc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpresaId");

                    b.HasIndex("PersonalId")
                        .IsUnique()
                        .HasFilter("[PersonalId] IS NOT NULL");

                    b.HasIndex("RolesId");

                    b.ToTable("empresas");
                });

            modelBuilder.Entity("Modelo.Entidades.Liquidaciones", b =>
                {
                    b.Property<int>("LiquidacionesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Estadoliq")
                        .HasColumnType("int");

                    b.Property<int?>("PersonalId")
                        .HasColumnType("int");

                    b.Property<string>("cesantia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("periodo_pri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("salario_base")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LiquidacionesId");

                    b.HasIndex("PersonalId")
                        .IsUnique()
                        .HasFilter("[PersonalId] IS NOT NULL");

                    b.ToTable("liquidaciones");
                });

            modelBuilder.Entity("Modelo.Entidades.Personal", b =>
                {
                    b.Property<int>("PersonalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cedula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstadoCV")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fecha_incio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fecha_salida")
                        .HasColumnType("datetime2");

                    b.Property<float>("salario")
                        .HasColumnType("real");

                    b.Property<int>("tipo")
                        .HasColumnType("int");

                    b.HasKey("PersonalId");

                    b.ToTable("personales");
                });

            modelBuilder.Entity("Modelo.Entidades.Roles", b =>
                {
                    b.Property<int>("RolesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PersonalId")
                        .HasColumnType("int");

                    b.Property<int?>("SalarioID")
                        .HasColumnType("int");

                    b.Property<float>("anticipo")
                        .HasColumnType("real");

                    b.Property<float>("aporte_iess")
                        .HasColumnType("real");

                    b.Property<float>("comision")
                        .HasColumnType("real");

                    b.Property<float>("total")
                        .HasColumnType("real");

                    b.HasKey("RolesId");

                    b.HasIndex("PersonalId");

                    b.HasIndex("SalarioID")
                        .IsUnique()
                        .HasFilter("[SalarioID] IS NOT NULL");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("Modelo.Entidades.Salario", b =>
                {
                    b.Property<int>("SalarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("DecimoCuartoSueldo")
                        .HasColumnType("real");

                    b.Property<float>("DecimoTercerSueldo")
                        .HasColumnType("real");

                    b.Property<int>("EstadoSal")
                        .HasColumnType("int");

                    b.Property<int?>("PersonalId")
                        .HasColumnType("int");

                    b.Property<float>("SueldoBasico")
                        .HasColumnType("real");

                    b.Property<float>("Utilidades")
                        .HasColumnType("real");

                    b.HasKey("SalarioId");

                    b.HasIndex("PersonalId");

                    b.ToTable("salarios");
                });

            modelBuilder.Entity("Modelo.Entidades.SalarioDetalle", b =>
                {
                    b.Property<int>("SalarioDetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<int?>("RolesId")
                        .HasColumnType("int");

                    b.Property<int?>("SalarioId")
                        .HasColumnType("int");

                    b.HasKey("SalarioDetalleId");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("RolesId");

                    b.HasIndex("SalarioId");

                    b.ToTable("SalarioDetalle");
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

                    b.HasOne("Modelo.Entidades.Roles", "roles")
                        .WithMany("empresas")
                        .HasForeignKey("RolesId");

                    b.Navigation("Personal");

                    b.Navigation("roles");
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

            modelBuilder.Entity("Modelo.Entidades.SalarioDetalle", b =>
                {
                    b.HasOne("Modelo.Entidades.Empresa", "Empresa")
                        .WithMany("salarioDetalles")
                        .HasForeignKey("EmpresaId");

                    b.HasOne("Modelo.Entidades.Roles", "Roles")
                        .WithMany("salarioDetalles")
                        .HasForeignKey("RolesId");

                    b.HasOne("Modelo.Entidades.Salario", "Salarios")
                        .WithMany("salarioDetalles")
                        .HasForeignKey("SalarioId");

                    b.Navigation("Empresa");

                    b.Navigation("Roles");

                    b.Navigation("Salarios");
                });

            modelBuilder.Entity("Modelo.Entidades.Empresa", b =>
                {
                    b.Navigation("salarioDetalles");
                });

            modelBuilder.Entity("Modelo.Entidades.Personal", b =>
                {
                    b.Navigation("Decimos_Terceros");

                    b.Navigation("empresa");

                    b.Navigation("liquidacion");

                    b.Navigation("Roles");

                    b.Navigation("Salarios");
                });

            modelBuilder.Entity("Modelo.Entidades.Roles", b =>
                {
                    b.Navigation("empresas");

                    b.Navigation("salarioDetalles");
                });

            modelBuilder.Entity("Modelo.Entidades.Salario", b =>
                {
                    b.Navigation("decterceros");

                    b.Navigation("roles");

                    b.Navigation("salarioDetalles");
                });
#pragma warning restore 612, 618
        }
    }
}