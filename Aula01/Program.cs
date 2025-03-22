// See https://aka.ms/new-console-template for more information
/*
//ENTRADA E SAÍDA DE DADOS
const string nome = "Gabriel"; //Declarando uma constante com o CONST;
int idade = 22;
char genero = 'M';
float altura = 1.68f;
double pi = 3.1415;
bool estudante = true;


Console.WriteLine("Hello, World!"); //Comando de saída de dados CONSOLE.WriteLine();
Console.WriteLine("Nome: "+nome);
Console.WriteLine($"Idade: {idade}");
Console.WriteLine($"Genero: {genero}");
Console.WriteLine($"Altura: {altura}\nEstudante: {estudante}");
Console.WriteLine($"PI: {pi}");

Console.WriteLine("Qual seu nome completo? ");
string nomeCompleto = Console.ReadLine(); //Comando de entrada de dados com String CONSOLE.ReadLine();
Console.WriteLine($"Bem vindo ao curso de C# {nomeCompleto}");

Console.WriteLine("Qual seu peso?");
double peso = Convert.ToDouble(Console.ReadLine()); //Comando de entrada de dados covertendo no tipo desejado;
Console.WriteLine($"Seu peso é {peso}");

Console.WriteLine("Qual a sua nova altura?");
altura = float.Parse(Console.ReadLine()); //Comando de entrada de dados convertendo em FLOAT;
Console.WriteLine($"Sua nova altura é {altura}");

Console.WriteLine();
*/
/*
//OPERADORES
Console.WriteLine("OPERADORES");
Console.WriteLine("Soma -> [ + ]");
Console.WriteLine("5 + 10 = "+ (5 + 10));
Console.WriteLine("Divisão -> [ / ]");
Console.WriteLine("2 / 10 = "+Convert.ToDouble(2) / (double)10); //Tem que converter para sair um número decimal;
Console.WriteLine("Multiplicação -> [ * ]");
Console.WriteLine("5 x 2 = "+5 * 2);
Console.WriteLine("Resto da divisão -> [ % ]");
Console.WriteLine("Resto da divisão de 5 / 2 = "+5 % 2);
Console.WriteLine();
*/

/*
//OPERADORES DE COMPARAÇÃO
Console.WriteLine("OPERADORES DE COMPARAÇÃO");
int valorPadrao = 20;
Console.WriteLine("Operador de igual -> [ == ]");
Console.WriteLine($" {valorPadrao} == 20: {valorPadrao == 20}");
Console.WriteLine("Operador de maior -> [ > ]");
Console.WriteLine($" {valorPadrao} > 20: {valorPadrao > 20}");
Console.WriteLine("Operador de menor -> [ < ]");
Console.WriteLine($" {valorPadrao} < 20: {valorPadrao < 20}");
Console.WriteLine("Operador de maior ou igual -> [ >= ]");
Console.WriteLine($" {valorPadrao} >= 20: {valorPadrao >= 20}");
Console.WriteLine("Operador de menor ou igual -> [ <= ]");
Console.WriteLine($" {valorPadrao} <= 20: {valorPadrao <= 20}");
Console.WriteLine("Operador de diferente -> [ != ]");
Console.WriteLine($" {valorPadrao} != 20: {valorPadrao != 20}");
Console.WriteLine();
*/

/*
//TABELA VERDADE
Console.WriteLine("TABELA VERDADE");
Console.WriteLine("AND -> &&");
Console.WriteLine($"True && True = {true}");
Console.WriteLine($"True && False = {false}");
Console.WriteLine($"False && True = {false}");
Console.WriteLine($"False && False = {false}");
Console.WriteLine();
Console.WriteLine("OR -> ||");
Console.WriteLine($"True || True = {true}");
Console.WriteLine($"True || False = {true}");
Console.WriteLine($"False || True = {true}");
Console.WriteLine($"False || False = {false}");
Console.WriteLine();
Console.WriteLine("NOT -> !");
Console.WriteLine($"!True = {false}");
Console.WriteLine($"!False = {true}");
Console.WriteLine();
*/

/*
//ESTRUTURA CONDICIONAL
//IF ELSE
string usuario = "admin";
string senha = "Admin@25";
Console.WriteLine("Digite o seu usuario\n>");
string usuarioInserido = Console.ReadLine();
Console.WriteLine("Digite a sua senha\n>");
string senhaInserida = Console.ReadLine();

if(usuario == usuarioInserido && senha == senhaInserida)
{
    Console.WriteLine("Login efetuado com sucesso!!");
} else if(usuario == usuarioInserido && senha != senhaInserida)
{
    Console.WriteLine($"Senha inválida para {usuario}");
} else
{
    Console.WriteLine("Falha ao efetuar o login!");
}
*/

//SWITCH CASE
Console.WriteLine("Para qual marcha eu devo trocar?");
char marcha = Convert.ToChar(Console.ReadLine());
switch(marcha)
{
    case '1':
        Console.WriteLine("Primeira marcha");
        break;
    case '2':
        Console.WriteLine("Segunda marcha");
        break;
    case '3':
        Console.WriteLine("Terceira marcha");
        break;
    default:
        Console.WriteLine("Inválido");
        break;
}

string motivoPiscaAlerta = marcha == '1' ? "Ligou por conta da marcha" : "Ligou por outro motivo";



