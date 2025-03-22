// See https://aka.ms/new-console-template for more information
//### **8. Jogo de Adivinhação (Mais Simples)**

//Você escolhe um número entre 1 e 50, e o usuário tenta adivinhar.
//Após cada tentativa, o programa diz se o número é maior ou menor.

int secreto = 37;

while(true)
{
    Console.WriteLine("Intervalo [1,50]");
    Console.WriteLine("Adivinhe qual o número secreto: ");
    int tentativa = Convert.ToInt32(Console.ReadLine());

    if(tentativa == secreto)
    {
        Console.WriteLine("Parabéns, você acertou o número secreto!");
        break;
    } else if(tentativa > secreto)
    {
        Console.WriteLine($"O número {tentativa} é maior que o número secreto");
    } else
    {
        Console.WriteLine($"O número {tentativa} é menor que o número secreto");
    }
}

