using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public interface IPodeSerEmprestado
    {
        string Emprestar(DateTime dataEmprestimo);
        string Devolver(DateTime dataDevolucao);
    }
}
