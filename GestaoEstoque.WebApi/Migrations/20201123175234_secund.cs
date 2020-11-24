using Microsoft.EntityFrameworkCore.Migrations;

namespace GestaoEstoque.WebApi.Migrations
{
    public partial class secund : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendas_Fornecedores_FornecedorId",
                table: "Agendas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fornecedores",
                table: "Fornecedores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Agendas",
                table: "Agendas");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "Usuario");

            migrationBuilder.RenameTable(
                name: "Fornecedores",
                newName: "Fornecedor");

            migrationBuilder.RenameTable(
                name: "Agendas",
                newName: "Agenda");

            migrationBuilder.RenameIndex(
                name: "IX_Agendas_FornecedorId",
                table: "Agenda",
                newName: "IX_Agenda_FornecedorId");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Vaga",
                table: "Agenda",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fornecedor",
                table: "Fornecedor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Agenda",
                table: "Agenda",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Agenda_Fornecedor_FornecedorId",
                table: "Agenda",
                column: "FornecedorId",
                principalTable: "Fornecedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agenda_Fornecedor_FornecedorId",
                table: "Agenda");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fornecedor",
                table: "Fornecedor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Agenda",
                table: "Agenda");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Vaga",
                table: "Agenda");

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Fornecedor",
                newName: "Fornecedores");

            migrationBuilder.RenameTable(
                name: "Agenda",
                newName: "Agendas");

            migrationBuilder.RenameIndex(
                name: "IX_Agenda_FornecedorId",
                table: "Agendas",
                newName: "IX_Agendas_FornecedorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fornecedores",
                table: "Fornecedores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Agendas",
                table: "Agendas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendas_Fornecedores_FornecedorId",
                table: "Agendas",
                column: "FornecedorId",
                principalTable: "Fornecedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
