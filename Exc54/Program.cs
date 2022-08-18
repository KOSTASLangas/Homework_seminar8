// // Задайте двумерный массив. 
// // Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


 class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число строк: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите число столбцов: ");
            int y = int.Parse(Console.ReadLine());
            int[,] mas = new int[x, y];
            Console.WriteLine();
            initialization(mas);
            Sort(mas);
            Console.WriteLine();
            Print(mas);
 
        }
        static void Print(int[,] arr)
        {
           for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write("{0}\t", arr[i, j]);
                    Console.WriteLine();
            }
        }
 
        static void initialization(int[,] mas)
        {
 
            Random rand = new Random();
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rand.Next(1, 15);
                    Console.Write("{0}\t", mas[i, j]);
                }
                Console.WriteLine();
            }
        }
 
        public static void Sort(int[,] mas)
        {
 
      int x, i,j,b;
            
            for (i = 0; i < mas.GetLength(0); i++)
    {
 
                for (j = 0; j < mas.GetLength(1); j++)
                {
                    x = mas[i, j];
 
                    for (b = j - 1; b >= 0 && mas[i,b] > x; b--)
                        mas[i, b + 1] = mas[i, b];
 
                    mas[i, b + 1] = x;
                }
            }
    
        }
       
    }
