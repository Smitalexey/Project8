// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

Console.WriteLine("Введите число строк и число столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
FillMassiv(matrix);
Console.WriteLine("Массив элементов выглядит так: ");
PrintMassiv(matrix);
Console.WriteLine();
SumLineElements(matrix);

void FillMassiv(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = new Random().Next(0, 100);
        }
    }
}
void PrintMassiv(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            Console.Write($"{collection[i, j]} ");

        }
        Console.WriteLine();
    }
}
void SumLineElements(int[,] collection)
{
    int SumLineElements(int[,] collection, int i)
    {
        int sumLine = collection[i, 0];
        for (int j = 1; j < collection.GetLength(1); j++)
        {
            sumLine += collection[i, j];
        }
        return sumLine;
    }

    int minSumLine = 0;
    int sumLine = SumLineElements(collection, 0);
    for (int i = 1; i < collection.GetLength(0); i++)
    {
        int temporySumLine = SumLineElements(collection, i);
        if (sumLine > temporySumLine)
        {
            sumLine = temporySumLine;
            minSumLine = i;
        }
    }

    Console.WriteLine($"Cтрокa с наименьшей суммой элементов - это {minSumLine + 1}, сумма элементов в этой строке равна {sumLine}");
}
