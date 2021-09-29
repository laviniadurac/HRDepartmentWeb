using Microsoft.EntityFrameworkCore.Migrations;

namespace HRDepartment.Migrations
{
    public partial class SeededExperiencesAndTechnologiesFirst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ExperiencesAndTechnologies",
                columns: new[] { "Id", "ExperienceId", "JobId", "TechnologiesId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 15, 15, 4, 9 },
                    { 14, 14, 3, 7 },
                    { 13, 13, 3, 6 },
                    { 12, 12, 3, 4 },
                    { 11, 11, 3, 3 },
                    { 10, 10, 3, 1 },
                    { 16, 16, 4, 10 },
                    { 9, 9, 2, 7 },
                    { 7, 7, 2, 8 },
                    { 6, 6, 2, 1 },
                    { 5, 5, 1, 4 },
                    { 4, 4, 1, 5 },
                    { 3, 3, 1, 9 },
                    { 2, 2, 1, 2 },
                    { 8, 8, 2, 3 },
                    { 17, 17, 4, 11 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExperiencesAndTechnologies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExperiencesAndTechnologies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ExperiencesAndTechnologies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ExperiencesAndTechnologies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ExperiencesAndTechnologies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ExperiencesAndTechnologies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ExperiencesAndTechnologies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ExperiencesAndTechnologies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ExperiencesAndTechnologies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ExperiencesAndTechnologies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ExperiencesAndTechnologies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ExperiencesAndTechnologies",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ExperiencesAndTechnologies",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ExperiencesAndTechnologies",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ExperiencesAndTechnologies",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ExperiencesAndTechnologies",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ExperiencesAndTechnologies",
                keyColumn: "Id",
                keyValue: 17);
        }
    }
}
