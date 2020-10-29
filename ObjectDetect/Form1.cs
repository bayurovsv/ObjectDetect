using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;
using System.Windows.Forms;
using System;
using Emgu.CV.Util;
using System.Drawing.Drawing2D;
using Feature_Calculations;

namespace ObjectDetect
{
    public partial class Form1 : Form
    {
        /// <summary>Контейнер для передачи изображения</summary>
        private Image<Bgr, byte> image = null;
        public Form1()
        {
            InitializeComponent();
        }
        #region Form control
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open_dialog = new OpenFileDialog();
                DialogResult res = open_dialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    image = new Image<Bgr, byte>(open_dialog.FileName);
                    pictureBox1.Image = image.Bitmap;
                }
            }
            catch (ExeptionOpenImage ex)
            {
                throw new ExeptionOpenImage(ex);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = binarizanionImage().Bitmap;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = searchСounters().Bitmap;
        }
        #endregion

        #region Обработка изображения
        /// <summary>Поиск контура объекта</summary><returns>Изображение с выделенным контуром объекта</returns>
        /// реализовать проверку на наличие изображения в pictureBox
        /// Реализовать нахождения максимального по площади контура

        private Image<Bgr, byte> searchСounters()
        {
            try
            {
                Image<Gray, byte> outputImage = image.Convert<Gray, byte>().ThresholdBinary(new Gray(150), new Gray(255));
                VectorOfVectorOfPoint countors = new VectorOfVectorOfPoint();
                Mat hierarchy = new Mat();
                CvInvoke.FindContours(inversion(outputImage), countors, hierarchy, Emgu.CV.CvEnum.RetrType.Tree, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxNone);
                Image<Bgr, byte> save = new Image<Bgr, byte>(image.Width, image.Height, new Bgr(255, 255, 255));
                CvInvoke.DrawContours(save, countors, 0, new MCvScalar(0, 0, 255), 1);
                CvInvoke.DrawContours(image, countors, 0, new MCvScalar(0, 0, 255), 1);
                save.Save("C:\\Users\\PC\\Desktop\\Тестовые изображения\\test2.png");
                Point[][] list;
                list = countors.ToArrayOfArray();
                Point[] test;
                test = list[0];
                int[] point = CharacteristicObject.Curvature_calculation_points_counter(test);
                listBox1.Items.Add("Выпуклые 90: " + point[0]);
                listBox1.Items.Add("Вогнутые 90: " + point[1]);
                listBox1.Items.Add("Выпуклые 135: " + point[2]);
                listBox1.Items.Add("Вогнутые 135: " + point[3]);
                listBox1.Items.Add("Нулевая кривизна: " + point[4]);
                int[] pointN = CharacteristicObject.SearchForConnectedPoints(test);
                listBox1.Items.Add("N1: " + pointN[0]);
                listBox1.Items.Add("N2: " + pointN[1]);
                listBox1.Items.Add("N3: " + pointN[2]);
                listBox1.Items.Add("N4: " + pointN[3]);
                listBox1.Items.Add("N5: " + pointN[4]);
                listBox1.Items.Add("N6: " + pointN[5]);
                listBox1.Items.Add("N7: " + pointN[6]);
                listBox1.Items.Add("N8: " + pointN[7]);
                return save;
            }
            catch (ExeptionSearchСounters ex)
            {
                throw new ExeptionSearchСounters(ex);
            }
        }
        private Image<Gray, byte> inversion(Image<Gray, byte> image)
        {
            for (int i = 0; i < image.Height; i++)
            {
                for (int z = 0; z < image.Width; z++)
                {
                    Gray color = image[i, z];
                    if (color.Intensity == 255)
                    {
                        image[i, z] = new Gray(0);
                    }
                    else
                    {
                        image[i, z] = new Gray(255);
                    }
                }

            }
            return image;
        }

        /// <summary>Бинаризания</summary><param name="image"></param><returns>Бинаризированное изображение</returns>
        private Image<Gray, byte> binarizanionImage()
        {
            try
            {
                return image.Convert<Gray, byte>().ThresholdBinary(new Gray(150), new Gray(255)); ;
            }
            catch (ExeptionBinarization ex)
            {
                throw new ExeptionBinarization(ex);
            }
        }

        /// <summary>Колибровка изображения(исправления искажения образованного матрицей камеры)</summary><param name="image">Исходное изображение</param><returns>Откалиброванное изображение</returns>
        private Image<Bgr, byte> colibrateImage(Image image)
        {
            Bitmap bt = (Bitmap)image;
            using (Graphics g = Graphics.FromImage(bt))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.InterpolationMode = InterpolationMode.High;
            }
            pictureBox1.Image = bt;
            //x,y - точки с искажением
            //x0,y0 - точки центра(заведомо известные точки без искажения)
            double X = 0, X0 = 0, Y = 0, Y0 = 0;
            double radialDistance = Math.Sqrt(Math.Pow((X - X0), 2) + Math.Pow((Y - Y0), 2));

            double xr = X0 + radialDistance * (X - X0);
            double yr = Y0 + radialDistance * (Y - Y0);
            return null;
        }
        #endregion

        #region формулы для расчёта дисперсии
        private void maths(Image img)
        {
            const double k = 1.15;

            //размер кадра
            double frame = img.Width * img.Height;

            // фокусное растояние
            double F = frame / 3;

            //координаты центра изображения
            double Xc = img.Width / 2;//Координата X
            double Yc = img.Height / 2;///Координата Y

            // Выходной радиус
            double R = F * Math.Tan(Math.Pow(Math.Sin(Math.Sin(Math.Pow(Math.Tan((img.Width / 2) / F), -1) * k)), -1));

            // выходная ширина и высота изображения
            double opw = F * Math.Tan((1 / (Math.Sin(Math.Sin(1 / (Math.Tan(img.Width / 2) / F)) * k))));
            double oph = F * Math.Tan((1 / (Math.Sin(Math.Sin(1 / (Math.Atan(img.Height / 2) / F)) * k))));
            int u = Convert.ToInt32(opw);//205679
            int t = Convert.ToInt32(oph);///54554

            Bitmap resized = new Bitmap(img);
            Bitmap lNewBitmap = new Bitmap(img.Width * 6, img.Height * 6);
            lNewBitmap.SetResolution(resized.HorizontalResolution, resized.VerticalResolution);
            Bitmap imgr = new Bitmap(img);
            // Растояние до центра
            double r = F * Math.Tan(Math.Pow(Math.Sin(Math.Sin(Math.Pow(Math.Tan((img.Width / 2) / F), -1) / k)), -1));
            for (int i = 1; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    int x = (int)Math.Round(r * Math.Cos(j / i), MidpointRounding.AwayFromZero);
                    int y = (int)Math.Round(r * Math.Sin(j / i), MidpointRounding.AwayFromZero);
                    lNewBitmap.SetPixel(x / 100, y / 100, imgr.GetPixel(i, j));
                }
            }
            pictureBox1.Image = lNewBitmap;
            // Координаты x,у
            //double x = r * Math.Cos(135);
            //double y = r * Math.Sin(135);

            //

        }
        #endregion

        #region Exception
        public class ExeptionOpenImage : Exception
        {
            public ExeptionOpenImage(Exception ex)
                   : base("Ошибка открытия изображения:  ", ex)
            {
            }
        }
        public class ExeptionSearchСounters : Exception
        {
            public ExeptionSearchСounters(Exception ex)
                   : base("Ошибка поиска контура объекта:  ", ex)
            {
            }
        }
        public class ExeptionBinarization : Exception
        {
            public ExeptionBinarization(Exception ex)
                   : base("Ошибка бинаризации:  ", ex)
            {
            }
        }
        #endregion
    }
}
