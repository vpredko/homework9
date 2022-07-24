int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}   
void PrintArray(int[,] inArray)
{
    for (int row = 0; row < inArray.GetLength(0); row++)
    {
        for (int column = 0; column < inArray.GetLength(1); column++)
        {
            Console.Write($"{inArray[row,column]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк массива: ");
int rows=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк массива 2: ");
int rows2=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива 2: ");
int columns2=Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
int[,] array2 = GetArray(rows2, columns2, 0, 10);
PrintArray(array);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
PrintArray(GetMultiMatrix(array, array2));

if (columns != rows2)
{
    Console.WriteLine("Нельзя умножать");
    return;
}

 int[,] GetMultiMatrix(int[,] arrayA, int[,] arrayB)
 {
    int[,] arraynew = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                arraynew[i,j] += arrayA[i,k]*arrayB[k,j];
            }
        }
    }
    return arraynew; 
}


