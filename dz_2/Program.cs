// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


Console.WriteLine("Введите колличество строк: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите колличество столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[8,9];
if (row > matrix.GetLength(0) && colums > matrix.GetLength(1))
{
    Console.WriteLine("такого числа в массиве нет");
}
else
{
    Console.WriteLine($"значение элемента {row} строки и {colums} столбца равно {matrix[row-1,colums-1]}");
}

for (int i = 0; i <matrix.GetLength(0); i++)
{
 for (int j = 0; j < matrix.GetLength(1); j++)
 {
    matrix[i,j]= new Random().Next(10);

    Console.Write(matrix[i,j]+ "\t");      
 }   

 Console.WriteLine();
}



