using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise18
{
    class Program
    {
        static void QuickSort(int[] vector, int first, int last)
        {
            int a = first, z = last;
            int pivot = 0;
            int centralIndex = (first + last) / 2;
            pivot = vector[centralIndex];

            do
            {
                while (vector[a] < pivot) a++;
                while (vector[z] > pivot) z--;
                if (a <= z)
                {
                    int temp;
                    temp = vector[a];
                    vector[a] = vector[z];
                    vector[z] = temp;
                    a++;
                    z--;
                }
            } while (a <= z);

            if (first < z)
            {
                QuickSort(vector, first, z);
            }
            if (a < last)
            {
                QuickSort(vector, a, last);
            }
        }

        static void Main(string[] args)
        {
            int n = 0;

            Console.WriteLine(" Write the number of element to the arragement:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write(" Write the number:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(" ARRAY");
            for (int i = 0; i < n; i++)
            {
                Console.Write(" {0}", array[i]);
            }

            Console.Write(" \n");

            QuickSort(array, 0, n - 1);

            Console.WriteLine("Ordered Array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(" {0}", array[i]);
            }
            

            Console.ReadKey();

        }
    }
}
