namespace Forecast
{
    partial class PaginaGrafic
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
            this.chartUserControl1 = new Forecast.ChartUserControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.creareGraficBtn = new System.Windows.Forms.Button();
            this.perecheValutaraGraficCb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartUserControl1
            // 
            this.chartUserControl1.Location = new System.Drawing.Point(0, 156);
            this.chartUserControl1.Name = "chartUserControl1";
            this.chartUserControl1.Size = new System.Drawing.Size(700, 361);
            this.chartUserControl1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(105)))), ((int)(((byte)(144)))));
            this.panel2.Controls.Add(this.creareGraficBtn);
            this.panel2.Controls.Add(this.perecheValutaraGraficCb);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(695, 99);
            this.panel2.TabIndex = 5;
            // 
            // creareGraficBtn
            // 
            this.creareGraficBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(105)))), ((int)(((byte)(144)))));
            this.creareGraficBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creareGraficBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.creareGraficBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creareGraficBtn.ForeColor = System.Drawing.Color.White;
            this.creareGraficBtn.Location = new System.Drawing.Point(205, 65);
            this.creareGraficBtn.Name = "creareGraficBtn";
            this.creareGraficBtn.Size = new System.Drawing.Size(132, 25);
            this.creareGraficBtn.TabIndex = 9;
            this.creareGraficBtn.Text = "Creare grafic";
            this.creareGraficBtn.UseVisualStyleBackColor = false;
            // 
            // perecheValutaraGraficCb
            // 
            this.perecheValutaraGraficCb.FormattingEnabled = true;
            this.perecheValutaraGraficCb.Location = new System.Drawing.Point(147, 30);
            this.perecheValutaraGraficCb.Name = "perecheValutaraGraficCb";
            this.perecheValutaraGraficCb.Size = new System.Drawing.Size(190, 23);
            this.perecheValutaraGraficCb.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(11, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Pereche valutara";
            // 
            // paginaGrafic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chartUserControl1);
            this.Name = "paginaGrafic";
            this.Size = new System.Drawing.Size(700, 520);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ChartUserControl chartUserControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button creareGraficBtn;
        private System.Windows.Forms.ComboBox perecheValutaraGraficCb;
        private System.Windows.Forms.Label label7;
    }
}
