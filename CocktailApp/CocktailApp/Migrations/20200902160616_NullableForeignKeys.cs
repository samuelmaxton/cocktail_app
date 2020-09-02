using Microsoft.EntityFrameworkCore.Migrations;

namespace CocktailApp.Migrations
{
    public partial class NullableForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cocktails_FortifiedWines_FortifiedWineId",
                table: "Cocktails");

            migrationBuilder.DropForeignKey(
                name: "FK_Cocktails_Spirits_SpiritId",
                table: "Cocktails");

            migrationBuilder.AlterColumn<int>(
                name: "SpiritId",
                table: "Cocktails",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FortifiedWineId",
                table: "Cocktails",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Cocktails_FortifiedWines_FortifiedWineId",
                table: "Cocktails",
                column: "FortifiedWineId",
                principalTable: "FortifiedWines",
                principalColumn: "FortifiedWineId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cocktails_Spirits_SpiritId",
                table: "Cocktails",
                column: "SpiritId",
                principalTable: "Spirits",
                principalColumn: "SpiritId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cocktails_FortifiedWines_FortifiedWineId",
                table: "Cocktails");

            migrationBuilder.DropForeignKey(
                name: "FK_Cocktails_Spirits_SpiritId",
                table: "Cocktails");

            migrationBuilder.AlterColumn<int>(
                name: "SpiritId",
                table: "Cocktails",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FortifiedWineId",
                table: "Cocktails",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cocktails_FortifiedWines_FortifiedWineId",
                table: "Cocktails",
                column: "FortifiedWineId",
                principalTable: "FortifiedWines",
                principalColumn: "FortifiedWineId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cocktails_Spirits_SpiritId",
                table: "Cocktails",
                column: "SpiritId",
                principalTable: "Spirits",
                principalColumn: "SpiritId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
