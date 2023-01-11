using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PNRT.Server.Migrations
{
    public partial class Soluction02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Riders_ClubId",
                table: "Riders");

            migrationBuilder.CreateIndex(
                name: "IX_Riders_ClubId",
                table: "Riders",
                column: "ClubId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Riders_ClubId",
                table: "Riders");

            migrationBuilder.CreateIndex(
                name: "IX_Riders_ClubId",
                table: "Riders",
                column: "ClubId",
                unique: true);
        }
    }
}
