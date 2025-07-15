namespace Terminal.Core;

/*
 * Crie uma classe chamada “Funcionário” com atributos para armazenar o nome, o salário e o cargo do funcionário. 
 * Implemente métodos para calcular o salário líquido, considerando descontos de impostos e benefícios.
 * 
 * nome
 * salario
 * cargo
 * 
 * 
 * salario bruto
 * salario liquido
 * imposto : INSS = 7,5%; IRRF = 7,5%
 * beneficios: ValeTranporte = 6%; ValeRefeição = 10%
 */
public class Funcionarios
{
    public Guid Id { get; } = Guid.NewGuid();

    public string Nome { get; set; }

    public string Cargo { get; set; }

    private decimal Salario { get; set; }


    public Funcionarios(string nome, string cargo, decimal salario)
    {
        Nome = nome ?? throw new ArgumentNullException(nameof(nome));
        Cargo = cargo ?? throw new ArgumentNullException(nameof(cargo));
        Salario = ValidarSalario(salario);
    }


    private decimal ValidarSalario(decimal salario)
    {
        if (salario < 0)
            throw new ArgumentException(nameof(salario),"Salario Invalido");

        return salario;
    }


    public decimal SalarioBruto()
    {
        return Salario;
    }

    public decimal SalarioLiquido()
    {
        decimal descontoINSS = Salario * 0.075m;
        decimal descontoIRRF = Salario * 0.07m;
        decimal descontoValeTranporte = Salario * 0.06m;
        decimal descontoValeRefeição = Salario * 0.10m;
        decimal totalDescontos = descontoINSS + descontoIRRF + descontoValeTranporte + descontoValeRefeição;

        decimal salarioLiquido = Salario - totalDescontos;

        return salarioLiquido;
    }
    public decimal MudarSalario(decimal novoSalario)
    {
        Salario = ValidarSalario(novoSalario);

        return Salario;
    }

}
