using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CW2_Assignment_App.Migrations
{
    /// <inheritdoc />
    public partial class _2ndDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.CreateTable(
                name: "Profile",
                schema: "CW2",
                columns: table => new
                {
                    profileID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    userID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    age = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    registerDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    archivedStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => x.profileID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profile",
                schema: "CW2");

        }
    }
}
