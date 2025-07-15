using System.Xml.Serialization;
using Terminal.Core;

namespace Terminal.UnitTests;

public class FuncionariosTest
{

    [Theory]
    [InlineData(200, 200)]
    [InlineData(5500, 5500)]
    [InlineData(6000, 6000)]
    [InlineData(2100, 2100)]
    public void SalarioBruto_RetornaCorreto(decimal salarioBruto, decimal esperado)
    {
        //Arrenge
        Funcionarios funcionario = new("Usario", "Cargo", salarioBruto);
        //Act
        var resultado = funcionario.SalarioBruto();
        //Assert
        Assert.Equal(esperado, resultado);
    }

    [Theory]
    [InlineData(5000, 3475)]
    [InlineData(3400, 2363)]
    [InlineData(2763, 1920.285)]
    [InlineData(1869, 1298.955)]
    public void SalarioLiquido_RetornaCorreto(decimal salarioBruto, decimal esperado)
    {
        //Arrenge
        Funcionarios funcionario = new("Usario", "Cargo", salarioBruto);
        //Act
        var resultado = funcionario.SalarioLiquido();
        //Assert
        Assert.Equal(esperado, resultado);
    }

    [Theory]
    [InlineData(5000, 3000)]
    [InlineData(3200, 1500)]
    [InlineData(7400, 4000)]
    [InlineData(2500, 7000)]
    public void MudarSalario_RetornaCorreto(decimal salarioBruto, decimal esperado)
    {
        //Arrange
        Funcionarios funcionario = new("Usario", "Cargo", salarioBruto);
        //Act
        funcionario.MudarSalario(esperado);
        //Assert
        Assert.Equal(esperado, funcionario.SalarioBruto());
    }
}
