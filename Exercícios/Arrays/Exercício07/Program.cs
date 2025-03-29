// See https://aka.ms/new-console-template for more information
//1. * *Remover Duplicatas * *
//    -Receba 10 números em um array e exiba-os sem valores duplicados.

int[] valores = { 2, 5, 7, 2, 8, 9, 4, 5, 6, 10 };
List<int> duplicados = new List<int>();

for(int i = 0; i < valores.Length; i++)
{
    for(int j = i+1; j < valores.Length; j++)
    {
        if (valores[i] == valores[j])
        {
            duplicados.Add(valores[i]);
        }
    }
}
