using System;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace CricketGame.specs
{
    [Binding]
    public class PlayerScoreSteps
    {
        private Cricket _game;
        [When(@"Player starts a game of cricket")]
        [Given(@"Player has started a game of cricket")]
        public void WhenPlayerHasStartedAGameOfCricket()
        {
            //ScenarioContext.Current.Pending();
            _game = new Cricket();
        }

        [When(@"Player scores (.*) runs")]
        public void WhenPlayerScoresRuns(int runs)
        {
            //ScenarioContext.Current.Pending();
            _game.Score(runs);
        }

        [Given(@"Player has scored (.*) runs")]
        public void PlayerIsPlayingAGameOfCricket(int runs)
        {
            //ScenarioContext.Current.Pending();
            _game.Curr_Score(runs);
        }

        [Given(@"Player gets out")]
        public void PlayerOut()
        {
            _game.Score(-1);
        }

        [Then(@"the player score should be (.*)")]
        public void ThenThePlayerScoreShouldBe(int score)
        {
            // ScenarioContext.Current.Pending();
            _game.PlayerScore.Should().Be(score);
        }
        
    }
}
