using System;
using System.Collections.Generic;
using System.Text;

namespace ZerothWeekProjects
{
    class One
    {
        public void circleDatas()
        {
            Console.WriteLine("Give the r!");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The circle's district: "+(2*r*3.14));
            Console.WriteLine("The circle's area: " + (Math.Pow(r,2) * 3.14));
        }

        public void globeDatas()
        {
            Console.WriteLine("Give the r!");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The globe's surface: "+(4*Math.Pow(r,2)*3.14));
            Console.WriteLine("The globe's volumetric: "+((4 * Math.Pow(r, 3) * 3.14)/3));
        }
    }
}
