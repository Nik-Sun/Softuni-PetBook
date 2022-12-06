using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetBook.Infrastructure.Migrations
{
    public partial class AddressExtended : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Like_AspNetUsers_UserId",
                table: "Like");

            migrationBuilder.DropForeignKey(
                name: "FK_Like_Pets_PetId",
                table: "Like");

            migrationBuilder.AddColumn<double>(
                name: "Lattitude",
                table: "Cities",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Cities",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Lattitude",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Longitude",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.697899999999997, 23.3217 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.211399999999998, 27.911100000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.143300000000004, 24.748899999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.5, 27.466699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.844499999999996, 25.953900000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.425699999999999, 25.634599999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.413200000000003, 24.616900000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.678100000000001, 26.326000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.566699999999997, 27.833300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.270000000000003, 26.924399999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.934600000000003, 25.555599999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.1892, 24.331700000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.482399999999998, 26.503799999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.609699999999997, 23.030799999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.011899999999997, 23.089700000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.0822, 25.631699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.2121, 23.5444 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.640000000000001, 25.370799999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.281100000000002, 22.6889 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.871099999999998, 25.315000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.008200000000002, 24.877300000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.988700000000001, 22.874099999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.616700000000002, 25.399999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.405500000000004, 23.2242 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.241399999999999, 26.571899999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.061100000000003, 25.593299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 44.118600000000001, 27.260300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.1342, 24.717199999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.526699999999998, 26.5242 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.398099999999999, 23.206900000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.265000000000001, 23.118500000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.122199999999999, 25.689699999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.575299999999999, 24.712800000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.558900000000001, 23.2744 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.338099999999997, 23.559999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.490299999999998, 26.0122 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.642000000000003, 24.808199999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.0276, 23.991299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.025799999999997, 25.103899999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.827199999999998, 23.2364 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.698999999999998, 27.248999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.6113, 25.3569 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.9238, 25.918299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.884399999999999, 24.709399999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.907299999999999, 23.793700000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.573700000000002, 23.729099999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.033999999999999, 24.302499999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.651299999999999, 26.985499999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.7652, 26.202999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.529699999999998, 25.406400000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.502600000000001, 24.180199999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.348100000000002, 26.227499999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.198099999999997, 25.330400000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.288400000000003, 24.965499999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.099400000000003, 25.2242 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.169400000000003, 27.442799999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.237099999999998, 23.1251 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.3476, 27.1981 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.546700000000001, 22.964200000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.433300000000003, 23.816700000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.556899999999999, 27.640499999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.803100000000001, 23.343599999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.660800000000002, 27.713899999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.288600000000002, 25.933599999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.407800000000002, 28.162199999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.886499999999998, 23.468 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.468800000000002, 23.945399999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.776400000000002, 23.729399999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.433300000000003, 28.338899999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.133200000000002, 24.5379 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.237499999999997, 25.307400000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.720399999999998, 26.828099999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.142499999999998, 23.714200000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.810099999999998, 23.216799999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.833300000000001, 24.0 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.706899999999997, 23.147200000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.493099999999998, 24.0806 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.171900000000001, 26.565799999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.107199999999999, 26.4192 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 44.048099999999998, 26.604399999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.582900000000002, 25.133199999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.2102, 24.1629 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.917700000000004, 24.257400000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.796700000000001, 26.501100000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.866700000000002, 25.491900000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.838500000000003, 23.488800000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.3461, 27.180800000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.1614, 26.8125 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.0426, 24.464600000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.218000000000004, 27.558 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.990000000000002, 24.087199999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.2164, 24.125 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.4709, 25.654599999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.032800000000002, 23.050000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.1081, 25.713200000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.032400000000003, 25.834499999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.5, 25.300000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.822899999999997, 27.141200000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.260800000000003, 27.815899999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.645600000000002, 25.125800000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.1892, 27.704999999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.959400000000002, 23.3477 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.973599999999998, 25.474699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.844499999999996, 26.081 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.75, 27.399999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.3797, 25.0928 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.993099999999998, 27.715800000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.891399999999997, 23.111699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.700000000000003, 24.183299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.034300000000002, 24.787800000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.851500000000001, 23.0383 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.668900000000001, 23.602499999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.700600000000001, 28.0367 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.7425, 24.3992 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 44.100000000000001, 27.166699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.307499999999997, 23.857500000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.701700000000002, 25.897500000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.600000000000001, 26.683299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.195300000000003, 23.285799999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.1708, 27.851099999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.886299999999999, 26.449999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.600000000000001, 23.4833 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.018300000000004, 23.669699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.566699999999997, 27.300000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.626899999999999, 22.683299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.9298, 25.878699999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.700000000000003, 26.2667 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.084200000000003, 26.337499999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.363799999999998, 22.997900000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.2333, 25.966699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.040100000000002, 23.0656 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.383299999999998, 25.2667 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.738900000000001, 23.961200000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.723300000000002, 24.6861 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.329999999999998, 27.592500000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.056100000000001, 24.5444 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.7134, 24.139099999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.9833, 26.550000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.75, 23.199999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.066699999999997, 24.0167 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.586100000000002, 23.359999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.367600000000003, 25.631900000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.049799999999998, 27.346299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.700000000000003, 24.550000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.418700000000001, 27.694299999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.299999999999997, 23.7667 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.989199999999997, 22.9358 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.357300000000002, 24.145 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.520699999999998, 24.471599999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.408900000000003, 24.440200000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.666699999999999, 23.466699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.600000000000001, 25.866700000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.0167, 24.116700000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.25, 27.7667 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 44.083300000000001, 27.2333 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.683300000000003, 26.033300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.993099999999998, 26.6721 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.894399999999997, 23.915600000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.698599999999999, 24.892399999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.459699999999998, 25.077000000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.465200000000003, 24.872199999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.506399999999999, 24.321100000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.732900000000001, 26.387799999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.015000000000001, 23.0442 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.450000000000003, 24.616700000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.316699999999997, 25.066700000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.023099999999999, 24.369599999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.200000000000003, 24.433299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.287399999999998, 23.258900000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.214599999999997, 24.020099999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.616700000000002, 26.600000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.740000000000002, 22.908300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.2333, 24.7333 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.066699999999997, 27.0167 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.489199999999997, 24.845400000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.941899999999997, 26.206399999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.759099999999997, 26.6751 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.200000000000003, 25.033300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.043799999999997, 25.6218 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.671900000000001, 23.658000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.528100000000002, 26.124400000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.183300000000003, 24.566700000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.737499999999997, 24.0243 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.920400000000001, 26.084800000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.720199999999998, 23.160799999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.761899999999997, 26.773599999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.633299999999998, 23.199999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.789999999999999, 23.180800000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.7667, 26.583300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.373600000000003, 25.406500000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.450000000000003, 24.2667 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.573300000000003, 26.624700000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.666699999999999, 25.383299999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.982300000000002, 23.053799999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.467799999999997, 24.520600000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.2669, 27.754999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.683300000000003, 24.0167 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.583300000000001, 24.033300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.633299999999998, 27.333300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.892099999999999, 23.749400000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.637099999999997, 24.6904 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.100000000000001, 24.850000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.6083, 25.5456 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.696100000000001, 23.444800000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.371699999999997, 23.481300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.947800000000001, 23.562899999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.159700000000001, 24.284400000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.116700000000002, 24.566700000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.629600000000003, 25.788799999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.533299999999997, 28.533300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.921700000000001, 22.9297 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.7667, 26.300000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.5456, 26.838100000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.083300000000001, 24.75 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.616700000000002, 27.091699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.716700000000003, 27.7667 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.399999999999999, 27.550000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.660600000000002, 25.791899999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.549999999999997, 26.316700000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.216700000000003, 24.333300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.149999999999999, 23.916699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.683300000000003, 23.850000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.799999999999997, 27.283300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.883299999999998, 22.5167 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.183300000000003, 24.866700000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.944000000000003, 24.2178 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.716700000000003, 23.7667 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.549999999999997, 25.600000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.218299999999999, 27.821400000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.916699999999999, 23.833300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.683900000000001, 26.607199999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.611199999999997, 24.974799999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.249299999999998, 27.899899999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.083300000000001, 24.816700000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.7667, 23.25 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.582999999999998, 23.399999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.597200000000001, 25.2075 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.879399999999997, 23.526900000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.6601, 27.568000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.046900000000001, 24.131900000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.633299999999998, 25.333300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.216700000000003, 25.75 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.183300000000003, 24.933299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.156500000000001, 25.739100000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.033299999999997, 24.5167 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.447400000000002, 26.1736 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.515500000000003, 23.852599999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.989600000000003, 27.799800000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.683300000000003, 24.283300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.8108, 22.918099999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 44.0, 26.9833 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.820999999999998, 23.563400000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.024999999999999, 24.100000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.371499999999997, 26.598700000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.683300000000003, 26.399999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.033299999999997, 27.433299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.7667, 27.416699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.104999999999997, 24.483000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.533299999999997, 23.9833 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.044199999999996, 25.889700000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.763800000000003, 23.565799999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.066699999999997, 24.966699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.2333, 24.816700000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.100000000000001, 24.416699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.5167, 26.75 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.205100000000002, 25.310600000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.616700000000002, 27.0 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.933300000000003, 24.283300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.836500000000001, 22.651 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.092799999999997, 24.501899999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.130400000000002, 24.938500000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.066699999999997, 24.699999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.0167, 24.283300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.584299999999999, 23.822800000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.616700000000002, 23.416699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.549999999999997, 25.083300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.671900000000001, 26.9161 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.0167, 27.533300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.600000000000001, 23.600000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.8399, 24.920000000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.149999999999999, 24.416699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.126800000000003, 23.130700000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.152999999999999, 25.652100000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.600000000000001, 27.216699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.183300000000003, 24.833300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.994300000000003, 25.6205 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.158099999999997, 24.310300000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.645800000000001, 24.160499999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.595300000000002, 25.3935 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.619300000000003, 23.976900000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.7667, 23.433299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.833300000000001, 26.583300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 44.149999999999999, 22.649999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.68, 27.099399999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.716700000000003, 26.050000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.640599999999999, 23.676400000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.149999999999999, 24.283300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.683300000000003, 25.399999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.299999999999997, 24.350000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.403100000000002, 28.045500000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.566699999999997, 23.833300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.783299999999997, 23.399999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.731900000000003, 26.892199999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.416699999999999, 25.066700000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.5, 24.0167 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.566699999999997, 25.366700000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.666899999999998, 25.408300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.373100000000001, 25.341699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.490699999999997, 25.811499999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.100000000000001, 24.866700000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.166699999999999, 24.216699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.616700000000002, 25.458300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.980600000000003, 27.523599999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.649999999999999, 27.083300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.200000000000003, 24.683299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.683300000000003, 25.966699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.180700000000002, 25.619900000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.640099999999997, 24.3583 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.600000000000001, 22.949999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.444400000000002, 27.6387 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.648899999999998, 27.648099999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.816699999999997, 26.383299999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.427700000000002, 23.754200000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.553100000000001, 23.747599999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.083300000000001, 24.433299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.549999999999997, 26.366700000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.598199999999999, 23.8032 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.616700000000002, 23.183299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.178899999999999, 24.0975 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.378100000000003, 24.8476 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.1999, 24.7942 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.823, 27.878699999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.616700000000002, 23.683299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.616700000000002, 25.366700000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.816699999999997, 26.283300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.832599999999999, 24.831499999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.700000000000003, 23.833300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.277200000000001, 24.398099999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.0, 27.133299999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.283299999999997, 23.149999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.616700000000002, 25.166699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.683300000000003, 25.316700000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.149999999999999, 25.0167 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.633299999999998, 26.866700000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.383299999999998, 24.350000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.950000000000003, 27.216699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.638300000000001, 23.957799999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.620100000000001, 27.305900000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.9116, 26.834499999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.183300000000003, 24.283300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.645600000000002, 25.159500000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.25, 24.949999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.833300000000001, 23.133299999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.8842, 26.503599999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.149999999999999, 24.366700000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.399999999999999, 26.883299999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.786099999999998, 23.273599999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.600000000000001, 25.366700000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.191699999999997, 25.180800000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.183300000000003, 24.25 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.883299999999998, 24.7667 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.085599999999999, 23.0581 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.450000000000003, 26.683299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.734999999999999, 25.521100000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.0, 26.7667 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.465699999999998, 25.6724 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.0167, 24.2333 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.75, 27.033300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.416699999999999, 24.283300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 44.010800000000003, 26.5 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.049999999999997, 24.7667 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.700000000000003, 24.4833 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.402099999999997, 27.260400000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.316699999999997, 23.199999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.5, 24.75 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.2667, 22.7072 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.583300000000001, 23.416699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.3399, 25.636600000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.450000000000003, 25.699999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.950000000000003, 23.683299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.866700000000002, 27.083300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.666699999999999, 27.399999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.488900000000001, 23.6875 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.200000000000003, 25.550000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.7333, 24.600000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.600000000000001, 24.183299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.176600000000001, 24.623699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.549999999999997, 26.0 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.384599999999999, 22.8825 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.735700000000001, 27.1845 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.533299999999997, 23.533300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.799999999999997, 25.233000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.566099999999999, 25.4055 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.316699999999997, 25.100000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.5167, 26.649999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.149999999999999, 26.166699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.4634, 23.223600000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.9833, 23.25 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.466700000000003, 24.449999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.180100000000003, 23.5169 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.348799999999997, 25.076799999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.583300000000001, 27.0 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.549999999999997, 23.716699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.3521, 27.331199999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.427100000000003, 23.9559 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.649999999999999, 26.149999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.834400000000002, 25.3294 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.963099999999997, 25.655799999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.283299999999997, 24.75 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.7333, 25.416699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.683300000000003, 23.433299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.132899999999999, 25.499300000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.301400000000001, 25.649699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.633299999999998, 23.183299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.366700000000002, 25.2333 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.950000000000003, 27.616700000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.633299999999998, 23.633299999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.25, 23.166699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.951900000000002, 23.767800000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.500300000000003, 26.259 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.825499999999998, 25.4832 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.666699999999999, 23.050000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.966700000000003, 24.2333 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.560200000000002, 23.864000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.013300000000001, 27.668600000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.350000000000001, 27.783300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.816699999999997, 23.5167 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.9833, 24.949999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.433300000000003, 23.166699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.633299999999998, 24.75 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.899999999999999, 27.4833 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.583300000000001, 25.449999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.566699999999997, 24.283300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.049999999999997, 24.949999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.549999999999997, 26.933299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.2333, 24.683299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.7273, 27.370200000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.955199999999998, 23.240600000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.326700000000002, 24.472799999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.921900000000001, 23.4528 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.482999999999997, 25.642600000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.966700000000003, 25.033300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.450000000000003, 26.533300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.083300000000001, 23.550000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.2333, 23.166699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.149999999999999, 24.149999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.783299999999997, 27.399999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.2333, 25.199999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.100000000000001, 26.333300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.033299999999997, 23.866700000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.247199999999999, 24.195599999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.450000000000003, 27.816700000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.649999999999999, 25.216699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.471899999999998, 23.335599999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.75, 24.283300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.100000000000001, 24.283300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.2333, 24.2667 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.7498, 27.6204 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.533299999999997, 23.366700000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.634700000000002, 23.3536 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.133299999999998, 27.033300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.783299999999997, 27.25 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.600000000000001, 24.7667 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.135800000000003, 24.466100000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.416699999999999, 24.699999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.658200000000001, 25.84 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.4833, 26.133299999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.700000000000003, 24.083300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.600000000000001, 25.033300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.7667, 27.466699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.700000000000003, 23.9833 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.2333, 24.300000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.577300000000001, 25.243600000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.478900000000003, 22.75 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.1526, 25.9681 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.7667, 26.816700000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.450000000000003, 24.033300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.580800000000004, 25.809200000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.783299999999997, 23.300000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.283299999999997, 24.033300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.9467, 27.2911 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.768799999999999, 23.406400000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.003799999999998, 23.347899999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.149999999999999, 24.5 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.648000000000003, 26.361499999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.649999999999999, 26.25 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.633299999999998, 24.25 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.1389, 25.610499999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.714700000000001, 27.531700000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.350000000000001, 26.533300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.649999999999999, 25.083300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.049999999999997, 27.600000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.5167, 23.316700000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.3215, 23.521999999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.0167, 25.0167 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.350000000000001, 25.166699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.198099999999997, 23.160799999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.549999999999997, 23.850000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.817700000000002, 27.757999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.683300000000003, 23.466699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.133299999999998, 25.933299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.686100000000003, 25.545300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.783299999999997, 27.166699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.0092, 27.251000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.399999999999999, 24.199999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.4542, 25.699000000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.8917, 26.800000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.933300000000003, 26.149999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.4955, 25.6145 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.601100000000002, 25.276900000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.649999999999999, 26.7667 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.9833, 26.25 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.283299999999997, 24.133299999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.931800000000003, 22.9788 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.4833, 25.7667 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.100000000000001, 27.466699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.066099999999999, 24.377500000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.666699999999999, 27.0167 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.5871, 23.8977 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.867699999999999, 23.622499999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.633299999999998, 26.716699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.381, 25.209800000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.6083, 25.675000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.2089, 25.170300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.216700000000003, 24.383299999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.333300000000001, 27.0167 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.311100000000003, 25.3139 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.693100000000001, 22.980599999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.3033, 25.2666 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.515500000000003, 25.277999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.2333, 24.399999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.700000000000003, 27.083300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.783299999999997, 26.966699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.383299999999998, 25.2667 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.693600000000004, 23.706099999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.834800000000001, 22.661000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.476199999999999, 25.5259 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.133299999999998, 27.149999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.450000000000003, 25.633299999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.416699999999999, 25.100000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.229999999999997, 26.479199999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.033299999999997, 24.283300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.216700000000003, 23.083300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.513199999999998, 25.4314 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.116700000000002, 24.633299999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.933300000000003, 25.133299999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.664700000000003, 25.4864 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.600000000000001, 23.666699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.520400000000002, 23.794899999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.566699999999997, 23.300000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.7667, 26.166699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.624699999999997, 25.1736 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.6755, 24.129999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.950000000000003, 27.300000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.5959, 24.063600000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.533299999999997, 23.383299999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.573599999999999, 25.316400000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.265799999999999, 24.1751 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.597000000000001, 25.235499999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.583300000000001, 25.550000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.299999999999997, 27.600000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.135599999999997, 25.056699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.7333, 26.116700000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.133299999999998, 26.433299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.333300000000001, 24.800000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.759999999999998, 27.457000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.450000000000003, 26.050000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.636499999999998, 23.7867 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.100000000000001, 26.966699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.5167, 23.2667 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.216700000000003, 24.649999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.933300000000003, 25.350000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.083300000000001, 24.300000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.433300000000003, 26.716699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.458100000000002, 25.901399999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.533299999999997, 25.449999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.341799999999999, 28.053799999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.0045, 27.186299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.738300000000002, 23.164200000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.9833, 24.366700000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.710299999999997, 25.335599999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.100299999999997, 27.941400000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.694600000000001, 27.6496 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.899999999999999, 23.583300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.213099999999997, 26.6233 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.649999999999999, 25.399999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.619300000000003, 25.359100000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.850000000000001, 22.980799999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.283299999999997, 24.2333 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.183300000000003, 26.699999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.966700000000003, 23.933299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.683300000000003, 27.5 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.459499999999998, 25.226600000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.583300000000001, 24.383299999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.162700000000001, 27.7806 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.533299999999997, 26.883299999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.783299999999997, 25.949999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.5167, 26.699999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.812399999999997, 27.198499999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.7667, 25.399999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.5, 25.366700000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.442300000000003, 23.427399999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.430799999999998, 23.3428 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.966700000000003, 23.716699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.700000000000003, 23.5 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.7333, 25.866700000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.799999999999997, 23.360299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.7333, 26.183299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.666699999999999, 25.5167 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.600000000000001, 27.033300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.583300000000001, 23.166699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.75, 27.699999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.416499999999999, 25.3155 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.033299999999997, 25.100000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.049999999999997, 26.583300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.399999999999999, 26.300000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.972900000000003, 23.6159 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.405799999999999, 25.3674 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.649999999999999, 24.050000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.7333, 27.5 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.110199999999999, 27.6051 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.066699999999997, 25.433299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.343899999999998, 23.690200000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.649999999999999, 27.566700000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.299999999999997, 25.5 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.799999999999997, 26.183299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.9833, 26.5 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.533299999999997, 25.5 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.933, 26.117000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.833300000000001, 26.683299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.741700000000002, 27.481200000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.083300000000001, 23.383299999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.75, 26.783300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.366700000000002, 23.133299999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.25, 23.4833 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.4026, 28.413 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.866700000000002, 23.366700000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 44.031500000000001, 22.907399999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.533299999999997, 23.5 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 44.033299999999997, 22.75 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.7667, 26.100000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.947899999999997, 26.073699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.685499999999998, 25.499099999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.294400000000003, 27.848800000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.683300000000003, 27.033300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.583300000000001, 24.883299999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.150500000000001, 23.001999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.2667, 23.199999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.2958, 23.2422 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.600000000000001, 25.649999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.133899999999997, 26.533899999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.600000000000001, 23.183299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.658900000000003, 24.7744 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.464100000000002, 25.574999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.833300000000001, 27.033300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.626800000000003, 25.345800000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.066699999999997, 24.183299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.7333, 23.566700000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.716700000000003, 25.699999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.600000000000001, 25.350000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.700000000000003, 24.449999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.150399999999998, 26.811499999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.049999999999997, 24.966699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.716700000000003, 23.533300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.933300000000003, 24.050000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.649999999999999, 26.183299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.450000000000003, 24.800000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.327500000000001, 27.4025 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.526699999999998, 25.239599999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.741500000000002, 22.726700000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.116700000000002, 24.199999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.533299999999997, 26.9833 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.506, 23.283899999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.066699999999997, 26.566700000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.149999999999999, 25.783300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.2667, 22.649999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.0167, 26.800000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.604399999999998, 26.506399999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.866700000000002, 26.550000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.666699999999999, 23.066700000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.533000000000001, 23.799800000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.960900000000002, 23.820499999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.843299999999999, 23.319400000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.116700000000002, 25.833300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.465600000000002, 27.186599999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.850000000000001, 23.133299999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.666200000000003, 25.554099999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.5167, 24.083300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.083300000000001, 25.283300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.549999999999997, 24.933299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.816699999999997, 23.283300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.7667, 27.600000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.401499999999999, 27.482099999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.311100000000003, 23.173100000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.586300000000001, 25.3644 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.75, 26.149999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.143099999999997, 24.455300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.700000000000003, 23.2333 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.155799999999999, 27.837199999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.183300000000003, 25.816700000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.616700000000002, 25.116700000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.651499999999999, 23.828299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.700000000000003, 27.166699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.450000000000003, 27.033300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.100000000000001, 24.899999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.851999999999997, 27.343900000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.566699999999997, 24.75 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.549999999999997, 25.566700000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.433999999999997, 25.193999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.133299999999998, 24.600000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.7333, 25.300000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.450000000000003, 25.533300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.316699999999997, 23.916699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.736600000000003, 27.1251 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.453400000000002, 23.195900000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.216700000000003, 23.916699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.441899999999997, 23.241700000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.633299999999998, 25.683299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.602400000000003, 25.1906 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.439700000000002, 25.2822 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.066699999999997, 26.616700000000002 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.566699999999997, 27.2333 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.796999999999997, 25.270099999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.633299999999998, 25.75 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.566699999999997, 23.183299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.783299999999997, 27.183299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.7667, 25.649999999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.396700000000003, 24.5153 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.302799999999998, 22.758099999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.9833, 24.183299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.566699999999997, 24.966699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.9833, 25.933299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.467500000000001, 25.7319 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.383299999999998, 25.183299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.666699999999999, 27.050000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.5167, 24.600000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.368099999999998, 23.050899999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.450000000000003, 26.800000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.362200000000001, 23.0214 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.850000000000001, 27.666699999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.216700000000003, 24.633299999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.333300000000001, 25.25 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.299999999999997, 23.683299999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.316699999999997, 24.066700000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.704900000000002, 27.059100000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.283299999999997, 27.100000000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.850000000000001, 26.25 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.702300000000001, 28.300999999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 44.158200000000001, 22.786899999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.685000000000002, 25.956 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.623899999999999, 22.8308 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.329999999999998, 25.365300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.9833, 27.5 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.256399999999999, 22.853300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.683300000000003, 24.583300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.519300000000001, 22.666499999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.950000000000003, 22.533300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.768000000000001, 22.6694 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 41.498699999999999, 24.939699999999998 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.6708, 24.452300000000001 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 44.027299999999997, 27.0198 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 43.535899999999998, 25.657599999999999 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "Lattitude", "Longitude" },
                values: new object[] { 42.874299999999998, 27.8886 });

            migrationBuilder.AddForeignKey(
                name: "FK_Like_AspNetUsers_UserId",
                table: "Like",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Like_Pets_PetId",
                table: "Like",
                column: "PetId",
                principalTable: "Pets",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Like_AspNetUsers_UserId",
                table: "Like");

            migrationBuilder.DropForeignKey(
                name: "FK_Like_Pets_PetId",
                table: "Like");

            migrationBuilder.DropColumn(
                name: "Lattitude",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "Lattitude",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Addresses");

            migrationBuilder.AddForeignKey(
                name: "FK_Like_AspNetUsers_UserId",
                table: "Like",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Like_Pets_PetId",
                table: "Like",
                column: "PetId",
                principalTable: "Pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
