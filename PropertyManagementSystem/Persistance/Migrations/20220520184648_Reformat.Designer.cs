﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PropertyManagementSystem.Persistance;

#nullable disable

namespace Persistance.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220520184648_Reformat")]
    partial class Reformat
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PropertyManagementSystem.Domain.Guest", b =>
                {
                    b.Property<int>("GuestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("GuestId"));

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.HasKey("GuestId");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("PropertyManagementSystem.Domain.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RoomId"));

                    b.Property<int>("RoomNumber")
                        .HasColumnType("integer");

                    b.Property<string>("RoomType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("RoomId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("PropertyManagementSystem.Domain.Stay", b =>
                {
                    b.Property<Guid>("StayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("GuestId")
                        .HasColumnType("integer");

                    b.Property<int?>("RoomId")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("StayId");

                    b.HasIndex("GuestId");

                    b.HasIndex("RoomId");

                    b.ToTable("Stays");
                });

            modelBuilder.Entity("PropertyManagementSystem.Domain.Stay", b =>
                {
                    b.HasOne("PropertyManagementSystem.Domain.Guest", "Guest")
                        .WithMany("Stays")
                        .HasForeignKey("GuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PropertyManagementSystem.Domain.Room", "Room")
                        .WithMany("Stays")
                        .HasForeignKey("RoomId");

                    b.Navigation("Guest");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("PropertyManagementSystem.Domain.Guest", b =>
                {
                    b.Navigation("Stays");
                });

            modelBuilder.Entity("PropertyManagementSystem.Domain.Room", b =>
                {
                    b.Navigation("Stays");
                });
#pragma warning restore 612, 618
        }
    }
}