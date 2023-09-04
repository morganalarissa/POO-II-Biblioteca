using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class MidiaDigital : ItemBiblioteca, IPodeSerEmprestado
    {

        public int CodigoMidia { get; set; }
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

                Console.WriteLine($"A midia digital: {Titulo} foi compartilhada em: ({DataEmprestimo.ToShortDateString()})");
            }
            else
            {
                Console.WriteLine($"A midia digital: {Titulo}  não esta mais disponível para compartilhamento.");
            }
        }

        public void Devolver(DateTime dataDevolucao)
        {
            Console.WriteLine($"Midia Digital não tem devolução.");
        }

    }
}
