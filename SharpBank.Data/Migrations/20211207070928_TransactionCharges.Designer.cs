﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SharpBank.Data;

#nullable disable

namespace SharpBank.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211207070928_TransactionCharges")]
    partial class TransactionCharges
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SharpBank.Models.Account", b =>
                {
                    b.Property<Guid>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BankId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FundsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("AccountId");

                    b.HasIndex("BankId");

                    b.HasIndex("FundsId");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            AccountId = new Guid("502237e2-63b3-4645-8a31-decc5a52e379"),
                            BankId = new Guid("f6f0fd94-bb7e-454e-925c-a0d5f539f813"),
                            FundsId = new Guid("b97bfc17-6ac5-4428-b855-511b9465d6ab"),
                            Gender = 0,
                            Name = "Testendra Testy",
                            Password = "password",
                            Status = 0
                        },
                        new
                        {
                            AccountId = new Guid("ae7b64b2-b309-493e-b4f0-48262a0e6b1c"),
                            BankId = new Guid("f6f0fd94-bb7e-454e-925c-a0d5f539f813"),
                            FundsId = new Guid("b97bfc17-6ac5-4428-b855-511b9465d6ab"),
                            Gender = 0,
                            Name = "Wastendar Wastee",
                            Password = "password",
                            Status = 0
                        });
                });

            modelBuilder.Entity("SharpBank.Models.Bank", b =>
                {
                    b.Property<Guid>("BankId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("BankId");

                    b.ToTable("Banks");

                    b.HasData(
                        new
                        {
                            BankId = new Guid("f6f0fd94-bb7e-454e-925c-a0d5f539f813"),
                            CreatedBy = "Cat",
                            CreatedOn = new DateTime(2021, 12, 7, 12, 39, 26, 197, DateTimeKind.Local).AddTicks(7992),
                            Name = "Test Bank",
                            UpdatedBy = "Cat",
                            UpdatedOn = new DateTime(2021, 12, 7, 12, 39, 26, 197, DateTimeKind.Local).AddTicks(8020)
                        });
                });

            modelBuilder.Entity("SharpBank.Models.Funds", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("FundsTable");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b97bfc17-6ac5-4428-b855-511b9465d6ab")
                        },
                        new
                        {
                            Id = new Guid("342f9963-2a24-49d4-9f6d-cabfcfe6ad84")
                        });
                });

            modelBuilder.Entity("SharpBank.Models.Money", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Currency")
                        .HasColumnType("int");

                    b.Property<Guid>("FundsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("FundsId");

                    b.ToTable("Money");

                    b.HasData(
                        new
                        {
                            Id = new Guid("25b83c46-2aee-4aa0-be33-0f395456ca9f"),
                            Amount = 10m,
                            Currency = 356,
                            FundsId = new Guid("b97bfc17-6ac5-4428-b855-511b9465d6ab")
                        },
                        new
                        {
                            Id = new Guid("5552db6d-1b61-445b-bc43-202af5512b83"),
                            Amount = 10m,
                            Currency = 356,
                            FundsId = new Guid("342f9963-2a24-49d4-9f6d-cabfcfe6ad84")
                        });
                });

            modelBuilder.Entity("SharpBank.Models.Transaction", b =>
                {
                    b.Property<Guid>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DestinationAccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MoneyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("On")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("SourceAccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("TransactionId");

                    b.HasIndex("DestinationAccountId");

                    b.HasIndex("MoneyId");

                    b.HasIndex("SourceAccountId");

                    b.ToTable("Transactions");

                    b.HasData(
                        new
                        {
                            TransactionId = new Guid("2114e135-1fd4-4cb5-b9d1-6a8edc68fb25"),
                            DestinationAccountId = new Guid("ae7b64b2-b309-493e-b4f0-48262a0e6b1c"),
                            MoneyId = new Guid("5552db6d-1b61-445b-bc43-202af5512b83"),
                            On = new DateTime(2021, 12, 7, 12, 39, 26, 197, DateTimeKind.Local).AddTicks(8722),
                            SourceAccountId = new Guid("502237e2-63b3-4645-8a31-decc5a52e379"),
                            Type = 0
                        });
                });

            modelBuilder.Entity("SharpBank.Models.TransactionCharge", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BankId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("IMPS")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NEFT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("RTGS")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("BankId");

                    b.ToTable("Charges");
                });

            modelBuilder.Entity("SharpBank.Models.Account", b =>
                {
                    b.HasOne("SharpBank.Models.Bank", "Bank")
                        .WithMany("Accounts")
                        .HasForeignKey("BankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SharpBank.Models.Funds", "Funds")
                        .WithMany()
                        .HasForeignKey("FundsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bank");

                    b.Navigation("Funds");
                });

            modelBuilder.Entity("SharpBank.Models.Money", b =>
                {
                    b.HasOne("SharpBank.Models.Funds", "Funds")
                        .WithMany("Wallets")
                        .HasForeignKey("FundsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funds");
                });

            modelBuilder.Entity("SharpBank.Models.Transaction", b =>
                {
                    b.HasOne("SharpBank.Models.Account", "DestinationAccount")
                        .WithMany("CreditTransactions")
                        .HasForeignKey("DestinationAccountId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SharpBank.Models.Money", "Money")
                        .WithMany()
                        .HasForeignKey("MoneyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SharpBank.Models.Account", "SourceAccount")
                        .WithMany("DebitTransactions")
                        .HasForeignKey("SourceAccountId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("DestinationAccount");

                    b.Navigation("Money");

                    b.Navigation("SourceAccount");
                });

            modelBuilder.Entity("SharpBank.Models.TransactionCharge", b =>
                {
                    b.HasOne("SharpBank.Models.Bank", "Bank")
                        .WithMany("Charges")
                        .HasForeignKey("BankId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Bank");
                });

            modelBuilder.Entity("SharpBank.Models.Account", b =>
                {
                    b.Navigation("CreditTransactions");

                    b.Navigation("DebitTransactions");
                });

            modelBuilder.Entity("SharpBank.Models.Bank", b =>
                {
                    b.Navigation("Accounts");

                    b.Navigation("Charges");
                });

            modelBuilder.Entity("SharpBank.Models.Funds", b =>
                {
                    b.Navigation("Wallets");
                });
#pragma warning restore 612, 618
        }
    }
}
