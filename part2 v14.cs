using System;

namespace lr2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Рядки ");
            int lin = int.Parse(Console.ReadLine());
            Console.Write("Стовпчики ");
            int col = int.Parse(Console.ReadLine());
            int[][] array = new int[lin][];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new int[col];
            }
            Console.WriteLine("1 автоматично     2 вручну");
            int q = int.Parse(Console.ReadLine());
            if (q == 1)
            {
                auto(array);
            }
            else if (q == 2)
            {
                manual(array);
            }

            int minline = SearchMin(array);
            array = PlussLine(array, minline);
            WriteConsol(array);
            Console.ReadKey();
        }
        static void auto(int[][] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = rand.Next(-10, 100);
                }
            }
            WriteConsol(array);
        }

        static void manual(int[][] array)
        {
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = int.Parse(Console.ReadLine());
                }
            }
            WriteConsol(array);
        }

        static void WriteConsol(int[][] array)
        {
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static int SearchMin(int[][] array)
        {
            int min = int.MaxValue;
            int minline = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] < min)
                    {
                        min = array[i][j];
                        minline = i;
                    }
                }
            }

            return minline;
        }

        static int[][] PlussLine(int[][] array, int minline)
        {
            int[][] res = new int[array.Length + 1][];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = new int[array[i].Length];
            }

            for (int i = 0; i < res.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (i < minline + 1)
                    {
                        res[i][j] = array[i][j];
                    }
                    else if (i > minline + 1)
                    {
                        res[i][j] = array[i - 1][j];
                    }

                }
            }

            return res;
        }

       
    }
}


