namespace Forecast
{
    partial class EcranPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranPrincipal));
            this.meniuLateralPanel = new System.Windows.Forms.Panel();
            this.sumarBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.descriereLabel = new System.Windows.Forms.Label();
            this.ajutorBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.previzionareBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.dateBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.graficBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.meniuBarPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.minimizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.meniuBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.paginaDate = new Forecast.PaginaDate();
            this.paginaPrevizionare = new Forecast.PaginaPrevizionare();
            this.paginaGrafic = new Forecast.PaginaGrafic();
            this.paginaSumar = new Forecast.UserControlForms.PaginaSumar();
            this.meniuLateralPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.meniuBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meniuBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // meniuLateralPanel
            // 
            this.meniuLateralPanel.BackColor = System.Drawing.Color.White;
            this.meniuLateralPanel.Controls.Add(this.sumarBtn);
            this.meniuLateralPanel.Controls.Add(this.descriereLabel);
            this.meniuLateralPanel.Controls.Add(this.ajutorBtn);
            this.meniuLateralPanel.Controls.Add(this.previzionareBtn);
            this.meniuLateralPanel.Controls.Add(this.logoPictureBox);
            this.meniuLateralPanel.Controls.Add(this.dateBtn);
            this.meniuLateralPanel.Controls.Add(this.graficBtn);
            this.meniuLateralPanel.Location = new System.Drawing.Point(0, 29);
            this.meniuLateralPanel.Name = "meniuLateralPanel";
            this.meniuLateralPanel.Size = new System.Drawing.Size(200, 523);
            this.meniuLateralPanel.TabIndex = 0;
            // 
            // sumarBtn
            // 
            this.sumarBtn.Activecolor = System.Drawing.Color.White;
            this.sumarBtn.BackColor = System.Drawing.Color.White;
            this.sumarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sumarBtn.BorderRadius = 0;
            this.sumarBtn.ButtonText = "       Sumar";
            this.sumarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sumarBtn.DisabledColor = System.Drawing.Color.Gray;
            this.sumarBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.sumarBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("sumarBtn.Iconimage")));
            this.sumarBtn.Iconimage_right = null;
            this.sumarBtn.Iconimage_right_Selected = null;
            this.sumarBtn.Iconimage_Selected = null;
            this.sumarBtn.IconMarginLeft = 0;
            this.sumarBtn.IconMarginRight = 0;
            this.sumarBtn.IconRightVisible = true;
            this.sumarBtn.IconRightZoom = 0D;
            this.sumarBtn.IconVisible = true;
            this.sumarBtn.IconZoom = 60D;
            this.sumarBtn.IsTab = false;
            this.sumarBtn.Location = new System.Drawing.Point(0, 340);
            this.sumarBtn.Name = "sumarBtn";
            this.sumarBtn.Normalcolor = System.Drawing.Color.White;
            this.sumarBtn.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.sumarBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.sumarBtn.selected = false;
            this.sumarBtn.Size = new System.Drawing.Size(200, 50);
            this.sumarBtn.TabIndex = 8;
            this.sumarBtn.Text = "       Sumar";
            this.sumarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sumarBtn.Textcolor = System.Drawing.Color.Black;
            this.sumarBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumarBtn.Click += new System.EventHandler(this.sumarBtn_Click);
            // 
            // descriereLabel
            // 
            this.descriereLabel.AutoSize = true;
            this.descriereLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(220)))), ((int)(((byte)(61)))));
            this.descriereLabel.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descriereLabel.ForeColor = System.Drawing.Color.White;
            this.descriereLabel.Location = new System.Drawing.Point(25, 130);
            this.descriereLabel.Name = "descriereLabel";
            this.descriereLabel.Size = new System.Drawing.Size(173, 18);
            this.descriereLabel.TabIndex = 7;
            this.descriereLabel.Text = "Analizează. Previzionează.";
            // 
            // ajutorBtn
            // 
            this.ajutorBtn.Activecolor = System.Drawing.Color.White;
            this.ajutorBtn.BackColor = System.Drawing.Color.White;
            this.ajutorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ajutorBtn.BorderRadius = 0;
            this.ajutorBtn.ButtonText = "       Despre";
            this.ajutorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ajutorBtn.DisabledColor = System.Drawing.Color.Gray;
            this.ajutorBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.ajutorBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("ajutorBtn.Iconimage")));
            this.ajutorBtn.Iconimage_right = null;
            this.ajutorBtn.Iconimage_right_Selected = null;
            this.ajutorBtn.Iconimage_Selected = null;
            this.ajutorBtn.IconMarginLeft = 0;
            this.ajutorBtn.IconMarginRight = 0;
            this.ajutorBtn.IconRightVisible = true;
            this.ajutorBtn.IconRightZoom = 0D;
            this.ajutorBtn.IconVisible = true;
            this.ajutorBtn.IconZoom = 60D;
            this.ajutorBtn.IsTab = false;
            this.ajutorBtn.Location = new System.Drawing.Point(0, 400);
            this.ajutorBtn.Name = "ajutorBtn";
            this.ajutorBtn.Normalcolor = System.Drawing.Color.White;
            this.ajutorBtn.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.ajutorBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.ajutorBtn.selected = false;
            this.ajutorBtn.Size = new System.Drawing.Size(200, 50);
            this.ajutorBtn.TabIndex = 6;
            this.ajutorBtn.Text = "       Despre";
            this.ajutorBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ajutorBtn.Textcolor = System.Drawing.Color.Black;
            this.ajutorBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajutorBtn.Click += new System.EventHandler(this.ajutorBtn_Click);
            // 
            // previzionareBtn
            // 
            this.previzionareBtn.Activecolor = System.Drawing.Color.White;
            this.previzionareBtn.BackColor = System.Drawing.Color.White;
            this.previzionareBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previzionareBtn.BorderRadius = 0;
            this.previzionareBtn.ButtonText = "       Previzionare";
            this.previzionareBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previzionareBtn.DisabledColor = System.Drawing.Color.Gray;
            this.previzionareBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.previzionareBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("previzionareBtn.Iconimage")));
            this.previzionareBtn.Iconimage_right = null;
            this.previzionareBtn.Iconimage_right_Selected = null;
            this.previzionareBtn.Iconimage_Selected = null;
            this.previzionareBtn.IconMarginLeft = 0;
            this.previzionareBtn.IconMarginRight = 0;
            this.previzionareBtn.IconRightVisible = true;
            this.previzionareBtn.IconRightZoom = 0D;
            this.previzionareBtn.IconVisible = true;
            this.previzionareBtn.IconZoom = 60D;
            this.previzionareBtn.IsTab = false;
            this.previzionareBtn.Location = new System.Drawing.Point(0, 280);
            this.previzionareBtn.Name = "previzionareBtn";
            this.previzionareBtn.Normalcolor = System.Drawing.Color.White;
            this.previzionareBtn.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.previzionareBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.previzionareBtn.selected = false;
            this.previzionareBtn.Size = new System.Drawing.Size(200, 50);
            this.previzionareBtn.TabIndex = 5;
            this.previzionareBtn.Text = "       Previzionare";
            this.previzionareBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.previzionareBtn.Textcolor = System.Drawing.Color.Black;
            this.previzionareBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previzionareBtn.Click += new System.EventHandler(this.previzionareBtn_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(220)))), ((int)(((byte)(61)))));
            this.logoPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.BackgroundImage")));
            this.logoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPictureBox.InitialImage = null;
            this.logoPictureBox.Location = new System.Drawing.Point(0, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(200, 150);
            this.logoPictureBox.TabIndex = 4;
            this.logoPictureBox.TabStop = false;
            // 
            // dateBtn
            // 
            this.dateBtn.Activecolor = System.Drawing.Color.White;
            this.dateBtn.BackColor = System.Drawing.Color.White;
            this.dateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dateBtn.BorderRadius = 0;
            this.dateBtn.ButtonText = "       Date";
            this.dateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateBtn.DisabledColor = System.Drawing.Color.Gray;
            this.dateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.dateBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("dateBtn.Iconimage")));
            this.dateBtn.Iconimage_right = null;
            this.dateBtn.Iconimage_right_Selected = null;
            this.dateBtn.Iconimage_Selected = null;
            this.dateBtn.IconMarginLeft = 0;
            this.dateBtn.IconMarginRight = 0;
            this.dateBtn.IconRightVisible = true;
            this.dateBtn.IconRightZoom = 0D;
            this.dateBtn.IconVisible = true;
            this.dateBtn.IconZoom = 60D;
            this.dateBtn.IsTab = false;
            this.dateBtn.Location = new System.Drawing.Point(0, 160);
            this.dateBtn.Name = "dateBtn";
            this.dateBtn.Normalcolor = System.Drawing.Color.White;
            this.dateBtn.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.dateBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.dateBtn.selected = false;
            this.dateBtn.Size = new System.Drawing.Size(200, 50);
            this.dateBtn.TabIndex = 3;
            this.dateBtn.Text = "       Date";
            this.dateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dateBtn.Textcolor = System.Drawing.Color.Black;
            this.dateBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBtn.Click += new System.EventHandler(this.dateBtn_Click);
            // 
            // graficBtn
            // 
            this.graficBtn.Activecolor = System.Drawing.Color.White;
            this.graficBtn.BackColor = System.Drawing.Color.White;
            this.graficBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.graficBtn.BorderRadius = 0;
            this.graficBtn.ButtonText = "       Grafic";
            this.graficBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.graficBtn.DisabledColor = System.Drawing.Color.Gray;
            this.graficBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.graficBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("graficBtn.Iconimage")));
            this.graficBtn.Iconimage_right = null;
            this.graficBtn.Iconimage_right_Selected = null;
            this.graficBtn.Iconimage_Selected = null;
            this.graficBtn.IconMarginLeft = 0;
            this.graficBtn.IconMarginRight = 0;
            this.graficBtn.IconRightVisible = true;
            this.graficBtn.IconRightZoom = 0D;
            this.graficBtn.IconVisible = true;
            this.graficBtn.IconZoom = 60D;
            this.graficBtn.IsTab = false;
            this.graficBtn.Location = new System.Drawing.Point(0, 220);
            this.graficBtn.Name = "graficBtn";
            this.graficBtn.Normalcolor = System.Drawing.Color.White;
            this.graficBtn.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.graficBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.graficBtn.selected = false;
            this.graficBtn.Size = new System.Drawing.Size(200, 50);
            this.graficBtn.TabIndex = 2;
            this.graficBtn.Text = "       Grafic";
            this.graficBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.graficBtn.Textcolor = System.Drawing.Color.Black;
            this.graficBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graficBtn.Click += new System.EventHandler(this.graficBtn_Click);
            // 
            // meniuBarPanel
            // 
            this.meniuBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(105)))), ((int)(((byte)(144)))));
            this.meniuBarPanel.Controls.Add(this.label2);
            this.meniuBarPanel.Controls.Add(this.minimizeBtn);
            this.meniuBarPanel.Controls.Add(this.closeBtn);
            this.meniuBarPanel.Controls.Add(this.meniuBtn);
            this.meniuBarPanel.Location = new System.Drawing.Point(0, -7);
            this.meniuBarPanel.Name = "meniuBarPanel";
            this.meniuBarPanel.Size = new System.Drawing.Size(900, 40);
            this.meniuBarPanel.TabIndex = 1;
            this.meniuBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.meniuBarPanel_MouseDown);
            this.meniuBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.meniuBarPanel_MouseMove);
            this.meniuBarPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.meniuBarPanel_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Previo";
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(105)))), ((int)(((byte)(144)))));
            this.minimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.Image")));
            this.minimizeBtn.ImageActive = null;
            this.minimizeBtn.Location = new System.Drawing.Point(842, 12);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(20, 20);
            this.minimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeBtn.TabIndex = 4;
            this.minimizeBtn.TabStop = false;
            this.minimizeBtn.Zoom = 10;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(105)))), ((int)(((byte)(144)))));
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.ImageActive = null;
            this.closeBtn.Location = new System.Drawing.Point(868, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(20, 20);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 3;
            this.closeBtn.TabStop = false;
            this.closeBtn.Zoom = 10;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // meniuBtn
            // 
            this.meniuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(105)))), ((int)(((byte)(144)))));
            this.meniuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.meniuBtn.Image = ((System.Drawing.Image)(resources.GetObject("meniuBtn.Image")));
            this.meniuBtn.ImageActive = null;
            this.meniuBtn.Location = new System.Drawing.Point(12, 12);
            this.meniuBtn.Name = "meniuBtn";
            this.meniuBtn.Size = new System.Drawing.Size(25, 25);
            this.meniuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.meniuBtn.TabIndex = 2;
            this.meniuBtn.TabStop = false;
            this.meniuBtn.Zoom = 10;
            this.meniuBtn.Click += new System.EventHandler(this.meniuBtn_Click);
            // 
            // paginaDate
            // 
            this.paginaDate.AllowDrop = true;
            this.paginaDate.BackColor = System.Drawing.Color.Ivory;
            this.paginaDate.Location = new System.Drawing.Point(200, 33);
            this.paginaDate.Name = "paginaDate";
            this.paginaDate.Size = new System.Drawing.Size(700, 520);
            this.paginaDate.TabIndex = 2;
            // 
            // paginaPrevizionare
            // 
            this.paginaPrevizionare.BackColor = System.Drawing.Color.Ivory;
            this.paginaPrevizionare.Location = new System.Drawing.Point(200, 33);
            this.paginaPrevizionare.Name = "paginaPrevizionare";
            this.paginaPrevizionare.Size = new System.Drawing.Size(700, 520);
            this.paginaPrevizionare.TabIndex = 4;
            // 
            // paginaGrafic
            // 
            this.paginaGrafic.BackColor = System.Drawing.Color.Ivory;
            this.paginaGrafic.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.paginaGrafic.Location = new System.Drawing.Point(200, 33);
            this.paginaGrafic.Name = "paginaGrafic";
            this.paginaGrafic.Size = new System.Drawing.Size(700, 520);
            this.paginaGrafic.TabIndex = 3;
            // 
            // paginaSumar
            // 
            this.paginaSumar.AllowDrop = true;
            this.paginaSumar.Location = new System.Drawing.Point(200, 33);
            this.paginaSumar.Name = "paginaSumar";
            this.paginaSumar.Size = new System.Drawing.Size(700, 520);
            this.paginaSumar.TabIndex = 5;
            // 
            // EcranPrincipal
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.meniuBarPanel);
            this.Controls.Add(this.meniuLateralPanel);
            this.Controls.Add(this.paginaDate);
            this.Controls.Add(this.paginaSumar);
            this.Controls.Add(this.paginaPrevizionare);
            this.Controls.Add(this.paginaGrafic);
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EcranPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Previo";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.EcranPrincipal_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.EcranPrincipal_DragEnter);
            this.meniuLateralPanel.ResumeLayout(false);
            this.meniuLateralPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.meniuBarPanel.ResumeLayout(false);
            this.meniuBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meniuBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel meniuLateralPanel;
        private Bunifu.Framework.UI.BunifuFlatButton graficBtn;
        private Bunifu.Framework.UI.BunifuImageButton meniuBtn;
        private System.Windows.Forms.Panel meniuBarPanel;
        private Bunifu.Framework.UI.BunifuFlatButton dateBtn;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label descriereLabel;
        private Bunifu.Framework.UI.BunifuFlatButton ajutorBtn;
        private Bunifu.Framework.UI.BunifuFlatButton previzionareBtn;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private Bunifu.Framework.UI.BunifuImageButton minimizeBtn;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton sumarBtn;
        private PaginaDate paginaDate;
        private PaginaGrafic paginaGrafic;
        private PaginaPrevizionare paginaPrevizionare;
        private UserControlForms.PaginaSumar paginaSumar;
    }
}