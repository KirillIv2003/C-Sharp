namespace CarPlayWfa
{
    public partial class Form1 : Form
    {
        private Point pos;
        private bool dragging, lose = false;
        private int score = 0, countCoins = 0, carspeed = 7, playerSpeed = 15;
        private Form2 form2;
        public event EventHandler PlayButtonClicked;
        public event EventHandler RestartButtonClicked;
        public Form1()
        {
            InitializeComponent();

            pbRoad.MouseDown += PbRoad_MouseDown;
            pbRoad.MouseMove += PbRoad_MouseMove;
            pbRoad.MouseUp += PbRoad_MouseUp;
            pbRoad2.MouseDown += PbRoad2_MouseDown;
            pbRoad2.MouseMove += PbRoad2_MouseMove;
            pbRoad2.MouseUp += PbRoad2_MouseUp;

            lLose.Visible = false;
            bnRestart.Visible = false;

            pbPlayer.BackColor = Color.Transparent;

            KeyPreview = true;

            form2 = new Form2();

            //form2.tbPlayer_TextChanged() += Form2_PlayButtonClicked;

        }

        private void Form2_PlayButtonClicked(object sender, EventArgs e)
        {
            // Запускаем таймер в Form1 из Form2
            timer.Enabled = true;
            carspeed = form2.GetCarSpeed();
            playerSpeed = form2.GetPlayerSpeed();
            form2.Close();
        }

        private void PbRoad2_MouseDown(object? sender, MouseEventArgs e)
        {
            dragging = true;
            pos.X = e.X;
            pos.Y = e.Y;
        }

        private void PbRoad2_MouseMove(object? sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currPoint = PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(currPoint.X - pos.X, currPoint.Y - pos.Y + pbRoad2.Top);
            }
        }

        private void PbRoad2_MouseUp(object? sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void PbRoad_MouseUp(object? sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void PbRoad_MouseMove(object? sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currPoint = PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(currPoint.X - pos.X, currPoint.Y - pos.Y + pbRoad.Top);
            }
        }

        private void PbRoad_MouseDown(object? sender, MouseEventArgs e)
        {
            dragging = true;
            pos.X = e.X;
            pos.Y = e.Y;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
            if (e.KeyChar == (char)Keys.Tab)
            {
                form2 = new Form2();
                form2.Show();
                timer.Enabled = false;

                // Подписываемся на событие в Form2
                form2.PlayButtonClicked += Form2_PlayButtonClicked;

                form2.RestartButtonClicked += bnRestart_Click;


                carspeed = form2.GetCarSpeed();

                playerSpeed = form2.GetPlayerSpeed();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int speed = 5;
            pbRoad.Top += speed;
            pbRoad2.Top += speed;

            //int carspeed = 7;
            pbEnemy1.Top += carspeed;
            pbEnemy2.Top += carspeed;

            pbCoin.Top += speed;

            if (pbCoin.Top >= 650)
            {
                pbCoin.Top = -50;
                Random rand = new Random();
                pbCoin.Left = rand.Next(50, 700);
            }

            if (pbRoad.Top > 650)
            {
                pbRoad.Top = 0;
                pbRoad2.Top = -650;
            }

            if (pbEnemy1.Top >= 650)
            {
                pbEnemy1.Top = -230;
                Random rand = new Random();
                pbEnemy1.Left = rand.Next(50, 300);
                score++;
                lScore.Text = $"Score\n{score}";
            }

            if (pbEnemy2.Top >= 650)
            {
                pbEnemy2.Top = -700;
                Random rand = new Random();
                pbEnemy2.Left = rand.Next(400, 700);
                score++;
                lScore.Text = $"Score\n{score}";
            }

            if (pbPlayer.Bounds.IntersectsWith(pbEnemy1.Bounds) || pbPlayer.Bounds.IntersectsWith(pbEnemy2.Bounds))
            {
                timer.Enabled = false;
                lLose.Visible = true;
                bnRestart.Visible = true;
                lose = true;
            }

            if (pbPlayer.Bounds.IntersectsWith(pbCoin.Bounds))
            {
                countCoins++;
                lCoins.Text = $"Coin\n{countCoins}";
                pbCoin.Top = -50;
                Random rand = new Random();
                pbCoin.Left = rand.Next(50, 700);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (lose) return;
            //int speed = 15;
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && pbPlayer.Left > 50)
            {
                pbPlayer.Left -= playerSpeed;
            }
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && pbPlayer.Right < 800)
            {
                pbPlayer.Left += playerSpeed;
            }
        }

        public void bnRestart_Click(object sender, EventArgs e)
        {
            pbEnemy1.Top = -230;
            pbEnemy2.Top = -450;
            lLose.Visible = false;
            bnRestart.Visible = false;
            timer.Enabled = true;
            score = 0;
            lScore.Text = $"Score\n{score}";
            countCoins = 0;
            lCoins.Text = $"Coin\n{countCoins}";
            pbCoin.Top = -500;
            lose = false;
            carspeed = form2.GetCarSpeed();
            playerSpeed = form2.GetPlayerSpeed();
            form2.Close();
        }
    }
}