﻿// <auto-generated />
using System;
using Medium.ReplacingIfElse.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Medium.ReplacingIfElse.DataLayer.Migrations
{
    [DbContext(typeof(DataStore))]
    [Migration("20200828165736_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Application")
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Medium.ReplacingIfElse.Domain.User", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users","Application");

                    b.HasData(
                        new
                        {
                            id = new Guid("be20ff2c-d1e6-47d4-8a2c-40cd0e528c6c"),
                            Email = "someuser@user.dk",
                            Username = "someuser@user.dk"
                        },
                        new
                        {
                            id = new Guid("7d0cc1c1-f97c-479e-9df2-560c8293e934"),
                            Email = "otheruser@user.dk",
                            Username = "otheruser@user.dk"
                        },
                        new
                        {
                            id = new Guid("e8f2bce5-c55f-4965-89f3-71439ffffe3a"),
                            Email = "lastuser@user.dk",
                            Username = "lastuser@user.dk"
                        });
                });

            modelBuilder.Entity("Medium.ReplacingIfElse.Domain.User", b =>
                {
                    b.OwnsOne("Medium.ReplacingIfElse.Domain.Address", "Address", b1 =>
                        {
                            b1.Property<Guid>("Userid")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("StreetName")
                                .IsRequired()
                                .HasColumnType("nvarchar(150)")
                                .HasMaxLength(150);

                            b1.Property<string>("StreetNumber")
                                .IsRequired()
                                .HasColumnType("nvarchar(10)")
                                .HasMaxLength(10);

                            b1.HasKey("Userid");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("Userid");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
