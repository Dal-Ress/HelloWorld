using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{

    class Program
    {

        public int MyMethod(int[]a)
        {
            int k = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] % 3 == 0 && a[i - 1] % 3 == 0) { k++; }
            }
            return k;
        }
    
          void Main(string[] args)
        {


            Random r = new Random();
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(-10000, 10000);
                Console.WriteLine(array[i]);
            }



            Console.WriteLine($"\nВсего в массиве есть {MyMethod(array)} пар элементов, в которых хотя бы один делится на 3");










        }




    }
}
