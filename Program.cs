//Задача 1.//Напишите программу, которая на вход принимает число и выдаёт его квадрат
Console.Write(" input you number: "); // запрос данных у пользователя

int number = Convert.ToInt32(Console.ReadLine()); // в переменную Number записали введеную пользователем значение

Console.WriteLine($" You number is {number}");
int result = number * number;
Console.WriteLine($" квадрат {number} - {result}");
Console.WriteLine(number*number);