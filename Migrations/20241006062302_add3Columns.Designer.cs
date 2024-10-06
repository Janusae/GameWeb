﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyTestProject.ClassesEntity;

#nullable disable

namespace MyTestProject.Migrations
{
    [DbContext(typeof(MyIndexInformation))]
    [Migration("20241006062302_add3Columns")]
    partial class add3Columns
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyTestProject.ClassesEntity.IndexPagesInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Context1_h6")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Context1_p")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Context_Header")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CopyriteText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DesignText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HasOffer")
                        .HasColumnType("bit");

                    b.Property<int>("Offer")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("TopImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IndexInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
