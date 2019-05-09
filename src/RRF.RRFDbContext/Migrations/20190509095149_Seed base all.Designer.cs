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
    [Migration("20190509095149_Seed base all")]
    partial class Seedbaseall
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
                            ConcurrencyStamp = "de8b9442-862d-462e-af19-9a9886e00a87",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "18f74838-7913-4467-9549-c7f585f23224",
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
                            Id = "baa0d4c2-1589-4378-be1c-238612953ae1",
                            APIKey = new Guid("00000000-0000-0000-0000-000000000000"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "88166ac2-cb87-452f-9ab6-b26ab263c4af",
                            Email = "client@mail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "CLIENT@MAIL.COM",
                            NormalizedUserName = "CLIENT@MAIL.COM",
                            PhoneNumber = "+359359",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "17cfabbd-325a-4a13-ac86-6ac0efc20d60",
                            TwoFactorEnabled = false,
                            UserName = "Client"
                        },
                        new
                        {
                            Id = "d91fa742-a57f-433e-a656-7671ea14141e",
                            APIKey = new Guid("00000000-0000-0000-0000-000000000000"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "40137215-b7ac-47dc-a8a9-255da02e255a",
                            Email = "admin@mail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@MAIL.COM",
                            NormalizedUserName = "ADMIN@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEHE3mVyR7U/AQxiw3FeQpjSF/f0aeUncPzu5rMf4y55k2s0i0/AcBREoh78cZnOwxg==",
                            PhoneNumber = "+359359",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "7460bf21-eee5-4e3a-a169-1e769a8f165d",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        });
                });

            modelBuilder.Entity("RRF.EFModels.DescendingElement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name");

                    b.Property<int?>("RssSettingDescendantElement_Id");

                    b.HasKey("Id");

                    b.HasIndex("RssSettingDescendantElement_Id")
                        .IsUnique()
                        .HasFilter("[RssSettingDescendantElement_Id] IS NOT NULL");

                    b.ToTable("DescendingElements");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTime(2019, 5, 9, 12, 51, 47, 427, DateTimeKind.Local).AddTicks(8611),
                            IsDeleted = false,
                            ModifiedOn = new DateTime(2019, 5, 9, 12, 51, 47, 428, DateTimeKind.Local).AddTicks(143),
                            Name = "item",
                            RssSettingDescendantElement_Id = 1
                        });
                });

            modelBuilder.Entity("RRF.EFModels.ImageElement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<string>("ElementSubName");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name");

                    b.Property<int?>("RssSettingImageFormatElement_Id");

                    b.HasKey("Id");

                    b.HasIndex("RssSettingImageFormatElement_Id");

                    b.ToTable("ImageElements");
                });

            modelBuilder.Entity("RRF.EFModels.ModelElement", b =>
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

                    b.Property<int>("RssSettingDisplayModelElementId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("RssSettingDisplayModelElementId")
                        .IsUnique();

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

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("RssChannels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClientId = "baa0d4c2-1589-4378-be1c-238612953ae1",
                            CreatedOn = new DateTime(2019, 5, 9, 12, 51, 47, 426, DateTimeKind.Local).AddTicks(5833),
                            IsDeleted = false,
                            Name = "testRssChannel",
                            URL = "https://www.vesti.bg/rss.php"
                        });
                });

            modelBuilder.Entity("RRF.EFModels.RssSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClientId");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<int?>("RssChanel_Id");

                    b.HasKey("Id");

                    b.HasIndex("RssChanel_Id")
                        .IsUnique()
                        .HasFilter("[RssChanel_Id] IS NOT NULL");

                    b.ToTable("RssSettings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClientId = "baa0d4c2-1589-4378-be1c-238612953ae1",
                            CreatedOn = new DateTime(2019, 5, 9, 12, 51, 47, 427, DateTimeKind.Local).AddTicks(2709),
                            IsDeleted = false,
                            RssChanel_Id = 1
                        });
                });

            modelBuilder.Entity("RRF.EFModels.XElementModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name");

                    b.Property<int?>("RssSettingFormatElements_Id");

                    b.Property<string>("UseName");

                    b.HasKey("Id");

                    b.HasIndex("RssSettingFormatElements_Id");

                    b.ToTable("XElementsModels");
                });

            modelBuilder.Entity("RRF.EFModels.DescendingElement", b =>
                {
                    b.HasOne("RRF.EFModels.RssSetting", "RssSettingDescendantElement")
                        .WithOne("DescendantElement")
                        .HasForeignKey("RRF.EFModels.DescendingElement", "RssSettingDescendantElement_Id")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("RRF.EFModels.ImageElement", b =>
                {
                    b.HasOne("RRF.EFModels.RssSetting", "RssSettingImageFormatElement")
                        .WithMany("RssImageFormatElements")
                        .HasForeignKey("RssSettingImageFormatElement_Id")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("RRF.EFModels.ModelElement", b =>
                {
                    b.HasOne("RRF.EFModels.RssSetting", "RssSettingDisplayModelElement")
                        .WithOne("RssModelElements")
                        .HasForeignKey("RRF.EFModels.ModelElement", "RssSettingDisplayModelElementId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("RRF.EFModels.RssChannel", b =>
                {
                    b.HasOne("RRF.EFModels.Client", "Client")
                        .WithMany("Channels")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("RRF.EFModels.RssSetting", b =>
                {
                    b.HasOne("RRF.EFModels.RssChannel", "RssChannel")
                        .WithOne("RssSeting")
                        .HasForeignKey("RRF.EFModels.RssSetting", "RssChanel_Id")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("RRF.EFModels.XElementModel", b =>
                {
                    b.HasOne("RRF.EFModels.RssSetting", "RssSettingFormatElements")
                        .WithMany("RssFormatElements")
                        .HasForeignKey("RssSettingFormatElements_Id")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}