using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast
{
    public class Title2D
    {
        private string title = "Title";
        private Font titleFont = new Font("Palatino Linotype", 12, FontStyle.Regular);
        private Color titleFontColor = Color.DarkSlateGray;
        private Grafic chart2d;
        public Title2D(Grafic ct2d)
        {
            chart2d = ct2d;
        }
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                chart2d.Invalidate();
            }
        }
        public Font TitleFont
        {
            get { return titleFont; }
            set
            {
                titleFont = value;
                chart2d.Invalidate();
            }
        }
        public Color TitleFontColor
        {
            get { return titleFontColor; }
            set
            {
                titleFontColor = value;
                chart2d.Invalidate();
            }
        }
    }
}
