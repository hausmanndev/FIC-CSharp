// See https://aka.ms/new-console-template for more information
//EXERCÍCIO 07
//using static System.Runtime.InteropServices.JavaScript.JSType;

//Crie um programa que recebe um ano e verifica se ele é bissexto.

//https://learn.microsoft.com/pt-br/office/troubleshoot/excel/determine-a-leap-year

//> Qualquer ano que seja uniformemente divisível por 4 é um ano bissexto: por exemplo, 1988, 1992 e 1996 são anos bissextos.
//> 

//> No entanto, ainda há um pequeno erro que deve ser contabilizado. Para eliminar esse erro, o calendário gregoriano estipula que 
//um ano que é uniformemente divisível por 100 (por exemplo, 1900) é um ano bissexto apenas se também é igualmente divisível por 400.

Console.WriteLine("Digite o ano");
int ano = Convert.ToInt32(Console.ReadLine());

if((ano % 4 == 0) && (ano % 100 == 0) && (ano % 400 == 0))
{
    Console.WriteLine("É um ano bissexto");
} else
{
    Console.WriteLine("Não é um ano bissexto");
}

