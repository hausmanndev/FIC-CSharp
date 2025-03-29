// See https://aka.ms/new-console-template for more information
//2. * *Função de Média**
//    - Faça uma função que recebe um array de números e retorna a média dos valores.

using System.Net.Http.Headers;

List<double> nums = new List<double>();

for(int i=0; i<3; i++)
{
    Console.Write($"Digite o número {i+1}: ");
    nums.Add(double.Parse(Console.ReadLine()));
}

static double CalcularMedia(List<double> nums)
{
    double media;
    media = nums.Sum() / nums.Count();

    return media;
}

Console.WriteLine(CalcularMedia(nums));

