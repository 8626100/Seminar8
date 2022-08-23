//Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
//Например, заданы 2 массива:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//и
//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7
//Их произведение будет равно следующему массиву:
//1 20 56 10
//20 81 8 6
//56 8 4 24
//10 6 24



Console.WriteLine("Задайте парамерты матриц:");
Console.WriteLine("Введите число строк 1-й матрицы: ");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов 1-й матрицы (равно числу строк 2-й матрицы по условию умножения): ");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов 2-й матрицы: ");
int p=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте диапазон значений элементов матрицы  от 1 до ");
int range=Convert.ToInt32(Console.ReadLine());

int[,] Martrix1 = new int[m, n];
CreateArray(Martrix1);
Console.WriteLine("1-я матрица:");
WriteArray(Martrix1);

int[,] Martrix2 = new int[n, p];
CreateArray(Martrix2);
Console.WriteLine("2-я матрица:");
WriteArray(Martrix2);

int[,] resultMatrix = new int[m,p];

MultiplicationMatrix(Martrix1, Martrix2, resultMatrix);
Console.WriteLine("Произведение  матриц:");
WriteArray(resultMatrix);

void MultiplicationMatrix(int[,] Martrix1, int[,] Martrix2, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < Martrix1.GetLength(1); k++)
      {
        sum += Martrix1[i,k] * Martrix2[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}


void CreateArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write(arr[i,j] + " ");
    }
    Console.WriteLine();
  }
}
