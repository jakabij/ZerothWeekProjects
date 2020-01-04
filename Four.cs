using System;
using System.Collections.Generic;
using System.Text;

namespace ZerothWeekProjects
{
    class Four
    {
        public string negativeOrPositive()
        {
            Console.WriteLine("Give the number!");
            string input = Console.ReadLine();
            double number;
            try 
            {
                number = Convert.ToDouble(input);
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR occured!" +e);
                return null;
            }

            if(number>=0)
            {
                return "The number is positive.";
            }
            else
            {
                return "The number is negative.";
            }

        }
    }
}
