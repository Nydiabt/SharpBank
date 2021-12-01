﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SharpBank.API;

#nullable disable

namespace SharpBank.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            AccountId = new Guid("00dcc120-bfd5-4cb9-9710-3dbcbcc5d0aa"),
                            BankId = new Guid("339186ff-4c10-48c4-8930-3ebd03c611b8"),
                            FundsId = new Guid("54a11d72-0ed4-4a59-8d5c-1cfe5f0452c9"),
                            Gender = 0,
                            Name = "Testendra Testy",
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
                            BankId = new Guid("339186ff-4c10-48c4-8930-3ebd03c611b8"),
                            CreatedBy = "Cat",
                            CreatedOn = new DateTime(2021, 12, 1, 10, 3, 43, 934, DateTimeKind.Local).AddTicks(1027),
                            Name = "Test Bank",
                            UpdatedBy = "Cat",
                            UpdatedOn = new DateTime(2021, 12, 1, 10, 3, 43, 934, DateTimeKind.Local).AddTicks(1042)
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
                            Id = new Guid("54a11d72-0ed4-4a59-8d5c-1cfe5f0452c9")
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
                });

            modelBuilder.Entity("SharpBank.Models.Transaction", b =>
                {
                    b.Property<Guid>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AmountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DestinationAccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("On")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("SourceAccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("TransactionId");

                    b.HasIndex("AmountId");

                    b.HasIndex("DestinationAccountId");

                    b.HasIndex("SourceAccountId");

                    b.ToTable("Transactions");
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

                    b.ToTable("TransactionCharge");
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
                    b.HasOne("SharpBank.Models.Money", "Amount")
                        .WithMany()
                        .HasForeignKey("AmountId");

                    b.HasOne("SharpBank.Models.Account", "DestinationAccount")
                        .WithMany("CreditTransactions")
                        .HasForeignKey("DestinationAccountId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SharpBank.Models.Account", "SourceAccount")
                        .WithMany("DebitTransactions")
                        .HasForeignKey("SourceAccountId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Amount");

                    b.Navigation("DestinationAccount");

                    b.Navigation("SourceAccount");
                });

            modelBuilder.Entity("SharpBank.Models.TransactionCharge", b =>
                {
                    b.HasOne("SharpBank.Models.Bank", "Bank")
                        .WithMany("Charges")
                        .HasForeignKey("BankId")
                        .OnDelete(DeleteBehavior.Cascade)
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