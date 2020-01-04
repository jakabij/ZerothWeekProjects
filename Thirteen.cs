using System;
using System.Collections.Generic;
using System.Text;

namespace ZerothWeekProjects
{
    class Thirteen
    {
        public void seasonTime()
        {
            Console.WriteLine("Give a month!");
            string month = Console.ReadLine();
            if(month.Equals("december") || month.Equals("january") || month.Equals("february"))
            {
                Console.WriteLine("It's winter.");
            }
            else if(month.Equals("march") ||month.Equals("april") || month.Equals("may"))
            {
                Console.WriteLine("It's spring.");
            }
            else if(month.Equals("june")||month.Equals("july")||month.Equals("august"))
            {
                Console.WriteLine("It's summer.");
            }
            else if(month.Equals("september")||month.Equals("october")||month.Equals("november"))
            {
                Console.WriteLine("It's autumn.");
            }
            else
            {
                Console.WriteLine("Wrong argument!");
            }
        }
    }
}
