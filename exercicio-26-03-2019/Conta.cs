using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Conta
    {
        private int Numero;
        private String Nome;
        private double Saldo;

        public Conta()
        {
            Random r = new Random();
            this.Numero = r.Next(1, 1000);
        }

        public Conta(int Numero, String Nome)
        {
            this.Numero = Numero;
            this.Nome = Nome;
        }

        public bool Depositar(double valor)
        {
            if( valor > 0)
            {
                this.Saldo = this.Saldo + valor;
                return true;
            } else
            {
                return false;
            }
        }

        public bool Sacar(double valor)
        {
           if( valor > 0)
            {
                if( this.Saldo - valor >= 0)
                {
                    this.Saldo = this.Saldo - valor;
                    return true;
                } else
                {
                    return false;
                }
            } else
            {
                return false;
            }
        }

        public void SetNumero( int Numero)
        {
            this.Numero = Numero;
        }

        public int GetNumero()
        {
            return this.Numero;
        }

        public void SetNome(String Nome)
        {
            this.Nome = Nome;
        }

        public String GetNome()
        {
            return this.Nome;
        }

        public double GetSaldo()
        {
            return this.Saldo;
        }

    }
}
