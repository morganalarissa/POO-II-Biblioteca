using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Biblioteca
    {
        public List<IPodeSerEmprestado> ItensDisponiveis { get; private set; }

        public Biblioteca()
        {
            ItensDisponiveis = new List<IPodeSerEmprestado>();
        }
        public void AdicionarItem(IPodeSerEmprestado item)
        {
            ItensDisponiveis.Add(item);
        }
        public void EmprestarItem(IPodeSerEmprestado item, DateTime dataEmprestimo)
        {
            item.Emprestar(dataEmprestimo);
        }
        public void DevolverItem(IPodeSerEmprestado item, DateTime dataDevolucao)
        {
            item.Devolver(dataDevolucao);
        }
    }
}
