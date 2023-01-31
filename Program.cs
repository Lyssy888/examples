//Напишите программу, которая принимает на вход трёхзначное число и// на выходе показывает последнюю цифру этого числа.
Console.Write("input your number 3-digit: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 & num <1000)
{
    int digit_3  = num % 10;
    Console.WriteLine($"Third digit is {digit_3}");
}
else
{
    Console.WriteLine("your number is not digit-3!");
}