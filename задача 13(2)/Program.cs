// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void bignumber (int number)
{
    if (number > 99)
    { 
        {
            while (number >999)
            number = number / 10;
        }
    
    int num3dig = number % 10;
    Console.WriteLine($"your number is {num3dig}");
    } 
   
    else
    Console.WriteLine("no third digit");
    
}
Console.WriteLine("enter a number greater than 99 ");
int num = Convert.ToInt32(Console.ReadLine());
bignumber (num);

