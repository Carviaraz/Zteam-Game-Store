﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Zteam.Data;

#nullable disable

namespace Zteam.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240331185243_first")]
    partial class first
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GameGenre", b =>
                {
                    b.Property<int>("GamesGameId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("GamesGameId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("GameGenre");
                });

            modelBuilder.Entity("Zteam.Models.BuyDtl", b =>
                {
                    b.Property<string>("BuyId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double?>("BdtlPrice")
                        .HasColumnType("float");

                    b.Property<double?>("BdtlQty")
                        .HasColumnType("float");

                    b.Property<string>("GameId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BuyId");

                    b.ToTable("BuyDtl");
                });

            modelBuilder.Entity("Zteam.Models.Buying", b =>
                {
                    b.Property<string>("BuyId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateOnly?>("BuyDate")
                        .HasColumnType("date");

                    b.Property<string>("BuyDocId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("BuyQty")
                        .HasColumnType("float");

                    b.Property<string>("DeveloperName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DevoperId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StfId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BuyId");

                    b.ToTable("Buyings");
                });

            modelBuilder.Entity("Zteam.Models.Cart", b =>
                {
                    b.Property<string>("CartId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double?>("CartCf")
                        .HasColumnType("float");

                    b.Property<DateOnly?>("CartDate")
                        .HasColumnType("date");

                    b.Property<double?>("CartMoney")
                        .HasColumnType("float");

                    b.Property<string>("CartPay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("CartQty")
                        .HasColumnType("float");

                    b.Property<string>("CusId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CartId");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("Zteam.Models.CartDtl", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartId"));

                    b.Property<double?>("CdtlMoney")
                        .HasColumnType("float");

                    b.Property<double?>("CdtlPrice")
                        .HasColumnType("float");

                    b.Property<double?>("CdtlQty")
                        .HasColumnType("float");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.HasKey("CartId");

                    b.ToTable("CartDtls");
                });

            modelBuilder.Entity("Zteam.Models.Customer", b =>
                {
                    b.Property<int>("CusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CusId"));

                    b.Property<string>("CusAdd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CusEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CusPass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly?>("LastLogin")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("CusId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Zteam.Models.Developer", b =>
                {
                    b.Property<int>("DeveloperId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeveloperId"));

                    b.Property<string>("DeveloperName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("DeveloperId");

                    b.ToTable("Developer");
                });

            modelBuilder.Entity("Zteam.Models.Duty", b =>
                {
                    b.Property<string>("DutyId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DutyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DutyId");

                    b.ToTable("Duty");
                });

            modelBuilder.Entity("Zteam.Models.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GameId"));

                    b.Property<int?>("DeveloperId")
                        .HasColumnType("int");

                    b.Property<byte[]>("GameImage")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("GameInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GameName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("Rating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReleaseDate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameId");

                    b.HasIndex("DeveloperId");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("Zteam.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"));

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("Zteam.Models.Staff", b =>
                {
                    b.Property<string>("StfId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DutyId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly?>("QuitDate")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("StartDate")
                        .HasColumnType("date");

                    b.Property<string>("StfName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StfPass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StfId");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("GameGenre", b =>
                {
                    b.HasOne("Zteam.Models.Game", null)
                        .WithMany()
                        .HasForeignKey("GamesGameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Zteam.Models.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Zteam.Models.Game", b =>
                {
                    b.HasOne("Zteam.Models.Developer", "Developer")
                        .WithMany("GamesDeveloped")
                        .HasForeignKey("DeveloperId");

                    b.Navigation("Developer");
                });

            modelBuilder.Entity("Zteam.Models.Developer", b =>
                {
                    b.Navigation("GamesDeveloped");
                });
#pragma warning restore 612, 618
        }
    }
}
