using System;
using System.Collections.Generic;
using System.Text;

namespace ZerothWeekProjects
{
    class Fifteen
    {
        public void languageAsking()
        {
            Console.WriteLine("Do you speak hungarian?");
            string answer = Console.ReadLine();
            if(answer.Equals("yes")||answer.Equals("Yes"))
            {
                Console.WriteLine("Üdvözleheletem!");
            }
            else
            {
                Console.WriteLine("Do you speak english? (If not then I can say anything wrong about you since the begining!)");
                answer = Console.ReadLine();
                if (answer.Equals("yes") || answer.Equals("Yes"))
                {
                    Console.WriteLine("Hello there!");
                }
                else
                {
                    Console.WriteLine("Do you speak spanish?");
                    answer = Console.ReadLine();
                    if (answer.Equals("yes") || answer.Equals("Yes"))
                    {
                        Console.WriteLine("Ni siquiera se que es!");
                    }
                    else
                    {
                        Console.WriteLine("\u2665");
                    }
                }
            }
        }
    }
}
