using System;

public class Personagem2
{
    private String Nome;
    private String Tipo;
    private int PontoVida;

    public Personagem2()
    {
        this.PontoVida = 100;
    }

    public void GeraDano(int Dano)
    {
        this.PontoVida = this.PontoVida - Dano;

    }

    public void SetNome(String Nome)
    {
        this.Nome = Nome;
    }

    public String GetNome()
    {
        return this.Nome;
    }

    public void SetTipo(String Tipo)
    {
        this.Tipo = Tipo;
    }

    public String GetTipo()
    {
        return this.Tipo;
    }

    public void SetPontoVida(int PontoVida)
    {
        this.PontoVida = PontoVida;
    }

    public int GetPontoVida()
    {
        return this.PontoVida;
    }
}
