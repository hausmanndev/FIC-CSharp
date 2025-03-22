// See https://aka.ms/new-console-template for more information
//EXERCÍCIO 06
//Crie um programa que recebe dois números e uma operação (+, -, *, /) e realiza o cálculo correspondente.
Console.WriteLine("Digite a operação");
double n1 = Convert.ToDouble(Console.ReadLine());
char opcao = Convert.ToChar(Console.ReadLine());
double n2 = Convert.ToDouble(Console.ReadLine());

switch (opcao)
{
    case '+':
        Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
        break;
    case '-':
        Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
        break;
    case '*':
        Console.WriteLine($"{n1} x {n2} = {n1 * n2}");
        break;
    case '/':
        Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
        break;
}


