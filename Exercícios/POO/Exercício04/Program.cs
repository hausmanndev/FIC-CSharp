//1. * *Construtores * *
//    -Adicione um construtor à classe `Pessoa` que recebe `Nome` e `Idade` como parâmetros ao instanciar um objeto.

class Pessoa
{
    string Nome;
    int Idade;
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public static void Main()
    {
        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();
        Console.Write("Digte a idade: ");
        int idade = int.Parse(Console.ReadLine());
        Pessoa p1 = new Pessoa(nome, idade);
        Console.WriteLine($"Nome: {p1.Nome} | Idade: {p1.Idade}");
    }
}