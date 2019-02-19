using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    static class UI
    {
        static string PickDataManagerType()
        {
            Console.WriteLine("Which type of data structure would you like? Please type Queue or Stack");
            string stackOrQueue = Console.ReadLine();
            stackOrQueue = stackOrQueue.ToLower();
            return stackOrQueue;
        }

        static string SetFirstName()
        {
            Console.WriteLine("Contestant's first name?");
            string firstName = Console.ReadLine();
            return firstName;              
        }

       
        
    }
}
