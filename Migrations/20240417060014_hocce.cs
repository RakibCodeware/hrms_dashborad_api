using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hrms_api.Migrations
{
    /// <inheritdoc />
    public partial class hocce : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AbsentHisb",
                table: "Attendance",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AbsentHisb",
                table: "Attendance");
        }
    }
}
