// See https://aka.ms/new-console-template for more information
//3. * *Frequência de um Número**
//    - Peça ao usuário 10 números e um número adicional.
//    O programa deve contar e exibir quantas vezes esse número aparece no array.

int[] nums = new int[10];
int numAdicional;
int cont = 0;

for(int i = 0; i < nums.Length; i++)
{
    Console.Write($"Digite o {i+1} número: ");
    nums[i] = int.Parse(Console.ReadLine());
}

Console.Write("Digite um número adicional: ");
numAdicional = int.Parse(Console.ReadLine());

for(int i = 0; i < nums.Length;i++)
{
    if (nums[i] == numAdicional)
    {
        cont++;
    }
}

Console.WriteLine($"O número {numAdicional} aparece {cont} vezes no array!");

