// See https://aka.ms/new-console-template for more information
//EXERCÍCIO 02
//Peça a idade do usuário e classifique-o como:

//-"Criança"(0 a 12 anos)
//- "Adolescente"(13 a 17 anos)
//- "Adulto"(18 anos ou mais)
Console.WriteLine("Digite sua idade");
int idade = Convert.ToInt32(Console.ReadLine());

if(idade >= 0 && idade <= 12)
{
    Console.WriteLine("Criança");
} else if(idade >= 13 && idade <= 17)
{
    Console.WriteLine("Adolescente");
} else
{
    Console.WriteLine("Adulto");
}