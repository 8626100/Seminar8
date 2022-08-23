//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

//массив размером 2 x 2 x 2
//12(0,0,0) 22(0,0,1)
//45(1,0,0) 53(1,0,1)



Console.WriteLine("Задайте парамерты массива:");
Console.WriteLine("x: ");
int x=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y: ");
int y=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z: ");
int z=Convert.ToInt32(Console.ReadLine());

int[,,] arr = new int[x, y, z];
CreateArray(arr);
WriteArray(arr);

void WriteArray (int[,,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write($"x({i}) y({j}) ");
      for (int k = 0; k < arr.GetLength(2); k++)
      {
        Console.Write( $"z({k})={arr[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] arr)
{
  int[] tmp = new int[arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(2)];
  int  number;
  for (int i = 0; i < tmp.GetLength(0); i++)
  {
    tmp[i] = new Random().Next(10, 100);
    number = tmp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (tmp[i] == tmp[j])
        {
          tmp[i] = new Random().Next(10, 100);
          j = 0;
          number = tmp[i];
        }
          number = tmp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < arr.GetLength(0); x++)
  {
    for (int y = 0; y < arr.GetLength(1); y++)
    {
      for (int z = 0; z < arr.GetLength(2); z++)
      {
        arr[x, y, z] = tmp[count];
        count++;
      }
    }
  }
}