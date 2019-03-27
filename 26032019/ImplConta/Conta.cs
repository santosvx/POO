using System;

public class Conta
{
    private int Numero;
    private String Nome;
    private double Saldo;

    public void Conta()
    {

        Random r = new Random();
        this.Numero = r.Next(0, 9999999);

        //int contaGerada = r.Next(0, 9999999);
        //return contaGerada;

    }

    public Conta(int numero, String Nome)
    {
        this.Numero = Numero;
        this.Nome = Nome;
    }

    public void SetNumero(int Numero)
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

    public bool Depositar(double valor)
    {
        if (valor > 0)
        {
            this.Saldo = Saldo + valor;
            return true;
        }
        else
        {
            return false;
        }
    }


    public bool Sacar(double valor)
    {
        if (valor > 0)
        {
            if (this.Saldo - valor >= 0)
            { 
            this.Saldo = Saldo - valor;
            return true;
            }
            else
            {
            return false;
            }
        }
        else
        {
            return false;
        }
    }

}
