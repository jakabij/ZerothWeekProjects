using System;
using System.Collections.Generic;
using System.Text;

namespace ZerothWeekProjects
{
    class Ten
    {
        public void toConvert()
        {
            Console.WriteLine("Add the amount in dl!");
            try
            {
                double dl=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The added amount was: "+dl+" dl which is "+(dl/10)+" liter and "+((dl/10)/100)+" hektoliter.");
            }

            catch(Exception e)
            {
                Console.WriteLine("An error ocured! "+e);
            }
        }
    }
}
