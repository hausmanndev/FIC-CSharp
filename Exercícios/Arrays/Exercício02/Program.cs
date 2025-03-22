// See https://aka.ms/new-console-template for more information
//2. * *Maior e Menor Valor**
//    - Peça ao usuário 10 números e armazene-os em um array. Em seguida, exiba o maior e o menor valor inserido.

/*List<int> numeros = new List<int>(); //Declarando uma lista

for(int i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite o {i+1} número: ");
    numeros.Add(int.Parse(Console.ReadLine())); //Para adicionar valores em uma lista usa-se .Add
}

var maiorNumero = 0;
for (int i = 0; i < numeros.Count; i++)
{
    if (numeros[i] > maiorNumero)
    {
        maiorNumero = numeros[i];
    }
}

var menorNumero = maiorNumero;
for(int i = 0; i < numeros.Count; i++)
{
    if (numeros[i] < menorNumero)
    {
        menorNumero = numeros[i];
    }
}

Console.WriteLine($"O menor número é {menorNumero}");
Console.WriteLine($"O maior número é {maiorNumero}");*/

// - - - - - - - - - - - - - - //

int[] nums = new int[10];

for (int i = 0; i < nums.Length; i++)
{
    Console.Write($"Digite o {i + 1} número: ");
    nums[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine($"O maior número do array é {nums.Max()}");
Console.WriteLine($"O menor número do array é {nums.Min()}");