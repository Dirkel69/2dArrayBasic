using System;
namespace _2dArrayBasic
{
    class Program
    {
        public static void Main(string[] args)
        {
            
        }
        public static void ex1()
        {
            int[,] arr = new int[3, 5];
            double[] avg = { 0, 0, 0, 0 };
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    arr[i,j] = int.Parse(Console.ReadLine());
                    avg[i] += arr[i,j];
                    avg[3] += arr[i,j];
                }
                avg[i] /= 5;
            }
            avg[3] /= 15;
            Console.WriteLine($"Class 1 average: {avg[0]}\nClass 2 average: {avg[1]}\nClass 3 average: {avg[2]}\nAll classes average: {avg[3]}");
        }
        public static int ex2(int[,] arr)
        {
            int counter = 0;
            for(int i = 0; i < arr.GetLength(0); i++)
                for(int j = 0; j < arr.GetLength(1); j++)
                    if (arr[i,j] % 3 == 0 && arr[i, j] > 0)
                        counter++;
            return counter;
        }
        public static int ex3(int[,] arr) 
        { 
            int max = arr[0,0];
            for(int i = 0; i < arr.GetLength(0); i++)
                for(int j = 0; j < arr.GetLength(1); j++)
                    if (arr[i,j] > max)
                        max = arr[i,j];
            return max;
        }
        public static void ex4(int[,] arr)
        {
            int min = arr[0,0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                min = arr[i,0];
                for (int j = 0; j < arr.GetLength(1); j++)
                    if (arr[i, j] < min)
                        min = arr[i, j];
                Console.WriteLine(min);
            }
        }
        public static void ex5(int[,] arr)
        {
            int max;
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                max = arr[i,0];
                for(int j = 0; j < arr.GetLength(1); j++)
                    if (arr[j,i] > max)
                        max = arr[j,i];
                Console.WriteLine(max);
            }
        }
        public static bool ex6(int[,] arr)
        {
            int vorherige = arr[0, 0] - 1;
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < vorherige)
                        return false;
                    vorherige = arr[i, j];
                }
            return true;
        }
        public static int ex7(int[,] arr)
        {
            int summe = 0;
            int H = arr.GetLength(0);
            int W = arr.GetLength(1);
            for(int h = 0; h < H; h++)
                for(int w = 0; w < W; w++)
                    if(h == 0 || w == 0 || w == W - 1 || h == H - 1)
                        summe+= arr[h,w];
            return summe;
        }
        public static int ex8(int[,] arr)
        {
            if(arr.GetLength(0) != arr.GetLength(1))
                return -1;
            int summe = 0;
            for(int i = 0; i < arr.GetLength(0); i++)
                summe += arr[i,i];
            return summe;
        }
        public static int ex9(int[,] arr)
        {
            if(arr.GetLength(0) != arr.GetLength(1))
                return -1;
            int summe = 0;
            for(int i = 0; i < arr.GetLength(0); i++)
                summe += arr[i,arr.GetLength(0) - i - 1];
            return summe;
        }
        public static int ex10(int[,] arr)
        {
            if(arr.GetLength(0) != arr.GetLength(1))
                return -1;
            int summe = 0;
            for(int i = 0; i < arr.GetLength(0); i++)
                for(int j = 1; j < arr.GetLength(1); j++)
                    if(j>i)
                        summe += arr[i,j];
            return summe;
        }
        public static int ex11(int[,] arr)
        {
            if(arr.GetLength(0) != arr.GetLength(1))
                return -1;
            int summe = 0;
            for(int i = 0; i < arr.GetLength(0); i++)
                for(int j = 0; j < arr.GetLength(1); j++)
                    if(j < arr.GetLength(0) - i - 1)
                        summe += arr[i, j];
            return summe;
        }
        public static int ex12(int[,] arr)
        {
            if (arr.GetLength(0) != arr.GetLength(1))
                return -1;
            int summe = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    if (i > j)
                        summe += arr[i, j];
            return summe;
        }
        public static int ex13(int[,] arr)
        {
            if(arr.GetLength(0) != arr.GetLength(1))
                return -1;
            int summe = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
                for(int j = 0; j < arr.GetLength(1); j++)
                    if(j > arr.GetLength(0) - i - 1)
                        summe += arr[i, j];
            return summe;
        }
        public static bool ex14(int[,] arr)
        {
            for (int h = 0; h < arr.GetLength(0); h++)
                for (int w = 0; w < arr.GetLength(1); w++)
                {
                    if (w == h || h == arr.GetLength(0) - w - 1)
                    {
                        if (arr[h, w] != 1)
                            return false;
                    }
                    else
                    {
                        if (arr[h, w] != 0)
                            return false;
                    }
                }
            return true;
        }
        public static bool ex15(int[,] arr)
        {
            int H = arr.GetLength(0);
            int W = arr.GetLength(1);
            for (int h = 0; h < H; h++)
                for(int w = 0; w < W; w++)
                    if (arr[h,w] != arr[H-1-h,w] || arr[h,w] != arr[h,W-1-w])
                        return false;
            return true;
        }
        /*
         * ex16a:
         * 8 3
         * 12 2
         * 
         * ex16b:
         * n= 7
         * s = 71
         * a = { 6, 23, 0, 54, 4, 44, 87 }
         * 
         * ex16c:
         * התוכנית מקבלת מספר ופולטת את זוגות המספרים במערך שמפכפלתם שווה למספר שהתקבל
         */
        public static int[] ex17(int[,]  m1, int[,] m2)
        {
            int d;
            int n = m1.GetLength(0);
            int[] res = new int[n];
            for(int i = 0; i < n; i++)
            {
                d = 0;
                for(int j = 0; j < n; j++)
                    d += m1[i, j];
                res[i] = d;
            }
            for(int i = 0; i < n; i++)
            {
                d = 0;
                for(int j =0; j < n; j++)
                    d += m2[j, i];
                res[i] *= d;
            }
            return res;
        }
        public static bool ex18(int[,] arr)
        {
            int überprüf = 0;
            for(int i = 0; i < arr.GetLength(0); i++)
                überprüf += arr[0, i];
            int[] summen = { 0, 0, 0, 0 };
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                summen[0] += arr[i, 0];
                summen[1] += arr[0, i];
                summen[2] += arr[i, i];
                summen[3] += arr[i, arr.GetLength(0) - i - 1];
            }
            return (summen[0] == überprüf && summen[1] == überprüf && summen[2] == überprüf && summen[3] == überprüf);
        }
        public static void ex19(int n)
        {
            int[,] arr = new int[n, 30];
            int[] counter = new int[n];
            int zahler = 0;
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    Console.WriteLine($"{i}? 0/1?");
                    arr[i, j] = int.Parse(Console.ReadLine());
                    arr[i,j] = (arr[i, j] == 1) ? 1 : 0;
                    if (arr[i, j] == 1) { counter[i]++; zahler++; }
                }
            }
            zahler /= n;
            int meistePopular = 0;
            for (int i = 0; i < 30; i++)
                if (counter[meistePopular] < counter[i])
                    meistePopular = i;
            bool hatAlles = true;
            int habenAlles = 0;
            for (int i = 0; i < n; i++)
            {
                hatAlles = true;
                for(int j = 0; j < 30; j++)
                    if (arr[i,j] == 0) hatAlles = false;
                if (hatAlles) habenAlles++;
            }
            Console.WriteLine($"Most heard single: {meistePopular}\nTeens with all singles: {habenAlles}\nAverage amount of singles owned by teens {zahler}");
        }
    }
}