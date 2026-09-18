using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES('Coca-Cola', 'Refrigerante de cola', 5.99, 'coca-cola.png', 100, datetime('now'), 1)");
            mb.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES('Hambúrguer', 'Hambúrguer artesanal', 12.99, 'hamburguer.png', 50, datetime('now'), 2)");
            mb.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES('Sorvete', 'Sorvete de chocolate', 3.99, 'sorvete.png', 200, datetime('now'), 3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Produtos");
        }
    }
}
