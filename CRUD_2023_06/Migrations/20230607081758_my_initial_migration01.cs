using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD_2023_06.Migrations
{
    public partial class my_initial_migration01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "myCRUD",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fruitname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fruitquantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_myCRUD", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "myCRUD");
        }
    }
}
