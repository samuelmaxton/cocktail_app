using Microsoft.EntityFrameworkCore.Migrations;

namespace CocktailApp.Migrations
{
    public partial class CocktailBittersManyToManyExample : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cocktails_Bitters_BittersId",
                table: "Cocktails");

            migrationBuilder.DropIndex(
                name: "IX_Cocktails_BittersId",
                table: "Cocktails");

            migrationBuilder.DropColumn(
                name: "BittersId",
                table: "Cocktails");

            migrationBuilder.CreateTable(
                name: "CocktailBitters",
                columns: table => new
                {
                    CocktailId = table.Column<int>(nullable: false),
                    BittersId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CocktailBitters", x => new { x.CocktailId, x.BittersId });
                    table.ForeignKey(
                        name: "FK_CocktailBitters_Bitters_BittersId",
                        column: x => x.BittersId,
                        principalTable: "Bitters",
                        principalColumn: "BittersId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CocktailBitters_Cocktails_CocktailId",
                        column: x => x.CocktailId,
                        principalTable: "Cocktails",
                        principalColumn: "CocktailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CocktailBitters_BittersId",
                table: "CocktailBitters",
                column: "BittersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CocktailBitters");

            migrationBuilder.AddColumn<int>(
                name: "BittersId",
                table: "Cocktails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cocktails_BittersId",
                table: "Cocktails",
                column: "BittersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cocktails_Bitters_BittersId",
                table: "Cocktails",
                column: "BittersId",
                principalTable: "Bitters",
                principalColumn: "BittersId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
