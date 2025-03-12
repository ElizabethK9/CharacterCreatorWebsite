using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CharacterCreatorWebsite.Migrations
{
    /// <inheritdoc />
    public partial class AddCharacterChartTemplates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CharacterCharts",
                columns: new[] { "Id", "Age", "Alignment", "Appearance", "BloodStatus", "CurrentResidence", "DateOfBirth", "FullName", "Gender", "HogwartsHouse", "ImportantFamily", "LordLadyShips", "MagicAbilities", "MagicCore", "MagicLegacy", "MagicalInheritance", "Miscellaneous", "Nicknames", "Parents", "Patronus", "PlaceOfBirth", "Siblings", "SpecialItems", "Species", "Style", "Wand" },
                values: new object[,]
                {
                    { 1, 0, "Neutral", "Unknown", "Unknown", "Unknown", "Unknown", "Template Character 1", "Unknown", "Unknown", "None", "None", "None", "Unknown", "None", "None", "None", "Nickname 1", "None", "Unknown", "Unknown", "None", "None", "Unknown", "Unknown", "Unknown" },
                    { 2, 0, "Neutral", "Unknown", "Unknown", "Unknown", "Unknown", "Template Character 2", "Unknown", "Unknown", "None", "None", "None", "Unknown", "None", "None", "None", "Nickname 2", "None", "Unknown", "Unknown", "None", "None", "Unknown", "Unknown", "Unknown" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CharacterCharts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CharacterCharts",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
