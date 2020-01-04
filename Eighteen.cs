using System;
using System.Collections.Generic;
using System.Text;

namespace ZerothWeekProjects
{
    class Eighteen
    {
        public void avgYearCelsius()
        {
            Console.WriteLine("Which year is this?");
            try
            {
                int year = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Add the month's cesius!\n");
                double sumCelsius=0;

                for (int count = 0; count < 12; count++)
                {
                    Console.WriteLine("How much was in " + year + "/" + (count + 1));
                    sumCelsius+= Convert.ToDouble(Console.ReadLine());
                }

                Console.WriteLine("The avg was: "+(sumCelsius/12));
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occured! " + e);
            }
        }
    }
}
