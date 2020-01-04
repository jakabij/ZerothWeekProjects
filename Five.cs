using System;
using System.Collections.Generic;
using System.Text;

namespace ZerothWeekProjects
{
    class Five
    {
        public string toCalculate()
        {
            Console.WriteLine("Give 2 numbers!");
            double number1;
            double number2;

            try
            {
                number1 = Convert.ToDouble(Console.ReadLine());
                number2 = Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR occured! "+e);
                return null;
            }

            return "The 2 numbers' sum: "+(number1+number2)+", the difference: "+(number1-number2)+", the multiplier: "+(number1*number2)+", the divisor: "+(number1/number2);
        }
    }
}
