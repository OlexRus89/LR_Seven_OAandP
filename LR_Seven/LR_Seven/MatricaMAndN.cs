using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;

namespace LR_Seven
{
    class MatricaMAndN
    {
        /*Класс «Матрица MxN». Реализовать инициализацию элементов
         *матрицы случайными числами, вывод матрицы, нахождение
         *максимального и минимального элементов, а также вывод
         *информации об объекте.  
         */

        public int M, N;

        public MatricaMAndN() { }

        public MatricaMAndN(int Mm, int Nm)
        {
            M = Mm;
            N = Nm;
        }

        public MatricaMAndN CreateMatricaFromFile()
        {
            this.M = Convert.ToInt32(Console.ReadLine());
            this.N = Convert.ToInt32(Console.ReadLine());
            return new MatricaMAndN(M,N);
        }

        public (int, int) Load()
        {
            this.M = Convert.ToInt32(Console.ReadLine());
            this.N = Convert.ToInt32(Console.ReadLine());
            return (M, N);
        }

        public double[,] random(int M1, int N1)
        {
            this.M = M1;
            this.N = N1;
            Random r = new Random(DateTime.Now.Millisecond);
            double[,] mas = new double[M, N];
            int x = 0;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    mas[i,j] = r.Next(-1000, 1001);
                }
            }
            return mas;
        }

        public string[,] InfoMatrica(int M2, int N2)
        {
            this.M = M2;
            this.N = N2;
            String[,] mas1 = new String[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    mas1[i, j] = "* ";
                }
            }
            return mas1;
        }

        public void Info()
        {
#if DEBUG
            Console.WriteLine("введите данные M и N:");
#endif
            var typle = Load();
#if DEBUG
            Console.WriteLine();
#endif
            Console.WriteLine("Была введена матрица размером {0}x{1}", typle.Item1, typle.Item2);
            Console.WriteLine("Результаты следующие: ");
            InfoMatrica(typle.Item1, typle.Item2);
            Console.WriteLine();
            random(typle.Item1, typle.Item2);
        }
        
#if DEBUG
        public void Info (ConsoleColor fg, ConsoleColor bgc)
        {
            Console.ForegroundColor = fg;
            Console.BackgroundColor = bgc;
            Console.Clear();
            Info();

        }
#endif
    }
}
