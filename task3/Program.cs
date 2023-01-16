Console.WriteLine("input rows matrixA");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("input columns matrixA");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("input columns matrixB");
int d = int.Parse(Console.ReadLine());

int [,] matrixA = new int [a, b];
FillArray(matrixA);
PrintArray(matrixA);
Console.WriteLine();

int [,] matrixB = new int [b, d];
FillArray(matrixB);
PrintArray(matrixB);
Console.WriteLine();

int [,] matrixC = new int [a, d];


Multiplication(matrixA, matrixB, matrixC);
PrintArray(matrixC);


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

void Multiplication(int[,] matrixA, int[,] matrixB, int[,] matrixC)
{
  for (int i = 0; i < matrixC.GetLength(0); i++)
  {
    for (int j = 0; j < matrixC.GetLength(1); j++)
    {
      int sum = 0;  
      for (int k = 0; k < martrixA.GetLength(1); k++)
      {
        sum += martrixA[i, k] * martrixB[k, j];
      }
      matrixC[i, j] = sum;
    }
  }
}