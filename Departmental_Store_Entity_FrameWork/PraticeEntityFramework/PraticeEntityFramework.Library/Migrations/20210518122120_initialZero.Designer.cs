﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PraticeEntityFramework.Library.Infrastructure;

namespace PraticeEntityFramework.Library.Migrations
{
    [DbContext(typeof(DepartmentalStoreContext))]
    [Migration("20210518122120_initialZero")]
    partial class initialZero
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("PraticeEntityFramework.Library.Entites.Address", b =>
                {
                    b.Property<long>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AddressLine1")
                        .HasColumnType("text");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("Pincode")
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.HasKey("AddressId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("PraticeEntityFramework.Library.Entites.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Role_Name")
                        .HasColumnType("text");

                    b.HasKey("RoleID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("PraticeEntityFramework.Library.Entites.Staff", b =>
                {
                    b.Property<long>("StaffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("AddressId")
                        .HasColumnType("bigint");

                    b.Property<string>("First_Name")
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.Property<string>("Last_Name")
                        .HasColumnType("text");

                    b.Property<string>("Phone_Number")
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<long>("Salary")
                        .HasColumnType("bigint");

                    b.HasKey("StaffId");

                    b.HasIndex("AddressId");

                    b.HasIndex("RoleId");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("PraticeEntityFramework.Library.Entites.Staff", b =>
                {
                    b.HasOne("PraticeEntityFramework.Library.Entites.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PraticeEntityFramework.Library.Entites.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}