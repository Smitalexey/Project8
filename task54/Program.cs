// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.


Console.WriteLine("Введите число строк и число столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
FillMassiv(matrix);
Console.WriteLine("Массив элементов выглядит так: ");
PrintMassiv(matrix);
Console.WriteLine();
Console.WriteLine("Сортированный массив элементов: ");
SelectionSort(matrix);
PrintMassiv(matrix);

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

void SelectionSort(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int tempory = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = tempory;
        }
      }
    }
  }
}


