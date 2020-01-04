using System;
using System.Collections.Generic;
using System.Text;

namespace ZerothWeekProjects
{
    class Nineteen
    {
        public void coffeeThings()
        {
            int price = 90;

            Console.WriteLine("The coffee's price is 90 Ft.");
            Console.WriteLine("If you want it without a cup you can spare 10 Fts. Just hit number 1.");
            Console.WriteLine("If you want your coffee with double sugar you have to pay 20 more Fts. Before that, hit number 2.");
            Console.WriteLine("If you want a latte pay more 50 Fts. Before that, hit number 3.");
            Console.WriteLine("If you finished hit number 4.");

            string choice= Console.ReadLine();
            while(choice!="4")
            {
                if(choice=="1")
                {
                    price -= 10;
                }
                
                else if(choice=="2")
                {
                    price += 20;
                }

                else if(choice=="3")
                {
                    price += 50;
                }

                Console.Write("next move: ");
                choice = Console.ReadLine();
                Console.WriteLine();
            }

            Console.WriteLine("You have to pay "+price+" Fts!");
        }
    }
}
