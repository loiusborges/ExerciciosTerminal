namespace Terminal.Core;

public class Bondinho
{
    public int alunos {  get; set; }

    public int monitores { get; set; }

    public static int Capacidade(Bondinho bonhinho)
    {
        int capacidade = 50;
        int total = bonhinho.alunos + bonhinho.monitores;

        if (total < 0)
        {
            throw new ArgumentException("Valor não pode ser 0");
        }

        if (total > capacidade)
        {
            throw new Exception("Capicidade Maxima");
        }

        return total;
    }
}
