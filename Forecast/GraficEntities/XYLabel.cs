using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast
{
    public class XYLabel
    {
        private string xLabel = "X Axis";
        private string yLabel = "Y Axis";
        private string y2Label = "Y2 Axis";
        private Font labelFont = new Font("Palatino Linotype", 10, FontStyle.Regular);
        private Color labelFontColor = Color.DarkSlateGray;
        private Font tickFont;
        private Color tickFontColor = Color.DarkSlateGray;
        private Grafic chart2d;
        public XYLabel(Grafic ct2d)
        {
            chart2d = ct2d;
            tickFont = ct2d.Font;
        }
        [Description("Creates a label for the X axis."), Category("Appearance")]
        public string XLabel
        {
            get { return xLabel; }
            set
            {
                xLabel = value;  
                chart2d.Invalidate();
            }
        }
        public string YLabel
        {
            get { return yLabel; }
            set
            {
                yLabel = value;
                chart2d.Invalidate();
            }
        } 
        public string Y2Label
        {
            get { return y2Label; }
            set
            {
                y2Label = value;
                chart2d.Invalidate();
            }
        }
        public Font LabelFont
        {
            get { return labelFont; }
            set
            {
                labelFont = value;
                chart2d.Invalidate();
            }
        }
        public Color LabelFontColor
        {
            get { return labelFontColor; }
            set
            {
                labelFontColor = value;
                chart2d.Invalidate();
            }
        }
        public Font TickFont
        {
            get { return tickFont; }
            set
            {
                tickFont = value;
                chart2d.Invalidate();
            }
        }
        public Color TickFontColor
        {
            get { return tickFontColor; }
            set
            {
                tickFontColor = value;
                chart2d.Invalidate();
            }
        }
    }
}
