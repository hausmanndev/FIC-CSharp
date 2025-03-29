// See https://aka.ms/new-console-template for more information
//1. * *Função de Soma**
//    - Crie uma função que recebe dois números e retorna a soma deles.
List<double> nums = new List<double>();

for (int i = 0; i < 2; i++)
{
    Console.Write($"Digite o número {i + 1}: ");
    nums.Add(Convert.ToDouble(Console.ReadLine()));
}

static double Somar(List<double> nums)
{
    double soma = nums.Sum();
    return soma;
}

Console.WriteLine(Somar(nums));
