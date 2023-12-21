using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CW2_Assignment_App.Migrations
{
    /// <inheritdoc />
    public partial class _4Db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trail",
                schema: "CW2",
                columns: table => new
                {
                    TrailID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrailName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trail", x => x.TrailID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trail",
                schema: "CW2");
        }
    }
}
