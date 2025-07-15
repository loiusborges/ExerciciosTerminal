using Terminal.Core;

namespace Terminal.UnitTests;

public class ContaBancariaTest
{
    

    [Fact]
    public void DepositarTest()
    {
        //Arrenge
        ContaBancaria conta = new("Usario",0);
        //Act
        conta.Depositar(100);
        //Assert
        Assert.Equal(100, conta.Saldo);
    }
}
