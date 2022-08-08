using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCControlStation.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FaultControl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Week = table.Column<int>(nullable: false),
                    StopOperacao = table.Column<DateTime>(nullable: false),
                    ActivEnginer = table.Column<DateTime>(nullable: false),
                    StartService = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaultControl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Station",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NameStation = table.Column<int>(nullable: false),
                    FaultControlId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Station", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Station_FaultControl_FaultControlId",
                        column: x => x.FaultControlId,
                        principalTable: "FaultControl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TestTecnian",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    FaultControlId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestTecnian", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestTecnian_FaultControl_FaultControlId",
                        column: x => x.FaultControlId,
                        principalTable: "FaultControl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Station_FaultControlId",
                table: "Station",
                column: "FaultControlId");

            migrationBuilder.CreateIndex(
                name: "IX_TestTecnian_FaultControlId",
                table: "TestTecnian",
                column: "FaultControlId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Station");

            migrationBuilder.DropTable(
                name: "TestTecnian");

            migrationBuilder.DropTable(
                name: "FaultControl");
        }
    }
}
