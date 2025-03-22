// See https://aka.ms/new-console-template for more information
//### **4. Soma de 1 a N**

//Solicite ao usuário um número inteiro positivo (N) e calcule a soma de todos os números de 1 até N.
Console.WriteLine("Digite um número:");
int n = Convert.ToInt32(Console.ReadLine());

int soma = 0;
int cont = 1;
while(cont <= n)
{
    soma += cont;
    cont++;
}

Console.WriteLine($"SOMA = {soma}");