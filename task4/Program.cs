Console.Write("Введите количество строк массива: ");
int rows=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int k =Convert.ToInt32(Console.ReadLine());

int[,,] array = GetArray(new int[] {rows, columns, k}, 10, 99);
PrintArray(array);
int [,,] GetArray (int[] sizes, int min, int max)
{
    int [,,] result = new int [sizes[0], sizes[1], sizes[2]];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int k=0;
            while (k< result.GetLength(2))
            {
                int element = new Random().Next(min, max+1);
                if(FindElement(result,element)) continue;
                result[i, j, k] = element;
                k++;
            }
        }

    }
    return result;
}
bool FindElement(int[,,] array, int el)
{
    for (int i=0; i < array.GetLength(0); i++)
    {
        for ( int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if(array[i,j,k] == el) return true;
            }

        }
    }
    return false;
}
void PrintArray(int[,,] array)
{
    for (int i=0; i < array.GetLength(0); i++)
    {
        for ( int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]}({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
