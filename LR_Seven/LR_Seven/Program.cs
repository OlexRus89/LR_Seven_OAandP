using System;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.IO;

namespace LR_Seven
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вариант 27

#if !DEBUG
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"matrica_output.txt");
            var new_in = new StreamReader(@"matrica_input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);
#endif
 
            MatricaMAndN load = new MatricaMAndN();
#if !DEBUG
            load.Info();
#endif

#if DEBUG
            load.Info(ConsoleColor.Black, ConsoleColor.Red);
#endif

            double[,] array = load.random(load.M, load.N);
            String[,] array1 = load.InfoMatrica(load.M, load.N);
            double Max = -1001, Min = 1001;

            for (int i = 0; i < load.M; i++)
            {
                for (int j = 0; j < load.N; j++)
                {
                    Console.Write(array1[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < load.M; i++)
            {
                for (int j = 0; j < load.N; j++)
                {
                    Console.Write(array[i,j] + " ");
                    if (Max <= array[i, j])
                    {
                        Max = array[i, j];
                    }
                    if (Min >= array[i,j])
                    {
                        Min = array[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Максимальный элемент: {0}", Max);
            Console.WriteLine("Минимальный элемент: {0}", Min);

#if !DEBUG
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
#endif

#if DEBUG
            Console.ReadKey();
#endif

        }
    }
}
