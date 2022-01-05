using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APIES.Migrations
{
    public partial class criteria5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BackgroundImageUrl",
                table: "MobileRND_UserFeedbackCriteria");

            migrationBuilder.DropColumn(
                name: "IconUrl",
                table: "MobileRND_UserFeedbackCriteria");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "MobileRND_UserFeedbackCriteria",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MobileRND_ModelWiseCriteria",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ModelID = table.Column<string>(maxLength: 150, nullable: false),
                    CriteriaID = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    LUser = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileRND_ModelWiseCriteria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MobileRND_ModelWiseCriteria_MobileRND_UserFeedbackCriteria_CriteriaID",
                        column: x => x.CriteriaID,
                        principalTable: "MobileRND_UserFeedbackCriteria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MobileRND_ModelWiseCriteria_CriteriaID",
                table: "MobileRND_ModelWiseCriteria",
                column: "CriteriaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MobileRND_ModelWiseCriteria");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "MobileRND_UserFeedbackCriteria");

            migrationBuilder.AddColumn<string>(
                name: "BackgroundImageUrl",
                table: "MobileRND_UserFeedbackCriteria",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IconUrl",
                table: "MobileRND_UserFeedbackCriteria",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
