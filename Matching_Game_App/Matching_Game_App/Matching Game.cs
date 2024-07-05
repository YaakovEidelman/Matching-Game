using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matching_Game_App
{
    public partial class Matching_Game : Form
    {
        string path = Application.StartupPath + @"\";

        bool playeroneturn = true;
        int p1score = 0;
        int p2score = 0;

        int numofclicks = 0;

        bool gamestarted = false;

        List<PictureBox> lstpictures;
        List<string> lstpicposition = new();

        public Matching_Game()
        {
            InitializeComponent();
            btnStart.Click += BtnStart_Click;

            lstpictures = new() { pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8, pic9, pic10, pic11, pic12, pic13, pic14, pic15, pic16, pic17, pic18, pic19, pic20 };
            lstpictures.ForEach(p =>
            {
                p.Click += Card_Click;
                lstpictures.ForEach(pic => pic.ImageLocation = path + @"\images\background.jpeg");
            });
        }

        private void StartTasks()
        {
            gamestarted = true;
            playeroneturn = true;
            SetScore(true);
            lstpicposition.Clear();
            numofclicks = 0;
            PlaceImagesOnCards();
            SetStatus();
        }
        private void PlaceImagesOnCards()
        {
            List<string> templstshapes = new()
            {
                path + @"\images\bassclef.jpeg",
                path + @"\images\bumblebee.jpeg",
                path + @"\images\candy.jpeg",
                path + @"\images\card.jpeg",
                path + @"\images\chair.jpeg",
                path + @"\images\dice.jpeg",
                path + @"\images\lamp.jpeg",
                path + @"\images\pen.jpeg",
                path + @"\images\squares.jpeg",
                path + @"\images\trebleclef.jpeg",
                path + @"\images\bassclef.jpeg",
                path + @"\images\bumblebee.jpeg",
                path + @"\images\candy.jpeg",
                path + @"\images\card.jpeg",
                path + @"\images\chair.jpeg",
                path + @"\images\dice.jpeg",
                path + @"\images\lamp.jpeg",
                path + @"\images\pen.jpeg",
                path + @"\images\squares.jpeg",
                path + @"\images\trebleclef.jpeg"
            };

            Random r = new();
            string selectedval = templstshapes[r.Next(0, templstshapes.Count)];

            lstpictures.ForEach(p =>
            {
                templstshapes.Remove(selectedval);
                lstpicposition.Add(selectedval);

                if (templstshapes.Count() > 0)
                {
                    selectedval = templstshapes[r.Next(0, templstshapes.Count)];
                }

                p.ImageLocation = path + @"\images\background.jpeg";
                p.Enabled = true;
                p.Tag = "notfound";
            });
        }
        private async void ShowCard(PictureBox p)
        {
            if (gamestarted == true)
            {
                int selectedcard = lstpictures.IndexOf(p);
                p.ImageLocation = lstpicposition[selectedcard];
                p.Enabled = false;
                numofclicks++;
                if (numofclicks >= 2)
                {
                    lstpictures.ForEach(pic => pic.Enabled = false);
                    if (lstpictures.Count(pic => pic.ImageLocation == p.ImageLocation) == 2)
                    {
                        lstpictures.Where(pic => pic.ImageLocation == p.ImageLocation).ToList().ForEach(pic => pic.Tag = "found");
                        lstpictures.ForEach(pic => pic.Enabled = true);
                        numofclicks = 0;
                        SetScore(false);
                        SetStatus("You found a Match, go again!!!");
                    }
                    else
                    {
                        SetStatus("Nice try, try again next turn");
                        await Task.Delay(3000);
                        HideCards();
                        numofclicks = 0;
                        playeroneturn = !playeroneturn;
                        SetStatus();
                    }
                }
            }
        }

        private void HideCards()
        {
            lstpictures.Where(pic => (string)pic.Tag != "found")
                .ToList()
                .ForEach(pic =>
                    {
                        pic.ImageLocation = path + @"\images\background.jpeg";
                        pic.Enabled = true;
                    });
        }

        private void SetStatus(string msg = "")
        {
            if(CheckForEndOfGame())
            {
                lblStatus.Text = (p1score > p2score) ? "Player 1 Wins" : (p1score < p2score) ? "Player 2 Wins" : "Tie Game";
            }
            else if(playeroneturn)
            {
                lblStatus.Text = "Player 1 Turn: " + msg;
            }
            else
            {
                lblStatus.Text = "Player 2 Turn: " + msg;
            }
        }
        private void SetScore(bool beginningofgame)
        {
            if(beginningofgame)
            {
                p1score = 0;
                p2score = 0;
            }
            else if (playeroneturn)
            {
                p1score++;
            }
            else
            {
                p2score++;
            }
            lblPlayerOneScore.Text = p1score.ToString();
            lblPlayerTwoScore.Text = p2score.ToString();
        }
        private bool CheckForEndOfGame()
        {
            if(lstpictures.Count(pic => (string)pic.Tag == "found") == lstpictures.Count())
            {
                return true;
            }
            return false;
        }



        private void BtnStart_Click(object? sender, EventArgs e)
        {
            StartTasks();
        }

        private void Card_Click(object? sender, EventArgs e)
        {
            if (sender != null)
            {
                ShowCard((PictureBox)sender);
            }
        }

        //End of class
    }
}