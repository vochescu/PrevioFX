using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast
{
    public class PerecheValutara
    {
        private string mNume;
        private String mSimbol;
        private List<Valoare> mValori;

        public string Nume
        {
            set { mNume = value; }
            get { return mNume; }
        }

        public String Simbol
        {
            set { mSimbol = value; }
            get { return mSimbol; }
        }
        public List<Valoare> Valori
        {
            get { return mValori; }
            set { mValori = value; }
        }
        public PerecheValutara(string nume, string simbol, List<Valoare> valori)
        {
            Nume = nume;
            Simbol = simbol;
            Valori = valori;
        }

        public PerecheValutara() { }

    }
}
