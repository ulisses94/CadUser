using System;
using System.Net;

namespace EstudoCSharpDia2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Função para Validação de Inteiro
            static void ObterIdadeValidada(out int numero)
            {
                while (true)
                {
                    Console.Write("Informe sua idade: ");
                    string? entrada = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(entrada))
                    {
                        Console.WriteLine("Erro: o valor informado não pode ser vazio, tente novamente.\n");
                        continue;
                    }
                    if (!int.TryParse(entrada, out numero))
                    {
                        Console.WriteLine("Erro: o valor informado não é numérico, tente novamente.\n");
                        continue;
                    }
                    if (numero < 0)
                    {
                        Console.WriteLine("Erro: o valor informado não pode ser negativo, tente novamente.\n");
                        continue;
                    }
                    break;
                }
            }

            //Função para Validação de Nome de Cidade
            static void ObterNomeCidade(out string nomeCidade)
            {
                while (true)
                {
                    Console.Write("Informe o nome da cidade onde você mora: ");
                    string? entrada = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(entrada))
                    {
                        Console.WriteLine("Erro: o nome da cidade não pode ser vazio, tente novamente.\n");
                        continue;
                    }
                    nomeCidade = entrada;
                    break;
                }
            }

            //Função para Validação de Altura
            static void ObterAlturaValidada(out double altura)
            {
                while (true)
                {
                    Console.Write("Informe a sua altura: ");
                    string? entrada = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(entrada))
                    {
                        Console.WriteLine("Erro: o valor informado não pode ser vazio, tente novamente.\n");
                        continue;
                    }
                    if (!double.TryParse(entrada, out altura))
                    {
                        Console.WriteLine("Erro: o valor não é composto por números, tente novamente.\n");
                        continue;
                    }
                    if (altura < 0)
                    {
                        Console.WriteLine("Erro, o valor não pode ser negativo, tente novamente.\n");
                        continue;
                    }
                    break;
                }
            }

            //Função para Validação de Altura
            static void ObterNomeValidado(out string nomePessoa)
            {
                while (true)
                {
                    Console.Write("Informe seu nome: ");
                    string? entrada = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(entrada))
                    {
                        Console.WriteLine("Erro, o nome não pode ser vazio, tente novamente.\n");
                        continue;
                    }
                    nomePessoa = entrada;
                    break;
                }
            }

            string? nome;
            int idade;
            string? cidade;
            double altura;


            ObterNomeValidado(out nome);
            ObterIdadeValidada(out idade);
            ObterNomeCidade(out cidade);
            ObterAlturaValidada(out altura);

            Console.WriteLine("\n--- Dados informados ---");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Cidade: {cidade}");
            Console.WriteLine("Altura: " + altura.ToString("F2") + "\n");

            Console.WriteLine($"Parabens {nome}, você mora em {cidade}, tem {idade} anos e sua altura é de " + altura.ToString("F2") + ".");
            Console.Write("\nPressione qualquer tecla para encerrar a aplicação...");
            Console.ReadKey();
        }
    }
}