// Заполните спирально массив 4 на 4.

Console.WriteLine("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

//С помощью переменной s задаются числа внутри массива начиная с 1.
int s = 1;

//Объявляю и инициализируем массив.
int[,] array = new int[m, n];

//Заполняю периметр массива по часовой стрелке.
for (int y = 0; y < n; y++)
{
    array[0, y] = s;
    s++;
}
for (int x = 1; x < m; x++)
{
    array[x, n - 1] = s;
    s++;
}
for (int y = n - 2; y >= 0; y--)
{
    array[m - 1, y] = s;
    s++;
}
for (int x = m - 2; x > 0; x--)
{
    array[x, 0] = s;
    s++;
}

//Периметр заполнен. Продолжаю заполнять массив и задаю
//координаты ячейки, которую необходимо заполнить следующей.
int c = 1;
int d = 1;

while (s < m * n)
{
    //Движемся вправо.
    while (array[c, d + 1] == 0)
    {
        array[c, d] = s;
        s++;
        d++;
    }

    //Движемся вниз.
    while (array[c + 1, d] == 0)
    {
        array[c, d] = s;
        s++;
        c++;
    }

    //Движемся влево.
    while (array[c, d - 1] == 0)
    {
        array[c, d] = s;
        s++;
        d--;
    }

    //Движемся вверх.
    while (array[c - 1, d] == 0)
    {
        array[c, d] = s;
        s++;
        c--;
    }
}

//остаётся незаполненная ячейка.
//Убираю её при помощи следующего цикла.
for (int x = 0; x < m; x++)
{
    for (int y = 0; y < n; y++)
    {
        if (array[x, y] == 0)
        {
            array[x, y] = s;
        }
    }
}

//Выводим массив в консоль.
for (int x = 0; x < m; x++)
{
    for (int y = 0; y < n; y++)
    {
        Console.Write(array[x, y] + " \t");       
    }
    Console.WriteLine();
}
