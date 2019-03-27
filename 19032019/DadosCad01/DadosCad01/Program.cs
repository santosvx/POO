using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosCad01
{
    class Program
    {
        static void Main(string[] args)
        {

            Endereco e1 = new Endereco();
            e1.SetTipoLogradouro("Avenida");
            e1.SetLogradouro("Afonso Pena, 135");
            e1.SetBairro("Centro");

            Console.WriteLine(
                e1.GetTipoLogradouro() + " " + e1.GetLogradouro() + ", " + e1.GetBairro() + ", " + e1.GetCidade() + ", " + e1.GetUF());

            Console.ReadKey();


        }
    }
}
