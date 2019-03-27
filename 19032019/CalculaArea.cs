using System;

public class CalculaArea
{

        private double Base;
        private double Altura;

    public double CalculaArea()
    {
        return this.Base * this.Altura / 2;
    }

    public void SetBase(double Base)
    {
        this.Base = Base;
    }

    public double GetBase()
    {
        return this.Base;
    }

    public void SetAltura(double Altura)
    {
        this.Altura = Altura;
    }

    public double GetAltura()
    {
        return this.Altura;
    }
}
