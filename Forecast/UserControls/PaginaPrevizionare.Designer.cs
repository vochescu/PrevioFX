namespace Forecast
{
    partial class PaginaPrevizionare
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.previzionareDtp = new Bunifu.Framework.UI.BunifuDatepicker();
            this.previzionareDataDtp = new Bunifu.Framework.UI.BunifuDatepicker();
            this.perecheValutaraPrevizionareCb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.previzionareBtn = new System.Windows.Forms.Button();
            this.revizuireCb = new System.Windows.Forms.ComboBox();
            this.modelCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chartUserControl1 = new Forecast.ChartUserControl();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(193)))), ((int)(((byte)(120)))));
            this.panel3.Controls.Add(this.previzionareDtp);
            this.panel3.Controls.Add(this.previzionareDataDtp);
            this.panel3.Controls.Add(this.perecheValutaraPrevizionareCb);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.previzionareBtn);
            this.panel3.Controls.Add(this.revizuireCb);
            this.panel3.Controls.Add(this.modelCb);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(695, 149);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // previzionareDtp
            // 
            this.previzionareDtp.BackColor = System.Drawing.Color.White;
            this.previzionareDtp.BorderRadius = 0;
            this.previzionareDtp.ForeColor = System.Drawing.Color.Black;
            this.previzionareDtp.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.previzionareDtp.FormatCustom = null;
            this.previzionareDtp.Location = new System.Drawing.Point(475, 25);
            this.previzionareDtp.Name = "previzionareDtp";
            this.previzionareDtp.Size = new System.Drawing.Size(200, 23);
            this.previzionareDtp.TabIndex = 13;
            this.previzionareDtp.Value = new System.DateTime(2018, 5, 18, 19, 51, 17, 701);
            this.previzionareDtp.onValueChanged += new System.EventHandler(this.previzionareDtp_onValueChanged);
            // 
            // previzionareDataDtp
            // 
            this.previzionareDataDtp.BackColor = System.Drawing.Color.White;
            this.previzionareDataDtp.BorderRadius = 0;
            this.previzionareDataDtp.ForeColor = System.Drawing.Color.Black;
            this.previzionareDataDtp.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.previzionareDataDtp.FormatCustom = null;
            this.previzionareDataDtp.Location = new System.Drawing.Point(137, 65);
            this.previzionareDataDtp.Name = "previzionareDataDtp";
            this.previzionareDataDtp.Size = new System.Drawing.Size(200, 23);
            this.previzionareDataDtp.TabIndex = 12;
            this.previzionareDataDtp.Value = new System.DateTime(2018, 5, 18, 19, 51, 17, 701);
            this.previzionareDataDtp.onValueChanged += new System.EventHandler(this.previzionareDataDtp_onValueChanged);
            // 
            // perecheValutaraPrevizionareCb
            // 
            this.perecheValutaraPrevizionareCb.FormattingEnabled = true;
            this.perecheValutaraPrevizionareCb.Location = new System.Drawing.Point(137, 25);
            this.perecheValutaraPrevizionareCb.Name = "perecheValutaraPrevizionareCb";
            this.perecheValutaraPrevizionareCb.Size = new System.Drawing.Size(200, 23);
            this.perecheValutaraPrevizionareCb.TabIndex = 11;
            this.perecheValutaraPrevizionareCb.SelectedIndexChanged += new System.EventHandler(this.perecheValutaraPrevizionareCb_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pereche valutara";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // previzionareBtn
            // 
            this.previzionareBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(193)))), ((int)(((byte)(120)))));
            this.previzionareBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previzionareBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.previzionareBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previzionareBtn.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.previzionareBtn.ForeColor = System.Drawing.Color.White;
            this.previzionareBtn.Location = new System.Drawing.Point(575, 104);
            this.previzionareBtn.Name = "previzionareBtn";
            this.previzionareBtn.Size = new System.Drawing.Size(100, 23);
            this.previzionareBtn.TabIndex = 9;
            this.previzionareBtn.Text = "Previzionare";
            this.previzionareBtn.UseVisualStyleBackColor = false;
            this.previzionareBtn.Click += new System.EventHandler(this.previzionareBtn_Click);
            // 
            // revizuireCb
            // 
            this.revizuireCb.FormattingEnabled = true;
            this.revizuireCb.Location = new System.Drawing.Point(475, 61);
            this.revizuireCb.Name = "revizuireCb";
            this.revizuireCb.Size = new System.Drawing.Size(200, 23);
            this.revizuireCb.TabIndex = 7;
            this.revizuireCb.SelectedIndexChanged += new System.EventHandler(this.revizuireCb_SelectedIndexChanged);
            // 
            // modelCb
            // 
            this.modelCb.FormattingEnabled = true;
            this.modelCb.Location = new System.Drawing.Point(137, 100);
            this.modelCb.Name = "modelCb";
            this.modelCb.Size = new System.Drawing.Size(200, 23);
            this.modelCb.TabIndex = 4;
            this.modelCb.SelectedIndexChanged += new System.EventHandler(this.modelCb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(387, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Revizuire";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(387, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Previzionare";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chartUserControl1
            // 
            this.chartUserControl1.Location = new System.Drawing.Point(0, 159);
            this.chartUserControl1.Name = "chartUserControl1";
            this.chartUserControl1.Size = new System.Drawing.Size(700, 361);
            this.chartUserControl1.TabIndex = 4;
            // 
            // paginaPrevizionare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.chartUserControl1);
            this.Name = "paginaPrevizionare";
            this.Size = new System.Drawing.Size(700, 520);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ChartUserControl chartUserControl1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuDatepicker previzionareDataDtp;
        private System.Windows.Forms.ComboBox perecheValutaraPrevizionareCb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button previzionareBtn;
        private System.Windows.Forms.ComboBox revizuireCb;
        private System.Windows.Forms.ComboBox modelCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker previzionareDtp;
    }
}
