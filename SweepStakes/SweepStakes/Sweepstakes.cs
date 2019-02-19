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
        public Sweepstakes(string name)
        {
            sweepstakesName = name;
        }

       

        public void RegisterContestant(Contestant contestant)
        {


        }

        public string PickWinner()
        {


        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
