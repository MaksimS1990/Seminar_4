﻿// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int GetDigits(int number){
    int result = 0;
    while(number > 0){
        number = number / 10;
        result++;
    }
    return result;
}

int res = GetDigits(number);
Console.WriteLine("Ваш результат: " + res);