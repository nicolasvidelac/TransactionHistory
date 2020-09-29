﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication2.Models;

namespace WebApplication2.Migrations
{
    [DbContext(typeof(TransactionBdContext))]
    partial class TransactionBdContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication2.Models.TransactionModel", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccounbtNumber")
                        .HasColumnType("nvarchar(12)");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("BankName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("BeneficiaryName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("SWIFTCode")
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("TransactionId");

                    b.ToTable("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
