using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Sweepstakes
    {
        public string sweepstakesName;
        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        private int registrationNumber = 00001;
        public Contestant winner;
        public Sweepstakes(string name)
        {
            sweepstakesName = name;
        }

       

        public void RegisterContestant(Contestant contestant)
        {
            contestant.registrationNumber = registrationNumber;
            contestants.Add(contestant.registrationNumber, contestant);
            registrationNumber++;

        }

        public string PickWinner()
        {
            Random rnd = new Random();
            List<int> keyList = new List<int>(contestants.Keys);
            int numberWinner = keyList[rnd.Next(keyList.Count)];
            winner = contestants[numberWinner];
            return contestants[numberWinner].firstName;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"The contestant's info is:\n {contestant.firstName}\n{contestant.lastName}\n{contestant.email}\n{contestant.registrationNumber}");

        }

        public void NotifyContestants(Dictionary<int,Contestant> dictionaryOfContestants)
        {
            foreach( KeyValuePair<int, Contestant> entry in contestants)
            {
                if (entry.Value.registrationNumber == winner.registrationNumber)
                {
                    Console.WriteLine($"Congratulations {winner.firstName} {winner.lastName}, You've won the {sweepstakesName} sweepstake!" +
                        $"you will be contacted shortly with information on how to collect your prize." );
                }
                else
                {
                    Console.WriteLine($"Dear {entry.Value.firstName} {entry.Value.lastName}, the sweepstakes {sweepstakesName} has ended." +
                        $"Unfortunately, you did not win. We would like to thank you for your participation and hope that you'll" +
                        $"enter other sweepstakes we hold for chances at many other prizes! Have a nice day, and thanks for entering {sweepstakesName}");
                }
            }

        }
    }
}
