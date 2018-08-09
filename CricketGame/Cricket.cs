using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    public class Cricket
    {
        public int PlayerScore { get; set; }

        public Cricket()
        {
            PlayerScore = 0;
        }

        public void Score(int runs)
        {
            if (runs > 0 && runs < 7)
            {
                PlayerScore += runs;
            }
            else
            {
                PlayerScore = 0;

            }
        }
        public void Curr_Score(int runs)
        {
            PlayerScore = runs;
        }
    }
}
