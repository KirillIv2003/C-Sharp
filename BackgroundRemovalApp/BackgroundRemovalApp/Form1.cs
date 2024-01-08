using System.Windows.Forms;
using System.Drawing;
using System;

namespace BackgroundRemovalApp
{
    public partial class Form1 : Form
    {
        //private readonly Kontur kr;
        private ImageProcessor imageProcessor;
        private Bitmap originalImage;
        private Bitmap displayedImage;
        private Point lastMousePos;
        private float zoomLevel = 1.0f;
        public Form1()
        {
            InitializeComponent();



            string relativePath = "Russian_Empire-1899-Coin-5-Obverse.jpg";
            string imagePath1 = Path.Combine(Application.StartupPath, relativePath);
            
            imageProcessor = new ImageProcessor(imagePath1);
            

            buOpen.Click += BuOpen_Click;
            buRun.Click += BuRun_Click;
            buSave.Click += BuSave_Click;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;


            pictureBox1.MouseWheel += PictureBox1_MouseWheel;
            pictureBox1.MouseDown += PictureBox1_MouseDown;
            pictureBox1.MouseMove += PictureBox1_MouseMove;
        }

        private void PictureBox1_MouseMove(object? sender, MouseEventArgs e)
        {
            // Обработка движения мыши
        if (e.Button == MouseButtons.Left)
        {
            // Перемещение изображения в соответствии с движением мыши
            int deltaX = e.X - lastMousePos.X;
            int deltaY = e.Y - lastMousePos.Y;

            pictureBox1.Location = new Point(pictureBox1.Location.X + deltaX, pictureBox1.Location.Y + deltaY);
            lastMousePos = e.Location;
        }

        // Отображение направляющих линий
        // Здесь вы можете реализовать логику для отображения линий под курсором
        // Например, рисовать их на изображении или на самом PictureBox
        }

        private void PictureBox1_MouseDown(object? sender, MouseEventArgs e)
        {
            // Запомнить начальные координаты мыши при нажатии
            lastMousePos = e.Location;
        }

        private void PictureBox1_MouseWheel(object? sender, MouseEventArgs e)
        {
            // Реализация зумирования с использованием колеса мыши
            if (e.Delta > 0)
            {
                ZoomIn();
            }
            else if (e.Delta < 0)
            {
                ZoomOut();
            }
        }
        private void ZoomIn()
        {
            // Увеличить зум
            zoomLevel += 0.1f;
            UpdateDisplayedImage();
        }

        private void ZoomOut()
        {
            // Уменьшить зум, но не допускать зум менее 10%
            zoomLevel = Math.Max(zoomLevel - 0.1f, 0.1f);
            UpdateDisplayedImage();
        }

        private void UpdateDisplayedImage()
        {
            // Обновить отображаемое изображение в соответствии с текущим зумом
            int newWidth = (int)(originalImage.Width * zoomLevel);
            int newHeight = (int)(originalImage.Height * zoomLevel);

            displayedImage = new Bitmap(originalImage, newWidth, newHeight);
            pictureBox1.Image = displayedImage;
        }

        private void BuSave_Click(object? sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp|All Files|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Получаем изображение из PictureBox
                    Bitmap imageToSave = new Bitmap(pictureBox1.Image);

                    // Сохраняем изображение в выбранный файл
                    imageToSave.Save(filePath);

                    MessageBox.Show("Изображение сохранено успешно!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Нет изображения для сохранения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuRun_Click(object? sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == 0)
            {
                //Убрать фон
                Bitmap imageWithoutBackground = imageProcessor.RemoveBackground();
                pictureBox1.Image = imageWithoutBackground;
                pictureBox1.BackColor = Color.Transparent; // Установить фон PictureBox как прозрачный
                pictureBox1.Refresh();
            }
            else if (listBox1.SelectedIndex == 1)
            {
                //Изменить цвет фона
                ColorDialog colorDialog = new ColorDialog();

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color newBackgroundColor = colorDialog.Color;
                    Bitmap imageWithNewBackground = imageProcessor.ChangeBackground(newBackgroundColor);
                    pictureBox1.Image = imageWithNewBackground;
                    pictureBox1.BackColor = newBackgroundColor;
                    pictureBox1.Refresh();
                }
            }
            else if (listBox1.SelectedIndex == 2)
            {
                //Обводка
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap imageWithoutBackground = imageProcessor.RemoveBackground();
                    pictureBox1.Image = imageWithoutBackground;
                    pictureBox1.BackColor = Color.Transparent;

                    Color newBackgroundColor = colorDialog.Color;
                    Bitmap imageWithOutline = imageProcessor.AddOutline(newBackgroundColor, 5);
                    pictureBox1.Image = imageWithOutline;
                    pictureBox1.Refresh();

                }
                   

            }
            else if (listBox1.SelectedIndex == 3)
            {

            }
        }

        private void BuOpen_Click(object? sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;

                    // Проверяем, что файл выбран и существует
                    if (File.Exists(imagePath))
                    {
                        imageProcessor = new ImageProcessor(imagePath);
                        pictureBox1.Image = imageProcessor.GetContour(); // Показываем контур по умолчанию
                    }
                    else
                    {
                        MessageBox.Show("Выбранный файл не существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}