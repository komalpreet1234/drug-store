using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DrugStoreManagement.Migrations
{
    public partial class us : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BrandID",
                table: "Drugs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    BrandID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BrandName = table.Column<string>(nullable: true),
                    details = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.BrandID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Drugs_BrandID",
                table: "Drugs",
                column: "BrandID");

            migrationBuilder.AddForeignKey(
                name: "FK_Drugs_Brand_BrandID",
                table: "Drugs",
                column: "BrandID",
                principalTable: "Brand",
                principalColumn: "BrandID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drugs_Brand_BrandID",
                table: "Drugs");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropIndex(
                name: "IX_Drugs_BrandID",
                table: "Drugs");

            migrationBuilder.DropColumn(
                name: "BrandID",
                table: "Drugs");
        }
    }
}
