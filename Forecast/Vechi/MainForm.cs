using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;
using Forecast.Entities;
using System.Data;

namespace Forecast
{
    public partial class MainForm : Form
    {
        private VizualizareDateForm viewDatabaseForm;
        private SelecteazaPerecheValutaraForm selecteazaPerecheValutaraForm;
        SqlConnection connection;
        SqlCommand command;
        ChartUserControl chart;
        public MainForm()
        {
            chart = new ChartUserControl();
            chart.Location = new System.Drawing.Point(277, 256);
            this.Controls.Add(chart);
            
            InitializeComponent();

        }

        private void Forecast_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(Constante.CONNECTION_STRING);
            try
            {
                connection.Open();
                string perechiValutarequery = "select Simbol from PerechiValutare";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(perechiValutarequery, connection);
 
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "PerechiValutare");
                perecheValutaraGraficCb.DisplayMember = "Simbol";
                perecheValutaraGraficCb.ValueMember = "Simbol";
                perecheValutaraGraficCb.DataSource = dataSet.Tables["PerechiValutare"];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void importCsvTSBtn_Click(object sender, EventArgs e)
        {
            selecteazaPerecheValutaraForm = new SelecteazaPerecheValutaraForm();
            
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
                                    chart.SetDataSeries(valoriLista);
                                    adaugaValoareInDatabase(valoriLista);
                                }

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                }
            }
        }

        private void closeAppBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewDateTSBtn_Click(object sender, EventArgs e)
        {
            viewDatabaseForm = new VizualizareDateForm();
            viewDatabaseForm.Show();
        }

        private void maximizeWindowBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void minimizeWindowBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void adaugaValoareInDatabase(List<Valoare> listaValori)
        {
            connection = new SqlConnection(Constante.CONNECTION_STRING);
            try
            {
                connection.Open();
                MessageBox.Show("Connection Open! ");
                foreach (Valoare valoare in listaValori)
                {
                    command = new SqlCommand("insert into Valori(Data, OpenPrice, HighPrice, LowPrice, ClosePrice,Simbol) values(@data,@openPrice,@highPrice,@lowPrice,@closePrice, @simbol)", connection);
                    command.Parameters.AddWithValue("@data", valoare.Data);
                    command.Parameters.AddWithValue("@openPrice", float.Parse(valoare.Open.ToString()));
                    command.Parameters.AddWithValue("@highPrice", float.Parse(valoare.High.ToString()));
                    command.Parameters.AddWithValue("@lowPrice", float.Parse(valoare.Low.ToString()));
                    command.Parameters.AddWithValue("@closePrice", float.Parse(valoare.Close.ToString()));
                    command.Parameters.AddWithValue("@simbol", selecteazaPerecheValutaraForm.SimbolSelectat);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void vizualizareDateTSBtn_Click(object sender, EventArgs e)
        {
            VizualizareDateForm vizualizareDateForm = new VizualizareDateForm();
            vizualizareDateForm.Show();
        }

        private void bindComboBoxAndDatabase()
        {
            using (connection = new SqlConnection(Constante.CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                    string perechiValutarequery = "select Simbol from PerechiValutare";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(perechiValutarequery, connection);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet, "PerechiValutare");
                    //perecheValutaraImportCb.DisplayMember = "Simbol";
                    //perecheValutaraImportCb.ValueMember = "Simbol";
                    //perecheValutaraImportCb.DataSource = dataSet.Tables["PerechiValutare"];
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }

}
