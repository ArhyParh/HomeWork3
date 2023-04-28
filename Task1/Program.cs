// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Main();
void Main()
{
    Console.WriteLine("Ведите 5ти значное число:...");
    int a = int.Parse(Console.ReadLine()!);
    IsNumberPolin(a);
}
void IsNumberPolin(int a)
{
    if (IsNumberValid(a) == true)
    {
        if (a / 1000 == a / 10 % 10 + a % 10 * 10) { Console.WriteLine("Да!"); }
        else { Console.WriteLine("Нет!"); }
    }
    else { Console.WriteLine("Вы ввели не 5ти значное число!"); }
}
bool IsNumberValid(int a)
{
    if (a < 100000 && a > 9999) { return true; }
    else { return false; }
}
