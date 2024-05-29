﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelManagementApp.Migrations
{
    [DbContext(typeof(HotelContext))]
    partial class HotelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.5");

            modelBuilder.Entity("EjercicioFinalOOP.Models.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Discount")
                        .HasColumnType("REAL");

                    b.Property<float>("TotalAmmount")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Invoice", (string)null);
                });

            modelBuilder.Entity("EjercicioFinalOOP.Models.InvoiceItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GuestIdNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<uint?>("RoomNumber")
                        .HasColumnType("INTEGER");

                    b.Property<float>("TotalCost")
                        .HasColumnType("REAL");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<float>("UnitCost")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("When")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GuestIdNumber");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("RoomNumber");

                    b.ToTable("InvoiceItem");
                });

            modelBuilder.Entity("EjercicioFinalOOP.Models.Minibar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("LiquorBottles")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PersonalCareKits")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Sodas")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WaterBottles")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WineBottles")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Minibar");
                });

            modelBuilder.Entity("EjercicioFinalOOP.Models.Person", b =>
                {
                    b.Property<string>("IdNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("TEXT");

                    b.Property<string>("IdType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdNumber");

                    b.ToTable("Person", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("EjercicioFinalOOP.Models.Reservation", b =>
                {
                    b.Property<uint>("ReservationNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ReservedGuestIdNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<uint>("ReservedRoomRoomNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("ReservationNumber");

                    b.HasIndex("ReservedGuestIdNumber");

                    b.HasIndex("ReservedRoomRoomNumber");

                    b.ToTable("Reservation", (string)null);
                });

            modelBuilder.Entity("EjercicioFinalOOP.Models.Room", b =>
                {
                    b.Property<uint>("RoomNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<uint>("Capacity")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CheckinDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("TEXT");

                    b.Property<uint>("Floor")
                        .HasColumnType("INTEGER");

                    b.Property<string>("GuestIdNumber")
                        .HasColumnType("TEXT");

                    b.Property<int?>("InvoiceId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("NightlyRate")
                        .HasColumnType("REAL");

                    b.Property<bool>("Occupied")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("OutDate")
                        .HasColumnType("TEXT");

                    b.HasKey("RoomNumber");

                    b.HasIndex("GuestIdNumber");

                    b.HasIndex("InvoiceId");

                    b.ToTable("Room", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("Room");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("EjercicioFinalOOP.Models.Customer", b =>
                {
                    b.HasBaseType("EjercicioFinalOOP.Models.Person");

                    b.Property<float>("Discount")
                        .HasColumnType("REAL");

                    b.Property<string>("LoyaltyCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Customer");
                });

            modelBuilder.Entity("EjercicioFinalOOP.Models.Guest", b =>
                {
                    b.HasBaseType("EjercicioFinalOOP.Models.Person");

                    b.HasDiscriminator().HasValue("Guest");
                });

            modelBuilder.Entity("EjercicioFinalOOP.Models.ExecutiveRoom", b =>
                {
                    b.HasBaseType("EjercicioFinalOOP.Models.Room");

                    b.Property<int>("BedType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MinibarId")
                        .HasColumnType("INTEGER");

                    b.HasIndex("MinibarId");

                    b.HasDiscriminator().HasValue("ExecutiveRoom");
                });

            modelBuilder.Entity("EjercicioFinalOOP.Models.SimpleRoom", b =>
                {
                    b.HasBaseType("EjercicioFinalOOP.Models.Room");

                    b.Property<int>("BedType")
                        .HasColumnType("INTEGER");

                    b.ToTable("Room", t =>
                        {
                            t.Property("BedType")
                                .HasColumnName("SimpleRoom_BedType");
                        });

                    b.HasDiscriminator().HasValue("SimpleRoom");
                });

            modelBuilder.Entity("EjercicioFinalOOP.Models.Suite", b =>
                {
                    b.HasBaseType("EjercicioFinalOOP.Models.Room");

                    b.Property<int>("Bathrobes")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BedType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MinibarId")
                        .HasColumnType("INTEGER");

                    b.HasIndex("MinibarId");

                    b.ToTable("Room", t =>
                        {
                            t.Property("BedType")
                                .HasColumnName("Suite_BedType");

                            t.Property("MinibarId")
                                .HasColumnName("Suite_MinibarId");
                        });

                    b.HasDiscriminator().HasValue("Suite");
                });

            modelBuilder.Entity("EjercicioFinalOOP.Models.InvoiceItem", b =>
                {
                    b.HasOne("EjercicioFinalOOP.Models.Person", "Guest")
                        .WithMany()
                        .HasForeignKey("GuestIdNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EjercicioFinalOOP.Models.Invoice", "Invoice")
                        .WithMany("Items")
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EjercicioFinalOOP.Models.Room", null)
                        .WithMany("Transactions")
                        .HasForeignKey("RoomNumber");

                    b.Navigation("Guest");

                    b.Navigation("Invoice");
                });

            modelBuilder.Entity("EjercicioFinalOOP.Models.Reservation", b =>
                {
                    b.HasOne("EjercicioFinalOOP.Models.Person", "ReservedGuest")
                        .WithMany()
                        .HasForeignKey("ReservedGuestIdNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EjercicioFinalOOP.Models.Room", "ReservedRoom")
                        .WithMany()
                        .HasForeignKey("ReservedRoomRoomNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ReservedGuest");

                    b.Navigation("ReservedRoom");
                });

            modelBuilder.Entity("EjercicioFinalOOP.Models.Room", b =>
                {
                    b.HasOne("EjercicioFinalOOP.Models.Person", "Guest")
                        .WithMany()
                        .HasForeignKey("GuestIdNumber");

                    b.HasOne("EjercicioFinalOOP.Models.Invoice", "Invoice")
                        .WithMany()
                        .HasForeignKey("InvoiceId");

                    b.Navigation("Guest");

                    b.Navigation("Invoice");
                });

            modelBuilder.Entity("EjercicioFinalOOP.Models.ExecutiveRoom", b =>
                {
                    b.HasOne("EjercicioFinalOOP.Models.Minibar", "Minibar")
                        .WithMany()
                        .HasForeignKey("MinibarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Minibar");
                });

            modelBuilder.Entity("EjercicioFinalOOP.Models.Suite", b =>
                {
                    b.HasOne("EjercicioFinalOOP.Models.Minibar", "Minibar")
                        .WithMany()
                        .HasForeignKey("MinibarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Minibar");
                });

            modelBuilder.Entity("EjercicioFinalOOP.Models.Invoice", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("EjercicioFinalOOP.Models.Room", b =>
                {
                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
