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
    }
}
