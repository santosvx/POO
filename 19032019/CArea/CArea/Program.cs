using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CArea
{
    class Program
    {
        static void Main(string[] args)
        {

            double Base, Altura;

            Console.WriteLine("Informe o valor da base: ");

            Base = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor da altura: ");

            Altura = Convert.ToDouble(Console.ReadLine());

            Triangulo triangulo = new Triangulo();

            triangulo.SetBase(Base);
            triangulo.SetAltura(Altura);

            Console.WriteLine("Área do triângulo: " + triangulo.CalculaArea());

            Console.ReadKey();
        }
    }
}
