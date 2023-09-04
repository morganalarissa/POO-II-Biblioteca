using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Livro : ItemBiblioteca, IPodeSerEmprestado
    {
        public int CodigoLivro { get; set; }
        public bool Emprestado { get; private set; }
        public DateTime DataEmprestimo { get; private set; }
        public DateTime DataDevolucao { get; private set; }

        public override string Titulo { get; set; }
        public override string Autor { get; set; }
        public override int AnoPublicacao { get; set; }
        public override int NumPaginas { get; set; }

        public Livro(int codigo, string titulo, string autor, int anoPublicacao, int numPaginas) 
        {
            CodigoLivro = codigo;
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
            NumPaginas = numPaginas;
        }
        public void Emprestar(DateTime dataEmprestimo)
        {
            if (!Emprestado)
            {
                Emprestado = true;
                DataEmprestimo = dataEmprestimo;
                DataDevolucao = dataEmprestimo.AddDays(15);

                Console.WriteLine($"Livro: {Titulo} foi emprestado em ({DataEmprestimo.ToShortDateString()})");
                Console.WriteLine($"Data máxima para devolução: ({DataDevolucao.ToShortDateString()}).");
            }
            else
            {
                Console.WriteLine($"Livro: {Titulo} está emprestado.");
            }
        }

        public void Devolver(DateTime dataDevolucao)
        {
            if (Emprestado)
            {
                Emprestado = false;
                DataDevolucao = dataDevolucao;
                Console.WriteLine($"Livro: {Titulo} devolvido em ({DataDevolucao.ToShortDateString()}).");
            }
        }
    }
}
