// See https://aka.ms/new-console-template for more information
//### **10. Números Ímpares em um Intervalo**

//Peça dois números ao usuário e exiba todos os números ímpares entre eles.

Console.Write("Digite o número inicial: ");
int nI = int.Parse(Console.ReadLine());

Console.Write("Digite o número final: ");
int nF = int.Parse(Console.ReadLine());
Console.WriteLine(" ");
Console.WriteLine("Números ímpares:");
while(nI <= nF)
{
    if(nI % 2 != 0)
    {
        Console.WriteLine(nI);
    }
    nI++;
}




