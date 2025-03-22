// See https://aka.ms/new-console-template for more information
//EXERCÍCIO 08
//Escreva um programa que recebe três números e imprime o maior deles sem utilizar if/else ou laços de repetição.
Console.WriteLine("Digite o primeiro número");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo número");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o terceiro número");
int n3 = Convert.ToInt32(Console.ReadLine());

int maiorN1N2 = Math.Max(n1, n2);
int maior = Math.Max(n2, n3);

Console.WriteLine($"O maior número entre {n1}, {n2} e {n3} é {maior}");
