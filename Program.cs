using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace самостоят10
{
    class Program
    {   
        static void zad1()
        {
            try 
            {
                Console.WriteLine("введи к-во строк");
                int m = int.Parse(Console.ReadLine());
                Console.WriteLine("введи к-во столбцов");
                int n = int.Parse(Console.ReadLine());
                if (m <= 0 || n <= 0)
                    Console.WriteLine("ошибка");
                else
                {
                    {
                        int[,] mas = new int[m, n];
                        for (int i = 0; i < mas.GetLength(0); i++)
                        {
                            for (int j = 0; j < mas.GetLength(1); j++)
                            {
                                for (int x = 0; x < mas.GetLength(0); x++)
                                {
                                    if (x < 2)
                                    {
                                        mas[x, j] = Convert.ToInt32($"{x + 1}");
                                        mas[i, j] = mas[x, j];
                                    }
                                    else
                                        mas[i, j] = Convert.ToInt32("3");
                                }
                            }
                        }
                        for (int i = 0; i < mas.GetLength(0); i++)
                        {
                            for (int j = 0; j < mas.GetLength(1); j++)
                            {
                                Console.Write(mas[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        int sum = 0, pro = 1, max = int.MinValue;
                        for (int i = 0; i < mas.GetLength(0); i++)
                        {
                            for (int j = 0; j < mas.GetLength(1); j++)
                            {
                                sum += mas[i, j];
                                pro *= mas[i, j];
                                if (mas[i, j] > max)
                                    max = mas[i, j];
                            }
                        }
                        Console.WriteLine($"сумма всех эл. {sum}\nпроизведение всех эл. {pro}\nмаксимальное число {max}");
                    }
                }
            }
            catch
            {
                Console.WriteLine("ошибка");
            }
        }
            static void Main()
            {
                zad1();
                Console.ReadKey();
            }
    }
}

