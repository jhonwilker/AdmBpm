using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProAdm.API.Data.Migrations
{
    public partial class MigrationPrincipal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Policiais",
                columns: table => new
                {
                    PolicialId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    PostoGraduacao = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policiais", x => x.PolicialId);
                });

            migrationBuilder.CreateTable(
                name: "Viaturas",
                columns: table => new
                {
                    ViaturaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Prefixo = table.Column<string>(type: "TEXT", nullable: true),
                    Placa = table.Column<string>(type: "TEXT", nullable: true),
                    Odometro = table.Column<int>(type: "INTEGER", nullable: false),
                    TipoCombustivel = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viaturas", x => x.ViaturaId);
                });

            migrationBuilder.CreateTable(
                name: "Abastecimentos",
                columns: table => new
                {
                    AbastecimentoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ViaturaId = table.Column<int>(type: "INTEGER", nullable: true),
                    KmAbastecimento = table.Column<int>(type: "INTEGER", nullable: false),
                    LitrosAbastecimento = table.Column<float>(type: "REAL", nullable: false),
                    ValorAbastecimento = table.Column<float>(type: "REAL", nullable: false),
                    Data = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ResponsavelPolicialId = table.Column<int>(type: "INTEGER", nullable: true),
                    Convenio = table.Column<string>(type: "TEXT", nullable: true),
                    Saldo = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abastecimentos", x => x.AbastecimentoId);
                    table.ForeignKey(
                        name: "FK_Abastecimentos_Policiais_ResponsavelPolicialId",
                        column: x => x.ResponsavelPolicialId,
                        principalTable: "Policiais",
                        principalColumn: "PolicialId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Abastecimentos_Viaturas_ViaturaId",
                        column: x => x.ViaturaId,
                        principalTable: "Viaturas",
                        principalColumn: "ViaturaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Abastecimentos_ResponsavelPolicialId",
                table: "Abastecimentos",
                column: "ResponsavelPolicialId");

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
                name: "Policiais");

            migrationBuilder.DropTable(
                name: "Viaturas");
        }
    }
}
