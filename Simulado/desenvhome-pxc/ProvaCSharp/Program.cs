using Berg.ProvaCSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bergs.ProvaCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            Conta c = new Conta();


            do {
                Console.WriteLine($"== Saldo Atual: R$ {c.Saldo:0.00.##} ==\n");

                Console.WriteLine("1. Efetuar crédito em conta");
                Console.WriteLine("2. Adicionar chave favorita");
                Console.WriteLine("3. Listar chaves favoritas");
                Console.WriteLine("4. Enviar PIX");
                Console.WriteLine("5. Persistir chaves");
                Console.WriteLine("6. Sair");
                Console.Write("\nInforme a opção desejada: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        try
                        {
                            Console.Write("\nValor a ser creditado: ");
                            decimal valor = decimal.Parse(Console.ReadLine());
                            if(valor > 0)
                                c.CreditarConta(valor.ToString());
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine($"\nErro: Valor digitado é inválido! {ex.Message}");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Write("\nNome do titular: ");
                        string nome = Console.ReadLine();

                        Console.Write("Tipo de chave: [1-Telefone, 2-CPF] ");
                        int tipo = int.Parse(Console.ReadLine());

                        Console.Write("Chave: ");
                        string chave = Console.ReadLine();

                        if (tipo == 1)
                        {
                            string regex = "^\\+[1-9][0-9]\\d{11}$";
                            if (System.Text.RegularExpressions.Regex.IsMatch(chave, regex))
                            {
                                
                                //c.AdicionarChaveFavorita(nome, tipo.ToString(), chave);
                            }
                        }
                        else if (tipo == 2)
                        {
                            string regex = "^\\d{11}$";
                            if (System.Text.RegularExpressions.Regex.IsMatch(chave, regex))
                            {
                                c.AdicionarChaveFavorita(nome, tipo.ToString(), chave);
                            }
                        }

                        
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        c.ListarChavesFavoritas();
                        Console.Clear();
                        break;
                    case 4:
                        //ENVIAR PIX
                        Console.Write("\nInsira a chave: ");
                        string chavePix = Console.ReadLine();
                        
                        Console.Write("\nInsira a chave: ");
                        decimal valorPix = decimal.Parse(Console.ReadLine());

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        //PERSISTIR CHAVES

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        //SAIR
                        break;
                    default:
                        Console.Clear();
                        break;


                }
            } while (op != 6);
        }
    }
}
