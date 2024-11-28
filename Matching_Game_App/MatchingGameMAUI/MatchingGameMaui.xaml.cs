using Matching_Game_App_System;

namespace MatchingGameMAUI;

public partial class MatchingGameMaui : ContentPage
{
    List<Image> lstpictures;
    private MatchingGame game = new();
    public MatchingGameMaui()
    {
        InitializeComponent();

        TapGestureRecognizer tgr = new();
        tgr.Tapped += Tgr_Tapped;

        this.BindingContext = game;
        lstpictures = new() { pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8, pic9, pic10, pic11, pic12, pic13, pic14, pic15, pic16, pic17, pic18, pic19, pic20 };
        lstpictures.ForEach(p =>
        {
            MatchingPiece piece = game.MatchingPieces[lstpictures.IndexOf(p)];
            p.BindingContext = piece;
            p.GestureRecognizers.Add(tgr);

        });
    }

    private async void Tgr_Tapped(object? sender, TappedEventArgs e)
    {
        if (sender != null)
        {
            await game.RevealTile(lstpictures.IndexOf((Image)sender));
        }
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        game.StartGame();

    }
}