using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetBook.Infrastructure.Migrations
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

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Sofia" },
                    { 2, "Varna" },
                    { 3, "Plovdiv" },
                    { 4, "Burgas" },
                    { 5, "Ruse" },
                    { 6, "Stara Zagora" },
                    { 7, "Pleven" },
                    { 8, "Sliven" },
                    { 9, "Dobrich" },
                    { 10, "Shumen" },
                    { 11, "Haskovo" },
                    { 12, "Pazardzhik" },
                    { 13, "Yambol" },
                    { 14, "Pernik" },
                    { 15, "Blagoevgrad" },
                    { 16, "Veliko Tarnovo" },
                    { 17, "Vratsa" },
                    { 18, "Kardzhali" },
                    { 19, "Kyustendil" },
                    { 20, "Gabrovo" },
                    { 21, "Asenovgrad" },
                    { 22, "Vidin" },
                    { 23, "Kazanlak" },
                    { 24, "Montana" },
                    { 25, "Targovishte" },
                    { 26, "Dimitrovgrad" },
                    { 27, "Silistra" },
                    { 28, "Lovech" },
                    { 29, "Razgrad" },
                    { 30, "Petrich" },
                    { 31, "Dupnitsa" },
                    { 32, "Gorna Oryahovitsa" },
                    { 33, "Smolyan" },
                    { 34, "Sandanski" },
                    { 35, "Samokov" },
                    { 36, "Nova Zagora" },
                    { 37, "Karlovo" },
                    { 38, "Velingrad" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 39, "Sevlievo" },
                    { 40, "Lom" },
                    { 41, "Aytos" },
                    { 42, "Svishtov" },
                    { 43, "Harmanli" },
                    { 44, "Troyan" },
                    { 45, "Botevgrad" },
                    { 46, "Gotse Delchev" },
                    { 47, "Peshtera" },
                    { 48, "Karnobat" },
                    { 49, "Svilengrad" },
                    { 50, "Momchilgrad" },
                    { 51, "Panagyurishte" },
                    { 52, "Popovo" },
                    { 53, "Chirpan" },
                    { 54, "Rakovski" },
                    { 55, "Parvomay" },
                    { 56, "Provadia" },
                    { 57, "Berkovitsa" },
                    { 58, "Novi Pazar" },
                    { 59, "Radomir" },
                    { 60, "Ihtiman" },
                    { 61, "Pomorie" },
                    { 62, "Novi Iskar" },
                    { 63, "Nesebar" },
                    { 64, "Radnevo" },
                    { 65, "Balchik" },
                    { 66, "Razlog" },
                    { 67, "Byala Slatina" },
                    { 68, "Kozloduy" },
                    { 69, "Kavarna" },
                    { 70, "Stamboliyski" },
                    { 71, "Pavlikeni" },
                    { 72, "Isperih" },
                    { 73, "Mezdra" },
                    { 74, "Kostinbrod" },
                    { 75, "Etropole" },
                    { 76, "Bankya" },
                    { 77, "Knezha" },
                    { 78, "Elhovo" },
                    { 79, "Omurtag" },
                    { 80, "Tutrakan" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 81, "Ardino" },
                    { 82, "Lukovit" },
                    { 83, "Teteven" },
                    { 84, "Kubrat" },
                    { 85, "Tryavna" },
                    { 86, "Bansko" },
                    { 87, "Sredets" },
                    { 88, "Veliki Preslav" },
                    { 89, "Krichim" },
                    { 90, "Devnya" },
                    { 91, "Rakitovo" },
                    { 92, "Septemvri" },
                    { 93, "Krumovgrad" },
                    { 94, "Belo Pole" },
                    { 95, "Lyaskovets" },
                    { 96, "Simeonovgrad" },
                    { 97, "Dzhebel" },
                    { 98, "Dulovo" },
                    { 99, "Aksakovo" },
                    { 100, "Belene" },
                    { 101, "Beloslav" },
                    { 102, "Svoge" },
                    { 103, "Dryanovo" },
                    { 104, "Lyubimets" },
                    { 105, "Tervel" },
                    { 106, "Zlatograd" },
                    { 107, "Dolni Chiflik" },
                    { 108, "Simitli" },
                    { 109, "Pirdop" },
                    { 110, "Kuklen" },
                    { 111, "Slivnitsa" },
                    { 112, "Elin Pelin" },
                    { 113, "General Toshevo" },
                    { 114, "Devin" },
                    { 115, "Aydemir" },
                    { 116, "Kostenets" },
                    { 117, "Tvarditsa" },
                    { 118, "Straldzha" },
                    { 119, "Varshets" },
                    { 120, "Tsarevo" },
                    { 121, "Kotel" },
                    { 122, "Lozen" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 123, "Yakoruda" },
                    { 124, "Kameno" },
                    { 125, "Belogradchik" },
                    { 126, "Elena" },
                    { 127, "Vetovo" },
                    { 128, "Topolovgrad" },
                    { 129, "Bobov Dol" },
                    { 130, "Strazhitsa" },
                    { 131, "Riltsi" },
                    { 132, "Benkovski" },
                    { 133, "Oryahovo" },
                    { 134, "Chepelare" },
                    { 135, "Suvorovo" },
                    { 136, "Perushtitsa" },
                    { 137, "Zlatitsa" },
                    { 138, "Yablanovo" },
                    { 139, "Bozhurishte" },
                    { 140, "Draginovo" },
                    { 141, "Bistritsa" },
                    { 142, "Polski Trambesh" },
                    { 143, "Dalgopol" },
                    { 144, "Rozino" },
                    { 145, "Sozopol" },
                    { 146, "Dolna Banya" },
                    { 147, "Logodazh" },
                    { 148, "Koynare" },
                    { 149, "Trastenik" },
                    { 150, "Dolni Dabnik" },
                    { 151, "Kazichene" },
                    { 152, "Dve Mogili" },
                    { 153, "Kostandovo" },
                    { 154, "Ignatievo" },
                    { 155, "Kalipetrovo" },
                    { 156, "Shivachevo" },
                    { 157, "Varbitsa" },
                    { 158, "Pravets" },
                    { 159, "Nikopol" },
                    { 160, "Nedelino" },
                    { 161, "Slavyanovo" },
                    { 162, "Strelcha" },
                    { 163, "Glodzhevo" },
                    { 164, "Godech" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 165, "Bukovlak" },
                    { 166, "Letnitsa" },
                    { 167, "Bratsigovo" },
                    { 168, "Malo Konare" },
                    { 169, "Sapareva Banya" },
                    { 170, "Belovo" },
                    { 171, "Dyankovo" },
                    { 172, "Breznik" },
                    { 173, "Trud" },
                    { 174, "Smyadovo" },
                    { 175, "Rudozem" },
                    { 176, "Slivo Pole" },
                    { 177, "Zavet" },
                    { 178, "Belozem" },
                    { 179, "Debelets" },
                    { 180, "Breznitsa" },
                    { 181, "Ivaylovgrad" },
                    { 182, "Tsalapitsa" },
                    { 183, "Sarnitsa" },
                    { 184, "Marten" },
                    { 185, "Kresna" },
                    { 186, "Sungurlare" },
                    { 187, "Vladaya" },
                    { 188, "Stara Kresna" },
                    { 189, "Brestovene" },
                    { 190, "Chorbadzhiysko" },
                    { 191, "Iskar" },
                    { 192, "Yasenovets" },
                    { 193, "Kran" },
                    { 194, "Pokrovnik" },
                    { 195, "Dolna Mitropolia" },
                    { 196, "Primorsko" },
                    { 197, "Selanovtsi" },
                    { 198, "Kochan" },
                    { 199, "Zarnevo" },
                    { 200, "Vrachesh" },
                    { 201, "Gulyantsi" },
                    { 202, "Yagodovo" },
                    { 203, "Maglizh" },
                    { 204, "Valchedram" },
                    { 205, "Krivodol" },
                    { 206, "Belitsa" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 207, "Aleko Konstantinovo" },
                    { 208, "Yoakim-Gruevo" },
                    { 209, "Nikolaevo" },
                    { 210, "Shabla" },
                    { 211, "Dragoman" },
                    { 212, "Smirnenski" },
                    { 213, "Yasenkovo" },
                    { 214, "Branipole" },
                    { 215, "Kaolinovo" },
                    { 216, "Sveti Vlas" },
                    { 217, "Valchidol" },
                    { 218, "Gurkovo" },
                    { 219, "Ezerche" },
                    { 220, "Ivaylo" },
                    { 221, "Roman" },
                    { 222, "Mizia" },
                    { 223, "Ruen" },
                    { 224, "Kula" },
                    { 225, "Rogosh" },
                    { 226, "Batak" },
                    { 227, "Ribnovo" },
                    { 228, "Yagoda" },
                    { 229, "Topoli" },
                    { 230, "Trudovets" },
                    { 231, "Ostrovo" },
                    { 232, "Kalofer" },
                    { 233, "Kamenar" },
                    { 234, "Krumovo" },
                    { 235, "Voluyak" },
                    { 236, "Pancharevo" },
                    { 237, "Pavel Banya" },
                    { 238, "Banya" },
                    { 239, "Kableshkovo" },
                    { 240, "Dorkovo" },
                    { 241, "Koprinka" },
                    { 242, "Draganovo" },
                    { 243, "Manole" },
                    { 244, "Dolna Oryahovitsa" },
                    { 245, "Ustina" },
                    { 246, "Opaka" },
                    { 247, "Hadzhidimovo" },
                    { 248, "Staro Oryahovo" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 249, "Borino" },
                    { 250, "Archar" },
                    { 251, "Iskra" },
                    { 252, "Dobrinishte" },
                    { 253, "Yablanitsa" },
                    { 254, "Loznitsa" },
                    { 255, "Sotirya" },
                    { 256, "Tsonevo" },
                    { 257, "Bezmer" },
                    { 258, "Novo Selo" },
                    { 259, "Valkosel" },
                    { 260, "Zlataritsa" },
                    { 261, "Buhovo" },
                    { 262, "Bolyartsi" },
                    { 263, "Kalekovets" },
                    { 264, "Ugarchin" },
                    { 265, "Samuil" },
                    { 266, "Byala Cherkva" },
                    { 267, "Kliment" },
                    { 268, "Nova Mahala" },
                    { 269, "Tran" },
                    { 270, "Kurtovo Konare" },
                    { 271, "Sadovo" },
                    { 272, "Markovo" },
                    { 273, "Galata" },
                    { 274, "Debren" },
                    { 275, "German" },
                    { 276, "Byal Izvor" },
                    { 277, "Podayva" },
                    { 278, "Grozdyovo" },
                    { 279, "Novi Han" },
                    { 280, "Apriltsi" },
                    { 281, "Ognyanovo" },
                    { 282, "Rila" },
                    { 283, "Parvomaytsi" },
                    { 284, "Valnari" },
                    { 285, "Skutare" },
                    { 286, "Kilifarevo" },
                    { 287, "Glavinitsa" },
                    { 288, "Dospat" },
                    { 289, "Gluhar" },
                    { 290, "Satovcha" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 291, "Chepintsi" },
                    { 292, "Sevar" },
                    { 293, "Bregovo" },
                    { 294, "Branichevo" },
                    { 295, "Shtraklevo" },
                    { 296, "Kornitsa" },
                    { 297, "Dermantsi" },
                    { 298, "Rani List" },
                    { 299, "Sadovets" },
                    { 300, "Obrochishte" },
                    { 301, "Dabnitsa" },
                    { 302, "Svetovrachane" },
                    { 303, "Kitanchevo" },
                    { 304, "Startsevo" },
                    { 305, "Slashten" },
                    { 306, "Buzovgrad" },
                    { 307, "Enina" },
                    { 308, "Fotinovo" },
                    { 309, "Borovo" },
                    { 310, "Katunitsa" },
                    { 311, "Bratanitsa" },
                    { 312, "Shiroko Pole" },
                    { 313, "Malko Tarnovo" },
                    { 314, "Pristoe" },
                    { 315, "Tsaratsovo" },
                    { 316, "Sborishte" },
                    { 317, "Polikrayshte" },
                    { 318, "Koprivshtitsa" },
                    { 319, "Batanovtsi" },
                    { 320, "Chernomorets" },
                    { 321, "Aheloy" },
                    { 322, "Belovets" },
                    { 323, "Borovan" },
                    { 324, "Musomishta" },
                    { 325, "Isperihovo" },
                    { 326, "Krushare" },
                    { 327, "Garmen" },
                    { 328, "Dragichevo" },
                    { 329, "Semchinovo" },
                    { 330, "Pordim" },
                    { 331, "Voyvodinovo" },
                    { 332, "Obzor" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 333, "Lazhnitsa" },
                    { 334, "Ayrovo" },
                    { 335, "Tetovo" },
                    { 336, "Laki" },
                    { 337, "Harlets" },
                    { 338, "Chernogorovo" },
                    { 339, "Medovets" },
                    { 340, "Yahinovo" },
                    { 341, "Gabarevo" },
                    { 342, "Sheynovo" },
                    { 343, "Chalakovi" },
                    { 344, "Vladimirovtsi" },
                    { 345, "Gorni Dabnik" },
                    { 346, "Tranak" },
                    { 347, "Pletena" },
                    { 348, "Balgarovo" },
                    { 349, "Glavinitsa" },
                    { 350, "Mokrishte" },
                    { 351, "Gorno Prahovo" },
                    { 352, "Aleksandrovo" },
                    { 353, "Petarch" },
                    { 354, "Bisertsi" },
                    { 355, "Sinitovo" },
                    { 356, "Timarevo" },
                    { 357, "Mramor" },
                    { 358, "Opalchensko" },
                    { 359, "Suhindol" },
                    { 360, "Zvanichevo" },
                    { 361, "Oreshak" },
                    { 362, "Kocherinovo" },
                    { 363, "Veselina" },
                    { 364, "Most" },
                    { 365, "Byala Reka" },
                    { 366, "Polkovnik Zhelyazovo" },
                    { 367, "Gradezhnitsa" },
                    { 368, "Okorsh" },
                    { 369, "Popintsi" },
                    { 370, "Nova Cherna" },
                    { 371, "Brestnik" },
                    { 372, "Gigen" },
                    { 373, "Debelt" },
                    { 374, "Kraynitsi" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 375, "Smilyan" },
                    { 376, "Slokoshtitsa" },
                    { 377, "Kokalyane" },
                    { 378, "Radanovo" },
                    { 379, "Hrishteni" },
                    { 380, "Litakovo" },
                    { 381, "Chernolik" },
                    { 382, "Zheglartsi" },
                    { 383, "Malorad" },
                    { 384, "Resen" },
                    { 385, "Hristo-Danovo" },
                    { 386, "Barutin" },
                    { 387, "Kostievo" },
                    { 388, "Korten" },
                    { 389, "Chiprovtsi" },
                    { 390, "Karageorgievo" },
                    { 391, "Lehchevo" },
                    { 392, "Komuniga" },
                    { 393, "Gruevo" },
                    { 394, "Asenovtsi" },
                    { 395, "Mortagonovo" },
                    { 396, "Antonovo" },
                    { 397, "Karnalovo" },
                    { 398, "Iskrets" },
                    { 399, "Gorna Mitropolia" },
                    { 400, "Zgorigrad" },
                    { 401, "Brezovo" },
                    { 402, "Izgrev" },
                    { 403, "Vakarel" },
                    { 404, "Belogradets" },
                    { 405, "Popitsa" },
                    { 406, "Seliminovo" },
                    { 407, "Karamantsi" },
                    { 408, "Uzundzhovo" },
                    { 409, "Graf Ignatievo" },
                    { 410, "Stremtsi" },
                    { 411, "Busmantsi" },
                    { 412, "Merichleri" },
                    { 413, "Sashevo" },
                    { 414, "Medkovets" },
                    { 415, "Mogilyane" },
                    { 416, "Golesh" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 417, "Lesnovo" },
                    { 418, "Samoranovo" },
                    { 419, "Skravena" },
                    { 420, "Kermen" },
                    { 421, "Plachkovtsi" },
                    { 422, "Divotino" },
                    { 423, "Glogovo" },
                    { 424, "Galiche" },
                    { 425, "Pchelnik" },
                    { 426, "Lyuben Karavelovo" },
                    { 427, "Dolni Tsibar" },
                    { 428, "Muldava" },
                    { 429, "Kavrakirovo" },
                    { 430, "Milkovitsa" },
                    { 431, "Sredishte" },
                    { 432, "Ovoshtnik" },
                    { 433, "Stavertsi" },
                    { 434, "Boyantsi" },
                    { 435, "Venets" },
                    { 436, "Stroevo" },
                    { 437, "Maglen" },
                    { 438, "Dolno Osenovo" },
                    { 439, "Petarnitsa" },
                    { 440, "Bachevo" },
                    { 441, "Vransko" },
                    { 442, "Dushevo" },
                    { 443, "Kukorevo" },
                    { 444, "Zverino" },
                    { 445, "Bistritsa" },
                    { 446, "Vetren Dol" },
                    { 447, "Razhitsa" },
                    { 448, "Varbovka" },
                    { 449, "Kamburovo" },
                    { 450, "Sveta Petka" },
                    { 451, "Radomirtsi" },
                    { 452, "Stozher" },
                    { 453, "Gorno Sakhrane" },
                    { 454, "Boychinovtsi" },
                    { 455, "Anton" },
                    { 456, "Toros" },
                    { 457, "Yunatsite" },
                    { 458, "Orizare" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 459, "Zheleznitsa" },
                    { 460, "Yakimovo" },
                    { 461, "Ivanski" },
                    { 462, "Yabalchevo" },
                    { 463, "Dabene" },
                    { 464, "Trivoditsi" },
                    { 465, "Grivitsa" },
                    { 466, "Trastenik" },
                    { 467, "Krepcha" },
                    { 468, "Chelopech" },
                    { 469, "Osetenovo" },
                    { 470, "Stratsin" },
                    { 471, "Mirkovo" },
                    { 472, "Dragor" },
                    { 473, "Oresh" },
                    { 474, "Zemen" },
                    { 475, "Kesarevo" },
                    { 476, "Vazovo" },
                    { 477, "Tarnak" },
                    { 478, "Obretenik" },
                    { 479, "Mirovyane" },
                    { 480, "Gornik" },
                    { 481, "Alfatar" },
                    { 482, "Negovan" },
                    { 483, "Tserovo" },
                    { 484, "Govedare" },
                    { 485, "Senovo" },
                    { 486, "Chintulovo" },
                    { 487, "Zmeitsa" },
                    { 488, "Samovodene" },
                    { 489, "Feldfebel Denkovo" },
                    { 490, "Tenevo" },
                    { 491, "Tazha" },
                    { 492, "Dabravino" },
                    { 493, "Sklave" },
                    { 494, "Lilyache" },
                    { 495, "Ryahovtsite" },
                    { 496, "Gorski Izvor" },
                    { 497, "Barzia" },
                    { 498, "Hvostyane" },
                    { 499, "Krushari" },
                    { 500, "Krivina" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 501, "Obruchishte" },
                    { 502, "Perperek" },
                    { 503, "Zaychar" },
                    { 504, "Partizani" },
                    { 505, "Glava" },
                    { 506, "Rogach" },
                    { 507, "Manolich" },
                    { 508, "Maysko" },
                    { 509, "Gorna Kula" },
                    { 510, "Boyno" },
                    { 511, "Ludogortsi" },
                    { 512, "Ryahovo" },
                    { 513, "Vinogradets" },
                    { 514, "Leshko" },
                    { 515, "Dalboki" },
                    { 516, "Bozveliysko" },
                    { 517, "Byaga" },
                    { 518, "Duhovets" },
                    { 519, "Dolno Dryanovo" },
                    { 520, "Eleshnitsa" },
                    { 521, "Yonkovo" },
                    { 522, "Dobromirtsi" },
                    { 523, "Potochnitsa" },
                    { 524, "Orizovo" },
                    { 525, "Dobrovnitsa" },
                    { 526, "Tsarev Brod" },
                    { 527, "Chakalarovo" },
                    { 528, "Drenovets" },
                    { 529, "Nedan" },
                    { 530, "Paprat" },
                    { 531, "Bezhanovo" },
                    { 532, "Zagoriche" },
                    { 533, "Paisievo" },
                    { 534, "Kitna" },
                    { 535, "Gorna Malina" },
                    { 536, "Gramada" },
                    { 537, "Zvezdel" },
                    { 538, "Drumevo" },
                    { 539, "Zvanarka" },
                    { 540, "Malchika" },
                    { 541, "Lilyak" },
                    { 542, "Balgarski Izvor" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 543, "Dzherman" },
                    { 544, "Sokolino" },
                    { 545, "Zlatitrap" },
                    { 546, "Iskra" },
                    { 547, "Zhinzifovo" },
                    { 548, "Hayredin" },
                    { 549, "Koprivlen" },
                    { 550, "Polenitsa" },
                    { 551, "Semerdzhievo" },
                    { 552, "Mlechino" },
                    { 553, "Ostrov" },
                    { 554, "Dobromir" },
                    { 555, "Vaklinovo" },
                    { 556, "Vladimirovo" },
                    { 557, "Morozovo" },
                    { 558, "Karabunar" },
                    { 559, "Kobilyane" },
                    { 560, "Tulovo" },
                    { 561, "Chernevo" },
                    { 562, "Popovitsa" },
                    { 563, "Bazan" },
                    { 564, "Belomortsi" },
                    { 565, "Razhevo Konare" },
                    { 566, "Bozhan" },
                    { 567, "Golyamo Gradishte" },
                    { 568, "Sofronievo" },
                    { 569, "Zlatar" },
                    { 570, "Damyanitsa" },
                    { 571, "Benkovski" },
                    { 572, "Mineralni Bani" },
                    { 573, "Radilovo" },
                    { 574, "Beli Lom" },
                    { 575, "Baniska" },
                    { 576, "Kanchevo" },
                    { 577, "Kranevo" },
                    { 578, "Lopushna" },
                    { 579, "Staliyska Mahala" },
                    { 580, "Kirchevo" },
                    { 581, "Shipka" },
                    { 582, "Ahtopol" },
                    { 583, "Tankovo" },
                    { 584, "Gorno Kraishte" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 585, "Ruets" },
                    { 586, "Sipey" },
                    { 587, "Rezbartsi" },
                    { 588, "Aldomirovtsi" },
                    { 589, "Dinkata" },
                    { 590, "Kralevo" },
                    { 591, "Grashevo" },
                    { 592, "Dabnik" },
                    { 593, "Ustren" },
                    { 594, "Orehovitsa" },
                    { 595, "Konstantinovo" },
                    { 596, "Bortsi" },
                    { 597, "Basarbovo" },
                    { 598, "Zhelyazkovets" },
                    { 599, "Vresovo" },
                    { 600, "Minzuhar" },
                    { 601, "Kozlovets" },
                    { 602, "Katuntsi" },
                    { 603, "Marikostinovo" },
                    { 604, "Novachene" },
                    { 605, "Dolni Bogrov" },
                    { 606, "Pirgovo" },
                    { 607, "Kovachitsa" },
                    { 608, "Byala" },
                    { 609, "Visoka Polyana" },
                    { 610, "Takach" },
                    { 611, "Rudartsi" },
                    { 612, "Kosharitsa" },
                    { 613, "Starovo" },
                    { 614, "Dalbok Izvor" },
                    { 615, "Tserovishte" },
                    { 616, "Boyadzhik" },
                    { 617, "Yurukovo" },
                    { 618, "Varben" },
                    { 619, "Chavdar" },
                    { 620, "Bata" },
                    { 621, "Sindel" },
                    { 622, "Yabalkovo" },
                    { 623, "Banitsa" },
                    { 624, "Karapelit" },
                    { 625, "Tihomir" },
                    { 626, "Novo Selo" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 627, "Filaretovo" },
                    { 628, "Razhena" },
                    { 629, "Sandrovo" },
                    { 630, "Prelez" },
                    { 631, "Popgruevo" },
                    { 632, "Gara Lakatnik" },
                    { 633, "Sveshtari" },
                    { 634, "Belasitsa" },
                    { 635, "Govedartsi" },
                    { 636, "Balgarevo" },
                    { 637, "Vlado Trichkov" },
                    { 638, "Pokrayna" },
                    { 639, "Pasarel" },
                    { 640, "Gradets" },
                    { 641, "Byala Palanka" },
                    { 642, "Konstantin" },
                    { 643, "Chiflik" },
                    { 644, "Vaglen" },
                    { 645, "Sredkovets" },
                    { 646, "Vedrare" },
                    { 647, "Boboshevo" },
                    { 648, "Resilovo" },
                    { 649, "Zamfirovo" },
                    { 650, "Dabovo" },
                    { 651, "Vardun" },
                    { 652, "Marchaevo" },
                    { 653, "Momchilovtsi" },
                    { 654, "Sindeltsi" },
                    { 655, "Ruyno" },
                    { 656, "Prileptsi" },
                    { 657, "Brestnitsa" },
                    { 658, "Yana" },
                    { 659, "Lyaskovets" },
                    { 660, "Petlino" },
                    { 661, "Klisura" },
                    { 662, "Bolyarovo" },
                    { 663, "Petko Slaveykov" },
                    { 664, "Gorni Bogrov" },
                    { 665, "Dzhurovo" },
                    { 666, "Gavrailovo" },
                    { 667, "Elhovets" },
                    { 668, "Zidarovo" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 669, "Mishevsko" },
                    { 670, "Dimovo" },
                    { 671, "Patalenitsa" },
                    { 672, "Ekzarh-Antimovo" },
                    { 673, "Novo Delchevo" },
                    { 674, "Obitel" },
                    { 675, "Pisarevo" },
                    { 676, "Zhilentsi" },
                    { 677, "Tushovtsa" },
                    { 678, "Kichenitsa" },
                    { 679, "Madrevo" },
                    { 680, "Brusartsi" },
                    { 681, "Altimir" },
                    { 682, "Krastava" },
                    { 683, "Katina" },
                    { 684, "Dobri Dyal" },
                    { 685, "Rusokastro" },
                    { 686, "Cherniche" },
                    { 687, "Kaloyantsi" },
                    { 688, "Oborishte" },
                    { 689, "Karadzhalovo" },
                    { 690, "Novachene" },
                    { 691, "Dobroslavtsi" },
                    { 692, "Gyulyovtsa" },
                    { 693, "Marinka" },
                    { 694, "Cherven Breg" },
                    { 695, "Tsarevets" },
                    { 696, "Novachevo" },
                    { 697, "Hadzhievo" },
                    { 698, "Rasovo" },
                    { 699, "Zvezditsa" },
                    { 700, "Varbitsa" },
                    { 701, "Tarnicheni" },
                    { 702, "Gorno Dryanovo" },
                    { 703, "Sekulovo" },
                    { 704, "Zhivkovo" },
                    { 705, "Karadzhovo" },
                    { 706, "Topchiysko" },
                    { 707, "Voynyagovo" },
                    { 708, "Nanovitsa" },
                    { 709, "General Geshevo" },
                    { 710, "Kadievo" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 711, "Beli Vir" },
                    { 712, "Konche" },
                    { 713, "Gabare" },
                    { 714, "Topolitsa" },
                    { 715, "Mihnevo" },
                    { 716, "Sestrimo" },
                    { 717, "Rupite" },
                    { 718, "Pchelari" },
                    { 719, "Yabalkovets" },
                    { 720, "Ridino" },
                    { 721, "Plastina" },
                    { 722, "Nikola-Kozlevo" },
                    { 723, "Gabrovo" },
                    { 724, "Dolno Cherkovishte" },
                    { 725, "Kladnitsa" },
                    { 726, "Kolobar" },
                    { 727, "Stambolovo" },
                    { 728, "Tarnene" },
                    { 729, "Zhabokrat" },
                    { 730, "Glozhene" },
                    { 731, "Varbina" },
                    { 732, "Shishmanovo" },
                    { 733, "Pelin" },
                    { 734, "Preseka" },
                    { 735, "Gusla" },
                    { 736, "Bozhuritsa" },
                    { 737, "Yavornitsa" },
                    { 738, "Trem" },
                    { 739, "Klyuch" },
                    { 740, "Telerig" },
                    { 741, "Voysil" },
                    { 742, "Drangovo" },
                    { 743, "Mramoren" },
                    { 744, "Chomakovtsi" },
                    { 745, "Klikach" },
                    { 746, "Madara" },
                    { 747, "Yudelnik" },
                    { 748, "Spasovo" },
                    { 749, "Novo Selo" },
                    { 750, "Ivanovo" },
                    { 751, "Ruzhintsi" },
                    { 752, "Kirkovo" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 753, "Kaynardzha" },
                    { 754, "Nevestino" },
                    { 755, "Shiroka Laka" },
                    { 756, "Chuprene" },
                    { 757, "Boynitsa" },
                    { 758, "Makresh" },
                    { 759, "Madan" },
                    { 760, "Iskar" },
                    { 761, "Sitovo" },
                    { 762, "Tsenovo" },
                    { 763, "Byala" }
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
