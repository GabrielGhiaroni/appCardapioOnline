using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace appCardapioOnline.Migrations
{
    /// <inheritdoc />
    public partial class PopularLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemURL, ImagemThumbnailURL, IsLanchePreferido, EmEstoque, CategoriaId) " +
            "VALUES('Cheddar Bacon', 'Carne tipo Angus com Cheddar.', 'Pão tostado na brasa, duas carnes tipo Angus, bacon e muito cheddar.', '38.99', 'https://img.cybercook.com.br/receitas/107/hamburguer-com-bacon-queijo-cheddar-e-molho-barbecue.jpeg', 'https://portal.lodivino.com.br/images/receitas/molho-de-cheddar.jpg', 0, 1, 2)"
            );

            migrationBuilder.Sql("INSERT INTO Lanches(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemURL, ImagemThumbnailURL, IsLanchePreferido, EmEstoque, CategoriaId) " +
            "VALUES('Chicken Light', 'Natural de Frango com Catupiry Light.', 'Pão de forma integral, Catupiry light original e frango desfiado.', '24.99', 'https://specialepaes.com/wp-content/uploads/2021/10/blog-speciale-receita.png', 'https://i0.wp.com/porkworld.com.br/wp-content/uploads/2022/07/recheio-de-frango-cremoso-para-sanduiche-natural-de-frango-receita-facil-e-rapida-lanche-da-tarde.jpg?fit=1076%2C603&ssl=1', 0, 1, 3)"
            );

            migrationBuilder.Sql("INSERT INTO Lanches(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemURL, ImagemThumbnailURL, IsLanchePreferido, EmEstoque, CategoriaId) " +
            "VALUES('Triple Angus Black', '3 carnes 120g tipo Angus com maionese da casa.', 'Pão tostado na brasa, três carnes tipo Angus de 120g, cebola roxa e nossa famosa maionese da casa.', '52.99', 'https://alineapproves.com/wp-content/uploads/2018/10/Ricks_Burger_CultMonsterBurger-1.jpg', 'https://i0.wp.com/ohamburguerperfeito.com.br/wp-content/uploads/2015/10/032.png?fit=815%2C611&ssl=1', 1, 1, 2)"
            );

            migrationBuilder.Sql("INSERT INTO Lanches(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemURL, ImagemThumbnailURL, IsLanchePreferido, EmEstoque, CategoriaId) " +
            "VALUES('Smash Texas Double', '2 Carnes tipo Angus com Parmesão e Cebola Roxa.', 'Pão tostado na brasa, duas carnes tipo Angus de 120g, parmesão de primeira qualidade, ketchup, bacon e cebola roxa.', '45.99', 'https://www.shutterstock.com/image-photo/double-meet-burger-melting-cheddar-600nw-1943764429.jpg', 'https://saltandbatteruk.com/wp-content/uploads/2023/09/BFV9770_DoubleCheeseburgerasmadebyErikAnderson-Thumb1080SQ.jpg', 1, 1, 2)"
            );

            migrationBuilder.Sql("INSERT INTO Lanches(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemURL, ImagemThumbnailURL, IsLanchePreferido, EmEstoque, CategoriaId) " +
            "VALUES('Veggie Monster Double', '2 carnes da Fazenda do Futuro e molho especial da casa.', 'Pão tostado na brasa, 2 carnes de 120g da Fazenda do Futuro, parmesão italiano, molho de ervas finas e cebola roxa.', '45.99', 'https://www.sabornamesa.com.br/media/k2/items/cache/acbf17dca076404b2078b0d4b135530d_XL.jpg', 'https://runnersworld.com.br/wp-content/uploads/sites/4/2019/06/hamburguer-vegano.jpg', 0, 1, 1)"
            );

            migrationBuilder.Sql("INSERT INTO Lanches(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemURL, ImagemThumbnailURL, IsLanchePreferido, EmEstoque, CategoriaId) " +
            "VALUES('Egg Plant Based', 'Carne de soja Fazenda do Futuro de 180g e ovo.', 'Pão tostado na brasa, carne de soja 180g da Fazenda do futuro, ovo, alface, tomate e cebola marinada no shoyu.', '33.99', 'https://veganandcolors.com/wp-content/uploads/2020/04/b2-3-1010x1024.jpg', 'https://s2.glbimg.com/SMJqmqMEbiE2z7qm0nEIQBY-Sqg=/e.glbimg.com/og/ed/f/original/2019/02/05/haburguer-veggie.jpg', 0, 1, 1)"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
