// See https://aka.ms/new-console-template for more information
//3. * *Função para Contar Vogais**
//    - Escreva uma função que recebe uma string e retorna a quantidade de vogais nela.

Console.Write("Digite uma palavra / frase: ");
string s = Console.ReadLine();

static int ContaVogais(string s)
{
    int nVogais = 0, i = 0, j = 0;
    char[] vogais = {'a', 'e', 'i', 'o', 'u'};
    var vogaisList = vogais.ToList(); //Convertendo o Array de char vogais em uma lista
    s.ToLower().ToCharArray(); //Mudando toda a string para minúscula e transformando em um Array de char
    foreach(char letra in s)
    {
        if(vogaisList.Contains(letra))
        {
            nVogais++;
        }
    }

    return nVogais;
}

Console.WriteLine(ContaVogais(s));