using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CateringLarissa2.Data.Migrations
{
    public partial class menuimagestring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MenuImage",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MenuImage",
                table: "Menu");
        }
    }
}
