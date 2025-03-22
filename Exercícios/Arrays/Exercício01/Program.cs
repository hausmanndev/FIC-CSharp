// See https://aka.ms/new-console-template for more information
//1. * *Soma dos Elementos**
//    - Crie um programa que receba 5 números inteiros, armazene-os em um array e exiba a soma total dos elementos.

int[] numeros = new int[5];
int soma = 0;

for(int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Digite o {i+1} número: ");
    numeros[i] = int.Parse(Console.ReadLine());

    soma += numeros[i];
}

Console.WriteLine($"SOMA = {soma}");
