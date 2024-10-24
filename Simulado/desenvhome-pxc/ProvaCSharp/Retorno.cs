using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berg.ProvaCSharp
{
    public class Retorno  //ABSTRACT ?
    {
        public bool Sucesso;
        public int CodRetorno;
        public string Mensagem;

        public Retorno() { }
        public Retorno(bool sucesso, int codRetorno, string msg)
        {
            Sucesso = sucesso;
            CodRetorno = codRetorno;
            Mensagem = msg;
        }
    }
}
