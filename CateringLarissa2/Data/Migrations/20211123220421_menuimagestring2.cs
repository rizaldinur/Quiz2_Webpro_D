using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CateringLarissa2.Data.Migrations
{
    public partial class menuimagestring2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MenuImage",
                table: "Menu",
                newName: "menuimage");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "menuimage",
                table: "Menu",
                newName: "MenuImage");
        }
    }
}
