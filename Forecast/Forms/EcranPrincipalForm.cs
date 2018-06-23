using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forecast
{
    public partial class EcranPrincipal : Form
    {
        Bunifu.Framework.UI.Drag MoveForm = new Bunifu.Framework.UI.Drag();

        public EcranPrincipal()
        {
            InitializeComponent();
            paginaSumar.AllowDrop = true;
            paginaSumar.GetPanel().AllowDrop = true;

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void meniuBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm.Grab(this);
        }

        private void meniuBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            MoveForm.MoveObject();
        }

        private void meniuBarPanel_MouseUp(object sender, MouseEventArgs e)
        {
            MoveForm.Release();
        }

        private void meniuBtn_Click(object sender, EventArgs e)
        {
            if(meniuLateralPanel.Width == 200)
            {
                descriereLabel.Visible = false;
                logoPictureBox.Location = new Point(0, 3);
                logoPictureBox.Size = new Size(50,150);
                meniuLateralPanel.Width = 50;
                paginaDate.Location = new Point(130, 33);
                paginaGrafic.Location = new Point(130, 33);
                paginaPrevizionare.Location = new Point(130, 33);
            }
            else
            {
                descriereLabel.Visible = true;
                logoPictureBox.Location = new Point(0, 3);
                logoPictureBox.Size = new Size(200, 150);
                meniuLateralPanel.Width = 200;
                paginaDate.Location = new Point(200, 33);
                paginaGrafic.Location = new Point(200, 33);
                paginaPrevizionare.Location = new Point(200, 33);

            }

        }

        private void dateBtn_Click(object sender, EventArgs e)
        {
            if(meniuLateralPanel.Width == 200){
                paginaDate.Location = new Point(200, 33);
            }
            else
            {
                paginaDate.Location = new Point(130, 33);
            }

            paginaDate.BringToFront();
        }

        private void graficBtn_Click(object sender, EventArgs e)
        {
            if (meniuLateralPanel.Width == 200)
            {
                paginaGrafic.Location = new Point(200, 33);
            }
            else
            {
                paginaGrafic.Location = new Point(130, 33);
            }
            paginaGrafic.BringToFront();
        }

        private void previzionareBtn_Click(object sender, EventArgs e)
        {
            if (meniuLateralPanel.Width == 200)
            {
                paginaPrevizionare.Location = new Point(200, 33);
            }
            else
            {
                paginaPrevizionare.Location = new Point(130, 33);
            }
            paginaPrevizionare.BringToFront();
        }

        private void sumarBtn_Click(object sender, EventArgs e)
        {
            if (meniuLateralPanel.Width == 200)
            {
                paginaSumar.Location = new Point(200, 33);
            }
            else
            {
                paginaSumar.Location = new Point(130, 33);
            }
            paginaSumar.BringToFront();
        }

        private void EcranPrincipal_DragDrop(object sender, DragEventArgs e)
        {
            paginaSumar.GetPanel().DragDrop += EcranPrincipal_DragDrop;

            int x = this.PointToClient(new Point(e.X, e.Y)).X;

            int y = this.PointToClient(new Point(e.X, e.Y)).Y;

            PictureBox pictureBox = paginaSumar.GetPictureBox();

            if (x >= pictureBox.Location.X && x <= pictureBox.Location.X + pictureBox.Width && y >= pictureBox.Location.Y && y <= pictureBox.Location.Y + pictureBox.Height)

            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                pictureBox.Image = Image.FromFile(files[0]);
            }

        }

        private void EcranPrincipal_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            paginaSumar.GetPanel().DragEnter += EcranPrincipal_DragEnter;
        }

        private void ajutorBtn_Click(object sender, EventArgs e)
        {
            AboutForm despreForm = new AboutForm();
            despreForm.Show();
        }

       
    }
}
