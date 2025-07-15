namespace Terminal.Core;
/*
 *Implemente uma classe chamada “Aluno” que possua atributos para armazenar o nome, a matrícula e as notas de um aluno. 
 *Adicione métodos para calcular a média das notas e verificar a situação do aluno (aprovado ou reprovado). 
 */
public class Aluno
{
    public Guid Matricula { get; } = Guid.NewGuid();

    public string Nome { get; set; }

    public int Portugues {  get; set; }

    public int Matematica { get; set; }

    public int Historia { get; set; }

    public int Ciencias { get; set; }

    public Aluno(string? nome, int portugues, int matematica, int historia, int ciencias)
    {
        Nome = nome ?? throw new ArgumentNullException(nameof(nome));
        Portugues = ValidarNota(portugues);
        Matematica = ValidarNota(matematica);
        Historia = ValidarNota(historia);
        Ciencias = ValidarNota(ciencias);
    }

    private int ValidarNota(int nota)
    {
        if (nota < 0 || nota > 10)
            throw new ArgumentOutOfRangeException(nameof(nota), "Nota Invalida: nota deve estar dentre 0 e 10");

        return nota;
    }

    public double CalcularNota()
    {
        return (Portugues + Matematica + Historia + Ciencias) / 4.0; 
    }

    public string VerificarStatus()
    {
        var media = CalcularNota();

        return media >= 7 ? "Aprovado" : "Reprovado";
    }
}
