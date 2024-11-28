using Matching_Game_App_System;

namespace MatchingGameTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGameStart()
        {
            MatchingGame game = new();
            game.StartGame();
            TestContext.WriteLine("If the game started properly, the 'FrontImage' property of any of the 'GamePiece' classes will not be blank");
            string msg = "The first pieces 'FrontImage' property is set to " + game.MatchingPieces[0].FrontImage;
            Assert.IsTrue(game.MatchingPieces[0].FrontImage != "", msg);
            TestContext.WriteLine(msg);
        }

        [Test]
        public async Task TestRevealTile()
        {
            MatchingGame game = new();
            game.StartGame();

            MatchingPiece mp1 = game.MatchingPieces[0];
            MatchingPiece mp2 = game.MatchingPieces.Skip(1).First(p => p.FrontImage == mp1.FrontImage);
            int mp1index = game.MatchingPieces.IndexOf(mp1);
            int mp2index = game.MatchingPieces.IndexOf(mp2);

            TestContext.WriteLine($"{mp1index} {mp1.FrontImage} : {mp2index} {mp2.FrontImage}");

            await game.RevealTile(mp1index);
            await game.RevealTile(mp2index);
            TestContext.WriteLine("Player One's score should be 1");
            string msg = "Player One's score is " + game.PlayerOneScore;
            Assert.IsTrue(game.PlayerOneScore == 1, msg);
            TestContext.WriteLine(msg);

            TestContext.WriteLine("Checking that the turn does not change after a match is found");

            mp1 = game.MatchingPieces[1];
            mp2 = game.MatchingPieces.Skip(2).First(p => p.FrontImage == mp1.FrontImage);
            mp1index = game.MatchingPieces.IndexOf(mp1);
            mp2index = game.MatchingPieces.IndexOf(mp2);

            TestContext.WriteLine($"{mp1index} {mp1.FrontImage} : {mp2index} {mp2.FrontImage}");

            await game.RevealTile(mp1index);
            await game.RevealTile(mp2index);
            TestContext.WriteLine("If its still Player One's turn, then player one's score should now be 2");
            msg = "Player One's score is " + game.PlayerOneScore;
            Assert.IsTrue(game.PlayerOneScore == 2, msg);
            TestContext.WriteLine(msg);
        }

        [Test]
        public async Task TestThatTurnChangesAfterWrongMatch()
        {
            MatchingGame game = new();
            game.StartGame();

            MatchingPiece mp1 = game.MatchingPieces[0];
            MatchingPiece mp2 = game.MatchingPieces.First(p => p.FrontImage != mp1.FrontImage);
            int mp1index = game.MatchingPieces.IndexOf(mp1);
            int mp2index = game.MatchingPieces.IndexOf(mp2);

            TestContext.WriteLine($"{mp1index} {mp1.FrontImage} : {mp2index} {mp2.FrontImage}");

            await game.RevealTile(mp1index);
            await game.RevealTile(mp2index);

            TestContext.WriteLine("Testing that the turn changes after a wrong match is picked");

            mp1 = game.MatchingPieces[0];
            mp2 = game.MatchingPieces.Skip(1).First(p => p.FrontImage == mp1.FrontImage);
            mp1index = game.MatchingPieces.IndexOf(mp1);
            mp2index = game.MatchingPieces.IndexOf(mp2);

            TestContext.WriteLine($"{mp1index} {mp1.FrontImage} : {mp2index} {mp2.FrontImage}");

            await game.RevealTile(mp1index);
            await game.RevealTile(mp2index);
            TestContext.WriteLine("If the turn changed to Player Two's turn, then Player Two's score will be 1");
            string msg = "Player Two's score is " + game.PlayerTwoScore;
            Assert.IsTrue(game.PlayerTwoScore == 1, msg);
            TestContext.WriteLine(msg);
        }

    }
}