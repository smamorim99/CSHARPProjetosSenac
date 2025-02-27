Boletim bo = new Boletim();

int qtd = bo.PedirQtd();
double[] notas = bo.CarregarNotas(qtd);
double media = bo.CalcularMedia(notas);

Console.WriteLine($"A media é: {media}");