using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PNRT.Server.Migrations
{
    public partial class Soluction01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clubs_Riders_RiderId",
                table: "Clubs");

            migrationBuilder.DropIndex(
                name: "IX_Clubs_RiderId",
                table: "Clubs");

            migrationBuilder.DropColumn(
                name: "RiderId",
                table: "Clubs");

            migrationBuilder.AddColumn<int>(
                name: "ClubId",
                table: "Riders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Riders_ClubId",
                table: "Riders",
                column: "ClubId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Riders_Clubs_ClubId",
                table: "Riders",
                column: "ClubId",
                principalTable: "Clubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Riders_Clubs_ClubId",
                table: "Riders");

            migrationBuilder.DropIndex(
                name: "IX_Riders_ClubId",
                table: "Riders");

            migrationBuilder.DropColumn(
                name: "ClubId",
                table: "Riders");

            migrationBuilder.AddColumn<int>(
                name: "RiderId",
                table: "Clubs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_RiderId",
                table: "Clubs",
                column: "RiderId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Clubs_Riders_RiderId",
                table: "Clubs",
                column: "RiderId",
                principalTable: "Riders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
