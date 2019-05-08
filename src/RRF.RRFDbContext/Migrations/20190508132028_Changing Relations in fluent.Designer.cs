﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RRF.RRFDbContext;

namespace RRF.RRFDbContext.Migrations
{
    [DbContext(typeof(RRFDbContext))]
    [Migration("20190508132028_Changing Relations in fluent")]
    partial class ChangingRelationsinfluent
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedName");

                    b.HasKey("Id");

                    b.ToTable("IdentityRole");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ConcurrencyStamp = "5eb8a401-04a6-4e50-b8b9-d65eb3709e39",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "2328b4f3-3f20-4443-8975-b20485d6f1a6",
                            Name = "Client",
                            NormalizedName = "CLIENT"
                        });
                });

            modelBuilder.Entity("RRF.EFModels.Client", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("APIKey");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = "44fed7ae-7502-4867-949c-a9b9bbb8cb60",
                            APIKey = new Guid("00000000-0000-0000-0000-000000000000"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3a1538d9-2056-4ae5-8f02-86382d13a27a",
                            Email = "admin@mail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@MAIL.COM",
                            NormalizedUserName = "ADMIN@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEI8NqdassFWA30EqKL/UcgZ+aaNf2h5ERCmQMXooMNBaAZoE2Fy8z9uHJTodnt3hMw==",
                            PhoneNumber = "+359359",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "2a88bb4d-7d35-4f9f-b88e-c5dabe291510",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        });
                });

            modelBuilder.Entity("RRF.EFModels.ImageFormat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<int>("RssSettingId");

                    b.HasKey("Id");

                    b.HasIndex("RssSettingId")
                        .IsUnique();

                    b.ToTable("ImageFormats");
                });

            modelBuilder.Entity("RRF.EFModels.ItemModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<string>("Description");

                    b.Property<string>("ImageSRC");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LinkToCurrentElement");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<DateTime>("PubDate");

                    b.Property<int>("RssSettingId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("RssSettingId")
                        .IsUnique();

                    b.ToTable("ItemModels");
                });

            modelBuilder.Entity("RRF.EFModels.ModelElement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BuildName");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsProcessed");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name");

                    b.Property<int>("RssSettingsId");

                    b.HasKey("Id");

                    b.HasIndex("RssSettingsId");

                    b.ToTable("ModelElements");
                });

            modelBuilder.Entity("RRF.EFModels.RssChannel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClientId");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name");

                    b.Property<string>("URL");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("RssChannels");
                });

            modelBuilder.Entity("RRF.EFModels.RssSettings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<int>("RssChannelId");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RssChannelId");

                    b.ToTable("RssSettings");
                });

            modelBuilder.Entity("RRF.EFModels.XElementModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<int>("ImageFormatId");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name");

                    b.Property<int>("RssElementSettingId");

                    b.Property<int>("RssSettingId");

                    b.HasKey("Id");

                    b.HasIndex("ImageFormatId");

                    b.HasIndex("RssElementSettingId")
                        .IsUnique();

                    b.ToTable("XElementsModels");
                });

            modelBuilder.Entity("RRF.EFModels.ImageFormat", b =>
                {
                    b.HasOne("RRF.EFModels.RssSettings", "RssSetting")
                        .WithOne("ImageFormats")
                        .HasForeignKey("RRF.EFModels.ImageFormat", "RssSettingId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("RRF.EFModels.ItemModel", b =>
                {
                    b.HasOne("RRF.EFModels.RssSettings", "RssSetting")
                        .WithOne("ItemModel")
                        .HasForeignKey("RRF.EFModels.ItemModel", "RssSettingId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("RRF.EFModels.ModelElement", b =>
                {
                    b.HasOne("RRF.EFModels.RssSettings", "RssSetting")
                        .WithMany("ModelElements")
                        .HasForeignKey("RssSettingsId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("RRF.EFModels.RssChannel", b =>
                {
                    b.HasOne("RRF.EFModels.Client", "Client")
                        .WithMany("Channels")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("RRF.EFModels.RssSettings", b =>
                {
                    b.HasOne("RRF.EFModels.RssChannel", "RssChannel")
                        .WithMany("Settings")
                        .HasForeignKey("RssChannelId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("RRF.EFModels.XElementModel", b =>
                {
                    b.HasOne("RRF.EFModels.ImageFormat", "ImageFormat")
                        .WithMany("ImageSearchTag")
                        .HasForeignKey("ImageFormatId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("RRF.EFModels.RssSettings", "RssElementSetting")
                        .WithOne("MainElement")
                        .HasForeignKey("RRF.EFModels.XElementModel", "RssElementSettingId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
