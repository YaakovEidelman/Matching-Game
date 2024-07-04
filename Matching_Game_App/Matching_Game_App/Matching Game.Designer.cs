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
            tlpGameBoard = new TableLayoutPanel();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn10 = new Button();
            btn11 = new Button();
            btn12 = new Button();
            btn13 = new Button();
            btn14 = new Button();
            btn15 = new Button();
            btn16 = new Button();
            btn17 = new Button();
            btn18 = new Button();
            btn19 = new Button();
            btn20 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tlpMain.SuspendLayout();
            tlpStats.SuspendLayout();
            tlpGameBoard.SuspendLayout();
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
            tlpStats.Controls.Add(label1, 2, 0);
            tlpStats.Controls.Add(label2, 2, 1);
            tlpStats.Controls.Add(label3, 3, 0);
            tlpStats.Controls.Add(label4, 3, 1);
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
            // tlpGameBoard
            // 
            tlpGameBoard.ColumnCount = 5;
            tlpGameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpGameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpGameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpGameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpGameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpGameBoard.Controls.Add(btn1, 0, 0);
            tlpGameBoard.Controls.Add(btn2, 1, 0);
            tlpGameBoard.Controls.Add(btn3, 2, 0);
            tlpGameBoard.Controls.Add(btn4, 3, 0);
            tlpGameBoard.Controls.Add(btn5, 4, 0);
            tlpGameBoard.Controls.Add(btn6, 0, 1);
            tlpGameBoard.Controls.Add(btn7, 1, 1);
            tlpGameBoard.Controls.Add(btn8, 2, 1);
            tlpGameBoard.Controls.Add(btn9, 3, 1);
            tlpGameBoard.Controls.Add(btn10, 4, 1);
            tlpGameBoard.Controls.Add(btn11, 0, 2);
            tlpGameBoard.Controls.Add(btn12, 1, 2);
            tlpGameBoard.Controls.Add(btn13, 2, 2);
            tlpGameBoard.Controls.Add(btn14, 3, 2);
            tlpGameBoard.Controls.Add(btn15, 4, 2);
            tlpGameBoard.Controls.Add(btn16, 0, 3);
            tlpGameBoard.Controls.Add(btn17, 0, 3);
            tlpGameBoard.Controls.Add(btn18, 1, 3);
            tlpGameBoard.Controls.Add(btn19, 2, 3);
            tlpGameBoard.Controls.Add(btn20, 3, 3);
            tlpGameBoard.Dock = DockStyle.Fill;
            tlpGameBoard.Location = new Point(3, 171);
            tlpGameBoard.Name = "tlpGameBoard";
            tlpGameBoard.RowCount = 4;
            tlpGameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpGameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpGameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpGameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpGameBoard.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpGameBoard.Size = new Size(1476, 669);
            tlpGameBoard.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Lime;
            btn1.Dock = DockStyle.Fill;
            btn1.Location = new Point(3, 3);
            btn1.Name = "btn1";
            btn1.Size = new Size(289, 161);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Lime;
            btn2.Dock = DockStyle.Fill;
            btn2.Location = new Point(298, 3);
            btn2.Name = "btn2";
            btn2.Size = new Size(289, 161);
            btn2.TabIndex = 1;
            btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Lime;
            btn3.Dock = DockStyle.Fill;
            btn3.Location = new Point(593, 3);
            btn3.Name = "btn3";
            btn3.Size = new Size(289, 161);
            btn3.TabIndex = 2;
            btn3.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Lime;
            btn4.Dock = DockStyle.Fill;
            btn4.Location = new Point(888, 3);
            btn4.Name = "btn4";
            btn4.Size = new Size(289, 161);
            btn4.TabIndex = 3;
            btn4.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Lime;
            btn5.Dock = DockStyle.Fill;
            btn5.Location = new Point(1183, 3);
            btn5.Name = "btn5";
            btn5.Size = new Size(290, 161);
            btn5.TabIndex = 4;
            btn5.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Lime;
            btn6.Dock = DockStyle.Fill;
            btn6.Location = new Point(3, 170);
            btn6.Name = "btn6";
            btn6.Size = new Size(289, 161);
            btn6.TabIndex = 5;
            btn6.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            btn7.BackColor = Color.Lime;
            btn7.Dock = DockStyle.Fill;
            btn7.Location = new Point(298, 170);
            btn7.Name = "btn7";
            btn7.Size = new Size(289, 161);
            btn7.TabIndex = 6;
            btn7.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            btn8.BackColor = Color.Lime;
            btn8.Dock = DockStyle.Fill;
            btn8.Location = new Point(593, 170);
            btn8.Name = "btn8";
            btn8.Size = new Size(289, 161);
            btn8.TabIndex = 7;
            btn8.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            btn9.BackColor = Color.Lime;
            btn9.Dock = DockStyle.Fill;
            btn9.Location = new Point(888, 170);
            btn9.Name = "btn9";
            btn9.Size = new Size(289, 161);
            btn9.TabIndex = 8;
            btn9.UseVisualStyleBackColor = false;
            // 
            // btn10
            // 
            btn10.BackColor = Color.Lime;
            btn10.Dock = DockStyle.Fill;
            btn10.Location = new Point(1183, 170);
            btn10.Name = "btn10";
            btn10.Size = new Size(290, 161);
            btn10.TabIndex = 9;
            btn10.UseVisualStyleBackColor = false;
            // 
            // btn11
            // 
            btn11.BackColor = Color.Lime;
            btn11.Dock = DockStyle.Fill;
            btn11.Location = new Point(3, 337);
            btn11.Name = "btn11";
            btn11.Size = new Size(289, 161);
            btn11.TabIndex = 10;
            btn11.UseVisualStyleBackColor = false;
            // 
            // btn12
            // 
            btn12.BackColor = Color.Lime;
            btn12.Dock = DockStyle.Fill;
            btn12.Location = new Point(298, 337);
            btn12.Name = "btn12";
            btn12.Size = new Size(289, 161);
            btn12.TabIndex = 11;
            btn12.UseVisualStyleBackColor = false;
            // 
            // btn13
            // 
            btn13.BackColor = Color.Lime;
            btn13.Dock = DockStyle.Fill;
            btn13.Location = new Point(593, 337);
            btn13.Name = "btn13";
            btn13.Size = new Size(289, 161);
            btn13.TabIndex = 12;
            btn13.UseVisualStyleBackColor = false;
            // 
            // btn14
            // 
            btn14.BackColor = Color.Lime;
            btn14.Dock = DockStyle.Fill;
            btn14.Location = new Point(888, 337);
            btn14.Name = "btn14";
            btn14.Size = new Size(289, 161);
            btn14.TabIndex = 13;
            btn14.UseVisualStyleBackColor = false;
            // 
            // btn15
            // 
            btn15.BackColor = Color.Lime;
            btn15.Dock = DockStyle.Fill;
            btn15.Location = new Point(1183, 337);
            btn15.Name = "btn15";
            btn15.Size = new Size(290, 161);
            btn15.TabIndex = 14;
            btn15.UseVisualStyleBackColor = false;
            // 
            // btn16
            // 
            btn16.BackColor = Color.Lime;
            btn16.Dock = DockStyle.Fill;
            btn16.Location = new Point(298, 504);
            btn16.Name = "btn16";
            btn16.Size = new Size(289, 162);
            btn16.TabIndex = 16;
            btn16.UseVisualStyleBackColor = false;
            // 
            // btn17
            // 
            btn17.BackColor = Color.Lime;
            btn17.Dock = DockStyle.Fill;
            btn17.Location = new Point(3, 504);
            btn17.Name = "btn17";
            btn17.Size = new Size(289, 162);
            btn17.TabIndex = 15;
            btn17.UseVisualStyleBackColor = false;
            // 
            // btn18
            // 
            btn18.BackColor = Color.Lime;
            btn18.Dock = DockStyle.Fill;
            btn18.Location = new Point(593, 504);
            btn18.Name = "btn18";
            btn18.Size = new Size(289, 162);
            btn18.TabIndex = 17;
            btn18.UseVisualStyleBackColor = false;
            // 
            // btn19
            // 
            btn19.BackColor = Color.Lime;
            btn19.Dock = DockStyle.Fill;
            btn19.Location = new Point(888, 504);
            btn19.Name = "btn19";
            btn19.Size = new Size(289, 162);
            btn19.TabIndex = 18;
            btn19.UseVisualStyleBackColor = false;
            // 
            // btn20
            // 
            btn20.BackColor = Color.Lime;
            btn20.Dock = DockStyle.Fill;
            btn20.Location = new Point(1183, 504);
            btn20.Name = "btn20";
            btn20.Size = new Size(290, 162);
            btn20.TabIndex = 19;
            btn20.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(741, 0);
            label1.Name = "label1";
            label1.Size = new Size(363, 81);
            label1.TabIndex = 3;
            label1.Text = "Player 1 Score:";
            label1.TextAlign = ContentAlignment.BottomRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(741, 81);
            label2.Name = "label2";
            label2.Size = new Size(363, 81);
            label2.TabIndex = 4;
            label2.Text = "Player 2 Score:";
            label2.TextAlign = ContentAlignment.BottomRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1110, 0);
            label3.Name = "label3";
            label3.Size = new Size(363, 81);
            label3.TabIndex = 5;
            label3.Text = "0";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1110, 81);
            label4.Name = "label4";
            label4.Size = new Size(363, 81);
            label4.TabIndex = 6;
            label4.Text = "0";
            label4.TextAlign = ContentAlignment.BottomLeft;
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
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private TableLayoutPanel tlpGameBoard;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn15;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn11;
        private Button btn12;
        private Button btn13;
        private Button btn14;
        private Button btn17;
        private Button btn18;
        private Button btn19;
        private Button btn20;
        private Button btn16;
        private Button btn4;
        private Button btn5;
        private Button btn10;
        private TableLayoutPanel tlpStats;
        private Button btnStart;
        private Label lblStatus;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}