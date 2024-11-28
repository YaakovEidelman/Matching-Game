using Matching_Game_App_System;

namespace Matching_Game_App
{
    public partial class Matching_Game : Form
    {
        MatchingGame game = new MatchingGame(true);
        List<PictureBox> lstpictures;

        public Matching_Game()
        {
            InitializeComponent();
            btnStart.Click += BtnStart_Click;

            lstpictures = new() { pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8, pic9, pic10, pic11, pic12, pic13, pic14, pic15, pic16, pic17, pic18, pic19, pic20 };
            lstpictures.ForEach(p =>
            {
                MatchingPiece piece = game.MatchingPieces[lstpictures.IndexOf(p)];
                p.DataBindings.Add("ImageLocation", piece, "SelectedImagePath");
                p.Click += Card_Click;
            });
            lblPlayerOneScore.DataBindings.Add("Text", game, "PlayerOneScore");
            lblPlayerTwoScore.DataBindings.Add("Text", game, "PlayerTwoScore");
            lblStatus.DataBindings.Add("Text", game, "GameDescription");
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            game.StartGame();
        }
        private void Card_Click(object? sender, EventArgs e)
        {
            if (sender != null)
            {
                game.RevealTile(lstpictures.IndexOf((PictureBox)sender));
            }
        }

    }
}