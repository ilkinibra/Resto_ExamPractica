using Microsoft.EntityFrameworkCore.Migrations;

namespace Resto_Backend.Migrations
{
    public partial class add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "pageIntros");

            migrationBuilder.DropColumn(
                name: "IconTitle",
                table: "pageIntros");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "pageIntros");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "pageIntros",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IconTitle",
                table: "pageIntros",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "pageIntros",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
