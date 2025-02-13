namespace CSHARPProjetosSenac;

class Program
{
    static void Main(string[] args)
    {
        /*Console.WriteLine("infome a primeira nota");
        double nota = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("infome a segunda nota");
        double nota2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("infome a segunda nota");
        double nota3 = Convert.ToDouble(Console.ReadLine());*/
        double nota1 = PedirNota("Informe a primeira nota");
        double nota2 = PedirNota("informe a Segunda nota");
        double nota3 = PedirNota("infome a terceira nota");

        double media = Media(nota1, nota2, nota3);

        string sit = Situação(media);
       
        Console.WriteLine($"A média do aluno é {media} e a situação é {sit}");
    }
 
    public static double PedirNota (string msg){
        Console.WriteLine(msg);
        double nota = Convert.ToDouble(Console.ReadLine());
        return nota;
    }

    public static double Media (double n1, double n2, double n3){
        double m =  n1 + n2 + n3 / 3;
        return m;

    }
    
    public static string Situação (double media){
        string sit = "";
        
        if (media >= 6 )

            sit = "aprovado";
        else {
            sit = "reprovado";
        }

        return sit;
    }
}