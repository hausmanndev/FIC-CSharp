//3. * *Polimorfismo - Sobrecarga * *
//    -Adicione um método `Apresentar()` na classe `Pessoa`,
//    que pode ser chamado sem parâmetros ou recebendo um `string sobrenome` para exibir um nome completo.

class Pessoa
{
    private string Nome;
    private int Idade;

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public virtual void ExibirDados()
    {
        Console.Write($"Nome: {Nome} | Idade: {Idade} | ");
    }

    //No método Apresentar() e Apresentar(string sobrenome) ocorre o Polimorfismo por Sobrecarga
    public void Apresentar()
    {
        Console.WriteLine($"Olá meu nome é {Nome}");
    }

    public void Apresentar(string sobrenome)
    {
        Console.WriteLine($"Olá meu nome é {Nome} {sobrenome}");
    }

}

class Funcionario : Pessoa
{
    private double salario;

    public Funcionario(string nome, int idade, double salario) : base(nome, idade)
    {
        this.salario = salario;
        //O {this} se refere a variável salario declarada no início da classe Funcionario.
    }

    public override void ExibirDados()
    {
        base.ExibirDados();
        Console.WriteLine($"Salário: {salario}.");
    }
}

class Program
{
    public static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());
        Console.Write("Digite seu salário: ");
        double salario = double.Parse(Console.ReadLine());

        Funcionario funcionario = new Funcionario(nome, idade, salario);

        funcionario.ExibirDados();
        funcionario.Apresentar("Hausmann");
    }
}