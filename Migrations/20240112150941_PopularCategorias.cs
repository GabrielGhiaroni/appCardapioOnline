using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace appCardapioOnline.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
            "VALUES('Vegetariano', 'Lanches feitos a base de carne de soja.')"
            );

            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
            "VALUES('Carne Bovina', 'Lanches feitos com carnes de primeira linha.')"
            );

            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
            "VALUES('Natural', 'Lanches saudáveis para um dia mais leve.')"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
