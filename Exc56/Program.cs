//Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int n = 6;
int c = 3;

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
int sum = int.MaxValue;
int index = 0;
for (int i = 0; i < n; i++)
{
    int temp = 0;
    for (int j = 0; j < c; j++)
    {
        temp += matrix[i, j];
    }
    if (temp < sum)
    {
        sum = temp;
        index = i +1;
    }
}
Console.WriteLine();
Console.WriteLine("Строка: "+index+" Сумма: "+sum);