using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace intro_to_entity_framework.Migrations
{
    /// <inheritdoc />
    public partial class AddMaxCountPassengers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaxCountPassengers",
                table: "Airplanes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Airplanes",
                keyColumn: "Id",
                keyValue: 1,
                column: "MaxCountPassengers",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Airplanes",
                keyColumn: "Id",
                keyValue: 2,
                column: "MaxCountPassengers",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Airplanes",
                keyColumn: "Id",
                keyValue: 3,
                column: "MaxCountPassengers",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Airplanes",
                keyColumn: "Id",
                keyValue: 4,
                column: "MaxCountPassengers",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Airplanes",
                keyColumn: "Id",
                keyValue: 5,
                column: "MaxCountPassengers",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxCountPassengers",
                table: "Airplanes");
        }
    }
}
