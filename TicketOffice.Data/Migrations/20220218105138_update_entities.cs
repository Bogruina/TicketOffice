using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketOffice.Data.Migrations
{
    public partial class update_entities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FlightId",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "PlaneId",
                table: "Flights",
                newName: "TicketId");

            migrationBuilder.AddColumn<int>(
                name: "FlightId",
                table: "Planes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Planes_FlightId",
                table: "Planes",
                column: "FlightId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Flights_TicketId",
                table: "Flights",
                column: "TicketId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Tickets_TicketId",
                table: "Flights",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Planes_Flights_FlightId",
                table: "Planes",
                column: "FlightId",
                principalTable: "Flights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Tickets_TicketId",
                table: "Flights");

            migrationBuilder.DropForeignKey(
                name: "FK_Planes_Flights_FlightId",
                table: "Planes");

            migrationBuilder.DropIndex(
                name: "IX_Planes_FlightId",
                table: "Planes");

            migrationBuilder.DropIndex(
                name: "IX_Flights_TicketId",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "FlightId",
                table: "Planes");

            migrationBuilder.RenameColumn(
                name: "TicketId",
                table: "Flights",
                newName: "PlaneId");

            migrationBuilder.AddColumn<int>(
                name: "FlightId",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
