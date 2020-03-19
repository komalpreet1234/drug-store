using Microsoft.EntityFrameworkCore.Migrations;

namespace DrugStoreManagement.Migrations
{
    public partial class newmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "details",
                table: "Brand",
                newName: "Details");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Details",
                table: "Brand",
                newName: "details");
        }
    }
}
