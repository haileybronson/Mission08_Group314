﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission08_Group314.Models;

#nullable disable

namespace Mission08_Group314.Migrations
{
    [DbContext(typeof(ToDoFormContext))]
    partial class ToDoFormContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("Mission08_Group314.Models.ToDo", b =>
                {
                    b.Property<string>("Task")
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Completed")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DueDate")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quadrant")
                        .HasColumnType("INTEGER");

                    b.HasKey("Task");

                    b.ToTable("ToDo");
                });
#pragma warning restore 612, 618
        }
    }
}
