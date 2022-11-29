using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetBook.Infrastructure.Migrations
{
    public partial class GroupsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActiveConnection");

            migrationBuilder.AddColumn<int>(
                name: "AuthorOfGroupId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MemberInGroupId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SignalRGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondMemberId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignalRGroup", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AuthorOfGroupId",
                table: "AspNetUsers",
                column: "AuthorOfGroupId",
                unique: true,
                filter: "[AuthorOfGroupId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_MemberInGroupId",
                table: "AspNetUsers",
                column: "MemberInGroupId",
                unique: true,
                filter: "[MemberInGroupId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_SignalRGroup_AuthorOfGroupId",
                table: "AspNetUsers",
                column: "AuthorOfGroupId",
                principalTable: "SignalRGroup",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_SignalRGroup_MemberInGroupId",
                table: "AspNetUsers",
                column: "MemberInGroupId",
                principalTable: "SignalRGroup",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_SignalRGroup_AuthorOfGroupId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_SignalRGroup_MemberInGroupId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "SignalRGroup");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AuthorOfGroupId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_MemberInGroupId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AuthorOfGroupId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MemberInGroupId",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "ActiveConnection",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConnectionId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActiveConnection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActiveConnection_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActiveConnection_UserId",
                table: "ActiveConnection",
                column: "UserId");
        }
    }
}
