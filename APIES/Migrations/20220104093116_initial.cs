using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APIES.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MobileRND_SalesChannel",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IEMI = table.Column<string>(maxLength: 150, nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    LUser = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileRND_SalesChannel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MobileRND_SalesChannel");
        }
    }
}
