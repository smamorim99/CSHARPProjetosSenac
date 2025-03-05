class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("CONTROLE DE ESTOQUE LIVRARIA");

    Estoque estoque = new Estoque();
    Tela tela = new Tela();

    int menu = tela.Menu();

    while (menu !=0)
    {
        switch(menu)
        {
            case 1:
            Console.WriteLine("Adicionar um novo título");
            Livro livro = tela.PedirLivro();
            estoque.AdcLivro(livro);
            break;

            case 2: 
            Console.WriteLine("Nossos livros em estoque:");
            estoque.Listar();
            break;

            case 3:
            Console.WriteLine("Remover produto:");
           
            
            break;

            case 4:
            Console.WriteLine("Adicionar Produto ao estoque");
            
            nome = tela.PedirNome();
            qtd = tela.PedirQtd();

            estoque.EntradaEstoque(nome, qtd);
            break;

            case 5: 
            Console.WriteLine("saida estoque");
            
            break;

            default:
            Console.WriteLine("Para sair precione 'x'");
            Console.ReadKey();
            break;
        }
        menu = tela.Menu();
    }

    
}
}