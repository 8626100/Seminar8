﻿//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки 
//с наименьшей суммой элементов: 1 строка

int[,] matrix = {{0,1,0},{2,6,0},{0,9,0},{9,9,7}};
 int min = 0; int index=0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j <matrix.GetLength(1) ; j++)
                {
                    sum += matrix[i, j];
                } 
                if (sum < min)
                {
                min = sum;
                index = i;    
                }
                
            }
Console.WriteLine($"{index+1}-я строка имеет наименьшую сумму элементов: ");
            for (int j = 0; j <matrix.GetLength(1) ; j++)
            {
                Console.Write($"{matrix[index, j]} " );
             }  
    
