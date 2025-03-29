// See https://aka.ms/new-console-template for more information
//1. * *Função de Soma**
//    - Crie uma função que recebe dois números e retorna a soma deles.

static double Somar()
{
    List<double> nums = new List<double>();

    for(int i = 0; i < 3; i++)
    {
        Console.Write($"Digite o número {i+1}: ");
        nums.Add(Convert.ToDouble(Console.ReadLine()));
    }

    double soma = nums.Sum() / nums.Count();
    return soma;
}

Console.WriteLine(Somar());
