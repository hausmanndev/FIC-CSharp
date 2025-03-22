// See https://aka.ms/new-console-template for more information
//EXERCÍCIO 04
//Receba três números e determine o maior entre eles.
Console.WriteLine("Digite o primeiro número");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo número");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o terceiro número");
int n3 = Convert.ToInt32(Console.ReadLine());

int maior;

if(n1 > n2 && n1 > n3)
{
    maior = n1;
} else if(n2 > n1 && n2 > n3)
{
    maior = n2;
} else
{
    maior = n3;
}

Console.WriteLine($"O maior número entre {n1}, {n2} e {n3} é {maior}");
