using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast
{
    [TypeConverter(typeof(XYLabelConverter))]
    public class XYLabel
    {
        private string xLabel = "X Axis";
        private string yLabel = "Y Axis";
        private string y2Label = "Y2 Axis";
        private Font labelFont = new Font("Arial", 10, FontStyle.Regular);
        private Color labelFontColor = Color.Black;
        private Font tickFont;
        private Color tickFontColor = Color.Black;
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
        [Description("Creates a label for the Y axis."), Category("Appearance")]
        public string YLabel
        {
            get { return yLabel; }
            set
            {
                yLabel = value;
                chart2d.Invalidate();
            }
        } 
        [Description("Creates a label for the Y2 axis."), Category("Appearance")]
        public string Y2Label
        {
            get { return y2Label; }
            set
            {
                y2Label = value;
                chart2d.Invalidate();
            }
        }
        [Description("The font used to display the axis labels."), Category("Appearance")]
        public Font LabelFont
        {
            get { return labelFont; }
            set
            {
                labelFont = value;
                chart2d.Invalidate();
            }
        }
        [Description("Sets the color of the axis labels."),Category("Appearance")]
        public Color LabelFontColor
        {
            get { return labelFontColor; }
            set
            {
                labelFontColor = value;
                chart2d.Invalidate();
            }
        }
        [Description("The font used to display the tick labels."), Category("Appearance")]
        public Font TickFont
        {
            get { return tickFont; }
            set
            {
                tickFont = value;
                chart2d.Invalidate();
            }
        }
        [Description("Sets the color of the tick labels."), Category("Appearance")]
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
