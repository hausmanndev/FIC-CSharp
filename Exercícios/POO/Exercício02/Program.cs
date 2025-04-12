//2. * *Métodos Simples * *
//    -Adicione à classe `Pessoa` um método `ExibirDados()` que imprime o nome e a idade no console.

class Pessoa
{
    string nome = "Gabriel";
    int idade = 22;


    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {nome} | Idade: {idade}");
    }

    public static void Main()
    {
        Pessoa p1 = new Pessoa();
        p1.ExibirDados();
    }
}