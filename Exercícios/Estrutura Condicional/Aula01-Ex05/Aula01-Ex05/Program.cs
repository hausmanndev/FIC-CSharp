// See https://aka.ms/new-console-template for more information
//EXERCÍCIO 05
//Receba os coeficientes de uma equação quadrática (ax² + bx + c = 0) e calcule o delta.

//> Delta: b² - 4 * a * c
//> 

//**EXTRA**: Finalize toda a fórmula de Bhaskara, descobrindo x e x’

Console.WriteLine("Digite A");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite B");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite C");
double c = Convert.ToDouble(Console.ReadLine());

double delta = b * b - 4 * a * c;

if(delta > 0)
{
    double xp = (-b + (Math.Sqrt(delta))) / (2 * a);
    double xm = (-b - (Math.Sqrt(delta))) / (2 * a);
    Console.WriteLine($"X+ = {xp}\nX- = {xm}");
} else
{
    Console.WriteLine("Não existe solução real");
}
