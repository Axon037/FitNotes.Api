using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitNotes.Api.Migrations
{
    /// <inheritdoc />
    public partial class ExerciseFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_User_UserId",
                table: "Exercises");

            migrationBuilder.DropIndex(
                name: "IX_Exercises_UserId",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Exercises");

            migrationBuilder.AddColumn<Guid>(
                name: "ExerciseId",
                table: "Sets",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ExercisesId",
                table: "Sets",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Sets_ExercisesId",
                table: "Sets",
                column: "ExercisesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sets_Exercises_ExercisesId",
                table: "Sets",
                column: "ExercisesId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sets_Exercises_ExercisesId",
                table: "Sets");

            migrationBuilder.DropIndex(
                name: "IX_Sets_ExercisesId",
                table: "Sets");

            migrationBuilder.DropColumn(
                name: "ExerciseId",
                table: "Sets");

            migrationBuilder.DropColumn(
                name: "ExercisesId",
                table: "Sets");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Exercises",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_UserId",
                table: "Exercises",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_User_UserId",
                table: "Exercises",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
