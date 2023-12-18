﻿// <auto-generated />
using EventCMS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ProductStore.Migrations
{
    [DbContext(typeof(EventDbContext))]
    partial class EventDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("EventCMS.Models.Event", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("SubDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Description = "This is a sample event.",
                            ImageUrl = "https://example.com/sample-image.jpg",
                            Name = "Sample Event",
                            Price = 50.0m,
                            SubDescription = "You can put whatever information here."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}