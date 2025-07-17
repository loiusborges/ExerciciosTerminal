namespace Terminal.Core;
/*
 * 
 * Implemente uma classe chamada “Produto” que possua atributos para armazenar o nome, o preço e a quantidade em estoque. 
 * Adicione métodos para calcular
 * o valor total em estoque e verificar se o produto está disponível.
 * 
 * nome
 * preço 
 * estoque
 * 
 * verificar produto disponível
 * valor total em estoque
 */
public class Produto
{

    public Guid ID { get; } = Guid.NewGuid();

    public string Nome { get; set; }

    public decimal Preco {  get; set; }

    public int Estoque { get; set; }

    
    public Produto(string nome, decimal preco, int estoque)
    {
        Nome = nome ?? throw new ArgumentNullException(nameof(nome),"Nome não pode ser nulo");
        Preco = preco;
        Estoque = estoque;
    }

    public int VerificarEstoque()
    {
        if (Estoque == 0)
            throw new Exception($"Estoque no Indiponivel: {Estoque}");

        return Estoque;
    }

    public decimal ValorEstoque()
    {
        decimal valorTotal = Estoque * Preco;
        return valorTotal;
    }
}
