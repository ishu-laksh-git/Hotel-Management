using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Migrations
{
    public partial class mudla : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Hotels_HotelsHotelId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_HotelsHotelId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "HotelsHotelId",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "Amenity",
                table: "Hotels",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "HotelId",
                table: "Hotels",
                newName: "H_id");

            migrationBuilder.AddColumn<string>(
                name: "Amenities",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_H_id",
                table: "Rooms",
                column: "H_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Hotels_H_id",
                table: "Rooms",
                column: "H_id",
                principalTable: "Hotels",
                principalColumn: "H_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Hotels_H_id",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_H_id",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Amenities",
                table: "Hotels");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Hotels",
                newName: "Amenity");

            migrationBuilder.RenameColumn(
                name: "H_id",
                table: "Hotels",
                newName: "HotelId");

            migrationBuilder.AddColumn<int>(
                name: "HotelsHotelId",
                table: "Rooms",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_HotelsHotelId",
                table: "Rooms",
                column: "HotelsHotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Hotels_HotelsHotelId",
                table: "Rooms",
                column: "HotelsHotelId",
                principalTable: "Hotels",
                principalColumn: "HotelId");
        }
    }
}
