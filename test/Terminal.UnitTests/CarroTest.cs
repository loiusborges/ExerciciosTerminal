using Terminal.Core;

namespace Terminal.UnitTests;

public class CarroTest
{
    [Fact]
    public void ConstrutorPadrao_DeveInicializarComValoresPadrao()
    {
        var carro = new Carro();

        Assert.Equal("Desconhecido", carro.Marca);
        Assert.Equal("Desconhecido", carro.Modelo);
        Assert.Equal(0, carro.VelocidadeAtual);
    }

    [Fact]
    public void ConstrutorParametro_DeveInicializarComValoresInformados()
    {
        var carro = new Carro("Ford", "Mustang");

        Assert.Equal("Ford", carro.Marca);
        Assert.Equal("Mustang", carro.Modelo);
        Assert.Equal(0, carro.VelocidadeAtual);
    }

    [Fact]
    public void Acelerar_DeveIncrementarVelocidade()
    {
        var carro = new Carro();
        carro.Acelerar(50);

        Assert.Equal(50, carro.VelocidadeAtual);
    }

    [Fact]
    public void Frear_DeveReduzirVelocidade()
    {
        var carro = new Carro();
        carro.Acelerar(60);
        carro.Frear(20);

        Assert.Equal(40, carro.VelocidadeAtual);
    }

    [Fact]
    public void Frear_NaoDeveTerVelocidadeNegativa()
    {
        var carro = new Carro();
        carro.Frear(10); 

        Assert.Equal(0, carro.VelocidadeAtual);
    }

}
