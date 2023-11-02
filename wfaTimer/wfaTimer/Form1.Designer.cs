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
            buDown = new Button();
            buDownPause = new Button();
            pbDown = new ProgressBar();
            pbDownMs = new ProgressBar();
            SuspendLayout();
            // 
            // buUp
            // 
            buUp.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buUp.Location = new Point(12, 20);
            buUp.Name = "buUp";
            buUp.Size = new Size(348, 109);
            buUp.TabIndex = 0;
            buUp.Text = "00:00.000";
            buUp.UseVisualStyleBackColor = true;
            // 
            // buUpPause
            // 
            buUpPause.Location = new Point(366, 20);
            buUpPause.Name = "buUpPause";
            buUpPause.Size = new Size(111, 109);
            buUpPause.TabIndex = 1;
            buUpPause.Text = "Pause";
            buUpPause.UseVisualStyleBackColor = true;
            // 
            // pbUp
            // 
            pbUp.Location = new Point(508, 20);
            pbUp.Name = "pbUp";
            pbUp.Size = new Size(280, 34);
            pbUp.TabIndex = 2;
            // 
            // pbUpMs
            // 
            pbUpMs.Location = new Point(508, 95);
            pbUpMs.Name = "pbUpMs";
            pbUpMs.Size = new Size(280, 34);
            pbUpMs.TabIndex = 3;
            // 
            // buDown
            // 
            buDown.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buDown.Location = new Point(12, 167);
            buDown.Name = "buDown";
            buDown.Size = new Size(348, 109);
            buDown.TabIndex = 4;
            buDown.Text = "00:00.000";
            buDown.UseVisualStyleBackColor = true;
            // 
            // buDownPause
            // 
            buDownPause.Location = new Point(366, 167);
            buDownPause.Name = "buDownPause";
            buDownPause.Size = new Size(111, 109);
            buDownPause.TabIndex = 5;
            buDownPause.Text = "Pause";
            buDownPause.UseVisualStyleBackColor = true;
            // 
            // pbDown
            // 
            pbDown.Location = new Point(508, 167);
            pbDown.Name = "pbDown";
            pbDown.Size = new Size(280, 34);
            pbDown.TabIndex = 6;
            // 
            // pbDownMs
            // 
            pbDownMs.Location = new Point(508, 242);
            pbDownMs.Name = "pbDownMs";
            pbDownMs.Size = new Size(280, 34);
            pbDownMs.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbDownMs);
            Controls.Add(pbDown);
            Controls.Add(buDownPause);
            Controls.Add(buDown);
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
        private Button buDown;
        private Button buDownPause;
        private ProgressBar pbDown;
        private ProgressBar pbDownMs;
    }
}