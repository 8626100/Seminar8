
// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8
//  

int[,] FillRandomDoubleArray (int rows =4, int columns =4, int leftRange = 0, int rightRange=10)
{
    int [,] randomArray = new int [rows, columns];
    Random rand = new Random ();
    for (int i=0; i<randomArray.GetLength(0); i++)
    {
        for (int j=0; j<randomArray.GetLength(0); j++)
        {
            randomArray [i,j] = rand.Next (leftRange, rightRange+1);
        }
    }
    return randomArray;
}
 

void PrintMatrix(int[,] matrix)  // метод печати матрицы
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int [,]  matrix = FillRandomDoubleArray();
PrintMatrix(matrix);
Console.WriteLine();

for (int i=0; i< matrix.GetLength(0); i++)
 {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
       int minIndex=j;
       for (int k = j+1; k < matrix.GetLength(1); k++)
         {
           if (matrix[i,k]<matrix[i,minIndex]) minIndex=k;
         }
                int temp=matrix[i,j];
                matrix[i,j]=matrix[i,minIndex];
                matrix[i,minIndex] =temp;
    }
 }
    
   

 PrintMatrix(matrix);
Console.WriteLine();
