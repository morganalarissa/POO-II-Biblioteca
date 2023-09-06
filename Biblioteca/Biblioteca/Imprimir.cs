using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Imprimir
    {
        public static void ImprimirLivro(DateTime dataDevolucao, DateTime dataEmprestimo, Livro livro)
        {
            Console.WriteLine(livro.Emprestar(dataEmprestimo));
            Console.WriteLine(livro.Devolver(dataDevolucao));
        }

        public static void ImprimirRevista(DateTime dataDevolucao, DateTime dataEmprestimo, Revista revista)
        {
            Console.WriteLine(revista.Emprestar(dataEmprestimo));
            Console.WriteLine(revista.Devolver(dataDevolucao));
        }

        public static void ImprimirMidiaDigital(DateTime dataDevolucao, DateTime dataEmprestimo, MidiaDigital midiaDigital)
        {
            Console.WriteLine(midiaDigital.Emprestar(dataEmprestimo));
            Console.WriteLine(midiaDigital.Devolver(dataDevolucao));
        }
    }
}