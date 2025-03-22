// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*
bool estalogado = false;

string nome = "Gabriel";
string senha = "1234#Aa";

while (!estalogado)
{
    Console.WriteLine("Digite seu nome: ");
    string nomeDigitado = Console.ReadLine();

    Console.WriteLine("Digite sua senha: ");
    string senhaDigitada = Console.ReadLine();

    if(nome == nomeDigitado && senha == senhaDigitada)
    {
        Console.WriteLine("Login efetuado com sucesso!");
        estalogado = true;
    } else
    {
        Console.WriteLine("Usuário ou senha inválido!");
    }
}
*/

/*
do
{
    Console.WriteLine("Digite seu nome: ");
    string nomeDigitado = Console.ReadLine();

    Console.WriteLine("Digite sua senha: ");
    string senhaDigitada = Console.ReadLine();

    if (nome == nomeDigitado && senha == senhaDigitada)
    {
        Console.WriteLine("Login efetuado com sucesso!");
        estalogado = true;
    }
    else
    {
        Console.WriteLine("Usuário ou senha inválido!");
    }

} while (!estalogado);
*/

/*
for(int cont = 0; cont <= 10; cont++)
{
    Console.WriteLine(cont);
}
*/


//Array
/*int[] numeros = new int[5];
int[] valores = { 10, 20, 30, 40, 50 };

Console.WriteLine(valores[1]);

for(int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Digite o {i+1} numero: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

for(int i = 0; i < 5; i++)
{
    Console.WriteLine($"Número {i+1}: {numeros[i]}");
}*/

/*string[] textos = new string[5];

for (int i = 0; i < textos.Length; i++)
{
    Console.WriteLine($"Digite o {i + 1} texto: ");
    textos[i] = Console.ReadLine();
}
Console.WriteLine(" ");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"String {i + 1}: {textos[i]}");
}*/

//Lista
List<string> nomes = new List<string>();
List<int> idades = new();
List<float> pesos = new();


