// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число, обозначающее номер дня недели (от 1 до 7) " );
int N = int.Parse(Console.ReadLine()!);

if (N==1 | N< 6)
{ 
Console.Write("День недели является рабочим");
}

else
{
Console.Write("День недели является выходным");
}