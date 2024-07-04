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
        enum GameStatus { notplaying, playing, tie, win }
        GameStatus gamestate = GameStatus.notplaying;

        List<Button> lstbuttons;
        
        public Matching_Game()
        {
            InitializeComponent();
            lstbuttons = new() { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11, btn12, btn13, btn14, btn15, btn16, btn17, btn18, btn19, btn20 };

            lstbuttons.ForEach(b => b.Click += Card_Click);

            btnStart.Click += BtnStart_Click;
        }

        private void PlaceImagesOnCards()
        {
            List<string> lstshapes = new() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };

            Random r = new();
            string selectedval = lstshapes[r.Next(0, lstshapes.Count)];


            lstbuttons.ForEach(b =>
            {
                b.Text = selectedval;
                lstshapes.Remove(selectedval);
                if(lstshapes.Count() > 0)
                {
                    selectedval = lstshapes[r.Next(0, lstshapes.Count)];
                }
            });
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            gamestate = GameStatus.playing;
            PlaceImagesOnCards();
        }

        private void Card_Click(object? sender, EventArgs e)
        {
            if (sender != null)
            {
                var clickedButton = (Button)sender;
                if (gamestate == GameStatus.playing)
                {
                    lblStatus.Text = "Hi";
                }
            }
        }

        //End of class
    }
}
