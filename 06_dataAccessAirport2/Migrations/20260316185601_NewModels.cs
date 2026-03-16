using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace intro_to_entity_framework.Migrations
{
    /// <inheritdoc />
    public partial class NewModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityID",
                table: "Flights",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AirplaneTypeID",
                table: "Airplanes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AirplaneTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TYPE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AirplaneID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirplaneTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CountryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Countries",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AirplaneTypes",
                columns: new[] { "ID", "AirplaneID", "TYPE" },
                values: new object[,]
                {
                    { 1, 1, "Passanger plane" },
                    { 2, 2, "Cargo" }
                });

            migrationBuilder.UpdateData(
                table: "Airplanes",
                keyColumn: "Id",
                keyValue: 1,
                column: "AirplaneTypeID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Airplanes",
                keyColumn: "Id",
                keyValue: 2,
                column: "AirplaneTypeID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Airplanes",
                keyColumn: "Id",
                keyValue: 3,
                column: "AirplaneTypeID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Airplanes",
                keyColumn: "Id",
                keyValue: 4,
                column: "AirplaneTypeID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Airplanes",
                keyColumn: "Id",
                keyValue: 5,
                column: "AirplaneTypeID",
                value: 1);

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "NAME" },
                values: new object[,]
                {
                    { 1, "Ukraine" },
                    { 2, "Poland" },
                    { 3, "Germany" }
                });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Number",
                keyValue: 1,
                column: "CityID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Number",
                keyValue: 2,
                column: "CityID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Number",
                keyValue: 3,
                column: "CityID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Number",
                keyValue: 4,
                column: "CityID",
                value: 2);

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "ID", "CountryID", "NAME" },
                values: new object[,]
                {
                    { 1, 1, "Kyiv" },
                    { 2, 1, "Lviv" },
                    { 3, 1, "Uzhorod" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Flights_CityID",
                table: "Flights",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Airplanes_AirplaneTypeID",
                table: "Airplanes",
                column: "AirplaneTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryID",
                table: "Cities",
                column: "CountryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Airplanes_AirplaneTypes_AirplaneTypeID",
                table: "Airplanes",
                column: "AirplaneTypeID",
                principalTable: "AirplaneTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Cities_CityID",
                table: "Flights",
                column: "CityID",
                principalTable: "Cities",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Airplanes_AirplaneTypes_AirplaneTypeID",
                table: "Airplanes");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Cities_CityID",
                table: "Flights");

            migrationBuilder.DropTable(
                name: "AirplaneTypes");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Flights_CityID",
                table: "Flights");

            migrationBuilder.DropIndex(
                name: "IX_Airplanes_AirplaneTypeID",
                table: "Airplanes");

            migrationBuilder.DropColumn(
                name: "CityID",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "AirplaneTypeID",
                table: "Airplanes");
        }
    }
}
