using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProektDbContext.Migrations
{
    public partial class Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id_Student",
                table: "Universities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_Student",
                table: "Schools",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_Student",
                table: "Universities");

            migrationBuilder.DropColumn(
                name: "Id_Student",
                table: "Schools");
        }
    }
}
