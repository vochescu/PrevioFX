using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace Forecast
{
    [TypeConverter(typeof(Y2AxisConverter))]
    public class Y2Axis
    {
        private float y2LimMin = 0f;
        private float y2LimMax = 100f;
        private float y2Tick = 20f;
        private bool isY2Axis = false;
        private Grafic chart2d;
        public Y2Axis(Grafic ct2d)
        {
            chart2d = ct2d;
        }
        [Description("Indicates whether the chart has the Y2 axis."), Category("Appearance")]
        public bool IsY2Axis
        {
            get { return isY2Axis; }
            set
            {
                isY2Axis = value;
                chart2d.Invalidate();
            }
        }
        [Description("Sets the maximum limit for the Y2 axis."), Category("Appearance")]
        public float Y2LimMax
        {
            get { return y2LimMax; }
            set
            {
                y2LimMax = value;
                chart2d.Invalidate();
            }
        }
        [Description("Sets the minimum limit for the Y2 axis."), Category("Appearance")]
        public float Y2LimMin
        {
            get { return y2LimMin; }
            set
            {
                y2LimMin = value;
                chart2d.Invalidate();
            }
        } 
        [Description("Sets the ticks for the Y2 axis."), Category("Appearance")]
         public float Y2Tick
         {
                get { return y2Tick; }
                set
                {
                    y2Tick = value;
                    chart2d.Invalidate();
                }
         }
    }
}