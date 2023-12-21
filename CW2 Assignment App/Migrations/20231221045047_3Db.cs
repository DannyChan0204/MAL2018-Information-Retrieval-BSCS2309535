using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CW2_Assignment_App.Migrations
{
    /// <inheritdoc />
    public partial class _3Db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Badges",
                schema: "CW2",
                columns: table => new
                {
                    BadgesID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    profileID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    badgeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateGained = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Badges", x => x.BadgesID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Badges",
                schema: "CW2");
        }
    }
}
