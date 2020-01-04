using System;
using System.Collections.Generic;
using System.Text;

namespace ZerothWeekProjects
{
    class Fourteen
    {
        public void isItProfit()
        {
            Console.Write("The makings: ");
            try
            {
                double makings = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.Write("The outgoings: ");
                double outgoings = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("The outcome is: "+(makings-outgoings));
                if((makings - outgoings)>0)
                {
                    Console.WriteLine("It's a profit!");
                }
                else if((makings - outgoings)<0)
                {
                    Console.WriteLine("It's a losing!");
                }
                else
                {
                    Console.WriteLine("It's a zero method!");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("An error occured! "+e);
            }
        }
    }
}
