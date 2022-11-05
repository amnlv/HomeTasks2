/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int number = Read("Введите трехзначное число: ");
int amount = number.ToString().Length;

Console.WriteLine(Center(number));


// Вывод сообщений 
int Read(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Вывод цифры
int Center(int a)
{
    int result = ((a / 10) % 10);
    return result;
}