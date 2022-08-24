using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProAdm.Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Servidores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    PostoGraduacao = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servidores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Viaturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Prefixo = table.Column<string>(type: "TEXT", nullable: true),
                    Placa = table.Column<string>(type: "TEXT", nullable: true),
                    Odometro = table.Column<int>(type: "INTEGER", nullable: false),
                    TipoCombustivel = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viaturas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Abastecimentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ViaturaId = table.Column<int>(type: "INTEGER", nullable: true),
                    KmAbastecimento = table.Column<int>(type: "INTEGER", nullable: false),
                    LitrosAbastecimento = table.Column<float>(type: "REAL", nullable: false),
                    ValorAbastecimento = table.Column<float>(type: "REAL", nullable: false),
                    DataAbastecimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ResponsavelId = table.Column<int>(type: "INTEGER", nullable: true),
                    Convenio = table.Column<string>(type: "TEXT", nullable: true),
                    Saldo = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abastecimentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Abastecimentos_Servidores_ResponsavelId",
                        column: x => x.ResponsavelId,
                        principalTable: "Servidores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Abastecimentos_Viaturas_ViaturaId",
                        column: x => x.ViaturaId,
                        principalTable: "Viaturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Abastecimentos_ResponsavelId",
                table: "Abastecimentos",
                column: "ResponsavelId");

            migrationBuilder.CreateIndex(
                name: "IX_Abastecimentos_ViaturaId",
                table: "Abastecimentos",
                column: "ViaturaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abastecimentos");

            migrationBuilder.DropTable(
                name: "Servidores");

            migrationBuilder.DropTable(
                name: "Viaturas");
        }
    }
}
