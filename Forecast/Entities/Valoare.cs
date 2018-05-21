using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast
{
    public class Valoare
    {
        private double mLow;
        private double mHigh;
        private double mOpen;
        private double mClose;
        private DateTime mData;

        public double Low
        {
            set { mLow = value; }
            get { return mLow; }
        }
        public double High
        {
            set { mHigh = value; }
            get { return mHigh; }
        }
        public double Open
        {
            set { mOpen = value; }
            get { return mOpen; }
        }
        public double Close
        {
            set { mClose = value; }
            get { return mClose; }
        }

        public DateTime Data
        {
            set { mData = value; }
            get { return mData; }
        }

        public Valoare()
        {
            
        }

        public Valoare(DateTime date, double open, double high, double low, double close)
        {
            Low = low;
            High = high;
            Open = open;
            Close = close;
            Data = date;
        }
    }
}
