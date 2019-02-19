using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public static class SweepstakesManagerCreator
    {

        public static ISweepstakesManager GetSweepstakesManager()
        {
            string dataStoreType = UI.PickDataManagerType();
            ISweepstakesManager temp = null;
            if (dataStoreType == "queue")
            {
                SweepstakeQueueManager sweepstakeQueueManager = new SweepstakeQueueManager();
                temp = sweepstakeQueueManager;
            }
            else if (dataStoreType == "stack")
            {
                SweepstakesStackManager sweepstakesStackManager = new SweepstakesStackManager();
                temp = sweepstakesStackManager;
            }

            return temp;
        }
        



    }
}
