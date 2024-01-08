using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.Linq;



namespace BackgroundRemovalApp
{
    
    public class ImageProcessor
    {
        private Bitmap originalImage;

        public ImageProcessor(string imagePath)
        {
            originalImage = new Bitmap(imagePath);
        }

        public Bitmap GetContour()
        {
            // Реализуйте алгоритм выделения контура
            Bitmap contourImage = new Bitmap(originalImage);

            for (int y = 0; y < contourImage.Height; y++)
            {
                for (int x = 0; x < contourImage.Width; x++)
                {
                    Color currentPixel = contourImage.GetPixel(x, y);

                    // Пример: простой алгоритм выделения контура по яркости пикселей
                    int brightness = (int)(0.299 * currentPixel.R + 0.587 * currentPixel.G + 0.114 * currentPixel.B);
                    Color contourColor = brightness > 128 ? Color.White : Color.Black;

                    contourImage.SetPixel(x, y, contourColor);
                }
            }

            // Пример: возврат оригинального изображения для демонстрации
            return originalImage;
        }

        public Bitmap ChangeBackground(Color newBackgroundColor)
        {
            // Ваш текущий код для обработки изображения
            Bitmap resultImage = RemoveBackground();

            // Создаем новое изображение с измененным цветом фона
            Bitmap imageWithNewBackground = new Bitmap(resultImage.Width, resultImage.Height);
            using (Graphics g = Graphics.FromImage(imageWithNewBackground))
            {
                g.Clear(newBackgroundColor);
                g.DrawImage(resultImage, Point.Empty);
            }

            return imageWithNewBackground;
        }

        public Bitmap ApplyBorder(Color borderColor, int borderWidth)
        {
            Bitmap borderedImage = new Bitmap(originalImage.Width, originalImage.Height);

            // Реализуйте алгоритм добавления обводки
            // ...

            // Пример: рисуем обводку
            using (Graphics g = Graphics.FromImage(borderedImage))
            {
                Pen pen = new Pen(borderColor, borderWidth);
                g.DrawRectangle(pen, 0, 0, originalImage.Width, originalImage.Height);
                g.DrawImage(originalImage, 0, 0);
            }

            return borderedImage;
        }
        public Bitmap RemoveBackground()
        {
            Bitmap resultImage = new Bitmap(originalImage);

            //Color backgroundColor = originalImage.GetPixel(0, 0);
            //for (int y = 0; y < resultImage.Height; y++)
            //{
            //    for (int x = 0; x < resultImage.Width; x++)
            //    {
            //        Color currentPixel = resultImage.GetPixel(x, y);

            //        // Если цвет текущего пикселя соответствует цвету фона, устанавливаем прозрачность
            //        if (currentPixel == backgroundColor)
            //        {
            //            resultImage.SetPixel(x, y, Color.Transparent);
            //        }
            //    }
            //}



            for (int offsetY = 0; offsetY <= 2; offsetY++)
            {
                for (int offsetX = 0; offsetX <= 2; offsetX++)
                {
                    Color backgroundColor = originalImage.GetPixel(offsetX, offsetY);
                    for (int y = 0; y < resultImage.Height; y++)
                    {
                        for (int x = 0; x < resultImage.Width; x++)
                        {
                            int currentX = x + offsetX;
                            int currentY = y + offsetY;

                            if (currentX < resultImage.Width && currentY < resultImage.Height)
                            {
                                Color currentPixel = resultImage.GetPixel(currentX, currentY);
                                if (currentPixel == backgroundColor)
                                {
                                    resultImage.SetPixel(currentX, currentY, Color.Transparent);
                                }
                            }
                        }
                    }
                }
            }

            return resultImage;

        }

        public Bitmap AddOutline(Color outlineColor, int outlineWidth)
        {
            Bitmap resultImage = new Bitmap(originalImage);
            Bitmap imageWithOutline = new Bitmap(resultImage.Width, resultImage.Height);

            using (Graphics g = Graphics.FromImage(imageWithOutline))
            {
                // Заливаем фон цветом обводки
                g.Clear(outlineColor);

                // Рисуем изначальное изображение поверх фона
                g.DrawImage(originalImage, new Point(outlineWidth, outlineWidth));

                // Рисуем обводку
                using (Pen outlinePen = new Pen(outlineColor, outlineWidth))
                {
                    g.DrawRectangle(outlinePen, new Rectangle(0, 0, resultImage.Width + 2 * outlineWidth, resultImage.Height + 2 * outlineWidth));
                }
            }

            return imageWithOutline;
        }
    }
}