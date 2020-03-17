﻿// <auto-generated />
using System;
using BlazingPizza.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazingPizza.Server.Migrations
{
    [DbContext(typeof(PizzaStoreContext))]
    partial class PizzaStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BlazingPizza.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("Line1")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("Line2")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20);

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("BlazingPizza.Shared.Models.NotificationSubscription", b =>
                {
                    b.Property<int>("NotificationSubscriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Auth")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("P256dh")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Url")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("NotificationSubscriptionId");

                    b.ToTable("NotificationSubscriptions");
                });

            modelBuilder.Entity("BlazingPizza.Shared.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("DeliveryAddressId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("OrderId");

                    b.HasIndex("DeliveryAddressId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BlazingPizza.Shared.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Biography")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("BlazingPizza.Shared.Models.Pizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<int>("SpecialId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("SpecialId");

                    b.ToTable("Pizzas");
                });

            modelBuilder.Entity("BlazingPizza.Shared.Models.PizzaSpecial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("BasePrice")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Specials");
                });

            modelBuilder.Entity("BlazingPizza.Shared.Models.PizzaTopping", b =>
                {
                    b.Property<int>("PizzaId")
                        .HasColumnType("int");

                    b.Property<int>("ToppingId")
                        .HasColumnType("int");

                    b.HasKey("PizzaId", "ToppingId");

                    b.HasIndex("ToppingId");

                    b.ToTable("PizzaTopping");
                });

            modelBuilder.Entity("BlazingPizza.Shared.Models.Topping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Toppings");
                });

            modelBuilder.Entity("BlazingPizza.Shared.Models.Order", b =>
                {
                    b.HasOne("BlazingPizza.Address", "DeliveryAddress")
                        .WithMany()
                        .HasForeignKey("DeliveryAddressId");

                    b.OwnsOne("BlazingPizza.LatLong", "DeliveryLocation", b1 =>
                        {
                            b1.Property<int>("OrderId")
                                .HasColumnType("int");

                            b1.Property<double>("Latitude")
                                .HasColumnType("double");

                            b1.Property<double>("Longitude")
                                .HasColumnType("double");

                            b1.HasKey("OrderId");

                            b1.ToTable("Orders");

                            b1.WithOwner()
                                .HasForeignKey("OrderId");
                        });
                });

            modelBuilder.Entity("BlazingPizza.Shared.Models.Pizza", b =>
                {
                    b.HasOne("BlazingPizza.Shared.Models.Order", null)
                        .WithMany("Pizzas")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazingPizza.Shared.Models.PizzaSpecial", "Special")
                        .WithMany()
                        .HasForeignKey("SpecialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlazingPizza.Shared.Models.PizzaTopping", b =>
                {
                    b.HasOne("BlazingPizza.Shared.Models.Pizza", null)
                        .WithMany("Toppings")
                        .HasForeignKey("PizzaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazingPizza.Shared.Models.Topping", "Topping")
                        .WithMany()
                        .HasForeignKey("ToppingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
