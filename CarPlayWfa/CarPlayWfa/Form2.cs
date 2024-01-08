using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace CarPlayWfa
{
    public partial class Form2 : Form
    {
        public string enemyName;
        public string playerName;
        public event EventHandler PlayButtonClicked;
        public event EventHandler RestartButtonClicked;
        //public int CarSpeed
        //{
        //    get { return int.TryParse(tbEnemy.Text, out int result) ? result : 0; }
        //    set { tbEnemy.Text = value.ToString(); }
        //}
        public Form2()
        {
            InitializeComponent();
        }

        private void tbEnemy_TextChanged(object sender, EventArgs e)
        {
            enemyName = tbEnemy.Text;
        }

        public void tbPlayer_TextChanged(object sender, EventArgs e)
        {
            playerName = tbPlayer.Text;
        }

        private void buPlay_Click(object sender, EventArgs e)
        {
            PlayButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void buRestart_Click(object sender, EventArgs e)
        {
            RestartButtonClicked?.Invoke(this, EventArgs.Empty);
        }
        public int GetCarSpeed()
        {
            return int.TryParse(tbEnemy.Text, out int result) ? result : 7;
        }
        public int GetPlayerSpeed()
        {
            return int.TryParse(tbPlayer.Text, out int result) ? result : 15;
        }
    }
}
