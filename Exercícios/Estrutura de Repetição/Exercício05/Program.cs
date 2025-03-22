// See https://aka.ms/new-console-template for more information
//### **5. Média de Notas**

//Peça ao usuário para inserir 5 notas e calcule a média.
float media, soma = 0;
for (int i=0; i<5; i++)
{
    Console.WriteLine($"Digite a {i+1} nota:");
    float nota = float.Parse(Console.ReadLine());

    soma += nota;
}

media = soma / 5;
Console.WriteLine($"MEDIA = {media}");