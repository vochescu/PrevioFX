using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast
{
    [TypeConverter(typeof(GridConverter))]
    public class Grid
    {
        private DashStyle gridPattern = DashStyle.Solid;
        private Color gridColor = Color.LightGray;
        private float gridLineThickness = 1.0f;
        private bool isXGrid = true;
        private bool isYGrid = true;
        private Grafic chart2d;
        public Grid(Grafic ct2d)
        {
            chart2d = ct2d;
        }
        [Description("Indicates whether the X grid is shown."), Category("Appearance")]
        public bool IsXGrid
        {
            get { return isXGrid; }
            set
            {
                isXGrid = value;
                chart2d.Invalidate();
            }
        }
        [Description("Indicates whether the Y grid is shown."),
         Category("Appearance")]
        public bool IsYGrid
        {
            get { return isYGrid; }
            set
            {
                isYGrid = value;
                chart2d.Invalidate();
            }
        }
        [Description("Sets the line pattern for the grid lines."), Category("Appearance")]
        virtual public DashStyle GridPattern
        {
            get { return gridPattern; }
            set
            {
                gridPattern = value;
                chart2d.Invalidate();
            }
        }
        [Description("Sets the thickness for the grid lines."), Category("Appearance")]
        public float GridThickness
        {
            get { return gridLineThickness; }
            set
            {
                gridLineThickness = value;
                chart2d.Invalidate();
            }
        }
        [Description("The color used to display the grid lines."), Category("Appearance")]
        virtual public Color GridColor
        {
            get { return gridColor; }
            set
            {
                gridColor = value;
                chart2d.Invalidate();
            }
        }
    }
}
