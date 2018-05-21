using Forecast.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forecast
{
    public partial class SelecteazaPerecheValutaraForm : Form
    {
        SqlConnection connection;
        Bunifu.Framework.UI.Drag MoveForm = new Bunifu.Framework.UI.Drag();
        Database database = new Database();

        public String SimbolSelectat{
            get;
            set;
        }
        public SelecteazaPerecheValutaraForm()
        {
            InitializeComponent();
            bindComboBoxAndDatabase();


        }
        private void bindComboBoxAndDatabase()
        {
            DataSet dataSet = database.SelectTotPerecheValutaraDataset();
            if (dataSet != null)
            {
                perecheValutaraImportCb.DisplayMember = "Simbol";
                perecheValutaraImportCb.ValueMember = "Simbol";
                perecheValutaraImportCb.DataSource = dataSet.Tables[Constante.DATASET_NAME_PERECHI_VALUTARE];
            }
            else
            {
                MessageBox.Show(Constante.DB_EROARE_SELECT_PERECHI_VALUTARE);
            }
        }
        private void perecheValutaraImportCb_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void selecteazaPerecheValutaraBtn_Click(object sender, EventArgs e)
        {
            SimbolSelectat = perecheValutaraImportCb.GetItemText(perecheValutaraImportCb.SelectedItem);
            this.Close();
        }

        private void adaugaPerecheValBtn_Click(object sender, EventArgs e)
        {
            if(denumireTb.Text.ToString().Trim() != "" || simbolTb.Text.ToString().Trim() != "")
            {
                database.InsertPerecheValutaraIntoDatabase(denumireTb.Text.ToString().Trim(), simbolTb.Text.ToString().Trim());
                MessageBox.Show("Perechea valutară " + simbolTb.Text.ToString() + " a fost adaugată cu succes! ");
                bindComboBoxAndDatabase();
            }
        }

        private void anuleazaBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            MoveForm.MoveObject();
        }

        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            MoveForm.Release();
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm.Grab(this);
        }
    }
}
