using AutomatedTrainer.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedTrainer.WindowsFormsUI.Examinations
{
    class SensorPlacesManager
    {
        public SensorPlacesManager(PhysicalIndicator[] physicalIndicators, PictureBox container)
        {
            PhysicalIndicators = physicalIndicators;
            HumansBody = container;

            SensorPlaceInit();
        }

        private void SensorPlaceInit()
        {
            HumansBody.Image = SetImageOpacity(Image.FromFile(@"Images/HumansBody.jpg"), 0.25f);
            HumansBody.SizeMode = PictureBoxSizeMode.Zoom;

            Bitmap bitmap = (Bitmap)HumansBody.Image;
            Graphics raw = Graphics.FromImage(bitmap);

            Pen DrawPen = null;

            for (int i = 0; i < PhysicalIndicators.Length; i++)
            {
                switch (PhysicalIndicators[i].Sensor.Status)
                {
                    case SensorStatus.WorkingCorrectly:
                        DrawPen = new Pen(Color.Green);
                        break;
                    case SensorStatus.NotWorking:
                        DrawPen = new Pen(Color.Red);
                        break;
                    case SensorStatus.Off:
                        DrawPen = new Pen(Color.Black);
                        break;
                }

                Point place = SensorsPositions[PhysicalIndicators[i].Name];
                raw.DrawString((i + 1).ToString(), new Font("Sans Serif", 50f), DrawPen.Brush, place);
            }

            HumansBody.Image = bitmap;
        }

        private Image SetImageOpacity(Image image, float opacity)
        {
            //create a Bitmap the size of the image provided  
            Bitmap bmp = new Bitmap(image.Width, image.Height);

            //create a graphics object from the image  
            using (Graphics gfx = Graphics.FromImage(bmp))
            {

                //create a color matrix object  
                ColorMatrix matrix = new ColorMatrix();

                //set the opacity  
                matrix.Matrix33 = opacity;

                //create image attributes  
                ImageAttributes attributes = new ImageAttributes();

                //set the color(opacity) of the image  
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                //now draw the image  
                gfx.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);

                return bmp;
            }
        }

        private PhysicalIndicator[] PhysicalIndicators { get; set; }

        private PictureBox HumansBody { get; set; }

        private const string ImagePath = "Images/HumansBody.jpg";

        private readonly Dictionary<string, Point> SensorsPositions =
            new Dictionary<string, Point>
            {
                { "Показатель кровяного давления",new Point(157,309) },
                { "Показатель проводимости кожи",new Point(71,646) },
                { "Показатель частоты пульса сердечного ритма",new Point(489,516) },
                { "Показатель влажности кожи",new Point(283,213) },
                { "Показатель температуры кожи",new Point(402,280) }
            };
    }
}
