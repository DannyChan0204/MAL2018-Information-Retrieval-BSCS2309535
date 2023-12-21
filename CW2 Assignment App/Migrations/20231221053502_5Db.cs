using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CW2_Assignment_App.Migrations
{
    /// <inheritdoc />
    public partial class _5Db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Leaderboard",
                schema: "CW2",
                columns: table => new
                {
                    LeaderboardID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrailID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfileID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FriendsRanking = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GlobalRanking = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeTaken = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leaderboard", x => x.LeaderboardID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Leaderboard",
                schema: "CW2");
        }
    }
}
