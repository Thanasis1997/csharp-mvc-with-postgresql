﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using exercise.api.DataContext;

#nullable disable

namespace exercise.api.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20230607075635_secondModel")]
    partial class secondModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("exercise.api.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("department")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("jobName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("salaryGrade")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("salaryId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("exercise.api.Models.Salary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("grade")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("maxSalary")
                        .HasColumnType("integer");

                    b.Property<int>("minSalary")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Salary");
                });
#pragma warning restore 612, 618
        }
    }
}