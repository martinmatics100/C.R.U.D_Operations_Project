using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_CRUD_Operations.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatedStudentModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentName",
                table: "students",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "StudentCourse",
                table: "students",
                newName: "Department");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "students",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsGraduated",
                table: "students",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "students");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "students");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "students");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "students");

            migrationBuilder.DropColumn(
                name: "IsGraduated",
                table: "students");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "students",
                newName: "StudentName");

            migrationBuilder.RenameColumn(
                name: "Department",
                table: "students",
                newName: "StudentCourse");
        }
    }
}
