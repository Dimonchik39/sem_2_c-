// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int num1 = new Random().Next(100, 1000);

int digit2(int num2)
{
    int first = num2 / 100 * 10;
    int two = num2 % 10;
    return first + two;
}

int number = digit2(num1);
Console.WriteLine($"Ответ:  из числа {num1} получается {number}");
