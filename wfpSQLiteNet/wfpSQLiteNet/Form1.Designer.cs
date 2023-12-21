namespace wfpSQLiteNet
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
            listView1 = new ListView();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            buShowLogs = new Button();
            buShowUsers = new Button();
            buShowCities = new Button();
            buExecuteSQL = new Button();
            buExecuteOne = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 49);
            listView1.Name = "listView1";
            listView1.Size = new Size(182, 389);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 1;
            label1.Text = "Logs:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(200, 49);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(588, 173);
            textBox1.TabIndex = 2;
            textBox1.Text = "select id, FIO, Email from User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 9);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 3;
            label2.Text = "SQL:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(200, 276);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(588, 162);
            dataGridView1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 248);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 5;
            label3.Text = "Result:";
            // 
            // buShowLogs
            // 
            buShowLogs.Location = new Point(269, 228);
            buShowLogs.Name = "buShowLogs";
            buShowLogs.Size = new Size(112, 34);
            buShowLogs.TabIndex = 6;
            buShowLogs.Text = "Logs";
            buShowLogs.UseVisualStyleBackColor = true;
            // 
            // buShowUsers
            // 
            buShowUsers.Location = new Point(387, 228);
            buShowUsers.Name = "buShowUsers";
            buShowUsers.Size = new Size(112, 34);
            buShowUsers.TabIndex = 7;
            buShowUsers.Text = "Users";
            buShowUsers.UseVisualStyleBackColor = true;
            // 
            // buShowCities
            // 
            buShowCities.Location = new Point(505, 228);
            buShowCities.Name = "buShowCities";
            buShowCities.Size = new Size(112, 34);
            buShowCities.TabIndex = 8;
            buShowCities.Text = "Cities";
            buShowCities.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            buExecuteSQL.Location = new Point(623, 228);
            buExecuteSQL.Name = "button4";
            buExecuteSQL.Size = new Size(58, 34);
            buExecuteSQL.TabIndex = 9;
            buExecuteSQL.Text = "SQL";
            buExecuteSQL.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            buExecuteOne.Location = new Point(687, 228);
            buExecuteOne.Name = "button5";
            buExecuteOne.Size = new Size(71, 34);
            buExecuteOne.TabIndex = 10;
            buExecuteOne.Text = "1";
            buExecuteOne.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buExecuteOne);
            Controls.Add(buExecuteSQL);
            Controls.Add(buShowCities);
            Controls.Add(buShowUsers);
            Controls.Add(buShowLogs);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "wfaSQLiteNet";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
        private Button buShowLogs;
        private Button buShowUsers;
        private Button buShowCities;
        private Button buExecuteSQL;
        private Button buExecuteOne;
    }
}