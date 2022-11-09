// напишите программу, которая принимает на вход число(A) и выдаёт сумму чисел от 1 до A.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите Ваше число ");
int number = int.Parse(Console.ReadLine()!);

int GetSumDigitsA (int number){
    int result = 0;   //переменаая, в которую складываем результат
    int count = 0;    //переменая-счетчик

    while(count < number){
        count++;
        result = result + count;
    }
    return result;
}

int res = GetSumDigitsA(number);
Console.WriteLine("Сумма чисел до Вашего числа равна: " + res);
