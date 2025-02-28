class Tela
{
    public int Menu()
    {
        Console.WriteLine(@"
[1] NOVO
[2] LISTAR PRODUTOS
[3] REMOVER PRODUTOS
[4] ENTRADA ESTOQUE
[5] SAIDA ESTOQUE
[6] SAIR");

    int menu =  Convert.ToInt32(Console.ReadLine());
    
    return menu;
    }

    public Livro PedirLivro()
    {
        Livro livro = new Livro();
        Console.WriteLine("Informe o Titulo do Livro");
        livro.Nome = Console.ReadLine();

        Console.WriteLine("Informe o preço do Livro");
        livro.Preco = Convert.ToDouble(Console.ReadLine());

        livro.Quantidade = 0;

        return livro;
    }

    public string PedirNome()
    {
        Console.WriteLine("Informe o título do livro:");
        return Console.ReadLine();
    }
    public int PedirQtd()
    {
        Console.WriteLine("Informe a quantidade do produto:");
        return Convert.ToInt32(Console.ReadLine());
    }
}