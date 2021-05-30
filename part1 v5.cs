using System;

namespace lr2
{
    class MainClass
    {
        static void auto(int[] array)
        {
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 100);
               
            }
            WriteConsol(array);
        }

        static void manual(int[] array)      
        {
            Console.WriteLine();
            string[] a = Console.ReadLine().Split(' ');
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Int32.Parse(a[i]);
            }

            WriteConsol(array);
        }

        static void WriteConsol(int[] array)  
        {
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        static int[] Res(int[] array)
        {
            int[] newa = new int[array.Length];
            int a = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 > 0 || i == 0)
                {
                    newa[a] = array[i];
                    a++;
                }
            }

            Array.Resize(ref newa, a);
            return newa;
        }

        public static void Main(string[] args)
        {
            Console.Write("Довжина масиву ");
            int longg = int.Parse(Console.ReadLine());
            int[] array = new int[longg];

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

            array = Res(array);
            WriteConsol(array);

            Console.ReadKey();
        }
    }
}
