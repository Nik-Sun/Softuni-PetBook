using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetBook.Infrastructure.Migrations
{
    public partial class ChatAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_AspNetUsers_UserId",
                table: "Message");

            migrationBuilder.DropIndex(
                name: "IX_Message_UserId",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Message");

            migrationBuilder.AddColumn<Guid>(
                name: "ChatId",
                table: "Message",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Chat",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chat_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Message_ChatId",
                table: "Message",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_AuthorId",
                table: "Chat",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Chat_ChatId",
                table: "Message",
                column: "ChatId",
                principalTable: "Chat",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_Chat_ChatId",
                table: "Message");

            migrationBuilder.DropTable(
                name: "Chat");

            migrationBuilder.DropIndex(
                name: "IX_Message_ChatId",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "ChatId",
                table: "Message");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Message",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Message_UserId",
                table: "Message",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_AspNetUsers_UserId",
                table: "Message",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
