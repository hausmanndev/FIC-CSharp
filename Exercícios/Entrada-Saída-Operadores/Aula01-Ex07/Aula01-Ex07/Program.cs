// See https://aka.ms/new-console-template for more information
//EXERCÍCIO
//Escreva um programa que recebe um número e imprime `1` se for par e `0` se for ímpar.
Console.WriteLine("Digite um número");
int n = Convert.ToInt32(Console.ReadLine());

if(n % 2 == 0)
{
    Console.WriteLine(1);
} else
{
    Console.WriteLine(0);
}