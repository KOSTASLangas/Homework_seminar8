//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
Console.Write("Первая матрица");
Console.WriteLine();
int[,] matrix2 = new int[n, c];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < c; j++)
    {
    matrix2[i, j] = new Random().Next(0, 10);
    Console.Write(matrix2[i, j] + " \t");
    }
    Console.WriteLine();
}
Console.Write("Вторая матрица");
Console.WriteLine();

int[,] matrix3 = new int[n, c];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < c; j++)
    {
    matrix3[i, j] = matrix[i,j] * matrix2[i, j];
    
    Console.Write(matrix3[i, j] + " \t");
    }
    Console.WriteLine();
}
Console.Write("Матрица произведений");
