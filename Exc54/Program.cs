// // Задайте двумерный массив. 
// // Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int c = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, c];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < c; j++)
    {
    matrix[i, j] = new Random().Next(0, 10);
    Console.Write(matrix[i, j] + " \t");
    }
    Console.WriteLine();
}

for (int a = 0; a < matrix.GetLength(0);  a++)
{
    for (int i = 0; i < matrix.GetLength(0) ; i++) 
    {    
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            if (matrix[i,j]  > matrix[i, j+ 1] )
            {
                int temp = matrix[i,j];
                matrix[i,j] = matrix[i,  j+ 1];
                matrix[i, j+ 1] = temp;
            }
        }
    }    
}
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < c; j++)
    {
    Console.Write(matrix[i, j] + " \t");
    }
    Console.WriteLine();
}