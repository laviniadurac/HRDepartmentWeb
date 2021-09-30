using Microsoft.EntityFrameworkCore.Migrations;

namespace HRDepartment.Migrations
{
    public partial class SeededExperiences : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "ExperienceId", "YearsOfExperience" },
                values: new object[,]
                {
                    { 1, "0-2 years" },
                    { 2, "2-5 years" },
                    { 3, "5-8 years" },
                    { 4, "8+ years" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "ExperienceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "ExperienceId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "ExperienceId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "ExperienceId",
                keyValue: 4);
        }
    }
}
