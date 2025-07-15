using System.Security.Cryptography.X509Certificates;

namespace Terminal.Core;
/* 
 Implemente uma classe chamada “ContaBancária” que possua atributos para armazenar o número da conta, 
    nome do titular e saldo. Adicione métodos para realizar depósitos e saques.
 */
public class ContaBancaria
{
    public Guid NumeroConta {  get;  private set; }
    
    public string? Nome { get; set; }

    public decimal Saldo { get; private set; }

    public ContaBancaria(string? nome, decimal saldo)
    {
        NumeroConta = Guid.NewGuid();
        Nome = nome;
        Saldo = saldo;
    }

    public void Depositar(decimal valor)
    {
        if (valor < 0)
            throw new ArgumentOutOfRangeException("Valor invalido");

        Saldo += valor;
    }
}
