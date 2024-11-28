using Matching_Game_App_System;

namespace MatchingGameTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //[Test]
        //public void TestGameStart()
        //{
        //    MatchingGame game = new();
        //    game.StartGame();
        //    string msg = $"Game state is: {game.GameState} {Environment.NewLine}Current turn is: {game.CurrentTurn}";
        //    TestContext.WriteLine("The 'GameState' should be 'Playing', and the 'CurrentTurn' should be 'PlayerOne'");
        //    Assert.That(game.GameState == MatchingGame.GameStateEnum.Playing && game.CurrentTurn == MatchingGame.CurrentTurnEnum.PlayerOne, msg);
        //    TestContext.WriteLine(msg);
        //}

        //[Test]
        //public void CheckThatSetScoreUpdatesScoresProperly()
        //{
        //    MatchingGame game = new();
        //    game.StartGame();
        //    TestContext.WriteLine("The current turn should be 'PlayerOne'");
        //    Assert.That(game.CurrentTurn == MatchingGame.CurrentTurnEnum.PlayerOne);
        //    TestContext.WriteLine($"The current turn is {game.CurrentTurn}");

        //    int playeronescore = game.PlayerScores[game.CurrentTurn.ToString()];
        //    TestContext.WriteLine($"The current players score is {playeronescore}");
        //    game.SetScore(true);
        //    TestContext.WriteLine("Player one should have another point");
        //    string msg = $"Player one now has {game.PlayerScores[game.CurrentTurn.ToString()]} point/'s";
        //    Assert.That(game.PlayerScores[game.CurrentTurn.ToString()] == playeronescore + 1);
        //    TestContext.WriteLine(msg);
            
        //}
    }
}