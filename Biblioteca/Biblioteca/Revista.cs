using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Revista : ItemBiblioteca, IPodeSerEmprestado
    {

        public int CodigoRevista { get; set; }
        public bool Emprestado { get; private set; }
        public DateTime DataEmprestimo { get; private set; }
        public DateTime DataDevolucao { get; private set; }

        public override string Titulo { get; set; }
        public override string Autor { get; set; }
        public override int AnoPublicacao { get; set; }
        public override int NumPaginas { get; set; }



        public void Emprestar(DateTime dataEmprestimo)
        {
            if (!Emprestado)
            {
                Emprestado = true;
                DataEmprestimo = dataEmprestimo;
                DataDevolucao = dataEmprestimo.AddDays(30);

                Console.WriteLine($"Revista: {Titulo} foi emprestada em ({DataEmprestimo.ToShortDateString()})");
                Console.WriteLine($"Data máxima para devolução: ({DataDevolucao.ToShortDateString()}).");
            }
            else
            {
                Console.WriteLine($"Revista: {Titulo} está emprestada.");
            }
        }

        public void Devolver(DateTime dataDevolucao)
        {
            if (Emprestado)
            {
                Emprestado = false;
                DataDevolucao = dataDevolucao;
                Console.WriteLine($"Revista: {Titulo} foi devolvida em: ({DataDevolucao.ToShortDateString()}).");
            }
        }

    }
}
