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

        Boletim boletim = new Boletim();
        Tela tela = new Tela();

        NotasAluno notas = new NotasAluno();

        notas.Nota1 = tela.PedirDouble("Informe a primeira nota");
        notas.Nota2 = tela.PedirDouble("informe a Segunda nota");
        notas.Nota3 = tela.PedirDouble("infome a terceira nota");

        Resultado res = boletim.Calcular(notas);
       
        tela.Exibir($"Média: {res.Media} \n Situação: {res.Situação}");
    } 
}