/*
Задача 15: 
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

int number= Read("Введите число от 1 до 7: ");;
Console.WriteLine(dayX(number));


//проверка дней
string dayX(int a)
{
        if (a == 7 || a == 6)
        {
            Console.Write( "выходной");
        }
        else
        {
            Console.Write( "будний день");
        }
    
    return ".";
}

// Вывод сообщений 
int Read(string message)
{
   Console.Write(message);
   return Convert.ToInt32(Console.ReadLine());
}

