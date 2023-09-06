/*Crie uma classe abstrata chamada "ItemBiblioteca" que contenha informações comuns a todos os itens, como título, autor, ano de publicação e número de páginas.

Defina uma interface chamada "PodeSerEmprestado" que declare métodos para empréstimo e devolução de itens.

Crie classes concretas para representar diferentes tipos de itens da biblioteca, como "Livro", "Revista" e "MidiaDigital". 
Essas classes devem herdar da classe abstrata "ItemBiblioteca" e implementar a interface "PodeSerEmprestado" se aplicável (você pode decidir que tipos de itens serão emprestáveis).

Implemente os métodos de empréstimo e devolução de acordo com a natureza do item. Por exemplo, um livro pode ser emprestado por um período definido,
enquanto uma mídia digital pode ser emprestada indefinidamente.

Crie uma classe chamada "Biblioteca" que gerencie uma coleção de itens da biblioteca e forneça métodos para emprestar e devolver itens.

Crie instâncias de diferentes tipos de itens da biblioteca e demonstre como eles podem ser emprestados e devolvidos usando a classe "Biblioteca".
*/
using System;

namespace Biblioteca
{
    public class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro (1, "Harry Potter", "J.K.", 2000, 1000);

            Revista revista = new Revista(1, "Tititi", "Sonia Abrao", 2000, 1000);

            MidiaDigital midia = new MidiaDigital(1, "Enter Sandman", "Metallica", 2000, 10);

            Biblioteca biblioteca = new Biblioteca();
           
            biblioteca.AdicionarItem(livro);
            biblioteca.AdicionarItem(revista);
            biblioteca.AdicionarItem(midia);
            
            DateTime dataEmprestimo = DateTime.Now;
            DateTime dataDevolucao = dataEmprestimo.AddDays(14);

            Imprimir.ImprimirLivro(dataDevolucao,dataEmprestimo, livro);
            Console.WriteLine();
            Imprimir.ImprimirRevista(dataDevolucao, dataEmprestimo, revista);
            Console.WriteLine();
            Imprimir.ImprimirMidiaDigital(dataDevolucao, dataEmprestimo, midia);

            Console.ReadKey();
        }
    }
}