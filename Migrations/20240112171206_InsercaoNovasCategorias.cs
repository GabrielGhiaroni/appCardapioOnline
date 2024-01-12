using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace appCardapioOnline.Migrations
{
    /// <inheritdoc />
    public partial class InsercaoNovasCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
            "VALUES('Pizzas', 'Pizzas premiadas de diversos sabores.')"
            );

            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
            "VALUES('Doces', 'Sobremesas deliciosas para adoçar seu dia.')"
            );

            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
            "VALUES('Bebidas', 'Bebidas diversificadas para refrescar o seu dia.')"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
