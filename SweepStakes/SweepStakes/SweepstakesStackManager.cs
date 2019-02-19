using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepstakesStackManager: ISweepstakesManager
    {

        Stack<Sweepstakes> sweepStorage = new Stack<Sweepstakes>();
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepStorage.Push(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes nextSweep = sweepStorage.Pop();
            return nextSweep;

        }

    }
}
