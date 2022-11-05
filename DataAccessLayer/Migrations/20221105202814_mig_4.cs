using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MovieExtraID",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CategoryID",
                table: "Movies",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_MovieExtraID",
                table: "Movies",
                column: "MovieExtraID");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Categories_CategoryID",
                table: "Movies",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_MovieExtras_MovieExtraID",
                table: "Movies",
                column: "MovieExtraID",
                principalTable: "MovieExtras",
                principalColumn: "MovieExtraID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Categories_CategoryID",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_MovieExtras_MovieExtraID",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_CategoryID",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_MovieExtraID",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieExtraID",
                table: "Movies");
        }
    }
}
