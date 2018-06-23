using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast
{
    public class YAxis
    {
        private float yLimMin = 0f;
        private float yLimMax = 10f;
        private float yTick = 2f;
        private Grafic chart2d;
        public YAxis(Grafic ct2d)
        {
            chart2d = ct2d;
        }

        public float YLimMax
        {
            get { return yLimMax; }
            set
            {
                yLimMax = value;
                chart2d.Invalidate();
            }
        }
       
        public float YLimMin
        {
            get { return yLimMin; }
            set
            {
                yLimMin = value;
                chart2d.Invalidate();
            }
        }
      
        public float YTick
        {
            get { return yTick; }
            set
            {
                yTick = value;
                chart2d.Invalidate();
            }
        }
    }
}
