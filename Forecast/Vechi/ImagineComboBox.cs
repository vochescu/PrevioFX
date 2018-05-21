using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forecast
{

    public partial class ImagineComboBox : ComboBox
    {
        public ImagineComboBox()
        {
            InitializeComponent();

            this.DrawMode = DrawMode.OwnerDrawVariable;
            this.DrawItem += new DrawItemEventHandler(ImgComboBoxDrawItem);
        }

        void ImgComboBoxDrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            CbItem currentItem = null;

            Rectangle rect = new Rectangle(2, e.Bounds.Top + 2,
                e.Bounds.Height, e.Bounds.Height - 4);
            try
            {
                currentItem = (CbItem)this.Items[e.Index];
            }
            catch (InvalidCastException exception)
            {
                Console.WriteLine(exception);
                throw;
            }

            e.Graphics.DrawImage(currentItem.ItemImage, rect);
            e.Graphics.DrawString(currentItem.Description.ToString(), this.Font,
                new SolidBrush(this.ForeColor),
                new Rectangle(e.Bounds.X + rect.Width + 2,
                    e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
        }
    }

    public class CbItem
    {
        public Image ItemImage { get; set; }
        public String Description { get; set; }
    }
}
