// See https://aka.ms/new-console-template for more information
//2. * *Maior e Menor Valor**
//    - Peça ao usuário 10 números e armazene-os em um array. Em seguida, exiba o maior e o menor valor inserido.

int[] nums = new int[10];

for(int i = 0; i < nums.Length; i++)
{
    Console.Write($"Digite o {i + 1} número: ");
    nums[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine($"O maior número do array é {Enumerable.Max(nums)}");
Console.WriteLine($"O menor número do array é {Enumerable.Min(nums)}");
//Console.WriteLine($"O menor número do array é {nums[0]}");