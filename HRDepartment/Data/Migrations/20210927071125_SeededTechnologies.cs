
using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRDepartment.Migrations
{
    public partial class SeededTechnologies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Technologies",
                columns: new[] { "TechnologiesId", "TechnologyName" },
                values: new object[,]
                {
                    { 1, "C#" },
                    { 2, "Java" },
                    { 3, "JavaScript" },
                    { 4, "ASP.Net Core" },
                    { 5, "WPF" },
                    { 6, "Angular" },
                    { 7, "SQL" },
                    { 8, "Automation" },
                    { 9, "C++" },
                    { 10, "Artificial Intelligence" },
                    { 11, "Statistics" }
                });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "TechnologiesId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "TechnologiesId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "TechnologiesId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "TechnologiesId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "TechnologiesId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "TechnologiesId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "TechnologiesId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "TechnologiesId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "TechnologiesId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "TechnologiesId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "TechnologiesId",
                keyValue: 11);
        }
    }
}
