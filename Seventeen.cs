using System;
using System.Collections.Generic;
using System.Text;

namespace ZerothWeekProjects
{
    class Seventeen
    {
        public void whichSeason()
        {
            Console.WriteLine("Add the number of the month!");
            try
            {
                int month = Convert.ToInt32(Console.ReadLine());
                if(month==12 || month==1 || month ==2)
                {
                    Console.WriteLine("It's winter!");
                }
                else if(month ==3 || month ==4 || month ==5)
                {
                    Console.WriteLine("It's spring!");
                }
                else if(month ==6 || month ==7 || month ==8)
                {
                    Console.WriteLine("It's summer!");
                }
                else if(month ==9 || month ==10 || month ==11)
                {
                    Console.WriteLine("It's autumn!");
                }
                else
                {
                    Console.WriteLine("Wrong argument!");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("An error occured! "+e);
            }
        }
    }
}
