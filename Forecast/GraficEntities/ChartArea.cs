using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast
{
    public class ChartArea
    {
        private Grafic chart2d;
        private Color chartBackColor;
        private Color chartBorderColor;
        private Color plotBackColor = Color.White;
        private Color plotBorderColor = Color.DarkSlateGray;

        public ChartArea(Grafic ct2d)
        {
            chart2d = ct2d;
            chartBackColor = chart2d.BackColor;
            chartBorderColor = chart2d.BackColor;
        }

        public Color ChartBackColor
        {
            get { return chartBackColor; }
            set
            {
                chartBackColor = value;
                chart2d.Invalidate();
            }
        }
        public Color ChartBorderColor
        {
            get { return chartBorderColor; }
            set
            {
                chartBorderColor = value;
                chart2d.Invalidate();
            }
        }
        public Color PlotBackColor
        {
            get { return plotBackColor; }
            set
            {
                plotBackColor = value;
                chart2d.Invalidate();
            }
        }
        public Color PlotBorderColor
        {
            get { return plotBorderColor; }
            set
            {
                plotBorderColor = value;
                chart2d.Invalidate();
            }
        }
    }
}
