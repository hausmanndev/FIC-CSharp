//// See https://aka.ms/new-console-template for more information
//1. * *Contagem de Números Pares**
//    - Peça ao usuário 10 números, armazene em um array e exiba a quantidade de números pares inseridos.

int[] nums = new int[10];
int[] pares = new int[10];

for(int i = 0; i < nums.Length; i++)
{
    Console.WriteLine($"Digite o {i} numero: ");
    nums[i] = int.Parse(Console.ReadLine());

    if (nums[i] % 2 == 0)
    {
        pares[i] = nums[i];
    }
}

Console.WriteLine("Números Pares:");
int cont = 0;
for(int i = 0; i < pares.Length; i++)
{
    if (pares[i] > 0)
    {
        Console.WriteLine(pares[i]);
        cont++;
    }
}

Console.WriteLine($"A quantidade de números pares é {cont}");