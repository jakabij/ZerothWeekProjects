using System;
using System.Collections.Generic;
using System.Text;

namespace ZerothWeekProjects
{
    class Two
    {
        public void descending()
        {
            Console.WriteLine("Give 3 number!");
            double[] numbers = new double[3];
            int count = 0;

            for (; count < 3; count++)
            {
                numbers[count] = Convert.ToDouble(Console.ReadLine());
            }

            Array.Sort(numbers);
            Array.Reverse(numbers);

            for (count=0; count < 2; count++)
            {
                Console.Write(numbers[count]+", ");
            }
            Console.Write(numbers[count]+"\n");
        }
    }
}
