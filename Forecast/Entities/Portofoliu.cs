using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast.Entities
{
    public class Portofoliu
    {
        private String mNume;
        private List<PerecheValutara> mPerechiValutare;

        public String NumePortofoliu
        {
            get { return mNume; }
            set { mNume = value; }
        }
        public List<PerecheValutara> PerechiValutare
        {
            get { return mPerechiValutare; }
            set { mPerechiValutare = value; }
        }

        public Portofoliu(string nume, List<PerecheValutara> perechiValutare)
        {
            NumePortofoliu = nume;
            PerechiValutare = perechiValutare;
        }
        
    }
}
