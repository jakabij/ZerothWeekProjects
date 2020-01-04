using System;
using System.Collections.Generic;
using System.Text;

namespace ZerothWeekProjects
{
    class Seven
    {
        public void avg()
        {
            double number1;
            double number2;

            try
            {
                number1 = Convert.ToDouble(Console.ReadLine());
                number2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine((number1 + number2) / 2);
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR occured! "+e);
            }

            
        }
    }
}
