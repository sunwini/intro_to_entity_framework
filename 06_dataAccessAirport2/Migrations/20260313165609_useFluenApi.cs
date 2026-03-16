using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace intro_to_entity_framework.Migrations
{
    /// <inheritdoc />
    public partial class useFluenApi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Passangers",
                newName: "Firstname");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Firstname",
                table: "Passangers",
                newName: "FirstName");
        }
    }
}
