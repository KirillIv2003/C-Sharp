namespace wfaGameTrainerAccount
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
            tableLayoutPanel1 = new TableLayoutPanel();
            laWrong = new Label();
            laCorrect = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            buNo = new Button();
            buYes = new Button();
            buPr = new Button();
            buStart = new Button();
            laCode = new Label();
            label4 = new Label();
            laTimer = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(laWrong, 1, 0);
            tableLayoutPanel1.Controls.Add(laCorrect, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(764, 150);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // laWrong
            // 
            laWrong.AutoSize = true;
            laWrong.BackColor = Color.FromArgb(255, 192, 192);
            laWrong.Dock = DockStyle.Fill;
            laWrong.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            laWrong.Location = new Point(385, 0);
            laWrong.Name = "laWrong";
            laWrong.Size = new Size(376, 150);
            laWrong.TabIndex = 1;
            laWrong.Text = "Неверно = 0 ";
            laWrong.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // laCorrect
            // 
            laCorrect.AutoSize = true;
            laCorrect.BackColor = Color.FromArgb(192, 255, 192);
            laCorrect.Dock = DockStyle.Fill;
            laCorrect.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            laCorrect.Location = new Point(3, 0);
            laCorrect.Name = "laCorrect";
            laCorrect.Size = new Size(376, 150);
            laCorrect.TabIndex = 0;
            laCorrect.Text = "Верно = 0 ";
            laCorrect.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(buNo, 1, 0);
            tableLayoutPanel2.Controls.Add(buYes, 0, 0);
            tableLayoutPanel2.Controls.Add(buPr, 0, 1);
            tableLayoutPanel2.Controls.Add(buStart, 1, 1);
            tableLayoutPanel2.Location = new Point(12, 470);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(764, 141);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // buNo
            // 
            buNo.Dock = DockStyle.Fill;
            buNo.Font = new Font("Segoe Script", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buNo.ForeColor = Color.Maroon;
            buNo.Location = new Point(385, 3);
            buNo.Name = "buNo";
            buNo.Size = new Size(376, 64);
            buNo.TabIndex = 1;
            buNo.Text = "Нет";
            buNo.UseVisualStyleBackColor = true;
            // 
            // buYes
            // 
            buYes.Dock = DockStyle.Fill;
            buYes.Font = new Font("Segoe Script", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buYes.ForeColor = Color.FromArgb(0, 192, 0);
            buYes.Location = new Point(3, 3);
            buYes.Name = "buYes";
            buYes.Size = new Size(376, 64);
            buYes.TabIndex = 0;
            buYes.Text = "Да";
            buYes.UseVisualStyleBackColor = true;
            // 
            // buPr
            // 
            buPr.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buPr.Font = new Font("ScriptS_IV50", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buPr.ForeColor = Color.FromArgb(192, 0, 192);
            buPr.Location = new Point(3, 73);
            buPr.Name = "buPr";
            buPr.Size = new Size(376, 65);
            buPr.TabIndex = 2;
            buPr.Text = "Пропустить";
            buPr.UseVisualStyleBackColor = true;
            // 
            // buStart
            // 
            buStart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buStart.Font = new Font("ScriptS_IV50", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buStart.ForeColor = Color.FromArgb(0, 0, 192);
            buStart.Location = new Point(385, 73);
            buStart.Name = "buStart";
            buStart.Size = new Size(376, 65);
            buStart.TabIndex = 3;
            buStart.Text = "Начать сначла";
            buStart.UseVisualStyleBackColor = true;
            // 
            // laCode
            // 
            laCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            laCode.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            laCode.Location = new Point(12, 165);
            laCode.Name = "laCode";
            laCode.Size = new Size(764, 190);
            laCode.TabIndex = 2;
            laCode.Text = "10 + 12 = 22";
            laCode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 400);
            label4.Name = "label4";
            label4.Size = new Size(761, 70);
            label4.TabIndex = 3;
            label4.Text = "Верно?";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // laTimer
            // 
            laTimer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            laTimer.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            laTimer.Location = new Point(12, 334);
            laTimer.Name = "laTimer";
            laTimer.Size = new Size(764, 66);
            laTimer.TabIndex = 4;
            laTimer.Text = "00:00.000";
            laTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 628);
            Controls.Add(laTimer);
            Controls.Add(label4);
            Controls.Add(laCode);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(498, 434);
            Name = "Form1";
            Text = "wfaGameTrainerAccount";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label laCorrect;
        private Label laWrong;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buYes;
        private Button buNo;
        private Label laCode;
        private Label label4;
        private Button buPr;
        private Button buStart;
        private Label laTimer;
    }
}