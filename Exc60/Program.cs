// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.WriteLine("Введите высоту: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во строк: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int b = Convert.ToInt32(Console.ReadLine());

int[,,] matrix = new int[n, c, b];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < c; j++)
    {
        for (int k = 0; k < b; k++)
        {
            matrix[i, j, k] = new Random().Next(0, 10);
            Console.Write(matrix[i, j, k] + " " + (i,j,k) +" \t");
            
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}