using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Conta[] banco = new Conta[3];

            for (int i = 0; i < 3; i++)
            {
                Conta C1 = new Conta();
                banco[i] = C1;
                String Nome;
                double Valor;

                Console.WriteLine("Informe o nome: ");
                Nome = Console.ReadLine();

                Console.WriteLine("Informe o valor: ");
                Valor = Convert.ToDouble(Console.ReadLine());

                C1.SetNome(Nome);
                C1.Depositar(Valor);


            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Número da conta: " + banco[i].GetNumero());
                Console.WriteLine("Titular da conta: " + banco[i].GetNome());
                Console.WriteLine("Saldo da conta: " + banco[i].GetSaldo().ToString("0.00"));

            }

            Console.ReadKey();

        }
    }
}