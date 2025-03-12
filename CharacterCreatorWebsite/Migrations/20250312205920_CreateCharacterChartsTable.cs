using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterCreatorWebsite.Migrations
{
    /// <inheritdoc />
    public partial class CreateCharacterChartsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CharacterCharts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nickname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CurrentAge = table.Column<int>(type: "int", nullable: true),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EthnicBackground = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Religion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DegreeOfReligiousPractice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Residence = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeDecor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pets = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IncomeLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vehicle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sexuality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelationshipStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Species = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BodyType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EyeColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EyelidShape = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkinTone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProminentFeatures = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaceShape = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeneralHealth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClothingPreferences = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Jewelry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hairstyle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NaturalHairTexture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NaturalHairColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentHairColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShifterAnimalForm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnimalFormColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UniqueAnimalFeatures = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaceOfSpeech = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccentOrDialect = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfLanguages = table.Column<int>(type: "int", nullable: false),
                    VoiceTone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HabitualWordsOrPhrases = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeneralVocabulary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mannerisms = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypicalPosture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gestures = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommonGestures = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonalHabits = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MorningRoutine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AfternoonRoutine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DinnerRoutine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EveningRoutine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BedtimeRoutine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillsOrTalents = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hobbies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnskilledAt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hometown = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChildhoodSummary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EarliestMemory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SaddestMemory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HappiestMemory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchoolsAttended = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SignificantChildhoodEvent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PastJobs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PoliceRecord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RomanticRelationsSummary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MajorAccidentsOrTraumas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthParentsNames = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdoptiveParentsNames = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StepParentsNames = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelationWithBirthParents = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelationWithAdoptiveParents = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelationWithStepParents = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthSiblingsNames = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HalfSiblingsNames = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdoptiveSiblingsNames = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StepSiblingsNames = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelationWithBirthSiblings = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelationWithHalfSiblings = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelationWithAdoptiveSiblings = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelationWithStepSiblings = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BestFriend = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CloseFriends = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReactToFriends = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReactToStrangers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReactToLovers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReactToFamilyMembers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReactToAuthority = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MentalDisorders = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OptimistOrPessimist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonalityType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BraveOrFearful = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SelfishOrSelfless = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GreatestWish = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Philosophy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BiggestEmbarrassment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prejudices = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReactionToCrisis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortTermGoals = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LongTermGoals = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FavoriteFoods = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FavoriteDrinks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FavoriteBooks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MagicPowers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weapons = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterCharts", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterCharts");
        }
    }
}
