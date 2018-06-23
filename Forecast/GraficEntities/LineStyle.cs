using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast
{
    public class LineStyle
    {
        private DashStyle linePattern = DashStyle.Solid;
        private Color lineColor = Color.BlueViolet;
        private float LineThickness = 1.0f;
        private bool isVisible = true;
        public LineStyle()
        {
        }
        public bool IsVisible
        {
            get { return isVisible; }
            set { isVisible = value; }
        }
        virtual public DashStyle Pattern
        {
            get { return linePattern; }
            set { linePattern = value; }
        }
        public float Thickness
        {
            get { return LineThickness; }
            set { LineThickness = value; }
        }
        virtual public Color LineColor
        {
            get { return lineColor; }
            set { lineColor = value; }
        }

        private PlotLinesMethodEnum pltLineMethod =
            PlotLinesMethodEnum.Lines;
        public PlotLinesMethodEnum PlotMethod
        {
            get { return pltLineMethod; }
            set { pltLineMethod = value; }
        }
        public enum PlotLinesMethodEnum
        {
            Lines = 0,
            Splines = 1,
            Candlesticks = 2,
            Area = 3
        }
    }
} 

