﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RRF.RRFDbContext;

namespace RRF.RRFDbContext.Migrations
{
    [DbContext(typeof(RRFDbContext))]
    partial class RRFDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            ConcurrencyStamp = "17c5f8e2-e3db-4c4a-9d5e-195033e2e15f",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "fda3b7bb-9aed-48f5-a3d2-00fe18453e5e",
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
                            Id = "e3e966c9-5b0c-4f1c-974f-848837ffde93",
                            APIKey = new Guid("00000000-0000-0000-0000-000000000000"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "20890dfb-dbc1-4d42-a91e-f4d813eff801",
                            Email = "admin@mail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@MAIL.COM",
                            NormalizedUserName = "ADMIN@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGLgGpmSeCfwWdMqDpwQBJVX8NUlRpOjX1LMrpIbhY5ZnqO+g67My/orSGX5qkT0+g==",
                            PhoneNumber = "+359359",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "a0d6109f-4c5c-4d64-b015-13d5c0472144",
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

                    b.Property<int>("ImageRssSettingId");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedOn");

                    b.HasKey("Id");

                    b.HasIndex("ImageRssSettingId")
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

                    b.Property<int>("ItemRssSettingId");

                    b.Property<string>("LinkToCurrentElement");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<DateTime>("PubDate");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("ItemRssSettingId")
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

                    b.Property<int>("ModelRssSettingsId");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("ModelRssSettingsId");

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

                    b.Property<int>("RssElementsSettingId");

                    b.HasKey("Id");

                    b.HasIndex("ImageFormatId");

                    b.HasIndex("RssElementsSettingId")
                        .IsUnique();

                    b.ToTable("XElementsModels");
                });

            modelBuilder.Entity("RRF.EFModels.ImageFormat", b =>
                {
                    b.HasOne("RRF.EFModels.RssSettings", "ImageRssSetting")
                        .WithOne("ImageFormats")
                        .HasForeignKey("RRF.EFModels.ImageFormat", "ImageRssSettingId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("RRF.EFModels.ItemModel", b =>
                {
                    b.HasOne("RRF.EFModels.RssSettings", "ItemRssSetting")
                        .WithOne("ItemModel")
                        .HasForeignKey("RRF.EFModels.ItemModel", "ItemRssSettingId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("RRF.EFModels.ModelElement", b =>
                {
                    b.HasOne("RRF.EFModels.RssSettings", "RssSetting")
                        .WithMany("ModelElements")
                        .HasForeignKey("ModelRssSettingsId")
                        .OnDelete(DeleteBehavior.Cascade);
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

                    b.HasOne("RRF.EFModels.RssSettings", "RssElementsSetting")
                        .WithOne("MainElement")
                        .HasForeignKey("RRF.EFModels.XElementModel", "RssElementsSettingId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
