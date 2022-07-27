using Microsoft.EntityFrameworkCore.Migrations;

namespace ProAdm.API.Data.Migrations
{
    public partial class AlteraçãoAbastecimento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Data",
                table: "Abastecimentos",
                newName: "DataAbastecimento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataAbastecimento",
                table: "Abastecimentos",
                newName: "Data");
        }
    }
}
