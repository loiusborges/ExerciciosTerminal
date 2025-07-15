using Terminal.Core;

namespace Terminal.UnitTests;

public class AlunoTest
{
    
    [Fact]
    public void CalcularMedia_RetornoCorreto()
    {
        //Arrenge
        var aluno = new Aluno("Usario",10,7,8,1);
        //Act
        var media = aluno.CalcularNota();
        //Assert
        Assert.Equal(6.5, media);
    }

    
    [Theory]
    [InlineData(8,9,10,3, "Aprovado")]
    [InlineData(8,9,7,6, "Aprovado")]
    [InlineData(2,4,1,3, "Reprovado")]
    [InlineData(5,5,5,5, "Reprovado")]
    public void ValidarStatus_RetornoCorreto(int port, int mate, int hist, int cies, string esperado)
    {
        //Arrenge
        var aluno = new Aluno("Usario", port, mate, hist, cies);
        //Act
        var situcao = aluno.VerificarStatus();
        //Assert
        Assert.Equal(situcao, esperado);
    }
}
