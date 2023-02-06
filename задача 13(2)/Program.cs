// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void bignumber (int number)
{
    if (number > 99)
    {
        int num3 = number % 10;
        
        Console.WriteLine($"your number is {num3}");
    }
    else
    Console.WriteLine("no third digit");
}

Console.WriteLine("enter a number greater than 99 ");
int num = Convert.ToInt32(Console.ReadLine());
bignumber (num);


// int thousand = number / 1000;  num3 = thousand % 10;