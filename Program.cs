//Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

using System.Runtime.ExceptionServices;

double[] CreateArrayRndInt(int size, int min, int max)
{
double[] arr = new double[size];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(min, max) + rnd.NextDouble();
}
return arr;
}

void PrintArray(double[] arr)
{
Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
else Console.Write($"{arr[i]}");
}
Console.Write("]");
}

double[] array = CreateArrayRndInt(4, 100, 1000);
PrintArray(array);

double DifferenceMinMax(double[] arr)
{
    double max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        else i++;
    }
    double min = max;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
        else i++;
    }
    double dif = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        dif = max - min;
    }
    return dif;
}

double dif = DifferenceMinMax(array);
Console.WriteLine($" — {dif}");