using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Estoque
{
    Livro[] livros = new Livro[0];

    public void AdcLivro(Livro livro)
    {
        Livro[] novo = new Livro[livros.Length + 1];

        for(int pos = 0; pos < livros.Length; pos++)
        {
            novo[pos] = livros[pos];
        }
        novo[livros.Length] = livro;
        
        livros = novo;
    }
    public void Listar()
    {
        foreach (Livro item in livros)
        {
            Console.WriteLine($"Livro: {item.Nome} - R${item.Preco} - Estoque: {item.Quantidade}");
        }
    }
    public void EntradaEstoque(String nome, int qtd)
    {
        Livro livro = null;
        foreach (Livro item in livros)
        {
           if (item.Nome == nome)
           { 
            livro = item;
            break;
           }
        }
        if (livro != null)
        {
            livro.Quantidade += qtd;
        }
    }
    public void SaidaEstoque(String nome, int qtd)
    {
        foreach (Livro item in livros)
        {
        
        }
    }


}