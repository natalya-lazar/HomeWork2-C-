﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//Решение:
void SecondDigit (int num)
{
    if (num > 99 && num < 1000){
        int sot = num / 100;
        int ed = num % 10;
        int des = (num - sot * 100 - ed) /10;
        Console.WriteLine($"Вторая цифра Вашего числа {des}");
    }
    else {Console.WriteLine("Вы ввели не трехзначное число.");};
}
Console.WriteLine("Введите трехзначное число:");
int user_num = Convert.ToInt32(Console.ReadLine());
SecondDigit(user_num);


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет
//Решение:







