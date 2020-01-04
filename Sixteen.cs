using System;
using System.Collections.Generic;
using System.Text;

namespace ZerothWeekProjects
{
    class Sixteen
    {
        public void passwordCheck()
        {
            string password="nagy@69";
            Console.WriteLine("Add the password!");
            string passwordToCheck = Console.ReadLine();
            if(passwordToCheck.Equals(password))
            {
                Console.WriteLine("You are in! Greetings!");
            }
            else
            {
                for(int count=0;count<4;count++)
                {
                    Console.WriteLine((4-count)+" tries left! Give it again!");
                    passwordToCheck = Console.ReadLine();
                    if (passwordToCheck.Equals(password))
                    {
                        Console.WriteLine("You are in! Greetings!");
                        break;
                    }
                }
            }
        }
    }
}
