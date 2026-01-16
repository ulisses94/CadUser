using System;

namespace EstudoCSharpDia1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"\nBem-vindo, {nome}!");
        }
    }
}