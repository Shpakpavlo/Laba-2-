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
            Console.Write("a ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b ");
            int b = int.Parse(Console.ReadLine());
            auto(array, a, b);
            int[][] Y = Transpone(array);
            WriteConsole(Y);
            Array.Reverse(Y);
            WriteConsole(Y);
            Y = Res(Y);
            WriteConsole(Y);
            Console.ReadKey();
        }
        static void auto(int[][] array, int a, int b)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = rand.Next(a, b + 1);
                }
            }
            WriteConsole(array);
        }



        static void WriteConsole(int[][] array)
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

        static int[][] Transpone(int[][] array)
        {
            int[][] trans = new int[array[0].Length][];
            for (int i = 0; i < trans.Length; i++)
            {
                trans[i] = new int[array.Length];
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    trans[j][i] = array[i][j];
                }
            }
            return trans;
        }

        static int[][] Res(int[][] Y)
        {
            for (int i = 0; i < Y.Length; i++)
            {
                if (Array.IndexOf(Y[i], 0) < Y[i].Length / 2 && Array.IndexOf(Y[i], 0) != -1)
                {
                    for (int j = 0; j < Y[i].Length; j++)
                    {
                        Y[i][j] = 0;
                    }
                }
                else
                {
                    Array.Sort(Y[i]);
                    Array.Reverse(Y[i]);
                }
            }

            return Y;
        }
        
    }
}