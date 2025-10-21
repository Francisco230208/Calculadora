int opcao = -1;

while (opcao != 0)
{
    Console.WriteLine("Seja bem vindo a Calculadora Lok");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Escolha uma das opções abaixo");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("0 - Sair");

    opcao = int.Parse(Console.ReadLine());
    if (opcao == 0)

    {
        Console.WriteLine("Saindo... Obrigado por usar a calculadora!");
        break;
    }

    Console.WriteLine("Digite o primerio numero");
    float numero1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo numero");
    float numero2 = float.Parse(Console.ReadLine());

    float resultado = 0;

    switch (opcao)
    {
        case 1:
            resultado = soma(numero1, numero2);
            Console.WriteLine($"O resultado da soma é {resultado}");
            break;
        case 2:
            resultado = subtracao(numero1, numero2);
            Console.WriteLine($"O resultado da subtração é {resultado}");
            break;
        case 3:
            resultado = multiplicacao(numero1, numero2);
            Console.WriteLine($"O resultado da multiplicacao é {resultado}");
            break;
        case 4:
            if (numero2 == 0)
            {
                Console.WriteLine("ERRO, A DIVISÃO POR 0 NÃO É PERMITIDA");
            }
        else
        {
                resultado = divisao(numero1, numero2);
                Console.WriteLine($"O resultado da divisão é {resultado}");
                break;
        }
            break;

    }

}

//FUNCAO

float soma(float soma1, float soma2)
{
    return soma1 + soma2;
}

float subtracao(float subtracao1, float subtracao2)
{
    return subtracao1 - subtracao2;
}

float multiplicacao(float multiplicacao1, float multiplicacao2)
{
    return multiplicacao1 * multiplicacao2;
}

float divisao(float divisao1, float divisao2)
{
    return divisao1 / divisao2;
}

