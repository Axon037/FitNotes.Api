using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitNotes.Api.Migrations
{
    /// <inheritdoc />
    public partial class FKUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsMetric",
                table: "Exercises",
                newName: "IsTime");

            migrationBuilder.AddColumn<Guid>(
                name: "UsersId",
                table: "Sets",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UsersId",
                table: "Exercises",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Sets_UsersId",
                table: "Sets",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_UsersId",
                table: "Exercises",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_User_UsersId",
                table: "Exercises",
                column: "UsersId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sets_User_UsersId",
                table: "Sets",
                column: "UsersId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_User_UsersId",
                table: "Exercises");

            migrationBuilder.DropForeignKey(
                name: "FK_Sets_User_UsersId",
                table: "Sets");

            migrationBuilder.DropIndex(
                name: "IX_Sets_UsersId",
                table: "Sets");

            migrationBuilder.DropIndex(
                name: "IX_Exercises_UsersId",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Sets");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Exercises");

            migrationBuilder.RenameColumn(
                name: "IsTime",
                table: "Exercises",
                newName: "IsMetric");
        }
    }
}
