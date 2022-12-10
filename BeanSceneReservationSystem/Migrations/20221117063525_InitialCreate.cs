using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeanSceneReservationSystem.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reservation_User_ID_FK = table.Column<int>(type: "int", nullable: false),
                    Reservation_Sitting = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Reservation_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reservation_Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reservation_Duration = table.Column<int>(type: "int", nullable: false),
                    Reservation_NumOfGuests = table.Column<int>(type: "int", nullable: false),
                    Reservation_Area = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Reservation_TableNo = table.Column<int>(type: "int", nullable: false),
                    Reservation_Source = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reservation_Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reservation_Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
