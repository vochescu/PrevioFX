namespace Forecast
{
    partial class ChartUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartUserControl));
            Forecast.DataCollection dataCollection2 = new Forecast.DataCollection();
            this.instrumenteToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.instrumenteToolStrip = new System.Windows.Forms.ToolStrip();
            this.graficLinieTsBtn = new System.Windows.Forms.ToolStripButton();
            this.graficCandleTsBtn = new System.Windows.Forms.ToolStripButton();
            this.graficAreaTsBtn = new System.Windows.Forms.ToolStripButton();
            this.indicatoriTsBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.medieMobilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medieMobilaExponentialaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volatilitateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.printScreenTsBtn = new System.Windows.Forms.ToolStripButton();
            this.fullScreenTsBtn = new System.Windows.Forms.ToolStripButton();
            this.zoomInTsBtn = new System.Windows.Forms.ToolStripButton();
            this.zoomOutTsBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.eraseTsBtn = new System.Windows.Forms.ToolStripButton();
            this.textTsBtn = new System.Windows.Forms.ToolStripButton();
            this.drawTsBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.linieTsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.dreptunghiTsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.triunghiTsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.elipsaTsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.setariTsBtn = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.graficUC = new Forecast.Grafic();
            this.panel2.SuspendLayout();
            this.instrumenteToolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.instrumenteToolStrip);
            this.panel2.Location = new System.Drawing.Point(0, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(695, 33);
            this.panel2.TabIndex = 8;
            // 
            // instrumenteToolStrip
            // 
            this.instrumenteToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(105)))), ((int)(((byte)(144)))));
            this.instrumenteToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graficLinieTsBtn,
            this.graficCandleTsBtn,
            this.graficAreaTsBtn,
            this.indicatoriTsBtn,
            this.toolStripSeparator2,
            this.printScreenTsBtn,
            this.fullScreenTsBtn,
            this.zoomInTsBtn,
            this.zoomOutTsBtn,
            this.toolStripSeparator1,
            this.eraseTsBtn,
            this.textTsBtn,
            this.drawTsBtn,
            this.toolStripSeparator3,
            this.setariTsBtn});
            this.instrumenteToolStrip.Location = new System.Drawing.Point(0, 0);
            this.instrumenteToolStrip.Name = "instrumenteToolStrip";
            this.instrumenteToolStrip.Size = new System.Drawing.Size(695, 25);
            this.instrumenteToolStrip.TabIndex = 8;
            this.instrumenteToolStrip.Text = "toolStrip1";
            // 
            // graficLinieTsBtn
            // 
            this.graficLinieTsBtn.BackColor = System.Drawing.Color.MintCream;
            this.graficLinieTsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.graficLinieTsBtn.Image = ((System.Drawing.Image)(resources.GetObject("graficLinieTsBtn.Image")));
            this.graficLinieTsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.graficLinieTsBtn.Margin = new System.Windows.Forms.Padding(0, 1, 5, 1);
            this.graficLinieTsBtn.Name = "graficLinieTsBtn";
            this.graficLinieTsBtn.Size = new System.Drawing.Size(23, 23);
            this.graficLinieTsBtn.Text = "Grafic de tip linie";
            this.graficLinieTsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // graficCandleTsBtn
            // 
            this.graficCandleTsBtn.BackColor = System.Drawing.Color.MintCream;
            this.graficCandleTsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.graficCandleTsBtn.Image = ((System.Drawing.Image)(resources.GetObject("graficCandleTsBtn.Image")));
            this.graficCandleTsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.graficCandleTsBtn.Margin = new System.Windows.Forms.Padding(0, 1, 5, 1);
            this.graficCandleTsBtn.Name = "graficCandleTsBtn";
            this.graficCandleTsBtn.Size = new System.Drawing.Size(23, 23);
            this.graficCandleTsBtn.Text = "Grafic de tip candlestick";
            this.graficCandleTsBtn.Click += new System.EventHandler(this.graficCandleTsBtn_Click);
            // 
            // graficAreaTsBtn
            // 
            this.graficAreaTsBtn.BackColor = System.Drawing.Color.MintCream;
            this.graficAreaTsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.graficAreaTsBtn.Image = ((System.Drawing.Image)(resources.GetObject("graficAreaTsBtn.Image")));
            this.graficAreaTsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.graficAreaTsBtn.Margin = new System.Windows.Forms.Padding(0, 1, 5, 1);
            this.graficAreaTsBtn.Name = "graficAreaTsBtn";
            this.graficAreaTsBtn.Size = new System.Drawing.Size(23, 23);
            this.graficAreaTsBtn.Text = "Grafic de tip suprafata";
            // 
            // indicatoriTsBtn
            // 
            this.indicatoriTsBtn.BackColor = System.Drawing.Color.MintCream;
            this.indicatoriTsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.indicatoriTsBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medieMobilaToolStripMenuItem,
            this.medieMobilaExponentialaToolStripMenuItem,
            this.volatilitateToolStripMenuItem,
            this.volumToolStripMenuItem});
            this.indicatoriTsBtn.Image = ((System.Drawing.Image)(resources.GetObject("indicatoriTsBtn.Image")));
            this.indicatoriTsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.indicatoriTsBtn.Margin = new System.Windows.Forms.Padding(0, 1, 5, 1);
            this.indicatoriTsBtn.Name = "indicatoriTsBtn";
            this.indicatoriTsBtn.Size = new System.Drawing.Size(29, 23);
            this.indicatoriTsBtn.Text = "Indicatori";
            // 
            // medieMobilaToolStripMenuItem
            // 
            this.medieMobilaToolStripMenuItem.Name = "medieMobilaToolStripMenuItem";
            this.medieMobilaToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.medieMobilaToolStripMenuItem.Text = "Medie mobila";
            // 
            // medieMobilaExponentialaToolStripMenuItem
            // 
            this.medieMobilaExponentialaToolStripMenuItem.Name = "medieMobilaExponentialaToolStripMenuItem";
            this.medieMobilaExponentialaToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.medieMobilaExponentialaToolStripMenuItem.Text = "Medie mobila exponentiala";
            // 
            // volatilitateToolStripMenuItem
            // 
            this.volatilitateToolStripMenuItem.Name = "volatilitateToolStripMenuItem";
            this.volatilitateToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.volatilitateToolStripMenuItem.Text = "Volatilitate";
            // 
            // volumToolStripMenuItem
            // 
            this.volumToolStripMenuItem.Name = "volumToolStripMenuItem";
            this.volumToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.volumToolStripMenuItem.Text = "Volum";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // printScreenTsBtn
            // 
            this.printScreenTsBtn.BackColor = System.Drawing.Color.MintCream;
            this.printScreenTsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printScreenTsBtn.Image = ((System.Drawing.Image)(resources.GetObject("printScreenTsBtn.Image")));
            this.printScreenTsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printScreenTsBtn.Margin = new System.Windows.Forms.Padding(0, 1, 5, 1);
            this.printScreenTsBtn.Name = "printScreenTsBtn";
            this.printScreenTsBtn.Size = new System.Drawing.Size(23, 23);
            this.printScreenTsBtn.Text = "Snapshot";
            // 
            // fullScreenTsBtn
            // 
            this.fullScreenTsBtn.BackColor = System.Drawing.Color.MintCream;
            this.fullScreenTsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fullScreenTsBtn.Image = ((System.Drawing.Image)(resources.GetObject("fullScreenTsBtn.Image")));
            this.fullScreenTsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fullScreenTsBtn.Margin = new System.Windows.Forms.Padding(0, 1, 5, 1);
            this.fullScreenTsBtn.Name = "fullScreenTsBtn";
            this.fullScreenTsBtn.Size = new System.Drawing.Size(23, 23);
            this.fullScreenTsBtn.Text = "Extinde pe tot ecranul";
            // 
            // zoomInTsBtn
            // 
            this.zoomInTsBtn.BackColor = System.Drawing.Color.MintCream;
            this.zoomInTsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomInTsBtn.Image = ((System.Drawing.Image)(resources.GetObject("zoomInTsBtn.Image")));
            this.zoomInTsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomInTsBtn.Margin = new System.Windows.Forms.Padding(0, 1, 5, 1);
            this.zoomInTsBtn.Name = "zoomInTsBtn";
            this.zoomInTsBtn.Size = new System.Drawing.Size(23, 23);
            this.zoomInTsBtn.Text = "Mareste";
            // 
            // zoomOutTsBtn
            // 
            this.zoomOutTsBtn.BackColor = System.Drawing.Color.MintCream;
            this.zoomOutTsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomOutTsBtn.Image = ((System.Drawing.Image)(resources.GetObject("zoomOutTsBtn.Image")));
            this.zoomOutTsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomOutTsBtn.Margin = new System.Windows.Forms.Padding(0, 1, 5, 1);
            this.zoomOutTsBtn.Name = "zoomOutTsBtn";
            this.zoomOutTsBtn.Size = new System.Drawing.Size(23, 23);
            this.zoomOutTsBtn.Text = "Micsoreaza";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // eraseTsBtn
            // 
            this.eraseTsBtn.BackColor = System.Drawing.Color.MintCream;
            this.eraseTsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eraseTsBtn.Image = ((System.Drawing.Image)(resources.GetObject("eraseTsBtn.Image")));
            this.eraseTsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eraseTsBtn.Margin = new System.Windows.Forms.Padding(0, 1, 5, 1);
            this.eraseTsBtn.Name = "eraseTsBtn";
            this.eraseTsBtn.Size = new System.Drawing.Size(23, 23);
            this.eraseTsBtn.Text = "Sterge";
            // 
            // textTsBtn
            // 
            this.textTsBtn.BackColor = System.Drawing.Color.MintCream;
            this.textTsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.textTsBtn.Image = ((System.Drawing.Image)(resources.GetObject("textTsBtn.Image")));
            this.textTsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.textTsBtn.Margin = new System.Windows.Forms.Padding(0, 1, 5, 1);
            this.textTsBtn.Name = "textTsBtn";
            this.textTsBtn.Size = new System.Drawing.Size(23, 23);
            this.textTsBtn.Text = "Text";
            // 
            // drawTsBtn
            // 
            this.drawTsBtn.BackColor = System.Drawing.Color.MintCream;
            this.drawTsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawTsBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linieTsBtn,
            this.dreptunghiTsBtn,
            this.triunghiTsBtn,
            this.elipsaTsBtn});
            this.drawTsBtn.Image = ((System.Drawing.Image)(resources.GetObject("drawTsBtn.Image")));
            this.drawTsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawTsBtn.Margin = new System.Windows.Forms.Padding(0, 1, 5, 1);
            this.drawTsBtn.Name = "drawTsBtn";
            this.drawTsBtn.Size = new System.Drawing.Size(29, 23);
            this.drawTsBtn.Text = "Deseneaza";
            // 
            // linieTsBtn
            // 
            this.linieTsBtn.Image = ((System.Drawing.Image)(resources.GetObject("linieTsBtn.Image")));
            this.linieTsBtn.Name = "linieTsBtn";
            this.linieTsBtn.Size = new System.Drawing.Size(152, 22);
            this.linieTsBtn.Text = "Linie";
            // 
            // dreptunghiTsBtn
            // 
            this.dreptunghiTsBtn.Image = ((System.Drawing.Image)(resources.GetObject("dreptunghiTsBtn.Image")));
            this.dreptunghiTsBtn.Name = "dreptunghiTsBtn";
            this.dreptunghiTsBtn.Size = new System.Drawing.Size(134, 22);
            this.dreptunghiTsBtn.Text = "Dreptunghi";
            // 
            // triunghiTsBtn
            // 
            this.triunghiTsBtn.Image = ((System.Drawing.Image)(resources.GetObject("triunghiTsBtn.Image")));
            this.triunghiTsBtn.Name = "triunghiTsBtn";
            this.triunghiTsBtn.Size = new System.Drawing.Size(134, 22);
            this.triunghiTsBtn.Text = "Triunghi";
            // 
            // elipsaTsBtn
            // 
            this.elipsaTsBtn.Image = ((System.Drawing.Image)(resources.GetObject("elipsaTsBtn.Image")));
            this.elipsaTsBtn.Name = "elipsaTsBtn";
            this.elipsaTsBtn.Size = new System.Drawing.Size(134, 22);
            this.elipsaTsBtn.Text = "Elipsa";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // setariTsBtn
            // 
            this.setariTsBtn.BackColor = System.Drawing.Color.MintCream;
            this.setariTsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.setariTsBtn.Image = ((System.Drawing.Image)(resources.GetObject("setariTsBtn.Image")));
            this.setariTsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.setariTsBtn.Margin = new System.Windows.Forms.Padding(0, 1, 5, 1);
            this.setariTsBtn.Name = "setariTsBtn";
            this.setariTsBtn.Size = new System.Drawing.Size(23, 23);
            this.setariTsBtn.Text = "Setari";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.graficUC);
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 275);
            this.panel1.TabIndex = 7;
            // 
            // graficUC
            // 
            this.graficUC.C2ChartArea.ChartBackColor = System.Drawing.SystemColors.Control;
            this.graficUC.C2ChartArea.ChartBorderColor = System.Drawing.SystemColors.Control;
            this.graficUC.C2ChartArea.PlotBackColor = System.Drawing.Color.White;
            this.graficUC.C2ChartArea.PlotBorderColor = System.Drawing.Color.Black;
            dataCollection2.DataSeriesIndex = 0;
            dataCollection2.DataSeriesList = ((System.Collections.ArrayList)(resources.GetObject("dataCollection2.DataSeriesList")));
            this.graficUC.C2DataCollection = dataCollection2;
            this.graficUC.C2Grid.GridColor = System.Drawing.Color.LightGray;
            this.graficUC.C2Grid.GridPattern = System.Drawing.Drawing2D.DashStyle.Solid;
            this.graficUC.C2Grid.GridThickness = 1F;
            this.graficUC.C2Grid.IsXGrid = true;
            this.graficUC.C2Grid.IsYGrid = true;
            this.graficUC.C2Label.LabelFont = new System.Drawing.Font("Arial", 10F);
            this.graficUC.C2Label.LabelFontColor = System.Drawing.Color.Black;
            this.graficUC.C2Label.TickFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.graficUC.C2Label.TickFontColor = System.Drawing.Color.Black;
            this.graficUC.C2Label.XLabel = "X Axis";
            this.graficUC.C2Label.Y2Label = "Y2 Axis";
            this.graficUC.C2Label.YLabel = "Y Axis";
            this.graficUC.C2Title.Title = "Title";
            this.graficUC.C2Title.TitleFont = new System.Drawing.Font("Arial", 12F);
            this.graficUC.C2Title.TitleFontColor = System.Drawing.Color.Black;
            this.graficUC.C2XAxis.XLimMax = 10F;
            this.graficUC.C2XAxis.XLimMin = 0F;
            this.graficUC.C2XAxis.XTick = 2F;
            this.graficUC.C2Y2Axis.IsY2Axis = false;
            this.graficUC.C2Y2Axis.Y2LimMax = 100F;
            this.graficUC.C2Y2Axis.Y2LimMin = 0F;
            this.graficUC.C2Y2Axis.Y2Tick = 20F;
            this.graficUC.C2YAxis.YLimMax = 10F;
            this.graficUC.C2YAxis.YLimMin = 0F;
            this.graficUC.C2YAxis.YTick = 2F;
            this.graficUC.Location = new System.Drawing.Point(3, 11);
            this.graficUC.Name = "graficUC";
            this.graficUC.Size = new System.Drawing.Size(689, 261);
            this.graficUC.TabIndex = 0;
            // 
            // ChartUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ChartUserControl";
            this.Size = new System.Drawing.Size(695, 307);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.instrumenteToolStrip.ResumeLayout(false);
            this.instrumenteToolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip instrumenteToolTip;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip instrumenteToolStrip;
        private System.Windows.Forms.ToolStripButton graficLinieTsBtn;
        private System.Windows.Forms.ToolStripButton graficCandleTsBtn;
        private System.Windows.Forms.ToolStripButton graficAreaTsBtn;
        private System.Windows.Forms.ToolStripDropDownButton indicatoriTsBtn;
        private System.Windows.Forms.ToolStripMenuItem medieMobilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medieMobilaExponentialaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volatilitateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volumToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton printScreenTsBtn;
        private System.Windows.Forms.ToolStripButton fullScreenTsBtn;
        private System.Windows.Forms.ToolStripButton zoomInTsBtn;
        private System.Windows.Forms.ToolStripButton zoomOutTsBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton eraseTsBtn;
        private System.Windows.Forms.ToolStripButton textTsBtn;
        private System.Windows.Forms.ToolStripDropDownButton drawTsBtn;
        private System.Windows.Forms.ToolStripMenuItem linieTsBtn;
        private System.Windows.Forms.ToolStripMenuItem dreptunghiTsBtn;
        private System.Windows.Forms.ToolStripMenuItem triunghiTsBtn;
        private System.Windows.Forms.ToolStripMenuItem elipsaTsBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton setariTsBtn;
        private System.Windows.Forms.Panel panel1;
        private Grafic graficUC;
    }
}
