using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bandymas_SQL_C_.Migrations
{
    public partial class TableCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TournamentTableId",
                table: "Persons",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tables", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_TournamentTableId",
                table: "Persons",
                column: "TournamentTableId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Tables_TournamentTableId",
                table: "Persons",
                column: "TournamentTableId",
                principalTable: "Tables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Tables_TournamentTableId",
                table: "Persons");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DropIndex(
                name: "IX_Persons_TournamentTableId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "TournamentTableId",
                table: "Persons");
        }
    }
}
