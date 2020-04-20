using System;

namespace laba3._2
{
    class Program
    {
        static void ValsGenerator(int[] Vals)
        {             // Random - клас для генерації випадкових чисел             
            Random aRand = new Random();             // заповнення масиву             
            for (int i = 0; i < Vals.Length; i++)                 
                Vals[i] = aRand.Next(-10,10);

        }         
        static void Main(string[] args)         
        {           
            const int N = 10;
            long sum = 0;
            int mul = 1;
            int[] Data = new int[N];           
            ValsGenerator(Data);                     
            for (int i = 0; i < Data.Length; i++)
            {
                Console.WriteLine("Data[" + i + "] = " + Data[i]);
                if (Data[i] < 0)
                {
                    sum += Data[i];
                }
            }

            for (int i = 0; i < Data.Length; ++i)
            {
                if (Data[i] < 0)
                {
                    break;
                }
                mul *= Data[i];
            }
            Console.WriteLine("Сума  від'ємних = " + Math.Abs(sum));
            Console.WriteLine("Добуток елементів масиву = " + mul);

        }
    }
}
