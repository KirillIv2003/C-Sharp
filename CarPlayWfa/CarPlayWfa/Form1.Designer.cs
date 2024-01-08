namespace CarPlayWfa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pbRoad = new PictureBox();
            pbPlayer = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            pbRoad2 = new PictureBox();
            pbEnemy1 = new PictureBox();
            pbEnemy2 = new PictureBox();
            lLose = new Label();
            bnRestart = new Button();
            lScore = new Label();
            pbCoin = new PictureBox();
            lCoins = new Label();
            ((System.ComponentModel.ISupportInitialize)pbRoad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRoad2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEnemy1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEnemy2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCoin).BeginInit();
            SuspendLayout();
            // 
            // pbRoad
            // 
            pbRoad.BackgroundImage = (Image)resources.GetObject("pbRoad.BackgroundImage");
            pbRoad.BackgroundImageLayout = ImageLayout.Stretch;
            pbRoad.Location = new Point(0, 0);
            pbRoad.Name = "pbRoad";
            pbRoad.Size = new Size(840, 650);
            pbRoad.TabIndex = 0;
            pbRoad.TabStop = false;
            // 
            // pbPlayer
            // 
            pbPlayer.BackColor = Color.Transparent;
            pbPlayer.Image = (Image)resources.GetObject("pbPlayer.Image");
            pbPlayer.Location = new Point(458, 414);
            pbPlayer.Name = "pbPlayer";
            pbPlayer.Size = new Size(132, 211);
            pbPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPlayer.TabIndex = 1;
            pbPlayer.TabStop = false;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 15;
            timer.Tick += timer_Tick;
            // 
            // pbRoad2
            // 
            pbRoad2.BackgroundImage = (Image)resources.GetObject("pbRoad2.BackgroundImage");
            pbRoad2.BackgroundImageLayout = ImageLayout.Stretch;
            pbRoad2.Location = new Point(0, -650);
            pbRoad2.Name = "pbRoad2";
            pbRoad2.Size = new Size(840, 650);
            pbRoad2.TabIndex = 2;
            pbRoad2.TabStop = false;
            // 
            // pbEnemy1
            // 
            pbEnemy1.Image = (Image)resources.GetObject("pbEnemy1.Image");
            pbEnemy1.Location = new Point(42, -230);
            pbEnemy1.Name = "pbEnemy1";
            pbEnemy1.Size = new Size(133, 167);
            pbEnemy1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEnemy1.TabIndex = 3;
            pbEnemy1.TabStop = false;
            // 
            // pbEnemy2
            // 
            pbEnemy2.Image = (Image)resources.GetObject("pbEnemy2.Image");
            pbEnemy2.Location = new Point(673, -450);
            pbEnemy2.Name = "pbEnemy2";
            pbEnemy2.Size = new Size(133, 167);
            pbEnemy2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEnemy2.TabIndex = 4;
            pbEnemy2.TabStop = false;
            // 
            // lLose
            // 
            lLose.AutoSize = true;
            lLose.BackColor = Color.Red;
            lLose.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            lLose.ForeColor = Color.White;
            lLose.Location = new Point(229, 183);
            lLose.Name = "lLose";
            lLose.Size = new Size(392, 70);
            lLose.TabIndex = 5;
            lLose.Text = "Вы проиграли";
            // 
            // bnRestart
            // 
            bnRestart.BackColor = Color.Red;
            bnRestart.FlatStyle = FlatStyle.Popup;
            bnRestart.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            bnRestart.ForeColor = Color.White;
            bnRestart.Location = new Point(317, 272);
            bnRestart.Name = "bnRestart";
            bnRestart.Size = new Size(208, 68);
            bnRestart.TabIndex = 6;
            bnRestart.Text = "Заново";
            bnRestart.UseVisualStyleBackColor = false;
            bnRestart.Click += bnRestart_Click;
            // 
            // lScore
            // 
            lScore.AutoSize = true;
            lScore.BackColor = Color.Transparent;
            lScore.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lScore.ForeColor = Color.White;
            lScore.Location = new Point(22, 34);
            lScore.Name = "lScore";
            lScore.Size = new Size(89, 76);
            lScore.TabIndex = 7;
            lScore.Text = "Score\r\n0";
            // 
            // pbCoin
            // 
            pbCoin.BackColor = Color.Transparent;
            pbCoin.Image = (Image)resources.GetObject("pbCoin.Image");
            pbCoin.Location = new Point(256, -600);
            pbCoin.Name = "pbCoin";
            pbCoin.Size = new Size(50, 50);
            pbCoin.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCoin.TabIndex = 8;
            pbCoin.TabStop = false;
            // 
            // lCoins
            // 
            lCoins.AutoSize = true;
            lCoins.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lCoins.ForeColor = Color.White;
            lCoins.Location = new Point(741, 34);
            lCoins.Name = "lCoins";
            lCoins.Size = new Size(76, 76);
            lCoins.TabIndex = 9;
            lCoins.Text = "Coin\r\n0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(840, 650);
            Controls.Add(lCoins);
            Controls.Add(pbCoin);
            Controls.Add(lScore);
            Controls.Add(bnRestart);
            Controls.Add(lLose);
            Controls.Add(pbEnemy2);
            Controls.Add(pbEnemy1);
            Controls.Add(pbPlayer);
            Controls.Add(pbRoad);
            Controls.Add(pbRoad2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)pbRoad).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRoad2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEnemy1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEnemy2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCoin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbPlayer;
        private System.Windows.Forms.Timer timer;
        private PictureBox pbRoad2;
        public PictureBox pbRoad;
        private PictureBox pbEnemy1;
        private PictureBox pbEnemy2;
        private Label lLose;
        private Button bnRestart;
        private Label lScore;
        private PictureBox pbCoin;
        private Label lCoins;
    }
}