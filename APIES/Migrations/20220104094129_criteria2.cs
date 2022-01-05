using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APIES.Migrations
{
    public partial class criteria2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MobileRND_UserFeedbackCriteria",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CriteriaNameEnglish = table.Column<string>(maxLength: 150, nullable: false),
                    CriteriaNameBangla = table.Column<string>(maxLength: 150, nullable: false),
                    ModelID = table.Column<string>(maxLength: 150, nullable: false),
                    ModelName = table.Column<string>(maxLength: 150, nullable: false),
                    BackgroundImageUrl = table.Column<string>(maxLength: 150, nullable: false),
                    IconUrl = table.Column<string>(maxLength: 150, nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    LUser = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileRND_UserFeedbackCriteria", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MobileRND_UserFeedbackCriteria");
        }
    }
}
