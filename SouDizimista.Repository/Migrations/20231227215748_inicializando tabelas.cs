using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SouDizimista.Repository.Migrations
{
    public partial class inicializandotabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "EnderecoId",
                table: "Paroquia",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Paroquia_EnderecoId",
                table: "Paroquia",
                column: "EnderecoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Paroquia_Endereco_EnderecoId",
                table: "Paroquia",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paroquia_Endereco_EnderecoId",
                table: "Paroquia");

            migrationBuilder.DropIndex(
                name: "IX_Paroquia_EnderecoId",
                table: "Paroquia");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Paroquia");
        }
    }
}
