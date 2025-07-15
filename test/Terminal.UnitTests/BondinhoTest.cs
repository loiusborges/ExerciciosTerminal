using Terminal.Core;

namespace Terminal.UnitTests;

public class BondinhoTest
{

    private readonly Bondinho bondinho = new();

    [Fact]
    public void CapacidadeTest()
    {
        //Arrange
        bondinho.alunos = 11;
        bondinho.monitores = 12;
        
        //Act
        int result = Bondinho.Capacidade(bondinho);
        //Assert
        Assert.Equal(23,result);
    }
}
