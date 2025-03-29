// See https://aka.ms/new-console-template for more information
//3. * *Função de Par ou Ímpar**
//    - Escreva uma função que recebe um número e retorna "Par" ou "Ímpar".

Console.Write("Digite um número: ");
int n = int.Parse(Console.ReadLine());

static void ParOuImpar(int n)
{
    if(n % 2 == 0)
    {
        Console.WriteLine($"O número {n} é PAR!");
    } else
    {
        Console.WriteLine($"O número {n} é ÍMPAR!");
    }
}

ParOuImpar(n);