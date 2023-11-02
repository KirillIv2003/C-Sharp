namespace wfaGraphic
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
            pbCharts = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pbCharts1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbCharts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCharts1).BeginInit();
            SuspendLayout();
            // 
            // pbCharts
            // 
            pbCharts.BackColor = Color.Transparent;
            pbCharts.Dock = DockStyle.Fill;
            pbCharts.Location = new Point(0, 0);
            pbCharts.Name = "pbCharts";
            pbCharts.Size = new Size(823, 465);
            pbCharts.SizeMode = PictureBoxSizeMode.AutoSize;
            pbCharts.TabIndex = 0;
            pbCharts.TabStop = false;
            pbCharts.MouseMove += pbCharts_MouseMove;
            // 
            // pbCharts1
            // 
            pbCharts1.BackColor = Color.Transparent;
            pbCharts1.Dock = DockStyle.Fill;
            pbCharts1.Location = new Point(0, 0);
            pbCharts1.Name = "pbCharts1";
            pbCharts1.Size = new Size(880, 446);
            pbCharts1.TabIndex = 0;
            pbCharts1.TabStop = false;
            // 
            // Form1
            // 
            ClientSize = new Size(880, 446);
            Controls.Add(pbCharts1);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbCharts).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCharts1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbCharts;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pbCharts1;
    }
}