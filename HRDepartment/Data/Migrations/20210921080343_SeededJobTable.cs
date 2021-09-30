using Microsoft.EntityFrameworkCore.Migrations;

namespace HRDepartment.Migrations
{
    public partial class SeededJobTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "JobId", "IsAvailable", "JobName" },
                values: new object[,]
                {
                    { 1, true, "Programmer" },
                    { 2, true, "Tester" },
                    { 3, true, "Web Developer" },
                    { 4, true, "Data Scientist" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "JobId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "JobId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "JobId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "JobId",
                keyValue: 4);
        }
    }
}
