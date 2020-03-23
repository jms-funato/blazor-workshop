using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazingPizza.Server.Migrations
{
    public partial class testdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Biography", "Name", "StateId" },
                values: new object[,]
                {
                    { 1, null, "Person 1", 1 },
                    { 74, null, "Person 74", 1 },
                    { 73, null, "Person 73", 1 },
                    { 72, null, "Person 72", 1 },
                    { 71, null, "Person 71", 1 },
                    { 70, null, "Person 70", 1 },
                    { 69, null, "Person 69", 1 },
                    { 68, null, "Person 68", 1 },
                    { 67, null, "Person 67", 1 },
                    { 75, null, "Person 75", 1 },
                    { 66, null, "Person 66", 1 },
                    { 64, null, "Person 64", 1 },
                    { 63, null, "Person 63", 1 },
                    { 62, null, "Person 62", 1 },
                    { 61, null, "Person 61", 1 },
                    { 60, null, "Person 60", 1 },
                    { 59, null, "Person 59", 1 },
                    { 58, null, "Person 58", 1 },
                    { 57, null, "Person 57", 1 },
                    { 65, null, "Person 65", 1 },
                    { 76, null, "Person 76", 1 },
                    { 77, null, "Person 77", 1 },
                    { 78, null, "Person 78", 1 },
                    { 97, null, "Person 97", 1 },
                    { 96, null, "Person 96", 1 },
                    { 95, null, "Person 95", 1 },
                    { 94, null, "Person 94", 1 },
                    { 93, null, "Person 93", 1 },
                    { 92, null, "Person 92", 1 },
                    { 91, null, "Person 91", 1 },
                    { 90, null, "Person 90", 1 },
                    { 89, null, "Person 89", 1 },
                    { 88, null, "Person 88", 1 },
                    { 87, null, "Person 87", 1 },
                    { 86, null, "Person 86", 1 },
                    { 85, null, "Person 85", 1 },
                    { 84, null, "Person 84", 1 },
                    { 83, null, "Person 83", 1 },
                    { 82, null, "Person 82", 1 },
                    { 81, null, "Person 81", 1 },
                    { 80, null, "Person 80", 1 },
                    { 79, null, "Person 79", 1 },
                    { 56, null, "Person 56", 1 },
                    { 55, null, "Person 55", 1 },
                    { 54, null, "Person 54", 1 },
                    { 53, null, "Person 53", 1 },
                    { 29, null, "Person 29", 1 },
                    { 28, null, "Person 28", 1 },
                    { 27, null, "Person 27", 1 },
                    { 26, null, "Person 26", 1 },
                    { 25, null, "Person 25", 1 },
                    { 24, null, "Person 24", 1 },
                    { 23, null, "Person 23", 1 },
                    { 22, null, "Person 22", 1 },
                    { 21, null, "Person 21", 1 },
                    { 20, null, "Person 20", 1 },
                    { 19, null, "Person 19", 1 },
                    { 18, null, "Person 18", 1 },
                    { 17, null, "Person 17", 1 },
                    { 16, null, "Person 16", 1 },
                    { 15, null, "Person 15", 1 },
                    { 5, null, "Person 5", 1 },
                    { 4, null, "Person 4", 1 },
                    { 3, null, "Person 3", 1 },
                    { 2, null, "Person 2", 1 },
                    { 30, null, "Person 30", 1 },
                    { 98, null, "Person 98", 1 },
                    { 31, null, "Person 31", 1 },
                    { 33, null, "Person 33", 1 },
                    { 52, null, "Person 52", 1 },
                    { 51, null, "Person 51", 1 },
                    { 50, null, "Person 50", 1 },
                    { 49, null, "Person 49", 1 },
                    { 48, null, "Person 48", 1 },
                    { 47, null, "Person 47", 1 },
                    { 46, null, "Person 46", 1 },
                    { 45, null, "Person 45", 1 },
                    { 44, null, "Person 44", 1 },
                    { 43, null, "Person 43", 1 },
                    { 42, null, "Person 42", 1 },
                    { 41, null, "Person 41", 1 },
                    { 40, null, "Person 40", 1 },
                    { 39, null, "Person 39", 1 },
                    { 38, null, "Person 38", 1 },
                    { 37, null, "Person 37", 1 },
                    { 36, null, "Person 36", 1 },
                    { 35, null, "Person 35", 1 },
                    { 34, null, "Person 34", 1 },
                    { 32, null, "Person 32", 1 },
                    { 99, null, "Person 99", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 99);
        }
    }
}
