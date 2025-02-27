class Boletim
{
    public int PedirQtd()
    {
        Console.WriteLine("informe a quantidade de notas");
        int qtd = Convert.ToInt32(Console.ReadLine());
        return qtd; 

    }

    public double[] CarregarNotas(int qtd)
    {
        double[] notas = new double[qtd];

        for( int i = 0; i < notas.Length; i++)
        {
        Console.WriteLine($"informe a {i+1} notas");
        notas[i] = Convert.ToDouble(Console.ReadLine());
        }
        return notas;
    }

    public double CalcularMedia(double[] notas)
    {
        double soma = 0;
        foreach (double nota in notas)
        {
            soma += nota;
        }

        double media = soma/notas.Length;

        return media;
    }
}