using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast
{
    public class XAxis
    {
        private float xLimMin = 0f;
        private float xLimMax = 1f;
        private float xTick = 1f;
        private List<DateTime> listaDate = new List<DateTime>();
        private Grafic chart2d;

        public XAxis(Grafic ct2d)
        {
            chart2d = ct2d;
            listaDate.Add(DateTime.Today);
            listaDate.Add(DateTime.Today);
        }
        public List<DateTime> ListaDate {
            get { return listaDate; }
            set
            {
                listaDate = value;
                chart2d.Invalidate();
            }
        }
        
        public float XLimMax
        {
            get { return xLimMax; }
            set
            {
                xLimMax = value;
                chart2d.Invalidate();
            }
        }

        public float XLimMin
        {
            get { return xLimMin; }
            set
            {
                xLimMin = value;
                chart2d.Invalidate();
            }
        }

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
