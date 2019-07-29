using Microsoft.EntityFrameworkCore.Migrations;

namespace yuvap.Migrations
{
    public partial class InitialCreateYP1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boy",
                columns: table => new
                {
                    BoyID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    MobileNum = table.Column<string>(nullable: true),
                    Pref1 = table.Column<int>(nullable: true),
                    Pref2 = table.Column<int>(nullable: true),
                    Pref3 = table.Column<int>(nullable: true),
                    Pref4 = table.Column<int>(nullable: true),
                    Pref5 = table.Column<int>(nullable: true),
                    Pref6 = table.Column<int>(nullable: true),
                    Pref7 = table.Column<int>(nullable: true),
                    Pref8 = table.Column<int>(nullable: true),
                    BoyLikedByConcat = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boy", x => x.BoyID);
                });

            migrationBuilder.CreateTable(
                name: "BoyLikedBy",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BoyID = table.Column<int>(nullable: false),
                    GirlID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoyLikedBy", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Girl",
                columns: table => new
                {
                    GirlID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    MobileNum = table.Column<string>(nullable: true),
                    Pref1 = table.Column<int>(nullable: true),
                    Pref2 = table.Column<int>(nullable: true),
                    Pref3 = table.Column<int>(nullable: true),
                    Pref4 = table.Column<int>(nullable: true),
                    Pref5 = table.Column<int>(nullable: true),
                    Pref6 = table.Column<int>(nullable: true),
                    Pref7 = table.Column<int>(nullable: true),
                    Pref8 = table.Column<int>(nullable: true),
                    GirlLikedByConcat = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Girl", x => x.GirlID);
                });

            migrationBuilder.CreateTable(
                name: "GirlLikedBy",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GirlID = table.Column<int>(nullable: false),
                    BoyID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GirlLikedBy", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Boy_BoyID",
                table: "Boy",
                column: "BoyID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Girl_GirlID",
                table: "Girl",
                column: "GirlID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boy");

            migrationBuilder.DropTable(
                name: "BoyLikedBy");

            migrationBuilder.DropTable(
                name: "Girl");

            migrationBuilder.DropTable(
                name: "GirlLikedBy");
        }
    }
}
