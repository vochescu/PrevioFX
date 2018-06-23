using Forecast.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forecast.Forms
{
    public partial class PrintForm : Form
    {
        private String mPerecheValutara;
        Database database;
        public PrintForm(String pv)
        {
            InitializeComponent();
            mPerecheValutara = pv;
            try
            {
                printPreviewControl.Document = printDocument;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Palatino Linotype", 12);

            var pageSettings = printDocument.DefaultPageSettings;
         
            var inaltimeFoaie = pageSettings.PaperSize.Height - pageSettings.Margins.Top - pageSettings.Margins.Bottom;
            var latimeFoaie = pageSettings.PaperSize.Width - pageSettings.Margins.Left - pageSettings.Margins.Right;

            var marginLeft = pageSettings.Margins.Left;
            var marginTop = pageSettings.Margins.Top;

            const int rowHeight = 20;
            var columnWidth = latimeFoaie / 5;

           
            StringFormat format = new StringFormat(StringFormatFlags.LineLimit);
            format.Trimming = StringTrimming.EllipsisCharacter;

            database = new Database();
            List<Valoare> valori = database.SelectValoriList(mPerecheValutara);
            if(valori == null)
            {
                return;
            }
            var currentY = marginTop;
            
            for(int i=0; i< valori.Count;i++)
            {
                var currentX = marginLeft;

                e.Graphics.DrawRectangle( Pens.Black, currentX, currentY, columnWidth, rowHeight); 
                e.Graphics.DrawString( valori[i].Data.ToShortDateString(), font, Brushes.Black, new RectangleF(currentX, currentY, columnWidth, rowHeight), format);
                currentX += columnWidth;

                e.Graphics.DrawRectangle(Pens.Black, currentX, currentY, columnWidth, rowHeight);
                e.Graphics.DrawString(valori[i].Open.ToString(), font, Brushes.Black, new RectangleF(currentX, currentY, columnWidth, rowHeight), format);
                currentX += columnWidth;

                e.Graphics.DrawRectangle(Pens.Black, currentX, currentY, columnWidth, rowHeight);
                e.Graphics.DrawString(valori[i].High.ToString(), font, Brushes.Black, new RectangleF(currentX, currentY, columnWidth, rowHeight), format);
                currentX += columnWidth;

                e.Graphics.DrawRectangle(Pens.Black, currentX, currentY, columnWidth, rowHeight);
                e.Graphics.DrawString(valori[i].Low.ToString(), font, Brushes.Black, new RectangleF(currentX, currentY, columnWidth, rowHeight), format);
                currentX += columnWidth;

                e.Graphics.DrawRectangle(Pens.Black, currentX, currentY, columnWidth, rowHeight);
                e.Graphics.DrawString(valori[i].Close.ToString(), font, Brushes.Black, new RectangleF(currentX, currentY, columnWidth, rowHeight), format);

                currentY += rowHeight;

                if (currentY + rowHeight > inaltimeFoaie)
                {
                    e.HasMorePages = true;
                    break;
                }
            }
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDocument.Print();
        }
    
    }
}
