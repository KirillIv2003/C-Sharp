namespace CarPlayWfa
{
    partial class Form2
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
            tbEnemy = new TextBox();
            tbPlayer = new TextBox();
            buRestart = new Button();
            buPlay = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // tbEnemy
            // 
            tbEnemy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            tbEnemy.Location = new Point(244, 30);
            tbEnemy.Name = "tbEnemy";
            tbEnemy.Size = new Size(82, 31);
            tbEnemy.TabIndex = 0;
            tbEnemy.TextChanged += tbEnemy_TextChanged;
            // 
            // tbPlayer
            // 
            tbPlayer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            tbPlayer.Location = new Point(244, 87);
            tbPlayer.Name = "tbPlayer";
            tbPlayer.Size = new Size(82, 31);
            tbPlayer.TabIndex = 1;
            tbPlayer.TextChanged += tbPlayer_TextChanged;
            // 
            // buRestart
            // 
            buRestart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buRestart.BackColor = Color.Red;
            buRestart.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buRestart.Location = new Point(12, 181);
            buRestart.Name = "buRestart";
            buRestart.Size = new Size(130, 49);
            buRestart.TabIndex = 3;
            buRestart.Text = "Заново";
            buRestart.UseVisualStyleBackColor = false;
            buRestart.Click += buRestart_Click;
            // 
            // buPlay
            // 
            buPlay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buPlay.BackColor = Color.Lime;
            buPlay.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buPlay.ForeColor = SystemColors.ActiveCaptionText;
            buPlay.Location = new Point(161, 181);
            buPlay.Name = "buPlay";
            buPlay.Size = new Size(165, 49);
            buPlay.TabIndex = 4;
            buPlay.Text = "Продолжить";
            buPlay.UseVisualStyleBackColor = false;
            buPlay.Click += buPlay_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 30);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 5;
            label1.Text = "Скорость врагов";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 87);
            label2.Name = "label2";
            label2.Size = new Size(151, 25);
            label2.TabIndex = 6;
            label2.Text = "Скорость игрока";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(338, 255);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buPlay);
            Controls.Add(buRestart);
            Controls.Add(tbPlayer);
            Controls.Add(tbEnemy);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form2";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbEnemy;
        private TextBox tbPlayer;
        private Button buRestart;
        private Button buPlay;
        private Label label1;
        private Label label2;
    }
}