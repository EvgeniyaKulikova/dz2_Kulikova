// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void dayofweek (int day)
{
if (day > 0 & day <6 )
{
    Console.WriteLine("today is a weekday");
}
else if (day > 5 & day < 8)
{
    Console.WriteLine("today is a day off");
}
else
{
    Console.WriteLine("ERROR, enter a number from 1 to 7");
}
}

Console.WriteLine("enter a number from 1 to 7");
int num = Convert.ToInt32(Console.ReadLine());
dayofweek (num);