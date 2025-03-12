using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterCreatorWebsite.Migrations
{
    /// <inheritdoc />
    public partial class AddCharacterClassWithRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Income",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Residence",
                table: "Characters");

            migrationBuilder.RenameColumn(
                name: "Species",
                table: "Characters",
                newName: "Description");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Characters",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<int>(
                name: "ProfileClassId",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Characters_ProfileClassId",
                table: "Characters",
                column: "ProfileClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Profiles_ProfileClassId",
                table: "Characters",
                column: "ProfileClassId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Profiles_ProfileClassId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_ProfileClassId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "ProfileClassId",
                table: "Characters");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Characters",
                newName: "Species");

            migrationBuilder.AddColumn<decimal>(
                name: "Income",
                table: "Characters",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Residence",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
