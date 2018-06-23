using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Forecast.Properties;
using Forecast.GraficEntities;
using Forecast.Entities;

namespace Forecast
{
    public partial class ChartUserControl : UserControl
    {
        private DataSeries mDataSeries;
        private List<float> mValori;
        private List<Valoare> mPreturi;
        private CalculatorIndicatori mCalculatorIndicatori;
        private List<DateTime> mDate;
        private string mPerecheValutara;
        private bool mEsteFullScreen;
        private Form fullScreenForm;
        private Rect rect;
        private Line mLine;

        public ChartUserControl()
        {
            InitializeComponent();
            pictureBox1.Parent = graficUC;
            mEsteFullScreen = false;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            graficUC.Dock = DockStyle.Fill;
            graficUC.C2ChartArea.ChartBackColor = Color.White;
            blockButtonsTs();

        }

        public void SetDataSeries(List<Valoare> preturi, List<float> valori, List<DateTime> date,String perecheValutara)
        {
            mDataSeries = new DataSeries();
            mValori = new List<float>();
            mPreturi = preturi;
            mPerecheValutara = perecheValutara;
            mDate = date;

            mCalculatorIndicatori = new CalculatorIndicatori(preturi);

            if (valori != null && valori.Count > 0)
            {
                for (int i = 0; i < valori.Count; i++)
                {
                    mDataSeries.AddPoint(new PointF(i + 1, valori[i]));
                    mValori.Add(valori[i]);
                }
                AddData(perecheValutara);
                enableButtonsTs();
            }
        }
        public void AddData(String titlu)
        {
            graficUC.C2XAxis.XLimMin = 0f;
            graficUC.C2XAxis.XLimMax = mValori.Count;
            graficUC.C2YAxis.YLimMin = mValori.Min();
            graficUC.C2YAxis.YLimMax = mValori.Max();
            graficUC.C2XAxis.ListaDate = mDate;
            graficUC.C2XAxis.XTick = (mValori.Count-1)/6;
            graficUC.C2YAxis.YTick = 0.1f;
            graficUC.C2Label.XLabel = "Timp";
            graficUC.C2Label.YLabel = "Prețul Close";
            graficUC.C2Title.Title = titlu;
            graficUC.C2DataCollection.DataSeriesList.Clear();

            mDataSeries.LineStyle.LineColor = Color.BlueViolet;
            mDataSeries.LineStyle.Thickness = 1f;
            mDataSeries.LineStyle.Pattern = DashStyle.Solid;
            mDataSeries.LineStyle.PlotMethod = LineStyle.PlotLinesMethodEnum.Lines;
            mDataSeries.SeriesName = titlu;
            graficUC.C2DataCollection.Add(mDataSeries);
        }
        
        private void graficCandleTsBtn_Click(object sender, EventArgs e)
        {
            mDataSeries.LineStyle.PlotMethod = LineStyle.PlotLinesMethodEnum.Candlesticks;
            graficUC.C2DataCollection.Valori = mPreturi;
            graficUC.Refresh();
        }

        private void graficLinieTsBtn_Click(object sender, EventArgs e)
        {
            mDataSeries.LineStyle.PlotMethod = LineStyle.PlotLinesMethodEnum.Lines;
            graficUC.Refresh();
        }

        private void printScreenTsBtn_Click(object sender, EventArgs e)
        {
            if (mEsteFullScreen)
            {
                Rectangle bounds = graficUC.Bounds;
                using (Bitmap bitmap = new Bitmap(bounds.Width -50, bounds.Height-10))
                {
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        this.Invalidate();
                        graphics.CopyFromScreen(new Point(this.Parent.Location.X+50, this.Parent.Location.Y+70 ), Point.Empty, bounds.Size);
                    }
                    salvareImagine(ImageFormat.Jpeg, bitmap);
                }
            }
            else
            {
                Rectangle bounds = graficUC.Bounds;
                using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
                {
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        graphics.CopyFromScreen(new Point(this.Parent.Parent.Location.X + 200, this.Parent.Parent.Location.Y + 220), Point.Empty, bounds.Size);
                    }
                    salvareImagine(ImageFormat.Jpeg, bitmap);
                }
            }
           
        }
        
        private void setPictureBox()
        {
            if (mEsteFullScreen)
            {
                pictureBox1.Location = new Point(100, 70);
                pictureBox1.Size = new Size(1175,575);
            }
            else
            {
                pictureBox1.Location = new Point(65, 39);
                pictureBox1.Size = new Size(579,189);
            }
        }
        private void salvareImagine(ImageFormat format, Bitmap image)
        {
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Salvare imagine";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }
                fs.Close();
            }
        }

        private void fullScreenTsBtn_Click(object sender, EventArgs e)
        {
            ChartUserControl fullChart = new ChartUserControl();
            fullChart.SetDataSeries(mPreturi,mValori,mDate, mPerecheValutara);
            ShowFullScreen(fullChart);
        }

        private void ShowFullScreen(ChartUserControl userControl)
        {
            fullScreenForm = new Form();
            fullScreenForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            fullScreenForm.WindowState = FormWindowState.Maximized;
            fullScreenForm.ShowInTaskbar = true;
            userControl.Dock = DockStyle.Fill;
            fullScreenForm.Controls.Add(userControl);
            userControl.fullScreenForm = fullScreenForm;
            userControl.mEsteFullScreen = true;
            userControl.setPictureBox();
            fullScreenForm.Show();
        }

        private void normalScreenTsBtn_Click(object sender, EventArgs e)
        {
            fullScreenForm.Hide();
            setPictureBox();
        }

        private void dreptunghiTsBtn_Click(object sender, EventArgs e)
        {
            creareRect();
        }

        private void creareRect()
        {
            rect = new Rect(new Rectangle(5, 5, 50, 50));
            rect.SetPictureBox(pictureBox1);
            graficUC.Invalidate();
        }

        private void creareLine()
        {
            mLine = new Line(new Rectangle(5, 5, 20,1));
            mLine.SetPictureBox(pictureBox1);
            graficUC.Invalidate();
        }

        private void linieTsBtn_Click(object sender, EventArgs e)
        {
            creareLine();
        }

        private void graficAreaTsBtn_Click(object sender, EventArgs e)
        {
            mDataSeries.LineStyle.PlotMethod = LineStyle.PlotLinesMethodEnum.Area;
            graficUC.Refresh();
        }
        TextBox textBox = new TextBox();
        Bunifu.Framework.UI.Drag movable = new Bunifu.Framework.UI.Drag();

        private void textTsBtn_Click(object sender, EventArgs e)
        {
            textBox.Cursor = Cursors.Hand;
            textBox.MouseDown += textBox_MouseDown;
            textBox.MouseMove += textBox_MouseMove;
            textBox.MouseUp += textBox_MouseUp;
            textBox.KeyUp += textBox_KeyUp;
            pictureBox1.Controls.Add(textBox);
        }
        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                pictureBox1.Controls.Remove(textBox);
            }
        }
        private void textBox_MouseUp(object sender, MouseEventArgs e)
        {
            movable.Release();
        }

        private void textBox_MouseMove(object sender, MouseEventArgs e)
        {
            movable.MoveObject();
        }

        private void textBox_MouseDown(object sender, MouseEventArgs e)
        {
            movable.Grab(textBox);
        }


        private void blockButtonsTs()
        {
            graficAreaTsBtn.Enabled = false;
            graficCandleTsBtn.Enabled = false;
            graficLinieTsBtn.Enabled = false;
            indicatoriTsBtn.Enabled = false;
        }

        private void enableButtonsTs()
        {
            graficAreaTsBtn.Enabled = true;
            graficCandleTsBtn.Enabled = true;
            graficLinieTsBtn.Enabled = true;
            indicatoriTsBtn.Enabled = true;
        }

        private void medieMobilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<double> medieMobila = mCalculatorIndicatori.CalculareMedieMobilaSimpla21Zile();
            DataSeries dataSeries = new DataSeries();
            for (int i = 0; i < medieMobila.Count; i++)
            {
                dataSeries.AddPoint(new PointF(i + 21, (float)medieMobila[i]));
            }
            graficUC.C2Y2Axis.Y2LimMin = (float)medieMobila.Min();
            graficUC.C2Y2Axis.Y2LimMax = (float)medieMobila.Max();
            graficUC.C2Y2Axis.Y2Tick = 0.1f;

            dataSeries.LineStyle.LineColor = Color.Red;
            dataSeries.LineStyle.Thickness = 1f;
            dataSeries.LineStyle.Pattern = DashStyle.Solid;
            dataSeries.LineStyle.PlotMethod = LineStyle.PlotLinesMethodEnum.Lines;
            dataSeries.SeriesName = "MedieMobila";
            dataSeries.IsY2Data = true;
            graficUC.C2DataCollection.Add(dataSeries);
            graficUC.Invalidate();
        }

        private void volatilitateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<double> volatilitateIstoirica = mCalculatorIndicatori.CalculeazaVolatilitateIstoirica30Zile();
            DataSeries dataSeries = new DataSeries();
            for (int i = 0; i < volatilitateIstoirica.Count; i++)
            {
                dataSeries.AddPoint(new PointF(i + 60, (float)volatilitateIstoirica[i]));
            }
            graficUC.C2Y2Axis.Y2LimMin = (float)volatilitateIstoirica.Min();
            graficUC.C2Y2Axis.Y2LimMax = (float)volatilitateIstoirica.Max();
            graficUC.C2Y2Axis.Y2Tick = 0.1f;
            graficUC.C2DataCollection.Remove("MedieMobila");
            dataSeries.LineStyle.LineColor = Color.SeaGreen;
            dataSeries.LineStyle.Thickness = 1f;
            dataSeries.LineStyle.Pattern = DashStyle.Dash;
            dataSeries.LineStyle.PlotMethod = LineStyle.PlotLinesMethodEnum.Lines;
            dataSeries.SeriesName = "Volatilitate";
            dataSeries.IsY2Data = true;
            graficUC.C2DataCollection.Add(dataSeries);
            graficUC.Invalidate();
        }

        private void stergeIndicatoriTSm_Click(object sender, EventArgs e)
        {
            graficUC.C2DataCollection.Remove("MedieMobila");
            graficUC.C2DataCollection.Remove("Volatilitate");
            graficUC.Invalidate();

        }

      
    }
}
