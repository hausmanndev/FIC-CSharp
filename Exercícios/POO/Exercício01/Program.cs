//1. * *Criando uma Classe**
//    - Crie uma classe `Pessoa` com os atributos `Nome` e `Idade`. Instancie um objeto, atribua valores e exiba no console.

class Pessoa
{
    public string nome;
    public int idade;

}

class Program
{
    public static void Main()
    {
        Pessoa p1 = new Pessoa();
        p1.nome = "Gabriel";
        p1.idade = 22;

        Console.WriteLine($"Nome: {p1.nome} | Idade: {p1.idade}");
    }
}