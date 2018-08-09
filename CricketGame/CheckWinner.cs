namespace CricketGame
{
    public class CheckWinner
    {
        private int _score = -1;
        public int winner=0;
        private int _tie = 0;

        public CheckWinner()
        {

        }
        public void PlayerScore(int playerNumber,int score)
        {
            if(_score<score)
            {
                _score = score;
                winner = playerNumber;
            }
            else if(_score==score)
            {
                _tie =1;
            }
        }

        public bool IsTie()
        {
            if (_tie == 1)
            {
                return true;
            }
            else
                return false;
        }
        public bool ShowWinner(int playerNumber)
        {
            if (winner == playerNumber)
            {
                return true;
            }
            else
                return false;
        }
    }
}
