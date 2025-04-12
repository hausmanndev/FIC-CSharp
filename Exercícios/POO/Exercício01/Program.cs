//1. * *Criando uma Classe**
//    - Crie uma classe `Pessoa` com os atributos `Nome` e `Idade`. Instancie um objeto, atribua valores e exiba no console.

class Pessoa
{
    private string nome;
    private int idade;

    public void CriarPessoa()
    {
        Console.WriteLine("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Digite sua idade: ");
        idade = int.Parse(Console.ReadLine());
    }
    public void MostrarPessoa()
    {
        Console.WriteLine($"O nome da pessoa é {nome} e sua idade é {idade}.");
    }

}

class Program
{
    public static void Main()
    {
        Pessoa p1 = new Pessoa();
        p1.CriarPessoa();
        p1.MostrarPessoa();
    }
}