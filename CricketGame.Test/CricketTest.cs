using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CricketGame.Test
{
    [TestClass]
    public class CricketTest
    {
        [TestMethod]
        public void PlayerScore_NewGame_ShouldBeZero()
        {
            var game = new Cricket();
            Assert.IsTrue(game.PlayerScore==0);
        }

       

        [TestMethod]
        public void Score_Validruns_ShouldUpdatePlayerScore()
        {
            var game = new Cricket();
            game.Score(3);
            Assert.IsTrue(game.PlayerScore==3);
        }

        [TestMethod]
        public void Score_Validruns_ShouldNotUpdatePlayerScore()
        {
            var game = new Cricket();
            game.Score(7);
            Assert.IsTrue(game.PlayerScore == 0);
        }

        [TestMethod]
        public void TwoPlayerScore_NewGame_ShouldBeZero()
        {
            var game = new TwoPlayersCricket();
            Assert.IsTrue(game.PlayerScore == 0);
        }

        [TestMethod]
        public void CheckingWinner()
        {
            var game = new CheckWinner();           
            Assert.IsTrue(game.ShowWinner(0));
        }

        [TestMethod]
        public void Score_Validruns_ShouldUpdateBothPlayerScore()
        {
            var game = new TwoPlayersCricket();
            game.Score(3);
            Assert.IsTrue(game.PlayerScore == 3);
        }

       
    }
}
