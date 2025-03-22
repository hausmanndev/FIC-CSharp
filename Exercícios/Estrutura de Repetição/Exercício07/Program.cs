// See https://aka.ms/new-console-template for more information
//### **7. Verificação de Número Primo**

//Peça um número ao usuário e verifique se ele é primo.
Console.WriteLine("Digite um número:");
int n = Convert.ToInt32(Console.ReadLine());

bool ehPrimo = true;
int cont = 2;
while(cont < n)
{
    if(n % cont == 0)
    {
        ehPrimo = false;
    }

    cont++;
}

if(ehPrimo)
{
    Console.WriteLine($"O número {n} é primo!");
} else
{
    Console.WriteLine($"O número {n} não é primo!");
}