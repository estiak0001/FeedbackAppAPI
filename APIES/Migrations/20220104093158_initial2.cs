using Microsoft.EntityFrameworkCore.Migrations;

namespace APIES.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MobileRND_SalesChannel",
                table: "MobileRND_SalesChannel");

            migrationBuilder.RenameTable(
                name: "MobileRND_SalesChannel",
                newName: "MobileRND_UserFeedback");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MobileRND_UserFeedback",
                table: "MobileRND_UserFeedback",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MobileRND_UserFeedback",
                table: "MobileRND_UserFeedback");

            migrationBuilder.RenameTable(
                name: "MobileRND_UserFeedback",
                newName: "MobileRND_SalesChannel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MobileRND_SalesChannel",
                table: "MobileRND_SalesChannel",
                column: "Id");
        }
    }
}
