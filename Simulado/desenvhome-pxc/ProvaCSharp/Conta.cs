using Berg.ProvaCSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bergs.ProvaCSharp
{
    public class Conta
    {
        public decimal Saldo;
        List<ChaveFavorita> ChavesFavoritas;
        Retorno r;

        //Construtor
        public Conta() { }
        public Conta(string caminhoBanco) { }

        public Retorno CreditarConta(string strValor)//TIPO RETORNO
        {
            try
            {
                Saldo += decimal.Parse(strValor);
            }
            catch ()
            {

            }
           
            return r;
        }  //TIPO RETORNO

        public void AdicionarChaveFavorita(string strNome, string strTipo, string strChave) { }  //Tipo RETORNO

        public void ListarChavesFavoritas() { }//TIPO LISTACHAVE

        public void EnviarPix(string strChave, string strValor) { }  //Tipo RETORNO


    }
}
