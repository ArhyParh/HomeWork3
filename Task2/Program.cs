// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Main();
void Main()
{
    Console.WriteLine("Введите координаты 2 точек по 3м осям(по 1 значению)...");
    int[] a = new int[6];
    FillArray(a);
    Console.WriteLine(FindDistance(a));
}
Array FillArray(int[] array)
{
    for (int i = 0; i < 6; i++)
    {
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}
double FindDistance(int[] a)
{
    double number = Math.Sqrt((a[3] - a[0])*(a[3] - a[0]) + (a[4] - a[1])*(a[4] - a[1]) + (a[5] - a[2])*(a[5] - a[2]));
    return number;
}