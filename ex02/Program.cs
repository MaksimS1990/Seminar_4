﻿// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.WriteLine("Введите число!");
int number = int.Parse(Console.ReadLine()!);
int FactorialDigit(int number){
    int count = 1;
    int result = 1;
    while(count <= number){
    result = result * count;
    count++;
    }
    return result;
}
int N = FactorialDigit(number);

Console.WriteLine("Ваш результат: " + N);
