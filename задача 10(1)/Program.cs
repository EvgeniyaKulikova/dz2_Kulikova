//Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void hundredNumber (int number)
{
    if (number >99 && number <1000)
    {
        int dec = number % 100;
        int hund = dec / 10;
        Console.WriteLine($"your number is {hund}");
    }
    else
    Console.WriteLine("ERROR, imput 3digit number");

}

Console.WriteLine("Imput 3digit number ");
int num = Convert.ToInt32(Console.ReadLine());
hundredNumber(num);

