﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPagesMovie.Data;

namespace RazorPagesMovie.Migrations
{
    [DbContext(typeof(RazorPagesMovieContext))]
    [Migration("20200512074359_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("RazorPagesMovie.Models.Addmovie", b =>
                {
                    b.Property<int>("VID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Actor")
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .HasColumnType("TEXT");

                    b.Property<string>("Language")
                        .HasColumnType("TEXT");

                    b.Property<string>("Moviename")
                        .HasColumnType("TEXT");

                    b.HasKey("VID");

                    b.ToTable("Addmovie");
                });

            modelBuilder.Entity("RazorPagesMovie.Models.Adduser", b =>
                {
                    b.Property<int>("UID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Uname")
                        .HasColumnType("TEXT");

                    b.Property<string>("password")
                        .HasColumnType("TEXT");

                    b.Property<int>("phone")
                        .HasColumnType("INTEGER");

                    b.HasKey("UID");

                    b.ToTable("Adduser");
                });

            modelBuilder.Entity("RazorPagesMovie.Models.Record", b =>
                {
                    b.Property<int>("RecordsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AddmovieVID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AdduserUID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TakenDate")
                        .HasColumnType("TEXT");

                    b.HasKey("RecordsId");

                    b.HasIndex("AddmovieVID");

                    b.HasIndex("AdduserUID");

                    b.ToTable("Record");
                });

            modelBuilder.Entity("RazorPagesMovie.Models.Record", b =>
                {
                    b.HasOne("RazorPagesMovie.Models.Addmovie", "Addmovie")
                        .WithMany()
                        .HasForeignKey("AddmovieVID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RazorPagesMovie.Models.Adduser", "Adduser")
                        .WithMany()
                        .HasForeignKey("AdduserUID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
