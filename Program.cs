//Напишите программу, которая на вход принимает два числа и проверяет,//является ли первое число квадратом второго.
Console.Write(" input you first number: ");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.Write(" input you second number: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

if (number_1 == number_2 * number_2) // проверка на равенство
    Console.WriteLine($"число {number_1} является квадратом числа {number_2}");// опустить фигурные скобки можно если одно действие

else
{
    Console.WriteLine($"число {number_1} не является квадратом числа {number_2}");
}