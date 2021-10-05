using Microsoft.EntityFrameworkCore.Migrations;

namespace Code1st.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Teams_TeamName1",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_TeamName1",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "TeamName1",
                table: "Players");

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamName",
                table: "Players",
                column: "TeamName");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Teams_TeamName",
                table: "Players",
                column: "TeamName",
                principalTable: "Teams",
                principalColumn: "TeamName",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Teams_TeamName",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_TeamName",
                table: "Players");

            migrationBuilder.AddColumn<string>(
                name: "TeamName1",
                table: "Players",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamName1",
                table: "Players",
                column: "TeamName1");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Teams_TeamName1",
                table: "Players",
                column: "TeamName1",
                principalTable: "Teams",
                principalColumn: "TeamName",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
