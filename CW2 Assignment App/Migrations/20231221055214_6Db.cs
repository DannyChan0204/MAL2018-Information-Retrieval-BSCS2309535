using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CW2_Assignment_App.Migrations
{
    /// <inheritdoc />
    public partial class _6Db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                schema: "CW2",
                columns: table => new
                {
                    CommentsID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrailID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfileID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentsID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments",
                schema: "CW2");
        }
    }
}
