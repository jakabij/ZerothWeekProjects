using System;
using System.Collections.Generic;
using System.Text;

namespace ZerothWeekProjects
{
    class Eleven
    {
        public void divisible()
        {
            Console.WriteLine("Add the number!");
            string number=Console.ReadLine();

            int sum = 0;

            for(int count=0;count<number.Length;count++)
            {
                sum += Convert.ToInt32(number[count].ToString());
                Console.WriteLine(sum);
            }

            Console.WriteLine("The summary of the number's digits: "+sum);

            if(sum%9==0)
            {
                Console.WriteLine("The number divisible by 9.");
            }
            else
            {
                Console.WriteLine("The number not divisible by 9.");
            }
        }
    }
}
