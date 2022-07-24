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

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();




void SortArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int t = j+1; t<array.GetLength(1); t++)
                {
                    if (array[i,t]>array[i,j])
                    {int temp = array[i,j];
                    array[i,j]=array[i,t];
                    array[i,t]=temp;
                    }
                       }       
        }
    }
}
SortArray(array);
PrintArray(array);