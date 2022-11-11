using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetBook.Infrastructure.Migrations
{
    public partial class PetsIsMaleAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMale",
                table: "Pets",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMale",
                table: "Pets");
        }
    }
}
