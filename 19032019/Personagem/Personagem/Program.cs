using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem2 p1 = new Personagem2();
            p1.SetNome("Mario");
            p1.SetTipo("H");

            Console.WriteLine("Ponto de vida: " + p1.GetPontoVida());

            p1.GerarDano(35);

            Console.WriteLine("Ponto de vida: " + p1.GetPontoVida());

            Console.ReadKey();

        }
    }
}
