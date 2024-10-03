namespace HastaneKayit
{
    partial class Enyakınhastane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enyakınhastane));
            this.frm1kapat = new System.Windows.Forms.Button();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hstnlergoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // frm1kapat
            // 
            this.frm1kapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("frm1kapat.BackgroundImage")));
            this.frm1kapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frm1kapat.FlatAppearance.BorderSize = 0;
            this.frm1kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frm1kapat.Location = new System.Drawing.Point(1033, 12);
            this.frm1kapat.Name = "frm1kapat";
            this.frm1kapat.Size = new System.Drawing.Size(57, 51);
            this.frm1kapat.TabIndex = 19;
            this.frm1kapat.UseVisualStyleBackColor = true;
            this.frm1kapat.Click += new System.EventHandler(this.frm1kapat_Click);
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(-1, 0);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 20;
            this.gmap.MinZoom = 1;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(917, 701);
            this.gmap.TabIndex = 20;
            this.gmap.Zoom = 0D;
            this.gmap.Load += new System.EventHandler(this.gmap_Load);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(951, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 39);
            this.button1.TabIndex = 21;
            this.button1.Text = "Konumumu Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(951, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(25, 20);
            this.textBox2.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(982, 92);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(19, 20);
            this.textBox3.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(948, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 26;
            // 
            // hstnlergoster
            // 
            this.hstnlergoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hstnlergoster.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.hstnlergoster.Location = new System.Drawing.Point(951, 229);
            this.hstnlergoster.Name = "hstnlergoster";
            this.hstnlergoster.Size = new System.Drawing.Size(139, 37);
            this.hstnlergoster.TabIndex = 27;
            this.hstnlergoster.Text = "Hastaneleri Göster";
            this.hstnlergoster.UseVisualStyleBackColor = true;
            this.hstnlergoster.Click += new System.EventHandler(this.hstnlergoster_Click);
            // 
            // Enyakınhastane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1115, 713);
            this.Controls.Add(this.hstnlergoster);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gmap);
            this.Controls.Add(this.frm1kapat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Enyakınhastane";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enyakınhastane";
            this.Load += new System.EventHandler(this.Enyakınhastane_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button frm1kapat;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hstnlergoster;
    }
}