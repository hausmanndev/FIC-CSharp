// See https://aka.ms/new-console-template for more information
//EXERCÍCIO 08
//Receba três valores numéricos e verifique se eles podem formar um triângulo.
//Caso possam, determine se ele é equilátero, isósceles ou escaleno.

Console.WriteLine("Digite o primeiro valor");
double n1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o segundo valor");
double n2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o terceiro valor");
double n3 = Convert.ToDouble(Console.ReadLine());

if((n1 + n2 > n3) || (n2 + n3 > n1) || (n1 + n3 > n2))
{
    if(n1 == n2 && n2 == n3)
    {
        Console.WriteLine("É um triângulo equilátero. Possuí todos os lados iguais");
    } else if((n1 == n2 && n3 != n1) || (n1 == n2 && n3 != n2) || (n2 == n3 && n1 != n3) || 
        (n2 == n3 && n1 != n2) || (n3 == n1 && n2 != n1) || (n3 == n1 && n2 != n3))
    {
        Console.WriteLine("É um triângulo isósceles. Possuí dois lados iguais");
    } else
    {
        Console.WriteLine("É um triângulo escaleno. Possuí todos os lados diferentes");
    }
} else
{
    Console.WriteLine("Não é possível formar um triângulo");
}

