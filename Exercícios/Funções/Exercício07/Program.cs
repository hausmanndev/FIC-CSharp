//1. * *Função para Verificar Número Primo**
//    - Crie uma função que recebe um número e retorna se ele é primo ou não.

Console.WriteLine("Digite um número: ");
int n = int.Parse(Console.ReadLine());

static void VerificaPrimo(int n)
{
    int cont = 2;
    bool ehPrimo = true;
    while(cont < n)
    {
        if(n % cont == 0)
        {
            ehPrimo = false;
        }
        cont++;
    }

    if (ehPrimo)
    {
        Console.WriteLine($"O número {n} É PRIMO!");
    } else
    {
        Console.WriteLine($"O número {n} NÃO É PRIMO!");
    }
}

VerificaPrimo(n);