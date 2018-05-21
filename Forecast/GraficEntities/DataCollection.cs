using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast
{
    public class DataCollection
    {
        private ArrayList dataSeriesList;
        private int dataSeriesIndex = 0;
        public DataCollection()
        {
            dataSeriesList = new ArrayList();
        }
        public ArrayList DataSeriesList
        {
            get { return dataSeriesList; }
            set { dataSeriesList = value; }
        }
        public int DataSeriesIndex
        {
            get { return dataSeriesIndex; }
            set { dataSeriesIndex = value; }
        }
        public void Add(DataSeries ds)
        {
            dataSeriesList.Add(ds);
            if (ds.SeriesName == "Default Name")
            {
                ds.SeriesName = "DataSeries" +
                                dataSeriesList.Count.ToString();
            }
        }
        public void Insert(int dataSeriesIndex, DataSeries ds)
        {
            dataSeriesList.Insert(dataSeriesIndex, ds);
            if (ds.SeriesName == "Default Name")
            {
                dataSeriesIndex = dataSeriesIndex + 1;
                ds.SeriesName = "DataSeries" +
                dataSeriesIndex.ToString();
            }
        }
        public void Remove(string dataSeriesName)
        {
            if (dataSeriesList != null)
            {
                for (int i = 0; i < dataSeriesList.Count; i++)
                {
                    DataSeries ds = (DataSeries)dataSeriesList[i];
                    if (ds.SeriesName == dataSeriesName)
                    {
                        dataSeriesList.RemoveAt(i);
                    }
                }
            }
        }
        public void RemoveAll()
        {
            dataSeriesList.Clear();
        }
        public void AddLines(Graphics g, ChartStyle cs, XAxis xa,YAxis ya, Y2Axis y2a)
        {
            // Plot lines:
            foreach (DataSeries ds in DataSeriesList)
            {
                if (ds.LineStyle.IsVisible == true)
                {
                    Pen aPen = new Pen(ds.LineStyle.LineColor,
                        ds.LineStyle.Thickness);
                    aPen.DashStyle = ds.LineStyle.Pattern;
                    if (ds.LineStyle.PlotMethod == LineStyle.PlotLinesMethodEnum.Lines)
                    {
                        for (int i = 1; i < ds.PointList.Count; i++)
                        {
                            if (!ds.IsY2Data)
                            {
                                g.DrawLine(aPen,cs.Point2D((PointF)ds.PointList[i - 1],xa,ya),cs.Point2D((PointF)ds.PointList[i],xa,ya));
                            }
                            else
                            {
                                g.DrawLine(aPen,
                                    cs.Point2DY2((PointF)ds.PointList[i - 1],xa,y2a),
                                    cs.Point2DY2((PointF)ds.PointList[i],xa,y2a));
                            }
                        }
                    }
                    else if (ds.LineStyle.PlotMethod ==
                             LineStyle.PlotLinesMethodEnum.Splines)
                    {
                        ArrayList al = new ArrayList();
                        for (int i = 0; i < ds.PointList.Count; i++)
                        {
                            PointF pt = (PointF)ds.PointList[i];
                            if (!ds.IsY2Data)
                            {
                                if (pt.X >= xa.XLimMin &&pt.X <= xa.XLimMax &&
                                    pt.Y >= ya.YLimMin &&
                                    pt.Y <= ya.YLimMax)
                                {
                                    al.Add(pt);
                                }
                            }
                            else
                            {
                                if (pt.X >= xa.XLimMin &&
                                    pt.X <= xa.XLimMax &&
                                    pt.Y >= y2a.Y2LimMin &&
                                    pt.Y <= y2a.Y2LimMax)
                                {
                                    al.Add(pt);
                                }

                            }
                        }
                        PointF[] pts = new PointF[al.Count];
                        for (int i = 0; i < pts.Length; i++)
                        {
                            if (!ds.IsY2Data)
                            {
                                pts[i] = cs.Point2D((PointF)(al[i]),xa,ya);
                            }
                            else
                            {
                                pts[i] = cs.Point2DY2((PointF)(al[i]),xa,y2a);
                            }
                        }
                        g.DrawCurve(aPen, pts);
                    }
                    aPen.Dispose();
                }
            }
            // Plot Symbols:
            foreach (DataSeries ds in DataSeriesList)
            {
                for (int i = 0; i < ds.PointList.Count; i++)
                {
                    PointF pt = (PointF)ds.PointList[i];
                    if (!ds.IsY2Data)
                    {
                        if (pt.X >= xa.XLimMin && pt.X <= xa.XLimMax &&
                            pt.Y >= ya.YLimMin && pt.Y <= ya.YLimMax)
                        {
                            // ds.symbolStyle.DrawSymbol(g, cs.Point2D((PointF)ds.PointList[i],xa,ya));
                        }
                    }
                    else
                    {
                        if (pt.X >= xa.XLimMin && pt.X <= xa.XLimMax &&
                            pt.Y >= y2a.Y2LimMin && pt.Y <= y2a.Y2LimMax)
                        {
                            // ss.SymbolStyle.DrawSymbol(g,cs.Point2DY2((PointF)ds.PointList[i]));
                        }
                    }
                }
            }
        }
    }
} 

