using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrrays1DConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Кiлькiсть елементiв масиву: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            double[] d = new double[n];
            int sum = 0;

            Console.Write("Array: ");
            for(int i = 0; i < d.Length; i++)
            {
                d[i] = rnd.Next(-142, 183) / 10.0;
                Console.Write($"{d[i]} | ");
            }

            for(int i = 0; i < d.Length; i++)
            {
                if (d[i] > 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"\nСума iндексiв додатних елементiв = {sum}");

            Console.WriteLine("\nСкiльки перших елементiв посортувати? ");
            int k = Convert.ToInt32(Console.ReadLine());
            double temp;

            for(int i = 0; i < d.Length; i++)
            {
                for (int j = 0; j < k-1; j++)
                {
                    if (d[j] > d[j + 1]) {
                        temp = d[j];
                        d[j] = d[j + 1];
                        d[j + 1] = temp;
                    }
                }
            }

            Console.Write("Array: ");
            foreach (double dx in d)
            {
                Console.Write($"{dx} | ");
            }


            //double d = rand.NextDouble() * (to - from) + from; - рандом в диапазоне
            //Console.WriteLine($"n = {n}"); - інтерпольовані рядки
            Console.ReadKey();
        }
    }
}
