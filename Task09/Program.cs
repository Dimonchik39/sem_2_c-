// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int num = new Random().Next(10, 100);
int firdig = num / 10;
int secdig = num % 10;

//if (firdig > secdig) Console.WriteLine($"Большая цифра из числа {num} -> {firdig}");
//else Console.WriteLine($"Большая цифра {num} -> {secdig}");

// тернарный опратор
if (firdig == secdig) Console.WriteLine($"{num} Одинаковые числа");
else
{
int max = firdig > secdig ? firdig : secdig;
Console.WriteLine($"Большая цифра из числа {num} -> {max}");
}