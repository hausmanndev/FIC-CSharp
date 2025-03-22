// See https://aka.ms/new-console-template for more information
//### **9. Fatorial de um Número (Com Limite)**

//Peça um número ao usuário (limite de 10) e calcule seu fatorial.
int mult;
for(int i = 0; i < 10; i++)
{
    Console.Write($"Digite o {i+1} número:");
    int n = int.Parse(Console.ReadLine());
    int fat = n;

    mult = 1;
    while(n >= 1)
    {
        mult *= n;
        n--;
    }

    Console.WriteLine($"O !{fat} é = {mult}");
}
