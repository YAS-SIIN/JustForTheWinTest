using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustForTheWinTest
{

    /// <summary>
    /// Some function for game action
    /// </summary>  
    public class GameActions
    {

        /// <summary>
        /// this will return list of twenty ball
        /// </summary>  
        public int[] GenerateStatus()
        {
            Random rnd = new Random();

            int[] BallRandomStatus = new int[19];
            BallRandomStatus[0] = 2;
            for (int i = 1; i < 19; i++)
            {
                if (i <= 5)
                    BallRandomStatus[i] = 1;
                else
                    BallRandomStatus[i] = 0;
            }

            return BallRandomStatus.OrderBy(x => rnd.Next()).ToArray();
        }
    }
}
