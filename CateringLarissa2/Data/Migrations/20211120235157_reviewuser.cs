using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CateringLarissa2.Data.Migrations
{
    public partial class reviewuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "user",
                table: "Review",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "user",
                table: "Review");
        }
    }
}
