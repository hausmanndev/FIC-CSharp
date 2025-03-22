// See https://aka.ms/new-console-template for more information
//EXERCÍCO 05
//Escreva um programa que recebe dois números e imprime o resto da divisão do primeiro pelo segundo.
Console.WriteLine("Digite o primeiro número");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo número");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O resto da divisão de {n1} por {n2} = {n1 % n2}");
