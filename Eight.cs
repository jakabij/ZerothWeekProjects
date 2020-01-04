using System;
using System.Collections.Generic;
using System.Text;

namespace ZerothWeekProjects
{
    class Eight
    {
        public void dataCalculator()
        {
            double a;
            double b;
            double c;

            try
            {
                Console.WriteLine("Give the 3 sides!");
                a= Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                c = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("The side's diagonals: "+(Math.Sqrt((Math.Pow(a,2)+Math.Pow(b, 2))))+", "+
                    (Math.Sqrt((Math.Pow(a, 2) + Math.Pow(c, 2))))+", "+ (Math.Sqrt((Math.Pow(c, 2) + Math.Pow(b, 2)))));

                Console.WriteLine("The cuboid's diagonal: "+(Math.Sqrt(Math.Pow(a, 2)+ Math.Pow(b, 2)+ Math.Pow(c, 2))));

                Console.WriteLine("The cuboid's volumetric: "+(a*b*c)+" and surface: "+(2*(a*b+a*c+b*c)));
            }
            catch(Exception e)
            {
                Console.WriteLine("An error occured! "+e);
            }
        }
    }
}
