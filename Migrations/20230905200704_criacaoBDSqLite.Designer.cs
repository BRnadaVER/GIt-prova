﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoCRUDSQLite.Models;

#nullable disable

namespace ProjetoCRUDSQLite.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20230905200704_criacaoBDSqLite")]
    partial class criacaoBDSqLite
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("ProjetoCRUDSQLite.Models.Aviao", b =>
                {
                    b.Property<int>("AviaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Fabricante")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("QuantidadePassageiros")
                        .HasColumnType("INTEGER");

                    b.HasKey("AviaoId");

                    b.ToTable("Avioes");
                });
#pragma warning restore 612, 618
        }
    }
}