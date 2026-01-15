static void ObterNumeroValidado (out int numero)
{
    while (true)
    {
        Console.Write("Informe um número: ");
        string? entrada = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(entrada))
        {
            Console.WriteLine("Erro: o valor informado não pode ser vazio.\n");
            continue;
        }

        if (!int.TryParse(entrada, out numero))
        {
            Console.WriteLine("Erro, o valor informado não é do tipo numérico.\n");
            continue;
        }

        if(numero < 0)
        {
            Console.WriteLine("Erro, o valor informado não pode ser negativo.\n");
            continue;
        }

        Console.WriteLine($"O número informado foi: {numero}.");
        break;
    }
}

int numero;

ObterNumeroValidado (out numero);