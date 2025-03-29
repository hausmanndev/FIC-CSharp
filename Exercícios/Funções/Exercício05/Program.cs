// See https://aka.ms/new-console-template for more information
//2. * *Função para Inverter String**
//    - Faça uma função que recebe uma string e retorna a string invertida.

Console.Write("Digite uma palavra / frase: ");
string s = Console.ReadLine();

static string InverterString(string s)
{

    //string sInvertido = new string(s.Reverse().ToArray());
    var sChar = s.ToCharArray();
    string sInvertido = "";
    for (int i = sChar.Length; i > 0; i--)
    {
        sInvertido += sChar[i-1];
        //Console.WriteLine(sInvertido);
    }

    return sInvertido;

}

Console.WriteLine(InverterString(s));