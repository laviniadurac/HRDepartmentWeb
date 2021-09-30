using Microsoft.EntityFrameworkCore.Migrations;

namespace HRDepartment.Migrations
{
    public partial class UpdateEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FutureEmployeeEmployeeId",
                table: "Technologies",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "FutureEmployees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Experience",
                table: "FutureEmployees",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.InsertData(
                table: "Technologies",
                columns: new[] { "TechnologiesId", "FutureEmployeeEmployeeId", "TechnologyName" },
                values: new object[,]
                {
                    { 1, null, "C#" },
                    { 2, null, "Java" },
                    { 3, null, "JavaScript" },
                    { 4, null, "ASP.Net Core" },
                    { 5, null, "WPF" },
                    { 6, null, "Angular" },
                    { 7, null, "SQL" },
                    { 8, null, "Automation" },
                    { 9, null, "C++" },
                    { 10, null, "Artificial Intelligence" },
                    { 11, null, "Statistics" }
                });

            migrationBuilder.InsertData(
                table: "ExperiencesAndTechnologies",
                columns: new[] { "Id", "ExperienceId", "JobId", "TechnologiesId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 15, 15, 4, 9 },
                    { 3, 3, 1, 9 },
                    { 7, 7, 2, 8 },
                    { 14, 14, 3, 7 },
                    { 9, 9, 2, 7 },
                    { 13, 13, 3, 6 },
                    { 16, 16, 4, 10 },
                    { 4, 4, 1, 5 },
                    { 5, 5, 1, 4 },
                    { 11, 11, 3, 3 },
                    { 8, 8, 2, 3 },
                    { 2, 2, 1, 2 },
                    { 10, 10, 3, 1 },
                    { 6, 6, 2, 1 },
                    { 12, 12, 3, 4 },
                    { 17, 17, 4, 11 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Technologies_FutureEmployeeEmployeeId",
                table: "Technologies",
                column: "FutureEmployeeEmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Technologies_FutureEmployees_FutureEmployeeEmployeeId",
                table: "Technologies",
                column: "FutureEmployeeEmployeeId",
                principalTable: "FutureEmployees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Technologies_FutureEmployees_FutureEmployeeEmployeeId",
                table: "Technologies");

            migrationBuilder.DropIndex(
                name: "IX_Technologies_FutureEmployeeEmployeeId",
                table: "Technologies");

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

            migrationBuilder.DropColumn(
                name: "FutureEmployeeEmployeeId",
                table: "Technologies");

            migrationBuilder.DropColumn(
                name: "Experience",
                table: "FutureEmployees");

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "FutureEmployees",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
