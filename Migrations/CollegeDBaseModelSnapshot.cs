﻿// <auto-generated />
using EntityCoreFrameworkCodeFirstApproach.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityCoreFrameworkCodeFirstApproach.Migrations
{
    [DbContext(typeof(CollegeDBase))]
    partial class CollegeDBaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityCoreFrameworkCodeFirstApproach.ListColumn.StudentDepartment", b =>
                {
                    b.Property<int>("dId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("dId"));

                    b.Property<string>("dName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("dId");

                    b.ToTable("studentDepartment");
                });

            modelBuilder.Entity("EntityCoreFrameworkCodeFirstApproach.ListColumn.StudentDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("semester")
                        .HasColumnType("int");

                    b.Property<string>("studentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StudentsDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
