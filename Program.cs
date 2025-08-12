using FundamentosCSharp.Colecoes;
using FundamentosCSharp.Construtores;
using FundamentosCSharp.Metodos;
using FundamentosCSharp.Propriedades;
using FundamentosCSharp.Serializacao;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    private static string[] jogador;


    enum Operacao
    {
        Adicionar,
        Remover,
        Editar,
        Listar
    }

     class Calculadora
    {
        public double N1 { get; set; }
        public double N2 { get; set; }

        public Operacao TipoOperacao { get; set; }


         public Calculadora(double n1, double n2, Operacao tipooperacao)
        {
            N1 = n1;
            N2 = n2;

            tipooperacao = tipooperacao;
        }

        public double Calcular()
        {
            return TipoOperacao switch
            {
                Operacao.Adicionar => N1 + N2,
                Operacao.Remover => N1 - N2,
                Operacao.Editar => N1 * N2,
                Operacao.Listar => N1 / N2,
                _ => throw new InvalidOperationException("Operação inválida")
            };
        }
    }

    static void Main(string[] args)
    {
        List<string> historico = new List<string>(); 

        while (true)
        {
            Console.WriteLine("=== Calculadora com Construtor, Enum e Lista ===");
            Console.Write("Digite o primeiro número (ou 'sair' para encerrar): ");
            string entrada = Console.ReadLine();
            if (entrada.ToLower() == "sair") break;

            double num1 = Convert.ToDouble(entrada);

            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEscolha a operação:");
            Console.WriteLine("1 - Soma (+)");
            Console.WriteLine("2 - Subtração (-)");
            Console.WriteLine("3 - Multiplicação (*)");
            Console.WriteLine("4 - Divisão (/)");
            int opcao = Convert.ToInt32(Console.ReadLine());

            if (!Enum.IsDefined(typeof(Operacao), opcao))
            {
                Console.WriteLine("Operação inválida!");
                continue;
            }

            try
            {

                Calculadora calc = new Calculadora(num1, num2, (Operacao)opcao);


                double resultado = calc.Calcular();
                Console.WriteLine($"Resultado: {resultado}\n");

                // Salvando no histórico....
                historico.Add(calc.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            Console.WriteLine("\n=== Histórico de Operações ===");
            foreach (var item in historico)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
    //static async Task Main(string[] args)
    //{



    //    string[] jogador = new string[3];

    //    jogador = new[] {"João", "Maria", "José" };

    //    int number = jogador.Length;

    //}
}