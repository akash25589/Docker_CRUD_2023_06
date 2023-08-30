using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD_2023_06.Migrations
{
    public partial class my_initial_fruits05 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fruits_details",
                columns: table => new
                {
                    FruitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FruitName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fruits_details", x => x.FruitId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fruits_details");
        }
    }
}
