// See https://aka.ms/new-console-template for more information
//### **3. Contagem de Números Positivos**

//Peça ao usuário para inserir 5 números inteiros e exiba quantos deles são positivos.
int cont = 0;
for(int i=0; i<5; i++)
{
    Console.WriteLine($"Digite o {i+1} número: ");
    int n = Convert.ToInt32(Console.ReadLine());

    if(n > 0)
    {
        cont++;
    }
}

Console.WriteLine($"Você digitou {cont} números positivos");
