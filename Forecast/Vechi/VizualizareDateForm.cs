using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Forecast.Entities;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Forecast
{
    public partial class VizualizareDateForm : Form
    {
        SqlConnection connection;
        SqlDataAdapter adapter;
        public VizualizareDateForm()
        {
            InitializeComponent();
        }

        private void ViewDatabaseForm_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(Constante.CONNECTION_STRING);
            connection.Open();
            DataTable dataTable = new DataTable();
            adapter = new SqlDataAdapter("select * from Valori", connection);
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }


    }
}
