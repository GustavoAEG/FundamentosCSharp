namespace FundamentosCSharp.Metodos;

public class Calculadora
{
    public void MostrarMensagem(string mensagem) => Console.WriteLine(mensagem);

    public int Somar(int a, int b) => a + b;

    public bool EhPar(int numero) => numero % 2 == 0;

    public List<string> ObterFrutas() => new() { "Maçã", "Banana", "Laranja" };
}
