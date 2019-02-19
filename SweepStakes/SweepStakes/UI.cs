using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    static class UI
    {
        public static string PickDataManagerType()
        {
            Console.WriteLine("\nWhich type of data structure would you like? Please type Queue or Stack\n");
            string stackOrQueue = Console.ReadLine();
            stackOrQueue = stackOrQueue.ToLower();
            return stackOrQueue;
        }

        public static string SetFirstName()
        {
            Console.WriteLine("\nContestant's first name?\n");
            string firstName = Console.ReadLine();
            return firstName;              
        }

        public static string SetLastName()
        {
            Console.WriteLine("\nContestant's last name?\n");
            string lastName = Console.ReadLine();
            return lastName;
        }

        public static string SetEmail()
        {
            Console.WriteLine("\nContestant's email address?\n");
            string email = Console.ReadLine();
            return email;
        }

        
    }
}
