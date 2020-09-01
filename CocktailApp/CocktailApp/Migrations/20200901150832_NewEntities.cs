using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CocktailApp.Migrations
{
    public partial class NewEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bitters",
                columns: table => new
                {
                    BittersId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Abv = table.Column<decimal>(nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bitters", x => x.BittersId);
                });

            migrationBuilder.CreateTable(
                name: "FortifiedWines",
                columns: table => new
                {
                    FortifiedWineId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Abv = table.Column<decimal>(nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FortifiedWines", x => x.FortifiedWineId);
                });

            migrationBuilder.CreateTable(
                name: "Spirits",
                columns: table => new
                {
                    SpiritId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Abv = table.Column<decimal>(nullable: false),
                    Category = table.Column<string>(nullable: true),
                    IsOverproof = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spirits", x => x.SpiritId);
                });

            migrationBuilder.CreateTable(
                name: "Cocktails",
                columns: table => new
                {
                    CocktailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Recipe = table.Column<string>(nullable: true),
                    Origin = table.Column<DateTime>(nullable: false),
                    FortifiedWineId = table.Column<int>(nullable: false),
                    SpiritId = table.Column<int>(nullable: false),
                    BittersId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cocktails", x => x.CocktailId);
                    table.ForeignKey(
                        name: "FK_Cocktails_Bitters_BittersId",
                        column: x => x.BittersId,
                        principalTable: "Bitters",
                        principalColumn: "BittersId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cocktails_FortifiedWines_FortifiedWineId",
                        column: x => x.FortifiedWineId,
                        principalTable: "FortifiedWines",
                        principalColumn: "FortifiedWineId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cocktails_Spirits_SpiritId",
                        column: x => x.SpiritId,
                        principalTable: "Spirits",
                        principalColumn: "SpiritId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cocktails_BittersId",
                table: "Cocktails",
                column: "BittersId");

            migrationBuilder.CreateIndex(
                name: "IX_Cocktails_FortifiedWineId",
                table: "Cocktails",
                column: "FortifiedWineId");

            migrationBuilder.CreateIndex(
                name: "IX_Cocktails_SpiritId",
                table: "Cocktails",
                column: "SpiritId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cocktails");

            migrationBuilder.DropTable(
                name: "Bitters");

            migrationBuilder.DropTable(
                name: "FortifiedWines");

            migrationBuilder.DropTable(
                name: "Spirits");
        }
    }
}
