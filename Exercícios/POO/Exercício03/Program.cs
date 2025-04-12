//3. * *Encapsulamento - Propriedades * *
//    -Modifique a classe `Pessoa` para que `Idade` só possa ser alterada se o valor for maior que zero.

class Pessoa
{
    int idade = 22;


    public void AlteraIdade()
    {
        Console.Write("Digite a nova idade: ");
        int novaIdade = int.Parse(Console.ReadLine());

        if (novaIdade > 0)
        {
            idade = novaIdade;
            Console.WriteLine($"A nova idade é {idade}.");
        }
        else
        {
            Console.WriteLine($"Idade inalterada. Idade: {idade}");
        }
    }

    public static void Main()
    {
        Pessoa p1 = new Pessoa();
        p1.AlteraIdade();
    }
}