using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            int num;
            var Random = new Random();
            int[] array = new int[15];
            Console.WriteLine("Числа массива");
            for (int i = 0; i < 15; i++)
            {
                num = Random.Next(0,50);
                array[i] = num;
                Console.WriteLine(num);
            }

            int max = array[0];
            int min = array[0];           
        
            foreach (int element in array)
            {
                if (element > max)
                {
                    max = element;
                }
                if (element < min)
                {
                    min = element;
                }
            }   

            Console.WriteLine("Сумма максимального и минимального элементов: " + min + " + " + max + " = " + (min+max));
            Console.ReadLine();
            Run();
            Environment.Exit(0);
        }
    }
}