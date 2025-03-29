// See https://aka.ms/new-console-template for more information
//1. * *Função de Fatorial**
//    - Implemente uma função que recebe um número e retorna seu fatorial.

Console.Write("Digite um número: ");
int n = Convert.ToInt32(Console.ReadLine());

static int Fatorar(int n)
{
    int fatorial = 1;
    while(n > 1)
    {
        fatorial *= n;
        n--;
    }

    return fatorial;
}

Console.WriteLine(Fatorar(n));