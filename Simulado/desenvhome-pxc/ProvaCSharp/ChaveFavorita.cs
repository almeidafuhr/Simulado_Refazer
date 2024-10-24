using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bergs.ProvaCSharp
{
    public class ChaveFavorita
    {
        public string NomeTitular;
        public string Chave;
        public TiposChave TipoChave;  //TIPO TIPOSCHAVE
        public decimal ValorTotal;
        public int Quantidade;

        public ChaveFavorita() { }
        public ChaveFavorita(string nomeTitular, string chave, TiposChave tipo)
        {
            NomeTitular = nomeTitular;
            Chave = chave;
            TipoChave = tipo;
            ValorTotal = 0;
            Quantidade = 0;
        }
    }
}
