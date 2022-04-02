int numero;

Console.Write("Insira um número: ");
numero = Convert.ToInt32(Console.ReadLine());

bool numeropar = (numero % 2) == 0;

if (numeropar)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{numero} é um número par");

}

else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"{numero} é um número ímpar");
}

Console.ResetColor();