using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forecast.Entities;

namespace Forecast
{
    public partial class PaginaGrafic : UserControl
    {
        Database database = new Database();

        public PaginaGrafic()
        {
            InitializeComponent();
        }

        private void PaginaGrafic_Load(object sender, EventArgs e)
        {
            bindComboBoxAndDatabase();
        }

        private void bindComboBoxAndDatabase()
        {
            DataSet dataSet = database.SelectTotPerecheValutaraDataset();
            if (dataSet != null)
            {
                perecheValutaraGraficCb.DisplayMember = "Simbol";
                perecheValutaraGraficCb.ValueMember = "Simbol";
                perecheValutaraGraficCb.DataSource = dataSet.Tables[Constante.DATASET_NAME_PERECHI_VALUTARE];
            }
            else
            {
                MessageBox.Show(Constante.DB_EROARE_SELECT_PERECHI_VALUTARE);
            }
        }

        private void creareGraficBtn_Click(object sender, EventArgs e)
        {

            if(perecheValutaraGraficCb.SelectedIndex >= 0)
            {
                List<float> valori = database.SelectClosePriceValoriList(perecheValutaraGraficCb.GetItemText(perecheValutaraGraficCb.SelectedItem));
                List<Valoare> preturi = database.SelectValoriList(perecheValutaraGraficCb.GetItemText(perecheValutaraGraficCb.SelectedItem));
                List< DateTime> date = database.SelectDateValoriList(perecheValutaraGraficCb.GetItemText(perecheValutaraGraficCb.SelectedItem));
                if (valori != null && date!= null)
                {
                    chartUserControl1.SetDataSeries(preturi,valori,date, perecheValutaraGraficCb.GetItemText(perecheValutaraGraficCb.SelectedItem));
                }
                if (valori.Count < 1)
                {
                    MessageBox.Show(Constante.EROARE_SELECTARE_PERECHE_VALUTARA);
                }
            }
            else
            {
                MessageBox.Show(Constante.EROARE_SELECTARE_PERECHE_VALUTARA);

            }
        }
    }
}
