namespace wfaFormSDI
{
    partial class FmMain
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
            buAbout = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            buAbout.Location = new Point(35, 37);
            buAbout.Name = "button1";
            buAbout.Size = new Size(112, 34);
            buAbout.TabIndex = 0;
            buAbout.Text = "button1";
            buAbout.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(35, 109);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(35, 186);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 328);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(buAbout);
            Name = "Form1";
            Text = "wfaFormSDI";
            ResumeLayout(false);
        }

        #endregion

        private Button buAbout;
        private Button button2;
        private Button button3;
    }
}