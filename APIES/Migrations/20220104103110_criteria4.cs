using Microsoft.EntityFrameworkCore.Migrations;

namespace APIES.Migrations
{
    public partial class criteria4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModelID",
                table: "MobileRND_UserFeedbackCriteria");

            migrationBuilder.DropColumn(
                name: "ModelName",
                table: "MobileRND_UserFeedbackCriteria");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ModelID",
                table: "MobileRND_UserFeedbackCriteria",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModelName",
                table: "MobileRND_UserFeedbackCriteria",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");
        }
    }
}
