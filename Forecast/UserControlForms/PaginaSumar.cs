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
using System.Drawing.Imaging;


namespace Forecast.UserControlForms
{


    public partial class PaginaSumar : UserControl
    {
        Database database;
        List<Valoare> mValori;
        public PaginaSumar()
        {
            InitializeComponent();
            database = new Database();
            mValori = new List<Valoare>();
            getComboBoxData();
        }

  

        public PictureBox GetPictureBox()
        {
            return pictureBox;
        }

        public  Bunifu.Framework.UI.BunifuGradientPanel GetPanel()
        {
            return bunifuGradientPanel1;
        }

        private void perecheValutaraCb_DropDownClosed(object sender, EventArgs e)
        {
            String perecheValutaraSelectata = perecheValutaraCb.SelectedValue.ToString();
            if (perecheValutaraSelectata != null)
            {
                mValori = database.SelectValoriList(perecheValutaraSelectata);
                if (mValori != null)
                {
                    calculeazaStatisticiPerecheValutara();
                }
                else
                {
                    MessageBox.Show(Constante.EROARE_DATE_PERECHI_VALUTARE);
                }
            }
            
        }
        private void getComboBoxData()
        {
            DataSet dataSet = database.SelectTotPerecheValutaraDataset();
            if (dataSet != null)
            {
                perecheValutaraCb.DisplayMember = "Simbol";
                perecheValutaraCb.ValueMember = "Simbol";
                perecheValutaraCb.DataSource = dataSet.Tables[Constante.DATASET_NAME_PERECHI_VALUTARE];
            }
            else
            {
                MessageBox.Show(Constante.DB_EROARE_SELECT_PERECHI_VALUTARE);
            }

        }
        private void calculeazaStatisticiPerecheValutara()
        {
            List<double> open = new List<double>();
            List<double> close = new List<double>();
            double sumOpen = 0;
            double sumClose = 0;
            foreach(Valoare val in mValori)
            {
                open.Add(val.Open);
                close.Add(val.Close);
                sumOpen += val.Open;
                sumClose += val.Close;
            }

            maxOpenLb.Text = open.Max().ToString();
            minOpenLb.Text = open.Min().ToString();
            maxCloseLb.Text = close.Max().ToString();
            minCloseLb.Text = close.Min().ToString();

            valMedOpenLb.Text = Math.Round(sumOpen / open.Count,4).ToString();
            valMedCloseLb.Text = Math.Round(sumClose / close.Count,4).ToString();
            CalculatorIndicatori calculatorIndicatori = new CalculatorIndicatori(mValori);
            List<double> volatilitate = calculatorIndicatori.CalculeazaVolatilitateIstoirica30Zile();
            double suma = 0;

            foreach(var v in volatilitate)
            {
                suma += v;
            }
            circleProgressbar.Value= (int)(Math.Round(suma / volatilitate.Count,2)*100);
        }

        private void valMedCloseLb_Click(object sender, EventArgs e)
        {

        }

        private void minCloseLb_Click(object sender, EventArgs e)
        {

        }

        private void panelSumar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip.Show(Cursor.Position);
            }
        }

        private void salveazaTsmi_Click(object sender, EventArgs e)
        {
            Rectangle bounds = this.Bounds;
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    this.Invalidate();
                    graphics.CopyFromScreen(new Point(this.Parent.Location.X+200, this.Parent.Location.Y+30), Point.Empty, bounds.Size);
                }
                salvareImagine(ImageFormat.Jpeg, bitmap);
            }
        }


        private void salvareImagine(ImageFormat format, Bitmap image)
        {
            saveFileDialog1.Filter = "JPeg Image|*.jpg";
            saveFileDialog1.Title = "Salvare imagine";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
               
                image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                       
                fs.Close();
            }
        }
    }
}
