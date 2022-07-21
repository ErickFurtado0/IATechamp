﻿// <auto-generated />
using System;
using IATechamp.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IATechamp.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220708144624_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("IATechamp.Models.ChampionshipModel", b =>
                {
                    b.Property<int>("IdChampionship")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdChampionship"), 1L, 1);

                    b.Property<string>("NameChampionship")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Championship");

                    b.HasKey("IdChampionship");

                    b.ToTable("Championship");
                });

            modelBuilder.Entity("IATechamp.Models.EventModel", b =>
                {
                    b.Property<int>("IdEvent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEvent"), 1L, 1);

                    b.Property<DateTime>("DateEvent")
                        .HasColumnType("datetime2")
                        .HasColumnName("Event");

                    b.HasKey("IdEvent");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("IATechamp.Models.PlayerModel", b =>
                {
                    b.Property<int>("IdPlayer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPlayer"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NamePlayer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Player");

                    b.HasKey("IdPlayer");

                    b.ToTable("Player");

                    b.HasDiscriminator<string>("Discriminator").HasValue("PlayerModel");
                });

            modelBuilder.Entity("IATechamp.Models.ScoreboardModel", b =>
                {
                    b.HasBaseType("IATechamp.Models.PlayerModel");

                    b.Property<int>("GamePlayed")
                        .HasColumnType("int");

                    b.Property<int>("GamePoints")
                        .HasColumnType("int");

                    b.Property<int>("IdScoreboard")
                        .HasColumnType("int");

                    b.Property<int>("PlayerPoints")
                        .HasColumnType("int");

                    b.Property<int>("SetPoints")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("ScoreboardModel");
                });

            modelBuilder.Entity("IATechamp.Models.RankingModel", b =>
                {
                    b.HasBaseType("IATechamp.Models.ScoreboardModel");

                    b.HasDiscriminator().HasValue("RankingModel");
                });
#pragma warning restore 612, 618
        }
    }
}
