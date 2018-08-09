namespace CricketGame
{
    public class TwoPlayersCricket
    {

        public int PlayerScore;
        public int winner=0;

        public TwoPlayersCricket()
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
        public void Current_Score(int score)
        {
            PlayerScore = score;
        }
    }
}
