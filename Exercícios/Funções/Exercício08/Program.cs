//2. * *Função de Busca em Array**
//    - Faça uma função que recebe um array e um número, retornando `true`
//    se o número estiver no array e `false` caso contrário.
int[] array = new int[5];
for (int i = 0; i < 5; i++)
{
    Console.Write($"Digite o número {i+1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Digite um número: ");
int n = Convert.ToInt32(Console.ReadLine());

static bool VerificaArray(int[] array, int n)
{
    foreach(int i in array)
    {
        if(n == i)
        {
            return true;
        }
    }

    return false;
}

Console.WriteLine(VerificaArray(array, n));