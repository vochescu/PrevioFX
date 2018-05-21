using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast
{
    [TypeConverter(typeof(Title2DConverter))]
    public class Title2D
    {
        private string title = "Title";
        private Font titleFont = new Font("Arial", 12, FontStyle.Regular);
        private Color titleFontColor = Color.Black;
        private Grafic chart2d;
        public Title2D(Grafic ct2d)
        {
            chart2d = ct2d;
        }
        [Description("Creates a title for the chart."), Category("Appearance")]
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                chart2d.Invalidate();
            }
        }
        [Description("The font used to display the title."), Category("Appearance")]
        public Font TitleFont
        {
            get { return titleFont; }
            set
            {
                titleFont = value;
                chart2d.Invalidate();
            }
        }
        [Description("Sets the color of the tile."), Category("Appearance")]
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
