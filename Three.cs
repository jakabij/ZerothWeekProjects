using System;
using System.Collections.Generic;
using System.Text;

namespace ZerothWeekProjects
{
    class Three
    {
        public string editable()
        {
            Console.WriteLine("Give the 3 sides!");
            double[] sides = new double[3];
            int a = 0;
            int b = 1;
            int c = 2;

            for(int count=0;count<3;count++)
            {
                sides[count] = Convert.ToDouble(Console.ReadLine());
            }

            if(((sides[a]+sides[b])>sides[c]) && ((sides[a]+sides[c])>sides[b]) && ((sides[b]+sides[c])>sides[a]))
            {
                return "Editable!";
            }
            else
            {
                return "Not editable!";
            }
            
        }
    }
}
