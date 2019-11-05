using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2DConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Розмiрнiсть матрицi");
            Console.Write("Кiлькiсть рядкiв: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кiлькiсть стовпцiв: ");
            int m = Convert.ToInt32(Console.ReadLine());

            double[,] arr = new double[n, m];
            Random rnd = new Random();
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = rnd.Next(-54, 57) / 10.0;
                    Console.Write($"{arr[i, j]} | ");
                }
                Console.WriteLine();
            }
            
            int count = 0;
            bool isNegative;
            for (int i = 0; i < n; i++)
            {
                isNegative = false;
                for (int j = 0; j < m; j++)
                {
                    if(arr[i, j] < 0)
                    {
                        isNegative = true;
                    }
                }
                if(!isNegative)
                {
                    count++;
                }

            }
            Console.WriteLine($"\nКiлькiсть рядкiв, якi не мiстять жодного вiд'ємного елемента: {count}\n");

            /*for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {

                }
            }*/

            double sum1, sum2;
            double d;
            for (int x = 0; x < n; x++)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    sum1 = 0;
                    sum2 = 0;
                    for (int j = 0; j < m; j++)
                    {
                        sum1 += arr[i, j];
                        sum2 += arr[i + 1, j];
                    }
                    if (sum1 < sum2)
                    {
                        for (int z = 0; z < m; z++)
                        {
                            d = arr[i, z];
                            arr[i, z] = arr[i + 1, z];
                            arr[i + 1, z] = d;
                        }
                    }
                }
            }

            
            Console.WriteLine("Сортування за сумою рядка по спаданню");
            for (int i = 0; i < n; i++)
            {
                sum1 = 0;
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{arr[i, j]} | ");
                    sum1 += arr[i, j];
                }
                Console.WriteLine();
                Console.WriteLine($"sum = {sum1}");
            }


            Console.ReadKey();
        }
    }
}
