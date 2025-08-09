using System.Text.Json.Serialization;

namespace FundamentosCSharp.Construtores;

public class Cliente
{
    public string Nome { get; }
    public int Idade { get; }

    public Cliente(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    [JsonConstructor]
    public Cliente(string nome)
    {
        Nome = nome;
        Idade = 0;
    }
}
