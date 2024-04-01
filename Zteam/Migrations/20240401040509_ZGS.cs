using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zteam.Migrations
{
    /// <inheritdoc />
    public partial class ZGS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuyDtl");

            migrationBuilder.DropTable(
                name: "Buyings");

            migrationBuilder.DropTable(
                name: "Duty");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BuyDtl",
                columns: table => new
                {
                    BuyId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BdtlPrice = table.Column<double>(type: "float", nullable: true),
                    BdtlQty = table.Column<double>(type: "float", nullable: true),
                    GameId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuyDtl", x => x.BuyId);
                });

            migrationBuilder.CreateTable(
                name: "Buyings",
                columns: table => new
                {
                    BuyId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BuyDate = table.Column<DateOnly>(type: "date", nullable: true),
                    BuyDocId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyQty = table.Column<double>(type: "float", nullable: true),
                    DeveloperName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DevoperId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StfId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buyings", x => x.BuyId);
                });

            migrationBuilder.CreateTable(
                name: "Duty",
                columns: table => new
                {
                    DutyId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DutyName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Duty", x => x.DutyId);
                });
        }
    }
}
