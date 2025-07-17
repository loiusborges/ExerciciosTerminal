namespace Terminal.Core;
/*
 * 
 * Implemente uma classe chamada “Carro” com atributos para armazenar a marca, o modelo e a velocidade atual do carro. 
 * Adicione métodos para acelerar, frear e exibir a velocidade atual
 * 
 * 
 */
public class Carro
{
    public Guid id { get; } = Guid.NewGuid();

    public string Marca { get; set; }

    public string Modelo { get; set; }

    public decimal VelocidadeAtual { get; private set; }

    public Carro()
    {
        Marca = "Desconhecido";
        Modelo = "Desconhecido";
        VelocidadeAtual = 0;
    }

    public Carro(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
        VelocidadeAtual = 0;
    }

    public void Acelerar(int incremento)
    {
        VelocidadeAtual += incremento;
        Console.WriteLine($"O Carro acelerou para {VelocidadeAtual} Km/h");
    }

    public void Frear(int decremento)
    {
        VelocidadeAtual -= decremento;
        if (VelocidadeAtual < 0) VelocidadeAtual = 0;

        Console.WriteLine($"O Carro estar freando a {VelocidadeAtual} Km/h");
    }

    public void ExibirVelocidade()
    {
        Console.WriteLine($"Velocidade atual é: {VelocidadeAtual} Km/h");
    }
}
