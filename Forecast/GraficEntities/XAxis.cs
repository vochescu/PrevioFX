using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast
{
    [TypeConverter(typeof(XAxisConverter))]
    public class XAxis
    {
        private float xLimMin = 0f;
        private float xLimMax = 10f;
        private float xTick = 2f;
        private Grafic chart2d;

        public XAxis(Grafic ct2d)
        {
            chart2d = ct2d;
        }

        [Description("Sets the maximum limit for the X axis."),
         Category("Appearance")]
        public float XLimMax
        {
            get { return xLimMax; }
            set
            {
                xLimMax = value;
                chart2d.Invalidate();
            }
        }

        [Description("Sets the minimum limit for the X axis."),
         Category("Appearance")]
        public float XLimMin
        {
            get { return xLimMin; }
            set
            {
                xLimMin = value;
                chart2d.Invalidate();
            }
        }

        [Description("Sets the ticks for the X axis."), Category("Appearance")]
        public float XTick
        {
            get { return xTick; }

            set
            {
                xTick = value;
                chart2d.Invalidate();
            }
        }
    }
}
