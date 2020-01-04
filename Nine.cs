using System;
using System.Collections.Generic;
using System.Text;

namespace ZerothWeekProjects
{
    class Nine
    {
        public void datas()
        {
            double a;
            double b;
            double c;

            try
            {
                Console.WriteLine("Give the 3 sides!");
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                c = Convert.ToDouble(Console.ReadLine());

                double[] sideDiagonals = new double[3];
                sideDiagonals[0] = Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2)));
                sideDiagonals[1] = Math.Sqrt((Math.Pow(a, 2) + Math.Pow(c, 2)));
                sideDiagonals[2] = Math.Sqrt((Math.Pow(c, 2) + Math.Pow(b, 2)));
                double min = sideDiagonals[0];
                int index = 0;
                for(int count=1;count<3;count++)
                {
                    if(min>sideDiagonals[count])
                    {
                        min = sideDiagonals[count];
                        index = count;
                    }
                }

                double firstSide;
                double secondSide;

                if(index==0)
                {
                    firstSide = a;
                    secondSide = b;
                }
                else if(index==1)
                {
                    firstSide = a;
                    secondSide = c;
                }
                else
                {
                    firstSide = c;
                    secondSide = b;
                }

                Console.WriteLine("The shortest side's diagonal: "+min);
                Console.WriteLine("This side's area: "+(firstSide*secondSide)+", the district: "+2*(firstSide+secondSide));

                
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occured! " + e);
            }
        }
    }
}
