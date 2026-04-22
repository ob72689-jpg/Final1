using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavoriteReds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<int>(type: "int", nullable: true),
                    ThrowHand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BatHand = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteReds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MyInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Program = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgramYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FavoriteMajor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FavoriteElective = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyInfos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FavoriteReds",
                columns: new[] { "Id", "BatHand", "Name", "Number", "Position", "ThrowHand" },
                values: new object[] { 1, "Left", "Votto", 19, "First Base", "Left" });

            migrationBuilder.InsertData(
                table: "MyInfos",
                columns: new[] { "Id", "FavoriteElective", "FavoriteMajor", "Name", "Program", "ProgramYear" },
                values: new object[] { 1, "Astronomy", "Contemporary Programing", "Aaron O'Brien", "IT", "Sophmore" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteReds");

            migrationBuilder.DropTable(
                name: "MyInfos");
        }
    }
}
