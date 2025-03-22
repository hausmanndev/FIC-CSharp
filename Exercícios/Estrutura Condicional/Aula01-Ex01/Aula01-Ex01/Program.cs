// See https://aka.ms/new-console-template for more information
//EXERCÍCIO 01
//Peça dois números inteiros ao usuário e exiba o maior entre eles.
Console.WriteLine("Digite o primeiro número");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo número");
int n2 = Convert.ToInt32(Console.ReadLine());

if(n1 > n2)
{
    Console.WriteLine($"O maior entre {n1} e {n2} é {n1}");  
} else
{
    Console.WriteLine($"O maior entre {n1} e {n2} é {n2}");
}
