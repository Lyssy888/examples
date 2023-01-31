//Задача 3.
//Напишите программу, которая на вход принимает два числа и проверяет,
//является ли первое число квадратом второго.

Console.Write( "input your number N: ");
int num = Convert.ToInt32(Console.ReadLine());

int current_num = (-1) * num;

while( current_num <= num)
{
    Console.Write(current_num + " ");
    current_num++;
}