// See https://aka.ms/new-console-template for more information
//3. * *Média dos Valores**
//    - Receba 6 números inteiros e armazene-os em um array. Depois, calcule e exiba a média dos valores.



int[] nums = new int[6];
double soma = 0;

for (int i =0; i < nums.Length; i++)
{
    Console.WriteLine($"Digite o {i} número");
    nums[i] = int.Parse(Console.ReadLine());

    soma += nums[i];
}

double media = soma / nums.Length;
Console.WriteLine($"MEDIA = {media}");