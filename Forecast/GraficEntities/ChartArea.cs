using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast
{
    [TypeConverter(typeof(ChartAreaConverter))]
    public class ChartArea
    {
        private Grafic chart2d;
        private Color chartBackColor;
        private Color chartBorderColor;
        private Color plotBackColor = Color.White;
        private Color plotBorderColor = Color.Black;

        public ChartArea(Grafic ct2d)
        {
            chart2d = ct2d;
            chartBackColor = chart2d.BackColor;
            chartBorderColor = chart2d.BackColor;
        }

        // The background color of the chart area.
        public Color ChartBackColor
        {
            get { return chartBackColor; }
            set
            {
                chartBackColor = value;
                chart2d.Invalidate();
            }
        }

        [Description("The border color of the chart area."), Category("Appearance")]
        public Color ChartBorderColor
        {
            get { return chartBorderColor; }
            set
            {
                chartBorderColor = value;
                chart2d.Invalidate();
            }
        }

        [Description("The background color of the plot area."), Category("Appearance")]
        public Color PlotBackColor
        {
            get { return plotBackColor; }
            set
            {
                plotBackColor = value;
                chart2d.Invalidate();
            }
        }

        [Description("The border color of the plot area."), Category("Appearance")]
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
