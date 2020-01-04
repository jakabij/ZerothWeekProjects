using System;
using System.Collections.Generic;
using System.Text;

namespace ZerothWeekProjects
{
    class Twenty
    {
        public void cashFactor()
        {
            int five = 0;
            int ten = 0;
            int twenty = 0;
            int fifty = 0;
            int oneHundred = 0;
            int twoHundred = 0;
            int fiveHundred=0;
            int oneThousand = 0;

            Console.WriteLine("Add the amount!");
            string stringAmount = Console.ReadLine();

            try
            {
                int amount = Convert.ToInt32(stringAmount);

                oneThousand=amount/1000;
                amount = amount - (oneThousand * 1000);

                fiveHundred = amount / 500;
                amount = amount - (fiveHundred * 500);
                
                twoHundred = amount / 200;
                amount = amount - (twoHundred * 200);

                oneHundred = amount / 100;
                amount = amount - (oneHundred * 100);

                fifty = amount / 50;
                amount = amount - (fifty * 50);

                twenty = amount / 20;
                amount = amount - (twenty * 20);

                ten = amount / 10;
                amount = amount - (ten * 10);

                five = amount / 5;
                amount = amount - (five * 5);

                Console.WriteLine("1000: "+oneThousand+" db\n"+"500: "+fiveHundred+" db\n"+"200: "+twoHundred+" db\n"+"100: "+oneHundred+" db\n"+"50: "+fifty+" db\n"+"20: "+twenty+" db\n"+"10: "+ten+" db\n"+"5: "+five+" db\n\tneed to pay.");
            }

            catch(Exception e)
            {
                Console.WriteLine("Error occured! "+e);
            }
        }
    }
}
