namespace Forecast
{
    partial class AdaugaValoriForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdaugaValoriForm));
            this.perecheValutaraLb = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.closeTb = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lowTb = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.highTb = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.openTb = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dataDtp = new Bunifu.Framework.UI.BunifuDatepicker();
            this.closeLb = new System.Windows.Forms.Label();
            this.lowLb = new System.Windows.Forms.Label();
            this.highLb = new System.Windows.Forms.Label();
            this.openLb = new System.Windows.Forms.Label();
            this.dataLb = new System.Windows.Forms.Label();
            this.dataErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.openErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.highErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lowErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.closeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.perecheValutaraPb = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perecheValutaraPb)).BeginInit();
            this.SuspendLayout();
            // 
            // perecheValutaraLb
            // 
            this.perecheValutaraLb.AutoSize = true;
            this.perecheValutaraLb.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.perecheValutaraLb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.perecheValutaraLb.Location = new System.Drawing.Point(91, 25);
            this.perecheValutaraLb.Name = "perecheValutaraLb";
            this.perecheValutaraLb.Size = new System.Drawing.Size(101, 18);
            this.perecheValutaraLb.TabIndex = 0;
            this.perecheValutaraLb.Text = "perecheValutara";
            this.perecheValutaraLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.closeTb);
            this.groupBox1.Controls.Add(this.lowTb);
            this.groupBox1.Controls.Add(this.highTb);
            this.groupBox1.Controls.Add(this.openTb);
            this.groupBox1.Controls.Add(this.dataDtp);
            this.groupBox1.Controls.Add(this.closeLb);
            this.groupBox1.Controls.Add(this.lowLb);
            this.groupBox1.Controls.Add(this.highLb);
            this.groupBox1.Controls.Add(this.openLb);
            this.groupBox1.Controls.Add(this.dataLb);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(9, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 193);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valori";
            // 
            // closeTb
            // 
            this.closeTb.BorderColorFocused = System.Drawing.Color.DarkSlateBlue;
            this.closeTb.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.closeTb.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.closeTb.BorderThickness = 2;
            this.closeTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.closeTb.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeTb.ForeColor = System.Drawing.Color.Black;
            this.closeTb.isPassword = false;
            this.closeTb.Location = new System.Drawing.Point(85, 149);
            this.closeTb.Margin = new System.Windows.Forms.Padding(4);
            this.closeTb.Name = "closeTb";
            this.closeTb.Size = new System.Drawing.Size(200, 25);
            this.closeTb.TabIndex = 10;
            this.closeTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lowTb
            // 
            this.lowTb.BorderColorFocused = System.Drawing.Color.DarkSlateBlue;
            this.lowTb.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.lowTb.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.lowTb.BorderThickness = 2;
            this.lowTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lowTb.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lowTb.ForeColor = System.Drawing.Color.Black;
            this.lowTb.isPassword = false;
            this.lowTb.Location = new System.Drawing.Point(85, 119);
            this.lowTb.Margin = new System.Windows.Forms.Padding(4);
            this.lowTb.Name = "lowTb";
            this.lowTb.Size = new System.Drawing.Size(200, 25);
            this.lowTb.TabIndex = 9;
            this.lowTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // highTb
            // 
            this.highTb.BorderColorFocused = System.Drawing.Color.DarkSlateBlue;
            this.highTb.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.highTb.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.highTb.BorderThickness = 2;
            this.highTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.highTb.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.highTb.ForeColor = System.Drawing.Color.Black;
            this.highTb.isPassword = false;
            this.highTb.Location = new System.Drawing.Point(85, 89);
            this.highTb.Margin = new System.Windows.Forms.Padding(4);
            this.highTb.Name = "highTb";
            this.highTb.Size = new System.Drawing.Size(200, 25);
            this.highTb.TabIndex = 8;
            this.highTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // openTb
            // 
            this.openTb.BorderColorFocused = System.Drawing.Color.DarkSlateBlue;
            this.openTb.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.openTb.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.openTb.BorderThickness = 2;
            this.openTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.openTb.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.openTb.ForeColor = System.Drawing.Color.Black;
            this.openTb.isPassword = false;
            this.openTb.Location = new System.Drawing.Point(85, 59);
            this.openTb.Margin = new System.Windows.Forms.Padding(4);
            this.openTb.Name = "openTb";
            this.openTb.Size = new System.Drawing.Size(200, 25);
            this.openTb.TabIndex = 7;
            this.openTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dataDtp
            // 
            this.dataDtp.BackColor = System.Drawing.Color.SteelBlue;
            this.dataDtp.BorderRadius = 5;
            this.dataDtp.ForeColor = System.Drawing.Color.White;
            this.dataDtp.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dataDtp.FormatCustom = null;
            this.dataDtp.Location = new System.Drawing.Point(85, 30);
            this.dataDtp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataDtp.Name = "dataDtp";
            this.dataDtp.Size = new System.Drawing.Size(199, 25);
            this.dataDtp.TabIndex = 6;
            this.dataDtp.Value = new System.DateTime(2018, 5, 20, 0, 0, 0, 0);
            // 
            // closeLb
            // 
            this.closeLb.AutoSize = true;
            this.closeLb.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeLb.Location = new System.Drawing.Point(15, 155);
            this.closeLb.Name = "closeLb";
            this.closeLb.Size = new System.Drawing.Size(66, 16);
            this.closeLb.TabIndex = 5;
            this.closeLb.Text = "Close Price";
            // 
            // lowLb
            // 
            this.lowLb.AutoSize = true;
            this.lowLb.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lowLb.Location = new System.Drawing.Point(15, 125);
            this.lowLb.Name = "lowLb";
            this.lowLb.Size = new System.Drawing.Size(60, 16);
            this.lowLb.TabIndex = 4;
            this.lowLb.Text = "Low Price";
            // 
            // highLb
            // 
            this.highLb.AutoSize = true;
            this.highLb.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.highLb.Location = new System.Drawing.Point(15, 95);
            this.highLb.Name = "highLb";
            this.highLb.Size = new System.Drawing.Size(62, 16);
            this.highLb.TabIndex = 3;
            this.highLb.Text = "High Price";
            // 
            // openLb
            // 
            this.openLb.AutoSize = true;
            this.openLb.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.openLb.Location = new System.Drawing.Point(15, 65);
            this.openLb.Name = "openLb";
            this.openLb.Size = new System.Drawing.Size(64, 16);
            this.openLb.TabIndex = 2;
            this.openLb.Text = "Open Price";
            // 
            // dataLb
            // 
            this.dataLb.AutoSize = true;
            this.dataLb.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataLb.Location = new System.Drawing.Point(15, 35);
            this.dataLb.Name = "dataLb";
            this.dataLb.Size = new System.Drawing.Size(30, 16);
            this.dataLb.TabIndex = 1;
            this.dataLb.Text = "Data";
            // 
            // dataErrorProvider
            // 
            this.dataErrorProvider.ContainerControl = this;
            // 
            // openErrorProvider
            // 
            this.openErrorProvider.ContainerControl = this;
            // 
            // highErrorProvider
            // 
            this.highErrorProvider.ContainerControl = this;
            // 
            // lowErrorProvider
            // 
            this.lowErrorProvider.ContainerControl = this;
            // 
            // closeErrorProvider
            // 
            this.closeErrorProvider.ContainerControl = this;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Image = ((System.Drawing.Image)(resources.GetObject("cancelBtn.Image")));
            this.cancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelBtn.Location = new System.Drawing.Point(285, 264);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 25);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Anulează";
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.okBtn.ForeColor = System.Drawing.Color.White;
            this.okBtn.Image = ((System.Drawing.Image)(resources.GetObject("okBtn.Image")));
            this.okBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.okBtn.Location = new System.Drawing.Point(179, 264);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(100, 25);
            this.okBtn.TabIndex = 6;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.perecheValutaraPb);
            this.panel1.Controls.Add(this.perecheValutaraLb);
            this.panel1.Controls.Add(this.okBtn);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 304);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdaugaValoriForm_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AdaugaValoriForm_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AdaugaValoriForm_MouseUp);
            // 
            // perecheValutaraPb
            // 
            this.perecheValutaraPb.Image = ((System.Drawing.Image)(resources.GetObject("perecheValutaraPb.Image")));
            this.perecheValutaraPb.InitialImage = null;
            this.perecheValutaraPb.Location = new System.Drawing.Point(9, 9);
            this.perecheValutaraPb.Name = "perecheValutaraPb";
            this.perecheValutaraPb.Size = new System.Drawing.Size(59, 50);
            this.perecheValutaraPb.TabIndex = 7;
            this.perecheValutaraPb.TabStop = false;
            // 
            // AdaugaValoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(406, 310);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdaugaValoriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdaugaValoriForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AdaugaValoriForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AdaugaValoriForm_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perecheValutaraPb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label perecheValutaraLb;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox closeTb;
        private Bunifu.Framework.UI.BunifuMetroTextbox lowTb;
        private Bunifu.Framework.UI.BunifuMetroTextbox highTb;
        private Bunifu.Framework.UI.BunifuMetroTextbox openTb;
        private Bunifu.Framework.UI.BunifuDatepicker dataDtp;
        private System.Windows.Forms.Label closeLb;
        private System.Windows.Forms.Label lowLb;
        private System.Windows.Forms.Label highLb;
        private System.Windows.Forms.Label openLb;
        private System.Windows.Forms.Label dataLb;
        private System.Windows.Forms.ErrorProvider dataErrorProvider;
        private System.Windows.Forms.ErrorProvider openErrorProvider;
        private System.Windows.Forms.ErrorProvider highErrorProvider;
        private System.Windows.Forms.ErrorProvider lowErrorProvider;
        private System.Windows.Forms.ErrorProvider closeErrorProvider;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox perecheValutaraPb;
    }
}