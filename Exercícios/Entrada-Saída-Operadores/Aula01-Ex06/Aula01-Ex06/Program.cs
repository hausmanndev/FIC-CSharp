// See https://aka.ms/new-console-template for more information
//EXERCÍCO 06
//Escreva um programa que troca os valores de duas variáveis sem usar variável auxiliar.
int n1 = 20;
int n2 = 30;
Console.WriteLine($"n1 = {n1}, n2 = {n2}");

n1 = n1 + n2;
n2 = n1 - n2;
n1 = n1 - n2;
Console.WriteLine($"n1 = {n1}, n2 = {n2}");

