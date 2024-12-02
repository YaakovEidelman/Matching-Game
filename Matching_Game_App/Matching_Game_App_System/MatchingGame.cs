using System.ComponentModel;
using static Matching_Game_App_System.MatchingPiece;

namespace Matching_Game_App_System
{
    public class MatchingGame : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public event EventHandler? TotalWins;
        private enum GameStateEnum { NotPlaying, Playing, PostSecondPick }
        private enum CurrentTurnEnum { None, PlayerOne, PlayerTwo }

        private int _playeronescore;
        private int _playertwoscore;
        private string _gamedescription = "Click Start to Play";

        public MatchingGame(bool iswinforms = false)
        {
            this.IsWinForms = iswinforms;
            for (int i = 0; i < 20; i++)
            {
                MatchingPieces.Add(new MatchingPiece((IsWinForms) ? "images\\background.jpeg" : "background.jpeg"));
            }
        }

        public List<MatchingPiece> MatchingPieces { get; set; } = new();
        private GameStateEnum GameState = GameStateEnum.NotPlaying;
        private CurrentTurnEnum CurrentTurn = CurrentTurnEnum.None;

        public int PlayerOneScore
        {
            get => _playeronescore;
            private set
            {
                _playeronescore = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PlayerOneScore"));
            }
        }
        public int PlayerTwoScore
        {
            get => _playertwoscore;
            private set
            {
                _playertwoscore = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PlayerTwoScore"));
            }
        }
        public string GameDescription
        {
            get
            {
                return _gamedescription;
            }
            private set
            {
                _gamedescription = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GameDescription"));
            }
        }

        private Dictionary<string, string> PlayersDesc = new()
        {
            {"PlayerOne", "Player One"},
            {"PlayerTwo", "Player Two" }
        };
        private List<MatchingPiece> CurrentTurnSelectedPieces = new();
        private int NumClicks { get; set; } = 0;
        private bool IsWinForms { get; set; }

        public static int PlayerOneTotalWins;
        public static int PlayerTwoTotalWins;
        public static int TotalTies;



        public void StartGame()
        {
            this.GameState = GameStateEnum.Playing;
            this.CurrentTurn = CurrentTurnEnum.PlayerOne;
            this.NumClicks = 0;
            SetScore();
            foreach (var p in MatchingPieces)
            {
                p.SelectedImage = RevealedImage.BackgroundImage;
                p.FrontImage = "";
            }
            PlaceImagesOnCards();
            SetStatus();
        }
        public async Task RevealTile(int index)
        {
            if (GameState == GameStateEnum.Playing)
            {
                MatchingPiece mp = this.MatchingPieces[index];
                mp.SelectedImage = RevealedImage.FrontImage;
                if (mp.FrontImage != "" && !CurrentTurnSelectedPieces.Contains(mp))
                {
                    CurrentTurnSelectedPieces.Add(mp);
                    NumClicks++;
                }

                if (NumClicks >= 2)
                {
                    GameState = GameStateEnum.PostSecondPick;

                    if (GameState == GameStateEnum.PostSecondPick && CurrentTurnSelectedPieces[0].FrontImage == CurrentTurnSelectedPieces[1].FrontImage)
                    {
                        await Task.Delay(1000);
                        MatchingPieces
                            .Where(m => m.SelectedImage == RevealedImage.FrontImage)
                            .ToList()
                            .ForEach(m =>
                            {
                                m.FrontImage = "";
                                m.SelectedImage = RevealedImage.FrontImage;
                            });
                        SetScore(true);
                        SetStatus("Great Job! Go Again!");
                    }
                    else
                    {
                        GameDescription = "Sorry, try again next time";
                        await Task.Delay(2000);
                        MatchingPieces
                            .Where(m => m.FrontImage == CurrentTurnSelectedPieces[0].FrontImage || m.FrontImage == CurrentTurnSelectedPieces[1].FrontImage)
                            .ToList()
                            .ForEach(m =>
                            {
                                m.SelectedImage = RevealedImage.BackgroundImage;
                            });
                        ChangeTurn();
                        SetStatus();
                    }
                    NumClicks = 0;
                    CurrentTurnSelectedPieces.Clear();
                    GameState = GameStateEnum.Playing;
                }

            }
        }

        private void SetScore(bool plusone = false)
        {
            if (plusone && CurrentTurn != CurrentTurnEnum.None)
            {
                if (CurrentTurn == CurrentTurnEnum.PlayerOne)
                {
                    PlayerOneScore++;
                }
                else
                {
                    PlayerTwoScore++;
                }
            }
            else
            {
                PlayerOneScore = 0;
                PlayerTwoScore = 0;
            }
        }
        private void PlaceImagesOnCards()
        {
            List<string> templstshapes = new()
            {
                "bassclef.jpeg",
                "bumblebee.jpeg",
                "candy.jpeg",
                "card.jpeg",
                "chair.jpeg",
                "dice.jpeg",
                "lamp.jpeg",
                "pen.jpeg",
                "squares.jpeg",
                "trebleclef.jpeg",
                "bassclef.jpeg",
                "bumblebee.jpeg",
                "candy.jpeg",
                "card.jpeg",
                "chair.jpeg",
                "dice.jpeg",
                "lamp.jpeg",
                "pen.jpeg",
                "squares.jpeg",
                "trebleclef.jpeg"
            };

            Random r = new();

            MatchingPieces.ForEach(p =>
            {
                string selectedval = templstshapes[r.Next(0, templstshapes.Count)];
                templstshapes.Remove(selectedval);
                if (IsWinForms)
                {
                    p.FrontImage = "images\\" + selectedval;
                }
                else
                {
                    p.FrontImage = selectedval;
                }
            });
        }
        private void ChangeTurn()
        {
            if (CurrentTurn != CurrentTurnEnum.None)
            {
                CurrentTurn = (CurrentTurn == CurrentTurnEnum.PlayerOne) ? CurrentTurnEnum.PlayerTwo : CurrentTurnEnum.PlayerOne;
            }
        }
        private void SetStatus(string msg = "")
        {
            if (CheckForEndGame())
            {
                //GameDescription = (PlayerOneScore > PlayerTwoScore) ? PlayersDesc["PlayerOne"] + " Wins" : (PlayerTwoScore > PlayerOneScore) ? PlayersDesc["PlayerTwo"] + " Wins" : "Tie Game";
                if (PlayerOneScore > PlayerTwoScore)
                {
                    GameDescription = PlayersDesc["PlayerOne"] = "Wins";
                    PlayerOneTotalWins++;
                }
                else if (PlayerOneScore < PlayerTwoScore)
                {
                    GameDescription = PlayersDesc["PlayerTwo"] + " Wins";
                    PlayerTwoTotalWins++;
                }
                else
                {
                    GameDescription = "Tie Game";
                    TotalTies++;
                }
                TotalWins?.Invoke(this, new EventArgs());
            }
            else if (CurrentTurn != CurrentTurnEnum.None)
            {
                GameDescription = PlayersDesc[CurrentTurn.ToString()] + " " + msg;
            }
        }
        private bool CheckForEndGame()
        {
            if (MatchingPieces.Count(mp => mp.SelectedImage == RevealedImage.FrontImage) == 20)
            {
                return true;
            }
            return false;
        }

    }
}
