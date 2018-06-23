using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast.Entities
{
    public class CalculatorIndicatori
    {
        private List<Valoare> mValori;

        public CalculatorIndicatori()
        {
            mValori = new List<Valoare>();
        }

        public CalculatorIndicatori(List<Valoare> valori)
        {
            mValori = valori;
        }
        public List<double> CalculareMedieMobilaSimpla21Zile()
        {
            List<double> medieMobila = new List<double>();
            if (mValori != null)
            {
                double suma = 0;
               
                for(int i = 0; i < 21; i++)
                {
                    suma += mValori[i].Close;
                }

                medieMobila.Add(Math.Round(suma / 21,4));

                for(int i = 21; i < mValori.Count; i++)
                {
                    suma -= mValori[i - 21].Close;
                    suma += mValori[i].Close;
                    medieMobila.Add(Math.Round(suma / 21,4));
                }
            }

            return medieMobila;
        }

        public List<double> CalculeazaVolatilitateIstoirica30Zile()
        {
            List<double> volatilitateIstoirca = new List<double>();
            if (mValori != null)
            {
                double suma = 0;

                for (int i = 0; i < 60; i++)
                {
                    suma += Math.Pow(Math.Log(mValori[i].Close), 2);
                }

                volatilitateIstoirca.Add(Math.Round(Math.Sqrt(suma) / Math.Sqrt(365 / 30), 4));

                for (int i = 21; i < mValori.Count; i++)
                {
                    suma -= Math.Pow(Math.Log(mValori[i-21].Close), 2);
                    suma += Math.Pow(Math.Log(mValori[i].Close), 2);
                    volatilitateIstoirca.Add(Math.Round(Math.Sqrt(suma) / Math.Sqrt(365 / 30), 4));
                }
            }
            return volatilitateIstoirca;
        }
    }
}
