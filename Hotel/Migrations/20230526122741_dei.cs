using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Migrations
{
    public partial class dei : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Hotels_HostelId",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "HostelId",
                table: "Rooms",
                newName: "HotelsHotelId");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_HostelId",
                table: "Rooms",
                newName: "IX_Rooms_HotelsHotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Hotels_HotelsHotelId",
                table: "Rooms",
                column: "HotelsHotelId",
                principalTable: "Hotels",
                principalColumn: "HotelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Hotels_HotelsHotelId",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "HotelsHotelId",
                table: "Rooms",
                newName: "HostelId");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_HotelsHotelId",
                table: "Rooms",
                newName: "IX_Rooms_HostelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Hotels_HostelId",
                table: "Rooms",
                column: "HostelId",
                principalTable: "Hotels",
                principalColumn: "HotelId");
        }
    }
}
