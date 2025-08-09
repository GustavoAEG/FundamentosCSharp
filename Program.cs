using FundamentosCSharp.Colecoes;
using FundamentosCSharp.Construtores;
using FundamentosCSharp.Metodos;
using FundamentosCSharp.Propriedades;
using FundamentosCSharp.Serializacao;
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Iniciando operação demorada...");
        var tarefa = OperacaoDemoradaAsync();

        Console.WriteLine("Informe Nome:");
        string entrada = Console.ReadLine();
        
        int outroResultado = await CalcularAsync();

        Console.WriteLine($"Resultado da operação: {outroResultado}");
    }

    static async Task<int> OperacaoDemoradaAsync()
    {
        await Task.Delay(60000); 
        return 42;
    }
    static async Task<int> CalcularAsync()
    {
        await Task.Delay(2000);
        return 100;
    }
}