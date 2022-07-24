using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProAdm.API.Data.Migrations
{
    public partial class Segundo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abastecimentos",
                columns: table => new
                {
                    AbastecimentoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Viatura = table.Column<int>(type: "INTEGER", nullable: false),
                    KmViatura = table.Column<int>(type: "INTEGER", nullable: false),
                    Litros = table.Column<int>(type: "INTEGER", nullable: false),
                    Valor = table.Column<int>(type: "INTEGER", nullable: false),
                    Data = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Responsavel = table.Column<int>(type: "INTEGER", nullable: false),
                    Convenio = table.Column<string>(type: "TEXT", nullable: true),
                    Saldo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abastecimentos", x => x.AbastecimentoId);
                });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abastecimentos");

            migrationBuilder.DropTable(
                name: "Policiais");
        }
    }
}
