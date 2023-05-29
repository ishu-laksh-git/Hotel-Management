using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Migrations
{
    public partial class plz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Hotels_HotelID",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "HotelID",
                table: "Rooms",
                newName: "HotelId");

            migrationBuilder.RenameColumn(
                name: "Hotel_Id",
                table: "Rooms",
                newName: "HotelID");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_HotelID",
                table: "Rooms",
                newName: "IX_Rooms_HotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Hotels_HotelId",
                table: "Rooms",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "HotelID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Hotels_HotelId",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "HotelId",
                table: "Rooms",
                newName: "HotelID");

            migrationBuilder.RenameColumn(
                name: "HotelID",
                table: "Rooms",
                newName: "Hotel_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_HotelId",
                table: "Rooms",
                newName: "IX_Rooms_HotelID");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Hotels_HotelID",
                table: "Rooms",
                column: "HotelID",
                principalTable: "Hotels",
                principalColumn: "HotelID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
