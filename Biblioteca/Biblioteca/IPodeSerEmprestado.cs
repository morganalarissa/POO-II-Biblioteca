using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public interface IPodeSerEmprestado
    {
        void Emprestar(DateTime dataEmprestimo);
        void Devolver(DateTime dataDevolucao);
    }
}
