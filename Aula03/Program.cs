// See https://aka.ms/new-console-template for more information
// FUNÇÕES

static double Somar(double n1, double n2)
{
    return n1 + n2;
}

static void MostrarSoma()
{
    Console.Write("Digite o primeiro número: ");
    double n1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    double n2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine($"A soma entre os dois números é igual a {Somar(n1, n2)}");
}

MostrarSoma();
