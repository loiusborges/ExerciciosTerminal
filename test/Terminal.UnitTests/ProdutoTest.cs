using Terminal.Core;

namespace Terminal.UnitTests;

public class ProdutoTest
{

    [Fact]
    public void VerificarEstoque_RetornoCorreto()
    {
        //Arange
        Produto produto = new("Produto", 8.5m, 12);
        //Act
        var resultado = produto.VerificarEstoque();
        //Assert
        Assert.Equal(12, resultado);
    }

    [Fact]
    public void ValorEstoque_RetornoCorreto()
    {
        //Arange
        Produto produto = new("Produto", 8.5m, 12);
        //Act
        var resultado = produto.ValorEstoque();
        //Assert
        Assert.Equal(102, resultado);
    }

}
