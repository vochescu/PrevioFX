using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forecast.GraficEntities
{
    class Line
    {
        private PictureBox mGrafic;
        public Rectangle line;
        public bool allowDeformingDuringMovement = true;
        private bool mIsClick = false;
        private bool mMove = false;
        private int oldX;
        private int oldY;
        private int sizeNodeRect = 5;
        private Bitmap mBmp = null;
        private PosSizableLine nodeSelected = PosSizableLine.None;

        private enum PosSizableLine
        {
            Left,
            Right,
            None

        };

        public Line(Rectangle r)
        {
            line = r;
            mIsClick = false;
        }

        public void Draw(Graphics g)
        {
            g.DrawRectangle(new Pen(Color.Red), line);

            foreach (PosSizableLine pos in Enum.GetValues(typeof(PosSizableLine)))
            {
                g.DrawRectangle(new Pen(Color.Red), GetRect(pos));
            }
        }

        public void SetBitmapFile(string filename)
        {
            this.mBmp = new Bitmap(filename);
        }

        public void SetBitmap(Bitmap bmp)
        {
            this.mBmp = bmp;
        }

        public void SetPictureBox(PictureBox g)
        {
            this.mGrafic = g;
            mGrafic.MouseDown += new MouseEventHandler(mGrafic_MouseDown);
            mGrafic.MouseUp += new MouseEventHandler(mGrafic_MouseUp);
            mGrafic.MouseMove += new MouseEventHandler(mGrafic_MouseMove);
            mGrafic.Paint += new PaintEventHandler(mGrafic_Paint);
        }

        private void mGrafic_Paint(object sender, PaintEventArgs e)
        {

            try
            {
                Draw(e.Graphics);
            }
            catch (Exception exp)
            {
                System.Console.WriteLine(exp.Message);
            }

        }

        private void mGrafic_MouseDown(object sender, MouseEventArgs e)
        {
            mIsClick = true;

            nodeSelected = PosSizableLine.None;
            nodeSelected = GetNodeSelectable(e.Location);

            if (line.Contains(new Point(e.X, e.Y)))
            {
                mMove = true;
            }
            oldX = e.X;
            oldY = e.Y;
        }

        private void mGrafic_MouseUp(object sender, MouseEventArgs e)
        {
            mIsClick = false;
            mMove = false;
        }

        private void mGrafic_MouseMove(object sender, MouseEventArgs e)
        {
            ChangeCursor(e.Location);
            if (mIsClick == false)
            {
                return;
            }

            Rectangle backupRect = line;

            switch (nodeSelected)
            {
                case PosSizableLine.Left:
                    line.X += e.X - oldX;
                    line.Y += e.Y - oldY;
                    line.Height =1;
                    break;
                
                case PosSizableLine.Right:
                    line.Width += e.X - oldX;
                    break;
                    
                default:
                    if (mMove)
                    {
                        line.X = line.X + e.X - oldX;
                        line.Y = line.Y + e.Y - oldY;
                    }
                    break;
            }
            oldX = e.X;
            oldY = e.Y;

            if (line.Width < 1 || line.Height < 1)
            {
                line = backupRect;
            }

            TestIfRectInsideArea();

            mGrafic.Invalidate();
        }

        private void TestIfRectInsideArea()
        {
            if (line.X < 0) line.X = 0;
            if (line.Y < 0) line.Y = 0;
            if (line.Width <= 0) line.Width = 1;
            if (line.Height <= 0) line.Height = 1;

            if (line.X + line.Width > mGrafic.Width)
            {
                line.Width = mGrafic.Width - line.X - 1;
                if (allowDeformingDuringMovement == false)
                {
                    mIsClick = false;
                }
            }
            if (line.Y + line.Height > mGrafic.Height)
            {
                line.Height = mGrafic.Height - line.Y - 1;
                if (allowDeformingDuringMovement == false)
                {
                    mIsClick = false;
                }
            }
        }

        private Rectangle CreateRectSizableNode(int x, int y)
        {
            return new Rectangle(x - sizeNodeRect / 2, y - sizeNodeRect / 2, sizeNodeRect, sizeNodeRect);
        }

        private Rectangle GetRect(PosSizableLine p)
        {
            switch (p)
            {
                case PosSizableLine.Left:
                    return CreateRectSizableNode(line.X, line.Y);
                    

                case PosSizableLine.Right:
                    return CreateRectSizableNode(line.X + line.Width, line.Y);

                default:
                    return new Rectangle();
            }
        }

        private PosSizableLine GetNodeSelectable(Point p)
        {
            foreach (PosSizableLine r in Enum.GetValues(typeof(PosSizableLine)))
            {
                if (GetRect(r).Contains(p))
                {
                    return r;
                }
            }
            return PosSizableLine.None;
        }

        private void ChangeCursor(Point p)
        {
            mGrafic.Cursor = GetCursor(GetNodeSelectable(p));
        }

        private Cursor GetCursor(PosSizableLine p)
        {
            switch (p)
            {
                case PosSizableLine.Left:
                    return Cursors.Hand;
                    
                case PosSizableLine.Right:
                    return Cursors.SizeWE;
                    
                default:
                    return Cursors.Default;
            }
        }
    }
}
