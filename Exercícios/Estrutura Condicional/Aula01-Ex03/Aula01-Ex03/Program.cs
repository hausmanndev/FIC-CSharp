// See https://aka.ms/new-console-template for more information
//EXERCÍCIO 03
//Crie um programa que receba um número inteiro do usuário e exiba se ele é par ou ímpar.
Console.WriteLine("Digite um número");
int n = Convert.ToInt32(Console.ReadLine());

if(n % 2 == 0)
{
    Console.WriteLine($"{n} é Par");
} else
{
    Console.WriteLine($"{n} é Ímpar");
}