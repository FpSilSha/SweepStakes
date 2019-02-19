using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepstakeQueueManager : ISweepstakesManager
    {

        Queue<Sweepstakes> sweepStorage = new Queue<Sweepstakes>();
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepStorage.Enqueue(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes nextSweep = sweepStorage.Dequeue();
            return nextSweep;

        }



    }
}
