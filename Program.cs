using System.Drawing;
using System.Runtime.CompilerServices;

namespace Aula_2_Console;
public class Program
{
    public static void Main()
    {
        Exercicios exercicios = new Exercicios();

        while (true)
        {
            Console.WriteLine("Menu de aplicações");
            Console.WriteLine("");
            Console.WriteLine("1 - Calcula média");
            Console.WriteLine("2 - Soma números");
            Console.WriteLine("3 - Cadastro de produtos");
            Console.WriteLine("4 - Divide números");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("");
            Console.WriteLine("Digite a opção desejada e tecle ENTER:");
            var opcao = Console.ReadLine();

            Console.Clear();

            switch (opcao)
            {
                case "1":

                    double media = exercicios.Media();

                    Console.WriteLine("");
                    Console.WriteLine($"A Média é {media:F2}");

                    ExibeMensagemDeFinalizacao();
                    break;

                case "2":

                    int soma = exercicios.Somar();

                    Console.WriteLine("");
                    Console.WriteLine($"A soma total dos valores digitados é {soma}");

                    ExibeMensagemDeFinalizacao();
                    break;

                case "3":


                    Dictionary<string, int> estoque = exercicios.CadastroDeProdutos();

                    Console.Clear();
                    Console.WriteLine("<<< Produtos cadastrados >>>");
                    Console.WriteLine();

                    foreach (var produto in estoque)
                    {
                        Console.WriteLine($"Produto: {produto.Key} – Quantidade: {produto.Value}");
                    }

                    ExibeMensagemDeFinalizacao();

                    break;

                case "4":

                    double divisao = exercicios.Divisao();

                    Console.WriteLine($"Resultado da divisão: {divisao:F2}");

                    ExibeMensagemDeFinalizacao();

                    break;

                case "0":
                    Console.WriteLine("");
                    Console.WriteLine("Saindo...");
                    Console.WriteLine("");
                    return;

                default:
                    Console.WriteLine("");
                    Console.WriteLine("Digite uma opção válida!");
                    Console.WriteLine("Pressione ENTER para tentar novamente...");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }
    }

    public static void ExibeMensagemDeFinalizacao()
    {
        Console.WriteLine("");
        Console.WriteLine("*******FIM*******");
        Console.WriteLine("");
        Console.WriteLine("Pressione ENTER para voltar ao menu principal...");
        Console.ReadLine();
        Console.Clear();
    }
}

