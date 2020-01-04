using System;
using System.Collections.Generic;
using System.Text;

namespace ZerothWeekProjects
{
    class Twelve
    {
        public void numberOfDigits()
        {
            Console.WriteLine("Give a non negative number!");
            string number = Console.ReadLine();
            if(number[0]=='-')
            {
                Console.WriteLine("NON NEGATIVE!");
            }
            else
            {
                Console.WriteLine("The number has " + number.Length + " digits.");
            }
            
        }
    }
}
