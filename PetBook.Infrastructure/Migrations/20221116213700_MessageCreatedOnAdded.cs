using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetBook.Infrastructure.Migrations
{
    public partial class MessageCreatedOnAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Message",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "SenderId",
                table: "Message",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "SenderId",
                table: "Message");
        }
    }
}
