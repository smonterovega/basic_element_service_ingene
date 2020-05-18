using Microsoft.EntityFrameworkCore.Migrations;

namespace basic_element_structure_service.Migrations
{
    public partial class TableColumnNameChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxNumberOfBound",
                table: "Elements");

            migrationBuilder.AddColumn<int>(
                name: "MaxNumberOfBond",
                table: "Elements",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxNumberOfBond",
                table: "Elements");

            migrationBuilder.AddColumn<int>(
                name: "MaxNumberOfBound",
                table: "Elements",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
