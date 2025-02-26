Console.WriteLine("informe a quantidade de notas");
int quant = Convert.ToInt32(Console.ReadLine());

double[] notas = new double[quant];

for( int i = 0; i < notas.Length; i++){
    Console.WriteLine("informe as notas");
    notas[i] = Convert.ToDouble(Console.ReadLine());

}
Console.WriteLine("teste...");

double soma = 0;
foreach (double nota in notas)
{
    soma += nota;
}

double media = soma/notas.Length;

Console.WriteLine($"A media é: {media}");