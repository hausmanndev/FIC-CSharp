// See https://aka.ms/new-console-template for more information
//EXERCÍCIO 04
//Escreva um programa que recebe três números e imprime a média aritmética deles.
Console.WriteLine("Digite o primeiro número");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo número");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o terceiro número");
int n3 = Convert.ToInt32(Console.ReadLine());

int soma = n1 + n2 + n3;

Console.WriteLine($"Média = {soma/Convert.ToDouble(3)}");