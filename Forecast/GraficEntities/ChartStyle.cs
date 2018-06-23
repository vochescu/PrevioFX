using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Forecast
{
    public class ChartStyle
    {
        private Grafic chart2d;
        private Rectangle chartArea;
        private Rectangle plotArea;

        public ChartStyle(Grafic ct2d)
        {
            chart2d = ct2d;
            chartArea = chart2d.ClientRectangle;
            plotArea = chartArea;
        }

        public Rectangle ChartArea
        {
            get { return chartArea; }
            set { chartArea = value; }
        }

        public Rectangle PlotArea
        {
            get { return plotArea; }
            set { plotArea = value; }
        }

        public void AddChartStyle(Graphics g, ChartArea ca, XAxis xa, YAxis ya, Y2Axis y2a, Grid gd, XYLabel lb, Title2D tl)
        {
            SetPlotArea(g, xa, ya, y2a, gd, lb, tl);

            Pen aPen = new Pen(Color.DarkSlateGray, 1f);
            SolidBrush aBrush = new SolidBrush(Color.White);
            g.FillRectangle(aBrush, ChartArea);
            g.DrawRectangle(aPen, ChartArea);
            aPen = new Pen(ca.PlotBorderColor, 1f);

            aBrush = new SolidBrush(Color.White);
            g.FillRectangle(aBrush, PlotArea);
            g.DrawRectangle(aPen, PlotArea);

            SizeF tickFontSize = g.MeasureString("A", lb.TickFont);

            float fX, fY;
            if (gd.IsYGrid == true)
            {
                aPen = new Pen(gd.GridColor, 1f);
                aPen.DashStyle = gd.GridPattern;
                for (fX = xa.XLimMin + xa.XTick; fX < xa.XLimMax; fX += xa.XTick)
                {
                    g.DrawLine(aPen, Point2D(new PointF(fX, ya.YLimMin), xa, ya), Point2D(new PointF(fX,
                        ya.YLimMax), xa, ya));
                }

                if (gd.IsXGrid == true)
                {
                    aPen = new Pen(gd.GridColor, 1f);
                    aPen.DashStyle = gd.GridPattern;
                    for (fY = ya.YLimMin + ya.YTick; fY < ya.YLimMax; fY += ya.YTick)
                    {
                        g.DrawLine(aPen, Point2D(new PointF(xa.XLimMin, fY), xa, ya), 
                            Point2D(new PointF(xa.XLimMax, fY), xa, ya));
                    }
                }
                

                aBrush = new SolidBrush(Color.DarkSlateGray);
                int i = 0;
                for (fX = xa.XLimMin; fX <= xa.XLimMax; fX += xa.XTick)
                {
                    PointF yAxisPoint = Point2D(new PointF(fX,
                        ya.YLimMin), xa, ya);
                    g.DrawLine(Pens.DarkSlateGray, yAxisPoint, new PointF(
                        yAxisPoint.X, yAxisPoint.Y - 5f));
                    StringFormat sFormat = new StringFormat();
                    sFormat.Alignment = StringAlignment.Far;
                    SizeF sizeXTick = g.MeasureString(xa.ListaDate[i].ToShortDateString(),
                        lb.TickFont);
                    g.DrawString(xa.ListaDate[i].ToShortDateString(), lb.TickFont, aBrush,
                        new PointF(yAxisPoint.X + sizeXTick.Width / 2,
                            yAxisPoint.Y + 4f), sFormat);
                    i += (int)xa.XTick;
                }
                aBrush = new SolidBrush(Color.DarkSlateGray);

                for (fY = ya.YLimMin; fY <= ya.YLimMax; fY += ya.YTick)
                {
                    PointF xAxisPoint = Point2D(new PointF(xa.XLimMin, fY), xa, ya);
                    g.DrawLine(Pens.DarkSlateGray, xAxisPoint, new PointF(xAxisPoint.X + 5f, xAxisPoint.Y));
                    StringFormat sFormat = new StringFormat();
                    sFormat.Alignment = StringAlignment.Far;
                    g.DrawString(fY.ToString(), lb.TickFont, aBrush, new PointF(xAxisPoint.X - 3f, xAxisPoint.Y - tickFontSize.Height/2), sFormat);
                }

                if (y2a.IsY2Axis)
                {
                    for (fY = y2a.Y2LimMin;
                        fY <= y2a.Y2LimMax;
                        fY += y2a.Y2Tick)
                    {
                        PointF x2AxisPoint = Point2DY2(new
                            PointF(xa.XLimMax, fY), xa, y2a);
                        g.DrawLine(Pens.DarkSlateGray, x2AxisPoint,
                            new PointF(x2AxisPoint.X - 5f,
                                x2AxisPoint.Y));
                        StringFormat sFormat = new StringFormat();
                        sFormat.Alignment = StringAlignment.Near;
                        g.DrawString(fY.ToString(), lb.TickFont,
                            aBrush, new PointF(x2AxisPoint.X + 3f,
                                x2AxisPoint.Y - tickFontSize.Height / 2),
                            sFormat);
                    }
                }
                aPen.Dispose();
                aBrush.Dispose();
                AddLabels(g, xa, ya, y2a, gd, lb, tl);
            }
        }

        private void SetPlotArea(Graphics g, XAxis xa, YAxis ya, Y2Axis y2a, Grid gd, XYLabel lb, Title2D tl)
        {
            float xOffset = ChartArea.Width / 30.0f;

            float yOffset = ChartArea.Height / 30.0f;
            SizeF labelFontSize = g.MeasureString("A", lb.LabelFont);

            SizeF titleFontSize = g.MeasureString("A", tl.TitleFont);
            if (tl.Title.ToUpper() == "NO TITLE")
            {
                titleFontSize.Width = 8f;
                titleFontSize.Height = 8f;
            }
            float xSpacing = xOffset / 3.0f;
            float ySpacing = yOffset / 3.0f;
            SizeF tickFontSize = g.MeasureString("A", lb.TickFont);
            float tickSpacing = 2f;

            SizeF yTickSize = g.MeasureString(ya.YLimMin.ToString(),
                lb.TickFont);
            for (float yTick = ya.YLimMin; yTick <= ya.YLimMax; yTick += ya.YTick)
            {
                SizeF tempSize = g.MeasureString(yTick.ToString(), lb.TickFont);
                if (yTickSize.Width < tempSize.Width)
                {
                    yTickSize = tempSize;
                }
            }

            float leftMargin = xOffset + labelFontSize.Width + xSpacing + yTickSize.Width + tickSpacing;

            float rightMargin = xOffset;

            float topMargin = yOffset + titleFontSize.Height + ySpacing;

            float bottomMargin = yOffset + labelFontSize.Height + ySpacing + tickSpacing + tickFontSize.Height;
            if (!y2a.IsY2Axis)
            {
                int plotX = ChartArea.X + (int) leftMargin;
                int plotY = ChartArea.Y + (int) topMargin;
                int plotWidth = ChartArea.Width - (int) leftMargin - 2 * (int) rightMargin;
                int plotHeight = ChartArea.Height - (int) topMargin - (int) bottomMargin;
                PlotArea = new Rectangle(plotX, plotY, plotWidth, plotHeight);
            }
            else
            {
                SizeF y2TickSize = g.MeasureString(y2a.Y2LimMin.ToString(), lb.TickFont);
                for (float y2Tick = y2a.Y2LimMin; y2Tick <= y2a.Y2LimMax; y2Tick += y2a.Y2Tick)
                {
                    SizeF tempSize2 = g.MeasureString(
                        y2Tick.ToString(), lb.TickFont);
                    if (y2TickSize.Width < tempSize2.Width)
                    {
                        y2TickSize = tempSize2;
                    }
                }
                rightMargin = xOffset + labelFontSize.Width + xSpacing + y2TickSize.Width + tickSpacing;
                int plotX = ChartArea.X + (int) leftMargin;
                int plotY = ChartArea.Y + (int) topMargin;
                int plotWidth = ChartArea.Width - (int) leftMargin - (int) rightMargin;
                int plotHeight = ChartArea.Height - (int) topMargin - (int) bottomMargin;
                PlotArea = new Rectangle(plotX, plotY, plotWidth, plotHeight);
            }
        }

        private void AddLabels(Graphics g, XAxis xa, YAxis ya, Y2Axis y2a, Grid gd, XYLabel lb, Title2D tl)
        {
            float xOffset = ChartArea.Width / 30.0f;
            float yOffset = ChartArea.Height / 30.0f;
            SizeF labelFontSize = g.MeasureString("A", lb.LabelFont);
            SizeF titleFontSize = g.MeasureString("A", tl.TitleFont);
           
            SolidBrush aBrush = new SolidBrush(Color.DarkSlateGray);
            SizeF stringSize = g.MeasureString(lb.XLabel,
                lb.LabelFont);
            g.DrawString(lb.XLabel, lb.LabelFont, aBrush,
                new Point(PlotArea.Left + PlotArea.Width / 2 - (int) stringSize.Width / 2, ChartArea.Bottom - (int) yOffset - (int) labelFontSize.Height));

            StringFormat sFormat = new StringFormat();
            sFormat.Alignment = StringAlignment.Center;
            stringSize = g.MeasureString(lb.YLabel, lb.LabelFont);

            GraphicsState gState = g.Save();
            g.TranslateTransform(ChartArea.X + xOffset, ChartArea.Y + yOffset + titleFontSize.Height + yOffset / 3 + PlotArea.Height / 2);
            g.RotateTransform(-90);
            g.DrawString(lb.YLabel, lb.LabelFont, aBrush, 0, 0, sFormat);

            g.Restore(gState);

            if (y2a.IsY2Axis)
            {
                stringSize = g.MeasureString(lb.Y2Label, lb.LabelFont);
                GraphicsState gState2 = g.Save();
                g.TranslateTransform(ChartArea.X + ChartArea.Width - xOffset - labelFontSize.Width, ChartArea.Y + yOffset + titleFontSize.Height + yOffset / 3 + PlotArea.Height / 2);
                g.RotateTransform(-90);
                g.DrawString(lb.Y2Label, lb.LabelFont, aBrush, 0, 0, sFormat);
                g.Restore(gState2);
            }
           
            aBrush = new SolidBrush(Color.DarkSlateGray);
            stringSize = g.MeasureString(tl.Title, tl.TitleFont);
            if (tl.Title.ToUpper() != "NO TITLE")
            {
                g.DrawString(tl.Title, tl.TitleFont, aBrush,
                    new Point(PlotArea.Left + PlotArea.Width / 2 -
                              (int) stringSize.Width / 2, ChartArea.Top +
                                                          (int) yOffset));
            }
            aBrush.Dispose();
        }

        public PointF Point2DY2(PointF pt, XAxis xa, Y2Axis y2a)
        {
            PointF aPoint = new PointF();
            if (pt.X < xa.XLimMin || pt.X > xa.XLimMax ||
                pt.Y < y2a.Y2LimMin || pt.Y > y2a.Y2LimMax)
            {
                pt.X = Single.NaN;
                pt.Y = Single.NaN;
            }
            aPoint.X = PlotArea.X + (pt.X - xa.XLimMin) *
                       PlotArea.Width / (xa.XLimMax - xa.XLimMin);
            aPoint.Y = PlotArea.Bottom - (pt.Y - y2a.Y2LimMin) *
                       PlotArea.Height / (y2a.Y2LimMax - y2a.Y2LimMin);
            return aPoint;
        }

        public PointF Point2D(PointF pt, XAxis xa, YAxis ya)
        {
            PointF aPoint = new PointF();
            if (pt.X < xa.XLimMin || pt.X > xa.XLimMax ||
                pt.Y < ya.YLimMin || pt.Y > ya.YLimMax)
            {
                pt.X = Single.NaN;
                pt.Y = Single.NaN;
            }
            aPoint.X = PlotArea.X + (pt.X - xa.XLimMin) *
                       PlotArea.Width / (xa.XLimMax - xa.XLimMin);
            aPoint.Y = PlotArea.Bottom - (pt.Y - ya.YLimMin) *
                       PlotArea.Height / (ya.YLimMax - ya.YLimMin);
            return aPoint;
        }
    }
}