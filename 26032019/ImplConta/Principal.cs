using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplConta
{
    class Principal
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta();
            String Nome;
            double valor;

            Console.WriteLine("Informe o nome do cliente: ");
            Nome = Console.ReadLine();

            Console.WriteLine("Informe o valor: ");
            valor = Convert.ToDouble(Console.ReadLine());

            c1.SetNome(Nome);
            c1.Depositar(valor);

            Console.WriteLine("Número da conta: " + C1.GetNumero());
            Console.WriteLine("Titular da conta: " + C1.GetNome());
            Console.WriteLine("Saldo da conta: " + C1.GetSaldo().ToString("0.00"));
            Console.ReadKey();

            ReceberDados recebe = new ReceberDados();
            recebe.SetNome("João Horacio Bretas");

            Console.WriteLine("Nome: " + recebe.GetNome());

            Console.WriteLine("Numero Conta: " + recebe.Conta());

            Console.ReadKey();

            Conta C2 = new Conta();
            String Nome;
            double Valor;

            Console.WriteLine("Informe o nome: ");
            Nome = Console.ReadLine();

            Console.WriteLine("Informe o valor: ");
            Valor = Convert.ToDouble(Console.ReadLine());

            C1.SetNome(Nome);
            C1.Depositar(Valor);

            Console.WriteLine("Número da conta: " + C2.GetNumero());
            Console.WriteLine("Titular da conta: " + C2.GetNome());
            Console.WriteLine("Saldo da conta: " + C2.GetSaldo().ToString("0.00"));
            Console.ReadKey();

        }
    }
}
