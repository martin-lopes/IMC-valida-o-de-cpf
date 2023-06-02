using System;

public class Pessoa
{
    //segundo commit teste
    private string nome;
    private string cpf;
    private string genero;
    private double peso;
    private double altura;
    private double idade;
    public double imc;
    public string classificacao;
    public string obesidade;

    public Pessoa(string nome, string cpf, string genero, double peso, double altura, double idade)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.genero = genero;
        this.peso = peso;
        this.altura = altura;
        this.idade = idade;
    }

    public (double, string, string) IMC()
    {
        //imc
        imc = peso / (Math.Pow(altura, 2));
        //classificao
        if (imc < 18.50)
        {
            classificacao = "Magreza";
            obesidade = "0";
        }

        else if (imc >= 18.50 && imc <= 24.90)
        {
            classificacao = "Normal";
            obesidade= "0";
        }

        else if (imc >= 25.00 && imc <= 29.90)
        {
            classificacao = "Sobrepeso";
            obesidade = "I";
        }

        else if (imc >= 30.00 && imc <= 39.90)
        {
            classificacao = "Obesidade";
            obesidade = "II";
        }

        else if (imc > 40.00)
        {
            classificacao = "Obesidade";
            obesidade = "III";
        }

        return (imc, classificacao, obesidade);
    }

    public string Nome
    {
        get { return nome; } set { nome = value; }
    }

    public string Cpf
    {
        get { return cpf; } set { cpf = value; }
    }

    public string Genero
    {
        get { return genero; } set { genero = value; }
    }

    public double Peso
    { 
        get { return peso; } set { peso = value; }
    }

    public double Altura
    {
        get { return altura; } set { altura = value; }
    }

    public double Idade
    {
        get { return idade; } set { idade = value; }
    }
}
