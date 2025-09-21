namespace Aula_2_Console;

public class Exercicios
{
    public double Media()
    {
        Console.WriteLine("*******Calculo de média*******");
        Console.WriteLine("");

        double nota1, nota2, nota3;
        // Validação das notas

        while (true)
        {
            Console.Write("Digite a nota 1 e tecle ENTER: ");
            var notaInput = Console.ReadLine();
            if (double.TryParse(notaInput, out nota1) && nota1 >= 0 && nota1 <= 10)
                break;
            Console.WriteLine("Erro: Digite uma nota válida (0-10)!");
        }

        while (true)
        {
            Console.Write("Digite a nota 2 e tecle ENTER: ");
            var notaInput = Console.ReadLine();
            if (double.TryParse(notaInput, out nota2) && nota2 >= 0 && nota2 <= 10)
                break;
            Console.WriteLine("Erro: Digite uma nota válida (0-10)!");
        }

        while (true)
        {
            Console.Write("Digite a nota 3 e tecle ENTER: ");
            var notaInput = Console.ReadLine();
            if (double.TryParse(notaInput, out nota3) && nota3 >= 0 && nota3 <= 10)
                break;
            Console.WriteLine("Erro: Digite uma nota válida (0-10)!");
        }

        // Cálculo da média
        double media = (nota1 + nota2 + nota3) / 3;

        return media;
    }

    public int Somar()
    {

        int valor = 0;
        int soma = 0;
        do
        {
            Console.WriteLine("Somador de Números");
            Console.WriteLine("");
            Console.WriteLine("<<< Digite apenas números inteiros >>>");
            Console.WriteLine("");

            while (true)
            {
                try
                {
                    Console.WriteLine("Digite um número e tecle ENTER:");
                    valor = int.Parse(Console.ReadLine());

                    soma = soma + valor;

                    Console.WriteLine("");
                    Console.WriteLine($"O subtotal dos valores digitados é {soma}");
                    Console.WriteLine("");
                    Console.WriteLine("Pressione ENTER para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Erro: Digite um número válido!");
                }
            }
        } while (valor != 0);

        return soma;
    }

    public Dictionary<string, int> CadastroDeProdutos()
    {

        Console.WriteLine("****** Cadastro de produtos ******");
        Console.WriteLine("");

        Dictionary<string, int> estoque = new Dictionary<string, int>();
        string produto;
        int quantidade;

        // Solicitar dados dos 3 produtos
        for (int i = 1; i <= 3; i++)
        {
            while (true)
            {
                Console.WriteLine($"Digite o nome do Produto {i} e tecle ENTER:");
                produto = Console.ReadLine();
                Console.WriteLine();

                if (produto == null || produto.Trim().Length == 0 )
                {
                    Console.WriteLine("O nome do produto não pode ser vazio");
                }
                else 
                {
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine($"Digite a quantidade em estoque para o Produto {i} e tecle ENTER: ");
                string input = Console.ReadLine();
                Console.WriteLine();

                if (int.TryParse(input, out quantidade) && quantidade >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Digite uma quantidade maior ou igual a zero");
                }
            }

            estoque.Add(produto, quantidade);
            Console.WriteLine("");
        }

        return estoque;
    }

    public double Divisao()
    {
        double divisao = 0.0;

        try
        {
            Console.WriteLine("Digite o primeiro número e tecle ENTER: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número e tecle ENTER: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            //Tenta dividir dois números
            divisao = num1 / num2;

            //Não ocorrendo erro, faz a divisão com números double
            divisao = (double)num1 / (double)num2;
        }
        catch (FormatException)
        {
            // Detectar entrada inválida
            Console.WriteLine("Erro: Por favor, digite apenas números inteiros válidos.");
        }
        catch (DivideByZeroException)
        {
            // Tratar divisão por zero
            Console.WriteLine("Erro: Não é possível dividir por zero.");
        }

        return divisao;
    }
}
