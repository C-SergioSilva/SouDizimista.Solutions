using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SouDizimista.Repository.Migrations
{
    public partial class INICIO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Municipio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paroquia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cnpj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeParoco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RazaoSocial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeFantasia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paroquia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dizimista",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValorDevolucao = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EnderecoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dizimista", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dizimista_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SenhaUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnderecoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Capela",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdParoquia = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParoquiaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Capela", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Capela_Paroquia_ParoquiaId",
                        column: x => x.ParoquiaId,
                        principalTable: "Paroquia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Capela_ParoquiaId",
                table: "Capela",
                column: "ParoquiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Dizimista_EnderecoId",
                table: "Dizimista",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_EnderecoId",
                table: "Usuario",
                column: "EnderecoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Capela");

            migrationBuilder.DropTable(
                name: "Dizimista");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Paroquia");

            migrationBuilder.DropTable(
                name: "Endereco");
        }
    }
}
