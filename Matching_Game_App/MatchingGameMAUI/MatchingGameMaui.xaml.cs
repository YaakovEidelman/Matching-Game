using Matching_Game_App_System;

namespace MatchingGameMAUI;

public partial class MatchingGameMaui : ContentPage
{
    MatchingGame activegame;
    List<Image> lstpictures;
    List<MatchingGame> lstgames = new() { new MatchingGame(), new MatchingGame(), new MatchingGame() };
    TapGestureRecognizer tgr = new();
    public MatchingGameMaui()
    {
        InitializeComponent();
        
        Rbgame1.BindingContext = lstgames[0];
        Rbgame2.BindingContext = lstgames[1];
        Rbgame3.BindingContext = lstgames[2];

        activegame = lstgames[0];
        this.BindingContext = activegame;

        tgr.Tapped += Tgr_Tapped;
        lstgames.ForEach(g => g.TotalWins += G_TotalWins);

        lstpictures = new() { pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8, pic9, pic10, pic11, pic12, pic13, pic14, pic15, pic16, pic17, pic18, pic19, pic20 };
        FillImages();
    }

    private void FillImages()
    {
        lstpictures.ForEach(p =>
        {
            MatchingPiece piece = activegame.MatchingPieces[lstpictures.IndexOf(p)];
            p.BindingContext = piece;
            p.GestureRecognizers.Add(tgr);
        });
    }

    private void G_TotalWins(object? sender, EventArgs e)
    {
        PlayerOneTotalWins.Text = MatchingGame.PlayerOneTotalWins.ToString();
        PlayerTwoTotalWins.Text = MatchingGame.PlayerTwoTotalWins.ToString();
        TotalTies.Text = MatchingGame.TotalTies.ToString();
    }

    private async void Tgr_Tapped(object? sender, TappedEventArgs e)
    {
        if (sender != null)
        {
            await activegame.RevealTile(lstpictures.IndexOf((Image)sender));
        }
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        
        activegame.StartGame();

    }

    private void Game_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {

        RadioButton rb = (RadioButton)sender;
        if(rb.IsChecked && rb.BindingContext != null)
        {
            //FillImages();
            activegame = (MatchingGame)rb.BindingContext;
            this.BindingContext = activegame;
            FillImages();
        }
    }
}