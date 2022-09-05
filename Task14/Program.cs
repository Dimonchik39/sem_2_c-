// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Clear();
Console.WriteLine("Введите  число");
int num1 = Convert.ToInt32(Console.ReadLine());
int a = 7;
int b = 23;

if (num1 % a == 0 && num1 % b == 0)
{
    Console.WriteLine($"Число {num1} кратно числам: 7 и 23");
}

else 
{
    Console.WriteLine ($"Число {num1} не кратно числам: 7 и 23");
}