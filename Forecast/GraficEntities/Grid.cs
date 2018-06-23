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
    public class Grid
    {
        private DashStyle gridPattern = DashStyle.Solid;
        private Color gridColor = Color.Ivory;
        private float gridLineThickness = 1.0f;
        private bool isXGrid = true;
        private bool isYGrid = true;
        private Grafic chart2d;
        public Grid(Grafic ct2d)
        {
            chart2d = ct2d;
        }

        public bool IsXGrid
        {
            get { return isXGrid; }
            set
            {
                isXGrid = value;
                chart2d.Invalidate();
            }
        }

        public bool IsYGrid
        {
            get { return isYGrid; }
            set
            {
                isYGrid = value;
                chart2d.Invalidate();
            }
        }

        virtual public DashStyle GridPattern
        {
            get { return gridPattern; }
            set
            {
                gridPattern = value;
                chart2d.Invalidate();
            }
        }

        public float GridThickness
        {
            get { return gridLineThickness; }
            set
            {
                gridLineThickness = value;
                chart2d.Invalidate();
            }
        }

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
