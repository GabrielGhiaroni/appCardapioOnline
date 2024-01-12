using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace appCardapioOnline.Migrations
{
    /// <inheritdoc />
    public partial class InsercaoNovosLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemURL, ImagemThumbnailURL, IsLanchePreferido, EmEstoque, CategoriaId) " +
            "VALUES('Bolo de Chocolate Belga', 'Chocolate Belga Original.', 'Receita caseira, com massa fofinha e chocolate belga original.', '11.50', 'https://www.receiteria.com.br/wp-content/uploads/bolo-de-chocolate-rapido-e-molhadinho.jpg', 'https://conteudo.imguol.com.br/c/entretenimento/c8/2021/07/13/bolo-cremoso-de-chocolate-1626185315609_v2_1x1.jpg', 0, 1, 5)"
            );
            migrationBuilder.Sql("INSERT INTO Lanches(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemURL, ImagemThumbnailURL, IsLanchePreferido, EmEstoque, CategoriaId) " +
            "VALUES('Torta de Limão', 'Creme de baunilha e limão siciliano.', 'Receita artesanal, com creme de baunilha e raspas de limão siciliano.', '11.50', 'https://www.receitasnestle.com.br/sites/default/files/srh_recipes/1d22d96039f98608bc9338debb1b4579.jpg', 'https://cooknenjoy.com/wp-content/uploads/2021/10/torta-de-limao-01-1800x1286.jpg', 1, 1, 5)"
            );
            migrationBuilder.Sql("INSERT INTO Lanches(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemURL, ImagemThumbnailURL, IsLanchePreferido, EmEstoque, CategoriaId) " +
            "VALUES('Quatro Queijos', 'Queijos curados e especiais.', 'Massa fininha, molho de tomate artesanal, parmesão, Catupiry Original, gorgonzola e mussarela.', '55.95', 'https://www.sabornamesa.com.br/media/k2/items/cache/32699af76cfc6e0191d612ffd4e88ee9_XL.jpg', 'https://pubimg.band.uol.com.br/files/e7c7412c3cd54a639e21.png', 1, 1, 4)"
            );
            migrationBuilder.Sql("INSERT INTO Lanches(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemURL, ImagemThumbnailURL, IsLanchePreferido, EmEstoque, CategoriaId) " +
            "VALUES('Presunto de Parma com Alho Poró', 'Presunto de Parma Italiano e Alho Poró fresco.', 'Massa fininha, molho de tomate artesanal, presunto de parma e alho poró.', '72.50', 'https://receitinhas.com.br/wp-content/uploads/2017/03/Depositphotos_13807710_m-2015-730x365.jpg', 'https://s2.glbimg.com/l1khbUk8Vs7vxTOPrOTrIRGv04c=/smart/e.glbimg.com/og/ed/f/original/2021/03/02/receita-pizza-presunto_2.jpg', 1, 1, 4)"
            );
            migrationBuilder.Sql("INSERT INTO Lanches(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemURL, ImagemThumbnailURL, IsLanchePreferido, EmEstoque, CategoriaId) " +
            "VALUES('Calabresa Acebolada', 'Calabresa premium e cebola roxa.', 'Massa fininha, molho de tomate artesanal, calabresa premium e cebola roxa.', '48.50', 'https://receitinhas.com.br/wp-content/uploads/2023/01/maxresdefault-38.jpg', 'https://www.sabornamesa.com.br/media/k2/items/cache/513d7a0ab11e38f7bd117d760146fed3_XL.jpg', 1, 1, 4)"
            );
            migrationBuilder.Sql("INSERT INTO Lanches(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemURL, ImagemThumbnailURL, IsLanchePreferido, EmEstoque, CategoriaId) " +
            "VALUES('Frango com Catupiry', 'Frango defumado e desfiado.', 'Massa fininha, molho de tomate artesanal, frango defumado desfiado e Catupiry Original.', '42.00', 'https://www.sabornamesa.com.br/media/k2/items/cache/ada34cd2101afafaba465aad112ee3c1_XL.jpg', 'https://www.hojetemfrango.com.br/wp-content/uploads/2019/01/shutterstock_333724454.jpg', 0, 1, 4)"
            );
            migrationBuilder.Sql("INSERT INTO Lanches(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemURL, ImagemThumbnailURL, IsLanchePreferido, EmEstoque, CategoriaId) " +
            "VALUES('Marguerita Especial', 'Pizza de Marguerita com Catupiry Original.', 'Massa fininha, molho de tomate artesanal, manjericão fresco, tomate cereja e Catupiry Original.', '42.00', 'https://www.paollarestaurante.com.br/uploads/images/2019/08/pizza-marguerita-1565142532.jpg', 'https://cloudfront-us-east-1.images.arcpublishing.com/estadao/YANRMY3TBZGWBCM2UDY6LEZJMA.jpg', 1, 1, 4)"
            );
            migrationBuilder.Sql("INSERT INTO Lanches(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemURL, ImagemThumbnailURL, IsLanchePreferido, EmEstoque, CategoriaId) " +
            "VALUES('Sorvete de Baunilha com Chocolate Belga', 'Receita artesanal com Chocolate Belga importado.', 'Nosso carro chefe das sobremesas. Com Chocolate Belga importado e creme de baunilha artesanal.', '12.00', 'https://catracalivre.com.br/wp-content/uploads/2023/08/istock-1326143969-910x607.jpg', 'https://www.mundoboaforma.com.br/wp-content/uploads/2022/07/Sorvete-vegano-de-baunilha.jpg', 1, 1, 5)"
            );
            migrationBuilder.Sql("INSERT INTO Lanches(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemURL, ImagemThumbnailURL, IsLanchePreferido, EmEstoque, CategoriaId) " +
            "VALUES('Pudim de Leite Condensado', 'O básico queridinho de todos.', 'Pudim de leite condensado Moça com calda artesanal.', '8.00', 'https://receitasrapidas.org/wp-content/webp-express/webp-images/uploads/2023/02/Pudim_leite_condensado-3.jpg.webp', 'https://www.aperitifalafrancaise.com.br/wp-content/uploads/2023/06/Receita-de-Pudim-de-Leite-Condensado.webp', 1, 1, 5)"
            );
            migrationBuilder.Sql("INSERT INTO Lanches(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemURL, ImagemThumbnailURL, IsLanchePreferido, EmEstoque, CategoriaId) " +
            "VALUES('Coca-Cola Lata', 'Coca-Cola 350ml gelada', 'Bebida gelada e refrescante na sua casa.', '7.50', 'https://domolivio.vtexassets.com/unsafe/fit-in/720x720/center/middle/https%3A%2F%2Fdomolivio.vtexassets.com%2Farquivos%2Fids%2F317905%2FRefrigerante-Coca-Cola-Lata-220ml.jpg%3Fv%3D638374708410400000', 'https://www.imigrantesbebidas.com.br/bebida/images/products/full/1984-refrigerante-coca-cola-lata-350ml.jpg', 1, 1, 6)"
            );
            migrationBuilder.Sql("INSERT INTO Lanches(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemURL, ImagemThumbnailURL, IsLanchePreferido, EmEstoque, CategoriaId) " +
            "VALUES('Pepsi Lata', 'Pepsi 350ml gelada', 'Bebida gelada e refrescante na sua casa.', '7.50', 'https://m.media-amazon.com/images/I/81WeZtiOKSS.jpg', 'https://www.auau.com.br/image/cache/data/up_system/product-13806/pepsi-1000x1000.jpg', 1, 1, 6)"
            );
            migrationBuilder.Sql("INSERT INTO Lanches(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemURL, ImagemThumbnailURL, IsLanchePreferido, EmEstoque, CategoriaId) " +
            "VALUES('Suco de Laranja Artesanal', '300ml, 500ml, 700ml ou 1 litro', 'Laranjas pré-selecionadas e refrescantes.', '10.00', 'https://s2-g1.glbimg.com/G8Aszccx740NAVnQHu9SGYT-n-Q=/1200x/smart/filters:cover():strip_icc()/i.s3.glbimg.com/v1/AUTH_59edd422c0c84a879bd37670ae4f538a/internal_photos/bs/2023/2/S/XJuYhCRped3Nb3qJvXXw/mateusz-feliksik-tmogarnogfs-unsplash-sucolaranja.jpg', 'https://static1.minhavida.com.br/articles/b5/29/62/fb/suco-de-laranja-orig-1.jpg', 1, 1, 6)"
            );
            migrationBuilder.Sql("INSERT INTO Lanches(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemURL, ImagemThumbnailURL, IsLanchePreferido, EmEstoque, CategoriaId) " +
            "VALUES('Suco de Uva', '300ml, 500ml, 700ml ou 1 litro', 'Cachos de uva pré-selecionados e refrescantes.', '10.00', 'https://vinicolaserradasgales.com.br/wp-content/uploads/2020/10/shutterstock_1505648246-730x430.jpg', 'https://ilovevinhos.com.br/wp-content/uploads/2020/10/Fresh-Grape-Juice.jpg', 1, 1, 6)"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
