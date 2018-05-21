using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forecast.Entities;
namespace Forecast
{
    public partial class AdaugaValoriForm : Form
    {
        String mSimbol;
        Database database = new Database();
        Bunifu.Framework.UI.Drag MoveForm = new Bunifu.Framework.UI.Drag();
        bool esteEditare;
        public AdaugaValoriForm(String simbol)
        {
            mSimbol = simbol;
            esteEditare = false;
            InitializeComponent();
            perecheValutaraLb.Text = simbol;
           
        }
        public AdaugaValoriForm(Valoare valoare, String simbol)
        {
            mSimbol = simbol;
            esteEditare = true;
            InitializeComponent();
            perecheValutaraLb.Text = simbol;
            dataDtp.Value = valoare.Data;
            dataDtp.Visible = false;
            dataLb.Visible = false;
            openTb.Text = valoare.Open.ToString();
            highTb.Text = valoare.High.ToString();
            lowTb.Text = valoare.Low.ToString();
            closeTb.Text = valoare.Close.ToString();

        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            dataErrorProvider.Clear();
            openErrorProvider.Clear();
            highErrorProvider.Clear();
            lowErrorProvider.Clear();
            closeErrorProvider.Clear();
            if (validareCampuriIntroduse())
            {
                Valoare valoare = new Valoare(dataDtp.Value,
                Math.Round(Double.Parse(openTb.Text.ToString().Trim().Replace('.', ',')), 2, MidpointRounding.AwayFromZero),
                Math.Round(Double.Parse(highTb.Text.ToString().Trim().Replace('.', ',')), 2, MidpointRounding.AwayFromZero),
                Math.Round(Double.Parse(lowTb.Text.ToString().Trim().Replace('.', ',')), 2, MidpointRounding.AwayFromZero),
                Math.Round(Double.Parse(closeTb.Text.ToString().Trim().Replace('.', ',')), 2, MidpointRounding.AwayFromZero));
                if (esteEditare)
                {
                    database.UpdateValoriIntoDatabase(valoare);
                }
                else
                {
                    database.InsertValoriIntoDatabase(valoare, mSimbol);
                }
                this.Close();
            }
        }

        private bool validareCampuriIntroduse()
        {
            bool campuriOk = true;
            float result = 0f;
            if(!(dataDtp.Value.Date.Year <= DateTime.Today.Year && dataDtp.Value.Date.Month <= DateTime.Today.Month && dataDtp.Value.Day <= DateTime.Today.Day))
            {
                campuriOk = false;
                dataErrorProvider.SetError(dataDtp, Constante.EROARE_DATA);
            }
            if (String.IsNullOrEmpty(openTb.Text.ToString().Trim()))
            {
                campuriOk = false;
                openErrorProvider.SetError(openTb, Constante.EROARE_OPEN);
            }
            else
            {
                if (!float.TryParse(openTb.Text.ToString().Trim(), out result))
                {
                    campuriOk = false;
                    openErrorProvider.SetError(openTb, Constante.EROARE_OPEN);
                }
            }
            if (String.IsNullOrEmpty(highTb.Text.ToString().Trim()))
            {
                campuriOk = false;
                highErrorProvider.SetError(highTb, Constante.EROARE_HIGH);
            }
            else
            {
                if (!float.TryParse(highTb.Text.ToString().Trim(), out result))
                {
                    campuriOk = false;
                    highErrorProvider.SetError(highTb, Constante.EROARE_HIGH);
                }
            }
            if (String.IsNullOrEmpty(lowTb.Text.ToString().Trim()))
            {
                campuriOk = false;
                lowErrorProvider.SetError(lowTb, Constante.EROARE_LOW);
            }
            else
            {
                if (!float.TryParse(lowTb.Text.ToString().Trim(), out result))
                {
                    campuriOk = false;
                    lowErrorProvider.SetError(lowTb, Constante.EROARE_LOW);

                }
            }
            if (String.IsNullOrEmpty(closeTb.Text.ToString().Trim()))
            {
                campuriOk = false;
                closeErrorProvider.SetError(closeTb, Constante.EROARE_CLOSE);
            }
            else
            {
                if (!float.TryParse(closeTb.Text.ToString().Trim(), out result))
                {
                    campuriOk = false;
                    closeErrorProvider.SetError(closeTb, Constante.EROARE_CLOSE);
                }
            }
           
            return campuriOk;
        }

        private void AdaugaValoriForm_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm.Grab(this);
        }

        private void AdaugaValoriForm_MouseUp(object sender, MouseEventArgs e)
        {
            MoveForm.Release();
        }

        private void AdaugaValoriForm_MouseMove(object sender, MouseEventArgs e)
        {
            MoveForm.MoveObject();
        }
    }
}
