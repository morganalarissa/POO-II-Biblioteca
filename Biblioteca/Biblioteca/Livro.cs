using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Livro : ItemBiblioteca, IPodeSerEmprestado
    {
        public int CodigoLivro { get; set; }
        public bool Emprestado { get; private set; }
        public DateTime DataEmprestimo { get; private set; }
        public DateTime DataDevolucao { get; private set; }

        public Livro(int codigo, string titulo, string autor, int anoPublicacao, int numPaginas) : base(titulo, autor, anoPublicacao, numPaginas) 
        {
          
        }
        public string Emprestar(DateTime dataEmprestimo)
        {
            if (!Emprestado)
            {
                Emprestado = true;
                DataEmprestimo = dataEmprestimo;
                DataDevolucao = dataEmprestimo.AddDays(15);

                return $"Livro: {Titulo} foi emprestado em ({DataEmprestimo.ToShortDateString()})" +
                Environment.NewLine + $"Data máxima para devolução: ({DataDevolucao.ToShortDateString()}).";
            }
            else
            {
                return $"Livro: {Titulo} está emprestado.";
            }
        }

        public string Devolver(DateTime dataDevolucao)
        {
            if (Emprestado)
            {
                Emprestado = false;
                DataDevolucao = dataDevolucao;
                return $"Livro: {Titulo} devolvido em ({DataDevolucao.ToShortDateString()}).";
            }
            else
                return "Livro não devolvido";
            
        }
    }
}
