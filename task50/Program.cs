// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("]");
    }
}

bool GetElement(int[,] matrix, int rowsNum, int columnNum)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (rowsNum == i && columnNum == j) return true;
        }
    }
    return false;
}


Console.WriteLine("Введите позицию элемента в двумерном массиве: ");
Console.WriteLine("Номер строки: ");
int rowsI = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Номер столбца: ");
int columnJ = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 99);

bool getElement = GetElement(array2D, rowsI, columnJ);

if (getElement)
{
    PrintMatrix(array2D);
    Console.WriteLine();
    Console.WriteLine($"Такой элемент есть в массиве -> {array2D[rowsI, columnJ]} ");
}

else
{
    PrintMatrix(array2D);
    Console.WriteLine();
    Console.WriteLine($"Такого элемента нет в массиве ");
}

