using FundamentosCSharp.Propriedades;

namespace FundamentosCSharp.Metodos;

public class Calculadora
{

    public void MostrarMensagem(string mensagem)
    {
        Console.WriteLine(mensagem);
    }

    public int Somar(int a, int b)
    {
        int result = a + b;
        return result;
    }

    public bool EhPar(int numero)
    {
        return numero % 2 == 0;
    }

    public Produto CriarProduto(string nome, decimal preco, int estoque)
    {
        return new Produto(nome, preco, estoque);
    }

    public List<string> ObterFrutas()
    {
        return new List<string> { "Maçã", "Banana", "Laranja" };
    }

    public T RetornarPrimeiro<T>(List<T> lista)
    {
        return lista.First();
    }


    public async Task<int> SomarAsync(int a, int b)
    {
        await Task.Delay(500);
        return a + b;
    }

    public static async Task<int> ExecutarSubtracaoAsync(int resultado, int SegundoValor)
    {
        await Task.Delay(500);

        int subtresultasync= resultado - SegundoValor;

        return subtresultasync;
     
    }
}
