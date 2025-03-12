﻿// <auto-generated />
using System;
using CharacterCreatorWebsite.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CharacterCreatorWebsite.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250312225032_UpdateCharacterChartSchema")]
    partial class UpdateCharacterChartSchema
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CharacterCreatorWebsite.Models.CharacterChartClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Alignment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Appearance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BloodStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentResidence")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateOfBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HogwartsHouse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImportantFamily")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LordLadyShips")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MagicAbilities")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MagicCore")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MagicLegacy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MagicalInheritance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Miscellaneous")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nicknames")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parents")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patronus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceOfBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Siblings")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecialItems")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Style")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CharacterCharts");
                });

            modelBuilder.Entity("CharacterCreatorWebsite.Models.CharacterClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfileClassId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfileClassId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("CharacterCreatorWebsite.Models.ProfileClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConfirmationToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsEmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("CharacterCreatorWebsite.Models.CharacterClass", b =>
                {
                    b.HasOne("CharacterCreatorWebsite.Models.ProfileClass", "Profile")
                        .WithMany("Characters")
                        .HasForeignKey("ProfileClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("CharacterCreatorWebsite.Models.ProfileClass", b =>
                {
                    b.Navigation("Characters");
                });
#pragma warning restore 612, 618
        }
    }
}
