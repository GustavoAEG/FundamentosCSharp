using System.Text.Json;

namespace FundamentosCSharp.Serializacao;

public class ExemploJson
{
    public void Executar()
    {
        var pessoa = new { Nome = "João", Idade = 30 };
        string json = JsonSerializer.Serialize(pessoa);
        Console.WriteLine(json);

        var obj = JsonSerializer.Deserialize<Dictionary<string, object>>(json);
        Console.WriteLine(obj["Nome"]);
    }
}
