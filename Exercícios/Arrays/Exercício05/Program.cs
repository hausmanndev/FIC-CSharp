// See https://aka.ms/new-console-template for more information
//2. * *Inversão de Elementos**
//    - Crie um programa que recebe 8 números em um array e exibe os valores na ordem inversa à que foram inseridos.

int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8 };

for (int i = nums.Length - 1; i >= 0; i--)
{
    Console.WriteLine(nums[i]);
}
