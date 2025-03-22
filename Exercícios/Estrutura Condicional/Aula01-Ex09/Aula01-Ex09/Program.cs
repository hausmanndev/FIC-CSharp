// See https://aka.ms/new-console-template for more information
//EXERCÍCIO 09
//Receba uma nota e classifique-a conforme a seguinte tabela:

//-**A * *(90 - 100)
//- **B * *(80 - 89)
//- **C * *(70 - 79)
//- **D * *(60 - 69)
//- **F * *(menor que 60)
Console.WriteLine("Digite a nota");
double nota = Convert.ToDouble(Console.ReadLine());

if (nota >= 90 && nota <= 100)
{
    Console.WriteLine("Tirou A");
} else if(nota >= 80 && nota <= 89)
{
    Console.WriteLine("Tirou B");
} else if(nota >= 70 && nota <= 79)
{
    Console.WriteLine("Tirou C");
} else if(nota > 60 && nota <= 69)
{
    Console.WriteLine("Tirou D");
} else 
{
    Console.WriteLine("Tirou F");
}