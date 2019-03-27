using System;

public class Endereco
{
    private String TipoLogradouro;
    private String Logradouro;
    private String Bairro;
    private String Cidade;
    private String UF;

    public Endereco()
    {
        this.TipoLogradouro = "Rua";
        this.Cidade = "Belo Horizonte";
        this.UF = "MG";
    }

    public void SetTipoLogradouro(String TipoLogradouro)
    {
        this.TipoLogradouro = TipoLogradouro;
    }

    public SetTipoLogradouro()
    {
        return this.TipoLogradouro;
    }

    public void SetLogradouro(String Logradouro)
    {
        this.Logradouro = Logradouro;
    }

    public SetLogradouro()
    {
        return this.Logradouro;
    }

    public void SetBairro(String Bairro)
    {
        this.Bairro = Bairro;
    }

    public SetBairro()
    {
        return this.Bairro;
    }

    public void SetCidade(String Cidade)
    {
        this.Cidade = Cidade;
    }

    public SetCidade()
    {
        return this.Cidade;
    }

    public void SetUF(String UF)
    {
        this.UF = UF;
    }

    public SetUF()
    {
        return this.UF;
    }

}


