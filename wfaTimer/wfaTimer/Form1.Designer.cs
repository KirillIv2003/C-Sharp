namespace wfaTimer
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
            buUp = new Button();
            buUpPause = new Button();
            pbUp = new ProgressBar();
            pbUpMs = new ProgressBar();
            SuspendLayout();
            // 
            // buUp
            // 
            buUp.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buUp.Location = new Point(12, 20);
            buUp.Name = "buUp";
            buUp.Size = new Size(218, 109);
            buUp.TabIndex = 0;
            buUp.Text = "00:00.000";
            buUp.UseVisualStyleBackColor = true;
            // 
            // buUpPause
            // 
            buUpPause.Location = new Point(246, 20);
            buUpPause.Name = "buUpPause";
            buUpPause.Size = new Size(111, 109);
            buUpPause.TabIndex = 1;
            buUpPause.Text = "Pause";
            buUpPause.UseVisualStyleBackColor = true;
            // 
            // pbUp
            // 
            pbUp.Location = new Point(380, 20);
            pbUp.Name = "pbUp";
            pbUp.Size = new Size(408, 34);
            pbUp.TabIndex = 2;
            // 
            // pbUpMs
            // 
            pbUpMs.Location = new Point(380, 95);
            pbUpMs.Name = "pbUpMs";
            pbUpMs.Size = new Size(408, 34);
            pbUpMs.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbUpMs);
            Controls.Add(pbUp);
            Controls.Add(buUpPause);
            Controls.Add(buUp);
            Name = "Form1";
            Text = "wfaTimer";
            ResumeLayout(false);
        }

        #endregion

        private Button buUp;
        private Button buUpPause;
        private ProgressBar pbUp;
        private ProgressBar pbUpMs;
    }
}