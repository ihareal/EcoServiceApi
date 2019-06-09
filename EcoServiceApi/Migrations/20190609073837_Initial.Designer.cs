﻿// <auto-generated />
using System;
using EcoServiceApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EcoServiceApi.Migrations
{
    [DbContext(typeof(EcoServiceContext))]
    [Migration("20190609073837_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EcoServiceApi.Models.EventDetail", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("DateTime2");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("DateTime2");

                    b.Property<float>("Latitude");

                    b.Property<float>("Longitude");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("DateTime2");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<int>("UserId");

                    b.HasKey("EventId");

                    b.HasIndex("UserId");

                    b.ToTable("EventDetails");
                });

            modelBuilder.Entity("EcoServiceApi.Models.NewsDetail", b =>
                {
                    b.Property<int>("NewsId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("ReadingTime");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<int>("isRead");

                    b.HasKey("NewsId");

                    b.ToTable("NewsDetails");
                });

            modelBuilder.Entity("EcoServiceApi.Models.PollutionDetail", b =>
                {
                    b.Property<int>("PollutionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("DateTime2");

                    b.Property<string>("Description");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<int>("UserId");

                    b.HasKey("PollutionId");

                    b.HasIndex("UserId");

                    b.ToTable("PollutionDetails");
                });

            modelBuilder.Entity("EcoServiceApi.Models.UserDetail", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DwellingType")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<int>("StageAmount");

                    b.Property<int>("StageNumber");

                    b.Property<int>("isAdmin");

                    b.HasKey("UserId");

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("EcoServiceApi.Models.UserNewsDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NewsId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("NewsId");

                    b.HasIndex("UserId");

                    b.ToTable("UserNewsDetail");
                });

            modelBuilder.Entity("EcoServiceApi.Models.EventDetail", b =>
                {
                    b.HasOne("EcoServiceApi.Models.UserDetail", "UserDetail")
                        .WithMany("EventDetails")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EcoServiceApi.Models.PollutionDetail", b =>
                {
                    b.HasOne("EcoServiceApi.Models.UserDetail", "UserDetail")
                        .WithMany("PollutionDetails")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EcoServiceApi.Models.UserNewsDetail", b =>
                {
                    b.HasOne("EcoServiceApi.Models.NewsDetail", "NewsDetail")
                        .WithMany("UserNewsDetails")
                        .HasForeignKey("NewsId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EcoServiceApi.Models.UserDetail", "UserDetail")
                        .WithMany("UserNewsDetails")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
