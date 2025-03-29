// See https://aka.ms/new-console-template for more information
//2. * *Função para Inverter String**
//    - Faça uma função que recebe uma string e retorna a string invertida.

Console.Write("Digite uma palavra / frase: ");
string s = Console.ReadLine();

static string InverterString(string s)
{
    int cont = 0;
    string sInvertido = new string(s.Reverse().ToArray());

    return sInvertido;

}

Console.WriteLine(InverterString(s));