using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedTrainer.WindowsFormsUI
{
    using AutomatedTrainer.Models;
    using AutomatedTrainer.Store;
    using System.Windows.Forms.DataVisualization.Charting;
    using AutomatedTrainer.WindowsFormsUI.Examinations;
    using System.Drawing.Imaging;

    public partial class ExaminationForm : Form
    {
        private Patient WhosExamination { get; set; }
        private Examination Examination { get; set; }

        private GraphManager GraphManager { get; set; }
        private TimeManager TimeManager { get; set; }


        public ExaminationForm(Patient patient, Examination examination)
        {
            WhosExamination = patient;
            Examination = examination;

            InitializeComponent();

            ExaminationInformationInit();

            SensorPlaceInit();

            this.GraphManager = new GraphManager(examination.PhysicalIndicators.ToArray(),
                IndicatorGraph1, IndicatorGraph2, IndicatorGraph3,
                IndicatorGraph4, IndicatorGraph5);

            this.TimeManager = new TimeManager(Synchronizer);

            DataRemovingInit();
        }

        private readonly Dictionary<string, Point> SensorsPositions  = 
            new Dictionary<string, Point>
            {
                { "Показатель кровяного давления",new Point(157,309) },
                { "Показатель проводимости кожи",new Point(71,646) },
                { "Показатель частоты пульса сердечного ритма",new Point(489,516) },
                { "Показатель влажности кожи",new Point(283,213) },
                { "Показатель температуры кожи",new Point(402,280) }
            };

        private void SensorPlaceInit()
        {
            HumansBody.Image = SetImageOpacity(Image.FromFile(@"Images/HumansBody.jpg"), 0.25f);
            HumansBody.SizeMode = PictureBoxSizeMode.Zoom;

            Bitmap bitmap = (Bitmap)HumansBody.Image;
            Graphics raw = Graphics.FromImage(bitmap);

            var PhysicalIndicators = Examination.PhysicalIndicators;

            Pen DrawPen = null;

            for (int i = 0; i < PhysicalIndicators.Count; i++)
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
                raw.DrawString((i+1).ToString(), new Font("Sans Serif", 50f), DrawPen.Brush, place);
            }

            HumansBody.Image = bitmap;
        }

        public Image SetImageOpacity(Image image, float opacity)
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

        private void DataRemovingInit()
        {
            this.FormClosed += (s, args) => {
                WhosExamination.Examinations.Remove(Examination);
            };
        }
        private void ExaminationInformationInit()
        {
            PatientFullName.Text = WhosExamination.FullName;

            double totalDays = DateTime.Now.Subtract(WhosExamination.BirthDate).TotalDays;
            PatientAge.Text = Math.Floor(totalDays / 365).ToString();

            PatientSex.Text = WhosExamination.Sex.ToString();

            ExaminationDate.Text = Examination.Date.ToString();
            ExaminationType.Text = Examination.Type.ToString();


        }

        private void Synchronizer_Tick(object sender, EventArgs e)
        {
            GraphManager.Step(TimeManager.Step());
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (TimeManager.IsRun())
            {
                TimeManager.Stop();

                Button btn = sender as Button;
                btn.Text = "Старт";
            }
            else
            {
                TimeManager.Start();

                Button btn = sender as Button;
                btn.Text = "Стоп";
            }
        }
    }
}
