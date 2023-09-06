using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Revista : ItemBiblioteca, IPodeSerEmprestado
    {
        
        public int CodigoRevista { get; set; }
        public bool Emprestado { get; private set; }
        public DateTime DataEmprestimo { get; private set; }
        public DateTime DataDevolucao { get; private set; }

        public Revista(int codigo, string titulo, string autor, int anoPublicacao, int numPaginas) : base(titulo, autor, anoPublicacao, numPaginas)
        {
            
        }
        public string Emprestar(DateTime dataEmprestimo)
        {
            if (!Emprestado)
            {
                Emprestado = true;
                DataEmprestimo = dataEmprestimo;
                DataDevolucao = dataEmprestimo.AddDays(30);

                return $"Revista: {Titulo} foi emprestada em ({DataEmprestimo.ToShortDateString()})" + 
                Environment.NewLine + $"Data máxima para devolução: ({DataDevolucao.ToShortDateString()}).";
            }
            else
            {
                return $"Revista: {Titulo} está emprestada.";
            }
        }

        public string Devolver(DateTime dataDevolucao)
        {
            if (Emprestado)
            {
                Emprestado = false;
                DataDevolucao = dataDevolucao;
                return $"Revista: {Titulo} foi devolvida em: ({DataDevolucao.ToShortDateString()}).";
            }
            else
                return "Não foi devolvido";
        }
        
    }
}