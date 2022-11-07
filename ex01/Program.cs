// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int GetDigits(int number){
    int count = 0;
    while(number > 0){
        count = number / 10;
        count++;
    }
    return count;
}

GetDigits(number);
Console.WriteLine("Ваш результат: " + count);