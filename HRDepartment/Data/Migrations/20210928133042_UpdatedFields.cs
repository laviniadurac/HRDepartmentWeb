using Microsoft.EntityFrameworkCore.Migrations;

namespace HRDepartment.Migrations
{
    public partial class UpdatedFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Technologies",
                table: "FutureEmployees");

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

            migrationBuilder.AlterColumn<string>(
                name: "Experience",
                table: "FutureEmployees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.DropColumn(
                name: "FutureEmployeeEmployeeId",
                table: "Technologies");

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "FutureEmployees",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Experience",
                table: "FutureEmployees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Technologies",
                table: "FutureEmployees",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
