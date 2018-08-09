using TechTalk.SpecFlow;
using FluentAssertions;

namespace CricketGame.specs
{
    [Binding]
    public class TwoPlayerScoreSteps
    {
        private TwoPlayersCricket _player = new TwoPlayersCricket();
        private CheckWinner _checkWinner = new CheckWinner();

        [Given(@"player(.*) has scored (.*) runs")]
        public void PlayerHasScoredAlready(int playerNumber , int score)
        {
            _player.Current_Score(score);
        }
        [Given(@"Player(.*) starts a game of cricket")]
        [When(@"Player(.*) starts a game of cricket")]
        public void WhenInningStarts(int playerNumber)
        {
            _player.Current_Score(0); 
           
        }

        [Given(@"player(.*) scores (.*) runs")]
        public void PlayerKeepScoring(int playerNumber, int score)
        {
            _player.Score(score);
        }

        [Given(@"player(.*) got out")]
        public void playerGotOut(int playerNumber)
        {
            _checkWinner.PlayerScore(playerNumber,_player.PlayerScore);
            _player.Current_Score(0);
        }

        [When(@"player(.*) gets out")]
        public void playerGetsOut(int playerNumber)
        {
            _checkWinner.PlayerScore(playerNumber, _player.PlayerScore);
            
        }

        [Then(@"player(.*) is the winner")]
        public void Winner(int playerNumber)
        {
            _checkWinner.PlayerScore(playerNumber, _player.PlayerScore);
            _checkWinner.ShowWinner(playerNumber).Should().BeTrue();
        }

        [When(@"player(.*) scores (.*) runs")]
        public void PlayerScoreAgain(int playerNumber , int score)
        {
            _player.Score( score);
        }
        [Then(@"the player(.*) score should be (.*)")]
        public void InitialScore(int playerNumber ,int score)
        {

            _player.PlayerScore.Should().Be(score);
        }

        [Then(@"Match tied")]
        public void MatchTied()
        {
            _checkWinner.IsTie().Should().BeTrue();
        }
    }
}
