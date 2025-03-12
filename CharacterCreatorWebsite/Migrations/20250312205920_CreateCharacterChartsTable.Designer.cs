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
    [Migration("20250312205920_CreateCharacterChartsTable")]
    partial class CreateCharacterChartsTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CharacterCreatorWebsite.CharacterChartClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccentOrDialect")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdoptiveParentsNames")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("AdoptiveSiblingsNames")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AfternoonRoutine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnimalFormColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BedtimeRoutine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BestFriend")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BiggestEmbarrassment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BirthParentsNames")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("BirthSiblingsNames")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BodyType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BraveOrFearful")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChildhoodSummary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("CloseFriends")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClothingPreferences")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommonGestures")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CurrentAge")
                        .HasColumnType("int");

                    b.Property<string>("CurrentHairColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DegreeOfReligiousPractice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DinnerRoutine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EarliestMemory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EducationLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EthnicBackground")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EveningRoutine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EyeColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EyelidShape")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FaceShape")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("FavoriteBooks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("FavoriteDrinks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("FavoriteFoods")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GeneralHealth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GeneralVocabulary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gestures")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GreatestWish")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HabitualWordsOrPhrases")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hairstyle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("HalfSiblingsNames")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HappiestMemory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Height")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("Hobbies")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeDecor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hometown")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IncomeLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Jewelry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LongTermGoals")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MagicPowers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MajorAccidentsOrTraumas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mannerisms")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MentalDisorders")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MorningRoutine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NaturalHairColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NaturalHairTexture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfLanguages")
                        .HasColumnType("int");

                    b.Property<string>("Occupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptimistOrPessimist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaceOfSpeech")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("PastJobs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalHabits")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalityType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pets")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Philosophy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceOfBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PoliceRecord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("Prejudices")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProminentFeatures")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReactToAuthority")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReactToFamilyMembers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReactToFriends")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReactToLovers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReactToStrangers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReactionToCrisis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RelationWithAdoptiveParents")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RelationWithAdoptiveSiblings")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RelationWithBirthParents")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RelationWithBirthSiblings")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RelationWithHalfSiblings")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RelationWithStepParents")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RelationWithStepSiblings")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RelationshipStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Religion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Residence")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RomanticRelationsSummary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SaddestMemory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("SchoolsAttended")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SelfishOrSelfless")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexuality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShifterAnimalForm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortTermGoals")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SignificantChildhoodEvent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("SkillsOrTalents")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkinTone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StepParentsNames")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("StepSiblingsNames")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypicalPosture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UniqueAnimalFeatures")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("UnskilledAt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vehicle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VoiceTone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Weapons")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Weight")
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
