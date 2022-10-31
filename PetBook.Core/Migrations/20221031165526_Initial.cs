using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetBook.Core.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Breeds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Breeds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressText = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    ImageId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Height = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    BreedId = table.Column<int>(type: "int", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pets_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pets_Breeds_BreedId",
                        column: x => x.BreedId,
                        principalTable: "Breeds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PetId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Image_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Breeds",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Affenpinscher" },
                    { 2, "Afghan Hound" },
                    { 3, "African Hunting Dog" },
                    { 4, "Airedale Terrier" },
                    { 5, "Akbash Dog" },
                    { 6, "Akita" },
                    { 7, "Alapaha Blue Blood Bulldog" },
                    { 8, "Alaskan Husky" },
                    { 9, "Alaskan Malamute" },
                    { 10, "American Bulldog" },
                    { 11, "American Bully" },
                    { 12, "American Eskimo Dog" },
                    { 13, "American Eskimo Dog (Miniature)" },
                    { 14, "American Foxhound" },
                    { 15, "American Pit Bull Terrier" },
                    { 16, "American Staffordshire Terrier" },
                    { 17, "American Water Spaniel" },
                    { 18, "Anatolian Shepherd Dog" },
                    { 19, "Appenzeller Sennenhund" },
                    { 21, "Australian Cattle Dog" },
                    { 22, "Australian Kelpie" },
                    { 23, "Australian Shepherd" },
                    { 24, "Australian Terrier" },
                    { 25, "Azawakh" },
                    { 26, "Barbet" },
                    { 28, "Basenji" },
                    { 29, "Basset Bleu de Gascogne" },
                    { 30, "Basset Hound" },
                    { 31, "Beagle" },
                    { 32, "Bearded Collie" },
                    { 33, "Beauceron" },
                    { 34, "Bedlington Terrier" },
                    { 36, "Belgian Malinois" },
                    { 38, "Belgian Tervuren" },
                    { 41, "Bernese Mountain Dog" },
                    { 42, "Bichon Frise" },
                    { 43, "Black and Tan Coonhound" },
                    { 45, "Bloodhound" },
                    { 47, "Bluetick Coonhound" },
                    { 48, "Boerboel" },
                    { 50, "Border Collie" },
                    { 51, "Border Terrier" }
                });

            migrationBuilder.InsertData(
                table: "Breeds",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 53, "Boston Terrier" },
                    { 54, "Bouvier des Flandres" },
                    { 55, "Boxer" },
                    { 56, "Boykin Spaniel" },
                    { 57, "Bracco Italiano" },
                    { 58, "Briard" },
                    { 59, "Brittany" },
                    { 61, "Bull Terrier" },
                    { 62, "Bull Terrier (Miniature)" },
                    { 64, "Bullmastiff" },
                    { 65, "Cairn Terrier" },
                    { 67, "Cane Corso" },
                    { 68, "Cardigan Welsh Corgi" },
                    { 69, "Catahoula Leopard Dog" },
                    { 70, "Caucasian Shepherd (Ovcharka)" },
                    { 71, "Cavalier King Charles Spaniel" },
                    { 76, "Chesapeake Bay Retriever" },
                    { 78, "Chinese Crested" },
                    { 79, "Chinese Shar-Pei" },
                    { 80, "Chinook" },
                    { 81, "Chow Chow" },
                    { 84, "Clumber Spaniel" },
                    { 86, "Cocker Spaniel" },
                    { 87, "Cocker Spaniel (American)" },
                    { 89, "Coton de Tulear" },
                    { 92, "Dalmatian" },
                    { 94, "Doberman Pinscher" },
                    { 95, "Dogo Argentino" },
                    { 98, "Dutch Shepherd" },
                    { 101, "English Setter" },
                    { 102, "English Shepherd" },
                    { 103, "English Springer Spaniel" },
                    { 104, "English Toy Spaniel" },
                    { 105, "English Toy Terrier" },
                    { 107, "Eurasier" },
                    { 108, "Field Spaniel" },
                    { 110, "Finnish Lapphund" },
                    { 111, "Finnish Spitz" },
                    { 113, "French Bulldog" },
                    { 114, "German Pinscher" },
                    { 115, "German Shepherd Dog" },
                    { 116, "German Shorthaired Pointer" }
                });

            migrationBuilder.InsertData(
                table: "Breeds",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 119, "Giant Schnauzer" },
                    { 120, "Glen of Imaal Terrier" },
                    { 121, "Golden Retriever" },
                    { 123, "Gordon Setter" },
                    { 124, "Great Dane" },
                    { 125, "Great Pyrenees" },
                    { 127, "Greyhound" },
                    { 128, "Griffon Bruxellois" },
                    { 129, "Harrier" },
                    { 130, "Havanese" },
                    { 134, "Irish Setter" },
                    { 135, "Irish Terrier" },
                    { 137, "Irish Wolfhound" },
                    { 138, "Italian Greyhound" },
                    { 140, "Japanese Chin" },
                    { 141, "Japanese Spitz" },
                    { 142, "Keeshond" },
                    { 144, "Komondor" },
                    { 145, "Kooikerhondje" },
                    { 147, "Kuvasz" },
                    { 149, "Labrador Retriever" },
                    { 151, "Lagotto Romagnolo" },
                    { 153, "Lancashire Heeler" },
                    { 155, "Leonberger" },
                    { 156, "Lhasa Apso" },
                    { 161, "Maltese" },
                    { 165, "Miniature American Shepherd" },
                    { 167, "Miniature Pinscher" },
                    { 168, "Miniature Schnauzer" },
                    { 171, "Newfoundland" },
                    { 172, "Norfolk Terrier" },
                    { 176, "Norwich Terrier" },
                    { 177, "Nova Scotia Duck Tolling Retriever" },
                    { 178, "Old English Sheepdog" },
                    { 179, "Olde English Bulldogge" },
                    { 181, "Papillon" },
                    { 183, "Pekingese" },
                    { 184, "Pembroke Welsh Corgi" },
                    { 185, "Perro de Presa Canario" },
                    { 188, "Pharaoh Hound" },
                    { 189, "Plott" },
                    { 193, "Pomeranian" }
                });

            migrationBuilder.InsertData(
                table: "Breeds",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 196, "Poodle (Miniature)" },
                    { 197, "Poodle (Toy)" },
                    { 201, "Pug" },
                    { 204, "Puli" },
                    { 205, "Pumi" },
                    { 207, "Rat Terrier" },
                    { 208, "Redbone Coonhound" },
                    { 209, "Rhodesian Ridgeback" },
                    { 210, "Rottweiler" },
                    { 211, "Russian Toy" },
                    { 212, "Saint Bernard" },
                    { 213, "Saluki" },
                    { 214, "Samoyed" },
                    { 216, "Schipperke" },
                    { 218, "Scottish Deerhound" },
                    { 219, "Scottish Terrier" },
                    { 221, "Shetland Sheepdog" },
                    { 222, "Shiba Inu" },
                    { 223, "Shih Tzu" },
                    { 225, "Shiloh Shepherd" },
                    { 226, "Siberian Husky" },
                    { 228, "Silky Terrier" },
                    { 232, "Smooth Fox Terrier" },
                    { 233, "Soft Coated Wheaten Terrier" },
                    { 235, "Spanish Water Dog" },
                    { 236, "Spinone Italiano" },
                    { 238, "Staffordshire Bull Terrier" },
                    { 239, "Standard Schnauzer" },
                    { 242, "Swedish Vallhund" },
                    { 243, "Thai Ridgeback" },
                    { 244, "Tibetan Mastiff" },
                    { 245, "Tibetan Spaniel" },
                    { 246, "Tibetan Terrier" },
                    { 248, "Toy Fox Terrier" },
                    { 250, "Treeing Walker Coonhound" },
                    { 251, "Vizsla" },
                    { 253, "Weimaraner" },
                    { 254, "Welsh Springer Spaniel" },
                    { 256, "West Highland White Terrier" },
                    { 257, "Whippet" },
                    { 258, "White Shepherd" },
                    { 259, "Wire Fox Terrier" }
                });

            migrationBuilder.InsertData(
                table: "Breeds",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 260, "Wirehaired Pointing Griffon" },
                    { 261, "Wirehaired Vizsla" },
                    { 262, "Xoloitzcuintli" },
                    { 264, "Yorkshire Terrier" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CityId",
                table: "Addresses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AddressId",
                table: "AspNetUsers",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ImageId",
                table: "AspNetUsers",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Image_PetId",
                table: "Image",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_BreedId",
                table: "Pets",
                column: "BreedId");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_OwnerId",
                table: "Pets",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Image_ImageId",
                table: "AspNetUsers",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Cities_CityId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Pets_AspNetUsers_OwnerId",
                table: "Pets");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "Breeds");
        }
    }
}
