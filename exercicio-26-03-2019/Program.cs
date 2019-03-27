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
            Conta C1 = new Conta();
            String Nome;
            double Valor;

            Console.WriteLine("Informe o nome: ");
            Nome = Console.ReadLine();

            Console.WriteLine("Informe o valor: ");
            Valor = Convert.ToDouble(Console.ReadLine());

            C1.SetNome(Nome);
            C1.Depositar(Valor);

            Console.WriteLine("Número da conta: " + C1.GetNumero());
            Console.WriteLine("Titular da conta: " + C1.GetNome());
            Console.WriteLine("Saldo da conta: " + C1.GetSaldo().ToString("0.00") );
            Console.ReadKey();

        }
    }
}
