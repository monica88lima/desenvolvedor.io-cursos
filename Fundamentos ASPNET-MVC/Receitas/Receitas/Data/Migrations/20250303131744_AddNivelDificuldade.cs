using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Receitas.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNivelDificuldade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NivelDificuldade",
                table: "Receita",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NivelDificuldade",
                table: "Receita");
        }
    }
}
