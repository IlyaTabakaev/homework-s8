Console.WriteLine("input rows count");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("input columns count");
int n = int.Parse(Console.ReadLine());
int [,] array = new int [m, n];
FillArray(array);
PrintArray(array);
MinimalRowSum(array);



void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100);
            }   
        }
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.WriteLine(""); 
    }
}

void MinimalRowSum(int[,] array)
{
    int minRow = 0;
    int minRowSum = 0;
    int rowSum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) rowSum = array[i, j];
        if (rowSum < minRow)
        {
            minRow = rowSum;
            minRowSum = i;
        }
        rowSum = 0;
    }
    Console.Write($"{minRowSum + 1} line with minimal sum");
}