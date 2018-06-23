using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Data.SqlClient;
using Forecast.Entities;
using Forecast.Forms;

namespace Forecast
{
    public partial class PaginaDate : UserControl
    {
        SelecteazaPerecheValutaraForm selecteazaPerecheValutaraForm = new SelecteazaPerecheValutaraForm();
        Database database = new Database();
        public PaginaDate()
        {
            InitializeComponent();
            bringToFrontPaginaDate();
        }

        private void vizualizeazaBtn_Click(object sender, EventArgs e)
        {
            bringToFrontPaginaVizualizareDate();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            bringToFrontPaginaDate();
        }

        private void bringToFrontPaginaDate()
        {
            paginaVizualizeazaDate.Visible = false;
            backBtn.Visible = false;

            paginaVizualizeazaDate.SendToBack();
            vizualizeazaDateBtn.BringToFront();
            importaCSVBtn.BringToFront();
            portofoliuBtn.BringToFront();
            printeazaBtn.BringToFront();
        }
        private void bringToFrontPaginaVizualizareDate()
        {
            paginaVizualizeazaDate.Visible = true;
            paginaVizualizeazaDate.BringToFront();
            vizualizeazaDateBtn.SendToBack();
            importaCSVBtn.SendToBack();
            portofoliuBtn.SendToBack();
            printeazaBtn.SendToBack();
            backBtn.Visible = true;
            backBtn.BringToFront();
        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            bringToFrontPaginaDate();
        }

        private void importaCSVBtn_Click(object sender, EventArgs e)
        {
            

            if (selecteazaPerecheValutaraForm.ShowDialog() == DialogResult.OK)
            {

                List<Valoare> valoriLista = new List<Valoare>();

                Stream importCsvStream = null;
                openFileDialogImport = new OpenFileDialog();
                openFileDialogImport.InitialDirectory = "C:\\";
                openFileDialogImport.Filter = "csv files (*.csv)|*.csv";
                openFileDialogImport.FilterIndex = 2;
                openFileDialogImport.RestoreDirectory = true;

                if (openFileDialogImport.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if ((importCsvStream = openFileDialogImport.OpenFile()) != null)
                        {
                            using (importCsvStream)
                            {
                                StreamReader streamReader = new StreamReader(importCsvStream);
                                var line = streamReader.ReadLine();
                                while (!streamReader.EndOfStream)
                                {
                                    var values = line.Split(',');
                                    Valoare valoare = new Valoare(DateTime.Parse(values[0]), Double.Parse(values[1], Constante.PROVIDER), Double.Parse(values[2], Constante.PROVIDER), Double.Parse(values[3], Constante.PROVIDER), Double.Parse(values[4], Constante.PROVIDER));
                                    valoriLista.Add(valoare);
                                    line = streamReader.ReadLine();
                                }
                                if (valoriLista != null)
                                {
                                    database.InsertListaValoriIntoDatabase(valoriLista, selecteazaPerecheValutaraForm.SimbolSelectat);
                                }

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void printeazaBtn_Click(object sender, EventArgs e)
        {
            if (paginaVizualizeazaDate.GetPerecheValutaraSelectata() != null)
            {
                PrintForm printForm = new PrintForm(paginaVizualizeazaDate.GetPerecheValutaraSelectata());
                printForm.Show();
            }
            else
            {
                MessageBox.Show(Constante.MESAJ_VIZUALIZARE_INAINTE_DE_PRINT);
            }
           
        }

        private void portofoliuBtn_Click(object sender, EventArgs e)
        {
            paginaVizualizeazaDate.Visible = true;
            paginaVizualizeazaDate.BringToFront();
            vizualizeazaDateBtn.SendToBack();
            importaCSVBtn.SendToBack();
            portofoliuBtn.SendToBack();
            printeazaBtn.SendToBack();
            backBtn.Visible = true;
            backBtn.BringToFront();
        }
    }
}
