namespace BackgroundRemovalApp
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
            pictureBox1 = new PictureBox();
            buOpen = new Button();
            buRun = new Button();
            buSave = new Button();
            listBox1 = new ListBox();
            colorDialog1 = new ColorDialog();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Location = new Point(521, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(435, 515);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            buOpen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            buOpen.Location = new Point(10, 491);
            buOpen.Name = "button1";
            buOpen.Size = new Size(112, 34);
            buOpen.TabIndex = 1;
            buOpen.Text = "Открыть";
            buOpen.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            buRun.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            buRun.Location = new Point(128, 491);
            buRun.Name = "button2";
            buRun.Size = new Size(134, 34);
            buRun.TabIndex = 2;
            buRun.Text = "Обработать";
            buRun.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            buSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            buSave.Location = new Point(268, 491);
            buSave.Name = "button3";
            buSave.Size = new Size(112, 34);
            buSave.TabIndex = 3;
            buSave.Text = "Сохранить";
            buSave.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] { "Убрать фон", "Оставить фон", "Обводка обычная", "Обводка пунктиром" });
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(205, 129);
            listBox1.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 539);
            Controls.Add(listBox1);
            Controls.Add(buSave);
            Controls.Add(buRun);
            Controls.Add(buOpen);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buOpen;
        private Button buRun;
        private Button buSave;
        private ListBox listBox1;
        private ColorDialog colorDialog1;
        private OpenFileDialog openFileDialog1;
    }
}