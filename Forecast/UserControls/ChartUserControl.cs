using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Forecast.Properties;

namespace Forecast
{
    public partial class ChartUserControl : UserControl

    {
        private DataSeries mDataSeries;
        private List<float> mValori = new List<float>();
        public ChartUserControl()
        {
            InitializeComponent();
  
            graficUC.Dock = DockStyle.Fill;
            graficUC.C2ChartArea.ChartBackColor = Color.White;
            mDataSeries = new DataSeries();
        }
        public void SetDataSeries(List<Valoare> valori)
        {
            for(int i = 0; i< valori.Count;i++)
            {
                float x = float.Parse(valori[i].Close.ToString());
                mDataSeries.AddPoint(new PointF(i + 1,x));
                mValori.Add(x);
            }
            AddData();


        }
        public void AddData()
        {
            // Override ChartStyle properties:
            graficUC.C2XAxis.XLimMin = 0f;
            graficUC.C2XAxis.XLimMax = mValori.Count;
            graficUC.C2YAxis.YLimMin = mValori.Min();
            graficUC.C2YAxis.YLimMax = mValori.Max();
            graficUC.C2XAxis.XTick = 1.0f;
            graficUC.C2YAxis.YTick = 0.5f;
            graficUC.C2Label.XLabel = "Time";
            graficUC.C2Label.YLabel = "Price";
            graficUC.C2Title.Title = "Title";
            graficUC.C2DataCollection.DataSeriesList.Clear();
            // Add Sine data with 7 data points:
            mDataSeries.LineStyle.LineColor = Color.Red;
            mDataSeries.LineStyle.Thickness = 1f;
            mDataSeries.LineStyle.Pattern = DashStyle.Dash;
            mDataSeries.LineStyle.PlotMethod =
                LineStyle.PlotLinesMethodEnum.Lines;
            mDataSeries.SeriesName = "Sine";
            //    chart2D1.SymbolStyle.SymbolType = SymbolStyle.SymbolTypeEnum.Diamond;
            //    chart2D1.SymbolStyle.BorderColor = Color.Red;
            //    chart2D1.SymbolStyle.FillColor = Color.Yellow;
            //    chart2D1.SymbolStyle.BorderThickness = 1f;
           
            graficUC.C2DataCollection.Add(mDataSeries);
        
        }
        
        private void graficCandleTsBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
