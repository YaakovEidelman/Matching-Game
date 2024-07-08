namespace Matching_Game_App
{
    partial class Matching_Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tlpMain = new TableLayoutPanel();
            tlpStats = new TableLayoutPanel();
            btnStart = new Button();
            lblStatus = new Label();
            lblPlayer1 = new Label();
            lblPlayer2 = new Label();
            lblPlayerOneScore = new Label();
            lblPlayerTwoScore = new Label();
            tlpGameBoard = new TableLayoutPanel();
            pic1 = new PictureBox();
            pic2 = new PictureBox();
            pic3 = new PictureBox();
            pic4 = new PictureBox();
            pic5 = new PictureBox();
            pic6 = new PictureBox();
            pic7 = new PictureBox();
            pic8 = new PictureBox();
            pic9 = new PictureBox();
            pic10 = new PictureBox();
            pic11 = new PictureBox();
            pic12 = new PictureBox();
            pic13 = new PictureBox();
            pic14 = new PictureBox();
            pic15 = new PictureBox();
            pic16 = new PictureBox();
            pic17 = new PictureBox();
            pic18 = new PictureBox();
            pic19 = new PictureBox();
            pic20 = new PictureBox();
            tlpMain.SuspendLayout();
            tlpStats.SuspendLayout();
            tlpGameBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic17).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic18).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic19).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic20).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpMain.Controls.Add(tlpStats, 0, 0);
            tlpMain.Controls.Add(tlpGameBoard, 0, 1);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 2;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMain.Size = new Size(1482, 843);
            tlpMain.TabIndex = 0;
            // 
            // tlpStats
            // 
            tlpStats.ColumnCount = 4;
            tlpStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpStats.Controls.Add(btnStart, 0, 0);
            tlpStats.Controls.Add(lblStatus, 0, 1);
            tlpStats.Controls.Add(lblPlayer1, 2, 0);
            tlpStats.Controls.Add(lblPlayer2, 2, 1);
            tlpStats.Controls.Add(lblPlayerOneScore, 3, 0);
            tlpStats.Controls.Add(lblPlayerTwoScore, 3, 1);
            tlpStats.Dock = DockStyle.Fill;
            tlpStats.Location = new Point(3, 3);
            tlpStats.Name = "tlpStats";
            tlpStats.RowCount = 2;
            tlpStats.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpStats.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpStats.Size = new Size(1476, 162);
            tlpStats.TabIndex = 0;
            // 
            // btnStart
            // 
            tlpStats.SetColumnSpan(btnStart, 2);
            btnStart.Dock = DockStyle.Fill;
            btnStart.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.Location = new Point(3, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(732, 75);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            tlpStats.SetColumnSpan(lblStatus, 2);
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.Location = new Point(3, 81);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(732, 81);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Click Start to Play";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPlayer1
            // 
            lblPlayer1.AutoSize = true;
            lblPlayer1.Dock = DockStyle.Fill;
            lblPlayer1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayer1.Location = new Point(741, 0);
            lblPlayer1.Name = "lblPlayer1";
            lblPlayer1.Size = new Size(363, 81);
            lblPlayer1.TabIndex = 3;
            lblPlayer1.Text = "Player 1 Score:";
            lblPlayer1.TextAlign = ContentAlignment.BottomRight;
            // 
            // lblPlayer2
            // 
            lblPlayer2.AutoSize = true;
            lblPlayer2.Dock = DockStyle.Fill;
            lblPlayer2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayer2.Location = new Point(741, 81);
            lblPlayer2.Name = "lblPlayer2";
            lblPlayer2.Size = new Size(363, 81);
            lblPlayer2.TabIndex = 4;
            lblPlayer2.Text = "Player 2 Score:";
            lblPlayer2.TextAlign = ContentAlignment.BottomRight;
            // 
            // lblPlayerOneScore
            // 
            lblPlayerOneScore.AutoSize = true;
            lblPlayerOneScore.Dock = DockStyle.Fill;
            lblPlayerOneScore.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayerOneScore.Location = new Point(1110, 0);
            lblPlayerOneScore.Name = "lblPlayerOneScore";
            lblPlayerOneScore.Size = new Size(363, 81);
            lblPlayerOneScore.TabIndex = 5;
            lblPlayerOneScore.Text = "0";
            lblPlayerOneScore.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblPlayerTwoScore
            // 
            lblPlayerTwoScore.AutoSize = true;
            lblPlayerTwoScore.Dock = DockStyle.Fill;
            lblPlayerTwoScore.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayerTwoScore.Location = new Point(1110, 81);
            lblPlayerTwoScore.Name = "lblPlayerTwoScore";
            lblPlayerTwoScore.Size = new Size(363, 81);
            lblPlayerTwoScore.TabIndex = 6;
            lblPlayerTwoScore.Text = "0";
            lblPlayerTwoScore.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tlpGameBoard
            // 
            tlpGameBoard.ColumnCount = 5;
            tlpGameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpGameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpGameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpGameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpGameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpGameBoard.Controls.Add(pic1, 0, 0);
            tlpGameBoard.Controls.Add(pic2, 1, 0);
            tlpGameBoard.Controls.Add(pic3, 2, 0);
            tlpGameBoard.Controls.Add(pic4, 3, 0);
            tlpGameBoard.Controls.Add(pic5, 4, 0);
            tlpGameBoard.Controls.Add(pic6, 0, 1);
            tlpGameBoard.Controls.Add(pic7, 1, 1);
            tlpGameBoard.Controls.Add(pic8, 2, 1);
            tlpGameBoard.Controls.Add(pic9, 3, 1);
            tlpGameBoard.Controls.Add(pic10, 4, 1);
            tlpGameBoard.Controls.Add(pic11, 0, 2);
            tlpGameBoard.Controls.Add(pic12, 1, 2);
            tlpGameBoard.Controls.Add(pic13, 2, 2);
            tlpGameBoard.Controls.Add(pic14, 3, 2);
            tlpGameBoard.Controls.Add(pic15, 4, 2);
            tlpGameBoard.Controls.Add(pic16, 0, 3);
            tlpGameBoard.Controls.Add(pic17, 1, 3);
            tlpGameBoard.Controls.Add(pic18, 2, 3);
            tlpGameBoard.Controls.Add(pic19, 3, 3);
            tlpGameBoard.Controls.Add(pic20, 4, 3);
            tlpGameBoard.Dock = DockStyle.Fill;
            tlpGameBoard.Location = new Point(3, 171);
            tlpGameBoard.Name = "tlpGameBoard";
            tlpGameBoard.RowCount = 4;
            tlpGameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpGameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpGameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpGameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpGameBoard.Size = new Size(1476, 669);
            tlpGameBoard.TabIndex = 0;
            // 
            // pic1
            // 
            pic1.BackColor = Color.FromArgb(192, 255, 192);
            pic1.Dock = DockStyle.Fill;
            pic1.Location = new Point(3, 3);
            pic1.Name = "pic1";
            pic1.Size = new Size(289, 161);
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1.TabIndex = 20;
            pic1.TabStop = false;
            // 
            // pic2
            // 
            pic2.BackColor = Color.FromArgb(192, 255, 192);
            pic2.Dock = DockStyle.Fill;
            pic2.Location = new Point(298, 3);
            pic2.Name = "pic2";
            pic2.Size = new Size(289, 161);
            pic2.SizeMode = PictureBoxSizeMode.StretchImage;
            pic2.TabIndex = 21;
            pic2.TabStop = false;
            // 
            // pic3
            // 
            pic3.BackColor = Color.FromArgb(192, 255, 192);
            pic3.Dock = DockStyle.Fill;
            pic3.Location = new Point(593, 3);
            pic3.Name = "pic3";
            pic3.Size = new Size(289, 161);
            pic3.SizeMode = PictureBoxSizeMode.StretchImage;
            pic3.TabIndex = 0;
            pic3.TabStop = false;
            // 
            // pic4
            // 
            pic4.BackColor = Color.FromArgb(192, 255, 192);
            pic4.Dock = DockStyle.Fill;
            pic4.Location = new Point(888, 3);
            pic4.Name = "pic4";
            pic4.Size = new Size(289, 161);
            pic4.SizeMode = PictureBoxSizeMode.StretchImage;
            pic4.TabIndex = 22;
            pic4.TabStop = false;
            // 
            // pic5
            // 
            pic5.BackColor = Color.FromArgb(192, 255, 192);
            pic5.Dock = DockStyle.Fill;
            pic5.Location = new Point(1183, 3);
            pic5.Name = "pic5";
            pic5.Size = new Size(290, 161);
            pic5.SizeMode = PictureBoxSizeMode.StretchImage;
            pic5.TabIndex = 23;
            pic5.TabStop = false;
            // 
            // pic6
            // 
            pic6.BackColor = Color.FromArgb(192, 255, 192);
            pic6.Dock = DockStyle.Fill;
            pic6.Location = new Point(3, 170);
            pic6.Name = "pic6";
            pic6.Size = new Size(289, 161);
            pic6.SizeMode = PictureBoxSizeMode.StretchImage;
            pic6.TabIndex = 24;
            pic6.TabStop = false;
            // 
            // pic7
            // 
            pic7.BackColor = Color.FromArgb(192, 255, 192);
            pic7.Dock = DockStyle.Fill;
            pic7.Location = new Point(298, 170);
            pic7.Name = "pic7";
            pic7.Size = new Size(289, 161);
            pic7.SizeMode = PictureBoxSizeMode.StretchImage;
            pic7.TabIndex = 25;
            pic7.TabStop = false;
            // 
            // pic8
            // 
            pic8.BackColor = Color.FromArgb(192, 255, 192);
            pic8.Dock = DockStyle.Fill;
            pic8.Location = new Point(593, 170);
            pic8.Name = "pic8";
            pic8.Size = new Size(289, 161);
            pic8.SizeMode = PictureBoxSizeMode.StretchImage;
            pic8.TabIndex = 26;
            pic8.TabStop = false;
            // 
            // pic9
            // 
            pic9.BackColor = Color.FromArgb(192, 255, 192);
            pic9.Dock = DockStyle.Fill;
            pic9.Location = new Point(888, 170);
            pic9.Name = "pic9";
            pic9.Size = new Size(289, 161);
            pic9.SizeMode = PictureBoxSizeMode.StretchImage;
            pic9.TabIndex = 27;
            pic9.TabStop = false;
            // 
            // pic10
            // 
            pic10.BackColor = Color.FromArgb(192, 255, 192);
            pic10.Dock = DockStyle.Fill;
            pic10.Location = new Point(1183, 170);
            pic10.Name = "pic10";
            pic10.Size = new Size(290, 161);
            pic10.SizeMode = PictureBoxSizeMode.StretchImage;
            pic10.TabIndex = 28;
            pic10.TabStop = false;
            // 
            // pic11
            // 
            pic11.BackColor = Color.FromArgb(192, 255, 192);
            pic11.Dock = DockStyle.Fill;
            pic11.Location = new Point(3, 337);
            pic11.Name = "pic11";
            pic11.Size = new Size(289, 161);
            pic11.SizeMode = PictureBoxSizeMode.StretchImage;
            pic11.TabIndex = 29;
            pic11.TabStop = false;
            // 
            // pic12
            // 
            pic12.BackColor = Color.FromArgb(192, 255, 192);
            pic12.Dock = DockStyle.Fill;
            pic12.Location = new Point(298, 337);
            pic12.Name = "pic12";
            pic12.Size = new Size(289, 161);
            pic12.SizeMode = PictureBoxSizeMode.StretchImage;
            pic12.TabIndex = 30;
            pic12.TabStop = false;
            // 
            // pic13
            // 
            pic13.BackColor = Color.FromArgb(192, 255, 192);
            pic13.Dock = DockStyle.Fill;
            pic13.Location = new Point(593, 337);
            pic13.Name = "pic13";
            pic13.Size = new Size(289, 161);
            pic13.SizeMode = PictureBoxSizeMode.StretchImage;
            pic13.TabIndex = 31;
            pic13.TabStop = false;
            // 
            // pic14
            // 
            pic14.BackColor = Color.FromArgb(192, 255, 192);
            pic14.Dock = DockStyle.Fill;
            pic14.Location = new Point(888, 337);
            pic14.Name = "pic14";
            pic14.Size = new Size(289, 161);
            pic14.SizeMode = PictureBoxSizeMode.StretchImage;
            pic14.TabIndex = 32;
            pic14.TabStop = false;
            // 
            // pic15
            // 
            pic15.BackColor = Color.FromArgb(192, 255, 192);
            pic15.Dock = DockStyle.Fill;
            pic15.Location = new Point(1183, 337);
            pic15.Name = "pic15";
            pic15.Size = new Size(290, 161);
            pic15.SizeMode = PictureBoxSizeMode.StretchImage;
            pic15.TabIndex = 33;
            pic15.TabStop = false;
            // 
            // pic16
            // 
            pic16.BackColor = Color.FromArgb(192, 255, 192);
            pic16.Dock = DockStyle.Fill;
            pic16.Location = new Point(3, 504);
            pic16.Name = "pic16";
            pic16.Size = new Size(289, 162);
            pic16.SizeMode = PictureBoxSizeMode.StretchImage;
            pic16.TabIndex = 34;
            pic16.TabStop = false;
            // 
            // pic17
            // 
            pic17.BackColor = Color.FromArgb(192, 255, 192);
            pic17.Dock = DockStyle.Fill;
            pic17.Location = new Point(298, 504);
            pic17.Name = "pic17";
            pic17.Size = new Size(289, 162);
            pic17.SizeMode = PictureBoxSizeMode.StretchImage;
            pic17.TabIndex = 35;
            pic17.TabStop = false;
            // 
            // pic18
            // 
            pic18.BackColor = Color.FromArgb(192, 255, 192);
            pic18.Dock = DockStyle.Fill;
            pic18.Location = new Point(593, 504);
            pic18.Name = "pic18";
            pic18.Size = new Size(289, 162);
            pic18.SizeMode = PictureBoxSizeMode.StretchImage;
            pic18.TabIndex = 36;
            pic18.TabStop = false;
            // 
            // pic19
            // 
            pic19.BackColor = Color.FromArgb(192, 255, 192);
            pic19.Dock = DockStyle.Fill;
            pic19.Location = new Point(888, 504);
            pic19.Name = "pic19";
            pic19.Size = new Size(289, 162);
            pic19.SizeMode = PictureBoxSizeMode.StretchImage;
            pic19.TabIndex = 37;
            pic19.TabStop = false;
            // 
            // pic20
            // 
            pic20.BackColor = Color.FromArgb(192, 255, 192);
            pic20.Dock = DockStyle.Fill;
            pic20.Location = new Point(1183, 504);
            pic20.Name = "pic20";
            pic20.Size = new Size(290, 162);
            pic20.SizeMode = PictureBoxSizeMode.StretchImage;
            pic20.TabIndex = 38;
            pic20.TabStop = false;
            // 
            // Matching_Game
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 843);
            Controls.Add(tlpMain);
            Name = "Matching_Game";
            Text = "Matching_Game";
            tlpMain.ResumeLayout(false);
            tlpStats.ResumeLayout(false);
            tlpStats.PerformLayout();
            tlpGameBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic17).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic18).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic19).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic20).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private TableLayoutPanel tlpGameBoard;
        private TableLayoutPanel tlpStats;
        private Button btnStart;
        private Label lblStatus;
        private Label lblPlayer1;
        private Label lblPlayer2;
        private Label lblPlayerOneScore;
        private Label lblPlayerTwoScore;
        private PictureBox pic1;
        private PictureBox pic2;
        private PictureBox pic3;
        private PictureBox pic4;
        private PictureBox pic5;
        private PictureBox pic6;
        private PictureBox pic7;
        private PictureBox pic8;
        private PictureBox pic9;
        private PictureBox pic10;
        private PictureBox pic11;
        private PictureBox pic12;
        private PictureBox pic13;
        private PictureBox pic14;
        private PictureBox pic15;
        private PictureBox pic16;
        private PictureBox pic17;
        private PictureBox pic18;
        private PictureBox pic19;
        private PictureBox pic20;
    }
}