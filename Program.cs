//Программа, принимающая на вход 2 числа, и проверяющая, является ли первое число квадратом второго.

Console.Write("Введите первое число: ");

int number1 = int.Parse(Console.ReadLine({number1}));

Console.Write("Введите второе число: ");

int number2 = int.Parse(Console.ReadLine({number2}));

int sqr = number2 * number2;

if (number1 = sqr)
{
 Console.WriteLine($"{number1} является квадратом {number2}");
}
if (number1 > sqr)
{
 Console.WriteLine($"{number1} НЕ является квадратом {number2}");
}
if (number1 < sqr)
{
 Console.WriteLine($"{number1} НЕ является квадратом {number2}");
}
else 
{
 Console.WriteLine($"{number1} НЕ является квадратом {number2}");
}

Console.WriteLine($"{number1} НЕ является квадратом {number2}");
