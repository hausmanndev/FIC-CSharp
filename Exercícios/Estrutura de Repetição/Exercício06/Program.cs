// See https://aka.ms/new-console-template for more information
//### **6. Contagem Regressiva**

//Solicite um número ao usuário e exiba uma contagem regressiva até 0.
Console.WriteLine("Digite um número: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

while(n >= 0)
{
    Console.WriteLine(n);
    n--;
}
