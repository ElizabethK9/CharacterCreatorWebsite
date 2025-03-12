using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterCreatorWebsite.Migrations
{
    /// <inheritdoc />
    public partial class RecreateCharacterCharts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccentOrDialect",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "AdoptiveParentsNames",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "AdoptiveSiblingsNames",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "AfternoonRoutine",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "AnimalFormColor",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "BedtimeRoutine",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "BestFriend",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "BiggestEmbarrassment",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "BirthParentsNames",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "BirthSiblingsNames",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "BodyType",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "BraveOrFearful",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "ChildhoodSummary",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "CloseFriends",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "ClothingPreferences",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "CommonGestures",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "CurrentAge",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "CurrentHairColor",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "DegreeOfReligiousPractice",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "DinnerRoutine",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "EarliestMemory",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "EducationLevel",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "EthnicBackground",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "EveningRoutine",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "EyeColor",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "EyelidShape",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "FaceShape",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "FavoriteBooks",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "FavoriteDrinks",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "FavoriteFoods",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "GeneralHealth",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "GeneralVocabulary",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "Gestures",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "GreatestWish",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "HabitualWordsOrPhrases",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "Hairstyle",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "HalfSiblingsNames",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "HappiestMemory",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "Hobbies",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "HomeDecor",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "Hometown",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "IncomeLevel",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "Jewelry",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "LongTermGoals",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "MagicPowers",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "MajorAccidentsOrTraumas",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "Mannerisms",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "MentalDisorders",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "MorningRoutine",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "NaturalHairColor",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "NaturalHairTexture",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "Nickname",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "Occupation",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "OptimistOrPessimist",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "PaceOfSpeech",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "PastJobs",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "PersonalHabits",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "PersonalityType",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "Pets",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "Philosophy",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "PoliceRecord",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "Prejudices",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "ProminentFeatures",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "ReactToAuthority",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "ReactToFamilyMembers",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "ReactToFriends",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "ReactToLovers",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "ReactToStrangers",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "ReactionToCrisis",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "RelationWithAdoptiveParents",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "RelationWithAdoptiveSiblings",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "RelationWithBirthParents",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "RelationWithBirthSiblings",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "RelationWithHalfSiblings",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "RelationWithStepParents",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "RelationWithStepSiblings",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "RelationshipStatus",
                table: "CharacterCharts");

            migrationBuilder.DropColumn(
                name: "Religion",
                table: "CharacterCharts");

            migrationBuilder.RenameColumn(
                name: "Weight",
                table: "CharacterCharts",
                newName: "Wand");

            migrationBuilder.RenameColumn(
                name: "Weapons",
                table: "CharacterCharts",
                newName: "Style");

            migrationBuilder.RenameColumn(
                name: "VoiceTone",
                table: "CharacterCharts",
                newName: "SpecialItems");

            migrationBuilder.RenameColumn(
                name: "Vehicle",
                table: "CharacterCharts",
                newName: "Siblings");

            migrationBuilder.RenameColumn(
                name: "UnskilledAt",
                table: "CharacterCharts",
                newName: "Patronus");

            migrationBuilder.RenameColumn(
                name: "UniqueAnimalFeatures",
                table: "CharacterCharts",
                newName: "Parents");

            migrationBuilder.RenameColumn(
                name: "TypicalPosture",
                table: "CharacterCharts",
                newName: "Nicknames");

            migrationBuilder.RenameColumn(
                name: "StepSiblingsNames",
                table: "CharacterCharts",
                newName: "Miscellaneous");

            migrationBuilder.RenameColumn(
                name: "StepParentsNames",
                table: "CharacterCharts",
                newName: "MagicalInheritance");

            migrationBuilder.RenameColumn(
                name: "SkinTone",
                table: "CharacterCharts",
                newName: "MagicLegacy");

            migrationBuilder.RenameColumn(
                name: "SkillsOrTalents",
                table: "CharacterCharts",
                newName: "MagicCore");

            migrationBuilder.RenameColumn(
                name: "SignificantChildhoodEvent",
                table: "CharacterCharts",
                newName: "MagicAbilities");

            migrationBuilder.RenameColumn(
                name: "ShortTermGoals",
                table: "CharacterCharts",
                newName: "LordLadyShips");

            migrationBuilder.RenameColumn(
                name: "ShifterAnimalForm",
                table: "CharacterCharts",
                newName: "ImportantFamily");

            migrationBuilder.RenameColumn(
                name: "Sexuality",
                table: "CharacterCharts",
                newName: "HogwartsHouse");

            migrationBuilder.RenameColumn(
                name: "SelfishOrSelfless",
                table: "CharacterCharts",
                newName: "DateOfBirth");

            migrationBuilder.RenameColumn(
                name: "SchoolsAttended",
                table: "CharacterCharts",
                newName: "CurrentResidence");

            migrationBuilder.RenameColumn(
                name: "SaddestMemory",
                table: "CharacterCharts",
                newName: "BloodStatus");

            migrationBuilder.RenameColumn(
                name: "RomanticRelationsSummary",
                table: "CharacterCharts",
                newName: "Appearance");

            migrationBuilder.RenameColumn(
                name: "Residence",
                table: "CharacterCharts",
                newName: "Alignment");

            migrationBuilder.RenameColumn(
                name: "NumberOfLanguages",
                table: "CharacterCharts",
                newName: "Age");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Wand",
                table: "CharacterCharts",
                newName: "Weight");

            migrationBuilder.RenameColumn(
                name: "Style",
                table: "CharacterCharts",
                newName: "Weapons");

            migrationBuilder.RenameColumn(
                name: "SpecialItems",
                table: "CharacterCharts",
                newName: "VoiceTone");

            migrationBuilder.RenameColumn(
                name: "Siblings",
                table: "CharacterCharts",
                newName: "Vehicle");

            migrationBuilder.RenameColumn(
                name: "Patronus",
                table: "CharacterCharts",
                newName: "UnskilledAt");

            migrationBuilder.RenameColumn(
                name: "Parents",
                table: "CharacterCharts",
                newName: "UniqueAnimalFeatures");

            migrationBuilder.RenameColumn(
                name: "Nicknames",
                table: "CharacterCharts",
                newName: "TypicalPosture");

            migrationBuilder.RenameColumn(
                name: "Miscellaneous",
                table: "CharacterCharts",
                newName: "StepSiblingsNames");

            migrationBuilder.RenameColumn(
                name: "MagicalInheritance",
                table: "CharacterCharts",
                newName: "StepParentsNames");

            migrationBuilder.RenameColumn(
                name: "MagicLegacy",
                table: "CharacterCharts",
                newName: "SkinTone");

            migrationBuilder.RenameColumn(
                name: "MagicCore",
                table: "CharacterCharts",
                newName: "SkillsOrTalents");

            migrationBuilder.RenameColumn(
                name: "MagicAbilities",
                table: "CharacterCharts",
                newName: "SignificantChildhoodEvent");

            migrationBuilder.RenameColumn(
                name: "LordLadyShips",
                table: "CharacterCharts",
                newName: "ShortTermGoals");

            migrationBuilder.RenameColumn(
                name: "ImportantFamily",
                table: "CharacterCharts",
                newName: "ShifterAnimalForm");

            migrationBuilder.RenameColumn(
                name: "HogwartsHouse",
                table: "CharacterCharts",
                newName: "Sexuality");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "CharacterCharts",
                newName: "SelfishOrSelfless");

            migrationBuilder.RenameColumn(
                name: "CurrentResidence",
                table: "CharacterCharts",
                newName: "SchoolsAttended");

            migrationBuilder.RenameColumn(
                name: "BloodStatus",
                table: "CharacterCharts",
                newName: "SaddestMemory");

            migrationBuilder.RenameColumn(
                name: "Appearance",
                table: "CharacterCharts",
                newName: "RomanticRelationsSummary");

            migrationBuilder.RenameColumn(
                name: "Alignment",
                table: "CharacterCharts",
                newName: "Residence");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "CharacterCharts",
                newName: "NumberOfLanguages");

            migrationBuilder.AddColumn<string>(
                name: "AccentOrDialect",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AdoptiveParentsNames",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AdoptiveSiblingsNames",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AfternoonRoutine",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AnimalFormColor",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BedtimeRoutine",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BestFriend",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BiggestEmbarrassment",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "CharacterCharts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BirthParentsNames",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BirthSiblingsNames",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BodyType",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BraveOrFearful",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ChildhoodSummary",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CloseFriends",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ClothingPreferences",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CommonGestures",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CurrentAge",
                table: "CharacterCharts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrentHairColor",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DegreeOfReligiousPractice",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DinnerRoutine",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EarliestMemory",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EducationLevel",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EthnicBackground",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EveningRoutine",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EyeColor",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EyelidShape",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FaceShape",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FavoriteBooks",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FavoriteDrinks",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FavoriteFoods",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GeneralHealth",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GeneralVocabulary",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gestures",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GreatestWish",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HabitualWordsOrPhrases",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Hairstyle",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HalfSiblingsNames",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HappiestMemory",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Height",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Hobbies",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HomeDecor",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Hometown",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IncomeLevel",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Jewelry",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LongTermGoals",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MagicPowers",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MajorAccidentsOrTraumas",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Mannerisms",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MentalDisorders",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MorningRoutine",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NaturalHairColor",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NaturalHairTexture",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nickname",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Occupation",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OptimistOrPessimist",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PaceOfSpeech",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PastJobs",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PersonalHabits",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PersonalityType",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Pets",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Philosophy",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PoliceRecord",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Prejudices",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProminentFeatures",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ReactToAuthority",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ReactToFamilyMembers",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ReactToFriends",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ReactToLovers",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ReactToStrangers",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ReactionToCrisis",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RelationWithAdoptiveParents",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RelationWithAdoptiveSiblings",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RelationWithBirthParents",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RelationWithBirthSiblings",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RelationWithHalfSiblings",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RelationWithStepParents",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RelationWithStepSiblings",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RelationshipStatus",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Religion",
                table: "CharacterCharts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
